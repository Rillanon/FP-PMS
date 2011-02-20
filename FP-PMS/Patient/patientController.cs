using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Ex;
using System.Linq.Expressions;
using FP_PMS.Db;

namespace FP_PMS.Patient
{
    class patientController
    {
        public tblPatient EditCopyPatient { get; set; }
        public tblPatientAddr EditCopyAddress { get; set;}
        public tblPatientAccident EditCopyAccident { get; set; }
        public List<tblClaimant> EditCopyClaimantList { get; set; }
        private Form MyViewForm { get; set; }

        private tblPatient _sourcePatient;
        private tblPatientAddr _sourceAddress;
        private List<tblClaimant> _sourceClaimantList;
        private tblPatientAccident _sourceAccident;

        private bool PatientPropertiesChanged()
        {
            return (EditCopyPatient.BirthDate != _sourcePatient.BirthDate)
                   || (EditCopyPatient.FirstNames != _sourcePatient.FirstNames)
                   || (EditCopyPatient.LastName != _sourcePatient.LastName)
                   || (EditCopyPatient.Sex != _sourcePatient.Sex)
                   || (EditCopyPatient.Comments != _sourcePatient.Comments)
                   || (EditCopyPatient.DVANumber != _sourcePatient.DVANumber)
                   || (EditCopyPatient.Title != _sourcePatient.Title)
                   || (EditCopyPatient.PhysioID != _sourcePatient.PhysioID);
        }

        private bool PatientAddressPropertiesChanged()
        {
            return (EditCopyAddress.Address1 != _sourceAddress.Address1)
                   || (EditCopyAddress.Address2 != _sourceAddress.Address2)
                   || (EditCopyAddress.Address3 != _sourceAddress.Address3)
                   || (EditCopyAddress.BusPhone != _sourceAddress.BusPhone)
                   || (EditCopyAddress.HomePhone != _sourceAddress.HomePhone)
                   || (EditCopyAddress.FaxNo != _sourceAddress.FaxNo)
                   || (EditCopyAddress.MobileNo != _sourceAddress.MobileNo)
                   || (EditCopyAddress.Postcode != _sourceAddress.Postcode)
                   || (EditCopyAddress.EmailAddr != _sourceAddress.EmailAddr);
        }

        private bool ClaimantsChanged()
        {
            return Ex.EntityListCompare.SetEqual(this.EditCopyClaimantList, this._sourceClaimantList);
        }

        public void Initialize()
        {
            var newConnection = new dbContextDataContext();
            EditCopyPatient = entityClone.Clone(_sourcePatient);

            try
            {
                _sourceAddress = (from p in newConnection.tblPatientAddrs
                                  where p.PatientID == _sourcePatient.PatientID
                                  select p).FirstOrDefault();
                if(_sourceAddress != null)
                {
                    
                }
                else
                {
                    _sourceAddress = new tblPatientAddr();
                    
                }
                _sourceClaimantList = (from c in newConnection.tblClaimants
                                       join p in newConnection.tblPatientClaimants
                                       on c.ClaimantID equals p.ClaimantID
                                       where p.PatientID == _sourcePatient.PatientID
                                       select c).ToList();

                _sourceAccident = newConnection.tblPatientAccidents.Where(od => od.PatientID == _sourcePatient.PatientID).FirstOrDefault();

                if (_sourceAccident == null)
                {
                    _sourceAccident = new tblPatientAccident();
                }
                EditCopyAccident = entityClone.Clone(_sourceAccident);
                EditCopyAddress = entityClone.Clone(_sourceAddress);
                EditCopyClaimantList = entityCollectionClone.ClaimantsClone(_sourceClaimantList);
            }
            catch(Exception)
            {
                MessageBox.Show(@"Database not responding. Please check your connection.");
            }
        }

        public void ApplyChanges()
        {
            var newConnection = new dbContextDataContext();

            //If Patient Changed.
            if(PatientPropertiesChanged())
            {
                
                try
                {
                    _sourcePatient = (from p in newConnection.tblPatients
                                      where p.PatientID == _sourcePatient.PatientID
                                      select p).SingleOrDefault();

                    if(_sourcePatient != null)
                    {
                        _sourcePatient.UpdatePatient(EditCopyPatient);
                        newConnection.SubmitChanges();
                    }
                    else
                    {
                        _sourcePatient = new tblPatient();
                        _sourcePatient.UpdatePatient(EditCopyPatient);
                        newConnection.tblPatients.InsertOnSubmit(_sourcePatient);
                        newConnection.SubmitChanges();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Database not responding. Please check your connection.");
                }
            }

            //If Patient Address Changed.
            if(PatientAddressPropertiesChanged())
            {
                try
                {
                    _sourceAddress = (from p in newConnection.tblPatientAddrs
                                      where p.PatientID == _sourcePatient.PatientID
                                      select p).FirstOrDefault();
                    if (_sourceAddress != null)
                    {
                        _sourceAddress.UpdatePatientAddress(EditCopyAddress);
                        newConnection.SubmitChanges();
                    }
                    else
                    {
                        _sourceAddress = new tblPatientAddr();
                        newConnection.tblPatientAddrs.InsertOnSubmit(_sourceAddress);
                        newConnection.SubmitChanges();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Database not responding. Please check your connection.");
                }
            }

            //Claimants of this patient changed.

            if(ClaimantsChanged() == false)
            {
                var added = this.EditCopyClaimantList.Except(this._sourceClaimantList);
                var deleted = this._sourceClaimantList.Except(this.EditCopyClaimantList);

                if (deleted.Any())
                {
                    using (newConnection)
                    {
                        foreach (var y in
                            deleted.Select(x => (tblPatientClaimant)(from p in newConnection.tblPatientClaimants
                                                                     where p.PatientID == this._sourcePatient.PatientID && p.ClaimantID == x.ClaimantID
                                                                     select p).First()))
                        {
                            newConnection.tblPatientClaimants.DeleteOnSubmit(y);
                        }

                        newConnection.SubmitChanges();
                    }

                  

                }

                if (added.Any())
                {
                    var newConnection1 = new dbContextDataContext();
                    using (newConnection1)
                    {
                        foreach (var y in added.Select(x => new tblPatientClaimant
                        {
                            ClaimantID = x.ClaimantID,
                            PatientID = _sourcePatient.PatientID
                        }))
                        {
                            newConnection1.tblPatientClaimants.InsertOnSubmit(y);
                        }
                        newConnection1.SubmitChanges();
                    }
                }
            }
        }

        public patientController(Form myForm, tblPatient myPatient)
        {
            MyViewForm = myForm;
            _sourcePatient = myPatient;
        }

    }
}
