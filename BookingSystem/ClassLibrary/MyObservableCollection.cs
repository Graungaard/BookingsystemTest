// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyObservableCollection.cs" company="Something">
//   Jacob Graungaard
// </copyright>
// <summary>
//   Defines the MyObservableCollection type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClassLibrary
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// The my observable collection.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class MyObservableCollection<T> : ObservableCollection<T>
    {
        /// <summary>
        /// The replace item.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <param name="item">
        /// The item.
        /// </param>
        public void ReplaceItem(int index, T item)
        {
            this.SetItem(index, item);
        }
    }
}
