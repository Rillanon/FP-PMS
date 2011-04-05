namespace FP_PMS.Scheduling
{
    partial class findForm
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
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.quitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchTermTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTermTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(124, 48);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "Find";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(205, 48);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 2;
            this.quitBtn.Text = "Quit";
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // searchTermTextEdit
            // 
            this.searchTermTextEdit.Location = new System.Drawing.Point(12, 12);
            this.searchTermTextEdit.Name = "searchTermTextEdit";
            this.searchTermTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTermTextEdit.Properties.Appearance.Options.UseFont = true;
            this.searchTermTextEdit.Size = new System.Drawing.Size(268, 29);
            this.searchTermTextEdit.TabIndex = 0;
            // 
            // findForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 83);
            this.Controls.Add(this.searchTermTextEdit);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "findForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find a Patient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.findForm_FormClosing);
            this.Load += new System.EventHandler(this.findForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.searchTermTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraEditors.SimpleButton quitBtn;
        private DevExpress.XtraEditors.TextEdit searchTermTextEdit;
    }
}