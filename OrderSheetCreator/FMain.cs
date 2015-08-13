﻿using System;
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
            Search("");

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

        private void Search(string OrderExNo)
        {
            OrderExNo=OrderExNo.Trim();
            using (var db = PublicDB.getDB(60))

            {
                List<entity.CainzOrder> orderList;
                if (OrderExNo.Trim().Length == 0)
                {
                    orderList = (from a in db.CainzOrder
                                 where a.IsDelete == 0 && (a.Status == 0 || a.Status == 1)
                                 orderby a.OrderDate
                                 select a).ToList();
                }
                else
                {
                    orderList = (from a in db.CainzOrder
                                 where a.IsDelete == 0 && a.OrderExNo.Contains(OrderExNo)
                                 orderby a.OrderDate
                                 select a).ToList();
                }

                if (orderList != null && orderList.Count>0)
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
            Search(txbSearch.Text.Trim());
            if(dataGridView1.Rows.Count==0)
            {
                PublicTools.Message404("没有记录");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var order = (entity.CainzOrder)cainzOrderBindingSource.Current;
            if (order != null)
            {
                FCainzOrderD m = new FCainzOrderD(order);
                m.ShowDialog();
            }
            Search("");

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
    }
}
