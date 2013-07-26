namespace ConsoleApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Action1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Desc = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Action2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Desc = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Audits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntityId = c.Int(nullable: false),
                        AffectedId = c.String(nullable: false, maxLength: 20),
                        NewValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Audits");
            DropTable("dbo.Action2");
            DropTable("dbo.Action1");
        }
    }
}
