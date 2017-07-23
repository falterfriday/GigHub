namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Classical')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Punk')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Alternative')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Reggae')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Rap')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'R&B')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Folk')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4,5,6,7,8,9,10)");
        }
    }
}
