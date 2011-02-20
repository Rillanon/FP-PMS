namespace FP_PMS.Report
{
    partial class journalReportViewForm
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
            this.gridGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.journalReportGridControl = new DevExpress.XtraGrid.GridControl();
            this.journalReportGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupControl)).BeginInit();
            this.gridGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalReportGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalReportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.quitBtn.Location = new System.Drawing.Point(655, 359);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okBtn.Location = new System.Drawing.Point(595, 359);
            // 
            // gridGroupControl
            // 
            this.gridGroupControl.Controls.Add(this.journalReportGridControl);
            this.gridGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupControl.Location = new System.Drawing.Point(0, 0);
            this.gridGroupControl.Name = "gridGroupControl";
            this.gridGroupControl.Size = new System.Drawing.Size(715, 389);
            this.gridGroupControl.TabIndex = 6;
            this.gridGroupControl.Text = "Journal Report";
            // 
            // journalReportGridControl
            // 
            this.journalReportGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalReportGridControl.Location = new System.Drawing.Point(2, 22);
            this.journalReportGridControl.MainView = this.journalReportGridView;
            this.journalReportGridControl.Name = "journalReportGridControl";
            this.journalReportGridControl.Size = new System.Drawing.Size(711, 365);
            this.journalReportGridControl.TabIndex = 7;
            this.journalReportGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.journalReportGridView});
            // 
            // journalReportGridView
            // 
            this.journalReportGridView.GridControl = this.journalReportGridControl;
            this.journalReportGridView.Name = "journalReportGridView";
            // 
            // journalReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(715, 389);
            this.Controls.Add(this.gridGroupControl);
            this.Name = "journalReportViewForm";
            this.Text = "Journal Report";
            this.Load += new System.EventHandler(this.journalReportViewForm_Load);
            this.Resize += new System.EventHandler(this.journalReportViewForm_Resize);
            this.Controls.SetChildIndex(this.gridGroupControl, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupControl)).EndInit();
            this.gridGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.journalReportGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalReportGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gridGroupControl;
        private DevExpress.XtraGrid.GridControl journalReportGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView journalReportGridView;

    }
}
