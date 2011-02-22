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
    public partial class appointmentsByPhysioViewForm : FP_PMS.Templates.level2TemplateForm, Interfaces.IPrinting
    {
        DateTime _startDate;
        DateTime _endDate;
        tblPhysio _myPhysio;
        BindingList<AnonPhysioAppointments> _myAppointments = new BindingList<AnonPhysioAppointments> { };

        tblPhysio myPhysio { get { return _myPhysio; } set { _myPhysio = value; } }
        BindingList<AnonPhysioAppointments> myAppointments { get { return _myAppointments; } set { _myAppointments = value; } }
        DateTime startDate { get { return _startDate; } set { _startDate = value; } }
        DateTime endDate { get { return _endDate; } set { _endDate = value; } }

        public void print()
        {
            this.appointmentsByPhysioGridControl.ShowPrintPreview();
        }

        void pullData()
        {
            var newConnection = new dbContextDataContext();
            var apps = (from a in newConnection.getPhysioAppointments(myPhysio.PhysioID, startDate, endDate)
                        select new AnonPhysioAppointments
                        {
                            Name = a.Name,
                            startDate = a.startDate.GetValueOrDefault(DateTime.MinValue),
                            endDate = a.endDate.GetValueOrDefault(DateTime.MinValue),
                            Rate = a.Rate,
                            Physio = a.PhysioID
                        }).ToList();
                        
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
        }

        private void appointmentsByPhysioViewForm_Load(object sender, EventArgs e)
        {
            pullData();
        }
    }
}
