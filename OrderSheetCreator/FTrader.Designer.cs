namespace OrderSheetCreator
{
    partial class FTrader
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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cainzTraderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.traderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traderShortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbSheet = new System.Windows.Forms.TextBox();
            this.txbBarcode = new System.Windows.Forms.TextBox();
            this.txbMaterial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cainzTraderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(31, 46);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(282, 21);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.traderIDDataGridViewTextBoxColumn,
            this.traderNameDataGridViewTextBoxColumn,
            this.traderShortNameDataGridViewTextBoxColumn,
            this.isDeleteDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cainzTraderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(696, 314);
            this.dataGridView1.TabIndex = 1;
            // 
            // cainzTraderBindingSource
            // 
            this.cainzTraderBindingSource.DataSource = typeof(entity.CainzTrader);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(379, 70);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "button1";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // traderIDDataGridViewTextBoxColumn
            // 
            this.traderIDDataGridViewTextBoxColumn.DataPropertyName = "TraderID";
            this.traderIDDataGridViewTextBoxColumn.HeaderText = "TraderID";
            this.traderIDDataGridViewTextBoxColumn.Name = "traderIDDataGridViewTextBoxColumn";
            // 
            // traderNameDataGridViewTextBoxColumn
            // 
            this.traderNameDataGridViewTextBoxColumn.DataPropertyName = "TraderName";
            this.traderNameDataGridViewTextBoxColumn.HeaderText = "TraderName";
            this.traderNameDataGridViewTextBoxColumn.Name = "traderNameDataGridViewTextBoxColumn";
            // 
            // traderShortNameDataGridViewTextBoxColumn
            // 
            this.traderShortNameDataGridViewTextBoxColumn.DataPropertyName = "TraderShortName";
            this.traderShortNameDataGridViewTextBoxColumn.HeaderText = "TraderShortName";
            this.traderShortNameDataGridViewTextBoxColumn.Name = "traderShortNameDataGridViewTextBoxColumn";
            // 
            // isDeleteDataGridViewTextBoxColumn
            // 
            this.isDeleteDataGridViewTextBoxColumn.DataPropertyName = "IsDelete";
            this.isDeleteDataGridViewTextBoxColumn.HeaderText = "IsDelete";
            this.isDeleteDataGridViewTextBoxColumn.Name = "isDeleteDataGridViewTextBoxColumn";
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // txbSheet
            // 
            this.txbSheet.Location = new System.Drawing.Point(532, 12);
            this.txbSheet.Name = "txbSheet";
            this.txbSheet.Size = new System.Drawing.Size(133, 21);
            this.txbSheet.TabIndex = 3;
            // 
            // txbBarcode
            // 
            this.txbBarcode.Location = new System.Drawing.Point(532, 46);
            this.txbBarcode.Name = "txbBarcode";
            this.txbBarcode.Size = new System.Drawing.Size(133, 21);
            this.txbBarcode.TabIndex = 3;
            // 
            // txbMaterial
            // 
            this.txbMaterial.Location = new System.Drawing.Point(532, 73);
            this.txbMaterial.Name = "txbMaterial";
            this.txbMaterial.Size = new System.Drawing.Size(133, 21);
            this.txbMaterial.TabIndex = 3;
            // 
            // FTrader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 467);
            this.Controls.Add(this.txbMaterial);
            this.Controls.Add(this.txbBarcode);
            this.Controls.Add(this.txbSheet);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbSearch);
            this.Name = "FTrader";
            this.Text = "FTrader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cainzTraderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cainzTraderBindingSource;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn traderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traderShortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDeleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txbSheet;
        private System.Windows.Forms.TextBox txbBarcode;
        private System.Windows.Forms.TextBox txbMaterial;
    }
}