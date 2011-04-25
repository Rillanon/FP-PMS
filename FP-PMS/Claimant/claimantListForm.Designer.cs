namespace FP_PMS.Claimant
{
    partial class claimantListForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.claimantViewGridControl = new DevExpress.XtraGrid.GridControl();
            this.claimantLinqInstantFeedbackSource = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.claimantViewGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRateID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.viewBtn = new DevExpress.XtraEditors.SimpleButton();
            this.newClaimantBtn = new DevExpress.XtraEditors.SimpleButton();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimantViewGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantViewGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.claimantViewGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(792, 512);
            this.groupControl1.TabIndex = 0;
            // 
            // claimantViewGridControl
            // 
            this.claimantViewGridControl.DataSource = this.claimantLinqInstantFeedbackSource;
            this.claimantViewGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.claimantViewGridControl.Location = new System.Drawing.Point(2, 22);
            this.claimantViewGridControl.MainView = this.claimantViewGridView;
            this.claimantViewGridControl.Name = "claimantViewGridControl";
            this.claimantViewGridControl.Size = new System.Drawing.Size(788, 488);
            this.claimantViewGridControl.TabIndex = 0;
            this.claimantViewGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.claimantViewGridView});
            // 
            // claimantLinqInstantFeedbackSource
            // 
            this.claimantLinqInstantFeedbackSource.AreSourceRowsThreadSafe = true;
            this.claimantLinqInstantFeedbackSource.DesignTimeElementType = typeof(FP_PMS.Db.tblClaimant);
            this.claimantLinqInstantFeedbackSource.KeyExpression = "ClaimantID";
            this.claimantLinqInstantFeedbackSource.GetQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.claimantLinqInstantFeedbackSource_GetQueryable);
            this.claimantLinqInstantFeedbackSource.DismissQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.claimantLinqInstantFeedbackSource_DismissQueryable);
            // 
            // claimantViewGridView
            // 
            this.claimantViewGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLastName,
            this.colFirstNames,
            this.colRateID,
            this.colCompany});
            this.claimantViewGridView.GridControl = this.claimantViewGridControl;
            this.claimantViewGridView.Name = "claimantViewGridView";
            this.claimantViewGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.claimantViewGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.claimantViewGridView.OptionsBehavior.Editable = false;
            this.claimantViewGridView.OptionsBehavior.ReadOnly = true;
            this.claimantViewGridView.OptionsFind.AlwaysVisible = true;
            this.claimantViewGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.claimantViewGridView.OptionsView.ShowGroupPanel = false;
            this.claimantViewGridView.OptionsView.ShowHorzLines = false;
            this.claimantViewGridView.OptionsView.ShowVertLines = false;
            // 
            // colLastName
            // 
            this.colLastName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLastName.AppearanceCell.Options.UseFont = true;
            this.colLastName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLastName.AppearanceHeader.Options.UseFont = true;
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 0;
            // 
            // colFirstNames
            // 
            this.colFirstNames.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFirstNames.AppearanceCell.Options.UseFont = true;
            this.colFirstNames.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFirstNames.AppearanceHeader.Options.UseFont = true;
            this.colFirstNames.FieldName = "FirstNames";
            this.colFirstNames.Name = "colFirstNames";
            this.colFirstNames.Visible = true;
            this.colFirstNames.VisibleIndex = 1;
            // 
            // colRateID
            // 
            this.colRateID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRateID.AppearanceCell.Options.UseFont = true;
            this.colRateID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRateID.AppearanceHeader.Options.UseFont = true;
            this.colRateID.FieldName = "RateID";
            this.colRateID.Name = "colRateID";
            this.colRateID.Visible = true;
            this.colRateID.VisibleIndex = 2;
            // 
            // colCompany
            // 
            this.colCompany.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCompany.AppearanceCell.Options.UseFont = true;
            this.colCompany.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCompany.AppearanceHeader.Options.UseFont = true;
            this.colCompany.FieldName = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 3;
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(705, 529);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Quit(Esc)";
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(12, 529);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 2;
            this.viewBtn.Text = "View/Edit";
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // newClaimantBtn
            // 
            this.newClaimantBtn.Location = new System.Drawing.Point(167, 529);
            this.newClaimantBtn.Name = "newClaimantBtn";
            this.newClaimantBtn.Size = new System.Drawing.Size(75, 23);
            this.newClaimantBtn.TabIndex = 3;
            this.newClaimantBtn.Text = "New Claimant";
            this.newClaimantBtn.Click += new System.EventHandler(this.newClaimantBtn_Click);
            // 
            // claimantListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 574);
            this.Controls.Add(this.newClaimantBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Name = "claimantListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Claimants";
            this.Load += new System.EventHandler(this.claimantDetailsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.claimantListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.claimantViewGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantViewGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl claimantViewGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView claimantViewGridView;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource claimantLinqInstantFeedbackSource;
        private DevExpress.XtraEditors.SimpleButton quitBtn;
        private DevExpress.XtraEditors.SimpleButton viewBtn;
        private DevExpress.XtraEditors.SimpleButton newClaimantBtn;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstNames;
        private DevExpress.XtraGrid.Columns.GridColumn colRateID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}