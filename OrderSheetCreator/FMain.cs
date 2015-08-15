using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace OrderSheetCreator
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            
            //恢复保存的窗体大小
            if (Properties.Settings.Default.Maximised)
            {
                WindowState = FormWindowState.Maximized;
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;

            }
            else if (Properties.Settings.Default.Minimised)
            {
                WindowState = FormWindowState.Minimized;
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
            else
            {
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;

            }

            //初始化dgv
            PublicTools.IniDatagridview(dataGridView1);

            //回复dgv的宽度设置
            PublicTools.RecoverColumnWidth(dataGridView1, "Fmaindgv.config");

            
        }

        private void FMain_Load(object sender, EventArgs e) 
        {

            lblDBStatus.Text = string.Format("数据库信息：{0}", PublicDB.getIniConnInfo("config.ini"));

            btnSearch_Click(null, null);

            this.Text = string.Format("{0}  Ver.{1}", PublicTools.AssemblyProduct, PublicTools.AssemblyVersion);

        }


        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存dgv的设置
            PublicTools.SaveColumnWidth(dataGridView1, "Fmaindgv.config");

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

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCainzOrderD m = new FCainzOrderD();
            m.StartPosition = FormStartPosition.CenterParent;
            m.ShowDialog();
            btnSearch_Click(null, null);

        }

        private void dataToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTools m = new DataTools();
            m.ShowDialog();
        }

        #region context menu methed

        private void lblDBStatus_Click(object sender, EventArgs e)
        {

                FDatabase m = new FDatabase();
                m.ShowDialog();
                lblDBStatus.Text = string.Format("数据库信息：{0}", PublicDB.getIniConnInfo("config.ini"));

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            entity.CainzOrder order = (entity.CainzOrder)cainzOrderBindingSource.Current;
            if (order != null)
            {
                if (MessageBox.Show(string.Format("是否删除该订单？ \n\n客户：{1} \n编号：{0} \n金额：{2}",order.OrderNo,order.FactoryName,order.Money.ToString("#.###")), "操作提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (var db = PublicDB.getDB())
                    {
                        order.IsDelete = 1;
                        db.CainzOrder.Attach(order);
                        db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    btnSearch_Click(null, null);
                }

            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            entity.CainzOrder order = (entity.CainzOrder)cainzOrderBindingSource.Current;
            if (order != null)
            {
                using (var db = PublicDB.getDB())
                {
                    order.Status = 1;
                    db.CainzOrder.Attach(order);
                    db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                btnSearch_Click(null, null);

            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            entity.CainzOrder order = (entity.CainzOrder)cainzOrderBindingSource.Current;
            if (order != null)
            {
                using (var db = PublicDB.getDB())
                {
                    order.Status = 0;
                    db.CainzOrder.Attach(order);
                    db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                btnSearch_Click(null, null);

            }
        }

        #endregion

        #region search order by multithreading

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(null, null);

            }
        }

        private void SearchForMain()
        {
            Frozen(true);
            entity.CainzOrder _orderForSearch = new entity.CainzOrder();
            _orderForSearch.OrderExNo = txbSearch.Text.Trim();
            _orderForSearch.TraderName = txbTraderForSearch.Text.Trim();

            BackgroundWorker work = new BackgroundWorker();
            work.DoWork += Work_DoWork;
            work.RunWorkerCompleted += Work_RunWorkerCompleted;
            OrdersArgs oa = new OrdersArgs();
            oa.OrderForSearch = _orderForSearch;
            work.RunWorkerAsync(oa);

        }

        private void SearchOrderBackgroud(OrdersArgs oa)
        {

            entity.CainzOrder o = oa.OrderForSearch;
            using (var db = PublicDB.getDB(60))
            {
                if (o == null)
                {
                    oa.Orders = (from a in db.CainzOrder
                              where a.IsDelete == 0 && (a.Status == 0 || a.Status == 1) 
                              orderby a.OrderDate
                              select a).ToList();
                }
                else
                {


                    oa.Orders = (from a in db.CainzOrder
                              where a.IsDelete == 0 && (a.Status == 0 || a.Status == 1) & (a.OrderExNo.Contains(o.OrderExNo) || a.OrderNo.Contains(o.OrderNo)) && a.TraderName.Contains(o.TraderName)
                              orderby a.OrderDate
                              select a).ToList();
                }
            }
        }


        private void Work_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Frozen(false);
            BindingList<entity.CainzOrder> _ol = (BindingList<entity.CainzOrder>)e.Result;
            if (_ol != null && _ol.Count > 0)
            {

                cainzOrderBindingSource.DataSource = _ol;
            }
            else
            {
                cainzOrderBindingSource.DataSource = new List<entity.CainzOrder>();

            }
            PublicTools.RecountRowsNum(dataGridView1);
            ReColorStatus();
        }

        private void Work_DoWork(object sender, DoWorkEventArgs e)
        {
            OrdersArgs oa =(OrdersArgs)e.Argument;
            SearchOrderBackgroud(oa);
            e.Result = new BindingList<entity.CainzOrder>(oa.Orders);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForMain();
        }

        private void txbTraderForSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }



        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var order = (entity.CainzOrder)cainzOrderBindingSource.Current;
            if (order != null)
            {
                FCainzOrderD m = new FCainzOrderD(order);
                Application.DoEvents();
                m.ShowDialog();
            }
            btnSearch_Click(null, null);

        }

        private void ReColorStatus()
        {

            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                var status = i.Cells["Status"].Value;
                if (status != null && (int)status == 1)
                {
                    if ((int)status == 1)
                    {
                        DataGridViewCellStyle dvcs = new DataGridViewCellStyle();
                        dvcs.BackColor = Color.LightGreen;
                        i.DefaultCellStyle = dvcs;
                        i.Cells["statusInfo"].Value = "已发货";
                    }
                    else if ((int)status == 0)
                    {
                        i.Cells["statusInfo"].Value = "未发货";

                    }

                }
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 m = new AboutBox1();
            m.ShowDialog();
        }

        private void Frozen(bool isEnable)
        {
            if(isEnable)
            {
                if(this.WindowState == FormWindowState.Maximized)
                {
                    Rectangle ScreenArea = System.Windows.Forms.Screen.GetWorkingArea(this);

                    pictureBox1.Location = new Point((ScreenArea.Width - pictureBox1.Width) / 2, (ScreenArea.Height - pictureBox1.Height) / 2 - 200);
                    pictureBox1.Visible = true;

                }
                else if(this.WindowState == FormWindowState.Normal)
                {
                    pictureBox1.Location = new Point((this.Size.Width - pictureBox1.Width) / 2, (this.Size.Height - pictureBox1.Height) / 2 - 200);
                    pictureBox1.Visible = true;

                }

                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                
            }
            else
            {
                panel1.Enabled = true;
                panel2.Enabled = true;
                panel3.Enabled = true;
                pictureBox1.Visible = false;

            }
            this.Refresh();
        }

    }

    public class OrdersArgs
    {
        public entity.CainzOrder OrderForSearch;
        public List<entity.CainzOrder> Orders;
    }
}
