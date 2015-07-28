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
        public static BindingList<entity.CainzOrderDetail> ORDERDETAILLIST = new BindingList<entity.CainzOrderDetail>();
        public static entity.CainzCustomer CC = new entity.CainzCustomer();
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
            bindingSource1.DataSource = CC;
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
            string excelPath = "D://cainzOrder.xls";
            string copedExcelPath = string.Format("{0}{1}{2}", @"D://", DateTime.Now.ToString("MMddHHmmss"), ".xls");
            if (File.Exists(excelPath))
            {
                File.Copy(excelPath, copedExcelPath, true);
            }
            if (File.Exists(copedExcelPath) == false)
            {
                return;
            }
            IWorkbook wb = WorkbookFactory.Create(copedExcelPath);

            ISheet ist = wb.GetSheetAt(0);
            int rowofPage = ist.LastRowNum + 1;

            ICell icTrader = ist.GetRow(2).GetCell(0);
            ICell icFactroy = ist.GetRow(3).GetCell(0);
            ICell icAdd = ist.GetRow(4).GetCell(0);
            ICell icContent = ist.GetRow(5).GetCell(0);

            icTrader.SetCellValue(icTrader.StringCellValue + txbTrader.Text);
            icFactroy.SetCellValue(icFactroy.StringCellValue + txbFactory.Text);
            icAdd.SetCellValue(icAdd.StringCellValue + txbAdd.Text);
            icContent.SetCellValue(icContent.StringCellValue + txbName.Text);

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
                irow.GetCell(9).SetCellValue(ORDERDETAILLIST[i].ExpectDate.ToString());
                irow.GetCell(10).SetCellValue("");
                irow.GetCell(11).SetCellValue(ORDERDETAILLIST[i].Remark);
            }
            IRow irowTotol = ist.GetRow(31);
            irowTotol.GetCell(6).SetCellValue(totolCount.ToString());
            irowTotol.GetCell(8).SetCellValue(totolMoney.ToString());
            

            using (FileStream fs = new FileStream(copedExcelPath, FileMode.Open))
            {
                wb.Write(fs);
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
            bindingSource1.DataSource = CC;
        }
    }
}
