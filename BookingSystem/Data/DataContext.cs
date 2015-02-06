// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataContext.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DataContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Data
{
    using System.Data.Entity;

    using Data.Model;

    /// <summary>
    /// The data context.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
      
        public DataContext() : base("BookingSystemDB")
        {
        }
        
        /// <summary>
        /// Gets or sets the staffs.
        /// </summary>
        public DbSet<StaffModel> StaffMembers { get; set; }

        /// <summary>
        /// Gets or sets the clients.
        /// </summary>
        public DbSet<ClientModel> Clients { get; set; }

        /// <summary>
        /// Gets or sets the appointments.
        /// </summary>
        public DbSet<StaffAppointments> Appointments2 { get; set; }

        /// <summary>
        /// Gets or sets the treatments.
        /// </summary>
        public DbSet<TreatmentModel> Treatments { get; set; }

        /// <summary>
        /// Gets or sets the appointments.
        /// </summary>
        public DbSet<Appointment> Appointments { get; set; }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
         
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffAppointments>()
                .HasKey(t => new { t.StaffId, t.TreatmentId });

            modelBuilder.Entity<StaffTreamentModel>()
                .HasKey(t => new { t.TreatmentId, t.StaffId });
           
        }
        
    }
}
