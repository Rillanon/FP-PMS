namespace FP_PMS.Templates
{
    partial class level3TemplateForm
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
            this.quitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(154, 111);
            this.quitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(56, 19);
            this.quitBtn.TabIndex = 7;
            this.quitBtn.Text = "Quit";
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(94, 111);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(56, 19);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // level3TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 140);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.okBtn);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "level3TemplateForm";
            this.Text = "level3TemplateForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.level3TemplateForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.level3TemplateForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton quitBtn;
        public DevExpress.XtraEditors.SimpleButton okBtn;

    }
}