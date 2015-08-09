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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCainzOrderD m = new FCainzOrderD();
            m.StartPosition = FormStartPosition.CenterParent;
            m.ShowDialog();
            OrderData_Load();

        }

        private void FMain_Load(object sender, EventArgs e)
        {
            PublicTools.IniDatagridview(dataGridView1);
            PublicTools.RecoverColumnWidth(dataGridView1, "Fmaindgv.config");
            OrderData_Load();
       
        }

        private void OrderData_Load()
        {
            using (var db = new entity.DB())
            {
                List<entity.CainzOrder> orderList = (from a in db.CainzOrder
                                                     where a.IsDelete == 0 && (a.Status==0||a.Status==1)
                                                     orderby a.OrderDate
                                                     select a).ToList();
                cainzOrderBindingSource.DataSource = orderList;
            }
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            PublicTools.SaveColumnWidth(dataGridView1, "Fmaindgv.config");
        }
    }
}
