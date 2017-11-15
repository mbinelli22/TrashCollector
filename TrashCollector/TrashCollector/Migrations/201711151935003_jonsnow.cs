namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jonsnow : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.TrashCollectorWorkers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.TrashCollectorWorkers", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrashCollectorWorkers", "LastName", c => c.String());
            AlterColumn("dbo.TrashCollectorWorkers", "FirstName", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
        }
    }
}
