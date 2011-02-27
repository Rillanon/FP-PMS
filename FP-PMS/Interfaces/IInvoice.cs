using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using FP_PMS.Db;

namespace FP_PMS.Interfaces
{
    interface IInvoice: IPrinting
    {
        Object myInvoice { get; set; }
        Object myClaimant { get; set; }

        BindingList<Object> myInvoiceLines {get; set;}

        void updateView();

        void newInvoice();
        void viewInvoice(int InvoiceID);
        void cancelInvoice();
        void applyChanges();
        void attachReceipt();
        
        void addInvoiceLine();
        void removeInvoiceLine();
        void clearInvoiceLines();
    }
}
