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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.paymentAuditTrailGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentAuditTrailGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.groupControl1.Controls.Add(this.paymentAuditTrailGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(616, 378);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Payment Audit Trail";
            // 
            // paymentAuditTrailGridControl
            // 
            this.paymentAuditTrailGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentAuditTrailGridControl.Location = new System.Drawing.Point(2, 22);
            this.paymentAuditTrailGridControl.MainView = this.gridView1;
            this.paymentAuditTrailGridControl.Name = "paymentAuditTrailGridControl";
            this.paymentAuditTrailGridControl.Size = new System.Drawing.Size(612, 354);
            this.paymentAuditTrailGridControl.TabIndex = 7;
            this.paymentAuditTrailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.paymentAuditTrailGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // paymentAuditTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(616, 378);
            this.Controls.Add(this.groupControl1);
            this.Name = "paymentAuditTrail";
            this.Text = "Payment Audit Trail";
            this.Load += new System.EventHandler(this.paymentAuditTrail_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentAuditTrailGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl paymentAuditTrailGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
