namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedGenreReferenceFromVideo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VideosSlashGenres", "Video_Id", "dbo.Videos");
            DropForeignKey("dbo.VideosSlashGenres", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.VideosSlashGenres", new[] { "Video_Id" });
            DropIndex("dbo.VideosSlashGenres", new[] { "Genre_Id" });
            AddColumn("dbo.Videos", "Genre_Id", c => c.Int());
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id");
            DropTable("dbo.VideosSlashGenres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VideosSlashGenres",
                c => new
                    {
                        Video_Id = c.Int(nullable: false),
                        Genre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_Id, t.Genre_Id });
            
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            DropColumn("dbo.Videos", "Genre_Id");
            CreateIndex("dbo.VideosSlashGenres", "Genre_Id");
            CreateIndex("dbo.VideosSlashGenres", "Video_Id");
            AddForeignKey("dbo.VideosSlashGenres", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.VideosSlashGenres", "Video_Id", "dbo.Videos", "Id", cascadeDelete: true);
        }
    }
}
