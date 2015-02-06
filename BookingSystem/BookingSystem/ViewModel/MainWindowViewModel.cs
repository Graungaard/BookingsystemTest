// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindowViewModel.cs" company="Something">
//   Jacob H. Graungaard
// </copyright>
// <summary>
//   The main window view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookingClient.ViewModel
{
    using System.Collections.Generic;
    using System.Linq;
    using BookingClient.View;
    using ClassLibrary;

    /// <summary>
    /// The main window view model.
    /// </summary>
    public class MainWindowViewModel : viewModel
    {
        #region Fields

        /// <summary>
        /// The change page command.
        /// </summary>
        private ActionCommand changePageCommand;

        /// <summary>
        /// The currentp page view model.
        /// </summary>
        private IPageViewModel currentpPageViewModel;

        /// <summary>
        /// The page view models.
        /// </summary>
        private List<IPageViewModel> pageViewModels;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            this.PageViewModels.Add(new OverViewViewModel());
            this.PageViewModels.Add(new StaffViewModel());
            this.PageViewModels.Add(new TreatmentViewModel());

            this.CurrentPageViewModel = this.PageViewModels[0];
        }
         

        #region Properties / Commands

        /// <summary>
        /// Gets or sets the change page command.
        /// </summary>
        public ActionCommand ChangePageCommand
        {
            get
            {
                if (this.changePageCommand == null)
                {
                    this.changePageCommand = new ActionCommand(p => this.ChangeViewModel((IPageViewModel)p), p => p is IPageViewModel);
                }

                return this.changePageCommand;
            }

            set
            {
                this.changePageCommand = value;
            }
        }

        /// <summary>
        /// Gets the page view models.
        /// </summary>
        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (this.pageViewModels == null)
                {
                    this.pageViewModels = new List<IPageViewModel>();
                }

                return this.pageViewModels;
            }
        }

        /// <summary>
        /// Gets or sets the current page view model.
        /// </summary>
        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return this.currentpPageViewModel;
            }

            set
            {
                if (this.currentpPageViewModel != value)
                {
                    this.currentpPageViewModel = value;
                    this.NotifyPropertyChanged("CurrentPageViewModel");
                }
            }
        }        
        #endregion

        #region Methods

        /// <summary>
        /// The change view model.
        /// </summary>
        /// <param name="viewModel">
        /// The view model.
        /// </param>
        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!this.PageViewModels.Contains(viewModel))
            {
                this.PageViewModels.Add(viewModel);
            }

            this.CurrentPageViewModel = this.PageViewModels.FirstOrDefault(vm => vm == viewModel);
        }

        #endregion
    }
}
