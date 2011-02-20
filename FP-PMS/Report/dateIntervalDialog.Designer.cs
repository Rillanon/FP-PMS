namespace FP_PMS.Report
{
    partial class dateIntervalDialog
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.startDatePicker = new DevExpress.XtraEditors.DateEdit();
            this.endDatePicker = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(278, 79);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(218, 79);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Start Date";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "End Date";
            // 
            // startDatePicker
            // 
            this.startDatePicker.EditValue = null;
            this.startDatePicker.Location = new System.Drawing.Point(129, 22);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDatePicker.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.startDatePicker.Size = new System.Drawing.Size(205, 20);
            this.startDatePicker.TabIndex = 10;
            this.startDatePicker.EditValueChanged += new System.EventHandler(this.startDatePicker_EditValueChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.EditValue = null;
            this.endDatePicker.Location = new System.Drawing.Point(129, 47);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDatePicker.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.endDatePicker.Size = new System.Drawing.Size(205, 20);
            this.endDatePicker.TabIndex = 11;
            this.endDatePicker.EditValueChanged += new System.EventHandler(this.endDatePicker_EditValueChanged);
            // 
            // dateIntervalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(362, 115);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "dateIntervalDialog";
            this.Text = "Pick a date interval";
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.startDatePicker, 0);
            this.Controls.SetChildIndex(this.endDatePicker, 0);
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit startDatePicker;
        private DevExpress.XtraEditors.DateEdit endDatePicker;
    }
}
