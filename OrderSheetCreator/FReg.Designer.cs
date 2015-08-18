namespace OrderSheetCreator
{
    partial class FReg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCreate = new System.Windows.Forms.TextBox();
            this.txbReg = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "机器码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(53, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "注册号";
            // 
            // txbCreate
            // 
            this.txbCreate.Font = new System.Drawing.Font("宋体", 14F);
            this.txbCreate.Location = new System.Drawing.Point(115, 18);
            this.txbCreate.Name = "txbCreate";
            this.txbCreate.ReadOnly = true;
            this.txbCreate.Size = new System.Drawing.Size(204, 29);
            this.txbCreate.TabIndex = 1;
            // 
            // txbReg
            // 
            this.txbReg.Font = new System.Drawing.Font("宋体", 14F);
            this.txbReg.Location = new System.Drawing.Point(115, 55);
            this.txbReg.Name = "txbReg";
            this.txbReg.Size = new System.Drawing.Size(204, 29);
            this.txbReg.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 14F);
            this.btnSave.Location = new System.Drawing.Point(229, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "注册";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(0, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "请将机器码发给软件服务商，获取注册码，方可使用";
            // 
            // FReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 198);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbReg);
            this.Controls.Add(this.txbCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注册加密程序";
            this.Load += new System.EventHandler(this.FReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCreate;
        private System.Windows.Forms.TextBox txbReg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
    }
}