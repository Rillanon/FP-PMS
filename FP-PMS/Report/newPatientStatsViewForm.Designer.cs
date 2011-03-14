namespace FP_PMS.Report
{
    partial class newPatientStatsViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newPatientStatsViewForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.newPatientPivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.categoryField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.physioField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.sessionTotalField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.patientField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.feeField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.reportPrintingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.reportPrintableComponentLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPatientPivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPrintingSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(577, 499);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(517, 499);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.newPatientPivotGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(897, 630);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "New Patient Statistics";
            // 
            // newPatientPivotGridControl
            // 
            this.newPatientPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPatientPivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.categoryField,
            this.physioField,
            this.sessionTotalField,
            this.patientField,
            this.feeField});
            this.newPatientPivotGridControl.Location = new System.Drawing.Point(2, 22);
            this.newPatientPivotGridControl.Name = "newPatientPivotGridControl";
            this.newPatientPivotGridControl.Size = new System.Drawing.Size(893, 606);
            this.newPatientPivotGridControl.TabIndex = 0;
            // 
            // categoryField
            // 
            this.categoryField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.categoryField.AreaIndex = 0;
            this.categoryField.Caption = "Category";
            this.categoryField.FieldName = "Category";
            this.categoryField.Name = "categoryField";
            // 
            // physioField
            // 
            this.physioField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.physioField.AreaIndex = 1;
            this.physioField.Caption = "Physio";
            this.physioField.FieldName = "Physio";
            this.physioField.Name = "physioField";
            // 
            // sessionTotalField
            // 
            this.sessionTotalField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.sessionTotalField.AreaIndex = 0;
            this.sessionTotalField.Caption = "Total Sessions";
            this.sessionTotalField.FieldName = "SessionTotal";
            this.sessionTotalField.Name = "sessionTotalField";
            this.sessionTotalField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // patientField
            // 
            this.patientField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.patientField.AreaIndex = 1;
            this.patientField.Caption = "Total Patients";
            this.patientField.FieldName = "PatientTotal";
            this.patientField.Name = "patientField";
            this.patientField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // feeField
            // 
            this.feeField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.feeField.AreaIndex = 2;
            this.feeField.Caption = "Total Fees";
            this.feeField.CellFormat.FormatString = "c2";
            this.feeField.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.feeField.FieldName = "FeeTotal";
            this.feeField.Name = "feeField";
            // 
            // reportPrintingSystem
            // 
            this.reportPrintingSystem.Links.AddRange(new object[] {
            this.reportPrintableComponentLink});
            // 
            // reportPrintableComponentLink
            // 
            this.reportPrintableComponentLink.Component = this.newPatientPivotGridControl;
            // 
            // 
            // 
            this.reportPrintableComponentLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.reportPrintableComponentLink.PrintingSystem = this.reportPrintingSystem;
            this.reportPrintableComponentLink.PrintingSystemBase = this.reportPrintingSystem;
            this.reportPrintableComponentLink.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.reportPrintableComponentLink_CreateReportHeaderArea);
            // 
            // newPatientStatsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(897, 630);
            this.Controls.Add(this.groupControl1);
            this.Name = "newPatientStatsViewForm";
            this.Text = "New Patient Statistics";
            this.Load += new System.EventHandler(this.newPatientStatsViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newPatientPivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPrintingSystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl newPatientPivotGridControl;
        private DevExpress.XtraPivotGrid.PivotGridField categoryField;
        private DevExpress.XtraPivotGrid.PivotGridField physioField;
        private DevExpress.XtraPivotGrid.PivotGridField sessionTotalField;
        private DevExpress.XtraPivotGrid.PivotGridField patientField;
        private DevExpress.XtraPivotGrid.PivotGridField feeField;
        private DevExpress.XtraPrinting.PrintingSystem reportPrintingSystem;
        private DevExpress.XtraPrinting.PrintableComponentLink reportPrintableComponentLink;
    }
}
