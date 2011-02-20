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
        public invoicePrintReport(tblInvoice myInvoice, tblClaimant myClaimant, BindingList<tblPatientStat> myInvoiceLines)
        {
            InitializeComponent();
            invoiceDateLabel.Text = "Invoice Date : " + System.DateTime.Today.ToShortDateString();
            InvoiceNoLabel.Text = "Invoice # : " + myInvoice.InvoiceNo.ToString();
            claimantNameLabel.Text = myClaimant.FirstNames + " " + myClaimant.LastName;
            streetLabel.Text = myClaimant.Address1;
            suburbLabel.Text = myClaimant.Address2;
            stateLabel.Text = myClaimant.Address3;
            postCodeLabel.Text = myClaimant.Postcode;
            
            var Lines = from p in new dbContextDataContext().tblPatientStats
                              where p.InvoiceNo == myInvoice.InvoiceNo
                              select p;
            this.DataSource = Lines;

            decimal feeTotal = (decimal)Lines.Sum(od => od.Fee);
            decimal gstTotal = (decimal)Lines.Sum(od => od.GST);
            feeTotalLabel.Text = feeTotalLabel.Text + feeTotal;
            gstTotalLabel.Text = gstTotalLabel.Text + gstTotal;
            totalLabel.Text = totalLabel.Text + decimal.Add(feeTotal, gstTotal);
        }

    }
}
