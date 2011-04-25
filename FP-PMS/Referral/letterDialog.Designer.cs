namespace FP_PMS.Referral
{
    partial class letterDialog
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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.thankyouLetterRichEdit = new DevExpress.XtraRichEdit.RichEditControl();
            this.printBtn = new DevExpress.XtraEditors.SimpleButton();
            this.emailBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(623, 423);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Quit";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.thankyouLetterRichEdit);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(709, 417);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Contents";
            // 
            // thankyouLetterRichEdit
            // 
            this.thankyouLetterRichEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thankyouLetterRichEdit.Location = new System.Drawing.Point(2, 22);
            this.thankyouLetterRichEdit.Name = "thankyouLetterRichEdit";
            this.thankyouLetterRichEdit.Size = new System.Drawing.Size(705, 393);
            this.thankyouLetterRichEdit.TabIndex = 3;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(12, 423);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 3;
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // emailBtn
            // 
            this.emailBtn.Location = new System.Drawing.Point(93, 423);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(75, 23);
            this.emailBtn.TabIndex = 4;
            this.emailBtn.Text = "Email";
            this.emailBtn.Click += new System.EventHandler(this.emailBtn_Click);
            // 
            // letterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.emailBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton2);
            this.Name = "letterDialog";
            this.Text = "Thank you Letter";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraRichEdit.RichEditControl thankyouLetterRichEdit;
        private DevExpress.XtraEditors.SimpleButton printBtn;
        private DevExpress.XtraEditors.SimpleButton emailBtn;

    }
}