namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteLoginInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "UserName", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Password", c => c.String(nullable: false));
            AddColumn("dbo.TrashCollectorWorkers", "UserName", c => c.String(nullable: false));
            AddColumn("dbo.TrashCollectorWorkers", "Email", c => c.String(nullable: false));
            AddColumn("dbo.TrashCollectorWorkers", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrashCollectorWorkers", "Password");
            DropColumn("dbo.TrashCollectorWorkers", "Email");
            DropColumn("dbo.TrashCollectorWorkers", "UserName");
            DropColumn("dbo.Customers", "Password");
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Customers", "UserName");
        }
    }
}
