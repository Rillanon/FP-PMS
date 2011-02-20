namespace FP_PMS.Patient
{
    partial class patientInvoiceViewForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.patientInvoiceGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.patientInvoiceGridControl = new DevExpress.XtraGrid.GridControl();
            this.patientInvoiceView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.invoiceTotalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.balanceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.receiptTotalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.patientInvoiceGroupControl)).BeginInit();
            this.patientInvoiceGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInvoiceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInvoiceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTotalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTotalSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(494, 447);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(434, 447);
            // 
            // patientInvoiceGroupControl
            // 
            this.patientInvoiceGroupControl.Controls.Add(this.patientInvoiceGridControl);
            this.patientInvoiceGroupControl.Location = new System.Drawing.Point(3, 1);
            this.patientInvoiceGroupControl.Name = "patientInvoiceGroupControl";
            this.patientInvoiceGroupControl.Size = new System.Drawing.Size(558, 343);
            this.patientInvoiceGroupControl.TabIndex = 6;
            this.patientInvoiceGroupControl.Text = "Patient Invoices";
            // 
            // patientInvoiceGridControl
            // 
            this.patientInvoiceGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientInvoiceGridControl.Location = new System.Drawing.Point(2, 22);
            this.patientInvoiceGridControl.MainView = this.patientInvoiceView;
            this.patientInvoiceGridControl.Name = "patientInvoiceGridControl";
            this.patientInvoiceGridControl.Size = new System.Drawing.Size(554, 319);
            this.patientInvoiceGridControl.TabIndex = 0;
            this.patientInvoiceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.patientInvoiceView});
            // 
            // patientInvoiceView
            // 
            this.patientInvoiceView.GridControl = this.patientInvoiceGridControl;
            this.patientInvoiceView.Name = "patientInvoiceView";
            this.patientInvoiceView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.patientInvoiceView_RowCellClick);
            // 
            // invoiceTotalSpinEdit
            // 
            this.invoiceTotalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.invoiceTotalSpinEdit.Location = new System.Drawing.Point(143, 355);
            this.invoiceTotalSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceTotalSpinEdit.Name = "invoiceTotalSpinEdit";
            this.invoiceTotalSpinEdit.Properties.AllowFocused = false;
            this.invoiceTotalSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceTotalSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.invoiceTotalSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.invoiceTotalSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.invoiceTotalSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.invoiceTotalSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.invoiceTotalSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.invoiceTotalSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.invoiceTotalSpinEdit.Properties.Mask.EditMask = "c";
            this.invoiceTotalSpinEdit.Properties.ReadOnly = true;
            this.invoiceTotalSpinEdit.Size = new System.Drawing.Size(120, 32);
            this.invoiceTotalSpinEdit.TabIndex = 41;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(11, 360);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 19);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Total Invoice:";
            // 
            // balanceSpinEdit
            // 
            this.balanceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.balanceSpinEdit.Location = new System.Drawing.Point(143, 426);
            this.balanceSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.balanceSpinEdit.Name = "balanceSpinEdit";
            this.balanceSpinEdit.Properties.AllowFocused = false;
            this.balanceSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.balanceSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.balanceSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.balanceSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.balanceSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.balanceSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.balanceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.balanceSpinEdit.Properties.Mask.EditMask = "c";
            this.balanceSpinEdit.Properties.ReadOnly = true;
            this.balanceSpinEdit.Size = new System.Drawing.Size(120, 32);
            this.balanceSpinEdit.TabIndex = 38;
            // 
            // receiptTotalSpinEdit
            // 
            this.receiptTotalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.receiptTotalSpinEdit.Location = new System.Drawing.Point(143, 391);
            this.receiptTotalSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.receiptTotalSpinEdit.Name = "receiptTotalSpinEdit";
            this.receiptTotalSpinEdit.Properties.AllowFocused = false;
            this.receiptTotalSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTotalSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.receiptTotalSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.receiptTotalSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.receiptTotalSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.receiptTotalSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.receiptTotalSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.receiptTotalSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.receiptTotalSpinEdit.Properties.Mask.EditMask = "c";
            this.receiptTotalSpinEdit.Properties.ReadOnly = true;
            this.receiptTotalSpinEdit.Size = new System.Drawing.Size(120, 32);
            this.receiptTotalSpinEdit.TabIndex = 37;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(50, 431);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 19);
            this.labelControl6.TabIndex = 40;
            this.labelControl6.Text = "Balance:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(11, 396);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(98, 19);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "Total Receipt:";
            // 
            // patientInvoiceViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(561, 477);
            this.Controls.Add(this.invoiceTotalSpinEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.balanceSpinEdit);
            this.Controls.Add(this.receiptTotalSpinEdit);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.patientInvoiceGroupControl);
            this.Name = "patientInvoiceViewForm";
            this.Text = "Patient Invoices";
            this.Load += new System.EventHandler(this.patientInvoiceViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.patientInvoiceGroupControl, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.receiptTotalSpinEdit, 0);
            this.Controls.SetChildIndex(this.balanceSpinEdit, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.invoiceTotalSpinEdit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.patientInvoiceGroupControl)).EndInit();
            this.patientInvoiceGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientInvoiceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInvoiceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTotalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTotalSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl patientInvoiceGroupControl;
        public DevExpress.XtraEditors.SpinEdit invoiceTotalSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.SpinEdit balanceSpinEdit;
        public DevExpress.XtraEditors.SpinEdit receiptTotalSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl patientInvoiceGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView patientInvoiceView;

    }
}
