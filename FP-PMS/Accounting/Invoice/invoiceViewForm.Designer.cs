namespace FP_PMS.Accounting.Invoice
{
    partial class invoiceViewForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this.invoiceLineGridControl = new DevExpress.XtraGrid.GridControl();
            this.invoiceLineView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.itemNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sessionDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.feeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gstCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addLineBtn = new DevExpress.XtraEditors.SimpleButton();
            this.removeLineBtn = new DevExpress.XtraEditors.SimpleButton();
            this.feeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.invoiceTotalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.gstSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.feeLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.invoiceDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.invoiceCommentsMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.claimantBillingAddressMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.invoiceStatusLabel = new DevExpress.XtraEditors.LabelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.paidSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dueSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.claimantMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.receiptBtn = new DevExpress.XtraEditors.SimpleButton();
            this.printBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.formSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTotalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gstSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceCommentsMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimantBillingAddressMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dueSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(880, 595);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(22, 566);
            this.applyBtn.Size = new System.Drawing.Size(120, 36);
            this.applyBtn.Text = "Make Invoice Official";
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(944, 595);
            // 
            // formSearchLookUpEdit
            // 
            this.formSearchLookUpEdit.Location = new System.Drawing.Point(881, 301);
            this.formSearchLookUpEdit.Properties.DisplayMember = "ReceiptNo";
            this.formSearchLookUpEdit.Properties.NullText = "View Receipts";
            this.formSearchLookUpEdit.Properties.ValueMember = "ReceiptNo";
            this.formSearchLookUpEdit.Size = new System.Drawing.Size(120, 20);
            // 
            // searchTitleLabel
            // 
            this.searchTitleLabel.Location = new System.Drawing.Point(824, 304);
            this.searchTitleLabel.Size = new System.Drawing.Size(41, 13);
            this.searchTitleLabel.Text = "Receipts";
            // 
            // invoiceLineGridControl
            // 
            this.invoiceLineGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceLineGridControl.Location = new System.Drawing.Point(22, 70);
            this.invoiceLineGridControl.MainView = this.invoiceLineView;
            this.invoiceLineGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceLineGridControl.Name = "invoiceLineGridControl";
            this.invoiceLineGridControl.Size = new System.Drawing.Size(462, 338);
            this.invoiceLineGridControl.TabIndex = 6;
            this.invoiceLineGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.invoiceLineView});
            // 
            // invoiceLineView
            // 
            this.invoiceLineView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.itemNoCol,
            this.physioCol,
            this.rateCol,
            this.sessionDateCol,
            this.feeCol,
            this.gstCol});
            this.invoiceLineView.GridControl = this.invoiceLineGridControl;
            this.invoiceLineView.Name = "invoiceLineView";
            // 
            // itemNoCol
            // 
            this.itemNoCol.Caption = "Item No";
            this.itemNoCol.FieldName = "ItemNo";
            this.itemNoCol.Name = "itemNoCol";
            this.itemNoCol.Visible = true;
            this.itemNoCol.VisibleIndex = 0;
            // 
            // physioCol
            // 
            this.physioCol.Caption = "Physio ID";
            this.physioCol.FieldName = "PhysioID";
            this.physioCol.Name = "physioCol";
            this.physioCol.Visible = true;
            this.physioCol.VisibleIndex = 1;
            // 
            // rateCol
            // 
            this.rateCol.Caption = "Rate ID";
            this.rateCol.FieldName = "RateID";
            this.rateCol.Name = "rateCol";
            this.rateCol.Visible = true;
            this.rateCol.VisibleIndex = 2;
            // 
            // sessionDateCol
            // 
            this.sessionDateCol.Caption = "Session Date";
            this.sessionDateCol.FieldName = "SessionDate";
            this.sessionDateCol.Name = "sessionDateCol";
            this.sessionDateCol.Visible = true;
            this.sessionDateCol.VisibleIndex = 3;
            // 
            // feeCol
            // 
            this.feeCol.Caption = "Fee";
            this.feeCol.DisplayFormat.FormatString = "c2";
            this.feeCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.feeCol.FieldName = "Fee";
            this.feeCol.Name = "feeCol";
            this.feeCol.Visible = true;
            this.feeCol.VisibleIndex = 4;
            // 
            // gstCol
            // 
            this.gstCol.Caption = "GST";
            this.gstCol.DisplayFormat.FormatString = "c2";
            this.gstCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gstCol.FieldName = "GST";
            this.gstCol.Name = "gstCol";
            this.gstCol.Visible = true;
            this.gstCol.VisibleIndex = 5;
            // 
            // addLineBtn
            // 
            this.addLineBtn.Location = new System.Drawing.Point(365, 415);
            this.addLineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addLineBtn.Name = "addLineBtn";
            this.addLineBtn.Size = new System.Drawing.Size(56, 19);
            this.addLineBtn.TabIndex = 7;
            this.addLineBtn.Text = "Add Item";
            this.addLineBtn.Click += new System.EventHandler(this.addLineBtn_Click);
            // 
            // removeLineBtn
            // 
            this.removeLineBtn.Location = new System.Drawing.Point(426, 415);
            this.removeLineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeLineBtn.Name = "removeLineBtn";
            this.removeLineBtn.Size = new System.Drawing.Size(56, 19);
            this.removeLineBtn.TabIndex = 8;
            this.removeLineBtn.Text = "Remove";
            // 
            // feeSpinEdit
            // 
            this.feeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.feeSpinEdit.Location = new System.Drawing.Point(881, 472);
            this.feeSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.feeSpinEdit.Name = "feeSpinEdit";
            this.feeSpinEdit.Properties.AllowFocused = false;
            this.feeSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.feeSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.feeSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.feeSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.feeSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.feeSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.feeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.feeSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.feeSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.feeSpinEdit.Properties.Mask.EditMask = "c";
            this.feeSpinEdit.Properties.ReadOnly = true;
            this.feeSpinEdit.Size = new System.Drawing.Size(120, 32);
            this.feeSpinEdit.TabIndex = 9;
            // 
            // invoiceTotalSpinEdit
            // 
            this.invoiceTotalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.invoiceTotalSpinEdit.Location = new System.Drawing.Point(881, 538);
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.invoiceTotalSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.invoiceTotalSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.invoiceTotalSpinEdit.Properties.Mask.EditMask = "c";
            this.invoiceTotalSpinEdit.Properties.ReadOnly = true;
            this.invoiceTotalSpinEdit.Size = new System.Drawing.Size(120, 32);
            this.invoiceTotalSpinEdit.TabIndex = 10;
            // 
            // gstSpinEdit
            // 
            this.gstSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gstSpinEdit.Location = new System.Drawing.Point(881, 505);
            this.gstSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.gstSpinEdit.Name = "gstSpinEdit";
            this.gstSpinEdit.Properties.AllowFocused = false;
            this.gstSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.gstSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.gstSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.gstSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
            this.gstSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.gstSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.gstSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.gstSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.gstSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gstSpinEdit.Properties.Mask.EditMask = "c";
            this.gstSpinEdit.Properties.ReadOnly = true;
            this.gstSpinEdit.Size = new System.Drawing.Size(120, 32);
            this.gstSpinEdit.TabIndex = 11;
            // 
            // feeLabel
            // 
            this.feeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeLabel.Location = new System.Drawing.Point(835, 477);
            this.feeLabel.Margin = new System.Windows.Forms.Padding(2);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(30, 19);
            this.feeLabel.TabIndex = 12;
            this.feeLabel.Text = "Fee:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(829, 510);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 19);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "GST:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(731, 543);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 27);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Invoice Total:";
            // 
            // invoiceDateEdit
            // 
            this.invoiceDateEdit.EditValue = null;
            this.invoiceDateEdit.Location = new System.Drawing.Point(555, 28);
            this.invoiceDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceDateEdit.Name = "invoiceDateEdit";
            this.invoiceDateEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.invoiceDateEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.invoiceDateEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
            this.invoiceDateEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.invoiceDateEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.invoiceDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invoiceDateEdit.Properties.ReadOnly = true;
            this.invoiceDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.invoiceDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.invoiceDateEdit.Size = new System.Drawing.Size(161, 20);
            this.invoiceDateEdit.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(513, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 19);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Date:";
            // 
            // invoiceCommentsMemoEdit
            // 
            this.invoiceCommentsMemoEdit.Location = new System.Drawing.Point(22, 464);
            this.invoiceCommentsMemoEdit.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceCommentsMemoEdit.Name = "invoiceCommentsMemoEdit";
            this.invoiceCommentsMemoEdit.Size = new System.Drawing.Size(336, 98);
            this.invoiceCommentsMemoEdit.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 446);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Invoice Comments";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(513, 70);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Claimant:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.claimantBillingAddressMemoEdit);
            this.groupControl1.Location = new System.Drawing.Point(513, 152);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(203, 123);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Claimant Billing Address";
            // 
            // claimantBillingAddressMemoEdit
            // 
            this.claimantBillingAddressMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.claimantBillingAddressMemoEdit.Location = new System.Drawing.Point(2, 22);
            this.claimantBillingAddressMemoEdit.Name = "claimantBillingAddressMemoEdit";
            this.claimantBillingAddressMemoEdit.Size = new System.Drawing.Size(199, 99);
            this.claimantBillingAddressMemoEdit.TabIndex = 32;
            // 
            // invoiceStatusLabel
            // 
            this.invoiceStatusLabel.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.invoiceStatusLabel.Appearance.BorderColor = System.Drawing.Color.Black;
            this.invoiceStatusLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceStatusLabel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.invoiceStatusLabel.Location = new System.Drawing.Point(22, 19);
            this.invoiceStatusLabel.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceStatusLabel.Name = "invoiceStatusLabel";
            this.invoiceStatusLabel.Size = new System.Drawing.Size(218, 29);
            this.invoiceStatusLabel.TabIndex = 24;
            this.invoiceStatusLabel.Text = "Preparing invoice...";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(0, 0);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 625);
            this.splitterControl1.TabIndex = 25;
            this.splitterControl1.TabStop = false;
            // 
            // paidSpinEdit
            // 
            this.paidSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.paidSpinEdit.Location = new System.Drawing.Point(881, 364);
            this.paidSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.paidSpinEdit.Name = "paidSpinEdit";
            this.paidSpinEdit.Properties.AllowFocused = false;
            this.paidSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.paidSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.paidSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.paidSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.paidSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.paidSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.paidSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.paidSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.paidSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.paidSpinEdit.Properties.Mask.EditMask = "c";
            this.paidSpinEdit.Properties.ReadOnly = true;
            this.paidSpinEdit.Size = new System.Drawing.Size(120, 32);
            this.paidSpinEdit.TabIndex = 27;
            // 
            // dueSpinEdit
            // 
            this.dueSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dueSpinEdit.Location = new System.Drawing.Point(881, 401);
            this.dueSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.dueSpinEdit.Name = "dueSpinEdit";
            this.dueSpinEdit.Properties.AllowFocused = false;
            this.dueSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.dueSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.dueSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.dueSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.dueSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.dueSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.dueSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.dueSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.dueSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dueSpinEdit.Properties.Mask.EditMask = "c";
            this.dueSpinEdit.Properties.ReadOnly = true;
            this.dueSpinEdit.Size = new System.Drawing.Size(120, 32);
            this.dueSpinEdit.TabIndex = 28;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(831, 406);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 19);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "Due:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(829, 369);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 19);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "Paid:";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(22, 415);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(56, 19);
            this.clearBtn.TabIndex = 31;
            this.clearBtn.Text = "Clear";
            // 
            // claimantMemoEdit
            // 
            this.claimantMemoEdit.Location = new System.Drawing.Point(513, 87);
            this.claimantMemoEdit.Name = "claimantMemoEdit";
            this.claimantMemoEdit.Size = new System.Drawing.Size(203, 60);
            this.claimantMemoEdit.TabIndex = 32;
            // 
            // receiptBtn
            // 
            this.receiptBtn.Location = new System.Drawing.Point(366, 31);
            this.receiptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.receiptBtn.Name = "receiptBtn";
            this.receiptBtn.Size = new System.Drawing.Size(56, 19);
            this.receiptBtn.TabIndex = 33;
            this.receiptBtn.Text = "Receipt";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(426, 31);
            this.printBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(56, 19);
            this.printBtn.TabIndex = 34;
            this.printBtn.Text = "Print";
            // 
            // invoiceViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1011, 625);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.receiptBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.dueSpinEdit);
            this.Controls.Add(this.claimantMemoEdit);
            this.Controls.Add(this.invoiceLineGridControl);
            this.Controls.Add(this.paidSpinEdit);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.invoiceCommentsMemoEdit);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.invoiceDateEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gstSpinEdit);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.invoiceTotalSpinEdit);
            this.Controls.Add(this.feeSpinEdit);
            this.Controls.Add(this.removeLineBtn);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.invoiceStatusLabel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.addLineBtn);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Name = "invoiceViewForm";
            this.Load += new System.EventHandler(this.invoiceViewForm_Load);
            this.Controls.SetChildIndex(this.searchTitleLabel, 0);
            this.Controls.SetChildIndex(this.formSearchLookUpEdit, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.addLineBtn, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.invoiceStatusLabel, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.removeLineBtn, 0);
            this.Controls.SetChildIndex(this.feeSpinEdit, 0);
            this.Controls.SetChildIndex(this.invoiceTotalSpinEdit, 0);
            this.Controls.SetChildIndex(this.feeLabel, 0);
            this.Controls.SetChildIndex(this.gstSpinEdit, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.invoiceDateEdit, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.invoiceCommentsMemoEdit, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.splitterControl1, 0);
            this.Controls.SetChildIndex(this.paidSpinEdit, 0);
            this.Controls.SetChildIndex(this.invoiceLineGridControl, 0);
            this.Controls.SetChildIndex(this.claimantMemoEdit, 0);
            this.Controls.SetChildIndex(this.applyBtn, 0);
            this.Controls.SetChildIndex(this.dueSpinEdit, 0);
            this.Controls.SetChildIndex(this.clearBtn, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.receiptBtn, 0);
            this.Controls.SetChildIndex(this.printBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.formSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTotalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gstSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceCommentsMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.claimantBillingAddressMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dueSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl feeLabel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        internal DevExpress.XtraEditors.SimpleButton removeLineBtn;
        internal DevExpress.XtraGrid.Views.Grid.GridView invoiceLineView;
        internal DevExpress.XtraEditors.SimpleButton clearBtn;
        internal DevExpress.XtraGrid.GridControl invoiceLineGridControl;
        internal DevExpress.XtraEditors.SimpleButton addLineBtn;
        internal DevExpress.XtraEditors.DateEdit invoiceDateEdit;
        internal DevExpress.XtraEditors.MemoEdit claimantBillingAddressMemoEdit;
        internal DevExpress.XtraEditors.MemoEdit claimantMemoEdit;
        private DevExpress.XtraGrid.Columns.GridColumn itemNoCol;
        private DevExpress.XtraGrid.Columns.GridColumn physioCol;
        private DevExpress.XtraGrid.Columns.GridColumn rateCol;
        private DevExpress.XtraGrid.Columns.GridColumn sessionDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn feeCol;
        internal DevExpress.XtraEditors.SpinEdit feeSpinEdit;
        internal DevExpress.XtraEditors.SpinEdit invoiceTotalSpinEdit;
        internal DevExpress.XtraEditors.SpinEdit gstSpinEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gstCol;
        public DevExpress.XtraEditors.SpinEdit paidSpinEdit;
        public DevExpress.XtraEditors.SpinEdit dueSpinEdit;
        public DevExpress.XtraEditors.MemoEdit invoiceCommentsMemoEdit;
        public DevExpress.XtraEditors.LabelControl invoiceStatusLabel;
        public DevExpress.XtraEditors.SimpleButton receiptBtn;
        public DevExpress.XtraEditors.SimpleButton printBtn;
    }
}
