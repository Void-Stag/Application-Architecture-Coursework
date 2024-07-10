namespace P2659902___Library_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentTableDrop : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rents", "BookId", "dbo.Books");
            DropIndex("dbo.Rents", new[] { "BookId" });
            DropTable("dbo.Rents");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Rents", "BookId");
            AddForeignKey("dbo.Rents", "BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
