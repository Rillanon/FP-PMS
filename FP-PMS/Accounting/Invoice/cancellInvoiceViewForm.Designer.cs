namespace FP_PMS.Accounting.Invoice
{
    partial class cancellInvoiceViewForm
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
            this.cancellInvoiceGridControl = new DevExpress.XtraGrid.GridControl();
            this.cancelInvoiceGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.InvoiceNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceAmntCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceCancelCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancellInvoiceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelInvoiceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(672, 404);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(612, 404);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.cancellInvoiceGridControl);
            this.groupControl1.Location = new System.Drawing.Point(-2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(730, 397);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Cancel Invoices";
            // 
            // cancellInvoiceGridControl
            // 
            this.cancellInvoiceGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancellInvoiceGridControl.Location = new System.Drawing.Point(2, 22);
            this.cancellInvoiceGridControl.MainView = this.cancelInvoiceGridView;
            this.cancellInvoiceGridControl.Name = "cancellInvoiceGridControl";
            this.cancellInvoiceGridControl.Size = new System.Drawing.Size(726, 373);
            this.cancellInvoiceGridControl.TabIndex = 0;
            this.cancellInvoiceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cancelInvoiceGridView});
            // 
            // cancelInvoiceGridView
            // 
            this.cancelInvoiceGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.InvoiceNoCol,
            this.invoiceAmntCol,
            this.invoiceDateCol,
            this.invoiceCancelCol});
            this.cancelInvoiceGridView.GridControl = this.cancellInvoiceGridControl;
            this.cancelInvoiceGridView.Name = "cancelInvoiceGridView";
            // 
            // InvoiceNoCol
            // 
            this.InvoiceNoCol.Caption = "Invoice #";
            this.InvoiceNoCol.FieldName = "InvoiceNo";
            this.InvoiceNoCol.Name = "InvoiceNoCol";
            this.InvoiceNoCol.OptionsColumn.ReadOnly = true;
            this.InvoiceNoCol.Visible = true;
            this.InvoiceNoCol.VisibleIndex = 0;
            // 
            // invoiceAmntCol
            // 
            this.invoiceAmntCol.Caption = "Invoice $";
            this.invoiceAmntCol.DisplayFormat.FormatString = "c2";
            this.invoiceAmntCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.invoiceAmntCol.FieldName = "InvoiceAmount";
            this.invoiceAmntCol.Name = "invoiceAmntCol";
            this.invoiceAmntCol.OptionsColumn.ReadOnly = true;
            this.invoiceAmntCol.Visible = true;
            this.invoiceAmntCol.VisibleIndex = 1;
            // 
            // invoiceDateCol
            // 
            this.invoiceDateCol.Caption = "Date";
            this.invoiceDateCol.FieldName = "InvoiceDate";
            this.invoiceDateCol.Name = "invoiceDateCol";
            this.invoiceDateCol.OptionsColumn.ReadOnly = true;
            this.invoiceDateCol.Visible = true;
            this.invoiceDateCol.VisibleIndex = 2;
            // 
            // invoiceCancelCol
            // 
            this.invoiceCancelCol.Caption = "Cancel ?";
            this.invoiceCancelCol.FieldName = "InvoiceCancelled";
            this.invoiceCancelCol.Name = "invoiceCancelCol";
            this.invoiceCancelCol.Visible = true;
            this.invoiceCancelCol.VisibleIndex = 3;
            // 
            // cancellInvoiceViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(729, 434);
            this.Controls.Add(this.groupControl1);
            this.Name = "cancellInvoiceViewForm";
            this.Text = "Cancel Invoices";
            this.Load += new System.EventHandler(this.cancellInvoiceViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cancellInvoiceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelInvoiceGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl cancellInvoiceGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView cancelInvoiceGridView;
        private DevExpress.XtraGrid.Columns.GridColumn InvoiceNoCol;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceAmntCol;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceCancelCol;
    }
}
