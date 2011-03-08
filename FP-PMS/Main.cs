using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraGrid;
using FP_PMS.Db;
using FP_PMS.Auth;
using FP_PMS.Accounting.Invoice;
using FP_PMS.Scheduling;
using FP_PMS.Admin;
using FP_PMS.Ex;
using FP_PMS.Referral;
using FP_PMS.Patient;
using FP_PMS.Claimant;

namespace FP_PMS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mainLoad(object sender, EventArgs e)
        {
            using (var loginDialogue = new authForm())
            {
                if(loginDialogue.ShowDialog() == DialogResult.Cancel)
                    Application.Exit();
            }
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blankInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var _myInvoiceController = new invoiceController();
            _myInvoiceController.chooseClaimant();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void invoiceByClaimantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var claimantChoose = new Accounting.Invoice.claimantSelectViewForm();
            claimantChoose.ShowDialog();
            if (claimantChoose.DialogResult == DialogResult.OK)
            {
                var newDateInterval = new Report.dateIntervalDialog();
                newDateInterval.ShowDialog();

                if (newDateInterval.DialogResult == DialogResult.OK)
                {
                    var newLoadForm = new Helper.loadingViewForm();
                    newLoadForm.Show();
                    newLoadForm.Update();
                    var foo = new Claimant.claimantInvoiceViewForm(claimantChoose.myClaimant, newDateInterval.startDate, newDateInterval.endDate);
                    Thread.Sleep(3000);
                    newLoadForm.Close();
                    foo.ShowDialog();
                    foo.Dispose();
                }
                newDateInterval.Dispose();
            }
            claimantChoose.Dispose();
        }

        private void invoicsByPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tblPatient one = new tblPatient();
            one.PatientID = 10834;
            var foo = new Patient.patientInvoiceViewForm(one);
            foo.ShowDialog();
            foo.Dispose();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void appointmentBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formAlreadyOpened = false;
            foreach (Form a in Application.OpenForms)
            {
                if (a.GetType() == typeof(appointmentViewForm))
                {
                    a.Show();
                    a.Focus();
                    formAlreadyOpened = true;
                }
            }

            if (formAlreadyOpened == false)
            {
                var foo = new appointmentViewForm();
                foo.MdiParent = this;
                foo.WindowState = FormWindowState.Maximized;
                foo.Show();
            }
        }

        private void physiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form appForm = new Form();

            foreach (Form a in Application.OpenForms)
            {
                if (a.GetType() == typeof(appointmentViewForm))
                {
                     appForm = a;
                }
            }

            appForm.Close();

            var foo = new Admin.physioViewForm();
            foo.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Admin.itemViewForm();
            foo.ShowDialog();
        }

        private void postCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Admin.postCodeViewForm();
            foo.ShowDialog();
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Admin.physioRateViewForm();
            foo.ShowDialog();
        }

        private void referralDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Referral.referralViewForm();
            foo.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Admin.userViewForm();
            foo.ShowDialog();
        }

        private void journalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Report.journalReportViewForm();
            foo.ShowDialog();
        }

        private void receiptByPhysioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Report.receiptsByPhysioRateForm();
            foo.ShowDialog();
        }

        private void newPatientSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Report.newPatientStatsViewForm();
            foo.ShowDialog();
        }

        private void paymentAuditTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Report.paymentAuditTrail();
            foo.ShowDialog();
        }

        private void viewPatientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Patient.newPatientViewForm();
            foo.ShowDialog();
        }

        private void viewClaimantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foo = new Claimant.claimantViewForm();
            foo.ShowDialog();
        }

        private void waitingRoomLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formAlreadyOpened = false;
            foreach (Form a in Application.OpenForms)
            {
                if (a.GetType() == typeof(waitingRoomView))
                {
                    a.Show();
                    a.Focus();
                    formAlreadyOpened = true;
                }
            }

            if (formAlreadyOpened == false)
            {
                var foo = new waitingRoomView();
                foo.ShowDialog();
            }

           
        }

        public  void receiptOkBtnClick(object sender, EventArgs e)
        {
            var myForm = ((DevExpress.XtraEditors.SimpleButton)sender).FindForm();
            myForm.DialogResult = DialogResult.OK;
            
        }

        private void multipleReceiptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var claimantChoose = new Accounting.Invoice.claimantSelectViewForm();
            claimantChoose.ShowDialog();
            if (claimantChoose.DialogResult == DialogResult.OK)
            {
                var newDateInterval = new Report.dateIntervalDialog();
                newDateInterval.ShowDialog();

                if (newDateInterval.DialogResult == DialogResult.OK)
                {
                    var newReceiptForm = new Accounting.Receipt.receiptViewForm(claimantChoose.myClaimant);
                    newReceiptForm.removeBtnEvent();
                    newReceiptForm.okBtn.Click += new EventHandler(receiptOkBtnClick);
                    newReceiptForm.IsMulti = true;
                    newReceiptForm.ShowDialog();
                    
                    if (newReceiptForm.DialogResult == DialogResult.OK)
                    {
                        var foo = new Accounting.Receipt.multiReceiptViewForm(claimantChoose.myClaimant, newDateInterval.startDate, newDateInterval.endDate, 
                            newReceiptForm.myReceipt, newReceiptForm.myPaymentLines);
                        
                        foo.ShowDialog();
                        foo.Dispose();
                        newReceiptForm.Dispose();
                    }
                    else
                    { newReceiptForm.Dispose(); }
                }
                newDateInterval.Dispose();
            }
            claimantChoose.Dispose();
        }

        private void applyCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var claimantChoose = new Accounting.Invoice.claimantSelectViewForm();
            claimantChoose.ShowDialog();
            if (claimantChoose.DialogResult == DialogResult.OK)
            {
                var newCreditApplyForm = new Accounting.Credit.addCreditViewForm(claimantChoose.myClaimant);
                newCreditApplyForm.ShowDialog();
                newCreditApplyForm.Dispose();
            }
            claimantChoose.Dispose();
        }

        private void cancelCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var claimantChoose = new Accounting.Invoice.claimantSelectViewForm();
            claimantChoose.ShowDialog();
            if (claimantChoose.DialogResult == DialogResult.OK)
            {
                var newDateInterval = new Report.dateIntervalDialog();
                newDateInterval.ShowDialog();

                if (newDateInterval.DialogResult == DialogResult.OK)
                {
                    var foo = new Accounting.Credit.cancelCreditViewForm(claimantChoose.myClaimant, newDateInterval.startDate, newDateInterval.endDate);

                    foo.ShowDialog();
                    foo.Dispose();
                }
                newDateInterval.Dispose();
            }
            claimantChoose.Dispose();
        }

        private void cancelInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var claimantChoose = new Accounting.Invoice.claimantSelectViewForm();
            claimantChoose.ShowDialog();
            if (claimantChoose.DialogResult == DialogResult.OK)
            {
                var newDateInterval = new Report.dateIntervalDialog();
                newDateInterval.ShowDialog();

                if (newDateInterval.DialogResult == DialogResult.OK)
                {
                    var foo = new Accounting.Invoice.cancellInvoiceViewForm(claimantChoose.myClaimant, newDateInterval.startDate, newDateInterval.endDate);

                    foo.ShowDialog();
                    foo.Dispose();
                }
                newDateInterval.Dispose();
            }
            claimantChoose.Dispose();
        }

        private void appointmentsByPhysioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var physioChoose = new Scheduling.physioSelectDialog();
            physioChoose.ShowDialog();
            if (physioChoose.DialogResult == DialogResult.OK)
            {
                var newDateInterval = new Report.dateIntervalDialog();
                newDateInterval.ShowDialog();

                if (newDateInterval.DialogResult == DialogResult.OK)
                {
                    var foo = new Scheduling.appointmentsByPhysioViewForm(newDateInterval.startDate, newDateInterval.endDate, physioChoose.myPhysio);
                    foo.MdiParent = this;
                    foo.Show();
                    //foo.Dispose();
                }
                newDateInterval.Dispose();
            }
            physioChoose.Dispose();

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form currentForm = this.ActiveMdiChild;
            if (currentForm is Interfaces.IPrinting)
            {
                var printable = currentForm as Interfaces.IPrinting;
                printable.printPreview();
            }
        }

        private void directToPrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form currentForm = this.ActiveMdiChild;
            if (currentForm is Interfaces.IPrinting)
            {
                var printable = currentForm as Interfaces.IPrinting;
                printable.print();
            }
        }

        private void agedBalanceTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var claimantChoose = new Accounting.Invoice.claimantSelectViewForm();
            claimantChoose.ShowDialog();
            if (claimantChoose.DialogResult == DialogResult.OK)
            {
                var physioChoose = new Scheduling.physioSelectDialog();
                physioChoose.ShowDialog();
                if (physioChoose.DialogResult == DialogResult.OK)
                {
                    var newDateInterval = new Report.dateIntervalDialog();
                    newDateInterval.ShowDialog();

                    if (newDateInterval.DialogResult == DialogResult.OK)
                    {
                        var foo = new Report.agedTrailBalanceViewForm(claimantChoose.myClaimant, physioChoose.myPhysio, newDateInterval.startDate, newDateInterval.endDate);
                        foo.MdiParent = this;
                        foo.Show();
                        //foo.Dispose();
                    }
                    newDateInterval.Dispose();
                }
                physioChoose.Dispose();
            }
            claimantChoose.Dispose();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var foo = new newInvoiceForm();
            foo.Show();
        }
    }
}
