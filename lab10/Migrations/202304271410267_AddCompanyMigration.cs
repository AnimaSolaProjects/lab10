namespace lab10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beers",
                c => new
                    {
                        BeerId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Average_price = c.Single(nullable: false),
                        Сompany_СompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.BeerId)
                .ForeignKey("dbo.Сompany", t => t.Сompany_СompanyId)
                .Index(t => t.Сompany_СompanyId);
            
            CreateTable(
                "dbo.Сompany",
                c => new
                    {
                        СompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.СompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Beers", "Сompany_СompanyId", "dbo.Сompany");
            DropIndex("dbo.Beers", new[] { "Сompany_СompanyId" });
            DropTable("dbo.Сompany");
            DropTable("dbo.Beers");
        }
    }
}
