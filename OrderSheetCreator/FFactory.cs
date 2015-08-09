using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderSheetCreator
{
    public partial class FFactory : Form
    {
        entity.CainzOrderDetail fd;
        private string FFACTORY_DATAGRIDVIEW_SETPATH = "客户查询表宽度设定.txt";

        public FFactory()
        {
            InitializeComponent();
        }

        public FFactory(entity.CainzOrderDetail fd)
        {
            InitializeComponent();
            this.fd = fd;

        }


        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (txbSearch.Text.Length > 0)
            {
                using (var db = new entity.DB())
                {
                    var Query = from a in db.CainzFactory
                                       where a.FactoryName.Contains(txbSearch.Text) || a.FactoryNameJP.Contains(txbSearch.Text)
                                       select a;
                    if(Query !=null)
                        CainzFactoryBindingSource.DataSource = Query.Take(8).ToList();

                }
                PublicTools.RecountRowsNum(dataGridView1);
            }
            else
            {
                CainzFactoryBindingSource.DataSource = new List<entity.CainzFactory>();
            }
        }

        private void FFactory_Load(object sender, EventArgs e)
        {
            PublicTools.IniDatagridview(dataGridView1);
            PublicTools.SetColumsAutoModeNone(dataGridView1);
            PublicTools.RecoverColumnWidth(dataGridView1, this.FFACTORY_DATAGRIDVIEW_SETPATH);
            panel4.Visible = false;
        }

        private void FFactory_FormClosing(object sender, FormClosingEventArgs e)
        {
            PublicTools.SaveColumnWidth(dataGridView1, this.FFACTORY_DATAGRIDVIEW_SETPATH);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FCainzOrderD.FACTORY = (entity.CainzFactory)CainzFactoryBindingSource.Current;
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOK_Click(null, null);
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否修改数据库，点击，YES，后修改不可恢复", "谨慎操作", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new entity.DB())
                {
                    entity.CainzFactory cp = (entity.CainzFactory)CainzFactoryBindingSource.Current;
                    db.CainzFactory.Attach(cp);
                    db.Entry(cp).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                }
                this.txbSearch_TextChanged(null,null);
            }
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.Height = 49;
        }
    }
}
