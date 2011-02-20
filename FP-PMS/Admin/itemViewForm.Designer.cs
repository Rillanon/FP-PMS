namespace FP_PMS.Admin
{
    partial class itemViewForm
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.itemNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.itemDescTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.itemLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.itemLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.itemTypeLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.itemNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDescTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypeLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(296, 224);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(236, 224);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Item #";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Item Type";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Item Desc";
            // 
            // itemNoTextEdit
            // 
            this.itemNoTextEdit.Location = new System.Drawing.Point(113, 50);
            this.itemNoTextEdit.Name = "itemNoTextEdit";
            this.itemNoTextEdit.Size = new System.Drawing.Size(177, 20);
            this.itemNoTextEdit.TabIndex = 9;
            // 
            // itemDescTextEdit
            // 
            this.itemDescTextEdit.Location = new System.Drawing.Point(113, 76);
            this.itemDescTextEdit.Name = "itemDescTextEdit";
            this.itemDescTextEdit.Size = new System.Drawing.Size(177, 20);
            this.itemDescTextEdit.TabIndex = 11;
            // 
            // itemLookUp
            // 
            this.itemLookUp.Location = new System.Drawing.Point(105, 31);
            this.itemLookUp.Name = "itemLookUp";
            this.itemLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemLookUp.Properties.NullText = "";
            this.itemLookUp.Properties.View = this.itemLookUpView;
            this.itemLookUp.Size = new System.Drawing.Size(247, 20);
            this.itemLookUp.TabIndex = 13;
            this.itemLookUp.EditValueChanged += new System.EventHandler(this.itemLookUp_EditValueChanged);
            // 
            // itemLookUpView
            // 
            this.itemLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.itemLookUpView.Name = "itemLookUpView";
            this.itemLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.itemLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Select Item";
            // 
            // itemTypeLookUp
            // 
            this.itemTypeLookUp.Location = new System.Drawing.Point(113, 102);
            this.itemTypeLookUp.Name = "itemTypeLookUp";
            this.itemTypeLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemTypeLookUp.Properties.NullText = "";
            this.itemTypeLookUp.Size = new System.Drawing.Size(177, 20);
            this.itemTypeLookUp.TabIndex = 15;
            this.itemTypeLookUp.EditValueChanged += new System.EventHandler(this.itemTypeLookUp_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.itemDescTextEdit);
            this.groupControl1.Controls.Add(this.itemTypeLookUp);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.itemNoTextEdit);
            this.groupControl1.Location = new System.Drawing.Point(32, 66);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(318, 143);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Item Details";
            // 
            // itemViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(362, 257);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.itemLookUp);
            this.Name = "itemViewForm";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.itemViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.itemLookUp, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.itemNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDescTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypeLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit itemNoTextEdit;
        private DevExpress.XtraEditors.TextEdit itemDescTextEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit itemLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView itemLookUpView;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit itemTypeLookUp;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
