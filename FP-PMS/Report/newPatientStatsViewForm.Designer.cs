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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.newPatientGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPatientGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.groupControl1.Controls.Add(this.newPatientGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(644, 529);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "New Patient Statistics";
            // 
            // newPatientGridControl
            // 
            this.newPatientGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPatientGridControl.Location = new System.Drawing.Point(2, 22);
            this.newPatientGridControl.MainView = this.gridView1;
            this.newPatientGridControl.Name = "newPatientGridControl";
            this.newPatientGridControl.Size = new System.Drawing.Size(640, 505);
            this.newPatientGridControl.TabIndex = 0;
            this.newPatientGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.newPatientGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // newPatientStatsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(644, 529);
            this.Controls.Add(this.groupControl1);
            this.Name = "newPatientStatsViewForm";
            this.Text = "New Patient Statistics";
            this.Load += new System.EventHandler(this.newPatientStatsViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newPatientGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl newPatientGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
