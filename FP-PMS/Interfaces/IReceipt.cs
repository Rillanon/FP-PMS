using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FP_PMS.Db;

namespace FP_PMS.Interfaces
{
    interface IReceipt
    {
        tblReceipt myReceipt { get; set; }
        BindingList<tblPayin> myPayments { get; set; }
        BindingList<tblPayinType> myPaymentTypes { get; set; }
        BindingList<tblInvoice> myInvoices { get; set; }

        string receiptType { get; set; } //is it a receipt for a single invoice or multiple invoices?

        void newPayment();
        void savePayments();
        void clearPayments();
        void removePayment();
        
        void attachInvoice();

         bool validatePayment();

         bool validateReceipt();

         void updateView();
        
        void newReceipt();  
        void viewReceipt(int ReceiptID);
        void saveReceipt();

        void applyReceiptChanges();
    }
}
