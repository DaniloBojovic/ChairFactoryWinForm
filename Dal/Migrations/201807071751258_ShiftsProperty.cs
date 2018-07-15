namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShiftsProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductionPlans", "Shifts", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductionPlans", "Shifts");
        }
    }
}
