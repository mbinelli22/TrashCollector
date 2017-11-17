namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCollectorWorkers", "PricePerPickUp", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "PickUpDay", c => c.String(nullable: false));
            AlterColumn("dbo.TrashCollectorWorkers", "RouteZipCode", c => c.String(nullable: false));
            DropColumn("dbo.Customers", "PricePerPickUp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "PricePerPickUp", c => c.String());
            AlterColumn("dbo.TrashCollectorWorkers", "RouteZipCode", c => c.String());
            AlterColumn("dbo.Customers", "PickUpDay", c => c.String());
            DropColumn("dbo.TrashCollectorWorkers", "PricePerPickUp");
        }
    }
}
