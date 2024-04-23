namespace User04_Nikolaev.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Requests", "StatusId", "dbo.Status");
            DropIndex("dbo.Requests", new[] { "StatusId" });
            AlterColumn("dbo.Requests", "StatusId", c => c.Int(nullable: false));
            CreateIndex("dbo.Requests", "StatusId");
            AddForeignKey("dbo.Requests", "StatusId", "dbo.Status", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "StatusId", "dbo.Status");
            DropIndex("dbo.Requests", new[] { "StatusId" });
            AlterColumn("dbo.Requests", "StatusId", c => c.Int());
            CreateIndex("dbo.Requests", "StatusId");
            AddForeignKey("dbo.Requests", "StatusId", "dbo.Status", "Id");
        }
    }
}
