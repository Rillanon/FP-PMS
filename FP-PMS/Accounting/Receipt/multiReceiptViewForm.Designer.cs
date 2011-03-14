namespace FP_PMS.Accounting.Receipt
{
    partial class multiReceiptViewForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.multipleReceiptGridControl = new DevExpress.XtraGrid.GridControl();
            this.multipleReceiptView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.invoiceNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptTotalCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.balanceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptAmntCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptAmountSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.appliedAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.receiptTotalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.remainingSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.claimantDetailMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.invoiceDetailsBtn = new DevExpress.XtraEditors.SimpleButton();
            this.receiptDetailBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multipleReceiptGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multipleReceiptView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptAmountSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appliedAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTotalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainingSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimantDetailMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(936, 594);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(876, 594);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.multipleReceiptGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1002, 449);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Unpaid Invoices";
            // 
            // multipleReceiptGridControl
            // 
            this.multipleReceiptGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multipleReceiptGridControl.Location = new System.Drawing.Point(2, 22);
            this.multipleReceiptGridControl.MainView = this.multipleReceiptView;
            this.multipleReceiptGridControl.Name = "multipleReceiptGridControl";
            this.multipleReceiptGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.receiptAmountSpinEdit});
            this.multipleReceiptGridControl.Size = new System.Drawing.Size(998, 425);
            this.multipleReceiptGridControl.TabIndex = 7;
            this.multipleReceiptGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.multipleReceiptView});
            // 
            // multipleReceiptView
            // 
            this.multipleReceiptView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.invoiceNoCol,
            this.dateCol,
            this.totalCol,
            this.receiptTotalCol,
            this.balanceCol,
            this.receiptAmntCol});
            this.multipleReceiptView.GridControl = this.multipleReceiptGridControl;
            this.multipleReceiptView.Name = "multipleReceiptView";
            this.multipleReceiptView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.multipleReceiptView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.multipleReceiptView_RowCellClick);
            // 
            // invoiceNoCol
            // 
            this.invoiceNoCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNoCol.AppearanceCell.Options.UseFont = true;
            this.invoiceNoCol.Caption = "Invoice #";
            this.invoiceNoCol.FieldName = "InvoiceNo";
            this.invoiceNoCol.Name = "invoiceNoCol";
            this.invoiceNoCol.OptionsColumn.AllowEdit = false;
            this.invoiceNoCol.Visible = true;
            this.invoiceNoCol.VisibleIndex = 1;
            // 
            // dateCol
            // 
            this.dateCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCol.AppearanceCell.Options.UseFont = true;
            this.dateCol.Caption = "Date";
            this.dateCol.FieldName = "InvoiceDate";
            this.dateCol.Name = "dateCol";
            this.dateCol.OptionsColumn.AllowEdit = false;
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 0;
            // 
            // totalCol
            // 
            this.totalCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCol.AppearanceCell.Options.UseFont = true;
            this.totalCol.Caption = "Invoice Total";
            this.totalCol.DisplayFormat.FormatString = "c2";
            this.totalCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.totalCol.FieldName = "InvoiceTotal";
            this.totalCol.Name = "totalCol";
            this.totalCol.OptionsColumn.AllowEdit = false;
            this.totalCol.Visible = true;
            this.totalCol.VisibleIndex = 2;
            // 
            // receiptTotalCol
            // 
            this.receiptTotalCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTotalCol.AppearanceCell.Options.UseFont = true;
            this.receiptTotalCol.Caption = "Receipt Total";
            this.receiptTotalCol.DisplayFormat.FormatString = "c2";
            this.receiptTotalCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.receiptTotalCol.FieldName = "ReceiptTotal";
            this.receiptTotalCol.Name = "receiptTotalCol";
            this.receiptTotalCol.OptionsColumn.AllowEdit = false;
            this.receiptTotalCol.Visible = true;
            this.receiptTotalCol.VisibleIndex = 3;
            // 
            // balanceCol
            // 
            this.balanceCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceCol.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.balanceCol.AppearanceCell.Options.UseFont = true;
            this.balanceCol.AppearanceCell.Options.UseForeColor = true;
            this.balanceCol.Caption = "Balance";
            this.balanceCol.DisplayFormat.FormatString = "c2";
            this.balanceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.balanceCol.FieldName = "Balance";
            this.balanceCol.Name = "balanceCol";
            this.balanceCol.OptionsColumn.AllowEdit = false;
            this.balanceCol.Visible = true;
            this.balanceCol.VisibleIndex = 4;
            // 
            // receiptAmntCol
            // 
            this.receiptAmntCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptAmntCol.AppearanceCell.Options.UseFont = true;
            this.receiptAmntCol.Caption = "Receipt Amount";
            this.receiptAmntCol.ColumnEdit = this.receiptAmountSpinEdit;
            this.receiptAmntCol.DisplayFormat.FormatString = "c2";
            this.receiptAmntCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.receiptAmntCol.FieldName = "ReceiptAmount";
            this.receiptAmntCol.Name = "receiptAmntCol";
            this.receiptAmntCol.Visible = true;
            this.receiptAmntCol.VisibleIndex = 5;
            // 
            // receiptAmountSpinEdit
            // 
            this.receiptAmountSpinEdit.AutoHeight = false;
            this.receiptAmountSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.receiptAmountSpinEdit.Name = "receiptAmountSpinEdit";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Controls.Add(this.appliedAmountSpinEdit);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.receiptTotalSpinEdit);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.remainingSpinEdit);
            this.groupControl2.Location = new System.Drawing.Point(12, 453);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(383, 160);
            this.groupControl2.TabIndex = 38;
            this.groupControl2.Text = "Invoices/Receipts/Balances";
            // 
            // appliedAmountSpinEdit
            // 
            this.appliedAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.appliedAmountSpinEdit.Location = new System.Drawing.Point(149, 66);
            this.appliedAmountSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.appliedAmountSpinEdit.Name = "appliedAmountSpinEdit";
            this.appliedAmountSpinEdit.Properties.AllowFocused = false;
            this.appliedAmountSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appliedAmountSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.appliedAmountSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.appliedAmountSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.appliedAmountSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.appliedAmountSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.appliedAmountSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.appliedAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.appliedAmountSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.appliedAmountSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.appliedAmountSpinEdit.Properties.Mask.EditMask = "c";
            this.appliedAmountSpinEdit.Properties.ReadOnly = true;
            this.appliedAmountSpinEdit.Size = new System.Drawing.Size(198, 32);
            this.appliedAmountSpinEdit.TabIndex = 31;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(15, 71);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(122, 19);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Applied Amount:";
            // 
            // receiptTotalSpinEdit
            // 
            this.receiptTotalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.receiptTotalSpinEdit.Location = new System.Drawing.Point(149, 30);
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.receiptTotalSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.receiptTotalSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.receiptTotalSpinEdit.Properties.Mask.EditMask = "c";
            this.receiptTotalSpinEdit.Properties.ReadOnly = true;
            this.receiptTotalSpinEdit.Size = new System.Drawing.Size(198, 32);
            this.receiptTotalSpinEdit.TabIndex = 35;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(56, 106);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 19);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Remaining:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(39, 35);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 19);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Receipt Total:";
            // 
            // remainingSpinEdit
            // 
            this.remainingSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.remainingSpinEdit.Location = new System.Drawing.Point(149, 101);
            this.remainingSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.remainingSpinEdit.Name = "remainingSpinEdit";
            this.remainingSpinEdit.Properties.AllowFocused = false;
            this.remainingSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.remainingSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.remainingSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.remainingSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.remainingSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.remainingSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.remainingSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.remainingSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.remainingSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.remainingSpinEdit.Properties.Mask.EditMask = "c";
            this.remainingSpinEdit.Properties.ReadOnly = true;
            this.remainingSpinEdit.Size = new System.Drawing.Size(198, 32);
            this.remainingSpinEdit.TabIndex = 32;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.claimantDetailMemoEdit);
            this.groupControl3.Location = new System.Drawing.Point(401, 453);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(216, 160);
            this.groupControl3.TabIndex = 42;
            this.groupControl3.Text = "Claimant Details";
            // 
            // claimantDetailMemoEdit
            // 
            this.claimantDetailMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.claimantDetailMemoEdit.Location = new System.Drawing.Point(2, 22);
            this.claimantDetailMemoEdit.Name = "claimantDetailMemoEdit";
            this.claimantDetailMemoEdit.Size = new System.Drawing.Size(212, 136);
            this.claimantDetailMemoEdit.TabIndex = 0;
            // 
            // invoiceDetailsBtn
            // 
            this.invoiceDetailsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceDetailsBtn.Location = new System.Drawing.Point(621, 453);
            this.invoiceDetailsBtn.Name = "invoiceDetailsBtn";
            this.invoiceDetailsBtn.Size = new System.Drawing.Size(88, 23);
            this.invoiceDetailsBtn.TabIndex = 40;
            this.invoiceDetailsBtn.Text = "Invoice Details";
            this.invoiceDetailsBtn.Click += new System.EventHandler(this.invoiceDetailsBtn_Click);
            // 
            // receiptDetailBtn
            // 
            this.receiptDetailBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptDetailBtn.Location = new System.Drawing.Point(715, 453);
            this.receiptDetailBtn.Name = "receiptDetailBtn";
            this.receiptDetailBtn.Size = new System.Drawing.Size(88, 23);
            this.receiptDetailBtn.TabIndex = 43;
            this.receiptDetailBtn.Text = "Receipt Details";
            // 
            // multiReceiptViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1003, 624);
            this.Controls.Add(this.receiptDetailBtn);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.invoiceDetailsBtn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "multiReceiptViewForm";
            this.Text = "Multiple Receipts";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.invoiceDetailsBtn, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            this.Controls.SetChildIndex(this.receiptDetailBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.multipleReceiptGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multipleReceiptView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptAmountSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appliedAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTotalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainingSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.claimantDetailMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl multipleReceiptGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView multipleReceiptView;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceNoCol;
        private DevExpress.XtraGrid.Columns.GridColumn dateCol;
        private DevExpress.XtraGrid.Columns.GridColumn totalCol;
        private DevExpress.XtraGrid.Columns.GridColumn balanceCol;
        private DevExpress.XtraGrid.Columns.GridColumn receiptAmntCol;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraEditors.SpinEdit appliedAmountSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.SpinEdit receiptTotalSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.SpinEdit remainingSpinEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit claimantDetailMemoEdit;
        private DevExpress.XtraEditors.SimpleButton invoiceDetailsBtn;
        private DevExpress.XtraEditors.SimpleButton receiptDetailBtn;
        private DevExpress.XtraGrid.Columns.GridColumn receiptTotalCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit receiptAmountSpinEdit;
    }
}
