namespace FP_PMS.Claimant
{
    partial class claimantInvoiceViewForm
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
            this.claimantInvoiceGridControl = new DevExpress.XtraGrid.GridControl();
            this.claimantInvoicesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.physioIDCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceAmountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gstCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paidCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.balanceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.receiptTotalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.invoiceTotalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.invoiceDetailsBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ClaimantInvoiceLinqInstantFeedbackSource = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.newInvoiceBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.claimantDetailMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimantInvoiceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantInvoicesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTotalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTotalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimantDetailMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(711, 451);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(651, 451);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.claimantInvoiceGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(778, 304);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Claimant Invoices";
            // 
            // claimantInvoiceGridControl
            // 
            this.claimantInvoiceGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.claimantInvoiceGridControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimantInvoiceGridControl.Location = new System.Drawing.Point(2, 22);
            this.claimantInvoiceGridControl.MainView = this.claimantInvoicesView;
            this.claimantInvoiceGridControl.Name = "claimantInvoiceGridControl";
            this.claimantInvoiceGridControl.Size = new System.Drawing.Size(774, 280);
            this.claimantInvoiceGridControl.TabIndex = 0;
            this.claimantInvoiceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.claimantInvoicesView});
            this.claimantInvoiceGridControl.Click += new System.EventHandler(this.claimantInvoiceGridControl_Click);
            // 
            // claimantInvoicesView
            // 
            this.claimantInvoicesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.physioIDCol,
            this.invoiceNoCol,
            this.dateCol,
            this.nameCol,
            this.invoiceAmountCol,
            this.gstCol,
            this.paidCol});
            this.claimantInvoicesView.GridControl = this.claimantInvoiceGridControl;
            this.claimantInvoicesView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TranAmount", this.invoiceAmountCol, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GST", this.gstCol, "")});
            this.claimantInvoicesView.Name = "claimantInvoicesView";
            this.claimantInvoicesView.OptionsView.ShowFooter = true;
            this.claimantInvoicesView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.claimantInvoicesView_RowClick);
            this.claimantInvoicesView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.claimantInvoicesView_RowCellClick);
            // 
            // physioIDCol
            // 
            this.physioIDCol.Caption = "Physio";
            this.physioIDCol.FieldName = "PhysioID";
            this.physioIDCol.Name = "physioIDCol";
            this.physioIDCol.OptionsColumn.AllowEdit = false;
            this.physioIDCol.Visible = true;
            this.physioIDCol.VisibleIndex = 0;
            // 
            // invoiceNoCol
            // 
            this.invoiceNoCol.Caption = "Invoice #";
            this.invoiceNoCol.FieldName = "InvoiceNo";
            this.invoiceNoCol.Name = "invoiceNoCol";
            this.invoiceNoCol.OptionsColumn.AllowEdit = false;
            this.invoiceNoCol.Visible = true;
            this.invoiceNoCol.VisibleIndex = 1;
            // 
            // dateCol
            // 
            this.dateCol.Caption = "Date";
            this.dateCol.FieldName = "TranDate";
            this.dateCol.Name = "dateCol";
            this.dateCol.OptionsColumn.AllowEdit = false;
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 2;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "Name";
            this.nameCol.FieldName = "Narrative";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 3;
            // 
            // invoiceAmountCol
            // 
            this.invoiceAmountCol.Caption = "Invoice $";
            this.invoiceAmountCol.DisplayFormat.FormatString = "c2";
            this.invoiceAmountCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.invoiceAmountCol.FieldName = "TranAmount";
            this.invoiceAmountCol.Name = "invoiceAmountCol";
            this.invoiceAmountCol.OptionsColumn.AllowEdit = false;
            this.invoiceAmountCol.Visible = true;
            this.invoiceAmountCol.VisibleIndex = 4;
            // 
            // gstCol
            // 
            this.gstCol.Caption = "GST";
            this.gstCol.DisplayFormat.FormatString = "c2";
            this.gstCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gstCol.FieldName = "GST";
            this.gstCol.Name = "gstCol";
            this.gstCol.OptionsColumn.AllowEdit = false;
            this.gstCol.Visible = true;
            this.gstCol.VisibleIndex = 5;
            // 
            // paidCol
            // 
            this.paidCol.Caption = "Paid ?";
            this.paidCol.DisplayFormat.FormatString = "c2";
            this.paidCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.paidCol.FieldName = "InvoicePaid";
            this.paidCol.Name = "paidCol";
            this.paidCol.OptionsColumn.AllowEdit = false;
            this.paidCol.Visible = true;
            this.paidCol.VisibleIndex = 6;
            // 
            // balanceSpinEdit
            // 
            this.balanceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.balanceSpinEdit.Location = new System.Drawing.Point(149, 101);
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.balanceSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.balanceSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.balanceSpinEdit.Properties.Mask.EditMask = "c";
            this.balanceSpinEdit.Properties.ReadOnly = true;
            this.balanceSpinEdit.Size = new System.Drawing.Size(198, 32);
            this.balanceSpinEdit.TabIndex = 32;
            // 
            // receiptTotalSpinEdit
            // 
            this.receiptTotalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.receiptTotalSpinEdit.Location = new System.Drawing.Point(149, 66);
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
            this.receiptTotalSpinEdit.TabIndex = 31;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(56, 106);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 19);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Balance:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(17, 71);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(98, 19);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Total Receipt:";
            // 
            // invoiceTotalSpinEdit
            // 
            this.invoiceTotalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.invoiceTotalSpinEdit.Location = new System.Drawing.Point(149, 30);
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.invoiceTotalSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.invoiceTotalSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.invoiceTotalSpinEdit.Properties.Mask.EditMask = "c";
            this.invoiceTotalSpinEdit.Properties.ReadOnly = true;
            this.invoiceTotalSpinEdit.Size = new System.Drawing.Size(198, 32);
            this.invoiceTotalSpinEdit.TabIndex = 35;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(17, 35);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 19);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Total Invoice:";
            // 
            // invoiceDetailsBtn
            // 
            this.invoiceDetailsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceDetailsBtn.Location = new System.Drawing.Point(594, 310);
            this.invoiceDetailsBtn.Name = "invoiceDetailsBtn";
            this.invoiceDetailsBtn.Size = new System.Drawing.Size(88, 23);
            this.invoiceDetailsBtn.TabIndex = 1;
            this.invoiceDetailsBtn.Text = "Invoice Details";
            this.invoiceDetailsBtn.Click += new System.EventHandler(this.invoiceDetailsBtn_Click);
            // 
            // ClaimantInvoiceLinqInstantFeedbackSource
            // 
            this.ClaimantInvoiceLinqInstantFeedbackSource.AreSourceRowsThreadSafe = true;
            this.ClaimantInvoiceLinqInstantFeedbackSource.DesignTimeElementType = typeof(FP_PMS.Db.tblTransaction);
            this.ClaimantInvoiceLinqInstantFeedbackSource.KeyExpression = "TranNo";
            this.ClaimantInvoiceLinqInstantFeedbackSource.GetQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.linqInstantFeedbackSource1_GetQueryable);
            this.ClaimantInvoiceLinqInstantFeedbackSource.DismissQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.linqInstantFeedbackSource1_DismissQueryable);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Controls.Add(this.receiptTotalSpinEdit);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.invoiceTotalSpinEdit);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.balanceSpinEdit);
            this.groupControl2.Location = new System.Drawing.Point(12, 310);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(356, 160);
            this.groupControl2.TabIndex = 37;
            this.groupControl2.Text = "Invoices/Receipts/Balances";
            // 
            // newInvoiceBtn
            // 
            this.newInvoiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newInvoiceBtn.Location = new System.Drawing.Point(688, 310);
            this.newInvoiceBtn.Name = "newInvoiceBtn";
            this.newInvoiceBtn.Size = new System.Drawing.Size(88, 23);
            this.newInvoiceBtn.TabIndex = 38;
            this.newInvoiceBtn.Text = "New Invoice";
            this.newInvoiceBtn.Click += new System.EventHandler(this.newInvoiceBtn_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.claimantDetailMemoEdit);
            this.groupControl3.Location = new System.Drawing.Point(374, 310);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(214, 160);
            this.groupControl3.TabIndex = 39;
            this.groupControl3.Text = "Claimant Details";
            // 
            // claimantDetailMemoEdit
            // 
            this.claimantDetailMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.claimantDetailMemoEdit.Location = new System.Drawing.Point(2, 22);
            this.claimantDetailMemoEdit.Name = "claimantDetailMemoEdit";
            this.claimantDetailMemoEdit.Size = new System.Drawing.Size(210, 136);
            this.claimantDetailMemoEdit.TabIndex = 0;
            // 
            // claimantInvoiceViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(778, 482);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.newInvoiceBtn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.invoiceDetailsBtn);
            this.Name = "claimantInvoiceViewForm";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.claimantInvoiceViewForm_Load);
            this.Controls.SetChildIndex(this.invoiceDetailsBtn, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.newInvoiceBtn, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.claimantInvoiceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantInvoicesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTotalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTotalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.claimantDetailMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl claimantInvoiceGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView claimantInvoicesView;
        public DevExpress.XtraEditors.SpinEdit balanceSpinEdit;
        public DevExpress.XtraEditors.SpinEdit receiptTotalSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.SpinEdit invoiceTotalSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton invoiceDetailsBtn;
        private DevExpress.XtraGrid.Columns.GridColumn physioIDCol;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceNoCol;
        private DevExpress.XtraGrid.Columns.GridColumn dateCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceAmountCol;
        private DevExpress.XtraGrid.Columns.GridColumn gstCol;
        private DevExpress.XtraGrid.Columns.GridColumn paidCol;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource ClaimantInvoiceLinqInstantFeedbackSource;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton newInvoiceBtn;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit claimantDetailMemoEdit;
    }
}
