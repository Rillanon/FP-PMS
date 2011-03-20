namespace FP_PMS.Scheduling
{
    partial class appointmentLookUpViewForm
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
            this.futureDateCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.patientLookUpGrid = new DevExpress.XtraGrid.GridControl();
            this.patientLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhysioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.patientLinqInstantFeedbackSource = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.appointmentsGridControl = new DevExpress.XtraGrid.GridControl();
            this.appointmentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dobCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.startCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.patientRepositoryItemSearchLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVANumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.goBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.futureDateCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRepositoryItemSearchLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // futureDateCheckEdit
            // 
            this.futureDateCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.futureDateCheckEdit.Location = new System.Drawing.Point(13, 566);
            this.futureDateCheckEdit.Margin = new System.Windows.Forms.Padding(4);
            this.futureDateCheckEdit.Name = "futureDateCheckEdit";
            this.futureDateCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureDateCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.futureDateCheckEdit.Properties.Caption = "Future Dates Only";
            this.futureDateCheckEdit.Size = new System.Drawing.Size(266, 24);
            this.futureDateCheckEdit.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.patientLookUpGrid);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(561, 556);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Patients";
            // 
            // patientLookUpGrid
            // 
            this.patientLookUpGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientLookUpGrid.Location = new System.Drawing.Point(2, 28);
            this.patientLookUpGrid.MainView = this.patientLookUpView;
            this.patientLookUpGrid.Name = "patientLookUpGrid";
            this.patientLookUpGrid.Size = new System.Drawing.Size(557, 526);
            this.patientLookUpGrid.TabIndex = 2;
            this.patientLookUpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.patientLookUpView});
            // 
            // patientLookUpView
            // 
            this.patientLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLastName,
            this.colFirstNames,
            this.colBirthDate,
            this.colSex,
            this.colPhysioID});
            this.patientLookUpView.GridControl = this.patientLookUpGrid;
            this.patientLookUpView.Name = "patientLookUpView";
            this.patientLookUpView.OptionsFind.AlwaysVisible = true;
            this.patientLookUpView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.patientLookUpView_RowCellClick);
            // 
            // colLastName
            // 
            this.colLastName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLastName.AppearanceCell.Options.UseFont = true;
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 0;
            // 
            // colFirstNames
            // 
            this.colFirstNames.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFirstNames.AppearanceCell.Options.UseFont = true;
            this.colFirstNames.FieldName = "FirstNames";
            this.colFirstNames.Name = "colFirstNames";
            this.colFirstNames.Visible = true;
            this.colFirstNames.VisibleIndex = 1;
            // 
            // colBirthDate
            // 
            this.colBirthDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBirthDate.AppearanceCell.Options.UseFont = true;
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 2;
            // 
            // colSex
            // 
            this.colSex.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSex.AppearanceCell.Options.UseFont = true;
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 3;
            // 
            // colPhysioID
            // 
            this.colPhysioID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPhysioID.AppearanceCell.Options.UseFont = true;
            this.colPhysioID.FieldName = "PhysioID";
            this.colPhysioID.Name = "colPhysioID";
            this.colPhysioID.Visible = true;
            this.colPhysioID.VisibleIndex = 4;
            // 
            // patientLinqInstantFeedbackSource
            // 
            this.patientLinqInstantFeedbackSource.AreSourceRowsThreadSafe = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.appointmentsGridControl);
            this.groupControl2.Location = new System.Drawing.Point(565, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(501, 556);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Appointments";
            // 
            // appointmentsGridControl
            // 
            this.appointmentsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentsGridControl.Location = new System.Drawing.Point(2, 28);
            this.appointmentsGridControl.MainView = this.appointmentsGridView;
            this.appointmentsGridControl.Name = "appointmentsGridControl";
            this.appointmentsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.patientRepositoryItemSearchLookUpEdit});
            this.appointmentsGridControl.Size = new System.Drawing.Size(497, 526);
            this.appointmentsGridControl.TabIndex = 1;
            this.appointmentsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.appointmentsGridView});
            // 
            // appointmentsGridView
            // 
            this.appointmentsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameCol,
            this.dobCol,
            this.physioCol,
            this.rateCol,
            this.startCol,
            this.endCol,
            this.dateCol});
            this.appointmentsGridView.GridControl = this.appointmentsGridControl;
            this.appointmentsGridView.Name = "appointmentsGridView";
            // 
            // nameCol
            // 
            this.nameCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.nameCol.AppearanceCell.Options.UseFont = true;
            this.nameCol.Caption = "Name";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.ReadOnly = true;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            // 
            // dobCol
            // 
            this.dobCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dobCol.AppearanceCell.Options.UseFont = true;
            this.dobCol.Caption = "Date of Birth";
            this.dobCol.DisplayFormat.FormatString = "d";
            this.dobCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dobCol.FieldName = "DOB";
            this.dobCol.Name = "dobCol";
            this.dobCol.Visible = true;
            this.dobCol.VisibleIndex = 1;
            // 
            // physioCol
            // 
            this.physioCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.physioCol.AppearanceCell.Options.UseFont = true;
            this.physioCol.Caption = "Physio";
            this.physioCol.FieldName = "Physio";
            this.physioCol.Name = "physioCol";
            this.physioCol.OptionsColumn.ReadOnly = true;
            this.physioCol.Visible = true;
            this.physioCol.VisibleIndex = 2;
            // 
            // rateCol
            // 
            this.rateCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rateCol.AppearanceCell.Options.UseFont = true;
            this.rateCol.Caption = "Rate";
            this.rateCol.FieldName = "Rate";
            this.rateCol.Name = "rateCol";
            this.rateCol.OptionsColumn.ReadOnly = true;
            this.rateCol.Visible = true;
            this.rateCol.VisibleIndex = 3;
            // 
            // startCol
            // 
            this.startCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.startCol.AppearanceCell.Options.UseFont = true;
            this.startCol.Caption = "Start";
            this.startCol.FieldName = "Start";
            this.startCol.Name = "startCol";
            this.startCol.OptionsColumn.ReadOnly = true;
            this.startCol.Visible = true;
            this.startCol.VisibleIndex = 4;
            // 
            // endCol
            // 
            this.endCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.endCol.AppearanceCell.Options.UseFont = true;
            this.endCol.Caption = "End";
            this.endCol.FieldName = "End";
            this.endCol.Name = "endCol";
            this.endCol.OptionsColumn.ReadOnly = true;
            this.endCol.Visible = true;
            this.endCol.VisibleIndex = 5;
            // 
            // dateCol
            // 
            this.dateCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCol.AppearanceCell.Options.UseFont = true;
            this.dateCol.Caption = "Date";
            this.dateCol.DisplayFormat.FormatString = "d";
            this.dateCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateCol.FieldName = "Date";
            this.dateCol.Name = "dateCol";
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 6;
            // 
            // patientRepositoryItemSearchLookUpEdit
            // 
            this.patientRepositoryItemSearchLookUpEdit.AutoHeight = false;
            this.patientRepositoryItemSearchLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.patientRepositoryItemSearchLookUpEdit.Name = "patientRepositoryItemSearchLookUpEdit";
            this.patientRepositoryItemSearchLookUpEdit.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colDVANumber});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "FirstNames";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "LastName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Sex";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // colDVANumber
            // 
            this.colDVANumber.FieldName = "DVANumber";
            this.colDVANumber.Name = "colDVANumber";
            this.colDVANumber.Visible = true;
            this.colDVANumber.VisibleIndex = 3;
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(978, 568);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 4;
            this.quitBtn.Text = "Quit";
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // goBtn
            // 
            this.goBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goBtn.Location = new System.Drawing.Point(565, 568);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 2;
            this.goBtn.Text = "Go";
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // appointmentLookUpViewForm
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 603);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.futureDateCheckEdit);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "appointmentLookUpViewForm";
            this.Text = "Appointments Look Up";
            this.Load += new System.EventHandler(this.appointmentLookUpViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futureDateCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRepositoryItemSearchLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit futureDateCheckEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl patientLookUpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView patientLookUpView;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource patientLinqInstantFeedbackSource;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstNames;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysioID;
        private DevExpress.XtraGrid.GridControl appointmentsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView appointmentsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn dobCol;
        private DevExpress.XtraGrid.Columns.GridColumn physioCol;
        private DevExpress.XtraGrid.Columns.GridColumn rateCol;
        private DevExpress.XtraGrid.Columns.GridColumn startCol;
        private DevExpress.XtraGrid.Columns.GridColumn endCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit patientRepositoryItemSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colDVANumber;
        private DevExpress.XtraEditors.SimpleButton quitBtn;
        private DevExpress.XtraEditors.SimpleButton goBtn;
        private DevExpress.XtraGrid.Columns.GridColumn dateCol;
    }
}