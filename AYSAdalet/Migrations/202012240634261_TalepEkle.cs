namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TalepEkle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Talep",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TalepBasligi = c.String(nullable: false, maxLength: 50),
                        Talep1 = c.String(nullable: false),
                        TalepTarihi = c.String(nullable: false, maxLength: 30),
                        TalepDurumu = c.Boolean(nullable: false),
                        Personel_PersonelID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Personel", t => t.Personel_PersonelID)
                .Index(t => t.Personel_PersonelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Talep", "Personel_PersonelID", "dbo.Personel");
            DropIndex("dbo.Talep", new[] { "Personel_PersonelID" });
            DropTable("dbo.Talep");
        }
    }
}
