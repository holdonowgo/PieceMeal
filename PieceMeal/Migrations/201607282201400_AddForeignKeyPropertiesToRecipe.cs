namespace PieceMeal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToRecipe : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Recipes", "Cuisine_Id", "dbo.Cuisines");
            DropForeignKey("dbo.Recipes", "MealType_Id", "dbo.MealTypes");
            DropIndex("dbo.Recipes", new[] { "Cuisine_Id" });
            DropIndex("dbo.Recipes", new[] { "MealType_Id" });
            RenameColumn(table: "dbo.Recipes", name: "Cuisine_Id", newName: "CuisineId");
            RenameColumn(table: "dbo.Recipes", name: "MealType_Id", newName: "MealTypeId");
            AlterColumn("dbo.Recipes", "CuisineId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Recipes", "MealTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Recipes", "CuisineId");
            CreateIndex("dbo.Recipes", "MealTypeId");
            AddForeignKey("dbo.Recipes", "CuisineId", "dbo.Cuisines", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Recipes", "MealTypeId", "dbo.MealTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "MealTypeId", "dbo.MealTypes");
            DropForeignKey("dbo.Recipes", "CuisineId", "dbo.Cuisines");
            DropIndex("dbo.Recipes", new[] { "MealTypeId" });
            DropIndex("dbo.Recipes", new[] { "CuisineId" });
            AlterColumn("dbo.Recipes", "MealTypeId", c => c.Byte());
            AlterColumn("dbo.Recipes", "CuisineId", c => c.Byte());
            RenameColumn(table: "dbo.Recipes", name: "MealTypeId", newName: "MealType_Id");
            RenameColumn(table: "dbo.Recipes", name: "CuisineId", newName: "Cuisine_Id");
            CreateIndex("dbo.Recipes", "MealType_Id");
            CreateIndex("dbo.Recipes", "Cuisine_Id");
            AddForeignKey("dbo.Recipes", "MealType_Id", "dbo.MealTypes", "Id");
            AddForeignKey("dbo.Recipes", "Cuisine_Id", "dbo.Cuisines", "Id");
        }
    }
}
