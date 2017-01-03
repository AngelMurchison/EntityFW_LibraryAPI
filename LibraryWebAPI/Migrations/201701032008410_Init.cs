namespace LibraryWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        author = c.String(),
                        title = c.String(),
                        genre = c.String(),
                        yearPublished = c.DateTime(),
                        dateLastCheckedOut = c.DateTime(),
                        dateDueBack = c.DateTime(),
                        isCheckedOut = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
