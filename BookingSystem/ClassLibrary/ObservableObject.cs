// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObservableObject.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ObservableObject type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClassLibrary
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// The observable object.
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        #region NotifyMembers
        /// <summary>
        /// The property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The raise property changed.
        /// </summary>
        /// <param name="propertyName">
        /// The property name.
        /// </param>
        public virtual void RaisePropertyChanged(string propertyName)
        {
            if (propertyName != null)
            {
                this.NotifyPropertyChanged(propertyName);
            }
        }

        /// <summary>
        /// The notify property changed.
        /// </summary>
        /// <param name="propertyName">
        /// The property name.
        /// </param>
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
