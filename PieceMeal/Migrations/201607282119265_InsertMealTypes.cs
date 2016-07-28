namespace PieceMeal.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InsertMealTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MealTypes (Id, Name) VALUES (1, 'Breakfast')");
            Sql("INSERT INTO MealTypes (Id, Name) VALUES (2, 'Lunch')");
            Sql("INSERT INTO MealTypes (Id, Name) VALUES (3, 'Dinner')");
            Sql("INSERT INTO MealTypes (Id, Name) VALUES (4, 'Dessert')");
            Sql("INSERT INTO MealTypes (Id, Name) VALUES (5, 'Beverage')");
            Sql("INSERT INTO MealTypes (Id, Name) VALUES (6, 'Snack')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM MealTypes WHERE Id IN (1,2,3,4,5,6)");
        }
    }
}
