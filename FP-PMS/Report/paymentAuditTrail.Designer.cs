namespace FP_PMS.Report
{
    partial class paymentAuditTrail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentAuditTrail));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.paymentAuditTrialPivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.userField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.descriptionField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.amountField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.receiptNoField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.reportPrintingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.reportPrintableComponentLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentAuditTrialPivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPrintingSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(555, 349);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(495, 349);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.paymentAuditTrialPivotGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(944, 613);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Payment Audit Trail";
            // 
            // paymentAuditTrialPivotGridControl
            // 
            this.paymentAuditTrialPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentAuditTrialPivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.userField,
            this.descriptionField,
            this.amountField,
            this.receiptNoField});
            this.paymentAuditTrialPivotGridControl.Location = new System.Drawing.Point(2, 22);
            this.paymentAuditTrialPivotGridControl.Name = "paymentAuditTrialPivotGridControl";
            this.paymentAuditTrialPivotGridControl.Size = new System.Drawing.Size(940, 589);
            this.paymentAuditTrialPivotGridControl.TabIndex = 0;
            // 
            // userField
            // 
            this.userField.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userField.Appearance.Cell.Options.UseFont = true;
            this.userField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.userField.AreaIndex = 0;
            this.userField.Caption = "User";
            this.userField.FieldName = "UserID";
            this.userField.Name = "userField";
            // 
            // descriptionField
            // 
            this.descriptionField.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionField.Appearance.Cell.Options.UseFont = true;
            this.descriptionField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.descriptionField.AreaIndex = 1;
            this.descriptionField.Caption = "Description";
            this.descriptionField.FieldName = "Description";
            this.descriptionField.Name = "descriptionField";
            // 
            // amountField
            // 
            this.amountField.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountField.Appearance.Cell.Options.UseFont = true;
            this.amountField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.amountField.AreaIndex = 0;
            this.amountField.Caption = "Amount";
            this.amountField.FieldName = "Amount";
            this.amountField.Name = "amountField";
            // 
            // receiptNoField
            // 
            this.receiptNoField.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptNoField.Appearance.Cell.Options.UseFont = true;
            this.receiptNoField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.receiptNoField.AreaIndex = 2;
            this.receiptNoField.Caption = "Receipt #";
            this.receiptNoField.FieldName = "ReceiptNo";
            this.receiptNoField.Name = "receiptNoField";
            // 
            // reportPrintingSystem
            // 
            this.reportPrintingSystem.Links.AddRange(new object[] {
            this.reportPrintableComponentLink});
            // 
            // reportPrintableComponentLink
            // 
            this.reportPrintableComponentLink.Component = this.paymentAuditTrialPivotGridControl;
            // 
            // 
            // 
            this.reportPrintableComponentLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("reportPrintableComponentLink.ImageCollection.ImageStream")));
            this.reportPrintableComponentLink.PrintingSystem = this.reportPrintingSystem;
            this.reportPrintableComponentLink.PrintingSystemBase = this.reportPrintingSystem;
            this.reportPrintableComponentLink.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.reportPrintableComponentLink_CreateReportHeaderArea);
            // 
            // paymentAuditTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(944, 613);
            this.Controls.Add(this.groupControl1);
            this.Name = "paymentAuditTrail";
            this.Text = "Payment Audit Trail";
            this.Load += new System.EventHandler(this.paymentAuditTrail_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentAuditTrialPivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPrintingSystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl paymentAuditTrialPivotGridControl;
        private DevExpress.XtraPivotGrid.PivotGridField userField;
        private DevExpress.XtraPivotGrid.PivotGridField descriptionField;
        private DevExpress.XtraPivotGrid.PivotGridField amountField;
        private DevExpress.XtraPivotGrid.PivotGridField receiptNoField;
        private DevExpress.XtraPrinting.PrintingSystem reportPrintingSystem;
        private DevExpress.XtraPrinting.PrintableComponentLink reportPrintableComponentLink;
    }
}
