using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NPOI.SS.UserModel;

namespace OrderSheetCreator
{
    public partial class FCainzOrderD : Form
    {
        Dictionary<string, int> dicColumnWidth = new Dictionary<string, int>();
        //全局订单明细列表
        public static BindingList<entity.CainzOrderDetail> ORDERDETAILLIST = new BindingList<entity.CainzOrderDetail>();
        //全局客户信息
        public static entity.CainzFactory FACTORY = new entity.CainzFactory();
        //全局订单信息
        public entity.CainzOrder ORDER = null;
        //add
        int addint = 0;
        FProduct fadd = new FProduct();
        private FDateTime FDT = new FDateTime();
        public FCainzOrderD()
        {
            InitializeComponent();
            ORDERDETAILLIST.Clear();
            FACTORY = new entity.CainzFactory();

            ///todo make faster
            #region load 
            PublicTools.IniDatagridview(dataGridView1);
            PublicTools.IniDatagridview(dataGridView2);
            dataGridView2.AllowUserToAddRows = true;
            dataGridView2.Height = dataGridView2[0, 0].Size.Height + 2;
            dataGridView2.AllowUserToResizeColumns = false;

            PublicTools.SetColumsAutoModeNone(dataGridView1);
            PublicTools.SetColumsAutoModeNone(dataGridView2);

            cainzOrderDetailBindingSource.DataSource = ORDERDETAILLIST;
            bdsCustomer.DataSource = FACTORY;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            dataGridView1_DataBindingComplete(null, null);
            #endregion

            //PublicTools.RecoverFormSize(this);

        }

        public FCainzOrderD(entity.CainzOrder order)
        {
            InitializeComponent();
            btnSave.Text = "修改订单";
            ORDER = order;

            using (var db = PublicDB.getDB())
            {

                FCainzOrderD.FACTORY = (from a in db.CainzFactory
                                        where a.FactoryID == order.FactoryID
                                        select a).FirstOrDefault();
                FCainzOrderD.ORDERDETAILLIST = new BindingList<entity.CainzOrderDetail>((from a in db.CainzOrderDetail
                                                                                         where a.OrderID == order.OrderID
                                                                                         orderby a.RowNo
                                                                                         select a).ToList());
            }

            LoadOrder(order);
            ReColorStatus();

            ///todo make faster
            #region load 
            PublicTools.IniDatagridview(dataGridView1);
            PublicTools.IniDatagridview(dataGridView2);
            dataGridView2.AllowUserToAddRows = true;
            dataGridView2.Height = dataGridView2[0, 0].Size.Height + 2;
            dataGridView2.AllowUserToResizeColumns = false;

            PublicTools.SetColumsAutoModeNone(dataGridView1);
            PublicTools.SetColumsAutoModeNone(dataGridView2);

            cainzOrderDetailBindingSource.DataSource = ORDERDETAILLIST;
            bdsCustomer.DataSource = FACTORY;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            dataGridView1_DataBindingComplete(null, null);
            #endregion

            //PublicTools.RecoverFormSize(this);

        }

        private void LoadOrder(entity.CainzOrder order)
        {
            txbDELdate.Tag = (DateTime)order.SendDate;
            txbDELdate.Text = PublicTools.FormatDateC((DateTime)order.SendDate);
            txbIssuedDate.Tag = (DateTime)order.OrderDate;
            txbIssuedDate.Text = PublicTools.FormatDateC((DateTime)order.OrderDate);
            txbName.Text = order.Contact;
            if (txbAdd.Text.Length == 0)
            {
                txbAdd.Text = order.Address;
            }
            txbOrder.Text = order.OrderExNo;
            txbJingChenOrder.Text = order.OrderNo;
            cainzOrderDetailBindingSource.DataSource = ORDERDETAILLIST;
            bdsCustomer.DataSource = FACTORY;
            txbFile.Text = order.ImageFile;
        }

        private void FCainzOrderD_Load(object sender, EventArgs e)
        {
            PublicTools.RecoverColumnWidth(dataGridView1, Program.Code, Program.AppName, this.Name);
            PublicTools.saveWidthTmp(dataGridView1, dicColumnWidth);

            ReColorStatus();
            pictureBox2.Visible = false;
        }

        private void FCainzOrderD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PublicTools.isWidthChange(dataGridView1, dicColumnWidth))
            {
                PublicTools.SaveColumnWidth(dataGridView1,Program.Code,Program.AppName,this.Name);
            }

            //保存窗体的设置
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.Location = RestoreBounds.Location;
                Properties.Settings.Default.Size = RestoreBounds.Size;
                Properties.Settings.Default.Maximised = true;
                Properties.Settings.Default.Minimised = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = Location;
                Properties.Settings.Default.Size = Size;
                Properties.Settings.Default.Maximised = false;
                Properties.Settings.Default.Minimised = false;
            }
            else
            {
                Properties.Settings.Default.Location = RestoreBounds.Location;
                Properties.Settings.Default.Size = RestoreBounds.Size;
                Properties.Settings.Default.Maximised = false;
                Properties.Settings.Default.Minimised = true;
            }
            Properties.Settings.Default.Save();

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            if (FCainzOrderD.FACTORY != null && FCainzOrderD.FACTORY.TraderID != Guid.Empty)
            {
                using (var db = PublicDB.getDB())
                {
                    entity.CainzTrader trader = db.CainzTrader.Where(a => a.TraderID == FCainzOrderD.FACTORY.TraderID).FirstOrDefault();
                    if (trader != null) {
                        fadd = new FProduct(trader);
                    }
                    else
                    {
                        fadd = new FProduct();
                    }
                }
            }
            else
            {
                fadd = new FProduct();
            }
            fadd.ShowDialog();
            PublicTools.RecountRowsNum(dataGridView1);

        }

        private void FCainzOrderD_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    {
                        btnFactory_Click(null, null);
                    }
                    break;
                case Keys.F2:
                    {
                        tsbNew_Click(null, null);

                    }
                    break;
                case Keys.F3:
                    {
                        btnExport_Click(null, null);
                    }
                    break;
                case Keys.F4:
                    {
                        tsbSave_Click(null, null);
                    }
                    break;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fadd = new FProduct((entity.CainzOrderDetail)cainzOrderDetailBindingSource.Current);
            fadd.ShowDialog();
            PublicTools.RecountRowsNum(dataGridView1);


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.SaveOrder() == false) return;

            if (ORDERDETAILLIST.Count == 0)
            {
                MessageBox.Show("请添加订单项目");
                return;
            }
            if (txbTrader.Text.Trim().Length == 0)
            {
                MessageBox.Show("请添加订购工厂信息");
                return;
            }

            //OrderSheetCreator.Properties.Resources.ResourceManager.GetObject("cainzOrder.xls");
            int totol = ORDERDETAILLIST.Count;
            string excelPath;

            if (totol < 17)
            {
                excelPath = Application.StartupPath + @"\cainzOrder.xls";
            }
            else if(totol<47)
            {
                excelPath = Application.StartupPath + @"\cainzOrder2.xls";
            }
            else if (totol < 77)
            {
                excelPath = Application.StartupPath + @"\cainzOrder3.xls";
            }
            else if (totol < 107)
            {
                excelPath = Application.StartupPath + @"\cainzOrder4.xls";
            }
            else if (totol < 137)
            {
                excelPath = Application.StartupPath + @"\cainzOrder5.xls";
            }
            else
            {
                excelPath = Application.StartupPath + @"\cainzOrder6.xls";
            }

            string copedExcelPath = string.Format("{0}\\{1}{2}", Application.StartupPath, DateTime.Now.ToString("MMddHHmmss"), ".xls");

            if (File.Exists(excelPath))
            {
                File.Copy(excelPath, copedExcelPath, true);
            }

            if (File.Exists(copedExcelPath) == false)
            {
                MessageBox.Show("找不到模板文件！无法导出","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
                return;
            }

            IWorkbook wb = WorkbookFactory.Create(copedExcelPath);

            //第二页
            ISheet ist = wb.GetSheetAt(1);
            int rowofPage = ist.LastRowNum + 1;

            ICell icIssuedDate = ist.GetRow(1).GetCell(0);
            ICell icDELDate = ist.GetRow(5).GetCell(4);
            ICell icTrader = ist.GetRow(2).GetCell(0);
            ICell icFactroy = ist.GetRow(3).GetCell(0);
            ICell icAdd = ist.GetRow(4).GetCell(0);
            ICell icContent = ist.GetRow(5).GetCell(0);
            ICell icFile = ist.GetRow(8).GetCell(5);

            ICell icOrder = ist.GetRow(7).GetCell(0);
            ICell icJingchenOrder = ist.GetRow(8).GetCell(0);

            icTrader.SetCellValue(icTrader.StringCellValue + txbTrader.Text);
            icFactroy.SetCellValue(icFactroy.StringCellValue + txbFactory.Text);
            icAdd.SetCellValue(icAdd.StringCellValue + txbAdd.Text);
            icContent.SetCellValue(icContent.StringCellValue + txbName.Text);
            icIssuedDate.SetCellValue(icIssuedDate.StringCellValue + txbIssuedDate.Text);
            icDELDate.SetCellValue(icDELDate.StringCellValue + txbDELdate.Text);
            icOrder.SetCellValue(icOrder.StringCellValue + txbOrder.Text);
            icJingchenOrder.SetCellValue(icJingchenOrder.StringCellValue + txbJingChenOrder.Text);

            icFile.SetCellValue(icFile.StringCellValue + txbFile.Text);

            
            Decimal totolCount = 0;
            Decimal totolMoney = 0;
            for (int i = 0; i < totol; i++)
            {

                IRow irow;

                irow = ist.GetRow(i + 11);
                irow.GetCell(1).SetCellValue(ORDERDETAILLIST[i].ProductBarcode);
                irow.GetCell(2).SetCellValue(ORDERDETAILLIST[i].ProductName);
                irow.GetCell(3).SetCellValue(ORDERDETAILLIST[i].ProductSize);
                irow.GetCell(4).SetCellValue(ORDERDETAILLIST[i].ProductColor);
                irow.GetCell(5).SetCellValue(ORDERDETAILLIST[i].ProductMaterial);
                ICell cell6 = irow.GetCell(6);
                cell6.SetCellType(CellType.Numeric);
                cell6.SetCellValue((double)ORDERDETAILLIST[i].POPNum);

                ICell cell7 = irow.GetCell(7);
                cell7.SetCellType(CellType.Numeric);

                totolCount += (decimal)ORDERDETAILLIST[i].POPNum;
                cell7.SetCellValue((double)ORDERDETAILLIST[i].ProductPrice);


                totolMoney += ORDERDETAILLIST[i].TotalMoney;

                irow.GetCell(8).SetCellValue((double)ORDERDETAILLIST[i].TotalMoney);

                if (ORDERDETAILLIST[i].ExpectDate != null)
                {
                    irow.GetCell(9).SetCellValue(PublicTools.FormatDateC(((DateTime)ORDERDETAILLIST[i].ExpectDate)));
                }
                irow.GetCell(10).SetCellValue("");
                irow.GetCell(11).SetCellValue(ORDERDETAILLIST[i].Remark);

            }

            //合计写
            
            IRow irowTotol;

            if (totol < 17)
            {
                irowTotol = ist.GetRow(27);
            }
            else if (totol < 47)
            {
                irowTotol = ist.GetRow(57);
            }
            else if (totol < 77)
            {
                irowTotol = ist.GetRow(87);
            }
            else if (totol < 107)
            {
                irowTotol = ist.GetRow(117);
            }
            else if (totol < 137)
            {
                irowTotol = ist.GetRow(147);
            }
            else
            {
                irowTotol = ist.GetRow(177);
            }


            irowTotol.GetCell(6).SetCellValue((double)totolCount);
            irowTotol.GetCell(8).SetCellValue((double)totolMoney);
           


            using (FileStream fs = new FileStream(copedExcelPath, FileMode.Open))
            {
                wb.Write(fs);
            }

            System.Diagnostics.Process.Start(copedExcelPath);

        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            FFactory ff = new FFactory();
            ff.ShowDialog();
            if (FACTORY != null)
            {
                bdsCustomer.DataSource = FACTORY;
                bindingSource1_CurrentChanged(null, null);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            //string traderJC = PublicTools.stringZip(txbTrader.Text);
            //string factoryJC = PublicTools.stringZip(txbFactory.Text);
            //txbFile.Text = string.Format("{0}-{1}", traderJC, factoryJC);
        }

        private void txbTrader_DoubleClick(object sender, EventArgs e)
        {
            btnFactory_Click(null, null);
        }

        private void txbFactory_DoubleClick(object sender, EventArgs e)
        {
            btnFactory_Click(null, null);
        }

        private void txbAdd_DoubleClick(object sender, EventArgs e)
        {
            btnFactory_Click(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrder();

        }

        private bool SaveOrder()
        {
            bool r = false;
            if (orderValidate() == false)
            {
                r = false;
            }
                else { 

                this.Frozen(true);
                BackgroundWorker worker = new BackgroundWorker();
                worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
                worker.DoWork += Worker_DoWork;
                worker.RunWorkerAsync();
                r = true;
            }
            return r;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ORDER != null)
            {
                ORDER.IsDelete = 1;
                using (var db = PublicDB.getDB())
                {
                    db.CainzOrder.Attach(ORDER);
                    db.Entry(ORDER).State = System.Data.Entity.EntityState.Modified;

                    
                    db.SaveChanges();

                    var q = (from item in db.CainzOrderDetail
                             where item.CainzOrderOrderID == ORDER.OrderID
                             select item).ToArray();
                    if (q != null && q.Count() > 0)
                    {
                        foreach (var item in q)
                        {
                            item.IsDelete = 1;
                            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }

                    }
                }

            }

            entity.CainzOrder order = new entity.CainzOrder();


            order.OrderID = Guid.NewGuid();

            order.OrderNo = txbJingChenOrder.Text.Trim();
            order.OrderExNo = txbOrder.Text.Trim();
            order.ImageFile = txbFile.Text.Trim();
            order.CreateTime = DateTime.Now;
            order.IsDelete = 0;
            order.Status = 0;
            order.LastUpdate = DateTime.Now;
            order.CainzFactoryFactoryID = FCainzOrderD.FACTORY.FactoryID;
            order.FactoryID = order.CainzFactoryFactoryID;
            order.FactoryName = txbFactory.Text.Trim();
            order.Address = txbAdd.Text.Trim();

            order.TraderName = FCainzOrderD.FACTORY.TraderName;
            order.TraderID = FCainzOrderD.FACTORY.TraderID;

            order.Contact = txbName.Text.Trim();
            order.isDraft = 1;
            if (txbDELdate.Tag != null)
            {
                order.SendDate = (DateTime)txbDELdate.Tag;
            }

            if (txbIssuedDate.Tag != null)
            {
                order.OrderDate = (DateTime)txbIssuedDate.Tag;
            }


            foreach (var odd in FCainzOrderD.ORDERDETAILLIST)
            {

                odd.OrderDetailID = Guid.NewGuid();

                odd.OrderID = order.OrderID;
                odd.CainzOrderOrderID = odd.OrderID;
                order.Money += odd.TotalMoney;
            }
            order.CainzOrderDetail = FCainzOrderD.ORDERDETAILLIST.ToList();

            using (var db = PublicDB.getDB())
            {

                db.CainzOrder.Add(order);

                db.SaveChanges();
            }
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 订单保存前，验证各要素是否填写
        /// </summary>
        /// <returns></returns>
        private bool orderValidate()
        {
            bool r = true;
            List<TextBox> toValidate = new List<TextBox>();
            toValidate.Add(txbDELdate);
            toValidate.Add(txbFactory);
            toValidate.Add(txbAdd);
            toValidate.Add(txbTrader);
            toValidate.Add(txbIssuedDate);
            toValidate.Add(txbName);
           // toValidate.Add(txbOrder);
            toValidate.Add(txbJingChenOrder);
            toValidate.Add(txbFile);

            foreach (var item in toValidate)
            {
                if (item.TextLength == 0)
                {
                    item.Focus();
                    MessageBox.Show("红色标注部分不能通过验证保存，请检查");
                    r = false;
                    break;
                }
            }

            if (dataGridView1.Rows.Count == 0)
            {
                r = false;
                MessageBox.Show("订单还没有添加产品明细，不能保存");
            }

            var reg =new System.Text.RegularExpressions.Regex(@"C-\d{4}-\d{4}", System.Text.RegularExpressions.RegexOptions.ExplicitCapture);
            if (reg.IsMatch(txbJingChenOrder.Text) == false)
            {
                r = false;
                MessageBox.Show("景辰订单编号格式不对，请重新填写");
                txbJingChenOrder.SelectAll();
                txbJingChenOrder.Focus();

            }

            return r;

            



        }

        private void txbOrder_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
            {
                ((TextBox)sender).BackColor = SystemColors.Control;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.LightCoral;
            }
        }

        private void tsiAddNew_Click(object sender, EventArgs e)
        {
            this.tsbNew_Click(null, null);
        }

        private void tmiDelete_Click(object sender, EventArgs e)
        {
            var orderDetail = (entity.CainzOrderDetail)cainzOrderDetailBindingSource.Current;
            if (orderDetail != null)
            {
                ORDERDETAILLIST.Remove(orderDetail);
            }
        }

        private void tsiFlag_Click(object sender, EventArgs e)
        {
            var orderDetail = (entity.CainzOrderDetail)cainzOrderDetailBindingSource.Current;
            if (orderDetail != null)
            {
                orderDetail.Status = 1;
                cainzOrderDetailBindingSource.EndEdit();
            }
            ReColorStatus();
        }

        private void ReColorStatus()
        {

            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                var status = i.Cells["Status"].Value;
                if (status != null && (int)status == 1)
                {
                    DataGridViewCellStyle dvcs = i.DefaultCellStyle.Clone();
                    dvcs.BackColor = Color.LightGreen;
                    i.DefaultCellStyle = dvcs;

                }
                else
                {
                    DataGridViewCellStyle dvcs = i.DefaultCellStyle.Clone();
                    dvcs.BackColor = Color.FromKnownColor(KnownColor.Window);
                    i.DefaultCellStyle = dvcs;
                }
            }

        }

        private void tsiCanselFlag_Click(object sender, EventArgs e)
        {
            var orderDetail = (entity.CainzOrderDetail)cainzOrderDetailBindingSource.Current;
            if (orderDetail != null)
            {
                orderDetail.Status = 0;
            }
            ReColorStatus();

        }

        private void txbIssuedDate_Click(object sender, EventArgs e)
        {
            FDT.Location = PublicTools.local(txbIssuedDate);
            FDT.ShowDialog();
            txbIssuedDate.Text = PublicTools.FormatDateC(FDateTime.DateTimeSelect);
            txbIssuedDate.Tag = FDateTime.DateTimeSelect;
        }

        private void txbDELdate_Click(object sender, EventArgs e)
        {
            FDT.Location = PublicTools.local(txbDELdate);
            FDT.ShowDialog();
            txbDELdate.Text = PublicTools.FormatDateC(FDateTime.DateTimeSelect);
            txbDELdate.Tag = FDateTime.DateTimeSelect;
        }

        private void btnImportOrder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.DefaultExt = ".xls";
            ofd.Filter = "excel file |*.xls;*.xlsx";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                entity.CainzOrder order = new entity.CainzOrder();
                try
                {
                    ReadOrderSheet(ofd.FileName, out order);
                }
                catch(Exception ee)
                {
                    MessageBox.Show("报错信息："+ee.Message,"导入失败",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                }

            }

        }

        public  void ReadOrderSheet(string excelPath,out entity.CainzOrder order)
        {
            order = new entity.CainzOrder();
            IWorkbook wb = WorkbookFactory.Create(excelPath);
            if (wb.NumberOfSheets < 2) return;

            ISheet ist = wb.GetSheetAt(1);
            int rowofPage = ist.LastRowNum + 1;

            string _IssuedDate = PublicTools.GetCellString(ist, 'a', 2).Replace("下单日期：", "").Trim();
            string _TraderName = PublicTools.GetCellString(ist, 'a', 3).Replace("所属贸易公司：", "").Trim();
            string _factoryName = PublicTools.GetCellString(ist, 'a', 4).Replace("订购工厂：", "").Trim();
            string _factoryAdd = PublicTools.GetCellString(ist, 'a', 5).Replace("交货地址/电话：", "").Trim();
            string _factoryContact = PublicTools.GetCellString(ist, 'a', 6).Replace("联系人：", "").Trim();
            string _DELdate = PublicTools.GetCellString(ist, 'e', 6).Replace("交货期：", "").Trim();
            string _FileName = PublicTools.GetCellString(ist, 'f', 9).Replace("文件位置：", "").Trim();

            string _OrderNo = PublicTools.GetCellString(ist, 'a', 8).Replace("合 同  编 号:", "").Trim();
            string _OrderJCNo = PublicTools.GetCellString(ist, 'a', 9).Replace("我司订单编号：", "").Trim();

            order.OrderID = Guid.NewGuid();
            order.Address = _factoryAdd;
            entity.CainzFactory factory =PublicDB.GetFactoryByName(_factoryName);
            if(factory !=null)
            {
                order.CainzFactoryFactoryID = factory.FactoryID;
                order.FactoryID = factory.FactoryID;
                order.FactoryName = factory.FactoryName;
                order.CainzFactory = factory;
            }
            order.IsDelete = 0;
            order.isDraft = 0;
            order.LastUpdate = DateTime.Now;
            order.OrderDate = DateTime.Parse(_IssuedDate);
            order.OrderExNo = _OrderJCNo;
            order.OrderNo = _OrderNo;
            order.TraderName = _TraderName;

            order.CreateTime = DateTime.Now;

            order.SendDate = DateTime.Parse(_DELdate);
            order.Status = 0;
            
            //order.Money =( (Decimal)PublicTools.GetCellNumic(ist, 'i', 31);
            
            for(int i = 12;i<31;i++)
            {
                entity.CainzOrderDetail detail =new entity.CainzOrderDetail();
                detail.OrderDetailID = Guid.NewGuid();
                detail.OrderID=order.OrderID;
                detail.IsDelete=0;
                detail.CreateTime=DateTime.Now;
                detail.RowNo=i-11;
                detail.Status=0;

                detail.ProductBarcode = PublicTools.GetCellString(ist, 'b', i);
                if (detail.ProductBarcode != string.Empty)
                {
                    entity.CainzProduct _product = PublicDB.GetProductByBarcode(detail.ProductBarcode);
                    if (_product != null)
                    {
                        detail.CainzProductProductID = _product.ProductID;
                        detail.ProductID = _product.ProductID;
                        detail.ProductName = PublicTools.GetCellString(ist, 'c', i);
                        detail.ProductSize = PublicTools.GetCellString(ist, 'd', i);
                        detail.ProductColor = PublicTools.GetCellString(ist, 'e', i);
                        detail.ProductMaterial = PublicTools.GetCellString(ist, 'f', i);

                        detail.POPNum = (int)PublicTools.GetCellNumic(ist, 'g', i);
                        detail.ProductPrice = (Decimal)PublicTools.GetCellNumic(ist, 'h', i);
                        detail.TotalMoney = (Decimal)PublicTools.GetCellNumic(ist, 'i', i);
                        string eDate = PublicTools.GetCellString(ist, 'j', i);
                        if (eDate != string.Empty)
                        {
                            detail.ExpectDate = DateTime.Parse(eDate);

                        }
                        detail.ExpectDateFormat = PublicTools.GetCellString(ist, 'j', i);
                        detail.Remark = PublicTools.GetCellString(ist, 'l', i);
                        order.CainzOrderDetail.Add(detail);
                    }

                }
                else
                {
                    break;
                }

            }



            FCainzOrderD.FACTORY = order.CainzFactory;
            FCainzOrderD.ORDERDETAILLIST = new BindingList<entity.CainzOrderDetail>(order.CainzOrderDetail.ToList());

            LoadOrder(order);

        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                dataGridView2.Columns[i].Width = dataGridView1.Columns[i].Width;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            decimal totolMoney = 0;
            int totolCount = 0;
            foreach (var item in FCainzOrderD.ORDERDETAILLIST)
            {
                totolMoney += item.TotalMoney;
                totolCount += (int)item.POPNum;
            }
            dataGridView2[6, 0].Value = totolCount;
            dataGridView2[8, 0].Value = totolMoney;
            dataGridView2[1, 0].Value = "合计";
        }

        private void Frozen(bool isEnable)
        {
            if (isEnable)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    Rectangle ScreenArea = System.Windows.Forms.Screen.GetWorkingArea(this);

                    pictureBox2.Location = new Point((ScreenArea.Width - pictureBox2.Width) / 2, (ScreenArea.Height - pictureBox2.Height) / 2 - 200);
                    pictureBox2.Visible = true;

                }
                else if (this.WindowState == FormWindowState.Normal)
                {
                    pictureBox2.Location = new Point((this.Size.Width - pictureBox2.Width) / 2, (this.Size.Height - pictureBox2.Height) / 2 - 200);
                    pictureBox2.Visible = true;

                }
                toolStrip1.Enabled = false;
                panel2.Visible = false;
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;

            }
            else
            {
                panel2.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox2.Visible = true;

            }
            this.Refresh();
        }

        private void FCainzOrderD_SizeChanged(object sender, EventArgs e)
        {
            PublicTools.SaveFormSize(this);
        }

        private void btnUpMove_Click(object sender, EventArgs e)
        {
            var orderDetail = (entity.CainzOrderDetail)cainzOrderDetailBindingSource.Current;
            if (orderDetail != null)
            {
                if(orderDetail.RowNo==1) return;
                foreach(var d in FCainzOrderD.ORDERDETAILLIST)
                {
                    if(d.RowNo == orderDetail.RowNo-1)
                    {
                        d.RowNo = orderDetail.RowNo;
                        orderDetail.RowNo--;
                        break;
                    }
                }
            }

            FCainzOrderD.ORDERDETAILLIST = new BindingList<entity.CainzOrderDetail>(FCainzOrderD.ORDERDETAILLIST.OrderBy(a => a.RowNo).ToList());
            cainzOrderDetailBindingSource.DataSource = FCainzOrderD.ORDERDETAILLIST;
            PublicTools.RecountRowsNum(dataGridView1);
            ReColorStatus();
        }

        private void btnChangeAdd_Click(object sender, EventArgs e)
        {
            switch (addint)
            {
                case 0:
                    {
                        txbAdd.Text = FACTORY.FactoryAddress2;
                        addint = 1;

                    } break;
                case 1:
                    {
                        txbAdd.Text = FACTORY.FactoryAddress;
                        addint = 2;
                    } break;
                case 2:
                    {
                        if (ORDER != null)
                            txbAdd.Text = ORDER.Address;
                        addint = 0;
                    } break;
            }
        }
    }
    
}
