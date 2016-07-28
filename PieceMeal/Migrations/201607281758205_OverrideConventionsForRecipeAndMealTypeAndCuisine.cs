namespace PieceMeal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForRecipeAndMealTypeAndCuisine : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cuisines", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.MealTypes", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Recipes", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Recipes", "Name", c => c.String());
            AlterColumn("dbo.MealTypes", "Name", c => c.String());
            AlterColumn("dbo.Cuisines", "Name", c => c.String());
        }
    }
}
