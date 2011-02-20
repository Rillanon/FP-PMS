namespace FP_PMS.Scheduling
{
    partial class appointUnAvailViewForm
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
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.timeEdit2 = new DevExpress.XtraEditors.TimeEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(295, 186);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(235, 186);
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2011, 2, 16, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(74, 105);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEdit1.Properties.Appearance.Options.UseFont = true;
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeEdit1.Properties.Mask.EditMask = "t";
            this.timeEdit1.Size = new System.Drawing.Size(100, 26);
            this.timeEdit1.TabIndex = 6;
            // 
            // timeEdit2
            // 
            this.timeEdit2.EditValue = new System.DateTime(2011, 2, 16, 0, 0, 0, 0);
            this.timeEdit2.Location = new System.Drawing.Point(200, 105);
            this.timeEdit2.Name = "timeEdit2";
            this.timeEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEdit2.Properties.Appearance.Options.UseFont = true;
            this.timeEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeEdit2.Properties.Mask.EditMask = "t";
            this.timeEdit2.Size = new System.Drawing.Size(100, 26);
            this.timeEdit2.TabIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.timeEdit1);
            this.groupControl1.Controls.Add(this.timeEdit2);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(362, 181);
            this.groupControl1.TabIndex = 8;
            // 
            // appointUnAvailViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(362, 213);
            this.Controls.Add(this.groupControl1);
            this.Name = "appointUnAvailViewForm";
            this.Text = "Unavailable Date/Time";
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraEditors.TimeEdit timeEdit2;
        private DevExpress.XtraEditors.GroupControl groupControl1;

    }
}
