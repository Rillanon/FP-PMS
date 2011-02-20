namespace FP_PMS.Accounting.Invoice
{
    partial class addItemForm
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.itemLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.itemLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.itemIDCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemDescCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemTypeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.feeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.physioLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.physioLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.physioIDCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physioNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.providerNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rateLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.rateLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.patientLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.commentRepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.patientLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.patientFirstNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.patientLastNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.patientBirthDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.patientCommentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gstSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.addGSTBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentRepositoryItemMemoExEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gstSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click_1);
            // 
            // okBtn
            // 
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 91);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Physio:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 136);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Item:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 114);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Rate:";
            // 
            // itemLookUp
            // 
            this.itemLookUp.Location = new System.Drawing.Point(44, 134);
            this.itemLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.itemLookUp.Name = "itemLookUp";
            this.itemLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemLookUp.Properties.NullText = "";
            this.itemLookUp.Properties.View = this.itemLookUpView;
            this.itemLookUp.Size = new System.Drawing.Size(308, 20);
            this.itemLookUp.TabIndex = 10;
            this.itemLookUp.EditValueChanged += new System.EventHandler(this.itemLookUp_EditValueChanged);
            // 
            // itemLookUpView
            // 
            this.itemLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.itemIDCol,
            this.itemDescCol,
            this.itemTypeCol});
            this.itemLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.itemLookUpView.Name = "itemLookUpView";
            this.itemLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.itemLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // itemIDCol
            // 
            this.itemIDCol.Caption = "Item ID";
            this.itemIDCol.FieldName = "ItemNo";
            this.itemIDCol.Name = "itemIDCol";
            this.itemIDCol.Visible = true;
            this.itemIDCol.VisibleIndex = 0;
            // 
            // itemDescCol
            // 
            this.itemDescCol.Caption = "Item Description";
            this.itemDescCol.FieldName = "ItemDesc";
            this.itemDescCol.Name = "itemDescCol";
            this.itemDescCol.Visible = true;
            this.itemDescCol.VisibleIndex = 1;
            // 
            // itemTypeCol
            // 
            this.itemTypeCol.Caption = "Item Type";
            this.itemTypeCol.FieldName = "ItemType";
            this.itemTypeCol.Name = "itemTypeCol";
            this.itemTypeCol.Visible = true;
            this.itemTypeCol.VisibleIndex = 2;
            // 
            // feeSpinEdit
            // 
            this.feeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.feeSpinEdit.Location = new System.Drawing.Point(235, 310);
            this.feeSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.feeSpinEdit.Name = "feeSpinEdit";
            this.feeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.feeSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.feeSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.feeSpinEdit.Properties.Mask.EditMask = "c2";
            this.feeSpinEdit.Size = new System.Drawing.Size(75, 20);
            this.feeSpinEdit.TabIndex = 11;
            this.feeSpinEdit.EditValueChanged += new System.EventHandler(this.feeSpinEdit_EditValueChanged);
            this.feeSpinEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.feeSpinEdit_CustomDisplayText);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(207, 313);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Fee:";
            // 
            // physioLookUp
            // 
            this.physioLookUp.Location = new System.Drawing.Point(44, 89);
            this.physioLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.physioLookUp.Name = "physioLookUp";
            this.physioLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.physioLookUp.Properties.NullText = "";
            this.physioLookUp.Properties.View = this.physioLookUpView;
            this.physioLookUp.Size = new System.Drawing.Size(308, 20);
            this.physioLookUp.TabIndex = 13;
            this.physioLookUp.EditValueChanged += new System.EventHandler(this.physioLookUp_EditValueChanged);
            // 
            // physioLookUpView
            // 
            this.physioLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.physioIDCol,
            this.physioNameCol,
            this.providerNoCol});
            this.physioLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.physioLookUpView.Name = "physioLookUpView";
            this.physioLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.physioLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // physioIDCol
            // 
            this.physioIDCol.Caption = "Physio ID";
            this.physioIDCol.FieldName = "PhysioID";
            this.physioIDCol.Name = "physioIDCol";
            this.physioIDCol.Visible = true;
            this.physioIDCol.VisibleIndex = 0;
            // 
            // physioNameCol
            // 
            this.physioNameCol.Caption = "Name";
            this.physioNameCol.FieldName = "PhysioName";
            this.physioNameCol.Name = "physioNameCol";
            this.physioNameCol.Visible = true;
            this.physioNameCol.VisibleIndex = 1;
            // 
            // providerNoCol
            // 
            this.providerNoCol.Caption = "Provider #";
            this.providerNoCol.FieldName = "ProviderNo";
            this.providerNoCol.Name = "providerNoCol";
            this.providerNoCol.Visible = true;
            this.providerNoCol.VisibleIndex = 2;
            // 
            // rateLookUp
            // 
            this.rateLookUp.Location = new System.Drawing.Point(44, 111);
            this.rateLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.rateLookUp.Name = "rateLookUp";
            this.rateLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rateLookUp.Properties.NullText = "";
            this.rateLookUp.Properties.View = this.rateLookUpView;
            this.rateLookUp.Size = new System.Drawing.Size(308, 20);
            this.rateLookUp.TabIndex = 14;
            this.rateLookUp.EditValueChanged += new System.EventHandler(this.rateLookUp_EditValueChanged);
            // 
            // rateLookUpView
            // 
            this.rateLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.rateLookUpView.Name = "rateLookUpView";
            this.rateLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.rateLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // patientLookUp
            // 
            this.patientLookUp.Location = new System.Drawing.Point(44, 65);
            this.patientLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.patientLookUp.Name = "patientLookUp";
            this.patientLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.patientLookUp.Properties.NullText = "";
            this.patientLookUp.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.commentRepositoryItemMemoExEdit});
            this.patientLookUp.Properties.View = this.patientLookUpView;
            this.patientLookUp.Size = new System.Drawing.Size(308, 20);
            this.patientLookUp.TabIndex = 17;
            this.patientLookUp.EditValueChanged += new System.EventHandler(this.patientLookUp_EditValueChanged);
            this.patientLookUp.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.patientLookUp_CustomDisplayText);
            // 
            // commentRepositoryItemMemoExEdit
            // 
            this.commentRepositoryItemMemoExEdit.AutoHeight = false;
            this.commentRepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.commentRepositoryItemMemoExEdit.Name = "commentRepositoryItemMemoExEdit";
            // 
            // patientLookUpView
            // 
            this.patientLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.patientFirstNameCol,
            this.patientLastNameCol,
            this.patientBirthDateCol,
            this.patientCommentCol});
            this.patientLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.patientLookUpView.Name = "patientLookUpView";
            this.patientLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.patientLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // patientFirstNameCol
            // 
            this.patientFirstNameCol.Caption = "First Name";
            this.patientFirstNameCol.FieldName = "FirstNames";
            this.patientFirstNameCol.Name = "patientFirstNameCol";
            this.patientFirstNameCol.Visible = true;
            this.patientFirstNameCol.VisibleIndex = 0;
            // 
            // patientLastNameCol
            // 
            this.patientLastNameCol.Caption = "Last Name";
            this.patientLastNameCol.FieldName = "LastName";
            this.patientLastNameCol.Name = "patientLastNameCol";
            this.patientLastNameCol.Visible = true;
            this.patientLastNameCol.VisibleIndex = 1;
            // 
            // patientBirthDateCol
            // 
            this.patientBirthDateCol.Caption = "Birth Date";
            this.patientBirthDateCol.FieldName = "BirthDate";
            this.patientBirthDateCol.Name = "patientBirthDateCol";
            this.patientBirthDateCol.Visible = true;
            this.patientBirthDateCol.VisibleIndex = 2;
            // 
            // patientCommentCol
            // 
            this.patientCommentCol.Caption = "Comments";
            this.patientCommentCol.FieldName = "Comments";
            this.patientCommentCol.Name = "patientCommentCol";
            this.patientCommentCol.Visible = true;
            this.patientCommentCol.VisibleIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 68);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Patient:";
            // 
            // gstSpinEdit
            // 
            this.gstSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gstSpinEdit.Location = new System.Drawing.Point(235, 286);
            this.gstSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.gstSpinEdit.Name = "gstSpinEdit";
            this.gstSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.gstSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.gstSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gstSpinEdit.Properties.Mask.EditMask = "c2";
            this.gstSpinEdit.Size = new System.Drawing.Size(75, 20);
            this.gstSpinEdit.TabIndex = 18;
            this.gstSpinEdit.EditValueChanged += new System.EventHandler(this.gstSpinEdit_EditValueChanged);
            this.gstSpinEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.gstSpinEdit_CustomDisplayText);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(207, 289);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "GST:";
            // 
            // addGSTBtn
            // 
            this.addGSTBtn.Location = new System.Drawing.Point(29, 289);
            this.addGSTBtn.Name = "addGSTBtn";
            this.addGSTBtn.Size = new System.Drawing.Size(75, 23);
            this.addGSTBtn.TabIndex = 20;
            this.addGSTBtn.Text = "Add GST";
            this.addGSTBtn.Click += new System.EventHandler(this.addGSTBtn_Click);
            // 
            // addItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(362, 392);
            this.Controls.Add(this.addGSTBtn);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.gstSpinEdit);
            this.Controls.Add(this.patientLookUp);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.rateLookUp);
            this.Controls.Add(this.physioLookUp);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.feeSpinEdit);
            this.Controls.Add(this.itemLookUp);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "addItemForm";
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addItemForm_FormClosing);
            this.Load += new System.EventHandler(this.addItemForm_Load);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.itemLookUp, 0);
            this.Controls.SetChildIndex(this.feeSpinEdit, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.physioLookUp, 0);
            this.Controls.SetChildIndex(this.rateLookUp, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.patientLookUp, 0);
            this.Controls.SetChildIndex(this.gstSpinEdit, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.addGSTBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentRepositoryItemMemoExEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gstSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit itemLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView itemLookUpView;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit physioLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView physioLookUpView;
        private DevExpress.XtraEditors.SearchLookUpEdit rateLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView rateLookUpView;
        private DevExpress.XtraGrid.Columns.GridColumn itemIDCol;
        private DevExpress.XtraGrid.Columns.GridColumn itemDescCol;
        private DevExpress.XtraGrid.Columns.GridColumn itemTypeCol;
        private DevExpress.XtraEditors.SearchLookUpEdit patientLookUp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton addGSTBtn;
        public DevExpress.XtraEditors.SpinEdit feeSpinEdit;
        public DevExpress.XtraEditors.SpinEdit gstSpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit commentRepositoryItemMemoExEdit;
        private DevExpress.XtraGrid.Columns.GridColumn physioIDCol;
        private DevExpress.XtraGrid.Columns.GridColumn physioNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn providerNoCol;
        private DevExpress.XtraGrid.Views.Grid.GridView patientLookUpView;
        private DevExpress.XtraGrid.Columns.GridColumn patientFirstNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn patientLastNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn patientBirthDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn patientCommentCol;
    }
}
