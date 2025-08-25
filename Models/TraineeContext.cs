using Microsoft.EntityFrameworkCore; // Needed for DbContext
namespace WebAppTrainees.Models
{
    public class TraineeContext: DbContext // Inherits from DbContext to interact with the database
    {
        public TraineeContext() { }
        public TraineeContext(DbContextOptions<TraineeContext> options) : base(options) { }
        //static string connectionString = @"Data Source=IBM-DJC3SB4\SQLEXPRESS;Initial Catalog=TraineeDB;TrustServerCertificate=True;Integrated Security=True;"; // Static field to hold the connection string
        public DbSet<Trainee> Trainees { get; set; } = null!; // DbSet for Trainee entities

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) // Check if options are already configured
            {
                base.OnConfiguring(optionsBuilder); // Call the base method to ensure proper configuration
                //optionsBuilder.UseSqlServer(connectionString); // Use SQL Server with the connection string
            }
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainee>().ToTable("Trainees"); // Map the Trainee entity to the "Trainees" table
            base.OnModelCreating(modelBuilder); // Call the base method to apply configurations
        }*/    

    }
}
