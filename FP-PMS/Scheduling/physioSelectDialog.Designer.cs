namespace FP_PMS.Scheduling
{
    partial class physioSelectDialog
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
            this.physioLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.physioLinqInstantFeedBackSource = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.physioLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.physioIDCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physioNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUpView)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(305, 79);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(245, 79);
            // 
            // physioLookUp
            // 
            this.physioLookUp.Location = new System.Drawing.Point(83, 33);
            this.physioLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.physioLookUp.Name = "physioLookUp";
            this.physioLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physioLookUp.Properties.Appearance.Options.UseFont = true;
            this.physioLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.physioLookUp.Properties.DataSource = this.physioLinqInstantFeedBackSource;
            this.physioLookUp.Properties.DisplayMember = "PhysioName";
            this.physioLookUp.Properties.NullText = "";
            this.physioLookUp.Properties.ValueMember = "UniqueID";
            this.physioLookUp.Properties.View = this.physioLookUpView;
            this.physioLookUp.Size = new System.Drawing.Size(278, 26);
            this.physioLookUp.TabIndex = 26;
            // 
            // physioLinqInstantFeedBackSource
            // 
            this.physioLinqInstantFeedBackSource.AreSourceRowsThreadSafe = true;
            this.physioLinqInstantFeedBackSource.DesignTimeElementType = typeof(FP_PMS.Db.tblPhysio);
            this.physioLinqInstantFeedBackSource.KeyExpression = "UniqueID";
            this.physioLinqInstantFeedBackSource.GetQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.physioLinqInstantFeedBackSource_GetQueryable);
            this.physioLinqInstantFeedBackSource.DismissQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.physioLinqInstantFeedBackSource_DismissQueryable);
            // 
            // physioLookUpView
            // 
            this.physioLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.physioIDCol,
            this.physioNameCol});
            this.physioLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.physioLookUpView.Name = "physioLookUpView";
            this.physioLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.physioLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // physioIDCol
            // 
            this.physioIDCol.Caption = "Physio ID";
            this.physioIDCol.FieldName = "PhysioID";
            this.physioIDCol.Name = "physioIDCol";
            this.physioIDCol.Visible = true;
            this.physioIDCol.VisibleIndex = 0;
            // 
            // physioNameCol
            // 
            this.physioNameCol.Caption = "Name";
            this.physioNameCol.FieldName = "PhysioName";
            this.physioNameCol.Name = "physioNameCol";
            this.physioNameCol.Visible = true;
            this.physioNameCol.VisibleIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(27, 36);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 19);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Physio:";
            // 
            // physioSelectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(372, 109);
            this.Controls.Add(this.physioLookUp);
            this.Controls.Add(this.labelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "physioSelectDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a Physio";
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.physioLookUp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUpView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit physioLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView physioLookUpView;
        private DevExpress.XtraGrid.Columns.GridColumn physioIDCol;
        private DevExpress.XtraGrid.Columns.GridColumn physioNameCol;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource physioLinqInstantFeedBackSource;

    }
}
