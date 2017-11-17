namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pptpu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PricePerPickUp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PricePerPickUp");
        }
    }
}
