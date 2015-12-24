namespace Data2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedToExisting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Data2Table2",
                c => new
                    {
                        Id2 = c.Int(nullable: false, identity: true),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id2);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Data2Table2");
        }
    }
}
