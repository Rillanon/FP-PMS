namespace FP_PMS.Scheduling
{
    partial class appointmentPopUp
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.patientFirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.patientLastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.patientGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.lastSessionDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.detailBtn = new DevExpress.XtraEditors.SimpleButton();
            this.patientLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.patientLinqInstantFeedBack = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.patientLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhysioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.physioLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.physioLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.physioIDCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physioNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.appointmentDurationEdit = new DevExpress.XtraScheduler.UI.DurationEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rateComboBoxEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.patientFirstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientGroupControl)).BeginInit();
            this.patientGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastSessionDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastSessionDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDurationEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateComboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(461, 443);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(401, 443);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(24, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "First Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(26, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 19);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Last Name";
            // 
            // patientFirstNameTextEdit
            // 
            this.patientFirstNameTextEdit.Location = new System.Drawing.Point(123, 38);
            this.patientFirstNameTextEdit.Name = "patientFirstNameTextEdit";
            this.patientFirstNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFirstNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.patientFirstNameTextEdit.Size = new System.Drawing.Size(355, 26);
            this.patientFirstNameTextEdit.TabIndex = 8;
            // 
            // patientLastNameTextEdit
            // 
            this.patientLastNameTextEdit.Location = new System.Drawing.Point(123, 71);
            this.patientLastNameTextEdit.Name = "patientLastNameTextEdit";
            this.patientLastNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLastNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.patientLastNameTextEdit.Size = new System.Drawing.Size(355, 26);
            this.patientLastNameTextEdit.TabIndex = 9;
            // 
            // patientGroupControl
            // 
            this.patientGroupControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientGroupControl.AppearanceCaption.Options.UseFont = true;
            this.patientGroupControl.Controls.Add(this.lastSessionDateEdit);
            this.patientGroupControl.Controls.Add(this.labelControl7);
            this.patientGroupControl.Controls.Add(this.detailBtn);
            this.patientGroupControl.Controls.Add(this.patientLastNameTextEdit);
            this.patientGroupControl.Controls.Add(this.labelControl2);
            this.patientGroupControl.Controls.Add(this.patientFirstNameTextEdit);
            this.patientGroupControl.Controls.Add(this.labelControl1);
            this.patientGroupControl.Location = new System.Drawing.Point(20, 12);
            this.patientGroupControl.Name = "patientGroupControl";
            this.patientGroupControl.Size = new System.Drawing.Size(497, 154);
            this.patientGroupControl.TabIndex = 10;
            this.patientGroupControl.Text = "Enter a new Patient";
            // 
            // lastSessionDateEdit
            // 
            this.lastSessionDateEdit.EditValue = null;
            this.lastSessionDateEdit.Location = new System.Drawing.Point(161, 113);
            this.lastSessionDateEdit.Name = "lastSessionDateEdit";
            this.lastSessionDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lastSessionDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastSessionDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.lastSessionDateEdit.Properties.Appearance.Options.UseFont = true;
            this.lastSessionDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lastSessionDateEdit.Properties.NullText = "N/A";
            this.lastSessionDateEdit.Properties.ReadOnly = true;
            this.lastSessionDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.lastSessionDateEdit.Size = new System.Drawing.Size(220, 26);
            this.lastSessionDateEdit.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(27, 116);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(129, 19);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Last Session Date:";
            // 
            // detailBtn
            // 
            this.detailBtn.Location = new System.Drawing.Point(403, 116);
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.Size = new System.Drawing.Size(75, 23);
            this.detailBtn.TabIndex = 10;
            this.detailBtn.Text = "Go to details";
            this.detailBtn.Click += new System.EventHandler(this.detailBtn_Click);
            // 
            // patientLookUp
            // 
            this.patientLookUp.Location = new System.Drawing.Point(123, 55);
            this.patientLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.patientLookUp.Name = "patientLookUp";
            this.patientLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLookUp.Properties.Appearance.Options.UseFont = true;
            this.patientLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.patientLookUp.Properties.DataSource = this.patientLinqInstantFeedBack;
            this.patientLookUp.Properties.NullText = "Select a patient";
            this.patientLookUp.Properties.ValueMember = "PatientID";
            this.patientLookUp.Properties.View = this.patientLookUpView;
            this.patientLookUp.Size = new System.Drawing.Size(355, 26);
            this.patientLookUp.TabIndex = 19;
            this.patientLookUp.EditValueChanged += new System.EventHandler(this.patientLookUp_EditValueChanged);
            this.patientLookUp.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.patientLookUp_CustomDisplayText);
            // 
            // patientLinqInstantFeedBack
            // 
            this.patientLinqInstantFeedBack.AreSourceRowsThreadSafe = true;
            this.patientLinqInstantFeedBack.DesignTimeElementType = typeof(FP_PMS.Db.tblPatient);
            this.patientLinqInstantFeedBack.KeyExpression = "PatientID";
            this.patientLinqInstantFeedBack.GetQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.patientLinqInstantFeedBack_GetQueryable);
            this.patientLinqInstantFeedBack.DismissQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.patientLinqInstantFeedBack_DismissQueryable);
            // 
            // patientLookUpView
            // 
            this.patientLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLastName,
            this.colFirstNames,
            this.colBirthDate,
            this.colPhysioID});
            this.patientLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.patientLookUpView.Name = "patientLookUpView";
            this.patientLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.patientLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // colLastName
            // 
            this.colLastName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLastName.AppearanceCell.Options.UseFont = true;
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colFirstNames
            // 
            this.colFirstNames.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFirstNames.AppearanceCell.Options.UseFont = true;
            this.colFirstNames.FieldName = "FirstNames";
            this.colFirstNames.Name = "colFirstNames";
            this.colFirstNames.Visible = true;
            this.colFirstNames.VisibleIndex = 0;
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
            // colPhysioID
            // 
            this.colPhysioID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPhysioID.AppearanceCell.Options.UseFont = true;
            this.colPhysioID.FieldName = "PhysioID";
            this.colPhysioID.Name = "colPhysioID";
            this.colPhysioID.Visible = true;
            this.colPhysioID.VisibleIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(37, 58);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 19);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Patient:";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.patientLookUp);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(20, 172);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(497, 119);
            this.groupControl2.TabIndex = 20;
            this.groupControl2.Text = "Or Select an existing Patient";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.physioLookUp);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.appointmentDurationEdit);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.rateComboBoxEdit);
            this.groupControl3.Location = new System.Drawing.Point(20, 297);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(497, 129);
            this.groupControl3.TabIndex = 21;
            this.groupControl3.Text = "Physio";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(279, 44);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 19);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Rate:";
            // 
            // physioLookUp
            // 
            this.physioLookUp.Location = new System.Drawing.Point(79, 41);
            this.physioLookUp.Margin = new System.Windows.Forms.Padding(2);
            this.physioLookUp.Name = "physioLookUp";
            this.physioLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physioLookUp.Properties.Appearance.Options.UseFont = true;
            this.physioLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.physioLookUp.Properties.NullText = "";
            this.physioLookUp.Properties.View = this.physioLookUpView;
            this.physioLookUp.Size = new System.Drawing.Size(183, 26);
            this.physioLookUp.TabIndex = 24;
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
            this.labelControl4.Location = new System.Drawing.Point(21, 44);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 19);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Physio:";
            // 
            // appointmentDurationEdit
            // 
            this.appointmentDurationEdit.Location = new System.Drawing.Point(79, 81);
            this.appointmentDurationEdit.Name = "appointmentDurationEdit";
            this.appointmentDurationEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDurationEdit.Properties.Appearance.Options.UseFont = true;
            this.appointmentDurationEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.appointmentDurationEdit.Size = new System.Drawing.Size(183, 26);
            this.appointmentDurationEdit.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(6, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 19);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Duration:";
            // 
            // rateComboBoxEdit
            // 
            this.rateComboBoxEdit.Location = new System.Drawing.Point(321, 41);
            this.rateComboBoxEdit.Name = "rateComboBoxEdit";
            this.rateComboBoxEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateComboBoxEdit.Properties.Appearance.Options.UseFont = true;
            this.rateComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rateComboBoxEdit.Properties.NullText = "";
            this.rateComboBoxEdit.Properties.PopupSizeable = false;
            this.rateComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rateComboBoxEdit.Size = new System.Drawing.Size(157, 26);
            this.rateComboBoxEdit.TabIndex = 22;
            this.rateComboBoxEdit.EditValueChanged += new System.EventHandler(this.rateComboBoxEdit_EditValueChanged);
            // 
            // appointmentPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 473);
            this.Controls.Add(this.patientGroupControl);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "appointmentPopUp";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.appointmentPopUp_Load);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.patientGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.patientFirstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientGroupControl)).EndInit();
            this.patientGroupControl.ResumeLayout(false);
            this.patientGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastSessionDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastSessionDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physioLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDurationEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateComboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit patientFirstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit patientLastNameTextEdit;
        private DevExpress.XtraEditors.GroupControl patientGroupControl;
        private DevExpress.XtraEditors.SearchLookUpEdit patientLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView patientLookUpView;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraScheduler.UI.DurationEdit appointmentDurationEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit physioLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView physioLookUpView;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton detailBtn;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource patientLinqInstantFeedBack;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit rateComboBoxEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit lastSessionDateEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstNames;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysioID;
        private DevExpress.XtraGrid.Columns.GridColumn physioIDCol;
        private DevExpress.XtraGrid.Columns.GridColumn physioNameCol;
    }
}
