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
            this.lblFactory = new System.Windows.Forms.Label();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbCount = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbColor = new System.Windows.Forms.TextBox();
            this.txbSize = new System.Windows.Forms.TextBox();
            this.txbMaterial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "条码:";
            // 
            // txbSearchBarcode
            // 
            this.txbSearchBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearchBarcode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbSearchBarcode.Location = new System.Drawing.Point(65, 13);
            this.txbSearchBarcode.Name = "txbSearchBarcode";
            this.txbSearchBarcode.Size = new System.Drawing.Size(172, 33);
            this.txbSearchBarcode.TabIndex = 2;
            this.txbSearchBarcode.TextChanged += new System.EventHandler(this.txbBarcode_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFactory);
            this.panel1.Controls.Add(this.txbSearchBarcode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 54);
            this.panel1.TabIndex = 3;
            // 
            // lblFactory
            // 
            this.lblFactory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFactory.AutoSize = true;
            this.lblFactory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "FactoryName", true));
            this.lblFactory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFactory.Location = new System.Drawing.Point(367, 18);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFactory.Size = new System.Drawing.Size(0, 21);
            this.lblFactory.TabIndex = 14;
            this.lblFactory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(entity.CainzProduct);
            // 
            // txbCount
            // 
            this.txbCount.AllowDrop = true;
            this.txbCount.BackColor = System.Drawing.Color.White;
            this.txbCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCount.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbCount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txbCount.Location = new System.Drawing.Point(384, 61);
            this.txbCount.MaxLength = 5;
            this.txbCount.Name = "txbCount";
            this.txbCount.Size = new System.Drawing.Size(172, 26);
            this.txbCount.TabIndex = 12;
            this.txbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCount_KeyPress);
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00元", "#0.00元"));
            this.txbPrice.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbPrice.Location = new System.Drawing.Point(384, 18);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(172, 26);
            this.txbPrice.TabIndex = 11;
            this.txbPrice.TabStop = false;
            // 
            // txbColor
            // 
            this.txbColor.BackColor = System.Drawing.SystemColors.Control;
            this.txbColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Color", true));
            this.txbColor.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbColor.Location = new System.Drawing.Point(65, 143);
            this.txbColor.Name = "txbColor";
            this.txbColor.Size = new System.Drawing.Size(259, 26);
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
            this.txbSize.Location = new System.Drawing.Point(65, 102);
            this.txbSize.Name = "txbSize";
            this.txbSize.Size = new System.Drawing.Size(259, 26);
            this.txbSize.TabIndex = 9;
            this.txbSize.TabStop = false;
            // 
            // txbMaterial
            // 
            this.txbMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.txbMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaterial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Material", true));
            this.txbMaterial.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbMaterial.Location = new System.Drawing.Point(65, 61);
            this.txbMaterial.Name = "txbMaterial";
            this.txbMaterial.Size = new System.Drawing.Size(259, 26);
            this.txbMaterial.TabIndex = 8;
            this.txbMaterial.TabStop = false;
            this.txbMaterial.TextChanged += new System.EventHandler(this.txbMaterial_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(329, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "数量:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(330, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "单价:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "颜色:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "尺寸:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMaterial.Location = new System.Drawing.Point(8, 60);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(55, 25);
            this.lblMaterial.TabIndex = 3;
            this.lblMaterial.Text = "材质:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txbReMarK);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnContinue);
            this.panel2.Controls.Add(this.txbCount);
            this.panel2.Controls.Add(this.txbPrice);
            this.panel2.Controls.Add(this.lblMaterial);
            this.panel2.Controls.Add(this.txbColor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbSize);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txbBarcode);
            this.panel2.Controls.Add(this.txbMaterial);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 194);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "条码:";
            // 
            // txbReMarK
            // 
            this.txbReMarK.BackColor = System.Drawing.Color.White;
            this.txbReMarK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbReMarK.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbReMarK.Location = new System.Drawing.Point(384, 100);
            this.txbReMarK.Name = "txbReMarK";
            this.txbReMarK.Size = new System.Drawing.Size(172, 26);
            this.txbReMarK.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(330, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "备注:";
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("宋体", 12F);
            this.btnContinue.Location = new System.Drawing.Point(618, 60);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(143, 51);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "保存";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txbBarcode
            // 
            this.txbBarcode.BackColor = System.Drawing.SystemColors.Control;
            this.txbBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBarcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Barcode", true));
            this.txbBarcode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbBarcode.Location = new System.Drawing.Point(65, 20);
            this.txbBarcode.Name = "txbBarcode";
            this.txbBarcode.ReadOnly = true;
            this.txbBarcode.Size = new System.Drawing.Size(259, 26);
            this.txbBarcode.TabIndex = 8;
            this.txbBarcode.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 235);
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
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(784, 235);
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
            this.Column1.Width = 42;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "条码";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 54;
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
            this.Color.Width = 54;
            // 
            // popSize
            // 
            this.popSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.popSize.DataPropertyName = "Size";
            this.popSize.HeaderText = "尺寸";
            this.popSize.Name = "popSize";
            this.popSize.ReadOnly = true;
            this.popSize.Width = 54;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 483);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
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
        private System.Windows.Forms.Label lblFactory;
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
    }
}