namespace P2659902___Library_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentTypeChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Payments", "CardNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Payments", "CardNumber", c => c.Int(nullable: false));
        }
    }
}
