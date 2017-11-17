namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoginInfo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "UserName");
            DropColumn("dbo.Customers", "Password");
            DropColumn("dbo.TrashCollectorWorkers", "UserName");
            DropColumn("dbo.TrashCollectorWorkers", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrashCollectorWorkers", "Password", c => c.String());
            AddColumn("dbo.TrashCollectorWorkers", "UserName", c => c.String());
            AddColumn("dbo.Customers", "Password", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "UserName", c => c.String(nullable: false));
        }
    }
}
