using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Services;
using DevExpress.XtraScheduler.Commands;
using DevExpress.Utils.Menu;

using FP_PMS.Db;
using FP_PMS.Ex;


namespace FP_PMS.Scheduling
{
    public partial class appointmentViewForm : FP_PMS.Templates.level1TemplateForm, Interfaces.IPrinting
    {
        TimeInterval lastFetchedInterval = new TimeInterval();
        TimeInterval mySelectedInterval = new TimeInterval();

        DateTime Start;
        DateTime End;

        public void print()
        {
            this.appointmentSchedulerControl.Print();
        }

        public void printPreview()
        {
            this.appointmentSchedulerControl.ShowPrintOptionsForm();
        }

        delegate void DoRefreshData();
        IAsyncResult asyncResult;

        public appointmentViewForm()
        {
            InitializeComponent();
            this.appointmentSchedulerControl.Start = System.DateTime.Today;

            ApplyCustomMapping();
        }

        public void RefreshAppointment(int AppID)
        {
            Cursor.Current = Cursors.WaitCursor;
            //AppointmentBaseCollection a = appointmentSchedulerStorage.GetAppointments(System.DateTime.Today, System.DateTime.Today.AddDays(1));
            
            //foreach (Appointment x in a)
            //{
            //    var myInt = x.CustomFields["UniqueID"];
            //    int? y = myInt as int?;
                
            //    if (y.IsNullOrDefault() == false)
            //    {
            //        if (y.Value == AppID)
            //        {
            //            x.LabelId = 2;
            //            x.CustomFields["CheckOut"] = true;
            //        }
            //    }
            //}

            //this.appointmentSchedulerStorage.RefreshData();
            //this.appointmentSchedulerControl.RefreshData();
            ReloadCollections();

            Cursor.Current = Cursors.Default;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.F)
            {
                this.findAppointment();
            }
        }

        void findAppointment()
        {
            var newFindForm = new findForm();
            newFindForm.ShowDialog();
            if (newFindForm.DialogResult == DialogResult.OK)
            {
                Appointment myApp = (from a in appointmentSchedulerStorage.Appointments.Items
                                     where a.Subject.ToUpper().Contains(newFindForm.mySearchTerm)
                                     || a.Subject.ToLower().Contains(newFindForm.mySearchTerm)
                                     select a).FirstOrDefault();
                if (myApp != null)
                {
                    appointmentSchedulerControl.ActiveView.SelectAppointment(myApp);
                    this.appointmentSchedulerControl.Refresh();
                    
                }
                else
                {
                    MessageBox.Show("Not found.");
                }
                
            }
            newFindForm.Dispose();
        }

        void ApplyCustomMapping()
        {
            //AppointmentCustomFieldMapping customPatientIDMapping = new AppointmentCustomFieldMapping("PatientID", "PatientID");
            //AppointmentCustomFieldMapping customRateIDMapping = new AppointmentCustomFieldMapping("RateID", "RateID");
            //AppointmentCustomFieldMapping customPhysioIDMapping = new AppointmentCustomFieldMapping("PhysioID", "PhysioID");
            //AppointmentCustomFieldMapping customUniqueID = new AppointmentCustomFieldMapping("UniqueID", "UniqueID");

            ////AppointmentCustomFieldMapping customInvoicedMapping = new AppointmentCustomFieldMapping("Invoiced", "Invoiced");

            //appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(customPatientIDMapping);
            //appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(customRateIDMapping);
            //appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(customPhysioIDMapping);
            //appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(customUniqueID);

            ////appointmentSchedulerStorage.Appointments.CustomFieldMappings.Add(customInvoicedMapping);

            //ResourceCustomFieldMapping customResPhysioIDLunchTimeStartMapping = new ResourceCustomFieldMapping("LunchStartTime", "LunchStartTime");
            //ResourceCustomFieldMapping customResPhysioIDLunchTimeEndMapping = new ResourceCustomFieldMapping("LunchEndTime", "LunchEndTime");

            //appointmentSchedulerStorage.Resources.CustomFieldMappings.Add(customResPhysioIDLunchTimeStartMapping);
            //appointmentSchedulerStorage.Resources.CustomFieldMappings.Add(customResPhysioIDLunchTimeEndMapping);
        }

        private void FixPositionInResize(Control CtrlToResize)
        {
            CtrlToResize.Width = this.Width - this.groupControl1.Width;
        }

        private void ReloadCollections()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                
                patientAppointmentsTableAdapter.ClearBeforeFill = true;
                patientAppointmentsTableAdapter.FillBy(db.PatientAppointments, Start, End);
                

                asyncResult = this.BeginInvoke((DoRefreshData)RefreshAsync);
                
            }
            catch (System.Data.SqlClient.SqlException)
            {
                //A transport error occured. Most likely a time out or connection reset error. 
                // Doing a ugly retry till connection succeeds.
                ReloadCollections();
            }
            Cursor.Current = Cursors.Default;
        }

        private void appointmentSchedulerControl_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            if ((e.Appointment.AllDay != true) && (appointmentSchedulerControl.SelectedResource.Id.ToString() != "DevExpress.XtraScheduler.Resource"))
            {
                var popUpForm = new appointmentPopUp(this.appointmentSchedulerControl, this.appointmentSchedulerStorage, e.Appointment);
                e.DialogResult = popUpForm.ShowDialog();
                
                appointmentSchedulerControl.Refresh();
                e.Handled = true;
            }
            else
            {
                var allDayForm = new DevExpress.XtraScheduler.UI.AppointmentForm(appointmentSchedulerControl, e.Appointment);
            }
        }

        private void appointmentViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db1.tblPhysio' table. You can move, or remove it, as needed.

            this.tblPhysioTableAdapter.FillBy(this.db.tblPhysio);

            //appointmentSchedulerStorage.Appointments.AutoReload = true;
            
            appointmentSchedulerControl.ActiveView.NavigationButtonVisibility = NavigationButtonVisibility.Never;

            
        }

        private void appointmentViewForm_Resize(object sender, EventArgs e)
        {
            //FixPositionInResize(this.appointmentSchedulerControl);
        }

        private void appointmentSchedulerStorage_FetchAppointments(object sender, FetchAppointmentsEventArgs e) 
        {
            Cursor.Current = Cursors.WaitCursor;
            Start = e.Interval.Start;
            End = e.Interval.End;

            if (Start <= lastFetchedInterval.Start || End >= lastFetchedInterval.End)
            {
                lastFetchedInterval = new TimeInterval(Start - TimeSpan.FromDays(1), End +
                    TimeSpan.FromDays(1));
                patientAppointmentsTableAdapter.FillBy(db.PatientAppointments, Start, End);
            }
            Cursor.Current = Cursors.Default;
        }



        void RefreshAsync()
        {
            this.EndInvoke(asyncResult);
           
            this.appointmentSchedulerControl.RefreshData();
            
        }

        private void OnApptChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            try
            {
                patientAppointmentsTableAdapter.Update(db.PatientAppointments);
                db.AcceptChanges();
                ReloadCollections();
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Appointments have changed. Data will be reloaded. Please Try again.");
                ReloadCollections();
            }
        }

        private void appointmentSchedulerControl_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void appointmentSchedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.Menu.Id == DevExpress.XtraScheduler.SchedulerMenuItemId.DefaultMenu)
            {
                //e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent);

                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringEvent);

                //e.Menu.Items.Add(new SchedulerMenuItem("New Event", MyEventClickHandler));

                SchedulerMenuItem item = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment);
                if (item != null) item.Caption = "&New patient appointment";
               
            }

            if (e.Menu.Id == DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu)
            {
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.LabelSubMenu);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu);

                
                e.Menu.Items.Add(new SchedulerMenuItem("Check In!", MyClickHandler));
                
            }
        }

        public void MyEventClickHandler(object sender, EventArgs e)
        {

            //var eventForm = new DevExpress.XtraScheduler.UI.AppointmentForm(appointmentSchedulerControl, );
            //eventForm.ShowDialog();
            //appointmentSchedulerControl.Refresh();
        }

        public void MyClickHandler(object sender, EventArgs e)
        {
            foreach (Appointment a in this.appointmentSchedulerControl.SelectedAppointments)
            {
                if (a.AllDay != true)
                {
                    if (entityClone.IsNullOrDefault(a.CustomFields["PatientID"]))
                    {
                        MessageBox.Show("You must select a patient before CHECK IN!");
                        var popUpForm = new appointmentPopUp(this.appointmentSchedulerControl, this.appointmentSchedulerStorage, a);
                        popUpForm.ShowDialog();
                        appointmentSchedulerControl.Refresh();
                    }
                    else
                    {
                        if (a.LabelId != 2)
                        {
                            a.CustomFields["CheckIn"] = true;
                            a.LabelId = 3;
                        }
                    }
                }
            }
        }

        private void appointmentSchedulerControl_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush msb = new SolidBrush(Color.FromArgb(90, 50, 50, 50));

            Rectangle rect = Rectangle.Empty;
            if (appointmentSchedulerControl.ActiveView is DayView)
            {
                foreach (DayViewColumn column in ((DayViewInfo)appointmentSchedulerControl.ActiveView.ViewInfo).Columns)
                {
                    for (int i = 0; i < column.Cells.Count; i++)
                    {
                        TimeCell tc = column.Cells[i] as TimeCell;
                        TimeSpan? Start = new TimeSpan();
                        TimeSpan? End = new TimeSpan();

                        var StartObject = tc.Resource.CustomFields["LunchStartTime"];
                        Start = StartObject as TimeSpan?;
                        var EndObject = tc.Resource.CustomFields["LunchEndTime"];
                        End = EndObject as TimeSpan?;

                        if (!Start.HasValue)
                        {
                            Start = new TimeSpan(13, 0, 0);
                        }

                        if (!End.HasValue)
                        {
                            End = new TimeSpan(14, 0, 0);
                        }

                        if ((tc.Interval.Start.TimeOfDay.TotalMinutes) >= Start.Value.TotalMinutes
                            && (tc.Interval.Start.TimeOfDay.TotalMinutes < End.Value.TotalMinutes))
                        {
                            if (rect == Rectangle.Empty)
                                rect = tc.Bounds;
                            else
                                rect = Rectangle.Union(rect, tc.Bounds);
                        }
                    }

                    if (rect != Rectangle.Empty)
                        using (Font f = new Font("Arial", rect.Height / 3, GraphicsUnit.Pixel))
                            e.Graphics.DrawString("Lunch Time", f, msb, new PointF(rect.X + rect.Width / 2 - f.Size * 3, rect.Y + rect.Height / 2 - f.Size / 2));
                    rect = Rectangle.Empty;

                }
            }
        }

        private void appointmentSchedulerControl_CustomDrawTimeCell(object sender, DevExpress.XtraScheduler.CustomDrawObjectEventArgs e)
        {
            if (e.ObjectInfo is TimeCell)
            {
                TimeCell tc = e.ObjectInfo as TimeCell;
                TimeSpan? Start = new TimeSpan();
                TimeSpan? End = new TimeSpan();

                var StartObject = tc.Resource.CustomFields["LunchStartTime"];
                Start = StartObject as TimeSpan?;
                var EndObject = tc.Resource.CustomFields["LunchEndTime"];
                End = EndObject as TimeSpan?;

                if (!Start.HasValue)
                {
                   Start = new TimeSpan(13, 0, 0);
                }

                if(!End.HasValue)
                {
                    End = new TimeSpan(14, 0, 0);
                }

                if ((tc.Interval.Start.TimeOfDay.TotalMinutes) >= Start.Value.TotalMinutes
                    && (tc.Interval.Start.TimeOfDay.TotalMinutes < End.Value.TotalMinutes))
                {
                    tc.Appearance.BackColor = Color.LightBlue;
                }
                
            }
        }

        private void appointmentSchedulerControl_AllowAppointmentConflicts(object sender, AppointmentConflictEventArgs e)
        {
            var Result = MessageBox.Show("This time has being marked as unavailable, are you sure you want to proceed?", "Time", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                Resource r = appointmentSchedulerStorage.Resources.Items.GetResourceById(e.AppointmentClone.ResourceId);
                double startLunchHour = ((TimeSpan)(r.CustomFields["LunchStart"])).TotalMinutes;
                double endLunchHour = ((TimeSpan)(r.CustomFields["LunchEnd"])).TotalMinutes;
                TimeInterval lunchTimeInterval = new TimeInterval(e.Appointment.Start.Date.AddMinutes(startLunchHour), TimeSpan.FromMinutes(endLunchHour - startLunchHour));
                TimeInterval aptTimeInterval = new TimeInterval(e.AppointmentClone.Start, e.AppointmentClone.End);

                if (lunchTimeInterval.IntersectsWith(aptTimeInterval))
                {
                    e.Conflicts.Add(e.AppointmentClone);
                }
            }
            else
            {
                
            }

        }

        private void appointmentReloadTimer_Tick(object sender, EventArgs e)
        {
            ReloadCollections();    
        }

        private void appointmentSchedulerControl_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
        {
            foreach (var apt in appointmentSchedulerControl.SelectedAppointments)
            {
                if (apt.Equals(e.ViewInfo.Appointment))
                {
                    e.ViewInfo.Appearance.BackColor = Color.Yellow;
                }
            }
        }

        private void appointmentSchedulerControl_SelectionChanged(object sender, EventArgs e)
        {
            this.appointmentSchedulerControl.Refresh();
        }

    }
}
