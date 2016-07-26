namespace PieceMeal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateClientRecipeTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        Account_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Account_Id, cascadeDelete: true)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Account_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Clients", new[] { "Account_Id" });
            DropTable("dbo.Recipes");
            DropTable("dbo.Clients");
        }
    }
}
