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
            if (txbSearchBarcode.Text.Length > 0)
            {
                using (var db = new entity.jingchendbEntities())
                {
                    var productQuery = from a in db.CainzProduct
                                       where a.Barcode.Contains(txbSearchBarcode.Text)
                                       select a;
                    productsBindingSource.DataSource = productQuery.Take(9).ToList();

                }
                PublicTools.RecountRowsNum(dataGridView1);
            }
            else
            {
                productsBindingSource.DataSource = new List<entity.CainzProduct>();
            }
        }

        private void FAdd_Load(object sender, EventArgs e)
        {
            PublicTools.IniDatagridview(dataGridView1);
        }

        private void FAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)115)
            {
            }
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            AddToODList();
            this.Clear();
            this.Close();


        }

        private void txbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 以下都是一些公共抽象的方法
        /// </summary>

        private void Clear()
        {
            txbSearchBarcode.Text = "";
            txbCount.Text = "";
            txbReMarK.Text = "";
            this.txbSearchBarcode.Focus();

        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            AddToODList();
            this.Clear();
        }

        private void AddToODList()
        {
            if (txbBarcode.Text.Length == 0)
            {
                txbSearchBarcode.Focus();
                return;
            }
            int count=-1;

            if (!int.TryParse(txbCount.Text.Trim(),out count))
            {
                MessageBox.Show("请输入正确订购数量");
                txbCount.Focus();
                return;
            }

            if (count < 1)
            {
                MessageBox.Show("请输入正确订购数量");
                txbCount.Focus();
                return;
            }

            decimal _price = 0;

            if (!decimal.TryParse(txbPrice.Text.Replace("元", ""), out _price))
            {
                MessageBox.Show("请输入正确价格");
                txbPrice.Focus();
                return;
            }

            entity.CainzOrderDetail cod = new entity.CainzOrderDetail();
            cod.RowNo = FCainzOrderD.ORDERDETAILLIST.Count + 1;
            cod.ProductCD = txbBarcode.Text;
            cod.PaperKind = txbMaterial.Text;
            cod.Colour = txbColor.Text;
            cod.PopSize = txbSize.Text;
            cod.Price = _price;
            cod.OrderNum = count;
            cod.Remark = txbReMarK.Text.Trim();
            cod.CreateTime = DateTime.Now;
            //注意最好计算！
            cod.InvoiceMoney = (decimal)cod.Price * (decimal)cod.OrderNum;
            FCainzOrderD.ORDERDETAILLIST.Add(cod);

        }





    }
}
