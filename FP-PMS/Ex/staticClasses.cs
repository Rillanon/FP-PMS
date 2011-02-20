using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FP_PMS.Ex
{
    public class compareNames : IComparer
    {
        public int Compare(object x, object y)
        {
            string sourceName = x.ToString();
            string matchName = y.ToString();

            if (sourceName == matchName)
                return 1;
            else
            {
                return 0;
            }
        }
    }
}
