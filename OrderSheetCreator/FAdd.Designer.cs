namespace OrderSheetCreator
{
    partial class FAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearchBarcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbCount = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbColor = new System.Windows.Forms.TextBox();
            this.txbSize = new System.Windows.Forms.TextBox();
            this.txbMaterial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTrader = new System.Windows.Forms.TextBox();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbIssuedDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbReMarK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txbBarcode = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "条码:";
            // 
            // txbSearchBarcode
            // 
            this.txbSearchBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearchBarcode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbSearchBarcode.Location = new System.Drawing.Point(87, 16);
            this.txbSearchBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchBarcode.Name = "txbSearchBarcode";
            this.txbSearchBarcode.Size = new System.Drawing.Size(229, 39);
            this.txbSearchBarcode.TabIndex = 2;
            this.txbSearchBarcode.TextChanged += new System.EventHandler(this.txbSearchBarcode_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSearchBarcode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSaveToDB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 79);
            this.panel1.TabIndex = 3;
            // 
            // txbCount
            // 
            this.txbCount.AllowDrop = true;
            this.txbCount.BackColor = System.Drawing.Color.White;
            this.txbCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCount.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbCount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txbCount.Location = new System.Drawing.Point(531, 78);
            this.txbCount.Margin = new System.Windows.Forms.Padding(4);
            this.txbCount.MaxLength = 5;
            this.txbCount.Name = "txbCount";
            this.txbCount.Size = new System.Drawing.Size(229, 32);
            this.txbCount.TabIndex = 12;
            this.txbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCount_KeyPress);
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00元", "#0.00元"));
            this.txbPrice.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbPrice.Location = new System.Drawing.Point(531, 26);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(229, 32);
            this.txbPrice.TabIndex = 11;
            this.txbPrice.TabStop = false;
            this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrice_KeyPress);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(entity.CainzProduct);
            this.productsBindingSource.CurrentItemChanged += new System.EventHandler(this.productsBindingSource_CurrentItemChanged);
            // 
            // txbColor
            // 
            this.txbColor.BackColor = System.Drawing.SystemColors.Control;
            this.txbColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Color", true));
            this.txbColor.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbColor.Location = new System.Drawing.Point(92, 185);
            this.txbColor.Margin = new System.Windows.Forms.Padding(4);
            this.txbColor.Name = "txbColor";
            this.txbColor.Size = new System.Drawing.Size(345, 32);
            this.txbColor.TabIndex = 10;
            this.txbColor.TabStop = false;
            // 
            // txbSize
            // 
            this.txbSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbSize.BackColor = System.Drawing.SystemColors.Control;
            this.txbSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Size", true));
            this.txbSize.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbSize.Location = new System.Drawing.Point(92, 132);
            this.txbSize.Margin = new System.Windows.Forms.Padding(4);
            this.txbSize.Name = "txbSize";
            this.txbSize.Size = new System.Drawing.Size(345, 32);
            this.txbSize.TabIndex = 9;
            this.txbSize.TabStop = false;
            // 
            // txbMaterial
            // 
            this.txbMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.txbMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaterial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Material", true));
            this.txbMaterial.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbMaterial.Location = new System.Drawing.Point(92, 79);
            this.txbMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaterial.Name = "txbMaterial";
            this.txbMaterial.Size = new System.Drawing.Size(345, 32);
            this.txbMaterial.TabIndex = 8;
            this.txbMaterial.TabStop = false;
            this.txbMaterial.TextChanged += new System.EventHandler(this.txbMaterial_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(439, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 40);
            this.label6.TabIndex = 7;
            this.label6.Text = "数量:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(440, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "单价:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(11, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "颜色:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "尺寸:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMaterial.Location = new System.Drawing.Point(11, 76);
            this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(68, 31);
            this.lblMaterial.TabIndex = 3;
            this.lblMaterial.Text = "材质:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txbColor);
            this.panel2.Controls.Add(this.txbTrader);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txbIssuedDate);
            this.panel2.Controls.Add(this.txbReMarK);
            this.panel2.Controls.Add(this.btnContinue);
            this.panel2.Controls.Add(this.txbCount);
            this.panel2.Controls.Add(this.txbPrice);
            this.panel2.Controls.Add(this.lblMaterial);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbSize);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txbBarcode);
            this.panel2.Controls.Add(this.txbMaterial);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 322);
            this.panel2.TabIndex = 4;
            // 
            // txbTrader
            // 
            this.txbTrader.BackColor = System.Drawing.SystemColors.Control;
            this.txbTrader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTrader.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbTrader.Location = new System.Drawing.Point(116, 238);
            this.txbTrader.Margin = new System.Windows.Forms.Padding(4);
            this.txbTrader.Name = "txbTrader";
            this.txbTrader.Size = new System.Drawing.Size(316, 32);
            this.txbTrader.TabIndex = 10;
            this.txbTrader.TabStop = false;
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveToDB.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSaveToDB.ForeColor = System.Drawing.Color.White;
            this.btnSaveToDB.Location = new System.Drawing.Point(777, 17);
            this.btnSaveToDB.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(168, 47);
            this.btnSaveToDB.TabIndex = 19;
            this.btnSaveToDB.Text = "更新到产品库!";
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(11, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "贸易商：";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDelete.Location = new System.Drawing.Point(850, 224);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 64);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "从订单删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(11, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "条码:";
            // 
            // txbIssuedDate
            // 
            this.txbIssuedDate.BackColor = System.Drawing.Color.White;
            this.txbIssuedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIssuedDate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbIssuedDate.Location = new System.Drawing.Point(531, 132);
            this.txbIssuedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbIssuedDate.Name = "txbIssuedDate";
            this.txbIssuedDate.Size = new System.Drawing.Size(229, 32);
            this.txbIssuedDate.TabIndex = 15;
            this.txbIssuedDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIssuedDate_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(440, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "交期:";
            // 
            // txbReMarK
            // 
            this.txbReMarK.BackColor = System.Drawing.Color.White;
            this.txbReMarK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbReMarK.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbReMarK.Location = new System.Drawing.Point(531, 185);
            this.txbReMarK.Margin = new System.Windows.Forms.Padding(4);
            this.txbReMarK.Name = "txbReMarK";
            this.txbReMarK.Size = new System.Drawing.Size(229, 32);
            this.txbReMarK.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(440, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 40);
            this.label8.TabIndex = 14;
            this.label8.Text = "备注:";
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("宋体", 12F);
            this.btnContinue.Location = new System.Drawing.Point(850, 118);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(191, 64);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "添加到订单";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txbBarcode
            // 
            this.txbBarcode.BackColor = System.Drawing.SystemColors.Control;
            this.txbBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBarcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Barcode", true));
            this.txbBarcode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbBarcode.Location = new System.Drawing.Point(92, 26);
            this.txbBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txbBarcode.Name = "txbBarcode";
            this.txbBarcode.ReadOnly = true;
            this.txbBarcode.Size = new System.Drawing.Size(345, 32);
            this.txbBarcode.TabIndex = 8;
            this.txbBarcode.TabStop = false;
            this.txbBarcode.TextChanged += new System.EventHandler(this.txbBarcode_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1045, 203);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Barcode,
            this.FactoryName,
            this.FactoryID,
            this.Material,
            this.Color,
            this.popSize,
            this.Price,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column1.HeaderText = "序";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 47;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "条码";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 62;
            // 
            // FactoryName
            // 
            this.FactoryName.DataPropertyName = "FactoryName";
            this.FactoryName.HeaderText = "FactoryName";
            this.FactoryName.Name = "FactoryName";
            this.FactoryName.ReadOnly = true;
            this.FactoryName.Visible = false;
            // 
            // FactoryID
            // 
            this.FactoryID.DataPropertyName = "FactoryID";
            this.FactoryID.HeaderText = "FactoryID";
            this.FactoryID.Name = "FactoryID";
            this.FactoryID.ReadOnly = true;
            this.FactoryID.Visible = false;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.DataPropertyName = "Material";
            this.Material.HeaderText = "材质";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "颜色";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 62;
            // 
            // popSize
            // 
            this.popSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.popSize.DataPropertyName = "Size";
            this.popSize.HeaderText = "尺寸";
            this.popSize.Name = "popSize";
            this.popSize.ReadOnly = true;
            this.popSize.Width = 62;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0";
            this.Price.DefaultCellStyle = dataGridViewCellStyle10;
            this.Price.HeaderText = "单价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "条码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 604);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " 添加产品";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAdd_FormClosing);
            this.Load += new System.EventHandler(this.FAdd_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FAdd_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearchBarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbCount;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbColor;
        private System.Windows.Forms.TextBox txbSize;
        private System.Windows.Forms.TextBox txbMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txbReMarK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn popSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbIssuedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTrader;
        private System.Windows.Forms.Button btnSaveToDB;
    }
}