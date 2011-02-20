using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Db;

namespace FP_PMS.Ex
{
    public static class entityRemove
    {
        public static void RemoveClaimant(List<tblClaimant> foo, int ClaimantID)
        {
            foo = (from p in foo where p.ClaimantID != ClaimantID select p).ToList();
            if (foo.Any())
            {
                MessageBox.Show("Yes");
            }
        }
        
    }
}
