using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Net.Mime;
using FP_PMS.Ex;
using FP_PMS.Db;

namespace FP_PMS.Patient
{
	public partial class newPatientViewForm : FP_PMS.Templates.level2TemplateForm
	{
		AnonPatient _sourcePatient = new AnonPatient();
		BindingList<tblPatientAccident> _sourceAccidentList = new BindingList<tblPatientAccident> { };
		BindingList<tblClaimant> _sourceClaimantList = new BindingList<tblClaimant> { };
		private AnonPatient editCopyPatient { get; set; }
		private BindingList<tblClaimant> editCopyClaimants = new BindingList<tblClaimant> { };
		private BindingList<tblPatientAccident> editCopyAccidents = new BindingList<tblPatientAccident> { };

		public AnonPatient myPatient { get { return _sourcePatient; } set { _sourcePatient = value; } }

		public newPatientViewForm()
		{
			InitializeComponent();
			newPatient();

			_sourceAccidentList.AllowNew = true;
			_sourceAccidentList.AllowEdit = true;
			_sourceAccidentList.AllowRemove = true;
		}

		#region my methods

		static Func<dbContextDataContext, int, IQueryable<tblClaimant>> GetClaimants =
			CompiledQuery.Compile((dbContextDataContext db, int pid) =>
				(from patient in db.tblPatients.Where(p => p.PatientID == pid).DefaultIfEmpty()

				 from patientClaimant in db.tblPatientClaimants.Where(pc => pc.PatientID == pid).DefaultIfEmpty()

				 from claimant in db.tblClaimants.Where(c => (c.ClaimantID == patientClaimant.ClaimantID)
					 || (c.ClaimantID == patient.ClaimantID)).DefaultIfEmpty()
				 select claimant).Distinct());


		void updateClaimantAccidents()
		{
			if (patientPresentTabControl.SelectedTabPage.Name == "claimantTabPage")
			{
				if ((_sourceClaimantList.Any() == false) && (myPatient.PatientID != null))
				{
					var newConnection = new dbContextDataContext();

					//var claimants = (from patient in newConnection.tblPatients.Where(p => p.PatientID == myPatient.PatientID).DefaultIfEmpty()

					//                 from patientClaimant in newConnection.tblPatientClaimants.Where(pc => pc.PatientID == myPatient.PatientID).DefaultIfEmpty()

					//                 from claimant in newConnection.tblClaimants.Where(c => (c.ClaimantID == patientClaimant.ClaimantID)
					//                     || (c.ClaimantID == patient.ClaimantID)).DefaultIfEmpty()
					//                 select claimant).Distinct().ToList();

					var claimants = GetClaimants(newConnection, myPatient.PatientID.Value).ToList();

					foreach (tblClaimant c in claimants)
					{
						_sourceClaimantList.Add(c);
					}

					editCopyClaimants = entityCollectionClone.CollectionClone(_sourceClaimantList);
					claimantGridControl.DataSource = editCopyClaimants;
				}
			}

			if (patientPresentTabControl.SelectedTabPage.Name == "accidentClaimTabPage")
			{
				if ((_sourceAccidentList.Any() == false) && (myPatient.PatientID != null))
				{
					var newConnection = new dbContextDataContext();

					var accidents = newConnection.tblPatientAccidents.Where(a => a.PatientID 
						== myPatient.PatientID).DefaultIfEmpty().Distinct().ToList();

					foreach (tblPatientAccident a in accidents)
					{
						_sourceAccidentList.Add(a);
					}

					editCopyAccidents = entityCollectionClone.CollectionClone(_sourceAccidentList);
					accidentGridControl.DataSource = editCopyAccidents;
				}
			}
		}

		void newPatient()
		{
			myPatient = new AnonPatient();
			_sourceAccidentList = new BindingList<tblPatientAccident> { };
			_sourceClaimantList = new BindingList<tblClaimant> { };
			editCopyPatient = entityClone.Clone(myPatient);

			editCopyAccidents = entityCollectionClone.CollectionClone(_sourceAccidentList);
			editCopyClaimants = entityCollectionClone.CollectionClone(_sourceClaimantList);

			claimantGridControl.DataSource = editCopyClaimants;
			accidentGridControl.DataSource = editCopyAccidents;
			actionStateLabelControl.Text = @"Adding new Patient";
			actionStateLabelControl.BackColor = System.Drawing.Color.LightGreen;
			patientLookUp.EditValue = null;
			refDocLookUp.EditValue = null;
			updateDetails();
		}

		void updateDetails()
		{
			_sourceClaimantList.Clear();
			_sourceAccidentList.Clear();
			firstNameTextEdit.Text = editCopyPatient.FirstName;
			lastNameTextEdit.Text = editCopyPatient.LastName;
			genderComboBox.Text = editCopyPatient.Sex;
			titleComboBox.Text = editCopyPatient.Title;
			dobDateEdit.DateTime = editCopyPatient.BirthDate.GetValueOrDefault(System.DateTime.MinValue);
			patientInactiveCheckEdit.Checked = editCopyPatient.PatientInActive.GetValueOrDefault(false);
			dvaTextEdit.Text = editCopyPatient.DVANumber;
			physioLookUp.EditValue = editCopyPatient.PhysioID;
			commentMemoEdit.Text = editCopyPatient.Comments;
			homePhoneTextEdit.Text = editCopyPatient.HomePhone;
			workPhoneTextEdit.Text = editCopyPatient.BusPhone;
			mobileTextEdit.Text = editCopyPatient.Mobile;
			faxTextEdit.Text = editCopyPatient.Fax;
			emailTextEdit.Text = editCopyPatient.Email;
			addressTextEdit.Text = editCopyPatient.Address;
			suburbTextEdit.Text = editCopyPatient.Suburb;
			stateTextEdit.Text = editCopyPatient.State;
			postCodeTextEdit.Text = editCopyPatient.PostCode;

			if (editCopyPatient.Family.GetValueOrDefault(false) == true)
			{
				referralCheckListBox.Items[0].CheckState = CheckState.Checked;
			}
			else
			{
				referralCheckListBox.Items[0].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.Friend.GetValueOrDefault(false) == true)
			{
				referralCheckListBox.Items[1].CheckState = CheckState.Checked;
			}
			else
			{
				referralCheckListBox.Items[1].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.FrontSign.GetValueOrDefault(false) == true)
			{
				referralCheckListBox.Items[2].CheckState = CheckState.Checked;
			}
			else
			{
				referralCheckListBox.Items[2].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.YellowPages.GetValueOrDefault(false) == true)
			{
				referralCheckListBox.Items[3].CheckState = CheckState.Checked;
			}
			else
			{
				referralCheckListBox.Items[3].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.Internet.GetValueOrDefault(false) == true)
			{
				referralCheckListBox.Items[4].CheckState = CheckState.Checked;
			}
			else
			{
				referralCheckListBox.Items[4].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.HealthFund.GetValueOrDefault(false) == true)
			{
				referralCheckListBox.Items[5].CheckState = CheckState.Checked;
			}
			else
			{
				referralCheckListBox.Items[5].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.HealthProfessional.GetValueOrDefault(false) == true)
			{
				referralCheckListBox.Items[6].CheckState = CheckState.Checked;
			}
			else
			{
				referralCheckListBox.Items[6].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.ReferredByDoc.GetValueOrDefault(false) == true)
			{
				referralCheckListBox.Items[7].CheckState = CheckState.Checked;
			}
			else
			{
				referralCheckListBox.Items[7].CheckState = CheckState.Unchecked;
			}

			otherTextEdit.Text = editCopyPatient.Other;
			refDocLookUp.EditValue = editCopyPatient.RefDoctor;



			if (editCopyPatient.HeartCondition.GetValueOrDefault(false) == true)
			{
				medicalCheckListBox.Items[0].CheckState = CheckState.Checked;
			}
			else
			{
				medicalCheckListBox.Items[0].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.CardiacPacemaker.GetValueOrDefault(false) == true)
			{
				medicalCheckListBox.Items[1].CheckState = CheckState.Checked;
			}
			else
			{
				medicalCheckListBox.Items[1].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.LossOfWeight.GetValueOrDefault(false) == true)
			{
				medicalCheckListBox.Items[2].CheckState = CheckState.Checked;
			}
			else
			{
				medicalCheckListBox.Items[2].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.Dizziness.GetValueOrDefault(false) == true)
			{
				medicalCheckListBox.Items[3].CheckState = CheckState.Checked;
			}
			else
			{
				medicalCheckListBox.Items[3].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.ArtificialJoint.GetValueOrDefault(false) == true)
			{
				medicalCheckListBox.Items[4].CheckState = CheckState.Checked;
			}
			else
			{
				medicalCheckListBox.Items[4].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.Epilepsy.GetValueOrDefault(false) == true)
			{
				medicalCheckListBox.Items[5].CheckState = CheckState.Checked;
			}
			else
			{
				medicalCheckListBox.Items[5].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.SurgeryInThePast3Months.GetValueOrDefault(false) == true)
			{
				medicalCheckListBox.Items[6].CheckState = CheckState.Checked;
			}
			else
			{
				medicalCheckListBox.Items[6].CheckState = CheckState.Unchecked;
			}

			if (editCopyPatient.Smoker.GetValueOrDefault(false) == true)
			{
				medicalCheckListBox.Items[7].CheckState = CheckState.Checked;
			}
			else
			{
				medicalCheckListBox.Items[7].CheckState = CheckState.Unchecked;
			}
			
			
		}

		void saveDetails()
		{
			editCopyPatient.FirstName = firstNameTextEdit.Text;
			editCopyPatient.LastName = lastNameTextEdit.Text;
			editCopyPatient.Sex = genderComboBox.Text;
			editCopyPatient.Title = titleComboBox.Text;
			editCopyPatient.BirthDate = dobDateEdit.DateTime;
			editCopyPatient.PatientInActive = patientInactiveCheckEdit.Checked;
			editCopyPatient.DVANumber = dvaTextEdit.Text;
			if ((tblPhysio)physioLookUpView.GetFocusedRow() != null)
			{
				var p = (tblPhysio)physioLookUpView.GetFocusedRow();
				editCopyPatient.PhysioID = p.PhysioID;
			}
			editCopyPatient.Comments = commentMemoEdit.Text;
			editCopyPatient.HomePhone = homePhoneTextEdit.Text;
			editCopyPatient.BusPhone = workPhoneTextEdit.Text;
			editCopyPatient.Mobile = mobileTextEdit.Text;
			editCopyPatient.Fax = faxTextEdit.Text;
			editCopyPatient.Email = emailTextEdit.Text;
			editCopyPatient.Address = addressTextEdit.Text;
			editCopyPatient.Suburb = suburbTextEdit.Text;
			editCopyPatient.State = stateTextEdit.Text;
			editCopyPatient.PostCode = postCodeTextEdit.Text;

			if (referralCheckListBox.Items[0].CheckState == CheckState.Checked)
			{
				editCopyPatient.Family = true;
			}
			else
			{
				editCopyPatient.Family = false;
			}

			if (referralCheckListBox.Items[1].CheckState == CheckState.Checked)
			{
				editCopyPatient.Friend = true;
			}
			else
			{
				editCopyPatient.Friend = false;
			}

			if (referralCheckListBox.Items[2].CheckState == CheckState.Checked)
			{
				editCopyPatient.FrontSign = true;
			}
			else
			{
				editCopyPatient.FrontSign = false;
			}

			if (referralCheckListBox.Items[3].CheckState == CheckState.Checked)
			{
				editCopyPatient.YellowPages = true;
			}
			else
			{
				editCopyPatient.YellowPages = false;
			}

			if (referralCheckListBox.Items[4].CheckState == CheckState.Checked)
			{
				editCopyPatient.Internet = true;
			}
			else
			{
				editCopyPatient.Internet = false;
			}

			if (referralCheckListBox.Items[5].CheckState == CheckState.Checked)
			{
				editCopyPatient.HealthFund = true;
			}
			else
			{
				editCopyPatient.HealthFund = false;
			}

			if (referralCheckListBox.Items[6].CheckState == CheckState.Checked)
			{
				editCopyPatient.HealthProfessional = true;
			}
			else
			{
				editCopyPatient.HealthProfessional = false;
			}

			if (referralCheckListBox.Items[7].CheckState == CheckState.Checked)
			{
				editCopyPatient.ReferredByDoc = true;
			}
			else
			{
				editCopyPatient.ReferredByDoc = false;
			}

			editCopyPatient.Other = otherTextEdit.Text;

			var currentDoc = (tblRefDoctor)refDoctorLookUpView.GetFocusedRow();
			if(currentDoc != null)
			{
				editCopyPatient.RefDoctor = currentDoc.RefDoctor;
			}

			if (medicalCheckListBox.Items[0].CheckState == CheckState.Checked)
			{
				editCopyPatient.HeartCondition = true;
			}
			else
			{
				editCopyPatient.HeartCondition = false;
			}

			if (medicalCheckListBox.Items[1].CheckState == CheckState.Checked)
			{
				editCopyPatient.CardiacPacemaker = true;
			}
			else
			{
				editCopyPatient.CardiacPacemaker = false;
			}

			if (medicalCheckListBox.Items[2].CheckState == CheckState.Checked)
			{
				editCopyPatient.LossOfWeight = true;
			}
			else
			{
				editCopyPatient.LossOfWeight = false;
			}

			if (medicalCheckListBox.Items[3].CheckState == CheckState.Checked)
			{
				editCopyPatient.Dizziness = true;
			}
			else
			{
				editCopyPatient.Dizziness = false;
			}

			if (medicalCheckListBox.Items[4].CheckState == CheckState.Checked)
			{
				editCopyPatient.ArtificialJoint = true;
			}
			else
			{
				editCopyPatient.ArtificialJoint = false;
			}

			if (medicalCheckListBox.Items[5].CheckState == CheckState.Checked)
			{
				editCopyPatient.Epilepsy = true;
			}
			else
			{
				editCopyPatient.Epilepsy = false;
			}

			if (medicalCheckListBox.Items[6].CheckState == CheckState.Checked)
			{
				editCopyPatient.SurgeryInThePast3Months = true;
			}
			else
			{
				editCopyPatient.SurgeryInThePast3Months = false;
			}

			if (medicalCheckListBox.Items[7].CheckState == CheckState.Checked)
			{
				editCopyPatient.Smoker = true;
			}
			else
			{
				editCopyPatient.Smoker = false;
			}

		}

		#endregion

		#region controllercode

		private void commitChanges()
		{

			if((firstNameTextEdit.Text == "") || (lastNameTextEdit.Text == ""))
			{
				MessageBox.Show("Please complete first name and last name");
			this.DialogResult = DialogResult.Retry;
			}
				//No doctor should have the ID of 0;
			else if ((referralCheckListBox.Items[7].CheckState == CheckState.Checked) && 
				((entityClone.IsNullOrDefault(editCopyPatient.RefDoctor) == true)) || (editCopyPatient.RefDoctor == 0))
			{
				var result = MessageBox.Show("Did you forget to select a referring doctor? Do you want to select one now?", 
					"Reminder", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					this.DialogResult = DialogResult.Retry;
				}
				else
				{
					saveDetails();
					applyChanges();
					this.DialogResult = DialogResult.OK;
				}
			}

			else
			{
				saveDetails();
				applyChanges();
				this.DialogResult = DialogResult.OK;
			}
		}
		
		private bool patientPropertiesChanged()
		{
			return (editCopyPatient.BirthDate != _sourcePatient.BirthDate)
				   || (editCopyPatient.FirstName != _sourcePatient.FirstName)
				   || (editCopyPatient.LastName != _sourcePatient.LastName)
				   || (editCopyPatient.Sex != _sourcePatient.Sex)
				   || (editCopyPatient.Comments != _sourcePatient.Comments)
				   || (editCopyPatient.DVANumber != _sourcePatient.DVANumber)
				   || (editCopyPatient.Title != _sourcePatient.Title)
				   || (editCopyPatient.PhysioID != _sourcePatient.PhysioID)
				   || (editCopyPatient.Address != _sourcePatient.Address)
				   || (editCopyPatient.Suburb != _sourcePatient.Suburb)
				   || (editCopyPatient.State != _sourcePatient.State)
				   || (editCopyPatient.PostCode != _sourcePatient.PostCode)
				   || (editCopyPatient.HomePhone != _sourcePatient.HomePhone)
				   || (editCopyPatient.Mobile != _sourcePatient.Mobile)
				   || (editCopyPatient.BusPhone != _sourcePatient.BusPhone)
				   || (editCopyPatient.Email != _sourcePatient.Email)
				   || (editCopyPatient.Fax != _sourcePatient.Fax)
				   || (editCopyPatient.PatientInActive != _sourcePatient.PatientInActive)
				   || (editCopyPatient.HeartCondition != _sourcePatient.HeartCondition)
				   || (editCopyPatient.CardiacPacemaker != _sourcePatient.CardiacPacemaker)
				   || (editCopyPatient.LossOfWeight != _sourcePatient.LossOfWeight)
				   || (editCopyPatient.Dizziness != _sourcePatient.Dizziness)
				   || (editCopyPatient.ArtificialJoint != _sourcePatient.ArtificialJoint)
				   || (editCopyPatient.Epilepsy != _sourcePatient.Epilepsy)
				   || (editCopyPatient.SurgeryInThePast3Months != _sourcePatient.SurgeryInThePast3Months)
				   || (editCopyPatient.Smoker != _sourcePatient.Smoker)
				   || (editCopyPatient.Family != _sourcePatient.Family)
				   || (editCopyPatient.Friend != _sourcePatient.Friend)
				   || (editCopyPatient.FrontSign != _sourcePatient.FrontSign)
				   || (editCopyPatient.YellowPages != _sourcePatient.YellowPages)
				   || (editCopyPatient.Internet != _sourcePatient.Internet)
				   || (editCopyPatient.HealthFund != _sourcePatient.HealthFund)
				   || (editCopyPatient.HealthProfessional != _sourcePatient.HealthProfessional)
				   || (editCopyPatient.ReferredByDoc != _sourcePatient.ReferredByDoc)
				   || (editCopyPatient.RefDoctor != _sourcePatient.RefDoctor)
				   || (editCopyPatient.Other != _sourcePatient.Other);
		}

		private bool claimantsChanged()
		{
			return Ex.EntityListCompare.claimantsEqual(this.editCopyClaimants, this._sourceClaimantList);
		}

		private bool accidentsChanged()
		{
			if (_sourceAccidentList.Count() != editCopyAccidents.Count())
			{
				return true;
			}

			var changed = !_sourceAccidentList.SequenceEqual(this.editCopyAccidents, new changedComparer());
			
			return changed;
		}

		public void applyChanges()
		{
			try
			{
				var newConnection = new dbContextDataContext();
				tblPatient patientData = new tblPatient();
				//If Patient Changed.
				if (patientPropertiesChanged())
				{
					//try
					//{
					//Patient Details
					patientData = (from p in newConnection.tblPatients
								   where p.PatientID == _sourcePatient.PatientID
								   select p).SingleOrDefault();

					if (patientData != null)
					{
						patientData.UpdatePatient(editCopyPatient);
					}
					else
					{
						patientData = new tblPatient();
						var claimantData = new tblClaimant();

						patientData.UpdatePatient(editCopyPatient);
						claimantData.FirstNames = patientData.FirstNames;
						claimantData.LastName = patientData.LastName;
						claimantData.RateID = "P";
						claimantData.Postcode = editCopyPatient.PostCode;
						claimantData.MobileNo = editCopyPatient.Mobile;
						claimantData.HomePhone = editCopyPatient.HomePhone;
						claimantData.FaxNo = editCopyPatient.Fax;
						claimantData.BusPhone = editCopyPatient.BusPhone;
						claimantData.EmailAddr = editCopyPatient.Email;
						claimantData.Address1 = editCopyPatient.Address;
						claimantData.Address2 = editCopyPatient.Suburb;
						claimantData.Address3 = editCopyPatient.State;

						//Submit the claimant first so we can get the claimant id for the patient.

						newConnection.tblClaimants.InsertOnSubmit(claimantData);
						newConnection.SubmitChanges();

						patientData.ClaimantID = claimantData.ClaimantID;
						newConnection.tblPatients.InsertOnSubmit(patientData);

						newConnection.SubmitChanges();
						actionStateLabelControl.Text = "Patient Added";
						myPatient.PatientID = patientData.PatientID;
					}


					//Patient Address
					var addressData = (from p in newConnection.tblPatientAddrs
									   where p.PatientID == patientData.PatientID
									   select p).FirstOrDefault();
					if (addressData != null)
					{
						addressData.UpdatePatientAddress(editCopyPatient);
					}
					else
					{
						addressData = new tblPatientAddr();
						addressData.PatientID = patientData.PatientID;
						addressData.UpdatePatientAddress(editCopyPatient);
						newConnection.tblPatientAddrs.InsertOnSubmit(addressData);
					}
					newConnection.SubmitChanges();
				}

				//Claimants of this patient changed.

				if (claimantsChanged() == false)
				{
					var added = this.editCopyClaimants.Except(this._sourceClaimantList);
					var deleted = this._sourceClaimantList.Except(this.editCopyClaimants);

					if (deleted.Any())
					{

						foreach (var y in
							deleted.Select(x => (tblPatientClaimant)(from p in newConnection.tblPatientClaimants
																	 where p.PatientID == patientData.PatientID
																	 && p.ClaimantID == x.ClaimantID
																	 select p).First()))
						{
							//newConnection.tblPatientClaimants.DeleteOnSubmit(y);
						}
					}

					if (added.Any())
					{
						foreach (var y in added.Select(x => new tblPatientClaimant
						{
							ClaimantID = x.ClaimantID,
							PatientID = patientData.PatientID
						}))
						{
							newConnection.tblPatientClaimants.InsertOnSubmit(y);
						}
					}
					//_sourceClaimantList = entityCollectionClone.CollectionClone(editCopyClaimants);
					//newConnection.SubmitChanges();
				}

				//Accidents of patient changed.

				if (accidentsChanged() == true)
				{
					var added = this.editCopyAccidents.Except(this._sourceAccidentList, new ProductComparer());
					var deleted = this._sourceAccidentList.Except(this.editCopyAccidents, new ProductComparer());
					var changed = this.editCopyAccidents.Except(this._sourceAccidentList, new changedComparer());

					if (changed.Any())
					{
						foreach (var c in changed)
						{
							var currentAccident = newConnection.tblPatientAccidents.Where(a => a.AccidentID == c.AccidentID)
								.DefaultIfEmpty().FirstOrDefault();

							if (currentAccident != null)
							{
								currentAccident.ClaimNo = c.ClaimNo;
								currentAccident.AccidentDate = c.AccidentDate;
								currentAccident.Location = c.Location;
								currentAccident.Comments = c.Comments;
								currentAccident.ClaimNoCurrent = c.ClaimNoCurrent;
							}
							//newConnection.SubmitChanges();
						}
					}

					if (deleted.Any())
					{
						foreach (var y in deleted)
						{
							newConnection.tblPatientAccidents.Attach(y);
							newConnection.tblPatientAccidents.DeleteOnSubmit(y);
						}
						//newConnection.SubmitChanges();
					}

					if (added.Any())
					{
						foreach (var y in added)
						{
							y.PatientID = patientData.PatientID;
							newConnection.tblPatientAccidents.InsertOnSubmit(y);
						}
						//newConnection.SubmitChanges();
					}
					newConnection.SubmitChanges();
					//_sourceAccidentList = entityCollectionClone.CollectionClone(editCopyAccidents);
					myPatient.PatientID = patientData.PatientID;
					
				}
				//    catch (Exception)
				//    {
				//        MessageBox.Show(@"Database not responding. Please check your connection.");
				//    }
				//}

				//newConnection.SubmitChanges();
			}
				catch (Exception)
				{

					MessageBox.Show(exceptionMessages.dbConnectionFailedException());
				}
		}

		#endregion

		#region Form view events
		private void patientLookUp_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
		{
			e.DisplayText = string.Format("{0} {1}",
				   patientLookUpView.GetRowCellValue(patientLookUpView.FocusedRowHandle, "FirstNames"),
				   patientLookUpView.GetRowCellValue(patientLookUpView.FocusedRowHandle, "LastName"));
		}
		#endregion

		#region Linq Instant Feed Back Events

		private void claimantLinqInstantFeedbackSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
		{
			((dbContextDataContext)e.Tag).Dispose();
		}

		private void claimantLinqInstantFeedbackSource_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
		{
			var newConnection = new dbContextDataContext();
			e.QueryableSource = newConnection.tblRefDoctors;
			e.Tag = newConnection;
		}

		private void patientLinqInstantFeedBackSource_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
		{
			var newConnection = new dbContextDataContext();
			e.QueryableSource = (from p in newConnection.tblPatients.DefaultIfEmpty()
								 from a in newConnection.tblPatientAddrs.Where(ad => ad.PatientID == p.PatientID).DefaultIfEmpty()
								 select new AnonPatient
								 {
									 PatientID = p.PatientID,
									 Name = p.FirstNames + " " + p.LastName,
									 FirstName = p.FirstNames,
									 LastName = p.LastName,
									 DVANumber = p.DVANumber,
									 PhysioID = p.PhysioID,
									 Sex = p.Sex,
									 BirthDate = p.BirthDate,
									 Title = p.Title,
									 PatientInActive = p.PatientInActive,
									 Comments = p.Comments,
									 Mobile = a.MobileNo,
									 HomePhone = a.HomePhone,
									 BusPhone = a.BusPhone,
									 Fax = a.FaxNo,
									 Email = a.EmailAddr,
									 Address = a.Address1,
									 Suburb = a.Address2,
									 State = a.Address3,
									 PostCode = a.Postcode,
											
		ArtificialJoint	= p.ArtificialJoint,
		CardiacPacemaker = p.CardiacPacemaker,
		Dizziness = p.Dizziness,
		Epilepsy	= p.Epilepsy,
		Family = p.Family,
		Friend	= p.Friend,
		FrontSign = p.FrontSign,
		HealthFund = p.HealthFund,
		HealthProfessional = p.HealthProfessional,
		HeartCondition = p.HeartCondition,
		Internet	= p.Internet,
		LossOfWeight = p.LossOfWeight,
		Other	= p.Other,
		RefDoctor = p.RefDoctor,
		ReferredByDoc = p.ReferredByDoc,
		Smoker = p.Smoker,
		SurgeryInThePast3Months	= p.SurgeryInThePast3Months,
		YellowPages	=p.YellowPages


								 }).Distinct();

			e.Tag = newConnection;
		}

		private void patientLinqInstantFeedBackSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
		{
			((dbContextDataContext)e.Tag).Dispose();
		}

		private void physioLinqInstantFeedBack_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
		{
			var newConnection = new dbContextDataContext();
			e.QueryableSource = newConnection.tblPhysios;
			e.Tag = newConnection;
		}

		private void physioLinqInstantFeedBack_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
		{
			((dbContextDataContext)e.Tag).Dispose();
		}

		private void postCodelinqInstantFeedbackSource_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
		{
			var newConnection = new dbContextDataContext();
			e.QueryableSource = newConnection.tblPostcodes;
			e.Tag = newConnection;
		}

		private void postCodelinqInstantFeedbackSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
		{
			((dbContextDataContext)e.Tag).Dispose();
		}

		#endregion

		private void postCodeLookUp_EditValueChanged(object sender, EventArgs e)
		{
			var currentRow = (tblPostcode)postCodeLookUpView.GetFocusedRow();

			if (currentRow != null)
			{
				stateTextEdit.Text = currentRow.State;
				postCodeTextEdit.Text = currentRow.Postcode;
				suburbTextEdit.Text = currentRow.Location;
			}
		}

		private void patientLookUp_EditValueChanged(object sender, EventArgs e)
		{
			var currentLookUp = (DevExpress.XtraEditors.SearchLookUpEdit)sender;
			var currentView = currentLookUp.Properties.View;
			var currentRow = (AnonPatient)patientLookUpView.GetFocusedRow();

			if ((currentRow != null) && (patientLookUp.EditValue != null))
			{
				MessageBox.Show(currentRow.RefDoctor.ToString());
				//var newConnection = new dbContextDataContext();
				//var patientData = (from a in newConnection.tblPatientAddrs.Where(ad => ad.PatientID == currentRow.PatientID).DefaultIfEmpty()
				//                   select new AnonPatient
				//                   {
				//                       PatientID = currentRow.PatientID,
				//                       Name = currentRow.FirstName + " " + currentRow.LastName,
				//                       FirstName = currentRow.FirstName,
				//                       LastName = currentRow.LastName,
				//                       DVANumber = currentRow.DVANumber,
				//                       PhysioID = currentRow.PhysioID,
				//                       Sex = currentRow.Sex,
				//                       BirthDate = currentRow.BirthDate,
				//                       Title = currentRow.Title,
				//                       PatientInActive = currentRow.PatientInActive,
				//                       Comments = currentRow.Comments,
				//                       Mobile = a.MobileNo,
				//                       HomePhone = a.HomePhone,
				//                       BusPhone = a.BusPhone,
				//                       Fax = a.FaxNo,
				//                       Email = a.EmailAddr,
				//                       Address = a.Address1,
				//                       Suburb = a.Address2,
				//                       State = a.Address3,
				//                       PostCode = a.Postcode,
				//                   }).Distinct().FirstOrDefault();

				//if (patientData != null)
				//{
				actionStateLabelControl.Text = @"Editing/Viewing Existing Patient";
				actionStateLabelControl.BackColor = System.Drawing.Color.LightBlue;
				myPatient = entityClone.Clone(currentRow);
				editCopyPatient = entityClone.Clone(myPatient);
				
				//refDocLookUp.EditValue = null;
				//}

			}

			else
			{
				currentRow = new AnonPatient();
				myPatient = entityClone.Clone(currentRow);
				editCopyPatient = entityClone.Clone(myPatient);
				refDocLookUp.EditValue = null;
			}


			updateDetails();
			_sourceClaimantList.Clear();
			_sourceAccidentList.Clear();
			editCopyAccidents.Clear();
			editCopyClaimants.Clear();
			
			updateClaimantAccidents();
		}

		private void newPatientBtn_Click(object sender, EventArgs e)
		{
			newPatient();
		}

		private void newPatientViewForm_Load(object sender, EventArgs e)
		{
			//patientLookUp.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.FindClick;
			//patientLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
			//postCodeLookUp.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.FindClick;
			//postCodeLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
			//physioLookUp.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.FindClick;
			//physioLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
			okBtn.Visible = false;
			quitBtn.Visible = false;
		}

		private void claimantTabPage_Enter(object sender, EventArgs e)
		{

		}

		private void claimantTabPage_Click(object sender, EventArgs e)
		{

		}

		private void patientPresentTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
		{
			updateClaimantAccidents();
		}

		private void newOkBtn_Click(object sender, EventArgs e)
		{
			this.commitChanges();
			this.Close();
		}

		private void applyBtn_Click(object sender, EventArgs e)
		{
			commitChanges();
			if (this.DialogResult == DialogResult.OK)
			{
				MessageBox.Show("Changes saved.");
				this.DialogResult = DialogResult.Retry;
			}

		}

		private void newQuitBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void accidentGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			var foo = (tblPatientAccident)accidentGridView.GetRow(e.RowHandle);
			foo.PatientID = myPatient.PatientID;
		}

		private void accidentGridView_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				editCopyAccidents.Remove((tblPatientAccident)accidentGridView.GetFocusedRow());
			}
		}

		private void claimantDeleteBtn_Click(object sender, EventArgs e)
		{
			var row = (tblClaimant)claimantGridView.GetFocusedRow();
			if (row != null)
			{
				editCopyClaimants.Remove(row);
			}
		}

		private void claimantAddBtn_Click(object sender, EventArgs e)
		{
			var form = new Accounting.Invoice.claimantSelectViewForm();
			form.ShowDialog();
			if(form.DialogResult == DialogResult.OK)
			{
				editCopyClaimants.Add(form.myClaimant);
			}
		}

		private void ReferralCheckListBox_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
		{
			if ((referralCheckListBox.Items[7].CheckState == CheckState.Unchecked ) && (referralCheckListBox.SelectedIndex == 7))
			{
				refDocLookUp.EditValue = null;
				editCopyPatient.RefDoctor = null;
			}

			
		}

		private void refDocLookUp_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
		{
			e.DisplayText = string.Format("{0} {1}",
	   refDoctorLookUpView.GetRowCellValue(patientLookUpView.FocusedRowHandle, "RefDFNames"),
	   patientLookUpView.GetRowCellValue(patientLookUpView.FocusedRowHandle, "RefDName"));
		}

		private void refDocLookUp_EditValueChanged(object sender, EventArgs e)
		{
			if (refDocLookUp.EditValue != null)
			{
				editCopyPatient.RefDoctor = (int)refDocLookUp.EditValue;
				referralCheckListBox.Items[7].CheckState = CheckState.Checked;
				
			}
			else
			{
				editCopyPatient.RefDoctor = null;
			}


		}

		private void sendEmailBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("mailto:" + emailTextEdit.Text +"?subject=" + "Fairfield Physio" + @"&body=Dear "  + 
			_sourcePatient.Title + @" " + _sourcePatient.FirstName + " " + _sourcePatient.LastName + Environment.NewLine);
		}

		private void invoiceBtn_Click(object sender, EventArgs e)
		{
			var currentRow = (tblClaimant)claimantGridView.GetFocusedRow();

			if (currentRow != null)
			{
				var foo = new Accounting.Invoice.invoiceController();
				foo.myClaimant = currentRow;
				foo.newInvoice();
			}
			else
			{
				MessageBox.Show("Please select a claimant.");
			}
		}

	}

	// Custom comparer for the Product class
	public class ProductComparer : IEqualityComparer<tblPatientAccident>
	{
		// Products are equal if their names and product numbers are equal.
		public bool Equals(tblPatientAccident x, tblPatientAccident y)
		{

			//Check whether the compared objects reference the same data.
			if (Object.ReferenceEquals(x, y)) return true;

			//Check whether any of the compared objects is null.
			if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
				return false;

			//Check whether the products' properties are equal.
			return x.ClaimNo == y.ClaimNo || x.AccidentDate == y.AccidentDate || x.Location == y.Location
				|| x.Comments == y.Comments;
		}

		// If Equals() returns true for a pair of objects 
		// then GetHashCode() must return the same value for these objects.

		public int GetHashCode(tblPatientAccident product)
		{
			//Check whether the object is null
			if (Object.ReferenceEquals(product, null)) return 0;

			//Get hash code for the Name field if it is not null.
			int hashProductName = product.ClaimNo == null ? 0 : product.ClaimNo.GetHashCode();

			//Calculate the hash code for the product.
			return hashProductName;
		}

	}

	// Custom comparer for the Product class
	public class changedComparer : IEqualityComparer<tblPatientAccident>
	{
		// Products are equal if their names and product numbers are equal.
		public bool Equals(tblPatientAccident x, tblPatientAccident y)
		{
			//Check whether the compared objects reference the same data.
			if (Object.ReferenceEquals(x, y)) return true;

			//Check whether any of the compared objects is null.
			if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
				return false;

			//Check whether the products' properties are equal.
			return (x.AccidentID == y.AccidentID) && (x.ClaimNo == y.ClaimNo) && (x.AccidentDate == y.AccidentDate) && (x.Location == y.Location)
					  && (x.Comments == y.Comments);
		}

		// If Equals() returns true for a pair of objects 
		// then GetHashCode() must return the same value for these objects.

		public int GetHashCode(tblPatientAccident accident)
		{
			//Check whether the object is null
			if (Object.ReferenceEquals(accident, null)) return 0;

			int claimNoHash = accident.ClaimNo == null ? 0 : accident.ClaimNo.GetHashCode();
			int accidentIDHash = accident.AccidentID.GetHashCode();
			int accidentComment = accident.AccidentDate == null ? 0 : accident.AccidentDate.GetHashCode();
			int accidentLocation = accident.Location == null ? 0 : accident.Location.GetHashCode();
			int accidentCurrent = accident.ClaimNoCurrent.GetHashCode();

			//Calculate the hash code for the accident object.
			return claimNoHash ^ accidentIDHash ^ accidentComment ^ accidentLocation ^ accidentCurrent;
		}

	}
}
