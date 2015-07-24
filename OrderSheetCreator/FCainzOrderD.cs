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
        public static List<entity.CainzOrderDetail> ORDERDETAILLIST = new List<entity.CainzOrderDetail>();
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowDrop = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            fadd.ShowDialog();
            cainzOrderDetailBindingSource.DataSource = ORDERDETAILLIST;
        }

        private void FCainzOrderD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                tsbNew_Click(null, null);
            }
        }
    }
}
