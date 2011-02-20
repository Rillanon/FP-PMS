using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Linq;
using FP_PMS.Db;
using FP_PMS.Ex;

namespace FP_PMS.Scheduling
{
    public partial class appointmentsByPhysioViewForm : FP_PMS.Templates.level2TemplateForm
    {
        DateTime _startDate;
        DateTime _endDate;
        tblPhysio _myPhysio;
        BindingList<PatientAppointment> _myAppointments = new BindingList<PatientAppointment> { };

        tblPhysio myPhysio { get { return _myPhysio; } set { _myPhysio = value; } }
        BindingList<PatientAppointment> myAppointments { get { return _myAppointments; } set { _myAppointments = value; } }
        DateTime startDate { get { return _startDate; } set { _startDate = value; } }
        DateTime endDate { get { return _endDate; } set { _endDate = value; } }

        void pullData()
        {
            var newConnection = new dbContextDataContext();
            var apps = (from a in newConnection.getPhysioAppointments(myPhysio.PhysioID, startDate, endDate)
                        select new PatientAppointment
                        {
                            UniqueID = a.UniqueID,
                            Status = a.Status,
                            RateID = a.RateID
                        }).OrderBy(b => b.StartDate).ToList();
            foreach (var a in apps)
            {
                myAppointments.Add(a);
            }
            appointmentsByPhysioGridControl.DataSource = myAppointments;
        }



        public appointmentsByPhysioViewForm(DateTime Start, DateTime End, tblPhysio MyPhysio)
        {
            InitializeComponent();
            startDate = Start;
            endDate = End;
            myPhysio = MyPhysio;
            myAppointments.ListChanged += new ListChangedEventHandler(myAppointments_ListChanged);
        }

        private void myAppointments_ListChanged(object sender, ListChangedEventArgs e)
        {
            appointmentsCountSpinEdit.Value = myAppointments.Count();
            checkInCountSpinEdit.Value = myAppointments.Count(a => a.CheckIn == true);
            checkOutCountSpinEdit.Value = myAppointments.Count(a => a.CheckOut == true);
        }

        private void appointmentsByPhysioViewForm_Load(object sender, EventArgs e)
        {
            pullData();
        }
    }
}
