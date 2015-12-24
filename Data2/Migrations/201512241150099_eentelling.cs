namespace Data2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eentelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Data2Table2", "Eentelling", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Data2Table2", "Eentelling");
        }
    }
}
