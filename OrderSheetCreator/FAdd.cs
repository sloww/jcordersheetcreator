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
        private string FADD_DATAGRIDVIEW_SETPATH = "产品查询表宽度设定.txt";
        private TextBox TXBMATERIAL_TMP = new TextBox();
        private bool IS_IN_ORDER = false;

        public FAdd()
        {
            InitializeComponent();
        }
        public FAdd(entity.CainzOrderDetail cod)
        {
            InitializeComponent();
            this.IS_IN_ORDER = true;
            txbMaterial.Text = cod.PaperKind;
            txbSize.Text = cod.PopSize;
            txbReMarK.Text = cod.Remark;
            txbCount.Text = cod.OrderNum.ToString();
            txbPrice.Text = cod.Price.ToString();
            txbColor.Text = cod.Colour;
            txbCount.Focus();
            btnContinue.Text = "修改";
            txbSearchBarcode.Enabled = false;
            this.Text = "产品修改";

            //注意顺序，后期修复此bug
            txbBarcode.Enabled = false;
            txbMaterial.Enabled = false;
            txbColor.Enabled = false;
            txbSize.Enabled = false;
            txbBarcode.Text = cod.ProductCD;
            

        }

        private void txbSearchBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txbSearchBarcode.Text.Length > 0)
            {
                using (var db = new entity.jingchendbEntities())
                {
                    var productQuery = from a in db.CainzProduct
                                       where a.Barcode.Contains(txbSearchBarcode.Text)
                                       orderby a.Barcode,a.Price
                                       select a;
                    productsBindingSource.DataSource = productQuery.Take(8).ToList();

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
            PublicTools.SetColumsAutoModeNone(dataGridView1);
            PublicTools.RecoverColumnWidth(dataGridView1, this.FADD_DATAGRIDVIEW_SETPATH);
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
            this.txbClear();
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

        private void txbClear()
        {
            txbSearchBarcode.Text = "";
            txbCount.Text = "";
            txbReMarK.Text = "";
            txbIssuedDate.Text = "";
            this.txbSearchBarcode.Focus();

        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (AddToODList())
                this.txbClear();
        }

        private bool AddToODList()
        {
            this.CheckOrderList();
            if (txbBarcode.Text.Length == 0)
            {
                txbSearchBarcode.Focus();
                return false;
            }
            int count=-1;

            if (!int.TryParse(txbCount.Text.Trim(),out count))
            {
                MessageBox.Show("请输入正确订购数量");
                txbCount.Focus();
                return false;
            }

            if (count < 1)
            {
                MessageBox.Show("请输入正确订购数量");
                txbCount.Focus();
                return false;
            }

            decimal _price = 0;

            if (!decimal.TryParse(txbPrice.Text.Replace("元", ""), out _price))
            {
                MessageBox.Show("请输入正确价格");
                txbPrice.Focus();
                return false;
            }
            if (this.IS_IN_ORDER == false)
            {
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

                if (txbIssuedDate.Text != "")
                {
                    DateTime dt;
                    if (DateTime.TryParse(txbIssuedDate.Text, out dt))
                    {
                        cod.ExpectDate = dt;
                    }
                }

                //注意最好计算！
                cod.InvoiceMoney = (decimal)cod.Price * (decimal)cod.OrderNum;
                FCainzOrderD.ORDERDETAILLIST.Add(cod);
            }
            else
            {
                int listCount = FCainzOrderD.ORDERDETAILLIST.Count;
                for (int i = 0; i < listCount; i++)
                {

                    if (FCainzOrderD.ORDERDETAILLIST[i].ProductCD.Equals(txbBarcode.Text) && FCainzOrderD.ORDERDETAILLIST[i].PaperKind.Equals(txbMaterial.Text) && FCainzOrderD.ORDERDETAILLIST[i].PopSize.Equals(txbSize.Text))
                    {
                        FCainzOrderD.ORDERDETAILLIST[i].OrderNum = count;
                        FCainzOrderD.ORDERDETAILLIST[i].Remark = txbReMarK.Text.Trim();
                        FCainzOrderD.ORDERDETAILLIST[i].CreateTime = DateTime.Now;
                        FCainzOrderD.ORDERDETAILLIST[i].Price = _price;
                        if (txbIssuedDate.Text != "")
                        {
                            DateTime dt;
                            if (DateTime.TryParse(txbIssuedDate.Text, out dt))
                            {
                                FCainzOrderD.ORDERDETAILLIST[i].ExpectDate = dt;
                            }
                        }
                        FCainzOrderD.ORDERDETAILLIST[i].InvoiceMoney = (decimal)count * (decimal)_price;
                        break;
                    }

                }
                    if (btnContinue.Text == "修改")
                    {
                        this.Close();
                    }

            }
            return true;

        }

        private void FAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            PublicTools.SaveColumnWidth(dataGridView1, this.FADD_DATAGRIDVIEW_SETPATH);
        }


        private void txbMaterial_TextChanged(object sender, EventArgs e)
        {
            if (txbMaterial.Tag == null)
            {
                txbMaterial.Tag = true;
                this.TXBMATERIAL_TMP.Location = txbMaterial.Location;
                this.TXBMATERIAL_TMP.Font = txbMaterial.Font;
            }
            txbMaterial.Location = this.TXBMATERIAL_TMP.Location;
            txbMaterial.Font = this.TXBMATERIAL_TMP.Font;
            PublicTools.ReSizeTextbox(txbMaterial);
        }

        private void txbBarcode_TextChanged(object sender, EventArgs e)
        {
            this.CheckOrderList();
        }

        private void CheckOrderList()
        {
            this.IS_IN_ORDER = false;

            entity.CainzOrderDetail cod = GetCOD(txbBarcode.Text, txbMaterial.Text, txbSize.Text);
            if (cod != null)
            {
                this.IS_IN_ORDER = true;
            }
        }

        private entity.CainzOrderDetail GetCOD(string bacode, string material, string size)
        {
            entity.CainzOrderDetail cod = null;
            foreach (var odm in FCainzOrderD.ORDERDETAILLIST)
            {
                if (odm.ProductCD.Equals(txbBarcode.Text) && odm.PaperKind.Equals(txbMaterial.Text) && odm.PopSize.Equals(txbSize.Text))
                {
                    cod = odm;
                    break;
                }
            }
            return cod;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            entity.CainzOrderDetail cod=GetCOD(txbBarcode.Text, txbMaterial.Text, txbSize.Text);
            if (cod == null)
            {
                MessageBox.Show("订单内无此产品");
            }
            else
            {
                FCainzOrderD.ORDERDETAILLIST.Remove(cod);
                this.txbClear();
            }
        }

        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbIssuedDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }






    }
}
