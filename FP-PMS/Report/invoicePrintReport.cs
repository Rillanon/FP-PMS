using System;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using FP_PMS.Db;

namespace FP_PMS.Report
{
    public partial class invoicePrintReport : DevExpress.XtraReports.UI.XtraReport
    {
        public invoicePrintReport(tblInvoice myInvoice, tblClaimant myClaimant, tblTransaction myTransaction)
        {
            InitializeComponent();
            

            Cursor.Current = Cursors.WaitCursor;
            invoiceDateLabel.Text = "Issued on: " + String.Format("{0:MM/dd/yyyy}", myTransaction.TranDate);  
            InvoiceNoLabel.Text = "Invoice # : " + myInvoice.InvoiceNo.ToString();
            claimantNameLabel.Text = myClaimant.FirstNames + " " + myClaimant.LastName;
            streetLabel.Text = myClaimant.Address1;
            suburbLabel.Text = myClaimant.Address2;
            stateLabel.Text = myClaimant.Address3;
            postCodeLabel.Text = myClaimant.Postcode;
            if (myClaimant.Terms.GetValueOrDefault() > 0)
            {
                claimantTermsLabel.Text = myClaimant.Terms.ToString() + " " + "days";
            }
            else
            {
                claimantTermsLabel.Text = "ASAP";
            }


            var Lines = new dbContextDataContext().getInvoiceLines(myInvoice.InvoiceNo).ToList();
            tblPhysio myPhysio = new dbContextDataContext().tblPhysios.Where(p => p.PhysioID == myTransaction.PhysioID).SingleOrDefault();
            physioProviderNoLabel.Text = myPhysio.ProviderNo;
            physioNameLabel.Text = myPhysio.PhysioName;

            var receipts = new dbContextDataContext().getReceiptsOfSingleInvoice(myInvoice.InvoiceNo).ToList();
            this.DataSource = Lines;
            sessionDateTableCell.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", this.DataSource, "Date", "{0:MM/dd/yyyy}"));
            dobTableCell.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", this.DataSource, "DOB", "{0:MM/dd/yyyy}"));
            feeTableCell.DataBindings.Add("Text", this.DataSource, "Fee", "{0:c2}");
            gstTableCell.DataBindings.Add("Text", this.DataSource, "GST", "{0:c2}");
            totalTableCell.DataBindings.Add("Text", this.DataSource, "Total", "{0:c2}");


            decimal invoiceTotal = decimal.Add( (decimal)Lines.Sum(od => od.Fee), (decimal)Lines.Sum(od => od.GST));
            decimal alreadyPaid = (decimal)receipts.Sum(r => r.InvRecAmnt);
            decimal remaining = decimal.Subtract(invoiceTotal, alreadyPaid);

            invoiceTotalLabel.Text = string.Format("{0:c2}", invoiceTotal);
            paidTotalLabel.Text = string.Format("{0:c2}", alreadyPaid);
            amountToBePaidLabel.Text = string.Format("{0:c2}", remaining);


            decimal feeTotal = (decimal)Lines.Sum(od => od.Fee);
            decimal gstTotal = (decimal)Lines.Sum(od => od.GST);
            //feeTotalLabel.Text = feeTotalLabel.Text + feeTotal;
            //gstTotalLabel.Text = gstTotalLabel.Text + gstTotal;
            //totalLabel.Text = totalLabel.Text + decimal.Add(feeTotal, gstTotal);
            Cursor.Current = Cursors.Default;
        }

    }
}
