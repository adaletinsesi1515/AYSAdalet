namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ver1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdliyeRehber",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personel", t => t.PersonelID, cascadeDelete: true)
                .Index(t => t.PersonelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdliyeRehber", "PersonelID", "dbo.Personel");
            DropIndex("dbo.AdliyeRehber", new[] { "PersonelID" });
            DropTable("dbo.AdliyeRehber");
        }
    }
}
