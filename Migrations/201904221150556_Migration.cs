namespace ControlWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Editions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Context = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subscribes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Cost = c.Int(nullable: false),
                        Since = c.DateTime(nullable: false),
                        Duration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        Money = c.Int(nullable: false),
                        Address = c.String(),
                        Subscribe_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subscribes", t => t.Subscribe_Id)
                .Index(t => t.Subscribe_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Subscribe_Id", "dbo.Subscribes");
            DropIndex("dbo.Users", new[] { "Subscribe_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Subscribes");
            DropTable("dbo.Publishers");
            DropTable("dbo.Editions");
        }
    }
}
