namespace Reg
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txbCreate = new System.Windows.Forms.TextBox();
            this.txbReg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbCreate
            // 
            this.txbCreate.Font = new System.Drawing.Font("宋体", 20F);
            this.txbCreate.Location = new System.Drawing.Point(62, 33);
            this.txbCreate.Name = "txbCreate";
            this.txbCreate.Size = new System.Drawing.Size(215, 38);
            this.txbCreate.TabIndex = 0;
            this.txbCreate.TextChanged += new System.EventHandler(this.txbCreate_TextChanged);
            // 
            // txbReg
            // 
            this.txbReg.Font = new System.Drawing.Font("宋体", 20F);
            this.txbReg.Location = new System.Drawing.Point(62, 96);
            this.txbReg.Name = "txbReg";
            this.txbReg.Size = new System.Drawing.Size(215, 38);
            this.txbReg.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 229);
            this.Controls.Add(this.txbReg);
            this.Controls.Add(this.txbCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCreate;
        private System.Windows.Forms.TextBox txbReg;
    }
}

