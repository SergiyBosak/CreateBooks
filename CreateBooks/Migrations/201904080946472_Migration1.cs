namespace CreateBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        BookId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId)
                .Index(t => t.BookId);
            
            DropColumn("dbo.Books", "ChapterId");
            DropColumn("dbo.Books", "ChapterTitle");
            DropColumn("dbo.Books", "ChapterText");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "ChapterText", c => c.String());
            AddColumn("dbo.Books", "ChapterTitle", c => c.String());
            AddColumn("dbo.Books", "ChapterId", c => c.Int());
            DropForeignKey("dbo.Chapters", "BookId", "dbo.Books");
            DropIndex("dbo.Chapters", new[] { "BookId" });
            DropTable("dbo.Chapters");
        }
    }
}
