namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Material = c.String(),
                        PartId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.PartId)
                .Index(t => t.PartId);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OperationPlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductionPlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        OperationPlanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.OperationPlans", t => t.OperationPlanId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.OperationPlanId);
            
            CreateTable(
                "dbo.Procedures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.WorkOperations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        TimeNeeded = c.Double(nullable: false),
                        ItemId = c.Int(nullable: false),
                        MachineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Machines", t => t.MachineId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.MachineId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkOperations", "MachineId", "dbo.Machines");
            DropForeignKey("dbo.WorkOperations", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Procedures", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ProductionPlans", "OperationPlanId", "dbo.OperationPlans");
            DropForeignKey("dbo.ProductionPlans", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "PartId", "dbo.Items");
            DropIndex("dbo.WorkOperations", new[] { "MachineId" });
            DropIndex("dbo.WorkOperations", new[] { "ItemId" });
            DropIndex("dbo.Procedures", new[] { "ItemId" });
            DropIndex("dbo.ProductionPlans", new[] { "OperationPlanId" });
            DropIndex("dbo.ProductionPlans", new[] { "ItemId" });
            DropIndex("dbo.Items", new[] { "PartId" });
            DropTable("dbo.WorkOperations");
            DropTable("dbo.Procedures");
            DropTable("dbo.ProductionPlans");
            DropTable("dbo.OperationPlans");
            DropTable("dbo.Machines");
            DropTable("dbo.Items");
        }
    }
}
