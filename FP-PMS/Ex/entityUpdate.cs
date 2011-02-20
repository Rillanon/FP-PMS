using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FP_PMS.Db;

namespace FP_PMS.Ex
{
    public static class entityUpdate
    {
        public static void UpdatePatient(this tblPatient source, AnonPatient copy)
        {
            source.FirstNames = copy.FirstName;
            source.LastName = copy.LastName;
            source.DVANumber = copy.DVANumber;
            source.Comments = copy.Comments;
            source.BirthDate = copy.BirthDate;
            source.PhysioID = copy.PhysioID;
            source.Sex = copy.Sex;
            source.Title = copy.Title;
            source.PatientInActive = copy.PatientInActive;
            source.Family = copy.Family;
            source.Friend = copy.Friend;
            source.FrontSign = copy.FrontSign;
            source.YellowPages = copy.YellowPages;
            source.Internet = copy.Internet;
            source.HealthFund = copy.HealthFund;
            source.HealthProfessional = copy.HealthProfessional;
            source.ReferredByDoc = copy.ReferredByDoc;
            source.RefDoctor = copy.RefDoctor;
            source.Other = copy.Other;

            source.HeartCondition = copy.HeartCondition;
            source.CardiacPacemaker = copy.CardiacPacemaker;
            source.LossOfWeight = copy.LossOfWeight;
            source.Dizziness = copy.Dizziness;
            source.ArtificialJoint = copy.ArtificialJoint;
            source.Epilepsy = copy.Epilepsy;
            source.SurgeryInThePast3Months = copy.SurgeryInThePast3Months;
            source.Smoker = copy.Smoker;
        }

        public static void UpdateClaimant(this tblClaimant source, tblClaimant copy)
        {
            source.AcctStatus = copy.AcctStatus;
            source.Address1 = copy.Address1;
            source.Address2 = copy.Address2;
            source.Address3 = copy.Address3;
            source.BusPhone = copy.BusPhone;
            source.ClaimantInActive = copy.ClaimantInActive;
            source.Comments = copy.Comments;
            source.Company = copy.Company;
            source.EmailAddr = copy.EmailAddr;
            source.FaxNo = copy.FaxNo;
            source.FirstNames = copy.FirstNames;
            source.HomePhone = copy.HomePhone;
            source.LastName = copy.LastName;
            source.MobileNo = copy.MobileNo;
            source.MonthlyAcct = copy.MonthlyAcct;
            source.Postcode = copy.Postcode;
            source.RateID = copy.RateID;
            source.Terms = copy.Terms;
            source.Title = copy.Title;
        }

        public static void UpdateDoctor(this tblRefDoctor source, tblRefDoctor copy)
        {
            source.RefDName = copy.RefDName;
            source.RefDFNames = copy.RefDFNames;
            source.RefDTitle = copy.RefDTitle;
            source.RefHomePhone = copy.RefHomePhone;
            source.RefBusPhone = copy.RefBusPhone;
            source.RefMobile = copy.RefMobile;
            source.RefEmail = copy.RefEmail;
            source.RefDAddr1 = copy.RefDAddr1;
            source.RefDAddr2 = copy.RefDAddr2;
            source.RefDState = copy.RefDState;
            source.RefDPcode = copy.RefDPcode;
            source.RefProviderNo = copy.RefProviderNo;
            source.RefFaxNo = copy.RefFaxNo;
            source.RefDType = copy.RefDType;
        }

        public static void UpdatePatientAddress(this tblPatientAddr source, AnonPatient copy)
        {
            source.Address1 = copy.Address;
            source.Address2 = copy.Suburb;
            source.Address3 = copy.State;
            source.BusPhone = copy.BusPhone;
            source.HomePhone = copy.HomePhone;
            source.FaxNo = copy.Fax;
            source.MobileNo = copy.Mobile;
            source.EmailAddr = copy.Email;
            source.Postcode = copy.PostCode;
        }

    }
}
