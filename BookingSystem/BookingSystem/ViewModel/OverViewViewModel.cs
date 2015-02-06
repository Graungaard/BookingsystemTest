using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingClient.ViewModel
{
    using System.Windows.Controls;
    using System.Windows.Documents;

    using BookingClient.View;

    using ClassLibrary;

    using Data;
    using Data.Model;

    /// <summary>
    /// The test view model.
    /// </summary>
    public class OverViewViewModel : viewModel, IPageViewModel
    {

        #region Fields

        private string subject = "Dette er en test";

        private string location;

        private string body;

        private DateTime startTime;

        private DateTime endTime;

        private DateTime currentDate = DateTime.Today;
     
        private DateTime selectedDate;

        private OverViewViewModel chieldViewModel;

        private MyObservableCollection<Appointment> appointments;

          

        #endregion

        public OverViewViewModel()
        {
            this.chieldViewModel = this;
            this.appointments = new MyObservableCollection<Appointment>();
            try
            {
                var bc = new BusinessContext();
                foreach (Appointment appointment in bc.GetAllAppointments())
                {
                    this.appointments.Add(appointment);
                }
            }
            catch (Exception)
            {
                
            }
        }

        #region properties

        public string Name
        {
            get
            {
                return " Overview ";
            } 
        }

        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                this.subject = value;
                this.NotifyPropertyChanged();
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
                this.NotifyPropertyChanged();
            }
        }

        public string Body
        {
            get
            {
                return this.body;
            }
            set
            {
                this.body = value;
                this.NotifyPropertyChanged();
            }
        }

        public DateTime SelectedDate
        {
            get
            {
                return this.selectedDate;
            }
            set
            {
                this.selectedDate = value;
                this.NotifyPropertyChanged();
            }
        }

        public DateTime CurrenDate
        {
            get
            {
                return this.currentDate;
            }
            set
            {
                this.currentDate = value;
                this.NotifyPropertyChanged();
            }
        }

        public DateTime StartTime
        {
            get
            {
                return this.startTime;
            }
            set
            {
                this.startTime = value;
                this.NotifyPropertyChanged();
            }
        }

        public DateTime EndTime
        {
            get
            {
                return this.endTime;
            }

            set
            {
                this.endTime = value;
            }
        }

        public MyObservableCollection<Appointment> Appointments
        {
            get
            {
                return this.appointments;
            }
            set
            {
                this.appointments = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region ActionCommands

        public ActionCommand OpenCreateAppointmentActionCommand
        {
            get
            {
                return new ActionCommand(s => this.OpenCreateAppointment(), s => true);
            }
        }

        public ActionCommand AddApointmentActionCommand
        {
            get
            {
                return new ActionCommand(s => this.AddAppointment(this.Subject, this.Location, this.StartTime, this.EndTime, this.Body), s => true);
            }
        }

        #endregion

        #region Methods

        private void OpenCreateAppointment()
            {
                var view = new AddAppointmentView { DataContext = this.chieldViewModel };
                view.Show();
            }

        private void AddAppointment(string subject, string location, DateTime startTime, DateTime endTime, string body)
        {
            using (var api = new BusinessContext())
            { 
                var appointment = new Appointment {Subject = subject, Location = location, StartTime = startTime, EndTime = endTime, Body = body}
                ;
                try
                {
                    api.AddNewAppointment(appointment);
                }
                catch (Exception)
                {
                    Console.WriteLine("Api arror by appointments");
                }

                this.appointments.Add(appointment);
            }
        }

        #endregion


    }
}
