namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedClassificationToVideo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Classification", c => c.Int());
            Sql("INSERT INTO dbo.Genres (Name) VALUES('Horror')");
            Sql("INSERT INTO dbo.Videos (Name, ReleaseDate, Genre_Id) VALUES('Return of JoJo', '04/11/2018', 1)");
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Classification");
        }
    }
}
