namespace ConsoleApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringKeyToInt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Audits", "Action1_Id", "dbo.Action1");
            DropForeignKey("dbo.Audits", "Action2_Id", "dbo.Action2");
            DropIndex("dbo.Audits", new[] { "Action1_Id" });
            DropIndex("dbo.Audits", new[] { "Action2_Id" });
            AlterColumn("dbo.Audits", "AffectedId", c => c.Int(nullable: false));
            DropColumn("dbo.Audits", "Action1_Id");
            DropColumn("dbo.Audits", "Action2_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Audits", "Action2_Id", c => c.Int());
            AddColumn("dbo.Audits", "Action1_Id", c => c.Int());
            AlterColumn("dbo.Audits", "AffectedId", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Audits", "Action2_Id");
            CreateIndex("dbo.Audits", "Action1_Id");
            AddForeignKey("dbo.Audits", "Action2_Id", "dbo.Action2", "Id");
            AddForeignKey("dbo.Audits", "Action1_Id", "dbo.Action1", "Id");
        }
    }
}
