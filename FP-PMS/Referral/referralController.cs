using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Referral;
using FP_PMS.Db;
using FP_PMS.Ex;

namespace FP_PMS.Referral
{
    class referralController
    {
        public tblRefDoctor EditCopyDoctor { get; set; }
        private Form MyViewForm { get; set; }

        private tblRefDoctor _sourceDoctor;

        //Returns true if user made a change.
        private bool DoctorPropertiesChanged()
        {
            return (EditCopyDoctor.RefDName != _sourceDoctor.RefDName)
                   || (EditCopyDoctor.RefDFNames != _sourceDoctor.RefDFNames)
                   || (EditCopyDoctor.RefDTitle != _sourceDoctor.RefDTitle)
                   || (EditCopyDoctor.RefHomePhone != _sourceDoctor.RefHomePhone)
                   || (EditCopyDoctor.RefBusPhone != _sourceDoctor.RefBusPhone)
                   || (EditCopyDoctor.RefMobile != _sourceDoctor.RefMobile)
                   || (EditCopyDoctor.RefEmail != _sourceDoctor.RefEmail)
                   || (EditCopyDoctor.RefDAddr1 != _sourceDoctor.RefDAddr1)
                   || (EditCopyDoctor.RefDAddr2 != _sourceDoctor.RefDAddr2)
                   || (EditCopyDoctor.RefDState != _sourceDoctor.RefDState)
                   || (EditCopyDoctor.RefDPcode != _sourceDoctor.RefDPcode)
                   || (EditCopyDoctor.RefProviderNo != _sourceDoctor.RefProviderNo)
                   || (EditCopyDoctor.RefFaxNo != _sourceDoctor.RefFaxNo)
                   || (EditCopyDoctor.RefDType != _sourceDoctor.RefDType);
        }

        public void Initialize()
        {
            EditCopyDoctor = entityClone.Clone(_sourceDoctor);
        }

        public void ApplyChanges()
        {
            if (DoctorPropertiesChanged())
            {
                var newConnection = new dbContextDataContext();
                try
                {
                    _sourceDoctor = (from p in newConnection.tblRefDoctors
                                     where p.RefDoctor == _sourceDoctor.RefDoctor
                                     select p).SingleOrDefault();

                    //Null = new doctor
                    if (_sourceDoctor != null)
                    {
                        _sourceDoctor.UpdateDoctor(EditCopyDoctor);
                        newConnection.SubmitChanges();
                    }
                    else
                    {
                        _sourceDoctor = new tblRefDoctor();
                        _sourceDoctor.UpdateDoctor(EditCopyDoctor);
                        newConnection.tblRefDoctors.InsertOnSubmit(_sourceDoctor);
                        newConnection.SubmitChanges();
                    }
                }
                    catch (Exception)
                {
                    MessageBox.Show(@"Database not responding. Please check your connection.");
                }
            }
        }

        public referralController(Form myForm, tblRefDoctor myDoctor)
        {
            MyViewForm = myForm;
            _sourceDoctor = myDoctor;
        }

    }
}
