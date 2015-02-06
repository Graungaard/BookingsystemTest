// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StaffViewModel.cs" company="Something">
//   Jacob H. Graungaard
// </copyright>
// <summary>
//   Defines the StaffViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookingClient.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Documents;

    using BookingClient.View;
    using System.Diagnostics.CodeAnalysis;

    using ClassLibrary;

    using Data;
    using Data.Model;

    /// <summary>
    /// The staff view model.
    /// </summary>
    public class StaffViewModel : viewModel, IPageViewModel
    {
        #region Fields

        /// <summary>
        /// The selected treatment.
        /// </summary>
        private TreatmentModel selectedTreatment = new TreatmentModel();

        /// <summary>
        /// The treatment name.
        /// </summary>
        private string treatmentName;

        /// <summary>
        /// The treatment list.
        /// </summary>
        private MyObservableCollection<TreatmentModel> treatmentList;

        /// <summary>
        /// The child view model.
        /// </summary>
        private StaffViewModel childViewModel;

        /// <summary>
        /// The first name.
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name.
        /// </summary>
        private string lastName;

        /// <summary>
        /// The success.
        /// </summary>
        private string success;

        /// <summary>
        /// The staff.
        /// </summary>
        private MyObservableCollection<StaffModel> staffMembers;

        /// <summary>
        /// The selected staff.
        /// </summary>
        private StaffModel selectedStaff = new StaffModel();

        #endregion

        #region Initializes a new instance of the <see cref="StaffViewModel"/> class.
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffViewModel"/> class.
        /// </summary>
        public StaffViewModel()
        {
            this.childViewModel = this;
            this.staffMembers = new MyObservableCollection<StaffModel>();
            try
            {
                var bc = new BusinessContext();
                foreach (StaffModel staff in bc.GetAllStaffMembers())
                {
                    this.StaffMembers.Add(staff);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Console.WriteLine("test");
            }
        }
        #endregion

        #region Properties
        #region treatments properties
        /// <summary>
        /// Gets or sets the seleceted treatment.
        /// </summary>
        public TreatmentModel SelecetedTreatment
        {
            get
            {
                return this.selectedTreatment;
            }

            set
            {
                this.selectedTreatment = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the treatment name.
        /// </summary>
        public string TreatmentName
        {
            get
            {
                return this.treatmentName;
            }

            set
            {
                this.treatmentName = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the treatment list.
        /// </summary>
        public MyObservableCollection<TreatmentModel> TreatmentList
        {
            
            get
            {
                return this.treatmentList;
            }

            set
            {
                this.treatmentList = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion
        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return " Staff ";
            }
        }
        #region staff properties
        /// <summary>
        /// Gets or sets the staff members.
        /// </summary>
        public MyObservableCollection<StaffModel> StaffMembers
        {
            get
            {
                return this.staffMembers;
            }

            set
            {
                this.staffMembers = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the seleceted staff.
        /// </summary>
        public StaffModel SelecetedStaff
        {
            get
            {
                return this.selectedStaff;
            }

            set
            {
                this.selectedStaff = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value != this.firstName)
                {
                    this.firstName = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value != this.lastName)
                {
                    this.lastName = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public string Success
        {
            get
            {
                return this.success;
            }

            set
            {
                this.success = value;
                this.NotifyPropertyChanged();
            }
        }
        #endregion
        #endregion

        #region Commands

        /// <summary>
        /// Gets the create staff member command.
        /// </summary>
        public ActionCommand CreateStaffMemberCommand
        {
            get
            {
                return new ActionCommand(s => this.CreateStaffMember(), s => true);
            }
        }

        /// <summary>
        /// Gets the add staff member command.
        /// </summary>
        public ActionCommand AddStaffMemberCommand
        {
            get
            {
                return new ActionCommand(s => this.AddStaffMember(this.FirstName, this.LastName), s => true);
            }
        }

        /// <summary>
        /// Gets the edit staff member command.
        /// </summary>
        public ActionCommand<StaffModel> EditStaffMemberCommand
        {
            get
            {
                return new ActionCommand<StaffModel>(s => this.EditStaffMember(), s => true);
            }
        }

        /// <summary>
        /// Gets the save staff member command.
        /// </summary>
        public ActionCommand<StaffModel> SaveStaffMemberCommand
        {
            get
            {
                return new ActionCommand<StaffModel>(s => this.SaveStaffMember(this.SelecetedStaff), s => true);
            }
        }

        /// <summary>
        /// Gets the delete staff member command.
        /// </summary>
        public ActionCommand<StaffModel> DeleteStaffMemberCommand
        {
            get
            {
                return new ActionCommand<StaffModel>(s => this.DeleteStaffMember(this.SelecetedStaff), s => true);
            }
        }

        /// <summary>
        /// Gets a value indicating whether is valid.
        /// </summary>
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrWhiteSpace(this.FirstName) && !string.IsNullOrWhiteSpace(this.LastName);
            }
        }

        #endregion

        #region Methods

        private void CreateStaffMember()
        {
            var view = new CreateStaffMemberView { DataContext = this.childViewModel };
            this.treatmentList = new MyObservableCollection<TreatmentModel>();
            try
            {
                var bc = new BusinessContext();
                foreach (TreatmentModel treatment in bc.GetAllTreatments())
                {
                    this.treatmentList.Add(treatment);
                }
            }
            catch (Exception)
            {

            }
            view.Show();

            //TODO : Close child window on button press in view
        }

        private void EditStaffMember()
        {
            var view = new EditStaffMemberView { DataContext = this.childViewModel };
            view.ShowDialog();
            //TODO : Close child window on button press in view
        }

        private void AddStaffMember(string firstName, string lastName)
        {
            using (var api = new BusinessContext())
            {
                var staffmember = new StaffModel { FirstName = firstName, LastName = lastName};
                try
                {
                    api.AddNewStaffMember(staffmember);
                }
                catch (Exception)
                {
                    // TODO: Cover error handling
                    Console.WriteLine("APi.addNewStaffMember Failed");
                }

                this.Success = "Staff Member " + this.FirstName + " " + this.LastName + " added";
                this.StaffMembers.Add(staffmember);
            }
        }

        private void SaveStaffMember(StaffModel staff)
        {
            using (var api = new BusinessContext())
            {
                try
                {
                    var tmpStaffMember = api.GetStaffMembersById(staff.Id);
                    tmpStaffMember.FirstName = staff.FirstName;
                    tmpStaffMember.LastName = staff.LastName;
                    tmpStaffMember.TreatmentsList = staff.TreatmentsList;

                    api.EditStaffMember(tmpStaffMember);
                }
                catch (Exception)
                {
                    // TODO: Cover error handling
                }

                this.Success = "Staff Member " + this.FirstName + " " + this.LastName + " Saved!";
                int index = this.StaffMembers.IndexOf(staff);
                this.StaffMembers.ReplaceItem(index, staff);
            }
        }

        private void DeleteStaffMember(StaffModel staff)
        {
            using (var api = new BusinessContext())
            {
                try
                {
                    var tmpStaffMember = api.GetStaffMembersById(staff.Id);
                    api.DeleteStaffMember(tmpStaffMember);
                }
                catch (Exception)
                {
                    // TODO: Cover error handling
                }
                this.StaffMembers.Remove(staff);
            }




            #endregion
        }
    }
}
