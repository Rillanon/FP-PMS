namespace FP_PMS.Scheduling
{
    partial class appointmentViewForm
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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.appointmentSchedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.appointmentSchedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.patientAppointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db = new FP_PMS.Db.db();
            this.tblPhysioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.resourcesCheckedListBoxControl = new DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.patientAppointmentsTableAdapter = new FP_PMS.Db.dbTableAdapters.PatientAppointmentsTableAdapter();
            this.tblPhysioTableAdapter = new FP_PMS.Db.dbTableAdapters.tblPhysioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.formSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSchedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSchedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientAppointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhysioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Visible = false;
            // 
            // applyBtn
            // 
            this.applyBtn.Visible = false;
            // 
            // quitBtn
            // 
            this.quitBtn.Visible = false;
            // 
            // formSearchLookUpEdit
            // 
            this.formSearchLookUpEdit.Location = new System.Drawing.Point(540, 599);
            this.formSearchLookUpEdit.Size = new System.Drawing.Size(10, 20);
            this.formSearchLookUpEdit.Visible = false;
            // 
            // searchTitleLabel
            // 
            this.searchTitleLabel.Location = new System.Drawing.Point(381, 602);
            this.searchTitleLabel.Visible = false;
            // 
            // appointmentSchedulerControl
            // 
            this.appointmentSchedulerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentSchedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Date;
            this.appointmentSchedulerControl.Location = new System.Drawing.Point(205, 0);
            this.appointmentSchedulerControl.Name = "appointmentSchedulerControl";
            this.appointmentSchedulerControl.OptionsBehavior.SelectOnRightClick = true;
            this.appointmentSchedulerControl.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.appointmentSchedulerControl.Size = new System.Drawing.Size(973, 627);
            this.appointmentSchedulerControl.Start = new System.DateTime(2011, 1, 29, 0, 0, 0, 0);
            this.appointmentSchedulerControl.Storage = this.appointmentSchedulerStorage;
            this.appointmentSchedulerControl.TabIndex = 6;
            this.appointmentSchedulerControl.Text = "Appointments";
            this.appointmentSchedulerControl.Views.DayView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Always;
            this.appointmentSchedulerControl.Views.DayView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Always;
            this.appointmentSchedulerControl.Views.DayView.AppointmentDisplayOptions.TimeDisplayType = DevExpress.XtraScheduler.AppointmentTimeDisplayType.Clock;
            this.appointmentSchedulerControl.Views.DayView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
            timeRuler1.AlwaysShowTimeDesignator = true;
            timeRuler1.ShowMinutes = true;
            this.appointmentSchedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.appointmentSchedulerControl.Views.DayView.TimeScale = System.TimeSpan.Parse("00:15:00");
            this.appointmentSchedulerControl.Views.DayView.VisibleTime.End = System.TimeSpan.Parse("20:00:00");
            this.appointmentSchedulerControl.Views.DayView.VisibleTime.Start = System.TimeSpan.Parse("06:00:00");
            this.appointmentSchedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.appointmentSchedulerControl.AllowAppointmentConflicts += new DevExpress.XtraScheduler.AppointmentConflictEventHandler(this.appointmentSchedulerControl_AllowAppointmentConflicts);
            this.appointmentSchedulerControl.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.appointmentSchedulerControl_PopupMenuShowing);
            this.appointmentSchedulerControl.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.appointmentSchedulerControl_EditAppointmentFormShowing);
            this.appointmentSchedulerControl.CustomDrawTimeCell += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(this.appointmentSchedulerControl_CustomDrawTimeCell);
            this.appointmentSchedulerControl.Paint += new System.Windows.Forms.PaintEventHandler(this.appointmentSchedulerControl_Paint);
            this.appointmentSchedulerControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appointmentSchedulerControl_MouseDown);
            // 
            // appointmentSchedulerStorage
            // 
            this.appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("CheckIn", "CheckIn"));
            this.appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("CheckOut", "CheckOut"));
            this.appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ClaimantID", "ClaimantID"));
            this.appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Invoiced", "Invoiced"));
            this.appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("PhysioID", "PhysioID"));
            this.appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("RateID", "RateID"));
            this.appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("UniqueID", "UniqueID"));
            this.appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("PatientID", "PatientID", DevExpress.XtraScheduler.FieldValueType.Integer));
            this.appointmentSchedulerStorage.Appointments.DataSource = this.patientAppointmentsBindingSource;
            this.appointmentSchedulerStorage.Appointments.Mappings.AllDay = "AllDay";
            this.appointmentSchedulerStorage.Appointments.Mappings.Description = "Description";
            this.appointmentSchedulerStorage.Appointments.Mappings.End = "EndDate";
            this.appointmentSchedulerStorage.Appointments.Mappings.Label = "Label";
            this.appointmentSchedulerStorage.Appointments.Mappings.Location = "Location";
            this.appointmentSchedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.appointmentSchedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.appointmentSchedulerStorage.Appointments.Mappings.ResourceId = "ResourceID";
            this.appointmentSchedulerStorage.Appointments.Mappings.Start = "StartDate";
            this.appointmentSchedulerStorage.Appointments.Mappings.Status = "Status";
            this.appointmentSchedulerStorage.Appointments.Mappings.Subject = "Subject";
            this.appointmentSchedulerStorage.Appointments.Mappings.Type = "Type";
            this.appointmentSchedulerStorage.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("PhysioID", "PhysioID", DevExpress.XtraScheduler.FieldValueType.String));
            this.appointmentSchedulerStorage.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("ExistingPatientAppDefaultDuration", "ExistingPatientAppDefaultDuration"));
            this.appointmentSchedulerStorage.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("NewPatientAppDefaultDuration", "NewPatientAppDefaultDuration"));
            this.appointmentSchedulerStorage.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("UniqueID", "UniqueID", DevExpress.XtraScheduler.FieldValueType.Integer));
            this.appointmentSchedulerStorage.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("LunchStartTime", "LunchStartTime"));
            this.appointmentSchedulerStorage.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("LunchEndTime", "LunchEndTime"));
            this.appointmentSchedulerStorage.Resources.DataSource = this.tblPhysioBindingSource;
            this.appointmentSchedulerStorage.Resources.Mappings.Caption = "PhysioName";
            this.appointmentSchedulerStorage.Resources.Mappings.Color = "Color";
            this.appointmentSchedulerStorage.Resources.Mappings.Id = "UniqueID";
            this.appointmentSchedulerStorage.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);
            this.appointmentSchedulerStorage.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);
            this.appointmentSchedulerStorage.AppointmentsDeleted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);
            this.appointmentSchedulerStorage.FetchAppointments += new DevExpress.XtraScheduler.FetchAppointmentsEventHandler(this.appointmentSchedulerStorage_FetchAppointments);
            // 
            // patientAppointmentsBindingSource
            // 
            this.patientAppointmentsBindingSource.DataMember = "PatientAppointments";
            this.patientAppointmentsBindingSource.DataSource = this.db;
            // 
            // db
            // 
            this.db.DataSetName = "db";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPhysioBindingSource
            // 
            this.tblPhysioBindingSource.DataMember = "tblPhysio";
            this.tblPhysioBindingSource.DataSource = this.db;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.resourcesCheckedListBoxControl);
            this.groupControl1.Controls.Add(this.dateNavigator1);
            this.groupControl1.Location = new System.Drawing.Point(1, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 627);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Date Navigator";
            // 
            // resourcesCheckedListBoxControl
            // 
            this.resourcesCheckedListBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resourcesCheckedListBoxControl.Location = new System.Drawing.Point(2, 497);
            this.resourcesCheckedListBoxControl.Name = "resourcesCheckedListBoxControl";
            this.resourcesCheckedListBoxControl.SchedulerControl = this.appointmentSchedulerControl;
            this.resourcesCheckedListBoxControl.Size = new System.Drawing.Size(198, 130);
            this.resourcesCheckedListBoxControl.TabIndex = 8;
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dateNavigator1.BoldAppointmentDates = false;
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(2, 22);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.appointmentSchedulerControl;
            this.dateNavigator1.Size = new System.Drawing.Size(196, 469);
            this.dateNavigator1.TabIndex = 7;
            // 
            // patientAppointmentsTableAdapter
            // 
            this.patientAppointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tblPhysioTableAdapter
            // 
            this.tblPhysioTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 627);
            this.Controls.Add(this.appointmentSchedulerControl);
            this.Controls.Add(this.groupControl1);
            this.Name = "appointmentViewForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.appointmentViewForm_Load);
            this.Resize += new System.EventHandler(this.appointmentViewForm_Resize);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.appointmentSchedulerControl, 0);
            this.Controls.SetChildIndex(this.formSearchLookUpEdit, 0);
            this.Controls.SetChildIndex(this.searchTitleLabel, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.applyBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.formSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSchedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSchedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientAppointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhysioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Db.db db;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private System.Windows.Forms.BindingSource patientAppointmentsBindingSource;
        private Db.dbTableAdapters.PatientAppointmentsTableAdapter patientAppointmentsTableAdapter;
        public DevExpress.XtraScheduler.SchedulerControl appointmentSchedulerControl;
        public DevExpress.XtraScheduler.SchedulerStorage appointmentSchedulerStorage;
        private System.Windows.Forms.BindingSource tblPhysioBindingSource;
        private Db.dbTableAdapters.tblPhysioTableAdapter tblPhysioTableAdapter;
        private DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl resourcesCheckedListBoxControl;
    }
}
