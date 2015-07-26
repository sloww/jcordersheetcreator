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
    public partial class FCainzOrderD : Form
    {
        public static BindingList<entity.CainzOrderDetail> ORDERDETAILLIST = new BindingList<entity.CainzOrderDetail>();
        FAdd fadd = new FAdd();
        private string FCainzOrderDdataGridViewSetPath = "订单表宽度设定.txt";
        public FCainzOrderD()
        {
            InitializeComponent();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FCainzOrderD_Load(object sender, EventArgs e)
        {
            PublicTools.IniDatagridview(dataGridView1);
            PublicTools.SetColumsAutoModeNone(dataGridView1);
            cainzOrderDetailBindingSource.DataSource = ORDERDETAILLIST;
            PublicTools.RecoverColumnWidth(dataGridView1, FCainzOrderDdataGridViewSetPath);
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            fadd.ShowDialog();
            PublicTools.RecountRowsNum(dataGridView1);
           
        }

        private void FCainzOrderD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                tsbNew_Click(null, null);
            }
        }


        private void FCainzOrderD_FormClosing(object sender, FormClosingEventArgs e)
        {
            PublicTools.SaveColumnWidth(dataGridView1, this.FCainzOrderDdataGridViewSetPath);
        }
    }
}
