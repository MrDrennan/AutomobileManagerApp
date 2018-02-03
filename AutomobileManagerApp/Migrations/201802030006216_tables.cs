namespace AutomobileManagerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerId = c.Byte(nullable: false),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.OwnerId);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleId = c.Byte(nullable: false),
                        Name = c.String(),
                        Make = c.String(),
                        Model = c.String(),
                        Year = c.DateTime(nullable: false),
                        Engine = c.String(),
                        Owner_OwnerId = c.Byte(),
                    })
                .PrimaryKey(t => t.VehicleId)
                .ForeignKey("dbo.Owners", t => t.Owner_OwnerId)
                .Index(t => t.Owner_OwnerId);
            
            CreateTable(
                "dbo.RepairUpgradeLogs",
                c => new
                    {
                        RepairUpgradeLogId = c.Short(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Cost = c.Double(),
                        Notes = c.String(),
                        Vehicle_VehicleId = c.Byte(),
                    })
                .PrimaryKey(t => t.RepairUpgradeLogId)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_VehicleId)
                .Index(t => t.Vehicle_VehicleId);
            
            CreateTable(
                "dbo.Parts",
                c => new
                    {
                        PartId = c.Short(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Cost = c.Double(),
                        DatePurchased = c.DateTime(nullable: false),
                        Warranty = c.String(),
                        Notes = c.String(),
                        RepairUpgradeLog_RepairUpgradeLogId = c.Short(),
                        ServiceLog_ServiceLogId = c.Short(),
                    })
                .PrimaryKey(t => t.PartId)
                .ForeignKey("dbo.RepairUpgradeLogs", t => t.RepairUpgradeLog_RepairUpgradeLogId)
                .ForeignKey("dbo.ServiceLogs", t => t.ServiceLog_ServiceLogId)
                .Index(t => t.RepairUpgradeLog_RepairUpgradeLogId)
                .Index(t => t.ServiceLog_ServiceLogId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Short(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        MonthInterval = c.Byte(nullable: false),
                        NextDueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.ServiceLogs",
                c => new
                    {
                        ServiceLogId = c.Short(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Cost = c.Double(),
                        Notes = c.String(),
                        Service_ServiceId = c.Short(),
                    })
                .PrimaryKey(t => t.ServiceLogId)
                .ForeignKey("dbo.Services", t => t.Service_ServiceId)
                .Index(t => t.Service_ServiceId);
            
            CreateTable(
                "dbo.ServiceVehicles",
                c => new
                    {
                        Service_ServiceId = c.Short(nullable: false),
                        Vehicle_VehicleId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_ServiceId, t.Vehicle_VehicleId })
                .ForeignKey("dbo.Services", t => t.Service_ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_VehicleId, cascadeDelete: true)
                .Index(t => t.Service_ServiceId)
                .Index(t => t.Vehicle_VehicleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "Owner_OwnerId", "dbo.Owners");
            DropForeignKey("dbo.ServiceVehicles", "Vehicle_VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.ServiceVehicles", "Service_ServiceId", "dbo.Services");
            DropForeignKey("dbo.ServiceLogs", "Service_ServiceId", "dbo.Services");
            DropForeignKey("dbo.Parts", "ServiceLog_ServiceLogId", "dbo.ServiceLogs");
            DropForeignKey("dbo.RepairUpgradeLogs", "Vehicle_VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Parts", "RepairUpgradeLog_RepairUpgradeLogId", "dbo.RepairUpgradeLogs");
            DropIndex("dbo.ServiceVehicles", new[] { "Vehicle_VehicleId" });
            DropIndex("dbo.ServiceVehicles", new[] { "Service_ServiceId" });
            DropIndex("dbo.ServiceLogs", new[] { "Service_ServiceId" });
            DropIndex("dbo.Parts", new[] { "ServiceLog_ServiceLogId" });
            DropIndex("dbo.Parts", new[] { "RepairUpgradeLog_RepairUpgradeLogId" });
            DropIndex("dbo.RepairUpgradeLogs", new[] { "Vehicle_VehicleId" });
            DropIndex("dbo.Vehicles", new[] { "Owner_OwnerId" });
            DropTable("dbo.ServiceVehicles");
            DropTable("dbo.ServiceLogs");
            DropTable("dbo.Services");
            DropTable("dbo.Parts");
            DropTable("dbo.RepairUpgradeLogs");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Owners");
        }
    }
}
