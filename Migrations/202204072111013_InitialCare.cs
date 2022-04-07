namespace Calendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCare : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "Date", c => c.Int(nullable: false));
        }
    }
}
