namespace FP_PMS.Report
{
    partial class invoicePrintReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.invoiceLineTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.patientCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.feeCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.gstCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.postCodeLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.suburbLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.stateLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.streetLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.claimantNameLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.invoiceDateLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.InvoiceNoLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.feeTotalLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.gstTotalLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.totalLabel = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.invoiceLineTable});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 97.37503F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // invoiceLineTable
            // 
            this.invoiceLineTable.BorderColor = System.Drawing.Color.Transparent;
            this.invoiceLineTable.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.invoiceLineTable.BorderWidth = 0;
            this.invoiceLineTable.Dpi = 254F;
            this.invoiceLineTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceLineTable.LocationFloat = new DevExpress.Utils.PointFloat(74.08327F, 0F);
            this.invoiceLineTable.Name = "invoiceLineTable";
            this.invoiceLineTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.invoiceLineTable.SizeF = new System.Drawing.SizeF(1543.579F, 63.5F);
            this.invoiceLineTable.StylePriority.UseBorderColor = false;
            this.invoiceLineTable.StylePriority.UseBorderDashStyle = false;
            this.invoiceLineTable.StylePriority.UseBorderWidth = false;
            this.invoiceLineTable.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.patientCell,
            this.itemCell,
            this.feeCell,
            this.gstCell});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // patientCell
            // 
            this.patientCell.Dpi = 254F;
            this.patientCell.Name = "patientCell";
            this.patientCell.Text = "[PatientID]";
            this.patientCell.Weight = 1.4911615948865387D;
            // 
            // itemCell
            // 
            this.itemCell.Dpi = 254F;
            this.itemCell.Name = "itemCell";
            this.itemCell.Text = "[ItemNo]";
            this.itemCell.Weight = 1.1590544917680152D;
            // 
            // feeCell
            // 
            this.feeCell.Dpi = 254F;
            this.feeCell.Name = "feeCell";
            xrSummary1.FormatString = "{0:$0.00}";
            this.feeCell.Summary = xrSummary1;
            this.feeCell.Text = "[Fee]";
            this.feeCell.Weight = 1.095666615448369D;
            // 
            // gstCell
            // 
            this.gstCell.Dpi = 254F;
            this.gstCell.Name = "gstCell";
            xrSummary2.FormatString = "{0:$0.00}";
            this.gstCell.Summary = xrSummary2;
            this.gstCell.Text = "[GST]";
            this.gstCell.Weight = 1.3119278142544988D;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 429F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // postCodeLabel
            // 
            this.postCodeLabel.Dpi = 254F;
            this.postCodeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodeLabel.LocationFloat = new DevExpress.Utils.PointFloat(665.0834F, 447.5692F);
            this.postCodeLabel.Name = "postCodeLabel";
            this.postCodeLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.postCodeLabel.SizeF = new System.Drawing.SizeF(751.4166F, 58.42001F);
            this.postCodeLabel.StylePriority.UseFont = false;
            this.postCodeLabel.Text = "xrLabel2";
            // 
            // suburbLabel
            // 
            this.suburbLabel.Dpi = 254F;
            this.suburbLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suburbLabel.LocationFloat = new DevExpress.Utils.PointFloat(665.0834F, 389.1492F);
            this.suburbLabel.Name = "suburbLabel";
            this.suburbLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.suburbLabel.SizeF = new System.Drawing.SizeF(751.4166F, 58.41998F);
            this.suburbLabel.StylePriority.UseFont = false;
            this.suburbLabel.Text = "xrLabel2";
            // 
            // stateLabel
            // 
            this.stateLabel.Dpi = 254F;
            this.stateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.LocationFloat = new DevExpress.Utils.PointFloat(210F, 447.5692F);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.stateLabel.SizeF = new System.Drawing.SizeF(455.0832F, 58.42001F);
            this.stateLabel.StylePriority.UseFont = false;
            this.stateLabel.Text = "xrLabel2";
            // 
            // streetLabel
            // 
            this.streetLabel.Dpi = 254F;
            this.streetLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.LocationFloat = new DevExpress.Utils.PointFloat(210F, 389.1492F);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.streetLabel.SizeF = new System.Drawing.SizeF(455.0834F, 58.41998F);
            this.streetLabel.StylePriority.UseFont = false;
            this.streetLabel.Text = "xrLabel2";
            // 
            // claimantNameLabel
            // 
            this.claimantNameLabel.Dpi = 254F;
            this.claimantNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimantNameLabel.LocationFloat = new DevExpress.Utils.PointFloat(210F, 307.1283F);
            this.claimantNameLabel.Name = "claimantNameLabel";
            this.claimantNameLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.claimantNameLabel.SizeF = new System.Drawing.SizeF(1206.5F, 58.42001F);
            this.claimantNameLabel.StylePriority.UseFont = false;
            this.claimantNameLabel.Text = "claimantNameLabel";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(210F, 210F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Bill to";
            // 
            // invoiceDateLabel
            // 
            this.invoiceDateLabel.Dpi = 254F;
            this.invoiceDateLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDateLabel.LocationFloat = new DevExpress.Utils.PointFloat(1476.942F, 11.77084F);
            this.invoiceDateLabel.Name = "invoiceDateLabel";
            this.invoiceDateLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.invoiceDateLabel.SizeF = new System.Drawing.SizeF(519.6414F, 58.42F);
            this.invoiceDateLabel.StylePriority.UseFont = false;
            this.invoiceDateLabel.Text = "invoiceDateLabel";
            // 
            // InvoiceNoLabel
            // 
            this.InvoiceNoLabel.Dpi = 254F;
            this.InvoiceNoLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNoLabel.LocationFloat = new DevExpress.Utils.PointFloat(1476.942F, 86.70086F);
            this.InvoiceNoLabel.Name = "InvoiceNoLabel";
            this.InvoiceNoLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.InvoiceNoLabel.SizeF = new System.Drawing.SizeF(519.6414F, 58.42F);
            this.InvoiceNoLabel.StylePriority.UseFont = false;
            this.InvoiceNoLabel.Text = "InvoiceNoLabel";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 130F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderColor = System.Drawing.Color.Transparent;
            this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrTable1.BorderWidth = 0;
            this.xrTable1.Dpi = 254F;
            this.xrTable1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(74.08325F, 570F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1543.579F, 63.5F);
            this.xrTable1.StylePriority.UseBorderColor = false;
            this.xrTable1.StylePriority.UseBorderDashStyle = false;
            this.xrTable1.StylePriority.UseBorderWidth = false;
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Text = "Patient ";
            this.xrTableCell1.Weight = 1.4911615948865387D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Dpi = 254F;
            this.xrTableCell2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = "Item #";
            this.xrTableCell2.Weight = 1.1590544917680152D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            xrSummary3.FormatString = "{0:$0.00}";
            this.xrTableCell3.Summary = xrSummary3;
            this.xrTableCell3.Text = "Fee";
            this.xrTableCell3.Weight = 1.095666615448369D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Dpi = 254F;
            this.xrTableCell4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            xrSummary4.FormatString = "{0:$0.00}";
            this.xrTableCell4.Summary = xrSummary4;
            this.xrTableCell4.Text = "GST";
            this.xrTableCell4.Weight = 1.3119278142544988D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrTable1,
            this.xrLabel1,
            this.claimantNameLabel,
            this.streetLabel,
            this.stateLabel,
            this.suburbLabel,
            this.postCodeLabel,
            this.invoiceDateLabel,
            this.InvoiceNoLabel});
            this.GroupHeader1.Dpi = 254F;
            this.GroupHeader1.HeightF = 711.9408F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Dpi = 254F;
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(1742.583F, 169.3333F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            // 
            // formattingRule1
            // 
            this.formattingRule1.Condition = "[DataSource.RowCount] > 7";
            this.formattingRule1.Name = "formattingRule1";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.feeTotalLabel,
            this.gstTotalLabel,
            this.totalLabel});
            this.PageFooter.Dpi = 254F;
            this.PageFooter.HeightF = 220F;
            this.PageFooter.Name = "PageFooter";
            // 
            // feeTotalLabel
            // 
            this.feeTotalLabel.Dpi = 254F;
            this.feeTotalLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeTotalLabel.LocationFloat = new DevExpress.Utils.PointFloat(1476.942F, 24.99993F);
            this.feeTotalLabel.Name = "feeTotalLabel";
            this.feeTotalLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.feeTotalLabel.SizeF = new System.Drawing.SizeF(519.6414F, 58.42F);
            this.feeTotalLabel.StylePriority.UseFont = false;
            xrSummary5.FormatString = "{0:$0.00}";
            this.feeTotalLabel.Summary = xrSummary5;
            this.feeTotalLabel.Text = "Fee: $";
            // 
            // gstTotalLabel
            // 
            this.gstTotalLabel.Dpi = 254F;
            this.gstTotalLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstTotalLabel.LocationFloat = new DevExpress.Utils.PointFloat(1476.942F, 88.49992F);
            this.gstTotalLabel.Name = "gstTotalLabel";
            this.gstTotalLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.gstTotalLabel.SizeF = new System.Drawing.SizeF(519.6414F, 58.42001F);
            this.gstTotalLabel.StylePriority.UseFont = false;
            this.gstTotalLabel.Text = "GST: $";
            // 
            // totalLabel
            // 
            this.totalLabel.Dpi = 254F;
            this.totalLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.LocationFloat = new DevExpress.Utils.PointFloat(1476.942F, 151.9999F);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.totalLabel.SizeF = new System.Drawing.SizeF(519.6414F, 58.42F);
            this.totalLabel.StylePriority.UseFont = false;
            this.totalLabel.Text = "Total: $";
            // 
            // invoicePrintReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.PageFooter});
            this.Dpi = 254F;
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Margins = new System.Drawing.Printing.Margins(41, 51, 429, 130);
            this.PageHeight = 2799;
            this.PageWidth = 2101;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 31.75F;
            this.Version = "10.2";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel invoiceDateLabel;
        private DevExpress.XtraReports.UI.XRLabel InvoiceNoLabel;
        private DevExpress.XtraReports.UI.XRLabel postCodeLabel;
        private DevExpress.XtraReports.UI.XRLabel suburbLabel;
        private DevExpress.XtraReports.UI.XRLabel stateLabel;
        private DevExpress.XtraReports.UI.XRLabel streetLabel;
        private DevExpress.XtraReports.UI.XRLabel claimantNameLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell itemCell;
        private DevExpress.XtraReports.UI.XRTableCell feeCell;
        private DevExpress.XtraReports.UI.XRTableCell gstCell;
        public DevExpress.XtraReports.UI.XRTable invoiceLineTable;
        private DevExpress.XtraReports.UI.XRTableCell patientCell;
        public DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel feeTotalLabel;
        private DevExpress.XtraReports.UI.XRLabel gstTotalLabel;
        private DevExpress.XtraReports.UI.XRLabel totalLabel;
    }
}
