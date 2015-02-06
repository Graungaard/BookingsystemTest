// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Something">
//   Jacob H. Graungaard
// </copyright>
// <summary>
//   Interaction logic for App.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookingClient
{
    using System.Windows;
    using BookingClient.View;
    using BookingClient.ViewModel;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// The on startup.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override void OnStartup(StartupEventArgs e)
       {
            base.OnStartup(e);

            var app = new MainWindow();
            var context = new MainWindowViewModel();
            app.DataContext = context;
            app.Show();
        }
    }
}
