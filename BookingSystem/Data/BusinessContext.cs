// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BusinessContext.cs" company="Something">
//   Jacob Graungaard
// </copyright>
// <summary>
//   Defines the BusinessContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects.DataClasses;
    using System.Linq;

    using Data.Model;

    /// <summary>
    /// The business context.
    /// </summary>
    public sealed class BusinessContext : IDisposable
    {
        /// <summary>
        /// The context.
        /// </summary>
        private readonly DataContext context;

        /// <summary>
        /// The disposed.
        /// </summary>
        private bool disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessContext"/> class.
        /// </summary>
        public BusinessContext()
        {
            this.context = new DataContext();
        }

        /// <summary>
        /// Gets the data context.
        /// </summary>
        public DataContext DataContext
        {
            get
            {
                return this.context;
            }
        }

        #region Treatment Logic

        /// <summary>
        /// The get all treatments.
        /// </summary>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public IQueryable<TreatmentModel> GetAllTreatments()
        {
            return this.context.Treatments;
        }

        /// <summary>
        /// The get all treatments by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="TreatmentModel"/>.
        /// </returns>
        public TreatmentModel GetAllTreatmentsById(int? id)
        {
            return this.context.Treatments.Find(id);
        }

        /// <summary>
        /// The add new treatments.
        /// </summary>
        /// <param name="treatments">
        /// The treatments.
        /// </param>
        public void AddNewTreatment(TreatmentModel treatments)
        {
            Check.Require(treatments.TreatmentName);
            this.context.Treatments.Add(treatments);
            this.context.SaveChanges();
        }

        /// <summary>
        /// The edit treatments.
        /// </summary>
        /// <param name="treatments">
        /// The treatments.
        /// </param>
        public void EditTreatment(TreatmentModel treatments)
        {
            Check.Require(treatments.TreatmentName);
            this.context.Entry(treatments).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        /// <summary>
        /// The delete treatment.
        /// </summary>
        /// <param name="treatments">
        /// The treatments.
        /// </param>
        public void DeleteTreatment(TreatmentModel treatments)
        {
            this.context.Treatments.Remove(treatments);
            this.context.SaveChanges();
        }





        #endregion

        #region StaffMemberLogic

        /// <summary>
        /// The get all staff members.
        /// </summary>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public IQueryable<StaffModel> GetAllStaffMembers()
        {
            return this.context.StaffMembers;
        }

        /// <summary>
        /// The get staff members by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="StaffModel"/>.
        /// </returns>
        public StaffModel GetStaffMembersById(int? id)
        {
            return this.context.StaffMembers.Find(id);
        }

        /// <summary>
        /// The add new staff member.
        /// </summary>
        /// <param name="staff">
        /// The staff.
        /// </param>
        public void AddNewStaffMember(StaffModel staff)
        {
            Check.Require(staff.FirstName);
            Check.Require(staff.LastName);
            this.context.StaffMembers.Add(staff);
            this.context.SaveChanges();
        }

        /// <summary>
        /// The edit staff member.
        /// </summary>
        /// <param name="staff">
        /// The staff.
        /// </param>
        public void EditStaffMember(StaffModel staff)
        {
            Check.Require(staff.FirstName);
            Check.Require(staff.LastName);
            this.context.Entry(staff).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        /// <summary>
        /// The delete staff member.
        /// </summary>
        /// <param name="staff">
        /// The staff.
        /// </param>
        public void DeleteStaffMember(StaffModel staff)
        {
            this.context.StaffMembers.Remove(staff);
            this.context.SaveChanges();
        }

        #endregion

#region Appointments logic

        public IQueryable<Appointment> GetAllAppointments()
        {
            return this.context.Appointments;
        }

        public Appointment GetAppointmentsById(int? id)
        {
            return this.context.Appointments.Find(id);
        }

        public void AddNewAppointment(Appointment appointment)
        {
            Check.Require(appointment.Subject);
            Check.Require(appointment.Body);
            this.context.Appointments.Add(appointment);
            this.context.SaveChanges();
        }

        public void EditAppointment(Appointment appointment)
        {
            Check.Require(appointment.Subject);
            Check.Require(appointment.Body);
            this.context.Entry(appointment).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteAppointment(Appointment appointment)
        {
            this.context.Appointments.Remove(appointment);
            this.context.SaveChanges();
        }


#endregion


        #region TheCheck
        /// <summary>
        /// The check.
        /// </summary>
        internal static class Check
        {
            /// <summary>
            /// The require.
            /// </summary>
            /// <param name="value">
            /// The value.
            /// </param>
            /// <exception cref="ArgumentNullException">
            /// If Argument is non existent
            /// </exception>
            /// <exception cref="ArgumentException">
            /// Ïf Argument is invalid
            /// </exception>
            public static void Require(string value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException();
                }
            }

            /// <summary>
            /// The require int.
            /// </summary>
            /// <param name="value">
            /// The value.
            /// </param>
            /// <exception cref="ArgumentNullException">
            /// </exception>
            /// <exception cref="ArgumentException">
            /// </exception>
            public static void RequireInt(int value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                if (value.Equals(0))
                {
                    throw new ArgumentException();
                }
            }
        }
        #endregion

        #region Idisposable Members

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        /// <param name="disposing">
        /// The disposing.
        /// </param>
        private void Dispose(bool disposing)
        {
            if (this.disposed || !disposing)
            {
                return;
            }

            if (this.context != null)
            {
                this.context.Dispose();
            }

            this.disposed = true;
        }
        #endregion
    }
}
