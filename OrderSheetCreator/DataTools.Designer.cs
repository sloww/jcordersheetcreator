namespace OrderSheetCreator
{
    partial class DataTools
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGetMaoyisTXT = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFactory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImportFactory = new System.Windows.Forms.Button();
            this.btnCainzMaoyis = new System.Windows.Forms.Button();
            this.btnBlind = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImportProductData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "导入贸易商数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "获取工厂和贸易商";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofd";
            // 
            // btnGetMaoyisTXT
            // 
            this.btnGetMaoyisTXT.Location = new System.Drawing.Point(239, 19);
            this.btnGetMaoyisTXT.Name = "btnGetMaoyisTXT";
            this.btnGetMaoyisTXT.Size = new System.Drawing.Size(122, 49);
            this.btnGetMaoyisTXT.TabIndex = 4;
            this.btnGetMaoyisTXT.Text = "获取贸易商txt清单";
            this.btnGetMaoyisTXT.UseVisualStyleBackColor = true;
            this.btnGetMaoyisTXT.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(695, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "绑定工厂和贸易商关系";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(860, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 49);
            this.button5.TabIndex = 6;
            this.button5.Text = "导入excel 万能表-产品数据";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFactory);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnGetMaoyisTXT);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 85);
            this.panel1.TabIndex = 7;
            // 
            // btnFactory
            // 
            this.btnFactory.Location = new System.Drawing.Point(543, 19);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(122, 49);
            this.btnFactory.TabIndex = 7;
            this.btnFactory.Text = "获取工厂 txt 清单";
            this.btnFactory.UseVisualStyleBackColor = true;
            this.btnFactory.Click += new System.EventHandler(this.btnFactory_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImportProductData);
            this.panel2.Controls.Add(this.btnImportFactory);
            this.panel2.Controls.Add(this.btnCainzMaoyis);
            this.panel2.Controls.Add(this.btnBlind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 100);
            this.panel2.TabIndex = 8;
            // 
            // btnImportFactory
            // 
            this.btnImportFactory.Location = new System.Drawing.Point(543, 26);
            this.btnImportFactory.Name = "btnImportFactory";
            this.btnImportFactory.Size = new System.Drawing.Size(122, 49);
            this.btnImportFactory.TabIndex = 8;
            this.btnImportFactory.Text = "导入工厂信息";
            this.btnImportFactory.UseVisualStyleBackColor = true;
            this.btnImportFactory.Click += new System.EventHandler(this.btnImportFactory_Click);
            // 
            // btnCainzMaoyis
            // 
            this.btnCainzMaoyis.Location = new System.Drawing.Point(391, 26);
            this.btnCainzMaoyis.Name = "btnCainzMaoyis";
            this.btnCainzMaoyis.Size = new System.Drawing.Size(122, 49);
            this.btnCainzMaoyis.TabIndex = 0;
            this.btnCainzMaoyis.Text = "导入贸易商数据";
            this.btnCainzMaoyis.UseVisualStyleBackColor = true;
            this.btnCainzMaoyis.Click += new System.EventHandler(this.btnCainzMaoyis_Click);
            // 
            // btnBlind
            // 
            this.btnBlind.Location = new System.Drawing.Point(695, 26);
            this.btnBlind.Name = "btnBlind";
            this.btnBlind.Size = new System.Drawing.Size(135, 49);
            this.btnBlind.TabIndex = 5;
            this.btnBlind.Text = "绑定工厂和贸易商关系";
            this.btnBlind.UseVisualStyleBackColor = true;
            this.btnBlind.Click += new System.EventHandler(this.btnBlind_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(entity.Customer);
            // 
            // btnImportProductData
            // 
            this.btnImportProductData.Location = new System.Drawing.Point(860, 26);
            this.btnImportProductData.Name = "btnImportProductData";
            this.btnImportProductData.Size = new System.Drawing.Size(173, 49);
            this.btnImportProductData.TabIndex = 9;
            this.btnImportProductData.Text = "导入产品数据";
            this.btnImportProductData.UseVisualStyleBackColor = true;
            this.btnImportProductData.Click += new System.EventHandler(this.btnImportProductData_Click);
            // 
            // DataTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DataTools";
            this.Text = "景辰ERP数据维护管理工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGetMaoyisTXT;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFactory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCainzMaoyis;
        private System.Windows.Forms.Button btnImportFactory;
        private System.Windows.Forms.Button btnBlind;
        private System.Windows.Forms.Button btnImportProductData;
    }
}

