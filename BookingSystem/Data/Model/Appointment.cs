// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Appointment.cs" company="Something">
//   Jacob Graungaard
// </copyright>
// <summary>
//   Defines the Appointment type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Data.Model
{
    using System;

    /// <summary>
    /// The appointment.
    /// </summary>
    public class Appointment 
    {
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return this.Subject;
        }

    }
}
