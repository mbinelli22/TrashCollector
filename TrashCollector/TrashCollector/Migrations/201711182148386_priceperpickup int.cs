namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class priceperpickupint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PricePerPickUp", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PricePerPickUp", c => c.String());
        }
    }
}
