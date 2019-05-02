namespace CreateBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Autor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Autor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Autor");
        }
    }
}
