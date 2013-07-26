namespace ConsoleApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WithAbstract2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Audits", "Action1_Id", c => c.Int());
            AddForeignKey("dbo.Audits", "Action1_Id", "dbo.Action1", "Id");
            CreateIndex("dbo.Audits", "Action1_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Audits", new[] { "Action1_Id" });
            DropForeignKey("dbo.Audits", "Action1_Id", "dbo.Action1");
            DropColumn("dbo.Audits", "Action1_Id");
        }
    }
}
