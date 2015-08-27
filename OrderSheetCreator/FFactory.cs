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
        Dictionary<string, int> dicColumnWidth = new Dictionary<string, int>();

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
                using (var db = PublicDB.getDB())
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

            PublicTools.RecoverColumnWidth(dataGridView1, Program.Code, Program.AppName, this.Name);
            PublicTools.saveWidthTmp(dataGridView1, dicColumnWidth);
            panel4.Visible = false;
        }

        private void FFactory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(PublicTools.isWidthChange(dataGridView1,dicColumnWidth))
            {
                PublicTools.SaveColumnWidth(dataGridView1, Program.Code, Program.AppName, this.Name);
            }
           // PublicTools.SaveColumnWidth(dataGridView1, this.FFACTORY_DATAGRIDVIEW_SETPATH);

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
            if (MessageBox.Show("是否修改数据库，点击，YES，后修改不可恢复", "谨慎操作", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                using (var db = PublicDB.getDB())
                {
                    entity.CainzFactory cp = (entity.CainzFactory)CainzFactoryBindingSource.Current;
                    cp.ImageFile = txbFilePath.Text.Trim();
                    db.CainzFactory.Attach(cp);
                    db.Entry(cp).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                }
                this.txbSearch.Text = "";
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
            panel4.BringToFront();
            panel4.Height = 49;
        }

        private void btnAdvice_Click(object sender, EventArgs e)
        {
            entity.CainzFactory _factory =(entity.CainzFactory) CainzFactoryBindingSource.Current;
            if (_factory !=null)
            {
                txbFilePath.Text = string.Format("{0}-{1}", PublicTools.stringZip(_factory.TraderName), PublicTools.stringZip(_factory.FactoryName));
            }
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            entity.CainzFactory _fac = (entity.CainzFactory)CainzFactoryBindingSource.Current;
            if (_fac != null)
            {
                FAddress _faddress = new FAddress(_fac);
                _faddress.StartPosition = FormStartPosition.CenterParent;
                _faddress.ShowDialog();
            }
        }
    }
}
