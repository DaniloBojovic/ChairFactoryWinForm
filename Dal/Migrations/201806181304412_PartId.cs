namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartId : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Items", new[] { "PartId" });
            AlterColumn("dbo.Items", "PartId", c => c.Int());
            CreateIndex("dbo.Items", "PartId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Items", new[] { "PartId" });
            AlterColumn("dbo.Items", "PartId", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "PartId");
        }
    }
}
