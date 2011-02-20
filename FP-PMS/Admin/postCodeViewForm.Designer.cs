namespace FP_PMS.Admin
{
    partial class postCodeViewForm
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
            this.postCodeLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.postCodeLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.stateComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.locationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.postCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.postCodeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.locationCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(296, 219);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(236, 219);
            // 
            // postCodeLookUp
            // 
            this.postCodeLookUp.Location = new System.Drawing.Point(81, 12);
            this.postCodeLookUp.Name = "postCodeLookUp";
            this.postCodeLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.postCodeLookUp.Properties.NullText = "";
            this.postCodeLookUp.Properties.View = this.postCodeLookUpView;
            this.postCodeLookUp.Size = new System.Drawing.Size(271, 20);
            this.postCodeLookUp.TabIndex = 6;
            this.postCodeLookUp.EditValueChanged += new System.EventHandler(this.postCodeLookUp_EditValueChanged);
            // 
            // postCodeLookUpView
            // 
            this.postCodeLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.postCodeCol,
            this.locationCol,
            this.stateCol});
            this.postCodeLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.postCodeLookUpView.Name = "postCodeLookUpView";
            this.postCodeLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.postCodeLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Post Codes:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.stateComboBoxEdit);
            this.groupControl1.Controls.Add(this.locationTextEdit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.postCodeTextEdit);
            this.groupControl1.Location = new System.Drawing.Point(12, 48);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(340, 145);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Post Code";
            // 
            // stateComboBoxEdit
            // 
            this.stateComboBoxEdit.Location = new System.Drawing.Point(113, 102);
            this.stateComboBoxEdit.Name = "stateComboBoxEdit";
            this.stateComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.stateComboBoxEdit.Properties.Items.AddRange(new object[] {
            "VIC",
            "ACT",
            "NSW",
            "QLD",
            "SA",
            "TAS",
            "NT",
            "WA"});
            this.stateComboBoxEdit.Size = new System.Drawing.Size(177, 20);
            this.stateComboBoxEdit.TabIndex = 12;
            // 
            // locationTextEdit
            // 
            this.locationTextEdit.Location = new System.Drawing.Point(113, 76);
            this.locationTextEdit.Name = "locationTextEdit";
            this.locationTextEdit.Size = new System.Drawing.Size(177, 20);
            this.locationTextEdit.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Post Code";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(71, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "State";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(58, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Location";
            // 
            // postCodeTextEdit
            // 
            this.postCodeTextEdit.Location = new System.Drawing.Point(113, 50);
            this.postCodeTextEdit.Name = "postCodeTextEdit";
            this.postCodeTextEdit.Size = new System.Drawing.Size(177, 20);
            this.postCodeTextEdit.TabIndex = 9;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 214);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // postCodeCol
            // 
            this.postCodeCol.Caption = "Post Code";
            this.postCodeCol.FieldName = "Postcode";
            this.postCodeCol.Name = "postCodeCol";
            this.postCodeCol.Visible = true;
            this.postCodeCol.VisibleIndex = 0;
            // 
            // locationCol
            // 
            this.locationCol.Caption = "Location";
            this.locationCol.FieldName = "Location";
            this.locationCol.Name = "locationCol";
            this.locationCol.Visible = true;
            this.locationCol.VisibleIndex = 1;
            // 
            // stateCol
            // 
            this.stateCol.Caption = "State";
            this.stateCol.FieldName = "State";
            this.stateCol.Name = "stateCol";
            this.stateCol.Visible = true;
            this.stateCol.VisibleIndex = 2;
            // 
            // postCodeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(362, 249);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.postCodeLookUp);
            this.Name = "postCodeViewForm";
            this.Text = "Post Codes";
            this.Load += new System.EventHandler(this.postCodeViewForm_Load);
            this.Controls.SetChildIndex(this.postCodeLookUp, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.deleteBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.postCodeLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit postCodeLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView postCodeLookUpView;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit locationTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit postCodeTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn postCodeCol;
        private DevExpress.XtraGrid.Columns.GridColumn locationCol;
        private DevExpress.XtraGrid.Columns.GridColumn stateCol;
        private DevExpress.XtraEditors.ComboBoxEdit stateComboBoxEdit;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
    }
}
