using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraEditors.Repository;
using FP_PMS.Db;
using FP_PMS.Ex;

namespace FP_PMS.Scheduling
{
    public partial class appointmentPopUp : FP_PMS.Templates.level2TemplateForm
    {
        SchedulerControl mySchedulerControl;
        SchedulerStorage mySchedulerStorage;

        long appointmentDuration;
        int suspendUpdateCount;

        Appointment apt;
        Resource res;
        tblPatient myPatient;
        tblRate myRate;
        tblPhysio myPhysio;

        public int selectedResource { get { return (int)myController.ResourceId; }}

        appointmentController myController;

        protected AppointmentStorage Appointments
        {
            get { return mySchedulerControl.Storage.Appointments; }
        }

        protected bool IsUpdateSuspended { get { return suspendUpdateCount > 0; } }

        protected void SuspendUpdate()
        {
            suspendUpdateCount++;
        }
        protected void ResumeUpdate()
        {
            if (suspendUpdateCount > 0)
                suspendUpdateCount--;
        }




        void UpdateForm()
        {
            SuspendUpdate();
            try
            {
                    myPatient = new dbContextDataContext().tblPatients.Where(od => od.PatientID == (int)apt.CustomFields["PatientID"]).FirstOrDefault();

                    if (myPatient != null)
                    {
                        patientFirstNameTextEdit.Text = myPatient.FirstNames;
                        patientLastNameTextEdit.Text = myPatient.LastName;
                        patientGroupControl.Text = myPatient.FirstNames + @" " + myPatient.LastName;
                    }

                    DateTime? date = new DateTime();
                    new dbContextDataContext().getLastPatientVisitDate(myPatient.PatientID, ref date);
                    if (date != null)
                        lastSessionDateEdit.DateTime = date.Value;
                    else
                        lastSessionDateEdit.DateTime = System.DateTime.Today;
                
                if (this.res.CustomFields["PhysioID"].GetType() == typeof(string))
                {
                    //myPhysio = new dbContextDataContext().tblPhysios.Where(od => od.PhysioID == apt.CustomFields["PhysioID"].ToString()).FirstOrDefault();
                    physioLookUp.EditValue = this.res.CustomFields["PhysioID"].ToString();
                }

                rateComboBoxEdit.EditValue = apt.CustomFields["RateID"].ToString();
                appointmentDurationEdit.Duration = apt.End - apt.Start;
            }
            catch(Exception)
            {
            }
            finally
            {
                ResumeUpdate();
            }
            //UpdateIntervalControls();
        }

        void UpdateIntervalControls()
        {
            if (IsUpdateSuspended)
                return;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            base.okBtn_Click(sender, e);

            // Required to check the appointment for conflicts.
            if (!myController.IsConflictResolved())
            {
                this.DialogResult = DialogResult.Retry;
                return;
            }

            if (( patientFirstNameTextEdit.Text.Trim() != string.Empty) && (patientLastNameTextEdit.Text.Trim() != string.Empty) && (myPatient == null))
            {
                myPatient = new tblPatient();
                myPatient.FirstNames = patientFirstNameTextEdit.Text;
                myPatient.LastName = patientLastNameTextEdit.Text;

                var myClaimant = new tblClaimant();

                myClaimant.FirstNames = myPatient.FirstNames;
                myClaimant.LastName = myPatient.LastName;

                var newConnection = new dbContextDataContext();
                newConnection.tblPatients.InsertOnSubmit(myPatient);
                newConnection.tblClaimants.InsertOnSubmit(myClaimant);
                newConnection.SubmitChanges();

                var relation = new tblPatientClaimant();
                relation.ClaimantID = myClaimant.ClaimantID;
                relation.PatientID = myPatient.PatientID;

                newConnection.tblPatientClaimants.InsertOnSubmit(relation);
                newConnection.SubmitChanges();
                Cursor.Current = Cursors.Default;
            }

            if (appointmentDurationEdit.Duration != null)
            {
                this.myController.DisplayEnd = this.myController.DisplayStart.AddTicks(this.appointmentDurationEdit.Duration.Ticks);
            }

                if(myPatient != null)
                {
                    this.myController.Subject = this.myPatient.FirstNames + @" " + this.myPatient.LastName;
                    this.myController.editCopyPatientID = this.myPatient.PatientID;
                }
                else
                {
                             this.myController.Subject = @"No Patient Selected";
                             this.myController.editCopyPatientID = null;
                }

                if (string.IsNullOrEmpty(rateComboBoxEdit.Text) == false)
                {
                    this.myController.editCopyRateID = this.rateComboBoxEdit.EditValue.ToString();
                }
                else
                {
                    this.myController.editCopyRateID = "P";
                }

                if (string.IsNullOrEmpty(physioLookUp.Text) == false)
                {
                    this.myController.editCopyPhysioID = this.physioLookUp.EditValue.ToString();
                    if (myPhysio != null)
                    {
                        this.myController.ResourceId = this.myPhysio.UniqueID;
                        //this.mySchedulerControl.ActiveView.SetSelection(this.mySchedulerStorage.Resources.GetResourceById(selectedResource));
                    }
                }

                else
                {
                    string physioID = mySchedulerControl.SelectedResource.CustomFields["PhysioID"].ToString();
                    this.myController.editCopyPhysioID = physioID;
                }

                this.myController.Subject = this.myController.Subject;
            
            this.myController.ApplyChanges();
        }

        public appointmentPopUp(SchedulerControl myControl, SchedulerStorage myStorage, Appointment apt)
        {
            this.mySchedulerControl = myControl;
            this.mySchedulerStorage = myStorage;
            
            this.myController = new appointmentController(myControl, apt);
            this.apt = apt;
                this.res = myControl.SelectedResource;
                
                if (this.res.CustomFields["NewPatientAppDefaultDuration"].GetType() != typeof(long))
                {
                    //default appointment interval time in long AKA 15mins.
                    appointmentDuration = 9000000000L;
                }
                else
                {
                    appointmentDuration = (long)this.res.CustomFields["NewPatientAppDefaultDuration"];
                }
                SuspendUpdate();
                InitializeComponent();
                ResumeUpdate();
            
        }


        private void patientLinqInstantFeedBack_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            ((dbContextDataContext)e.Tag).Dispose();
        }

        private void patientLinqInstantFeedBack_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var newConnection = new dbContextDataContext();
            e.QueryableSource = newConnection.tblPatients;
            e.Tag = newConnection;
        }

        private void appointmentPopUp_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            patientLookUp.Properties.DisplayMember = "FirstNames";
            patientLookUp.Properties.ValueMember = "PatientID";
            patientLookUp.Properties.DataSource = patientLinqInstantFeedBack;

            physioLookUp.Properties.DisplayMember = "PhysioID";
            physioLookUp.Properties.ValueMember = "PhysioID";
            physioLookUp.Properties.DataSource = new dbContextDataContext().tblPhysios.Where(p=>p.PhysioInActive.GetValueOrDefault(false) != true);

            rateComboBoxEdit.Properties.DisplayMember = "RateDesc";
            rateComboBoxEdit.Properties.ValueMember = "RateID";
            rateComboBoxEdit.Properties.DataSource = new dbContextDataContext().tblRates;

            //patientLookUp.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.FindClick;
            //patientLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.appointmentDurationEdit.EditValue = TimeSpan.FromTicks(appointmentDuration);

            if (mySchedulerStorage.Appointments.IsNewAppointment(apt) == true)
            {
                this.physioLookUp.EditValue = res.CustomFields["PhysioID"].ToString();
                this.rateComboBoxEdit.EditValue = "P";
            }

            UpdateForm();
            Cursor.Current = Cursors.Default;   
        }

        private void patientLookUp_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
                e.DisplayText = string.Format("{0} {1}",
                   patientLookUpView.GetRowCellValue(patientLookUpView.FocusedRowHandle, "FirstNames"),
                   patientLookUpView.GetRowCellValue(patientLookUpView.FocusedRowHandle, "LastName"));
        }

        private void patientLookUp_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
                myPatient = entityClone.Clone(((tblPatient)patientLookUpView.GetFocusedRow()));

                if (myPatient != null)
                {
                    patientFirstNameTextEdit.Text = myPatient.FirstNames;
                    patientLastNameTextEdit.Text = myPatient.LastName;
                    physioLookUp.EditValue = myPatient.PhysioID;
                    myPhysio = new dbContextDataContext().tblPhysios.Where(od => od.PhysioID == myPatient.PhysioID).FirstOrDefault();
                    if (myPhysio != null)
                    {
                        appointmentDurationEdit.Duration = TimeSpan.FromTicks(myPhysio.ExistingPatientAppDefaultDuration.GetValueOrDefault(9000000000L));
                    }
                    patientGroupControl.Text = myPatient.FirstNames + @" " + myPatient.LastName;

                    DateTime? date = new DateTime();
                    new dbContextDataContext().getLastPatientVisitDate(myPatient.PatientID, ref date);
                    if (date != null)
                        lastSessionDateEdit.DateTime = date.Value;
                    else
                        lastSessionDateEdit.DateTime = System.DateTime.Today;
                }
                Cursor.Current = Cursors.Default;
        }

        private void rateComboBoxEdit_EditValueChanged(object sender, EventArgs e)
        {
            myRate = entityClone.Clone((tblRate)rateComboBoxEdit.GetSelectedDataRow());
        }

        private void physioLookUp_EditValueChanged(object sender, EventArgs e)
        {
            myPhysio = entityClone.Clone((tblPhysio)physioLookUpView.GetFocusedRow());
        }

        private void detailBtn_Click(object sender, EventArgs e)
        {
            var x = new Patient.newPatientViewForm();
            if (x.ShowDialog() == DialogResult.OK)
            {
                myPatient = new dbContextDataContext().tblPatients.Where(p => p.PatientID == x.myPatient.PatientID).SingleOrDefault();
                patientFirstNameTextEdit.Text = myPatient.FirstNames;
                patientLastNameTextEdit.Text = myPatient.LastName;
                patientGroupControl.Text = myPatient.FirstNames + @" " + myPatient.LastName;
            }
        }

        private void recurrenceBtn_Click(object sender, EventArgs e)
        {
            ShowRecurrenceForm();
        }

        void ShowRecurrenceForm()
        {
            if (!mySchedulerControl.SupportsRecurrence)
                return;
            // Prepare to edit the appointment's recurrence.
            Appointment editedAptCopy = myController.EditedAppointmentCopy;
            Appointment editedPattern = myController.EditedPattern;
            Appointment patternCopy = myController.PrepareToRecurrenceEdit();

            var dlg = new AppointmentRecurrenceForm(patternCopy, mySchedulerControl.OptionsView.FirstDayOfWeek, myController);

            // Required for skin support.
            

            DialogResult result = dlg.ShowDialog(this);
            dlg.Dispose();

            if (result == DialogResult.Abort)
                myController.RemoveRecurrence();
            else
                if (result == DialogResult.OK)
                {
                    myController.ApplyRecurrence(patternCopy);
                    if (myController.EditedAppointmentCopy != editedAptCopy)
                        UpdateForm();
                }
            UpdateIntervalControls();
            myController.ApplyChanges();
        }
    }
}
