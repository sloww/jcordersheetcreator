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
        FCainzOrderD fd;
        private string FFACTORY_DATAGRIDVIEW_SETPATH = "客户查询表宽度设定.txt";

        public FFactory()
        {
            InitializeComponent();
        }

        public FFactory(FCainzOrderD fd)
        {
            InitializeComponent();
            this.fd = fd;

        }


        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (txbSearch.Text.Length > 0)
            {
                using (var db = new entity.jingchendbEntities())
                {
                    var Query = from a in db.CainzCustomer
                                       where a.FactoryName.Contains(txbSearch.Text) || a.FactoryNameJP.Contains(txbSearch.Text)
                                       select a;
                    cainzCustomerBindingSource.DataSource = Query.Take(8).ToList();

                }
                PublicTools.RecountRowsNum(dataGridView1);
            }
            else
            {
                cainzCustomerBindingSource.DataSource = new List<entity.CainzCustomer>();
            }
        }

        private void FFactory_Load(object sender, EventArgs e)
        {
            PublicTools.IniDatagridview(dataGridView1);
            PublicTools.SetColumsAutoModeNone(dataGridView1);
            PublicTools.RecoverColumnWidth(dataGridView1, this.FFACTORY_DATAGRIDVIEW_SETPATH);
        }

        private void FFactory_FormClosing(object sender, FormClosingEventArgs e)
        {
            PublicTools.SaveColumnWidth(dataGridView1, this.FFACTORY_DATAGRIDVIEW_SETPATH);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FCainzOrderD.CC =(entity.CainzCustomer) cainzCustomerBindingSource.Current;
            this.Close();
        }
    }
}
