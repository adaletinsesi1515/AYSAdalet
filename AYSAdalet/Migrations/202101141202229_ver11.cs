namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ver11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AdliyeRehber", "PersonelID", "dbo.Personel");
            DropIndex("dbo.AdliyeRehber", new[] { "PersonelID" });
            DropTable("dbo.AdliyeRehber");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AdliyeRehber",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.AdliyeRehber", "PersonelID");
            AddForeignKey("dbo.AdliyeRehber", "PersonelID", "dbo.Personel", "PersonelID", cascadeDelete: true);
        }
    }
}
