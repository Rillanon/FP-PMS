using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Linq;
using FP_PMS.Ex;
using FP_PMS.Db;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;

namespace FP_PMS.Interfaces
{
    interface IPrinting
    {
        void print();
        void printPreview();
    }
}
