namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dsdasdasdassasd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author = c.String(),
                        ISBN = c.String(),
                        Publisher = c.String(),
                        PublishDate = c.DateTime(),
                        Cover = c.String(),
                        Description = c.String(),
                        Amount = c.Int(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        DeliveryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deliveries", t => t.DeliveryId)
                .Index(t => t.DeliveryId);
            
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(),
                        ReaderId = c.Int(),
                        DateIssue = c.DateTime(),
                        DateReturn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Readers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Patronimic = c.String(),
                        DateBith = c.DateTime(),
                        PhoneNumber = c.Int(),
                        Address = c.String(),
                        Photo = c.String(),
                        DeliveryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deliveries", t => t.DeliveryId)
                .Index(t => t.DeliveryId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Readers", "DeliveryId", "dbo.Deliveries");
            DropForeignKey("dbo.Books", "DeliveryId", "dbo.Deliveries");
            DropIndex("dbo.Readers", new[] { "DeliveryId" });
            DropIndex("dbo.Books", new[] { "DeliveryId" });
            DropTable("dbo.Users");
            DropTable("dbo.Readers");
            DropTable("dbo.Deliveries");
            DropTable("dbo.Books");
        }
    }
}
