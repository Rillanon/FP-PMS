namespace FP_PMS.Report
{
    partial class receiptsByPhysioRateForm
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
            this.receiptsPhysioPivotGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.physioIDField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.rateField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.itemTypeField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.itemField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.feeField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.gstField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.totalField = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsPhysioPivotGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(801, 553);
            this.quitBtn.Visible = false;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(741, 553);
            this.okBtn.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.receiptsPhysioPivotGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(857, 583);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Physio Receipts";
            // 
            // receiptsPhysioPivotGrid
            // 
            this.receiptsPhysioPivotGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptsPhysioPivotGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.physioIDField,
            this.rateField,
            this.itemTypeField,
            this.itemField,
            this.feeField,
            this.gstField,
            this.totalField});
            this.receiptsPhysioPivotGrid.Location = new System.Drawing.Point(2, 22);
            this.receiptsPhysioPivotGrid.Name = "receiptsPhysioPivotGrid";
            this.receiptsPhysioPivotGrid.Size = new System.Drawing.Size(853, 559);
            this.receiptsPhysioPivotGrid.TabIndex = 0;
            // 
            // physioIDField
            // 
            this.physioIDField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.physioIDField.AreaIndex = 0;
            this.physioIDField.Caption = "Physio";
            this.physioIDField.FieldName = "Physio";
            this.physioIDField.Name = "physioIDField";
            // 
            // rateField
            // 
            this.rateField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.rateField.AreaIndex = 1;
            this.rateField.Caption = "Rate";
            this.rateField.FieldName = "Rate";
            this.rateField.Name = "rateField";
            // 
            // itemTypeField
            // 
            this.itemTypeField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.itemTypeField.AreaIndex = 2;
            this.itemTypeField.Caption = "Item Type";
            this.itemTypeField.FieldName = "ItemTypeDesc";
            this.itemTypeField.Name = "itemTypeField";
            // 
            // itemField
            // 
            this.itemField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.itemField.AreaIndex = 3;
            this.itemField.Caption = "Item";
            this.itemField.FieldName = "Item";
            this.itemField.Name = "itemField";
            // 
            // feeField
            // 
            this.feeField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.feeField.AreaIndex = 0;
            this.feeField.Caption = "Fee";
            this.feeField.FieldName = "FeeTotal";
            this.feeField.Name = "feeField";
            // 
            // gstField
            // 
            this.gstField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.gstField.AreaIndex = 1;
            this.gstField.Caption = "GST";
            this.gstField.FieldName = "GsTTotal";
            this.gstField.Name = "gstField";
            // 
            // totalField
            // 
            this.totalField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.totalField.AreaIndex = 2;
            this.totalField.Caption = "Total";
            this.totalField.FieldName = "FinalTotal";
            this.totalField.Name = "totalField";
            // 
            // receiptsByPhysioRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(857, 583);
            this.Controls.Add(this.groupControl1);
            this.Name = "receiptsByPhysioRateForm";
            this.Text = "Physio Receipts";
            this.Load += new System.EventHandler(this.receiptsByPhysioRateForm_Load);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptsPhysioPivotGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl receiptsPhysioPivotGrid;
        private DevExpress.XtraPivotGrid.PivotGridField physioIDField;
        private DevExpress.XtraPivotGrid.PivotGridField rateField;
        private DevExpress.XtraPivotGrid.PivotGridField itemTypeField;
        private DevExpress.XtraPivotGrid.PivotGridField itemField;
        private DevExpress.XtraPivotGrid.PivotGridField feeField;
        private DevExpress.XtraPivotGrid.PivotGridField gstField;
        private DevExpress.XtraPivotGrid.PivotGridField totalField;

    }
}
