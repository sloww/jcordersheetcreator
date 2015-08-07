﻿using System;
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
        //全局订单明细列表
        public static BindingList<entity.CainzOrderDetail> ORDERDETAILLIST = new BindingList<entity.CainzOrderDetail>();
        //全局客户信息
        public static entity.CainzCustomer CC = new entity.CainzCustomer();
        FAdd fadd = new FAdd();
        private string FCainzOrderDdataGridViewSetPath = "订单表宽度设定.txt";
        private FDateTime FDT = new FDateTime();
        public FCainzOrderD()
        {
            InitializeComponent();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            cainzOrderDetailBindingSource.Clear();
            //this.Close();
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
            bindingSource1.DataSource = CC;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.ControlBox = true;
            using (entity.DB db = new entity.DB())
            {


                lblSql.Text = db.Database.Connection.ConnectionString.Replace("ceshi123!@#","***").Trim();
            }
            lblVer.Text = " Ver 1.2 2015-8-5";
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            fadd = new FAdd();
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
                    }break;
                case Keys.F2:
                    {
                        tsbNew_Click(null, null);
                        
                    }break;
                case Keys.F3:
                    {
                        btnExport_Click(null, null);
                    }break;
                case Keys.F4:
                    {
                        tsbSave_Click(null, null);
                    } break;
            }
        }

        private void FCainzOrderD_FormClosing(object sender, FormClosingEventArgs e)
        {
            PublicTools.SaveColumnWidth(dataGridView1, this.FCainzOrderDdataGridViewSetPath);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fadd = new FAdd((entity.CainzOrderDetail)cainzOrderDetailBindingSource.Current);
            fadd.ShowDialog();
            PublicTools.RecountRowsNum(dataGridView1);


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ORDERDETAILLIST.Count == 0)
            {
                MessageBox.Show("请添加订单项目");
                return;
            } 
            if (txbTrader.Text.Trim().Length ==0)
            {
                MessageBox.Show("请添加订购工厂信息");
                return;
            }
            string excelPath = Application.StartupPath+ @"\\cainzOrder.xls";
            string copedExcelPath = string.Format("{0}\\订单记录\\{1}{2}", Application.StartupPath, DateTime.Now.ToString("MMddHHmmss"), ".xls");
            if (File.Exists(excelPath))
            {
                File.Copy(excelPath, copedExcelPath, true);
            }
            if (File.Exists(copedExcelPath) == false)
            {
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
            ICell icJingchenOrer = ist.GetRow(8).GetCell(0);

            icTrader.SetCellValue(icTrader.StringCellValue + txbTrader.Text);
            icFactroy.SetCellValue(icFactroy.StringCellValue + txbFactory.Text);
            icAdd.SetCellValue(icAdd.StringCellValue + txbAdd.Text);
            icContent.SetCellValue(icContent.StringCellValue + txbName.Text);
            icIssuedDate.SetCellValue(icIssuedDate.StringCellValue + txbIssuedDate.Text);
            icDELDate.SetCellValue(icDELDate.StringCellValue + txbDELdate.Text);
            icOrder.SetCellValue(icOrder.StringCellValue + txbOrder.Text);
            icJingchenOrer.SetCellValue(icJingchenOrer.StringCellValue + txbJingChenOrder.Text);

            icFile.SetCellValue(icFile.StringCellValue+ txbFile.Text);

            int totol = ORDERDETAILLIST.Count;
            Decimal totolCount = 0;
            Decimal totolMoney = 0;
            for(int i =0;i<totol;i++)
            {
                IRow irow = ist.GetRow(i + 11);
                irow.GetCell(1).SetCellValue(ORDERDETAILLIST[i].ProductCD);
                irow.GetCell(2).SetCellValue(ORDERDETAILLIST[i].ProductName);
                irow.GetCell(3).SetCellValue(ORDERDETAILLIST[i].PopSize);
                irow.GetCell(4).SetCellValue(ORDERDETAILLIST[i].Colour);
                irow.GetCell(5).SetCellValue(ORDERDETAILLIST[i].PaperKind);
                irow.GetCell(6).SetCellValue(ORDERDETAILLIST[i].OrderNum);
                totolCount += ORDERDETAILLIST[i].OrderNum;
                irow.GetCell(7).SetCellValue(ORDERDETAILLIST[i].Price.ToString());
                totolMoney += ORDERDETAILLIST[i].InvoiceMoney;
                irow.GetCell(8).SetCellValue(ORDERDETAILLIST[i].InvoiceMoney.ToString());
                if (ORDERDETAILLIST[i].ExpectDate !=null)
                {
                    irow.GetCell(9).SetCellValue(((DateTime)ORDERDETAILLIST[i].ExpectDate).ToString("yyyy-MM-dd"));
                }
                irow.GetCell(10).SetCellValue("");
                irow.GetCell(11).SetCellValue(ORDERDETAILLIST[i].Remark);
            }

            //合计写
            IRow irowTotol = ist.GetRow(30);
            irowTotol.GetCell(6).SetCellValue(totolCount.ToString());
            irowTotol.GetCell(8).SetCellValue(totolMoney.ToString());
            

            using (FileStream fs = new FileStream(copedExcelPath, FileMode.Open))
            {
                wb.Write(fs);
            }

            using (var db = new entity.DB())
            {

            }
            ORDERDETAILLIST = new BindingList<entity.CainzOrderDetail>();
            CC = new entity.CainzCustomer();
            bindingSource1.DataSource = CC;
            System.Diagnostics.Process.Start(copedExcelPath); 

        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            FFactory ff = new FFactory();
            ff.ShowDialog();
            if (CC != null)
            {
                bindingSource1.DataSource = CC;
                bindingSource1_CurrentChanged(null, null);
            }
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            DataTools dt = new DataTools();
            dt.ShowDialog();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            string traderJC = PublicTools.stringZip(txbTrader.Text);
            string factoryJC = PublicTools.stringZip(txbFactory.Text);
            txbFile.Text = string.Format("{0}-{1}", traderJC, factoryJC);
        }

        private void txbIssuedDate_DoubleClick(object sender, EventArgs e)
        {
            FDT.Location = PublicTools.local(txbIssuedDate);
            FDT.ShowDialog();
            txbIssuedDate.Text = FDateTime.DateTimeSelect.ToShortDateString();
        }

        private void txbDELdate_DoubleClick(object sender, EventArgs e)
        {
            FDT.Location = PublicTools.local(txbDELdate);
            FDT.ShowDialog();
            txbDELdate.Text = FDateTime.DateTimeSelect.ToShortDateString();
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
            using (var db = new entity.DB())
            {


            }
        }
    }
}
