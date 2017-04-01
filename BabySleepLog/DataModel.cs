namespace BabySleepLog
{
    using Models;
    using System.Data.Entity;

    public class DataModel : DbContext
    {
        // Your context has been configured to use a 'DataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BabySleepLog.DataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DataModel' 
        // connection string in the application configuration file.
        public DataModel()
            : base("name=DataModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Sleep> Sleeps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entry>().ToTable("Entries");
            modelBuilder.Entity<Entry>().HasKey(t => t.EntryId);
            modelBuilder.Entity<Entry>().Property(t => t.Notes).HasMaxLength(250);

            modelBuilder.Entity<Sleep>().ToTable("Sleeps");
            modelBuilder.Entity<Sleep>().HasKey(t => t.SleepId);
            modelBuilder.Entity<Sleep>().Property(t => t.Name).IsRequired();
        }
    }

}