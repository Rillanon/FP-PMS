using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Ex;
using FP_PMS.Db;

namespace FP_PMS.Claimant
{
    class claimantController
    {
        public tblClaimant EditCopyClaimant { get; set; }
        private Form MyViewForm { get; set; }

        private tblClaimant _sourceClaimant;

        private bool ClaimantPropertiesChanged()
        {
            return (EditCopyClaimant.FirstNames != _sourceClaimant.FirstNames)
                   || (EditCopyClaimant.LastName != _sourceClaimant.LastName)
                   || (EditCopyClaimant.Title != _sourceClaimant.Title)
                   || (EditCopyClaimant.Terms != _sourceClaimant.Terms)
                   || (EditCopyClaimant.Comments != _sourceClaimant.Comments)
                   || (EditCopyClaimant.Company != _sourceClaimant.Company)
                   || (EditCopyClaimant.EmailAddr != _sourceClaimant.EmailAddr)
                   || (EditCopyClaimant.ClaimantInActive != _sourceClaimant.ClaimantInActive)
                   || (EditCopyClaimant.RateID != _sourceClaimant.RateID)
                   || (EditCopyClaimant.Postcode != _sourceClaimant.Postcode)
                   || (EditCopyClaimant.AcctStatus != _sourceClaimant.AcctStatus)
                   || (EditCopyClaimant.BusPhone != _sourceClaimant.BusPhone)
                       || (EditCopyClaimant.Address3 != _sourceClaimant.Address3)
                       || (EditCopyClaimant.Address1 != _sourceClaimant.Address1)
                       || (EditCopyClaimant.Address2 != _sourceClaimant.Address2)
                       || (EditCopyClaimant.AcctStatus != _sourceClaimant.AcctStatus)
                       || (EditCopyClaimant.FaxNo != _sourceClaimant.FaxNo)
                       || (EditCopyClaimant.HomePhone != _sourceClaimant.HomePhone)
                       || (EditCopyClaimant.MobileNo != _sourceClaimant.MobileNo)
                       || (EditCopyClaimant.MonthlyAcct != _sourceClaimant.MonthlyAcct);
        }

        public void Initialize()
        {
            EditCopyClaimant = entityClone.Clone(_sourceClaimant);
        }

        public void ApplyChanges()
        {
            var newConnection = new dbContextDataContext();

            try
            {
                if (ClaimantPropertiesChanged())
                {
                    _sourceClaimant = (from p in newConnection.tblClaimants
                                       where p.ClaimantID == _sourceClaimant.ClaimantID
                                       select p).SingleOrDefault();
                    if (_sourceClaimant != null)
                    {
                        _sourceClaimant.UpdateClaimant(EditCopyClaimant);
                        newConnection.SubmitChanges();
                    }
                    else
                    {
                        _sourceClaimant = new tblClaimant();
                        _sourceClaimant.UpdateClaimant(EditCopyClaimant);
                        newConnection.tblClaimants.InsertOnSubmit(_sourceClaimant);
                        newConnection.SubmitChanges();
                    }
                }
            }

            catch(Exception)
            {
                MessageBox.Show(@"Database not responding. Please check your connection.");
            }
        }

        public claimantController(Form myForm, tblClaimant myClaimant)
        {
            MyViewForm = myForm;
            _sourceClaimant = myClaimant;
        }



    }
}
