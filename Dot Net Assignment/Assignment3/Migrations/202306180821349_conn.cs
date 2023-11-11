namespace Assignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class conn : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Products0025", newName: "Products");
            DropTable("dbo.Users0025");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users0025",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            RenameTable(name: "dbo.Products", newName: "Products0025");
        }
    }
}
