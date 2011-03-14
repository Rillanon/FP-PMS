using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FP_PMS.Scheduling
{
    public partial class eventViewForm : DevExpress.XtraEditors.XtraForm
    {
        public eventViewForm()
        {
            InitializeComponent();
        }

        private void eventViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db.tblPhysio' table. You can move, or remove it, as needed.
            this.tblPhysioTableAdapter.FillBy(this.db.tblPhysio);
            // TODO: This line of code loads data into the 'db.EventAppointments' table. You can move, or remove it, as needed.
            this.eventAppointmentsTableAdapter.Fill(this.db.EventAppointments);

        }
    }
}