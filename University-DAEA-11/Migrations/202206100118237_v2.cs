namespace University_DAEA_11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "IsActive", c => c.Boolean());
        }
    }
}
