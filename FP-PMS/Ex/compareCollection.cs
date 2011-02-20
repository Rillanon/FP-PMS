using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FP_PMS.Db;

namespace FP_PMS.Ex
{

    public static class EntityListCompare
    {
        public static bool claimantsEqual(BindingList<tblClaimant> left, BindingList<tblClaimant> right)
        {

            if (left.Count != right.Count)
                return false;

            var dict = new Dictionary<int, int>();

            foreach (tblClaimant x in left)
            {
                if (x == null)
                    return true;
            }

            foreach (tblClaimant y in right)
            {
                if (y == null)
                    return true;
            }

            foreach (tblClaimant member in left)
            {
                if (dict.ContainsKey(member.ClaimantID) == false)
                    dict[member.ClaimantID] = 1;
                else
                    dict[member.ClaimantID]++;
            }

            foreach (tblClaimant member in right)
            {
                switch (dict.ContainsKey(member.ClaimantID))
                {
                    case false:
                        return false;
                    default:
                        dict[member.ClaimantID]--;
                        break;
                }
            }

            return dict.All(kvp => kvp.Value == 0);
        }

        public static bool accidentsEqual(BindingList<tblPatientAccident> left, 
            BindingList<tblPatientAccident> right)
        {

            if (left.Count != right.Count)
                return false;

            foreach (tblPatientAccident A in left)
            {
                if ((A == null) || (A.ClaimNo == null))
                    return false;
            }

            foreach (tblPatientAccident B in right)
            {
                if ((B == null) || (B.ClaimNo == null))
                    return false;
            }

            var dict = new Dictionary<string, int>();

            foreach (tblPatientAccident member in left)
            {
                if (dict.ContainsKey(member.ClaimNo) == false)
                    dict[member.ClaimNo] = 1;
                else
                    dict[member.ClaimNo]++;
            }

            foreach (tblPatientAccident member in right)
            {
                switch (dict.ContainsKey(member.ClaimNo))
                {
                    case false:
                        return false;
                    default:
                        dict[member.ClaimNo]--;
                        break;
                }
            }

            return dict.All(kvp => kvp.Value == 0);
        }


    }



}
