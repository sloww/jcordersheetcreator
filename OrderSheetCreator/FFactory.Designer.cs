namespace OrderSheetCreator
{
    partial class FFactory
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
            this.btnOK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cainzCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFactory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbDELdate = new System.Windows.Forms.TextBox();
            this.txbFactory = new System.Windows.Forms.TextBox();
            this.txbTrader = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHidden = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cainzCustomerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOK.Location = new System.Drawing.Point(842, 56);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(143, 51);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 275);
            this.panel3.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.factoryNameDataGridViewTextBoxColumn,
            this.traderDataGridViewTextBoxColumn,
            this.sendAddressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cainzCustomerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "序";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // factoryNameDataGridViewTextBoxColumn
            // 
            this.factoryNameDataGridViewTextBoxColumn.DataPropertyName = "FactoryName";
            this.factoryNameDataGridViewTextBoxColumn.HeaderText = "订购工厂";
            this.factoryNameDataGridViewTextBoxColumn.Name = "factoryNameDataGridViewTextBoxColumn";
            this.factoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // traderDataGridViewTextBoxColumn
            // 
            this.traderDataGridViewTextBoxColumn.DataPropertyName = "Trader";
            this.traderDataGridViewTextBoxColumn.HeaderText = "所属贸易公司";
            this.traderDataGridViewTextBoxColumn.Name = "traderDataGridViewTextBoxColumn";
            this.traderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sendAddressDataGridViewTextBoxColumn
            // 
            this.sendAddressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.sendAddressDataGridViewTextBoxColumn.HeaderText = "交货地址";
            this.sendAddressDataGridViewTextBoxColumn.Name = "sendAddressDataGridViewTextBoxColumn";
            this.sendAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "联系人";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cainzCustomerBindingSource
            // 
            this.cainzCustomerBindingSource.DataSource = typeof(entity.CainzCustomer);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "条码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblFactory
            // 
            this.lblFactory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFactory.AutoSize = true;
            this.lblFactory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFactory.Location = new System.Drawing.Point(591, 27);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFactory.Size = new System.Drawing.Size(0, 21);
            this.lblFactory.TabIndex = 14;
            this.lblFactory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFactory);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 63);
            this.panel1.TabIndex = 6;
            // 
            // txbSearch
            // 
            this.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearch.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbSearch.Location = new System.Drawing.Point(206, 16);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(217, 33);
            this.txbSearch.TabIndex = 2;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "订购工厂（支持首字母）：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Controls.Add(this.txbDELdate);
            this.panel2.Controls.Add(this.txbFactory);
            this.panel2.Controls.Add(this.txbTrader);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 188);
            this.panel2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cainzCustomerBindingSource, "Address", true));
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(305, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(531, 19);
            this.textBox1.TabIndex = 34;
            this.textBox1.TabStop = false;
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.Control;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cainzCustomerBindingSource, "Contact", true));
            this.txbName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txbName.Location = new System.Drawing.Point(140, 107);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(144, 19);
            this.txbName.TabIndex = 33;
            this.txbName.TabStop = false;
            // 
            // txbDELdate
            // 
            this.txbDELdate.BackColor = System.Drawing.SystemColors.Control;
            this.txbDELdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDELdate.Font = new System.Drawing.Font("宋体", 12F);
            this.txbDELdate.Location = new System.Drawing.Point(433, 104);
            this.txbDELdate.Name = "txbDELdate";
            this.txbDELdate.Size = new System.Drawing.Size(267, 19);
            this.txbDELdate.TabIndex = 32;
            this.txbDELdate.TabStop = false;
            // 
            // txbFactory
            // 
            this.txbFactory.BackColor = System.Drawing.SystemColors.Control;
            this.txbFactory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFactory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cainzCustomerBindingSource, "FactoryName", true));
            this.txbFactory.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txbFactory.Location = new System.Drawing.Point(250, 47);
            this.txbFactory.Name = "txbFactory";
            this.txbFactory.ReadOnly = true;
            this.txbFactory.Size = new System.Drawing.Size(523, 19);
            this.txbFactory.TabIndex = 31;
            this.txbFactory.TabStop = false;
            // 
            // txbTrader
            // 
            this.txbTrader.BackColor = System.Drawing.SystemColors.Control;
            this.txbTrader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTrader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cainzCustomerBindingSource, "Trader", true));
            this.txbTrader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txbTrader.Location = new System.Drawing.Point(206, 17);
            this.txbTrader.Name = "txbTrader";
            this.txbTrader.ReadOnly = true;
            this.txbTrader.Size = new System.Drawing.Size(567, 19);
            this.txbTrader.TabIndex = 30;
            this.txbTrader.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(10, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(296, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "交货地址/电话（納品住所/電話番号）：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(10, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "所属贸易公司（商社名）：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(10, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "订购工厂［工場名（発注者）］：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "联系人(担当者)：　";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(689, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(689, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(689, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(689, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnHidden);
            this.panel4.Controls.Add(this.btnSaveToDB);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 49);
            this.panel4.TabIndex = 35;
            // 
            // btnHidden
            // 
            this.btnHidden.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHidden.Font = new System.Drawing.Font("宋体", 12F);
            this.btnHidden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHidden.Location = new System.Drawing.Point(869, 5);
            this.btnHidden.Name = "btnHidden";
            this.btnHidden.Size = new System.Drawing.Size(126, 38);
            this.btnHidden.TabIndex = 20;
            this.btnHidden.Text = "隐藏此界面";
            this.btnHidden.UseVisualStyleBackColor = false;
            this.btnHidden.Click += new System.EventHandler(this.btnHidden_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveToDB.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSaveToDB.ForeColor = System.Drawing.Color.White;
            this.btnSaveToDB.Location = new System.Drawing.Point(11, 5);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(126, 38);
            this.btnSaveToDB.TabIndex = 19;
            this.btnSaveToDB.Text = "更新到数据库!";
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnShow.Font = new System.Drawing.Font("宋体", 12F);
            this.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Location = new System.Drawing.Point(879, 144);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(126, 38);
            this.btnShow.TabIndex = 36;
            this.btnShow.Text = "显示管理界面";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 526);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FFactory";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择订货工厂";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FFactory_FormClosing);
            this.Load += new System.EventHandler(this.FFactory_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cainzCustomerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblFactory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource cainzCustomerBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbDELdate;
        private System.Windows.Forms.TextBox txbFactory;
        private System.Windows.Forms.TextBox txbTrader;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHidden;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnShow;
    }
}