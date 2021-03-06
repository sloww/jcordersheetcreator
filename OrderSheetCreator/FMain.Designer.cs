﻿namespace OrderSheetCreator
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTraderForSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDBStatus = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderExNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caidan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOk = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReady = new System.Windows.Forms.ToolStripMenuItem();
            this.cainzOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.caidan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cainzOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 31);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.dataToolsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1174, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.newOrderToolStripMenuItem.Text = "新建订单";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.reportToolStripMenuItem.Text = "报表";
            this.reportToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.helpToolStripMenuItem.Text = "帮助";
            this.helpToolStripMenuItem.Visible = false;
            // 
            // dataToolsToolStripMenuItem
            // 
            this.dataToolsToolStripMenuItem.Name = "dataToolsToolStripMenuItem";
            this.dataToolsToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.dataToolsToolStripMenuItem.Text = "数据管理";
            this.dataToolsToolStripMenuItem.Visible = false;
            this.dataToolsToolStripMenuItem.Click += new System.EventHandler(this.dataToolsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(138, 27);
            this.clearToolStripMenuItem.Text = "清理订单明细";
            this.clearToolStripMenuItem.Visible = false;
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.updateToolStripMenuItem.Text = "更新记录";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTraderForSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 46);
            this.panel2.TabIndex = 1;
            // 
            // txbTraderForSearch
            // 
            this.txbTraderForSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.txbTraderForSearch.Location = new System.Drawing.Point(404, 10);
            this.txbTraderForSearch.MaxLength = 50;
            this.txbTraderForSearch.Name = "txbTraderForSearch";
            this.txbTraderForSearch.Size = new System.Drawing.Size(169, 26);
            this.txbTraderForSearch.TabIndex = 1;
            this.txbTraderForSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTraderForSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(308, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "贸易公司";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(613, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "合同编号";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.txbSearch.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbSearch.Location = new System.Drawing.Point(102, 10);
            this.txbSearch.MaxLength = 30;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(169, 26);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearch_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDBStatus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 735);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1174, 26);
            this.panel3.TabIndex = 2;
            // 
            // lblDBStatus
            // 
            this.lblDBStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDBStatus.AutoSize = true;
            this.lblDBStatus.Font = new System.Drawing.Font("宋体", 9F);
            this.lblDBStatus.Location = new System.Drawing.Point(6, 7);
            this.lblDBStatus.Name = "lblDBStatus";
            this.lblDBStatus.Size = new System.Drawing.Size(41, 12);
            this.lblDBStatus.TabIndex = 0;
            this.lblDBStatus.Text = "label2";
            this.lblDBStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1174, 658);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.orderNoDataGridViewTextBoxColumn,
            this.OrderExNo,
            this.TraderName,
            this.factoryNameDataGridViewTextBoxColumn,
            this.OrderDate,
            this.contactDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.statusInfo,
            this.sendDateDataGridViewTextBoxColumn,
            this.Status,
            this.createTimeDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.caidan;
            this.dataGridView1.DataSource = this.cainzOrderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 658);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "序";
            this.Column1.Name = "Column1";
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "我司订单编号";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            // 
            // OrderExNo
            // 
            this.OrderExNo.DataPropertyName = "OrderExNo";
            this.OrderExNo.HeaderText = "合同编号";
            this.OrderExNo.Name = "OrderExNo";
            // 
            // TraderName
            // 
            this.TraderName.DataPropertyName = "TraderName";
            this.TraderName.HeaderText = "所属贸易公司";
            this.TraderName.Name = "TraderName";
            // 
            // factoryNameDataGridViewTextBoxColumn
            // 
            this.factoryNameDataGridViewTextBoxColumn.DataPropertyName = "FactoryName";
            this.factoryNameDataGridViewTextBoxColumn.HeaderText = "订购工厂";
            this.factoryNameDataGridViewTextBoxColumn.Name = "factoryNameDataGridViewTextBoxColumn";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Format = "d";
            this.OrderDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDate.HeaderText = "下单日期";
            this.OrderDate.Name = "OrderDate";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "联系人(担当者)";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = "0";
            this.moneyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.moneyDataGridViewTextBoxColumn.HeaderText = "订单总价";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            // 
            // statusInfo
            // 
            this.statusInfo.HeaderText = "发货状态";
            this.statusInfo.Name = "statusInfo";
            // 
            // sendDateDataGridViewTextBoxColumn
            // 
            this.sendDateDataGridViewTextBoxColumn.DataPropertyName = "SendDate";
            dataGridViewCellStyle3.Format = "d";
            this.sendDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sendDateDataGridViewTextBoxColumn.HeaderText = "交货期(納品日)";
            this.sendDateDataGridViewTextBoxColumn.Name = "sendDateDataGridViewTextBoxColumn";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.Visible = false;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.createTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建日期";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            // 
            // caidan
            // 
            this.caidan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDelete,
            this.btnOk,
            this.btnReady});
            this.caidan.Name = "caidan";
            this.caidan.Size = new System.Drawing.Size(149, 70);
            this.caidan.Text = "删除订单";
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 22);
            this.btnDelete.Text = "删除订单";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOk
            // 
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(148, 22);
            this.btnOk.Text = "标记已发货";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnReady
            // 
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(148, 22);
            this.btnReady.Text = "标记为未发货";
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // cainzOrderBindingSource
            // 
            this.cainzOrderBindingSource.DataSource = typeof(entity.CainzOrder);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMain";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cainz 订单管理系统 v1.0.3 150815";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.SizeChanged += new System.EventHandler(this.FMain_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.caidan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cainzOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cainzOrderBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ToolStripMenuItem dataToolsToolStripMenuItem;
        private System.Windows.Forms.Label lblDBStatus;
        private System.Windows.Forms.ContextMenuStrip caidan;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnOk;
        private System.Windows.Forms.ToolStripMenuItem btnReady;
        private System.Windows.Forms.TextBox txbTraderForSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderExNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}