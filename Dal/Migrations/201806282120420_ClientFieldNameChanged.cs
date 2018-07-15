namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientFieldNameChanged : DbMigration
    {
        public override void Up()
        {
             
            AddColumn("dbo.OperationPlans", "Client", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OperationPlans", "Client");
              
        }
    }
}
