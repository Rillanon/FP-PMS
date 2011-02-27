using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FP_PMS.Interfaces
{
    interface IReport: IPrinting
    {
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }

        void fillData();
        void calculateSummaries();
        void updateView();
    }
}
