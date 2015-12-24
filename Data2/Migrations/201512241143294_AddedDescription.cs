namespace Data2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Data2Table2", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Data2Table2", "Description");
        }
    }
}
