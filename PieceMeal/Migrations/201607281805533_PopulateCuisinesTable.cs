namespace PieceMeal.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateCuisinesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (1, 'American')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (2, 'Chinese')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (3, 'Mexican')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (4, 'Indian')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (5, 'Greek')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (6, 'Japanese')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (7, 'Thai')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (8, 'Vietnamese')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (9, 'Lebanese')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (10, 'Italian')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (11, 'Spanish')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (12, 'French')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (13, 'Polish')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (14, 'Korean')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (15, 'Peruvian')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (16, 'Pakistani')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (17, 'Brazilian')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (18, 'Irish')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (19, 'Soul-Food')");
            Sql("INSERT INTO Cuisines (Id, Name) VALUES (20, 'Southern')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Cuisines WHERE Id BETWEEN 1 AND 20");
        }
    }
}
