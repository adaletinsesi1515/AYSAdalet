namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vr3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PersonelGorevYerleriPersonels", "PersonelGorevYerleri_GorevYeriID", "dbo.PersonelGorevYerleri");
            DropForeignKey("dbo.PersonelGorevYerleriPersonels", "Personel_PersonelID", "dbo.Personel");
            DropIndex("dbo.PersonelGorevYerleriPersonels", new[] { "PersonelGorevYerleri_GorevYeriID" });
            DropIndex("dbo.PersonelGorevYerleriPersonels", new[] { "Personel_PersonelID" });
            CreateIndex("dbo.PersonelGorevYerleri", "PersonelID");
            AddForeignKey("dbo.PersonelGorevYerleri", "PersonelID", "dbo.Personel", "PersonelID", cascadeDelete: true);
            DropTable("dbo.PersonelGorevYerleriPersonels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PersonelGorevYerleriPersonels",
                c => new
                    {
                        PersonelGorevYerleri_GorevYeriID = c.Int(nullable: false),
                        Personel_PersonelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PersonelGorevYerleri_GorevYeriID, t.Personel_PersonelID });
            
            DropForeignKey("dbo.PersonelGorevYerleri", "PersonelID", "dbo.Personel");
            DropIndex("dbo.PersonelGorevYerleri", new[] { "PersonelID" });
            CreateIndex("dbo.PersonelGorevYerleriPersonels", "Personel_PersonelID");
            CreateIndex("dbo.PersonelGorevYerleriPersonels", "PersonelGorevYerleri_GorevYeriID");
            AddForeignKey("dbo.PersonelGorevYerleriPersonels", "Personel_PersonelID", "dbo.Personel", "PersonelID", cascadeDelete: true);
            AddForeignKey("dbo.PersonelGorevYerleriPersonels", "PersonelGorevYerleri_GorevYeriID", "dbo.PersonelGorevYerleri", "GorevYeriID", cascadeDelete: true);
        }
    }
}
