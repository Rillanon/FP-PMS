namespace FP_PMS.Scheduling
{
    partial class waitingRoomView
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.waitingRoomGridControl = new DevExpress.XtraGrid.GridControl();
            this.waitingRoomGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.patientRepositoryItemSearchLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.patientRepositoryItemSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVANumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceBtn = new DevExpress.XtraEditors.SimpleButton();
            this.checkOutBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingRoomGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingRoomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRepositoryItemSearchLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRepositoryItemSearchLookUpEditView)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(938, 510);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(878, 510);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.waitingRoomGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1006, 502);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Waiting Room ";
            // 
            // waitingRoomGridControl
            // 
            this.waitingRoomGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waitingRoomGridControl.Location = new System.Drawing.Point(2, 22);
            this.waitingRoomGridControl.MainView = this.waitingRoomGridView;
            this.waitingRoomGridControl.Name = "waitingRoomGridControl";
            this.waitingRoomGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.patientRepositoryItemSearchLookUpEdit});
            this.waitingRoomGridControl.Size = new System.Drawing.Size(1002, 478);
            this.waitingRoomGridControl.TabIndex = 0;
            this.waitingRoomGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.waitingRoomGridView});
            // 
            // waitingRoomGridView
            // 
            this.waitingRoomGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.waitingRoomGridView.GridControl = this.waitingRoomGridControl;
            this.waitingRoomGridView.Name = "waitingRoomGridView";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.Caption = "Name";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.Caption = "Physio";
            this.gridColumn2.FieldName = "Physio";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.Caption = "Rate";
            this.gridColumn3.FieldName = "Rate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.Caption = "Start";
            this.gridColumn4.FieldName = "Start";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.Caption = "End";
            this.gridColumn5.FieldName = "End";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // patientRepositoryItemSearchLookUpEdit
            // 
            this.patientRepositoryItemSearchLookUpEdit.AutoHeight = false;
            this.patientRepositoryItemSearchLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.patientRepositoryItemSearchLookUpEdit.Name = "patientRepositoryItemSearchLookUpEdit";
            this.patientRepositoryItemSearchLookUpEdit.View = this.patientRepositoryItemSearchLookUpEditView;
            // 
            // patientRepositoryItemSearchLookUpEditView
            // 
            this.patientRepositoryItemSearchLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstNames,
            this.colLastName,
            this.colSex,
            this.colDVANumber});
            this.patientRepositoryItemSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.patientRepositoryItemSearchLookUpEditView.Name = "patientRepositoryItemSearchLookUpEditView";
            this.patientRepositoryItemSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.patientRepositoryItemSearchLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colFirstNames
            // 
            this.colFirstNames.FieldName = "FirstNames";
            this.colFirstNames.Name = "colFirstNames";
            this.colFirstNames.Visible = true;
            this.colFirstNames.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 0;
            // 
            // colSex
            // 
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 2;
            // 
            // colDVANumber
            // 
            this.colDVANumber.FieldName = "DVANumber";
            this.colDVANumber.Name = "colDVANumber";
            this.colDVANumber.Visible = true;
            this.colDVANumber.VisibleIndex = 3;
            // 
            // invoiceBtn
            // 
            this.invoiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invoiceBtn.Location = new System.Drawing.Point(12, 506);
            this.invoiceBtn.Name = "invoiceBtn";
            this.invoiceBtn.Size = new System.Drawing.Size(75, 23);
            this.invoiceBtn.TabIndex = 1;
            this.invoiceBtn.Text = "Invoice";
            this.invoiceBtn.Click += new System.EventHandler(this.invoiceBtn_Click);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkOutBtn.Location = new System.Drawing.Point(165, 506);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(75, 23);
            this.checkOutBtn.TabIndex = 7;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // waitingRoomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1005, 537);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.invoiceBtn);
            this.Controls.Add(this.groupControl1);
            this.Name = "waitingRoomView";
            this.Text = "Waiting Room";
            this.Load += new System.EventHandler(this.waitingRoomView_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.invoiceBtn, 0);
            this.Controls.SetChildIndex(this.checkOutBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waitingRoomGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingRoomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRepositoryItemSearchLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRepositoryItemSearchLookUpEditView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl waitingRoomGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView waitingRoomGridView;
        private DevExpress.XtraEditors.SimpleButton invoiceBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit patientRepositoryItemSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView patientRepositoryItemSearchLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstNames;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colDVANumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton checkOutBtn;

    }
}
