namespace FP_PMS.Admin
{
    partial class physioRateViewForm
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
            this.physioRateLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.physioRateLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rateLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.rateAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.itemLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.itemLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.physioLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.physioLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.physioIDCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physioNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.providerNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rateAmountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gstCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gstAppliedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.physioRateLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioRateLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUpView)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(340, 348);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(280, 348);
            // 
            // physioRateLookUp
            // 
            this.physioRateLookUp.Location = new System.Drawing.Point(132, 20);
            this.physioRateLookUp.Name = "physioRateLookUp";
            this.physioRateLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.physioRateLookUp.Properties.NullText = "";
            this.physioRateLookUp.Properties.View = this.physioRateLookUpView;
            this.physioRateLookUp.Size = new System.Drawing.Size(264, 20);
            this.physioRateLookUp.TabIndex = 19;
            this.physioRateLookUp.EditValueChanged += new System.EventHandler(this.physioRateLookUp_EditValueChanged);
            this.physioRateLookUp.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.physioRateLookUp_CustomDisplayText);
            // 
            // physioRateLookUpView
            // 
            this.physioRateLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.physioCol,
            this.rateCol,
            this.itemCol,
            this.rateAmountCol,
            this.gstCol,
            this.gstAppliedCol});
            this.physioRateLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.physioRateLookUpView.Name = "physioRateLookUpView";
            this.physioRateLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.physioRateLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 23);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Select a physio rate:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rateLookUp);
            this.groupControl1.Controls.Add(this.rateAmountSpinEdit);
            this.groupControl1.Controls.Add(this.itemLookUp);
            this.groupControl1.Controls.Add(this.physioLookUp);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(26, 58);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(370, 270);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Physio Rate";
            // 
            // rateLookUp
            // 
            this.rateLookUp.Location = new System.Drawing.Point(85, 76);
            this.rateLookUp.Name = "rateLookUp";
            this.rateLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rateLookUp.Properties.NullText = "";
            this.rateLookUp.Size = new System.Drawing.Size(264, 20);
            this.rateLookUp.TabIndex = 32;
            this.rateLookUp.EditValueChanged += new System.EventHandler(this.rateLookUp_EditValueChanged);
            // 
            // rateAmountSpinEdit
            // 
            this.rateAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.rateAmountSpinEdit.Location = new System.Drawing.Point(249, 221);
            this.rateAmountSpinEdit.Name = "rateAmountSpinEdit";
            this.rateAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rateAmountSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.rateAmountSpinEdit.TabIndex = 31;
            this.rateAmountSpinEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.rateAmountSpinEdit_CustomDisplayText);
            // 
            // itemLookUp
            // 
            this.itemLookUp.Location = new System.Drawing.Point(85, 106);
            this.itemLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.itemLookUp.Name = "itemLookUp";
            this.itemLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemLookUp.Properties.NullText = "";
            this.itemLookUp.Properties.View = this.itemLookUpView;
            this.itemLookUp.Size = new System.Drawing.Size(264, 20);
            this.itemLookUp.TabIndex = 30;
            this.itemLookUp.EditValueChanged += new System.EventHandler(this.itemLookUp_EditValueChanged);
            // 
            // itemLookUpView
            // 
            this.itemLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.itemLookUpView.Name = "itemLookUpView";
            this.itemLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.itemLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // physioLookUp
            // 
            this.physioLookUp.Location = new System.Drawing.Point(85, 43);
            this.physioLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.physioLookUp.Name = "physioLookUp";
            this.physioLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.physioLookUp.Properties.NullText = "";
            this.physioLookUp.Properties.View = this.physioLookUpView;
            this.physioLookUp.Size = new System.Drawing.Size(264, 20);
            this.physioLookUp.TabIndex = 28;
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
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(43, 44);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(35, 13);
            this.labelControl14.TabIndex = 27;
            this.labelControl14.Text = "Physio:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Rate Code:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(176, 222);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Rate Amount:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Item No:";
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
            this.physioNameCol.Caption = "Physio Name";
            this.physioNameCol.FieldName = "PhysioName";
            this.physioNameCol.Name = "physioNameCol";
            this.physioNameCol.Visible = true;
            this.physioNameCol.VisibleIndex = 1;
            // 
            // providerNoCol
            // 
            this.providerNoCol.Caption = "Provider No";
            this.providerNoCol.FieldName = "ProviderNo";
            this.providerNoCol.Name = "providerNoCol";
            this.providerNoCol.Visible = true;
            this.providerNoCol.VisibleIndex = 2;
            // 
            // physioCol
            // 
            this.physioCol.Caption = "Physio ID";
            this.physioCol.FieldName = "PhysioID";
            this.physioCol.Name = "physioCol";
            this.physioCol.Visible = true;
            this.physioCol.VisibleIndex = 0;
            // 
            // rateCol
            // 
            this.rateCol.Caption = "Rate";
            this.rateCol.FieldName = "RateID";
            this.rateCol.Name = "rateCol";
            this.rateCol.Visible = true;
            this.rateCol.VisibleIndex = 1;
            // 
            // itemCol
            // 
            this.itemCol.Caption = "Item #";
            this.itemCol.FieldName = "ItemNo";
            this.itemCol.Name = "itemCol";
            this.itemCol.Visible = true;
            this.itemCol.VisibleIndex = 2;
            // 
            // rateAmountCol
            // 
            this.rateAmountCol.Caption = "Rate Amount";
            this.rateAmountCol.FieldName = "RateAmount";
            this.rateAmountCol.Name = "rateAmountCol";
            this.rateAmountCol.Visible = true;
            this.rateAmountCol.VisibleIndex = 5;
            // 
            // gstCol
            // 
            this.gstCol.Caption = "GST";
            this.gstCol.FieldName = "GST";
            this.gstCol.Name = "gstCol";
            this.gstCol.Visible = true;
            this.gstCol.VisibleIndex = 3;
            // 
            // gstAppliedCol
            // 
            this.gstAppliedCol.Caption = "GST Applied";
            this.gstAppliedCol.FieldName = "GSTApplied";
            this.gstAppliedCol.Name = "gstAppliedCol";
            this.gstAppliedCol.Visible = true;
            this.gstAppliedCol.VisibleIndex = 4;
            // 
            // physioRateViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(421, 378);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.physioRateLookUp);
            this.Name = "physioRateViewForm";
            this.Text = "Physio Rates";
            this.Load += new System.EventHandler(this.physioRateViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.physioRateLookUp, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.physioRateLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioRateLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUpView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit physioRateLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView physioRateLookUpView;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit rateAmountSpinEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit itemLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView itemLookUpView;
        private DevExpress.XtraEditors.SearchLookUpEdit physioLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView physioLookUpView;
        private DevExpress.XtraGrid.Columns.GridColumn physioIDCol;
        private DevExpress.XtraGrid.Columns.GridColumn physioNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn providerNoCol;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit rateLookUp;
        private DevExpress.XtraGrid.Columns.GridColumn physioCol;
        private DevExpress.XtraGrid.Columns.GridColumn rateCol;
        private DevExpress.XtraGrid.Columns.GridColumn itemCol;
        private DevExpress.XtraGrid.Columns.GridColumn gstCol;
        private DevExpress.XtraGrid.Columns.GridColumn gstAppliedCol;
        private DevExpress.XtraGrid.Columns.GridColumn rateAmountCol;
    }
}
