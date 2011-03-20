namespace FP_PMS.Report
{
    partial class nullSelectionForm
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
            this.physioLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.physioIDCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physioNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.claimantLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.claimantlinqInstantFeedbackSource = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.claimantLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.firstNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.streetCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.endDatePicker = new DevExpress.XtraEditors.DateEdit();
            this.startDatePicker = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.allCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(324, 186);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(264, 186);
            // 
            // physioLookUp
            // 
            this.physioLookUp.Location = new System.Drawing.Point(102, 11);
            this.physioLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.physioLookUp.Name = "physioLookUp";
            this.physioLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physioLookUp.Properties.Appearance.Options.UseFont = true;
            this.physioLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.physioLookUp.Properties.DisplayMember = "PhysioName";
            this.physioLookUp.Properties.NullText = "";
            this.physioLookUp.Properties.ValueMember = "UniqueID";
            this.physioLookUp.Properties.View = this.physioLookUpView;
            this.physioLookUp.Size = new System.Drawing.Size(278, 26);
            this.physioLookUp.TabIndex = 28;
            this.physioLookUp.EditValueChanged += new System.EventHandler(this.physioLookUp_EditValueChanged);
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
            this.labelControl4.Location = new System.Drawing.Point(34, 14);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 19);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Physio:";
            // 
            // claimantLookUp
            // 
            this.claimantLookUp.Location = new System.Drawing.Point(102, 56);
            this.claimantLookUp.Name = "claimantLookUp";
            this.claimantLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimantLookUp.Properties.Appearance.Options.UseFont = true;
            this.claimantLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.claimantLookUp.Properties.DataSource = this.claimantlinqInstantFeedbackSource;
            this.claimantLookUp.Properties.DisplayMember = "LastName";
            this.claimantLookUp.Properties.NullText = "";
            this.claimantLookUp.Properties.ValueMember = "ClaimantID";
            this.claimantLookUp.Properties.View = this.claimantLookUpView;
            this.claimantLookUp.Size = new System.Drawing.Size(278, 29);
            this.claimantLookUp.TabIndex = 29;
            this.claimantLookUp.EditValueChanged += new System.EventHandler(this.claimantLookUp_EditValueChanged);
            // 
            // claimantlinqInstantFeedbackSource
            // 
            this.claimantlinqInstantFeedbackSource.AreSourceRowsThreadSafe = true;
            this.claimantlinqInstantFeedbackSource.DesignTimeElementType = typeof(FP_PMS.Db.tblClaimant);
            this.claimantlinqInstantFeedbackSource.KeyExpression = "ClaimantID";
            this.claimantlinqInstantFeedbackSource.GetQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.claimantlinqInstantFeedbackSource_GetQueryable);
            this.claimantlinqInstantFeedbackSource.DismissQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.claimantlinqInstantFeedbackSource_DismissQueryable);
            // 
            // claimantLookUpView
            // 
            this.claimantLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.firstNameCol,
            this.lastNameCol,
            this.streetCol});
            this.claimantLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.claimantLookUpView.Name = "claimantLookUpView";
            this.claimantLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.claimantLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // firstNameCol
            // 
            this.firstNameCol.Caption = "First Names";
            this.firstNameCol.FieldName = "FirstNames";
            this.firstNameCol.Name = "firstNameCol";
            this.firstNameCol.Visible = true;
            this.firstNameCol.VisibleIndex = 0;
            // 
            // lastNameCol
            // 
            this.lastNameCol.Caption = "Last Name";
            this.lastNameCol.FieldName = "LastName";
            this.lastNameCol.Name = "lastNameCol";
            this.lastNameCol.Visible = true;
            this.lastNameCol.VisibleIndex = 1;
            // 
            // streetCol
            // 
            this.streetCol.Caption = "Street";
            this.streetCol.FieldName = "Address1";
            this.streetCol.Name = "streetCol";
            this.streetCol.Visible = true;
            this.streetCol.VisibleIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(18, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 19);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Claimant:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.EditValue = null;
            this.endDatePicker.Location = new System.Drawing.Point(102, 138);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Properties.Appearance.Options.UseFont = true;
            this.endDatePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDatePicker.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.endDatePicker.Size = new System.Drawing.Size(278, 26);
            this.endDatePicker.TabIndex = 34;
            // 
            // startDatePicker
            // 
            this.startDatePicker.EditValue = null;
            this.startDatePicker.Location = new System.Drawing.Point(102, 106);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Properties.Appearance.Options.UseFont = true;
            this.startDatePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDatePicker.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.startDatePicker.Size = new System.Drawing.Size(278, 26);
            this.startDatePicker.TabIndex = 33;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(16, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 19);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "End Date:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(10, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 19);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Start Date:";
            // 
            // allCheckEdit
            // 
            this.allCheckEdit.Location = new System.Drawing.Point(14, 181);
            this.allCheckEdit.Name = "allCheckEdit";
            this.allCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.allCheckEdit.Properties.Caption = "All Claimants/Physios";
            this.allCheckEdit.Size = new System.Drawing.Size(179, 24);
            this.allCheckEdit.TabIndex = 35;
            // 
            // nullSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(386, 217);
            this.Controls.Add(this.allCheckEdit);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.claimantLookUp);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.physioLookUp);
            this.Controls.Add(this.labelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "nullSelectionForm";
            this.Text = "Select Options";
            this.Load += new System.EventHandler(this.nullSelectionForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.physioLookUp, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.claimantLookUp, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.startDatePicker, 0);
            this.Controls.SetChildIndex(this.endDatePicker, 0);
            this.Controls.SetChildIndex(this.allCheckEdit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit physioLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView physioLookUpView;
        private DevExpress.XtraGrid.Columns.GridColumn physioIDCol;
        private DevExpress.XtraGrid.Columns.GridColumn physioNameCol;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit claimantLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView claimantLookUpView;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn streetCol;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit endDatePicker;
        private DevExpress.XtraEditors.DateEdit startDatePicker;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit allCheckEdit;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource claimantlinqInstantFeedbackSource;
    }
}
