namespace University_DAEA_11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "IsActive", c => c.Boolean());
            DropColumn("dbo.OfficeAssignments", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OfficeAssignments", "IsActive", c => c.Boolean());
            DropColumn("dbo.People", "IsActive");
        }
    }
}
