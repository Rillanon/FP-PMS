namespace FP_PMS.Scheduling
{
    partial class eventViewForm
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
            this.eventSchedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.eventSchedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.eventAppointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db = new FP_PMS.Db.db();
            this.tblPhysioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.eventDateNavigator = new DevExpress.XtraScheduler.DateNavigator();
            this.resourcesCheckedListBoxControl1 = new DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl();
            this.eventAppointmentsTableAdapter = new FP_PMS.Db.dbTableAdapters.EventAppointmentsTableAdapter();
            this.tblPhysioTableAdapter = new FP_PMS.Db.dbTableAdapters.tblPhysioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eventSchedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventSchedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventAppointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhysioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGroupControl)).BeginInit();
            this.dateGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDateNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesCheckedListBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventSchedulerControl
            // 
            this.eventSchedulerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.eventSchedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.eventSchedulerControl.Location = new System.Drawing.Point(199, -2);
            this.eventSchedulerControl.Name = "eventSchedulerControl";
            this.eventSchedulerControl.Size = new System.Drawing.Size(905, 611);
            this.eventSchedulerControl.Start = new System.DateTime(2011, 3, 15, 0, 0, 0, 0);
            this.eventSchedulerControl.Storage = this.eventSchedulerStorage;
            this.eventSchedulerControl.TabIndex = 0;
            this.eventSchedulerControl.Text = "schedulerControl1";
            this.eventSchedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.eventSchedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // eventSchedulerStorage
            // 
            this.eventSchedulerStorage.Appointments.DataSource = this.eventAppointmentsBindingSource;
            this.eventSchedulerStorage.Appointments.Mappings.AllDay = "AllDay";
            this.eventSchedulerStorage.Appointments.Mappings.Description = "Description";
            this.eventSchedulerStorage.Appointments.Mappings.End = "EndDate";
            this.eventSchedulerStorage.Appointments.Mappings.Label = "Label";
            this.eventSchedulerStorage.Appointments.Mappings.Location = "Location";
            this.eventSchedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.eventSchedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.eventSchedulerStorage.Appointments.Mappings.ResourceId = "ResourceID";
            this.eventSchedulerStorage.Appointments.Mappings.Start = "StartDate";
            this.eventSchedulerStorage.Appointments.Mappings.Status = "Status";
            this.eventSchedulerStorage.Appointments.Mappings.Subject = "Subject";
            this.eventSchedulerStorage.Appointments.Mappings.Type = "Type";
            this.eventSchedulerStorage.Resources.DataSource = this.tblPhysioBindingSource;
            this.eventSchedulerStorage.Resources.Mappings.Caption = "PhysioName";
            this.eventSchedulerStorage.Resources.Mappings.Color = "Color";
            this.eventSchedulerStorage.Resources.Mappings.Id = "UniqueID";
            // 
            // eventAppointmentsBindingSource
            // 
            this.eventAppointmentsBindingSource.DataMember = "EventAppointments";
            this.eventAppointmentsBindingSource.DataSource = this.db;
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
            // dateGroupControl
            // 
            this.dateGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dateGroupControl.Controls.Add(this.eventDateNavigator);
            this.dateGroupControl.Location = new System.Drawing.Point(-5, -2);
            this.dateGroupControl.Name = "dateGroupControl";
            this.dateGroupControl.Size = new System.Drawing.Size(200, 409);
            this.dateGroupControl.TabIndex = 1;
            this.dateGroupControl.Text = "Date Navigator";
            // 
            // eventDateNavigator
            // 
            this.eventDateNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventDateNavigator.HotDate = null;
            this.eventDateNavigator.Location = new System.Drawing.Point(2, 22);
            this.eventDateNavigator.Name = "eventDateNavigator";
            this.eventDateNavigator.SchedulerControl = this.eventSchedulerControl;
            this.eventDateNavigator.Size = new System.Drawing.Size(196, 385);
            this.eventDateNavigator.TabIndex = 0;
            // 
            // resourcesCheckedListBoxControl1
            // 
            this.resourcesCheckedListBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resourcesCheckedListBoxControl1.Location = new System.Drawing.Point(0, 411);
            this.resourcesCheckedListBoxControl1.Name = "resourcesCheckedListBoxControl1";
            this.resourcesCheckedListBoxControl1.SchedulerControl = this.eventSchedulerControl;
            this.resourcesCheckedListBoxControl1.Size = new System.Drawing.Size(195, 198);
            this.resourcesCheckedListBoxControl1.TabIndex = 2;
            // 
            // eventAppointmentsTableAdapter
            // 
            this.eventAppointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tblPhysioTableAdapter
            // 
            this.tblPhysioTableAdapter.ClearBeforeFill = true;
            // 
            // eventViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 609);
            this.Controls.Add(this.resourcesCheckedListBoxControl1);
            this.Controls.Add(this.dateGroupControl);
            this.Controls.Add(this.eventSchedulerControl);
            this.Name = "eventViewForm";
            this.Text = "Events";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.eventViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventSchedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventSchedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventAppointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhysioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGroupControl)).EndInit();
            this.dateGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventDateNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesCheckedListBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl eventSchedulerControl;
        private DevExpress.XtraScheduler.SchedulerStorage eventSchedulerStorage;
        private DevExpress.XtraEditors.GroupControl dateGroupControl;
        private DevExpress.XtraScheduler.DateNavigator eventDateNavigator;
        private DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl resourcesCheckedListBoxControl1;
        private Db.db db;
        private System.Windows.Forms.BindingSource eventAppointmentsBindingSource;
        private Db.dbTableAdapters.EventAppointmentsTableAdapter eventAppointmentsTableAdapter;
        private System.Windows.Forms.BindingSource tblPhysioBindingSource;
        private Db.dbTableAdapters.tblPhysioTableAdapter tblPhysioTableAdapter;
    }
}