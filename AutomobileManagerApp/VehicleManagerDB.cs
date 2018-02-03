namespace AutomobileManagerApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class VehicleManagerDB : DbContext
    {
        // Your context has been configured to use a 'VehicleManagerDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AutomobileManagerApp.VehicleManagerDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'VehicleManagerDB' 
        // connection string in the application configuration file.
        public VehicleManagerDB()
            : base("name=VehicleManagerDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<RepairUpgradeLog> RepairUpgradeLog  { get; set; }
        public virtual DbSet<ServiceLog> ServiceLog { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}