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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.agedTrailBalancePivotGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPhysio1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldClaimant1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTerms1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAge1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldInvoiceNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldInvoiceTotal1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRemaining1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldStatus1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agedTrailBalancePivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(713, 500);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(653, 500);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.agedTrailBalancePivotGrid);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(906, 372);
            this.groupControl1.TabIndex = 6;
            // 
            // agedTrailBalancePivotGrid
            // 
            this.agedTrailBalancePivotGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agedTrailBalancePivotGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldID1,
            this.fieldPhysio1,
            this.fieldClaimant1,
            this.fieldDate1,
            this.fieldTerms1,
            this.fieldAge1,
            this.fieldInvoiceNo1,
            this.fieldInvoiceTotal1,
            this.fieldRemaining1,
            this.fieldStatus1});
            this.agedTrailBalancePivotGrid.Location = new System.Drawing.Point(2, 22);
            this.agedTrailBalancePivotGrid.Name = "agedTrailBalancePivotGrid";
            this.agedTrailBalancePivotGrid.Size = new System.Drawing.Size(902, 348);
            this.agedTrailBalancePivotGrid.TabIndex = 9;
            // 
            // fieldID1
            // 
            this.fieldID1.AreaIndex = 0;
            this.fieldID1.Caption = "ID";
            this.fieldID1.FieldName = "ID";
            this.fieldID1.Name = "fieldID1";
            this.fieldID1.Options.ShowTotals = false;
            // 
            // fieldPhysio1
            // 
            this.fieldPhysio1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPhysio1.AreaIndex = 0;
            this.fieldPhysio1.Caption = "Physio";
            this.fieldPhysio1.FieldName = "Physio";
            this.fieldPhysio1.Name = "fieldPhysio1";
            // 
            // fieldClaimant1
            // 
            this.fieldClaimant1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldClaimant1.AreaIndex = 1;
            this.fieldClaimant1.Caption = "Claimant";
            this.fieldClaimant1.FieldName = "Claimant";
            this.fieldClaimant1.MinWidth = 50;
            this.fieldClaimant1.Name = "fieldClaimant1";
            // 
            // fieldDate1
            // 
            this.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDate1.AreaIndex = 5;
            this.fieldDate1.Caption = "Date";
            this.fieldDate1.CellFormat.FormatString = "d";
            this.fieldDate1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldDate1.FieldName = "Date";
            this.fieldDate1.Name = "fieldDate1";
            this.fieldDate1.Options.ShowTotals = false;
            this.fieldDate1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.fieldDate1.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fieldDate1.ValueFormat.FormatString = "d";
            this.fieldDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldTerms1
            // 
            this.fieldTerms1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTerms1.AreaIndex = 3;
            this.fieldTerms1.Caption = "Terms";
            this.fieldTerms1.FieldName = "Terms";
            this.fieldTerms1.Name = "fieldTerms1";
            // 
            // fieldAge1
            // 
            this.fieldAge1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldAge1.AreaIndex = 2;
            this.fieldAge1.Caption = "Age";
            this.fieldAge1.FieldName = "Age";
            this.fieldAge1.Name = "fieldAge1";
            // 
            // fieldInvoiceNo1
            // 
            this.fieldInvoiceNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldInvoiceNo1.AreaIndex = 2;
            this.fieldInvoiceNo1.Caption = "Invoice No";
            this.fieldInvoiceNo1.FieldName = "InvoiceNo";
            this.fieldInvoiceNo1.Name = "fieldInvoiceNo1";
            // 
            // fieldInvoiceTotal1
            // 
            this.fieldInvoiceTotal1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldInvoiceTotal1.AreaIndex = 0;
            this.fieldInvoiceTotal1.Caption = "Invoice Total";
            this.fieldInvoiceTotal1.FieldName = "InvoiceTotal";
            this.fieldInvoiceTotal1.Name = "fieldInvoiceTotal1";
            // 
            // fieldRemaining1
            // 
            this.fieldRemaining1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRemaining1.AreaIndex = 1;
            this.fieldRemaining1.Caption = "Remaining";
            this.fieldRemaining1.FieldName = "Remaining";
            this.fieldRemaining1.Name = "fieldRemaining1";
            // 
            // fieldStatus1
            // 
            this.fieldStatus1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldStatus1.AreaIndex = 4;
            this.fieldStatus1.Caption = "Status";
            this.fieldStatus1.FieldName = "Status";
            this.fieldStatus1.Name = "fieldStatus1";
            this.fieldStatus1.Options.ShowTotals = false;
            this.fieldStatus1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.fieldStatus1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // groupControl2
            // 
            this.groupControl2.Location = new System.Drawing.Point(0, 378);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(342, 100);
            this.groupControl2.TabIndex = 8;
            // 
            // agedTrailBalanceViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(906, 530);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "agedTrailBalanceViewForm";
            this.Text = "Aged Trail Balance";
            this.Load += new System.EventHandler(this.agedTrailBalanceViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agedTrailBalancePivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraPivotGrid.PivotGridControl agedTrailBalancePivotGrid;
        private DevExpress.XtraPivotGrid.PivotGridField fieldID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPhysio1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldClaimant1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTerms1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAge1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInvoiceNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInvoiceTotal1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRemaining1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldStatus1;
    }
}
