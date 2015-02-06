// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreatmentViewModel.cs" company="Something">
//   Jacob H. Graungaard
// </copyright>
// <summary>
//   Defines the TreatmentViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookingClient.ViewModel
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Data;

    using BookingClient.View.TreatmentViews;

    using ClassLibrary;

    using Data;
    using Data.Model;

    /// <summary>
    /// The treatment view model.
    /// </summary>
    public class TreatmentViewModel : viewModel, IPageViewModel
    {
        #region Fields

        private string success;

        /// <summary>
        /// The child view model.
        /// </summary>
        private TreatmentViewModel childViewModel;
        
        /// <summary>
        /// The treatment name.
        /// </summary>
        private string treatmentName;

        /// <summary>
        /// The treatment length.
        /// </summary>
        private int treatmentLength;

        /// <summary>
        /// The treatment types.
        /// </summary>
        private MyObservableCollection<TreatmentModel> treatmentTypes;

        /// <summary>
        /// The selected treatment.
        /// </summary>
        private TreatmentModel selectedTreatment = new TreatmentModel();

        #endregion

        #region Initializes a new instance

        /// <summary>
        /// Initializes a new instance of the <see cref="TreatmentViewModel"/> class.
        /// </summary>
        public TreatmentViewModel()
        {
            this.childViewModel = this;
            this.treatmentTypes = new MyObservableCollection<TreatmentModel>();
            try
            {
                var bc = new BusinessContext();
                foreach (TreatmentModel treatment in bc.GetAllTreatments())
                {
                    this.TreatmentTypes.Add(treatment);
                }
            }
            catch (Exception)
            {
                
            }
        }

        #endregion

        #region properties

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
        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name 
        {
            get
            {
                return " Treatments ";
            }
        }

        /// <summary>
        /// Gets or sets the treatment.
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
        /// Gets or sets the treatment length.
        /// </summary>
        public int TreatmentLength
        {
            get
            {
                return this.treatmentLength;
            }

            set
            {
                this.treatmentLength = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the treatment types.
        /// </summary>
        public MyObservableCollection<TreatmentModel> TreatmentTypes
        {
            get
            {
                return this.treatmentTypes;
            }

            set
            {
                this.TreatmentTypes = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the selected treatment.
        /// </summary>
        public TreatmentModel SelectedTreatment
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

        #endregion

        #region ActionCommands

        /// <summary>
        /// Gets the create treatment command.
        /// </summary>
        public ActionCommand CreateTreatmentCommand
        {
            get
            {
                return new ActionCommand(s => this.CreateTreatment(), s => true);
            }
        }

        /// <summary>
        /// Gets the add treatment command.
        /// </summary>
        public ActionCommand AddTreatmentCommand
        {
            get
            {
                return new ActionCommand(s => this.AddTreatment(this.TreatmentName), s => true);

            }
        }

        /// <summary>
        /// Gets the edit treatment command.
        /// </summary>
        public ActionCommand<TreatmentModel> EditTreatmentCommand
        {
            get
            {
                return new ActionCommand<TreatmentModel>(s => this.EditTreatment(), s => true);
            }
        }

        /// <summary>
        /// Gets the save treamtent command.
        /// </summary>
        public ActionCommand<TreatmentModel> SaveTreamtentCommand
        {
            get
            {
                return new ActionCommand<TreatmentModel>(s => this.SaveTreatment(this.SelectedTreatment));
            }
        }

        /// <summary>
        /// Gets the delete treament command.
        /// </summary>
        public ActionCommand<TreatmentModel> DeleteTreatmentCommand
        {
            get
            {
                return new ActionCommand<TreatmentModel>(s => this.DeleteTreatment(this.SelectedTreatment), s => true);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The create treatment.
        /// </summary>
        private void CreateTreatment()
        {
            var view = new CreatTreatmentView { DataContext = this.childViewModel };
            view.Show();
        }

        /// <summary>
        /// The edit treatment.
        /// </summary>
        private void EditTreatment()
        {
            var view = new EditTreatmentView { DataContext = this.childViewModel };
            view.Show();
        }

        /// <summary>
        /// The add treatment.
        /// </summary>
        /// <param name="treatmentName">
        /// The treatment name.
        /// </param>
        private void AddTreatment(string treatmentName)
        {
            using (var api = new BusinessContext())
            {
                
                var treatment = new TreatmentModel { TreatmentName = treatmentName};
                try
                {
                    api.AddNewTreatment(treatment);
                }
                catch (Exception)
                {
                    Console.WriteLine("api.addNew failed");
                }

                this.Success = "Treatment " + this.TreatmentName + " added";
                this.TreatmentTypes.Add(treatment);
            }
        }

        /// <summary>
        /// The save treatment.
        /// </summary>
        /// <param name="treatment">
        /// The treatment.
        /// </param>
        private void SaveTreatment(TreatmentModel treatment)
        {
            using (var api = new BusinessContext())
            {
                try
                {
                    var tmpTreatment = api.GetAllTreatmentsById(treatment.Id);
                    tmpTreatment.TreatmentName = treatment.TreatmentName;
                    
                    api.EditTreatment(tmpTreatment);
                }
                catch (Exception)
                {
                    
                }
                this.Success = "Treatment " + this.TreatmentName + " Saved!";
                int index = this.treatmentTypes.IndexOf(treatment);
                this.treatmentTypes.ReplaceItem(index, treatment);
            }
        }

        /// <summary>
        /// The delete treatment.
        /// </summary>
        /// <param name="treatment">
        /// The treatment.
        /// </param>
        private void DeleteTreatment(TreatmentModel treatment)
        {
            using (var api = new BusinessContext())
            {
                try
                {
                    var tmpTreatment = api.GetAllTreatmentsById(treatment.Id);
                    api.DeleteTreatment(tmpTreatment);
                }
                catch (Exception)
                {
                    
                }
                this.TreatmentTypes.Remove(treatment);
            }
        }
        #endregion
    }
}
