using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;
using FP_PMS.Db;


namespace FP_PMS.Scheduling
{
    class appointmentController: AppointmentFormController
    {
        public int? editCopyPatientID { get { return (int?)EditedAppointmentCopy.CustomFields["PatientID"]; } set { EditedAppointmentCopy.CustomFields["PatientID"] = value; } }
        public string editCopyRateID { get { return (string)EditedAppointmentCopy.CustomFields["RateID"]; } set { EditedAppointmentCopy.CustomFields["RateID"] = value; } }
        public string editCopyPhysioID { get { return (string)EditedAppointmentCopy.CustomFields["PhysioID"]; } set { EditedAppointmentCopy.CustomFields["PhysioID"] = value; } }

        int? sourcePatientID { get { return (int?)SourceAppointment.CustomFields["PatientID"]; } set { SourceAppointment.CustomFields["PatientID   "] = value; } }
        string sourceRateID { get { return (string)SourceAppointment.CustomFields["RateID"]; } set { SourceAppointment.CustomFields["RateID"] = value; } }
        string sourcePhysioID { get { return (string)SourceAppointment.CustomFields["PhysioID"]; } set { SourceAppointment.CustomFields["PhysioID"] = value; } }



        public appointmentController(SchedulerControl control, Appointment apt)
            : base(control, apt)
        {
        }

        protected override void ApplyCustomFieldsValues()
        {
            sourcePatientID = editCopyPatientID;
            sourceRateID = editCopyRateID;
            sourcePhysioID = editCopyPhysioID;
        }

        public override bool IsAppointmentChanged() {
            if(base.IsAppointmentChanged())
                return true;
            return sourcePatientID != editCopyPatientID || sourcePhysioID != editCopyPhysioID ||
                sourceRateID != editCopyRateID;
          }
    }
}
