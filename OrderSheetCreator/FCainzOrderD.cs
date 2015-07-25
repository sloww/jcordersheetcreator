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
            dataGridView1.AllowDrop = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;

            PublicTools.IniDatagridview(dataGridView1);

            cainzOrderDetailBindingSource.DataSource = ORDERDETAILLIST;

            //dataGridView1.Rows.Insert(0, "1", "459509116295", "", "40*60", "正1C 反1C", "300g铜版纸，上光", "10,000", "0.060", "600.00", "", "", "");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
