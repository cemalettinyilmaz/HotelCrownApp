namespace HotelCrownApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        IdentityNumber = c.String(),
                        PhoneNumber = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureId = c.Int(nullable: false, identity: true),
                        FeatureName = c.String(),
                    })
                .PrimaryKey(t => t.FeatureId);
            
            CreateTable(
                "dbo.RoomFeatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        FeatureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Features", t => t.FeatureId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId)
                .Index(t => t.FeatureId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomName = c.String(),
                        Capacity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId);
            
            CreateTable(
                "dbo.ReservationCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReservationId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: false)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: false)
                .Index(t => t.ReservationId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        CheckedInTime = c.Boolean(),
                        CheckedOutTime = c.Boolean(),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.ReservationServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReservationId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        ServiceName = c.String(),
                        UnitPrice = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ReservationId)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        UnitPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.ReservationServices", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.ReservationCustomers", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.ReservationCustomers", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.RoomFeatures", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.RoomFeatures", "FeatureId", "dbo.Features");
            DropIndex("dbo.ReservationServices", new[] { "ServiceId" });
            DropIndex("dbo.ReservationServices", new[] { "ReservationId" });
            DropIndex("dbo.Reservations", new[] { "RoomId" });
            DropIndex("dbo.ReservationCustomers", new[] { "CustomerId" });
            DropIndex("dbo.ReservationCustomers", new[] { "ReservationId" });
            DropIndex("dbo.RoomFeatures", new[] { "FeatureId" });
            DropIndex("dbo.RoomFeatures", new[] { "RoomId" });
            DropTable("dbo.Services");
            DropTable("dbo.ReservationServices");
            DropTable("dbo.Reservations");
            DropTable("dbo.ReservationCustomers");
            DropTable("dbo.Rooms");
            DropTable("dbo.RoomFeatures");
            DropTable("dbo.Features");
            DropTable("dbo.Customers");
        }
    }
}
