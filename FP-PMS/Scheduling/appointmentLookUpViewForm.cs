using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Data.Linq;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using FP_PMS.Db;
using FP_PMS.Ex;


namespace FP_PMS.Scheduling
{
    public partial class appointmentLookUpViewForm : DevExpress.XtraEditors.XtraForm
    {
        void updateAppointments(int ID)
        {
            
            Cursor.Current = Cursors.WaitCursor;
            var newConnection = new dbContextDataContext();

            if (futureDateCheckEdit.Checked == false)
            {
                this.appointmentsGridControl.DataSource = from a in newConnection.PatientAppointments
                                                          where (a.PatientID == ID)
                                                          from r in newConnection.tblRates
                                                          where r.RateID == a.RateID
                                                          from p in newConnection.tblPatients
                                                          where p.PatientID == a.PatientID
                                                          select new AnonAppointments
                                                          {
                                                              ID = p.PatientID,
                                                              AppointmentID = a.UniqueID,
                                                              Name = p.FirstNames + @" " + p.LastName,
                                                              DOB = p.BirthDate,
                                                              Physio = a.PhysioID,
                                                              Rate = r.RateDesc,
                                                              Date = a.StartDate.Value.Date,
                                                              Start = a.StartDate.Value.ToShortTimeString(),
                                                              End = a.EndDate.Value.ToShortTimeString()
                                                          };
            }
            else
            {
                this.appointmentsGridControl.DataSource = from a in newConnection.PatientAppointments
                                                          where (a.PatientID == ID) && (a.StartDate > System.DateTime.Today)
                                                          from r in newConnection.tblRates
                                                          where r.RateID == a.RateID
                                                          from p in newConnection.tblPatients
                                                          where p.PatientID == a.PatientID
                                                          select new AnonAppointments
                                                          {
                                                              ID = p.PatientID,
                                                              AppointmentID = a.UniqueID,
                                                              Name = p.FirstNames + @" " + p.LastName,
                                                              DOB = p.BirthDate,
                                                              Physio = a.PhysioID,
                                                              Rate = r.RateDesc,
                                                              Date = a.StartDate.Value.Date,
                                                              Start = a.StartDate.Value.ToShortTimeString(),
                                                              End = a.EndDate.Value.ToShortTimeString()
                                                          };
            }

            Cursor.Current = Cursors.Default;
        }

        public appointmentLookUpViewForm()
        {
            InitializeComponent();
            patientLinqInstantFeedbackSource.DesignTimeElementType = typeof(tblPatient);
           
            patientLinqInstantFeedbackSource.DismissQueryable += new EventHandler<GetQueryableEventArgs>(patientLinqInstantFeedbackSource_DismissQueryable);
            patientLinqInstantFeedbackSource.GetQueryable +=new EventHandler<GetQueryableEventArgs>(patientLinqInstantFeedbackSource_GetQueryable);
        }

        private void patientLinqInstantFeedbackSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            ((dbContextDataContext)e.Tag).Dispose();
        }

        private void patientLinqInstantFeedbackSource_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var newConnection = new dbContextDataContext();
            e.QueryableSource = newConnection.tblPatients;
            e.Tag = newConnection;
        }

        private void appointmentLookUpViewForm_Load(object sender, EventArgs e)
        {
            patientLookUpGrid.DataSource = patientLinqInstantFeedbackSource;
        }

        private void patientLookUpView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            if (patientLookUpView.GetFocusedRow() != null)
            {
                var currentRow = (tblPatient)patientLookUpView.GetFocusedRow();
                updateAppointments(currentRow.PatientID);
            }
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}