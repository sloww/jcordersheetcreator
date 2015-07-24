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
    public partial class FAdd : Form
    {
        public FAdd()
        {
            InitializeComponent();
        }

        private void txbBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txbBarcode.Text.Length > 2)
            {
                using (var db = new entity.jingchendbEntities())
                {
                    var productQuery = from a in db.CainzProduct
                                       where a.Barcode.Contains(txbBarcode.Text)
                                       select a;
                    productsBindingSource.DataSource = productQuery.Take(9).ToList();
                }
            }
            else
            {
                //productsBindingSource.DataSource = null;
            }
        }

        private void FAdd_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowDrop = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void FAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)115)
            {
            }
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            add();
            this.Clear();
            this.Close();
         
          
        }


        private void Clear()
        {
            
            txbBarcode.Text = "";
     
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            add();
        }

        private void add()
        {
            entity.CainzOrderDetail cod = new entity.CainzOrderDetail();
            cod.ProductCD = txbBarcode.Text;
            cod.Colour = txbColor.Text;
            cod.PopSize = txbSize.Text;
            cod.Price = System.Decimal.Parse(txbPrice.Text) ;
            cod.OrderNum = txbCount.Text;
            cod.CreateTime = DateTime.Now;

            FCainzOrderD.ORDERDETAILLIST.Add(cod);

        }


    }
}
