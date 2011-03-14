namespace FP_PMS.Report
{
    partial class agedTrailBalanceViewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agedTrailBalanceViewForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.agedTrailGridControl = new DevExpress.XtraGrid.GridControl();
            this.agedTrailGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.claimantCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.termCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ageCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceTotalCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remainingCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reportPrintingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.reportPrintableComponentLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agedTrailGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agedTrailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPrintingSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(850, 541);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(790, 541);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.agedTrailGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(906, 536);
            this.groupControl1.TabIndex = 6;
            // 
            // agedTrailGridControl
            // 
            this.agedTrailGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agedTrailGridControl.Location = new System.Drawing.Point(2, 22);
            this.agedTrailGridControl.MainView = this.agedTrailGridView;
            this.agedTrailGridControl.Name = "agedTrailGridControl";
            this.agedTrailGridControl.Size = new System.Drawing.Size(902, 512);
            this.agedTrailGridControl.TabIndex = 0;
            this.agedTrailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.agedTrailGridView});
            // 
            // agedTrailGridView
            // 
            this.agedTrailGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.claimantCol,
            this.physioCol,
            this.dateCol,
            this.termCol,
            this.ageCol,
            this.invoiceNoCol,
            this.invoiceTotalCol,
            this.remainingCol,
            this.statusCol});
            this.agedTrailGridView.GridControl = this.agedTrailGridControl;
            this.agedTrailGridView.Name = "agedTrailGridView";
            this.agedTrailGridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.agedTrailGridView_CustomDrawCell);
            // 
            // claimantCol
            // 
            this.claimantCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimantCol.AppearanceCell.Options.UseFont = true;
            this.claimantCol.Caption = "Claimant";
            this.claimantCol.FieldName = "Claimant";
            this.claimantCol.Name = "claimantCol";
            this.claimantCol.Visible = true;
            this.claimantCol.VisibleIndex = 0;
            // 
            // physioCol
            // 
            this.physioCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physioCol.AppearanceCell.Options.UseFont = true;
            this.physioCol.Caption = "Physio";
            this.physioCol.FieldName = "Physio";
            this.physioCol.Name = "physioCol";
            this.physioCol.Visible = true;
            this.physioCol.VisibleIndex = 1;
            // 
            // dateCol
            // 
            this.dateCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCol.AppearanceCell.Options.UseFont = true;
            this.dateCol.Caption = "Invoice Date";
            this.dateCol.FieldName = "Date";
            this.dateCol.Name = "dateCol";
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 2;
            // 
            // termCol
            // 
            this.termCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termCol.AppearanceCell.Options.UseFont = true;
            this.termCol.Caption = "Terms";
            this.termCol.FieldName = "Terms";
            this.termCol.Name = "termCol";
            this.termCol.Visible = true;
            this.termCol.VisibleIndex = 3;
            // 
            // ageCol
            // 
            this.ageCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageCol.AppearanceCell.Options.UseFont = true;
            this.ageCol.Caption = "Age";
            this.ageCol.FieldName = "Age";
            this.ageCol.Name = "ageCol";
            this.ageCol.Visible = true;
            this.ageCol.VisibleIndex = 4;
            // 
            // invoiceNoCol
            // 
            this.invoiceNoCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNoCol.AppearanceCell.Options.UseFont = true;
            this.invoiceNoCol.Caption = "Invoice #";
            this.invoiceNoCol.FieldName = "InvoiceNo";
            this.invoiceNoCol.Name = "invoiceNoCol";
            this.invoiceNoCol.Visible = true;
            this.invoiceNoCol.VisibleIndex = 5;
            // 
            // invoiceTotalCol
            // 
            this.invoiceTotalCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceTotalCol.AppearanceCell.Options.UseFont = true;
            this.invoiceTotalCol.Caption = "Invoice Total";
            this.invoiceTotalCol.DisplayFormat.FormatString = "c2";
            this.invoiceTotalCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.invoiceTotalCol.FieldName = "InvoiceTotal";
            this.invoiceTotalCol.Name = "invoiceTotalCol";
            this.invoiceTotalCol.Visible = true;
            this.invoiceTotalCol.VisibleIndex = 6;
            // 
            // remainingCol
            // 
            this.remainingCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingCol.AppearanceCell.Options.UseFont = true;
            this.remainingCol.Caption = "Remaining";
            this.remainingCol.DisplayFormat.FormatString = "c2";
            this.remainingCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.remainingCol.FieldName = "Remaining";
            this.remainingCol.Name = "remainingCol";
            this.remainingCol.Visible = true;
            this.remainingCol.VisibleIndex = 7;
            // 
            // statusCol
            // 
            this.statusCol.Caption = "Status";
            this.statusCol.FieldName = "Status";
            this.statusCol.Name = "statusCol";
            this.statusCol.Visible = true;
            this.statusCol.VisibleIndex = 8;
            // 
            // reportPrintingSystem
            // 
            this.reportPrintingSystem.Links.AddRange(new object[] {
            this.reportPrintableComponentLink});
            // 
            // reportPrintableComponentLink
            // 
            this.reportPrintableComponentLink.Component = this.agedTrailGridControl;
            // 
            // 
            // 
            this.reportPrintableComponentLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("reportPrintableComponentLink.ImageCollection.ImageStream")));
            this.reportPrintableComponentLink.PrintingSystem = this.reportPrintingSystem;
            this.reportPrintableComponentLink.PrintingSystemBase = this.reportPrintingSystem;
            this.reportPrintableComponentLink.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.reportPrintableComponent_CreateReportHeaderArea);
            // 
            // agedTrailBalanceViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(906, 565);
            this.Controls.Add(this.groupControl1);
            this.Name = "agedTrailBalanceViewForm";
            this.Text = "Aged Trail Balance";
            this.Load += new System.EventHandler(this.agedTrailBalanceViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agedTrailGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agedTrailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPrintingSystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl agedTrailGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView agedTrailGridView;
        private DevExpress.XtraGrid.Columns.GridColumn claimantCol;
        private DevExpress.XtraGrid.Columns.GridColumn physioCol;
        private DevExpress.XtraGrid.Columns.GridColumn dateCol;
        private DevExpress.XtraGrid.Columns.GridColumn termCol;
        private DevExpress.XtraGrid.Columns.GridColumn ageCol;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceNoCol;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceTotalCol;
        private DevExpress.XtraGrid.Columns.GridColumn remainingCol;
        private DevExpress.XtraGrid.Columns.GridColumn statusCol;
        private DevExpress.XtraPrinting.PrintingSystem reportPrintingSystem;
        private DevExpress.XtraPrinting.PrintableComponentLink reportPrintableComponentLink;
    }
}
