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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCainzOrderD m = new FCainzOrderD();
            m.StartPosition = FormStartPosition.CenterParent;
            m.ShowDialog();
            SearchOrder("","");

        }

        private void FMain_Load(object sender, EventArgs e) 
        {
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


            lblDBStatus.Text = string.Format("数据库信息：{0}", PublicDB.getIniConnInfo("config.ini"));


        }

        private void SearchOrder(string OrderExNo, string TraderName)
        {
            OrderExNo = OrderExNo.Trim();
            TraderName = TraderName.Trim();
            using (var db = PublicDB.getDB(60))
            {
                List<entity.CainzOrder> orderList;

                orderList = (from a in db.CainzOrder
                             where a.IsDelete == 0 && (a.Status == 0 || a.Status == 1) & (a.OrderExNo.Contains(OrderExNo) || a.OrderNo.Contains(OrderExNo)) && a.TraderName.Contains(TraderName)
                             orderby a.OrderDate
                             select a).ToList();



                if (orderList != null && orderList.Count > 0)
                {

                    cainzOrderBindingSource.DataSource = orderList;
                }
                else
                {
                    cainzOrderBindingSource.DataSource = new List<entity.CainzOrder>();

                    // MessageBox.Show("查询结果为空");
                }
            }
            PublicTools.RecountRowsNum(dataGridView1);

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForMain();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var order = (entity.CainzOrder)cainzOrderBindingSource.Current;
            if (order != null)
            {
                FCainzOrderD m = new FCainzOrderD(order);
                m.ShowDialog();
            }
            SearchOrder("","");

        }

        private void dataToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTools m = new DataTools();
            m.ShowDialog();
        }

        private void lblDBStatus_Click(object sender, EventArgs e)
        {
            FDatabase m = new FDatabase();
            m.ShowDialog();
            lblDBStatus.Text = string.Format("数据库信息：{0}", PublicDB.getIniConnInfo("config.ini"));

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            entity.CainzOrder order = (entity.CainzOrder)cainzOrderBindingSource.Current;
            if(order !=null)
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

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(char)Keys.Enter)
            {
                btnSearch_Click(null, null);

            }
        }

        private void txbTraderForSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void SearchForMain()
        {
            SearchOrder(txbSearch.Text.Trim(), txbTraderForSearch.Text.Trim());
            if (dataGridView1.Rows.Count == 0)
            {
                PublicTools.Message404("没有记录");
            }
            ReColorStatus();
        }
    }
}
