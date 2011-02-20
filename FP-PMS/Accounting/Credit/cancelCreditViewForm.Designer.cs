namespace FP_PMS.Accounting.Credit
{
    partial class cancelCreditViewForm
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
            this.cancellCreditGridControl = new DevExpress.XtraGrid.GridControl();
            this.cancelCreditGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.creditNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.creditAmntCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.creditDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.creditTypeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.creditCancelCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancellCreditGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelCreditGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(662, 348);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(602, 348);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cancellCreditGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(730, 343);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Cancel Credit";
            // 
            // cancellCreditGridControl
            // 
            this.cancellCreditGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancellCreditGridControl.Location = new System.Drawing.Point(2, 22);
            this.cancellCreditGridControl.MainView = this.cancelCreditGridView;
            this.cancellCreditGridControl.Name = "cancellCreditGridControl";
            this.cancellCreditGridControl.Size = new System.Drawing.Size(726, 319);
            this.cancellCreditGridControl.TabIndex = 0;
            this.cancellCreditGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cancelCreditGridView});
            // 
            // cancelCreditGridView
            // 
            this.cancelCreditGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.creditNoCol,
            this.creditAmntCol,
            this.creditDateCol,
            this.creditTypeCol,
            this.creditCancelCol});
            this.cancelCreditGridView.GridControl = this.cancellCreditGridControl;
            this.cancelCreditGridView.Name = "cancelCreditGridView";
            this.cancelCreditGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.cancelCreditGridView_CustomColumnDisplayText);
            // 
            // creditNoCol
            // 
            this.creditNoCol.Caption = "Credit #";
            this.creditNoCol.FieldName = "CreditID";
            this.creditNoCol.Name = "creditNoCol";
            this.creditNoCol.Visible = true;
            this.creditNoCol.VisibleIndex = 0;
            // 
            // creditAmntCol
            // 
            this.creditAmntCol.Caption = "Credit $";
            this.creditAmntCol.DisplayFormat.FormatString = "c2";
            this.creditAmntCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.creditAmntCol.FieldName = "CreditAmount";
            this.creditAmntCol.Name = "creditAmntCol";
            this.creditAmntCol.Visible = true;
            this.creditAmntCol.VisibleIndex = 1;
            // 
            // creditDateCol
            // 
            this.creditDateCol.Caption = "Date";
            this.creditDateCol.FieldName = "CreditDate";
            this.creditDateCol.Name = "creditDateCol";
            this.creditDateCol.Visible = true;
            this.creditDateCol.VisibleIndex = 2;
            // 
            // creditTypeCol
            // 
            this.creditTypeCol.Caption = "Credit Type";
            this.creditTypeCol.FieldName = "CreditType";
            this.creditTypeCol.Name = "creditTypeCol";
            this.creditTypeCol.Visible = true;
            this.creditTypeCol.VisibleIndex = 3;
            // 
            // creditCancelCol
            // 
            this.creditCancelCol.Caption = "Cancel ?";
            this.creditCancelCol.FieldName = "CreditCancelled";
            this.creditCancelCol.Name = "creditCancelCol";
            this.creditCancelCol.Visible = true;
            this.creditCancelCol.VisibleIndex = 4;
            // 
            // cancelCreditViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(729, 378);
            this.Controls.Add(this.groupControl1);
            this.Name = "cancelCreditViewForm";
            this.Text = "Cancel Credit";
            this.Load += new System.EventHandler(this.cancelCreditViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cancellCreditGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelCreditGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl cancellCreditGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView cancelCreditGridView;
        private DevExpress.XtraGrid.Columns.GridColumn creditNoCol;
        private DevExpress.XtraGrid.Columns.GridColumn creditAmntCol;
        private DevExpress.XtraGrid.Columns.GridColumn creditDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn creditTypeCol;
        private DevExpress.XtraGrid.Columns.GridColumn creditCancelCol;
    }
}
