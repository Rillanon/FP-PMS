namespace FP_PMS.Dialogs
{
    partial class patientSelectDialog
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
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.quitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.patientLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.patientLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.patientLinqInstantFeedBackSource = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhysioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpView)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(236, 52);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(317, 52);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Quit";
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // patientLookUp
            // 
            this.patientLookUp.Location = new System.Drawing.Point(81, 11);
            this.patientLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.patientLookUp.Name = "patientLookUp";
            this.patientLookUp.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLookUp.Properties.Appearance.Options.UseFont = true;
            this.patientLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.patientLookUp.Properties.DataSource = this.patientLinqInstantFeedBackSource;
            this.patientLookUp.Properties.DisplayMember = "LastName";
            this.patientLookUp.Properties.NullText = "Select a patient";
            this.patientLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.patientLookUp.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.patientLookUp.Properties.ValueMember = "PatientID";
            this.patientLookUp.Properties.View = this.patientLookUpView;
            this.patientLookUp.Size = new System.Drawing.Size(312, 30);
            this.patientLookUp.TabIndex = 23;
            this.patientLookUp.EditValueChanged += new System.EventHandler(this.patientLookUp_EditValueChanged);
            // 
            // patientLookUpView
            // 
            this.patientLookUpView.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.patientLookUpView.Appearance.ViewCaption.Options.UseFont = true;
            this.patientLookUpView.BestFitMaxRowCount = 30;
            this.patientLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBirthDate,
            this.colSex,
            this.colPhysioID,
            this.colFirstNames,
            this.colLastName});
            this.patientLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.patientLookUpView.Name = "patientLookUpView";
            this.patientLookUpView.NewItemRowText = "Add a new row";
            this.patientLookUpView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.patientLookUpView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.patientLookUpView.OptionsBehavior.Editable = false;
            this.patientLookUpView.OptionsBehavior.ReadOnly = true;
            this.patientLookUpView.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.patientLookUpView.OptionsFind.AlwaysVisible = true;
            this.patientLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.patientLookUpView.OptionsView.EnableAppearanceEvenRow = true;
            this.patientLookUpView.OptionsView.ShowGroupPanel = false;
            this.patientLookUpView.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(11, 14);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 24);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Patient:";
            // 
            // patientLinqInstantFeedBackSource
            // 
            this.patientLinqInstantFeedBackSource.AreSourceRowsThreadSafe = true;
            this.patientLinqInstantFeedBackSource.DesignTimeElementType = typeof(FP_PMS.Db.tblPatient);
            this.patientLinqInstantFeedBackSource.KeyExpression = "PatientID";
            this.patientLinqInstantFeedBackSource.GetQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.patientLinqInstantFeedBackSource_GetQueryable);
            this.patientLinqInstantFeedBackSource.DismissQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.patientLinqInstantFeedBackSource_DismissQueryable);
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 1;
            // 
            // colSex
            // 
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 2;
            // 
            // colPhysioID
            // 
            this.colPhysioID.FieldName = "PhysioID";
            this.colPhysioID.Name = "colPhysioID";
            this.colPhysioID.Visible = true;
            this.colPhysioID.VisibleIndex = 3;
            // 
            // colFirstNames
            // 
            this.colFirstNames.FieldName = "FirstNames";
            this.colFirstNames.Name = "colFirstNames";
            this.colFirstNames.Visible = true;
            this.colFirstNames.VisibleIndex = 0;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "LastName";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 4;
            // 
            // patientSelectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 87);
            this.Controls.Add(this.patientLookUp);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "patientSelectDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Patient";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patientSelectDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraEditors.SimpleButton quitBtn;
        private DevExpress.XtraEditors.SearchLookUpEdit patientLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView patientLookUpView;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysioID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstNames;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource patientLinqInstantFeedBackSource;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
    }
}