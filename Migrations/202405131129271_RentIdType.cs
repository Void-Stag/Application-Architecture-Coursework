namespace P2659902___Library_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentIdType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Rents");
            AlterColumn("dbo.Rents", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Rents", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Rents");
            AlterColumn("dbo.Rents", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Rents", "Id");
        }
    }
}
