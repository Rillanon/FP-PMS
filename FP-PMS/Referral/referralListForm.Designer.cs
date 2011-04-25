namespace FP_PMS.Referral
{
    partial class referralListForm
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
            this.referralInstantFeedBack = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.newReferralBtn = new DevExpress.XtraEditors.SimpleButton();
            this.viewBtn = new DevExpress.XtraEditors.SimpleButton();
            this.quitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.referralGridControl = new DevExpress.XtraGrid.GridControl();
            this.referralGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.firstNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.providerNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orgCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referralGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // referralInstantFeedBack
            // 
            this.referralInstantFeedBack.AreSourceRowsThreadSafe = true;
            this.referralInstantFeedBack.DesignTimeElementType = typeof(FP_PMS.Db.tblRefDoctor);
            this.referralInstantFeedBack.KeyExpression = "RefDoctor";
            this.referralInstantFeedBack.GetQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.referralInstantFeedBack_GetQueryable);
            this.referralInstantFeedBack.DismissQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.referralInstantFeedBack_DismissQueryable);
            // 
            // newReferralBtn
            // 
            this.newReferralBtn.Location = new System.Drawing.Point(172, 537);
            this.newReferralBtn.Name = "newReferralBtn";
            this.newReferralBtn.Size = new System.Drawing.Size(117, 23);
            this.newReferralBtn.TabIndex = 7;
            this.newReferralBtn.Text = "New Referral Doctor";
            this.newReferralBtn.Click += new System.EventHandler(this.newReferralBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(12, 537);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 6;
            this.viewBtn.Text = "View/Edit";
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(705, 537);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 5;
            this.quitBtn.Text = "Quit(Esc)";
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.referralGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(791, 520);
            this.groupControl1.TabIndex = 8;
            // 
            // referralGridControl
            // 
            this.referralGridControl.DataSource = this.referralInstantFeedBack;
            this.referralGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.referralGridControl.Location = new System.Drawing.Point(2, 22);
            this.referralGridControl.MainView = this.referralGridView;
            this.referralGridControl.Name = "referralGridControl";
            this.referralGridControl.Size = new System.Drawing.Size(787, 496);
            this.referralGridControl.TabIndex = 0;
            this.referralGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.referralGridView});
            // 
            // referralGridView
            // 
            this.referralGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.firstNameCol,
            this.lastNameCol,
            this.providerNoCol,
            this.orgCol});
            this.referralGridView.GridControl = this.referralGridControl;
            this.referralGridView.Name = "referralGridView";
            this.referralGridView.OptionsFind.AlwaysVisible = true;
            this.referralGridView.OptionsView.ShowGroupPanel = false;
            this.referralGridView.OptionsView.ShowHorzLines = false;
            // 
            // firstNameCol
            // 
            this.firstNameCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.firstNameCol.AppearanceCell.Options.UseFont = true;
            this.firstNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameCol.AppearanceHeader.Options.UseFont = true;
            this.firstNameCol.Caption = "First Name";
            this.firstNameCol.FieldName = "RefDFNames";
            this.firstNameCol.Name = "firstNameCol";
            this.firstNameCol.Visible = true;
            this.firstNameCol.VisibleIndex = 0;
            // 
            // lastNameCol
            // 
            this.lastNameCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lastNameCol.AppearanceCell.Options.UseFont = true;
            this.lastNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameCol.AppearanceHeader.Options.UseFont = true;
            this.lastNameCol.Caption = "Last Name";
            this.lastNameCol.FieldName = "RefDName";
            this.lastNameCol.Name = "lastNameCol";
            this.lastNameCol.Visible = true;
            this.lastNameCol.VisibleIndex = 1;
            // 
            // providerNoCol
            // 
            this.providerNoCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.providerNoCol.AppearanceCell.Options.UseFont = true;
            this.providerNoCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerNoCol.AppearanceHeader.Options.UseFont = true;
            this.providerNoCol.Caption = "Provider #";
            this.providerNoCol.FieldName = "RefProviderNo";
            this.providerNoCol.Name = "providerNoCol";
            this.providerNoCol.Visible = true;
            this.providerNoCol.VisibleIndex = 2;
            // 
            // orgCol
            // 
            this.orgCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.orgCol.AppearanceCell.Options.UseFont = true;
            this.orgCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgCol.AppearanceHeader.Options.UseFont = true;
            this.orgCol.Caption = "Organization";
            this.orgCol.FieldName = "RefDType";
            this.orgCol.Name = "orgCol";
            this.orgCol.Visible = true;
            this.orgCol.VisibleIndex = 3;
            // 
            // referralListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 572);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.newReferralBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.quitBtn);
            this.KeyPreview = true;
            this.Name = "referralListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Referral Doctors";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.referralListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.referralGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Data.Linq.LinqInstantFeedbackSource referralInstantFeedBack;
        private DevExpress.XtraEditors.SimpleButton newReferralBtn;
        private DevExpress.XtraEditors.SimpleButton viewBtn;
        private DevExpress.XtraEditors.SimpleButton quitBtn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl referralGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView referralGridView;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn providerNoCol;
        private DevExpress.XtraGrid.Columns.GridColumn orgCol;
    }
}