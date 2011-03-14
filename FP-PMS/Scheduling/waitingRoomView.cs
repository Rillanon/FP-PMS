using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using FP_PMS.Db;

namespace FP_PMS.Scheduling
{
    public partial class waitingRoomView : FP_PMS.Templates.level2TemplateForm
    {
        public waitingRoomView()
        {
            InitializeComponent();
        }

        void updateWaitingRoom()
        {
            Cursor.Current = Cursors.WaitCursor;
            var newConnection = new dbContextDataContext();
            waitingRoomGridControl.DataSource = from a in newConnection.PatientAppointments
                                                where (a.StartDate.Value.Date == System.DateTime.Today.Date)
                                                &&
                                                (a.EndDate.Value.Date == System.DateTime.Today.Date)
                                                &&
                                                (a.CheckIn == true)
                                                &&
                                                ((a.CheckOut != true) || (a.CheckOut == null))
                                                

                                                from r in newConnection.tblRates
                                                where r.RateID == a.RateID
                                                from p in newConnection.tblPatients
                                                where p.PatientID == a.PatientID
                                                select new AnonWaitingRoom
                                                {
                                                    ID = p.PatientID,
                                                    AppointmentID = a.UniqueID,
                                                    Name = p.FirstNames + @" " + p.LastName,
                                                    Physio = a.PhysioID,
                                                    Rate = r.RateDesc,
                                                    Start = a.StartDate.Value.ToShortTimeString(),
                                                    End = a.EndDate.Value.ToShortTimeString()
                                                };
            Cursor.Current = Cursors.Default;
        }

        private void waitingRoomView_Load(object sender, EventArgs e)
        {
            updateWaitingRoom();
        }

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
            var currentRow = (AnonWaitingRoom)waitingRoomGridView.GetFocusedRow();
            
            if (currentRow != null)
            {
                    var claimantChoose = new Accounting.Invoice.claimantSelectViewForm(currentRow.ID);
                    claimantChoose.ShowDialog();
                    if (claimantChoose.DialogResult == DialogResult.OK)
                    {
                        var newConnection = new dbContextDataContext();
                        var currentPhysio = newConnection.tblPhysios.Where(physio => physio.PhysioID == currentRow.Physio).FirstOrDefault();
                        var newInvoice = new Accounting.Invoice.newInvoiceForm(claimantChoose.myClaimant, currentPhysio);
                        newInvoice.ShowDialog();
                    }
            }
            else
            {
                MessageBox.Show("Please Select a Patient first!");
            }
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var currentRow = (AnonWaitingRoom)waitingRoomGridView.GetFocusedRow();
            var newConnection = new dbContextDataContext();
            var formOpen = false;

            if (currentRow != null)
            {
                var thisApp = newConnection.PatientAppointments.Where(a => a.UniqueID == currentRow.AppointmentID).FirstOrDefault();

                foreach (var f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(appointmentViewForm))
                    {
                        ((appointmentViewForm)f).RefreshAppointment(thisApp.UniqueID);
                        formOpen = true;
                    }
                }

                if (formOpen == false)
                {
                    thisApp.CheckOut = true;
                    thisApp.Label = 2;
                    newConnection.SubmitChanges();
                }
                updateWaitingRoom();
                
            }
            else
            {
                MessageBox.Show("Please Select a Patient first!");
            }
            Cursor.Current = Cursors.Default;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);

        }
    }
}
