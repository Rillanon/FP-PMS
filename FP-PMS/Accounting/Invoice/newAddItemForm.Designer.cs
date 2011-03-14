namespace FP_PMS.Accounting.Invoice
{
    partial class newAddItemForm
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
            this.addGSTBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.feeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl10 = new DevExpress.XtraEditors.GroupControl();
            this.gstSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sessionDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.itemLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.itemLookUpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.itemNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemDescCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemTypeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.feeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gstCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.patientLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.patientLookUpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhysioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).BeginInit();
            this.groupControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gstSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(331, 282);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(271, 282);
            // 
            // addGSTBtn
            // 
            this.addGSTBtn.Location = new System.Drawing.Point(12, 278);
            this.addGSTBtn.Name = "addGSTBtn";
            this.addGSTBtn.Size = new System.Drawing.Size(75, 23);
            this.addGSTBtn.TabIndex = 21;
            this.addGSTBtn.Text = "Add GST";
            this.addGSTBtn.Click += new System.EventHandler(this.addGSTBtn_Click);
            // 
            // groupControl9
            // 
            this.groupControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl9.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl9.AppearanceCaption.Options.UseFont = true;
            this.groupControl9.Controls.Add(this.feeSpinEdit);
            this.groupControl9.Location = new System.Drawing.Point(9, 25);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(165, 63);
            this.groupControl9.TabIndex = 25;
            this.groupControl9.Text = "Fee";
            // 
            // feeSpinEdit
            // 
            this.feeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.feeSpinEdit.Location = new System.Drawing.Point(4, 24);
            this.feeSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.feeSpinEdit.Name = "feeSpinEdit";
            this.feeSpinEdit.Properties.AllowFocused = false;
            this.feeSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeSpinEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.feeSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.feeSpinEdit.Properties.Appearance.Options.UseForeColor = true;
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
            this.feeSpinEdit.Size = new System.Drawing.Size(150, 32);
            this.feeSpinEdit.TabIndex = 17;
            // 
            // groupControl10
            // 
            this.groupControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl10.Controls.Add(this.gstSpinEdit);
            this.groupControl10.Location = new System.Drawing.Point(192, 25);
            this.groupControl10.Name = "groupControl10";
            this.groupControl10.Size = new System.Drawing.Size(166, 63);
            this.groupControl10.TabIndex = 24;
            this.groupControl10.Text = "GST";
            // 
            // gstSpinEdit
            // 
            this.gstSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gstSpinEdit.Location = new System.Drawing.Point(4, 24);
            this.gstSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.gstSpinEdit.Name = "gstSpinEdit";
            this.gstSpinEdit.Properties.AllowFocused = false;
            this.gstSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.gstSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.gstSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.gstSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.gstSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.gstSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.gstSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.gstSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.gstSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gstSpinEdit.Properties.Mask.EditMask = "c";
            this.gstSpinEdit.Size = new System.Drawing.Size(150, 32);
            this.gstSpinEdit.TabIndex = 16;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl10);
            this.groupControl1.Controls.Add(this.groupControl9);
            this.groupControl1.Location = new System.Drawing.Point(12, 152);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(375, 120);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Fees";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.sessionDateEdit);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.itemLookUp);
            this.groupControl2.Controls.Add(this.patientLookUp);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(12, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(375, 144);
            this.groupControl2.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(32, 109);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 19);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Date:";
            // 
            // sessionDateEdit
            // 
            this.sessionDateEdit.EditValue = null;
            this.sessionDateEdit.Location = new System.Drawing.Point(74, 106);
            this.sessionDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.sessionDateEdit.Name = "sessionDateEdit";
            this.sessionDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionDateEdit.Properties.Appearance.Options.UseFont = true;
            this.sessionDateEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.sessionDateEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.sessionDateEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
            this.sessionDateEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.sessionDateEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.sessionDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sessionDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.sessionDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.sessionDateEdit.Size = new System.Drawing.Size(284, 26);
            this.sessionDateEdit.TabIndex = 33;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(30, 71);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 24);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Item:";
            // 
            // itemLookUp
            // 
            this.itemLookUp.Location = new System.Drawing.Point(74, 68);
            this.itemLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.itemLookUp.Name = "itemLookUp";
            this.itemLookUp.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLookUp.Properties.Appearance.Options.UseFont = true;
            this.itemLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemLookUp.Properties.DisplayMember = "Description";
            this.itemLookUp.Properties.NullText = "Select an Item";
            this.itemLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.itemLookUp.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.itemLookUp.Properties.ValueMember = "ItemNo";
            this.itemLookUp.Properties.View = this.itemLookUpGridView;
            this.itemLookUp.Size = new System.Drawing.Size(284, 30);
            this.itemLookUp.TabIndex = 31;
            this.itemLookUp.EditValueChanged += new System.EventHandler(this.itemLookUp_EditValueChanged);
            // 
            // itemLookUpGridView
            // 
            this.itemLookUpGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.itemLookUpGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.itemLookUpGridView.BestFitMaxRowCount = 30;
            this.itemLookUpGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.itemNoCol,
            this.itemDescCol,
            this.itemTypeCol,
            this.feeCol,
            this.gstCol});
            this.itemLookUpGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.itemLookUpGridView.Name = "itemLookUpGridView";
            this.itemLookUpGridView.NewItemRowText = "Add a new row";
            this.itemLookUpGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.itemLookUpGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.itemLookUpGridView.OptionsBehavior.Editable = false;
            this.itemLookUpGridView.OptionsBehavior.ReadOnly = true;
            this.itemLookUpGridView.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.itemLookUpGridView.OptionsFind.AlwaysVisible = true;
            this.itemLookUpGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.itemLookUpGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.itemLookUpGridView.OptionsView.ShowGroupPanel = false;
            this.itemLookUpGridView.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // itemNoCol
            // 
            this.itemNoCol.Caption = "Item #";
            this.itemNoCol.FieldName = "ItemNo";
            this.itemNoCol.Name = "itemNoCol";
            this.itemNoCol.Visible = true;
            this.itemNoCol.VisibleIndex = 0;
            // 
            // itemDescCol
            // 
            this.itemDescCol.Caption = "Description";
            this.itemDescCol.FieldName = "Description";
            this.itemDescCol.Name = "itemDescCol";
            this.itemDescCol.Visible = true;
            this.itemDescCol.VisibleIndex = 1;
            // 
            // itemTypeCol
            // 
            this.itemTypeCol.Caption = "Type";
            this.itemTypeCol.FieldName = "Type";
            this.itemTypeCol.Name = "itemTypeCol";
            this.itemTypeCol.Visible = true;
            this.itemTypeCol.VisibleIndex = 2;
            // 
            // feeCol
            // 
            this.feeCol.Caption = "Fee";
            this.feeCol.DisplayFormat.FormatString = "c2";
            this.feeCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.feeCol.FieldName = "Fee";
            this.feeCol.Name = "feeCol";
            this.feeCol.Visible = true;
            this.feeCol.VisibleIndex = 3;
            // 
            // gstCol
            // 
            this.gstCol.Caption = "GST";
            this.gstCol.DisplayFormat.FormatString = "c2";
            this.gstCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gstCol.FieldName = "GST";
            this.gstCol.Name = "gstCol";
            this.gstCol.Visible = true;
            this.gstCol.VisibleIndex = 4;
            // 
            // patientLookUp
            // 
            this.patientLookUp.Location = new System.Drawing.Point(74, 34);
            this.patientLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.patientLookUp.Name = "patientLookUp";
            this.patientLookUp.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLookUp.Properties.Appearance.Options.UseFont = true;
            this.patientLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.patientLookUp.Properties.DisplayMember = "Name";
            this.patientLookUp.Properties.NullText = "Select a patient";
            this.patientLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.patientLookUp.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.patientLookUp.Properties.ValueMember = "PatientID";
            this.patientLookUp.Properties.View = this.patientLookUpGridView;
            this.patientLookUp.Size = new System.Drawing.Size(284, 30);
            this.patientLookUp.TabIndex = 30;
            // 
            // patientLookUpGridView
            // 
            this.patientLookUpGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.patientLookUpGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.patientLookUpGridView.BestFitMaxRowCount = 30;
            this.patientLookUpGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBirthDate,
            this.colSex,
            this.colPhysioID,
            this.colName});
            this.patientLookUpGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.patientLookUpGridView.Name = "patientLookUpGridView";
            this.patientLookUpGridView.NewItemRowText = "Add a new row";
            this.patientLookUpGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.patientLookUpGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.patientLookUpGridView.OptionsBehavior.Editable = false;
            this.patientLookUpGridView.OptionsBehavior.ReadOnly = true;
            this.patientLookUpGridView.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.patientLookUpGridView.OptionsFind.AlwaysVisible = true;
            this.patientLookUpGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.patientLookUpGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.patientLookUpGridView.OptionsView.ShowGroupPanel = false;
            this.patientLookUpGridView.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 1;
            // 
            // colSex
            // 
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 2;
            // 
            // colPhysioID
            // 
            this.colPhysioID.FieldName = "PhysioID";
            this.colPhysioID.Name = "colPhysioID";
            this.colPhysioID.Visible = true;
            this.colPhysioID.VisibleIndex = 3;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(9, 37);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 24);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Patient:";
            // 
            // newAddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(394, 314);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.addGSTBtn);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "newAddItemForm";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.newAddItemForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.addGSTBtn, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).EndInit();
            this.groupControl10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gstSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton addGSTBtn;
        private DevExpress.XtraEditors.GroupControl groupControl9;
        internal DevExpress.XtraEditors.SpinEdit feeSpinEdit;
        private DevExpress.XtraEditors.GroupControl groupControl10;
        internal DevExpress.XtraEditors.SpinEdit gstSpinEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit itemLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView itemLookUpGridView;
        private DevExpress.XtraEditors.SearchLookUpEdit patientLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView patientLookUpGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysioID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn itemNoCol;
        private DevExpress.XtraGrid.Columns.GridColumn itemDescCol;
        private DevExpress.XtraGrid.Columns.GridColumn itemTypeCol;
        private DevExpress.XtraGrid.Columns.GridColumn feeCol;
        private DevExpress.XtraGrid.Columns.GridColumn gstCol;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        internal DevExpress.XtraEditors.DateEdit sessionDateEdit;

    }
}
