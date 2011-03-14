namespace FP_PMS.Accounting.Receipt
{
    partial class receiptViewForm
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
            this.receiptLinesGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.paymentListGridControl = new DevExpress.XtraGrid.GridControl();
            this.paymentListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.payinTypeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.payinAmountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.bankCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.branchCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.drawerCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chequeNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.removePaymentBtn = new DevExpress.XtraEditors.SimpleButton();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.existingCreditSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.receiptTotalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.paymentTypeGridControl = new DevExpress.XtraGrid.GridControl();
            this.paymentTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.paymentTypeDescCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.invoiceTotalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.commentsMemoExEdit = new DevExpress.XtraEditors.MemoExEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.receiptLinesGroupControl)).BeginInit();
            this.receiptLinesGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingCreditSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTotalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTotalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsMemoExEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(795, 566);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(735, 566);
            // 
            // receiptLinesGroupControl
            // 
            this.receiptLinesGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptLinesGroupControl.Controls.Add(this.paymentListGridControl);
            this.receiptLinesGroupControl.Controls.Add(this.removePaymentBtn);
            this.receiptLinesGroupControl.Controls.Add(this.clearBtn);
            this.receiptLinesGroupControl.Location = new System.Drawing.Point(174, 2);
            this.receiptLinesGroupControl.Name = "receiptLinesGroupControl";
            this.receiptLinesGroupControl.Size = new System.Drawing.Size(680, 541);
            this.receiptLinesGroupControl.TabIndex = 12;
            this.receiptLinesGroupControl.Text = "Payments";
            // 
            // paymentListGridControl
            // 
            this.paymentListGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentListGridControl.Location = new System.Drawing.Point(2, 22);
            this.paymentListGridControl.MainView = this.paymentListGridView;
            this.paymentListGridControl.Name = "paymentListGridControl";
            this.paymentListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit,
            this.repositoryItemSpinEdit});
            this.paymentListGridControl.Size = new System.Drawing.Size(676, 479);
            this.paymentListGridControl.TabIndex = 0;
            this.paymentListGridControl.TabStop = false;
            this.paymentListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.paymentListGridView});
            // 
            // paymentListGridView
            // 
            this.paymentListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.payinTypeCol,
            this.payinAmountCol,
            this.bankCol,
            this.branchCol,
            this.drawerCol,
            this.chequeNoCol});
            this.paymentListGridView.GridControl = this.paymentListGridControl;
            this.paymentListGridView.Name = "paymentListGridView";
            this.paymentListGridView.OptionsView.ShowVertLines = false;
            this.paymentListGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.paymentListGridView_CustomColumnDisplayText);
            // 
            // payinTypeCol
            // 
            this.payinTypeCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payinTypeCol.AppearanceCell.Options.UseFont = true;
            this.payinTypeCol.Caption = "Payment Method";
            this.payinTypeCol.FieldName = "PayinType";
            this.payinTypeCol.Name = "payinTypeCol";
            this.payinTypeCol.OptionsColumn.AllowEdit = false;
            this.payinTypeCol.Visible = true;
            this.payinTypeCol.VisibleIndex = 0;
            this.payinTypeCol.Width = 96;
            // 
            // payinAmountCol
            // 
            this.payinAmountCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payinAmountCol.AppearanceCell.Options.UseFont = true;
            this.payinAmountCol.Caption = "Payment Amount";
            this.payinAmountCol.ColumnEdit = this.repositoryItemSpinEdit;
            this.payinAmountCol.DisplayFormat.FormatString = "c2";
            this.payinAmountCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.payinAmountCol.FieldName = "PayinAmnt";
            this.payinAmountCol.Name = "payinAmountCol";
            this.payinAmountCol.Visible = true;
            this.payinAmountCol.VisibleIndex = 1;
            this.payinAmountCol.Width = 96;
            // 
            // repositoryItemSpinEdit
            // 
            this.repositoryItemSpinEdit.AutoHeight = false;
            this.repositoryItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit.Name = "repositoryItemSpinEdit";
            // 
            // bankCol
            // 
            this.bankCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankCol.AppearanceCell.Options.UseFont = true;
            this.bankCol.Caption = "Bank";
            this.bankCol.ColumnEdit = this.repositoryItemMemoExEdit;
            this.bankCol.FieldName = "Bank";
            this.bankCol.Name = "bankCol";
            this.bankCol.Visible = true;
            this.bankCol.VisibleIndex = 2;
            this.bankCol.Width = 96;
            // 
            // repositoryItemMemoExEdit
            // 
            this.repositoryItemMemoExEdit.AutoHeight = false;
            this.repositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit.Name = "repositoryItemMemoExEdit";
            // 
            // branchCol
            // 
            this.branchCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchCol.AppearanceCell.Options.UseFont = true;
            this.branchCol.Caption = "Branch";
            this.branchCol.ColumnEdit = this.repositoryItemMemoExEdit;
            this.branchCol.FieldName = "Branch";
            this.branchCol.Name = "branchCol";
            this.branchCol.Visible = true;
            this.branchCol.VisibleIndex = 3;
            this.branchCol.Width = 96;
            // 
            // drawerCol
            // 
            this.drawerCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerCol.AppearanceCell.Options.UseFont = true;
            this.drawerCol.Caption = "Drawer";
            this.drawerCol.ColumnEdit = this.repositoryItemMemoExEdit;
            this.drawerCol.FieldName = "Drawer";
            this.drawerCol.Name = "drawerCol";
            this.drawerCol.Visible = true;
            this.drawerCol.VisibleIndex = 4;
            this.drawerCol.Width = 96;
            // 
            // chequeNoCol
            // 
            this.chequeNoCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeNoCol.AppearanceCell.Options.UseFont = true;
            this.chequeNoCol.Caption = "Cheque #";
            this.chequeNoCol.ColumnEdit = this.repositoryItemMemoExEdit;
            this.chequeNoCol.FieldName = "ChequeNo";
            this.chequeNoCol.Name = "chequeNoCol";
            this.chequeNoCol.Visible = true;
            this.chequeNoCol.VisibleIndex = 5;
            this.chequeNoCol.Width = 150;
            // 
            // removePaymentBtn
            // 
            this.removePaymentBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.removePaymentBtn.Location = new System.Drawing.Point(396, 507);
            this.removePaymentBtn.Name = "removePaymentBtn";
            this.removePaymentBtn.Size = new System.Drawing.Size(100, 29);
            this.removePaymentBtn.TabIndex = 13;
            this.removePaymentBtn.Text = "Remove";
            this.removePaymentBtn.Click += new System.EventHandler(this.removePaymentBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearBtn.Location = new System.Drawing.Point(173, 507);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 29);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.existingCreditSpinEdit);
            this.groupControl1.Location = new System.Drawing.Point(2, 342);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(166, 63);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Existing Credit";
            // 
            // existingCreditSpinEdit
            // 
            this.existingCreditSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.existingCreditSpinEdit.Location = new System.Drawing.Point(4, 24);
            this.existingCreditSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.existingCreditSpinEdit.Name = "existingCreditSpinEdit";
            this.existingCreditSpinEdit.Properties.AllowFocused = false;
            this.existingCreditSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingCreditSpinEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.existingCreditSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.existingCreditSpinEdit.Properties.Appearance.Options.UseForeColor = true;
            this.existingCreditSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.existingCreditSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.existingCreditSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.existingCreditSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.existingCreditSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.existingCreditSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.existingCreditSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.existingCreditSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.existingCreditSpinEdit.Properties.Mask.EditMask = "c";
            this.existingCreditSpinEdit.Properties.ReadOnly = true;
            this.existingCreditSpinEdit.Size = new System.Drawing.Size(150, 32);
            this.existingCreditSpinEdit.TabIndex = 16;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Controls.Add(this.receiptTotalSpinEdit);
            this.groupControl2.Location = new System.Drawing.Point(3, 411);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(165, 63);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "Receipt Total";
            // 
            // receiptTotalSpinEdit
            // 
            this.receiptTotalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.receiptTotalSpinEdit.Location = new System.Drawing.Point(4, 24);
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
            this.receiptTotalSpinEdit.Size = new System.Drawing.Size(150, 32);
            this.receiptTotalSpinEdit.TabIndex = 17;
            // 
            // paymentTypeGridControl
            // 
            this.paymentTypeGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.paymentTypeGridControl.Location = new System.Drawing.Point(2, 2);
            this.paymentTypeGridControl.MainView = this.paymentTypeGridView;
            this.paymentTypeGridControl.Name = "paymentTypeGridControl";
            this.paymentTypeGridControl.Size = new System.Drawing.Size(166, 334);
            this.paymentTypeGridControl.TabIndex = 17;
            this.paymentTypeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.paymentTypeGridView});
            // 
            // paymentTypeGridView
            // 
            this.paymentTypeGridView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeGridView.Appearance.Row.Options.UseFont = true;
            this.paymentTypeGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.paymentTypeGridView.AppearancePrint.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeGridView.AppearancePrint.Row.Options.UseFont = true;
            this.paymentTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.paymentTypeDescCol});
            this.paymentTypeGridView.GridControl = this.paymentTypeGridControl;
            this.paymentTypeGridView.Name = "paymentTypeGridView";
            this.paymentTypeGridView.OptionsView.ShowGroupPanel = false;
            this.paymentTypeGridView.OptionsView.ShowHorzLines = false;
            this.paymentTypeGridView.RowHeight = 20;
            this.paymentTypeGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paymentTypeGridView_MouseDown);
            // 
            // paymentTypeDescCol
            // 
            this.paymentTypeDescCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeDescCol.AppearanceCell.Options.UseFont = true;
            this.paymentTypeDescCol.Caption = "Payment Method";
            this.paymentTypeDescCol.FieldName = "PayinDesc";
            this.paymentTypeDescCol.Name = "paymentTypeDescCol";
            this.paymentTypeDescCol.OptionsColumn.AllowEdit = false;
            this.paymentTypeDescCol.Visible = true;
            this.paymentTypeDescCol.VisibleIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl3.Controls.Add(this.invoiceTotalSpinEdit);
            this.groupControl3.Location = new System.Drawing.Point(3, 480);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(165, 63);
            this.groupControl3.TabIndex = 18;
            this.groupControl3.Text = "Invoice Remaining";
            // 
            // invoiceTotalSpinEdit
            // 
            this.invoiceTotalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.invoiceTotalSpinEdit.Location = new System.Drawing.Point(4, 24);
            this.invoiceTotalSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceTotalSpinEdit.Name = "invoiceTotalSpinEdit";
            this.invoiceTotalSpinEdit.Properties.AllowFocused = false;
            this.invoiceTotalSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceTotalSpinEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.invoiceTotalSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.invoiceTotalSpinEdit.Properties.Appearance.Options.UseForeColor = true;
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
            this.invoiceTotalSpinEdit.Size = new System.Drawing.Size(150, 36);
            this.invoiceTotalSpinEdit.TabIndex = 17;
            // 
            // commentsMemoExEdit
            // 
            this.commentsMemoExEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.commentsMemoExEdit.Location = new System.Drawing.Point(97, 558);
            this.commentsMemoExEdit.Name = "commentsMemoExEdit";
            this.commentsMemoExEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsMemoExEdit.Properties.Appearance.Options.UseFont = true;
            this.commentsMemoExEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.commentsMemoExEdit.Size = new System.Drawing.Size(350, 29);
            this.commentsMemoExEdit.TabIndex = 22;
            this.commentsMemoExEdit.EditValueChanged += new System.EventHandler(this.commentsMemoExEdit_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(10, 561);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 19);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Comments:";
            // 
            // receiptViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(856, 596);
            this.Controls.Add(this.commentsMemoExEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.paymentTypeGridControl);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.receiptLinesGroupControl);
            this.Name = "receiptViewForm";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.receiptViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.receiptLinesGroupControl, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.paymentTypeGridControl, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.commentsMemoExEdit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.receiptLinesGroupControl)).EndInit();
            this.receiptLinesGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.existingCreditSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptTotalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTotalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsMemoExEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl receiptLinesGroupControl;
        private DevExpress.XtraGrid.GridControl paymentListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView paymentListGridView;
        private DevExpress.XtraEditors.SimpleButton removePaymentBtn;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraGrid.Columns.GridColumn payinTypeCol;
        private DevExpress.XtraGrid.Columns.GridColumn payinAmountCol;
        private DevExpress.XtraGrid.Columns.GridColumn bankCol;
        private DevExpress.XtraGrid.Columns.GridColumn branchCol;
        private DevExpress.XtraGrid.Columns.GridColumn drawerCol;
        private DevExpress.XtraGrid.Columns.GridColumn chequeNoCol;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        internal DevExpress.XtraEditors.SpinEdit existingCreditSpinEdit;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        internal DevExpress.XtraEditors.SpinEdit receiptTotalSpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit;
        private DevExpress.XtraGrid.GridControl paymentTypeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView paymentTypeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn paymentTypeDescCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        internal DevExpress.XtraEditors.SpinEdit invoiceTotalSpinEdit;
        private DevExpress.XtraEditors.MemoExEdit commentsMemoExEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
