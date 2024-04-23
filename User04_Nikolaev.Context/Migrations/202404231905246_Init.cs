namespace User04_Nikolaev.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(nullable: false),
                        WorkerId = c.Int(nullable: false),
                        RequestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.WorkerId, cascadeDelete: true)
                .ForeignKey("dbo.Requests", t => t.RequestId, cascadeDelete: true)
                .Index(t => t.WorkerId)
                .Index(t => t.RequestId);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        CompletionDate = c.DateTime(),
                        ResentDefect = c.String(nullable: false),
                        Zapchasty = c.String(),
                        EquipmentTypeId = c.Int(nullable: false),
                        ModelEquipment = c.String(nullable: false),
                        ClientId = c.Int(nullable: false),
                        StatusId = c.Int(),
                        WorkerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ClientId)
                .ForeignKey("dbo.Users", t => t.WorkerId)
                .ForeignKey("dbo.EquipmentTypes", t => t.EquipmentTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId)
                .Index(t => t.EquipmentTypeId)
                .Index(t => t.ClientId)
                .Index(t => t.StatusId)
                .Index(t => t.WorkerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EquipmentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Requests", "EquipmentTypeId", "dbo.EquipmentTypes");
            DropForeignKey("dbo.Comments", "RequestId", "dbo.Requests");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Requests", "WorkerId", "dbo.Users");
            DropForeignKey("dbo.Requests", "ClientId", "dbo.Users");
            DropForeignKey("dbo.Comments", "WorkerId", "dbo.Users");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Requests", new[] { "WorkerId" });
            DropIndex("dbo.Requests", new[] { "StatusId" });
            DropIndex("dbo.Requests", new[] { "ClientId" });
            DropIndex("dbo.Requests", new[] { "EquipmentTypeId" });
            DropIndex("dbo.Comments", new[] { "RequestId" });
            DropIndex("dbo.Comments", new[] { "WorkerId" });
            DropTable("dbo.Status");
            DropTable("dbo.EquipmentTypes");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Requests");
            DropTable("dbo.Comments");
        }
    }
}
