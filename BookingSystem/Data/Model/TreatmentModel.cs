// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreatmentModel.cs" company="Something">
//   Jacob Graungaard
// </copyright>
// <summary>
//   Defines the TreatmentModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
namespace Data.Model
{
    /// <summary>
    /// The treatment model.
    /// </summary>
    public class TreatmentModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the treatment name.
        /// </summary>
        public string TreatmentName { get; set; }
    }
}
