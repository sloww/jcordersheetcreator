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
            txbMaterial.Text = cod.CainzProduct.ProductMaterial;
            txbSize.Text = cod.CainzProduct.ProductSize;
            txbReMarK.Text = cod.Remark;
            txbCount.Text = cod.POPNum.ToString();
            txbPrice.Text = cod.ProductPrice.ToString();
            txbColor.Text = cod.CainzProduct.ProductColor;
            txbCount.Focus();
            btnContinue.Text = "修改";
            txbSearchBarcode.Enabled = false;
            this.Text = "产品修改";

            //注意顺序，后期修复此bug
            txbBarcode.Enabled = false;
            txbMaterial.Enabled = false;
            txbColor.Enabled = false;
            txbSize.Enabled = false;
            txbBarcode.Text = cod.ProductBarcode;
            

        }

        private void SearchBarcode()
        {
            if (txbSearchBarcode.Text.Length > 0)
            {
                using (var db = new entity.DB())
                {
                    var productQuery = from a in db.CainzProduct
                                       where a.ProductBarcode.Contains(txbSearchBarcode.Text) && a.Deleted == 0
                                       orderby a.ProductBarcode, a.ProductPrice
                                       select a;
                    productsBindingSource.DataSource = productQuery.Take(5).ToList();

                }
                PublicTools.RecountRowsNum(dataGridView1);
            }
            else
            {
                productsBindingSource.DataSource = new List<entity.CainzProduct>();
            }
        }

        private void txbSearchBarcode_TextChanged(object sender, EventArgs e)
        {
            if (ckbAutoEnter.Checked)
            {
                this.SearchBarcode();
            }

        }

        private void FAdd_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            PublicTools.IniDatagridview(dataGridView1);
            PublicTools.SetColumsAutoModeNone(dataGridView1);
            PublicTools.RecoverColumnWidth(dataGridView1, this.FADD_DATAGRIDVIEW_SETPATH);
            btnHidden_Click(null, null);
        }

        private void FAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
            {
                this.Close();
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
                cod.OrderDetailID = Guid.NewGuid();
                cod.RowNo = FCainzOrderD.ORDERDETAILLIST.Count + 1;
                cod.CainzProductProductID = ((entity.CainzProduct)productsBindingSource.Current).ProductID;
                cod.ProductID = cod.CainzProductProductID;
                cod.ProductBarcode = txbBarcode.Text;
                cod.ProductMaterial= txbMaterial.Text;
                cod.ProductColor = txbColor.Text;
                cod.ProductSize = txbSize.Text;
                cod.ProductPrice = _price;

                cod.POPNum = count;
                cod.Remark = txbReMarK.Text.Trim();
                cod.CreateTime = DateTime.Now;

                if (txbIssuedDate.Text != "")
                {
                    DateTime dt;
                    if (DateTime.TryParse(txbIssuedDate.Text, out dt))
                    {
                        cod.ExpectDate = dt;
                        cod.ExpectDateFormat = PublicTools.FormatDate(dt);
                    }
                }

                //注意最好计算！
                cod.TotalMoney = (decimal)cod.ProductPrice * (decimal)cod.POPNum;
                cod.IsDelete = 0;
                cod.Status = 0;

                FCainzOrderD.ORDERDETAILLIST.Add(cod);
            }
            else
            {
                int listCount = FCainzOrderD.ORDERDETAILLIST.Count;
                for (int i = 0; i < listCount; i++)
                {

                    if (FCainzOrderD.ORDERDETAILLIST[i].ProductBarcode.Equals(txbBarcode.Text) && FCainzOrderD.ORDERDETAILLIST[i].ProductMaterial.Equals(txbMaterial.Text) && FCainzOrderD.ORDERDETAILLIST[i].ProductSize.Equals(txbSize.Text))
                    {
                        FCainzOrderD.ORDERDETAILLIST[i].POPNum = count;
                        FCainzOrderD.ORDERDETAILLIST[i].Remark = txbReMarK.Text.Trim();
                        FCainzOrderD.ORDERDETAILLIST[i].CreateTime = DateTime.Now;
                        FCainzOrderD.ORDERDETAILLIST[i].ProductPrice = _price;
                        if (txbIssuedDate.Text != "")
                        {
                            DateTime dt;
                            if (DateTime.TryParse(txbIssuedDate.Text, out dt))
                            {
                                FCainzOrderD.ORDERDETAILLIST[i].ExpectDate = dt;
                            }
                        }
                        FCainzOrderD.ORDERDETAILLIST[i].TotalMoney = (decimal)count * (decimal)_price;
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
                if (odm.ProductBarcode.Equals(txbBarcode.Text) && odm.ProductMaterial.Equals(txbMaterial.Text) && odm.ProductSize.Equals(txbSize.Text))
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

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否修改该产品数据库，点击，YES，后修改不可恢复", "谨慎操作", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new entity.DB())
                {
                    entity.CainzProduct cp = (entity.CainzProduct)productsBindingSource.Current;
                    cp.Modified = 1;
                    cp.ModifyTime = DateTime.Now;
                    db.CainzProduct.Attach(cp);
                    db.Entry(cp).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                }
                this.SearchBarcode();
            }
        }

        private void productsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            this.CheckOrderList();
        }

        private void btnDeletedb_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除从数据库删除该行记录，点击，YES，后删除不可恢复", "谨慎操作", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new entity.DB())
                {
                    entity.CainzProduct cp = (entity.CainzProduct)productsBindingSource.Current;
                    cp.Deleted = 1;
                    db.CainzProduct.Attach(cp);
                    db.Entry(cp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

                this.SearchBarcode();
            }
            
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.Height = 59;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbSearchBarcode_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txbSearchBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.SearchBarcode();
            }
        }

        private void txbTrader_TextChanged(object sender, EventArgs e)
        {
            if (txbTrader.Text.Length > 0)
            {
                ckbIsLock.Visible = true;
            }
            else
            {
                ckbIsLock.Visible = false;

            }
        }

        private void btnDBnew_Click(object sender, EventArgs e)
        {
            using (var db = new entity.DB())
            {
                entity.CainzProduct cp = new entity.CainzProduct();
                cp.Deleted = 0;
                cp.ProductBarcode = txbBarcode.Text.Trim();
                cp.ProductColor = txbColor.Text.Trim();
                cp.ProductMaterial = txbMaterial.Text.Trim();
                cp.ProductPrice = decimal.Parse(txbPrice.Text.Trim());
                cp.Modified = 1;
                cp.ModifyTime = DateTime.Now;
                cp.CreateTime = DateTime.Now;
                cp.TraderID = ((entity.CainzProduct)productsBindingSource.Current).TraderID;
                cp.TraderName = ((entity.CainzProduct)productsBindingSource.Current).TraderName;
                db.CainzProduct.Add(cp);
                db.SaveChanges();
            }

            this.SearchBarcode();

        }

        private void txbColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbIssuedDate_DoubleClick(object sender, EventArgs e)
        {

            FDateTime fdt = new FDateTime();
            fdt.Location = PublicTools.local(txbIssuedDate);
            fdt.ShowDialog();
            txbIssuedDate.Text = FDateTime.DateTimeSelect.ToShortDateString();

           
        }



    }
}
