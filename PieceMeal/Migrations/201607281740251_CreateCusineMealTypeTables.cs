namespace PieceMeal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCusineMealTypeTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cuisines",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MealTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Recipes", "Cuisine_Id", c => c.Byte());
            AddColumn("dbo.Recipes", "MealType_Id", c => c.Byte());
            CreateIndex("dbo.Recipes", "Cuisine_Id");
            CreateIndex("dbo.Recipes", "MealType_Id");
            AddForeignKey("dbo.Recipes", "Cuisine_Id", "dbo.Cuisines", "Id");
            AddForeignKey("dbo.Recipes", "MealType_Id", "dbo.MealTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "MealType_Id", "dbo.MealTypes");
            DropForeignKey("dbo.Recipes", "Cuisine_Id", "dbo.Cuisines");
            DropIndex("dbo.Recipes", new[] { "MealType_Id" });
            DropIndex("dbo.Recipes", new[] { "Cuisine_Id" });
            DropColumn("dbo.Recipes", "MealType_Id");
            DropColumn("dbo.Recipes", "Cuisine_Id");
            DropTable("dbo.MealTypes");
            DropTable("dbo.Cuisines");
        }
    }
}
