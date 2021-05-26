namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtoBook_delivery : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReaderId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        DateIssue = c.DateTime(),
                        DateReturn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Readers", t => t.ReaderId, cascadeDelete: true)
                .Index(t => t.ReaderId)
                .Index(t => t.BookId);
            
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
                    })
                .PrimaryKey(t => t.Id);
            
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
            DropForeignKey("dbo.Deliveries", "ReaderId", "dbo.Readers");
            DropForeignKey("dbo.Deliveries", "BookId", "dbo.Books");
            DropIndex("dbo.Deliveries", new[] { "BookId" });
            DropIndex("dbo.Deliveries", new[] { "ReaderId" });
            DropTable("dbo.Users");
            DropTable("dbo.Readers");
            DropTable("dbo.Deliveries");
            DropTable("dbo.Books");
        }
    }
}
