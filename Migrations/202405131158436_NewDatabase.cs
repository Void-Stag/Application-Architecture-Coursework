namespace P2659902___Library_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckoutDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "BookId", "dbo.Books");
            DropIndex("dbo.Rents", new[] { "BookId" });
            DropTable("dbo.Rents");
        }
    }
}
