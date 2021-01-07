namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zim11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BilgiZimmet",
                c => new
                    {
                        ZimmetID = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        PersonelGorevYerleriID = c.Int(nullable: false),
                        BilgisayarID = c.Int(nullable: false),
                        MonitorID = c.Int(nullable: false),
                        YaziciID = c.Int(nullable: false),
                        TarayiciID = c.Int(nullable: false),
                        DomainAdi = c.String(),
                        Durum = c.Boolean(nullable: false),
                        PersonelGorevYerleri_GorevYeriID = c.Int(),
                    })
                .PrimaryKey(t => t.ZimmetID)
                .ForeignKey("dbo.Bilgi_Bilgisayarlar", t => t.BilgisayarID, cascadeDelete: true)
                .ForeignKey("dbo.Bilgi_Monitorler", t => t.MonitorID, cascadeDelete: true)
                .ForeignKey("dbo.Bilgi_Tarayicilar", t => t.TarayiciID, cascadeDelete: true)
                .ForeignKey("dbo.Bilgi_Yazicilar", t => t.YaziciID, cascadeDelete: true)
                .ForeignKey("dbo.Personel", t => t.PersonelId, cascadeDelete: true)
                .ForeignKey("dbo.PersonelGorevYerleri", t => t.PersonelGorevYerleri_GorevYeriID)
                .Index(t => t.PersonelId)
                .Index(t => t.BilgisayarID)
                .Index(t => t.MonitorID)
                .Index(t => t.YaziciID)
                .Index(t => t.TarayiciID)
                .Index(t => t.PersonelGorevYerleri_GorevYeriID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BilgiZimmet", "PersonelGorevYerleri_GorevYeriID", "dbo.PersonelGorevYerleri");
            DropForeignKey("dbo.BilgiZimmet", "PersonelId", "dbo.Personel");
            DropForeignKey("dbo.BilgiZimmet", "YaziciID", "dbo.Bilgi_Yazicilar");
            DropForeignKey("dbo.BilgiZimmet", "TarayiciID", "dbo.Bilgi_Tarayicilar");
            DropForeignKey("dbo.BilgiZimmet", "MonitorID", "dbo.Bilgi_Monitorler");
            DropForeignKey("dbo.BilgiZimmet", "BilgisayarID", "dbo.Bilgi_Bilgisayarlar");
            DropIndex("dbo.BilgiZimmet", new[] { "PersonelGorevYerleri_GorevYeriID" });
            DropIndex("dbo.BilgiZimmet", new[] { "TarayiciID" });
            DropIndex("dbo.BilgiZimmet", new[] { "YaziciID" });
            DropIndex("dbo.BilgiZimmet", new[] { "MonitorID" });
            DropIndex("dbo.BilgiZimmet", new[] { "BilgisayarID" });
            DropIndex("dbo.BilgiZimmet", new[] { "PersonelId" });
            DropTable("dbo.BilgiZimmet");
        }
    }
}
