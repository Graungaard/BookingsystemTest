// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StaffModel.cs" company="Something">
//   Jacob Graungaard
// </copyright>
// <summary>
//   Defines the StaffModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Data.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// The staff model.
    /// </summary>
    public class StaffModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the treatments list.
        /// </summary>
        public virtual IList<TreatmentModel> TreatmentsList { get; set; } 

        /// <summary>
        /// Gets or sets the staff appointmentses.
        /// </summary>
        public virtual IList<StaffAppointments> StaffAppointmentses { get; set; }
    }
}
