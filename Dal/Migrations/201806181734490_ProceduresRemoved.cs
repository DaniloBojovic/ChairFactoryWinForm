namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProceduresRemoved : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Procedures", "ItemId", "dbo.Items");
            DropIndex("dbo.Procedures", new[] { "ItemId" });
            AddColumn("dbo.WorkOperations", "Quantity", c => c.Int(nullable: false));
            DropTable("dbo.Procedures");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Procedures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.WorkOperations", "Quantity");
            CreateIndex("dbo.Procedures", "ItemId");
            AddForeignKey("dbo.Procedures", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
    }
}
