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
            this.titleLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.feeTotalLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.gstTotalLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.totalLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.invoiceLineTable});
            this.Detail.HeightF = 31.25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // invoiceLineTable
            // 
            this.invoiceLineTable.BorderColor = System.Drawing.Color.Transparent;
            this.invoiceLineTable.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.invoiceLineTable.BorderWidth = 0;
            this.invoiceLineTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceLineTable.LocationFloat = new DevExpress.Utils.PointFloat(29.16664F, 0F);
            this.invoiceLineTable.Name = "invoiceLineTable";
            this.invoiceLineTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.invoiceLineTable.SizeF = new System.Drawing.SizeF(607.7081F, 25F);
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
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // patientCell
            // 
            this.patientCell.Name = "patientCell";
            this.patientCell.Text = "[PatientID]";
            this.patientCell.Weight = 1.4911615948865387D;
            // 
            // itemCell
            // 
            this.itemCell.Name = "itemCell";
            this.itemCell.Text = "[ItemNo]";
            this.itemCell.Weight = 1.1590544917680152D;
            // 
            // feeCell
            // 
            this.feeCell.Name = "feeCell";
            xrSummary1.FormatString = "{0:$0.00}";
            this.feeCell.Summary = xrSummary1;
            this.feeCell.Text = "[Fee]";
            this.feeCell.Weight = 1.095666615448369D;
            // 
            // gstCell
            // 
            this.gstCell.Name = "gstCell";
            xrSummary2.FormatString = "{0:$0.00}";
            this.gstCell.Summary = xrSummary2;
            this.gstCell.Text = "[GST]";
            this.gstCell.Weight = 1.3119278142544988D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.postCodeLabel,
            this.suburbLabel,
            this.stateLabel,
            this.streetLabel,
            this.claimantNameLabel,
            this.xrLabel1,
            this.invoiceDateLabel,
            this.InvoiceNoLabel,
            this.titleLabel,
            this.xrLine1});
            this.TopMargin.HeightF = 237.0833F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // postCodeLabel
            // 
            this.postCodeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodeLabel.LocationFloat = new DevExpress.Utils.PointFloat(211.4583F, 205.375F);
            this.postCodeLabel.Name = "postCodeLabel";
            this.postCodeLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.postCodeLabel.SizeF = new System.Drawing.SizeF(295.8333F, 23F);
            this.postCodeLabel.StylePriority.UseFont = false;
            this.postCodeLabel.Text = "xrLabel2";
            // 
            // suburbLabel
            // 
            this.suburbLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suburbLabel.LocationFloat = new DevExpress.Utils.PointFloat(211.4583F, 182.375F);
            this.suburbLabel.Name = "suburbLabel";
            this.suburbLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.suburbLabel.SizeF = new System.Drawing.SizeF(295.8333F, 23F);
            this.suburbLabel.StylePriority.UseFont = false;
            this.suburbLabel.Text = "xrLabel2";
            // 
            // stateLabel
            // 
            this.stateLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.LocationFloat = new DevExpress.Utils.PointFloat(32.29167F, 205.375F);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.stateLabel.SizeF = new System.Drawing.SizeF(179.1666F, 23F);
            this.stateLabel.StylePriority.UseFont = false;
            this.stateLabel.Text = "xrLabel2";
            // 
            // streetLabel
            // 
            this.streetLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.LocationFloat = new DevExpress.Utils.PointFloat(32.29167F, 182.375F);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.streetLabel.SizeF = new System.Drawing.SizeF(179.1667F, 23F);
            this.streetLabel.StylePriority.UseFont = false;
            this.streetLabel.Text = "xrLabel2";
            // 
            // claimantNameLabel
            // 
            this.claimantNameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimantNameLabel.LocationFloat = new DevExpress.Utils.PointFloat(32.29167F, 159.375F);
            this.claimantNameLabel.Name = "claimantNameLabel";
            this.claimantNameLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.claimantNameLabel.SizeF = new System.Drawing.SizeF(475F, 23F);
            this.claimantNameLabel.StylePriority.UseFont = false;
            this.claimantNameLabel.Text = "claimantNameLabel";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(29.16667F, 118.75F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Bill to";
            // 
            // invoiceDateLabel
            // 
            this.invoiceDateLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDateLabel.LocationFloat = new DevExpress.Utils.PointFloat(435.4167F, 36.45835F);
            this.invoiceDateLabel.Name = "invoiceDateLabel";
            this.invoiceDateLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.invoiceDateLabel.SizeF = new System.Drawing.SizeF(204.5832F, 23F);
            this.invoiceDateLabel.StylePriority.UseFont = false;
            this.invoiceDateLabel.Text = "invoiceDateLabel";
            // 
            // InvoiceNoLabel
            // 
            this.InvoiceNoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNoLabel.LocationFloat = new DevExpress.Utils.PointFloat(435.4167F, 65.95834F);
            this.InvoiceNoLabel.Name = "InvoiceNoLabel";
            this.InvoiceNoLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.InvoiceNoLabel.SizeF = new System.Drawing.SizeF(204.5832F, 23F);
            this.InvoiceNoLabel.StylePriority.UseFont = false;
            this.InvoiceNoLabel.Text = "InvoiceNoLabel";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 36.45835F);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.titleLabel.SizeF = new System.Drawing.SizeF(377.0833F, 52.49999F);
            this.titleLabel.StylePriority.UseFont = false;
            this.titleLabel.Text = "Fairfield PhysioTherapy";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 88.95834F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(629.9998F, 7.291672F);
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderColor = System.Drawing.Color.Transparent;
            this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrTable1.BorderWidth = 0;
            this.xrTable1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(29.16667F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(607.7081F, 25F);
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
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Text = "Patient ";
            this.xrTableCell1.Weight = 1.4911615948865387D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = "Item #";
            this.xrTableCell2.Weight = 1.1590544917680152D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            xrSummary3.FormatString = "{0:$0.00}";
            this.xrTableCell3.Summary = xrSummary3;
            this.xrTableCell3.Text = "Fee";
            this.xrTableCell3.Weight = 1.095666615448369D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            xrSummary4.FormatString = "{0:$0.00}";
            this.xrTableCell4.Summary = xrSummary4;
            this.xrTableCell4.Text = "GST";
            this.xrTableCell4.Weight = 1.3119278142544988D;
            // 
            // feeTotalLabel
            // 
            this.feeTotalLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeTotalLabel.LocationFloat = new DevExpress.Utils.PointFloat(347.5966F, 10.00001F);
            this.feeTotalLabel.Name = "feeTotalLabel";
            this.feeTotalLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.feeTotalLabel.SizeF = new System.Drawing.SizeF(204.5832F, 23F);
            this.feeTotalLabel.StylePriority.UseFont = false;
            xrSummary5.FormatString = "{0:$0.00}";
            this.feeTotalLabel.Summary = xrSummary5;
            this.feeTotalLabel.Text = "Fee: $";
            // 
            // gstTotalLabel
            // 
            this.gstTotalLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstTotalLabel.LocationFloat = new DevExpress.Utils.PointFloat(347.5966F, 33.00002F);
            this.gstTotalLabel.Name = "gstTotalLabel";
            this.gstTotalLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.gstTotalLabel.SizeF = new System.Drawing.SizeF(204.5832F, 23F);
            this.gstTotalLabel.StylePriority.UseFont = false;
            this.gstTotalLabel.Text = "GST: $";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.LocationFloat = new DevExpress.Utils.PointFloat(347.5966F, 56.00001F);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.totalLabel.SizeF = new System.Drawing.SizeF(204.5832F, 23F);
            this.totalLabel.StylePriority.UseFont = false;
            this.totalLabel.Text = "Total: $";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.GroupHeader1.HeightF = 26.04167F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.feeTotalLabel,
            this.gstTotalLabel,
            this.totalLabel});
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // formattingRule1
            // 
            this.formattingRule1.Name = "formattingRule1";
            // 
            // invoicePrintReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1});
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 237, 100);
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
        private DevExpress.XtraReports.UI.XRLabel titleLabel;
        private DevExpress.XtraReports.UI.XRLabel postCodeLabel;
        private DevExpress.XtraReports.UI.XRLabel suburbLabel;
        private DevExpress.XtraReports.UI.XRLabel stateLabel;
        private DevExpress.XtraReports.UI.XRLabel streetLabel;
        private DevExpress.XtraReports.UI.XRLabel claimantNameLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
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
        private DevExpress.XtraReports.UI.XRLabel gstTotalLabel;
        private DevExpress.XtraReports.UI.XRLabel feeTotalLabel;
        private DevExpress.XtraReports.UI.XRLabel totalLabel;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
    }
}
