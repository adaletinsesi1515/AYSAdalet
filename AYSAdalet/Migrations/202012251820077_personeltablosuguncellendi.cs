namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personeltablosuguncellendi : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Bilgi_Bilgisayarlar",
            //    c => new
            //        {
            //            BilgisayarID = c.Int(nullable: false, identity: true),
            //            BilgisayarMarka = c.String(nullable: false, maxLength: 50),
            //            BilgisayarModel = c.String(nullable: false, maxLength: 50),
            //            BilgisayarSeriNo = c.String(maxLength: 50),
            //            Durum = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.BilgisayarID);
            
            //CreateTable(
            //    "dbo.Bilgi_Monitorler",
            //    c => new
            //        {
            //            MonitorID = c.Int(nullable: false, identity: true),
            //            MonitorMarka = c.String(nullable: false, maxLength: 50),
            //            MonitorModel = c.String(nullable: false, maxLength: 50),
            //            MonitorSeriNo = c.String(maxLength: 50),
            //            Durum = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.MonitorID);
            
            //CreateTable(
            //    "dbo.Bilgi_Tarayicilar",
            //    c => new
            //        {
            //            TarayiciID = c.Int(nullable: false, identity: true),
            //            TarayiciMarka = c.String(nullable: false, maxLength: 50),
            //            TarayiciModel = c.String(nullable: false, maxLength: 50),
            //            TarayiciSeriNo = c.String(maxLength: 50),
            //            Durum = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.TarayiciID);
            
            //CreateTable(
            //    "dbo.Bilgi_Yazicilar",
            //    c => new
            //        {
            //            YaziciID = c.Int(nullable: false, identity: true),
            //            YaziciMarka = c.String(nullable: false, maxLength: 50),
            //            YaziciModel = c.String(nullable: false, maxLength: 50),
            //            YaziciSeriNo = c.String(maxLength: 50),
            //            Durum = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.YaziciID);
            
            //CreateTable(
            //    "dbo.Birimler",
            //    c => new
            //        {
            //            BirimID = c.Int(nullable: false, identity: true),
            //            BirimAdi = c.String(nullable: false, maxLength: 100),
            //            Durum = c.Boolean(nullable: false),
            //            PersonelGorevYerleri_GorevYeriID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.BirimID)
            //    .ForeignKey("dbo.PersonelGorevYerleri", t => t.PersonelGorevYerleri_GorevYeriID)
            //    .Index(t => t.PersonelGorevYerleri_GorevYeriID);
            
            //CreateTable(
            //    "dbo.Talep",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            TalepBasligi = c.String(nullable: false, maxLength: 50),
            //            Talep1 = c.String(nullable: false),
            //            TalepTarihi = c.String(nullable: false, maxLength: 30),
            //            TalepDurumu = c.Boolean(nullable: false),
            //            Personel_PersonelID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Personel", t => t.Personel_PersonelID)
            //    .Index(t => t.Personel_PersonelID);
            
            //CreateTable(
            //    "dbo.Personel",
            //    c => new
            //        {
            //            PersonelID = c.Int(nullable: false, identity: true),
            //            PersonelSicil = c.String(nullable: false, maxLength: 10),
            //            PersonelAdSoyad = c.String(nullable: false, maxLength: 50),
            //            CepTelefonu = c.String(nullable: false, maxLength: 15),
            //            DahiliNo1 = c.String(),
            //            DahiliNo2 = c.String(),
            //            Durum = c.Boolean(nullable: false),
            //            UnvanID = c.Int(nullable: false),
            //            GorevYeriID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.PersonelID)
            //    .ForeignKey("dbo.PersonelGorevYerleri", t => t.GorevYeriID, cascadeDelete: true)
            //    .ForeignKey("dbo.Unvanlar", t => t.UnvanID, cascadeDelete: true)
            //    .Index(t => t.UnvanID)
            //    .Index(t => t.GorevYeriID);
            
            //CreateTable(
            //    "dbo.PersonelGorevYerleri",
            //    c => new
            //        {
            //            GorevYeriID = c.Int(nullable: false, identity: true),
            //            PersonelID = c.Int(nullable: false),
            //            BirimID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.GorevYeriID);
            
            //CreateTable(
            //    "dbo.Unvanlar",
            //    c => new
            //        {
            //            UnvanID = c.Int(nullable: false, identity: true),
            //            Unvani = c.String(nullable: false, maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.UnvanID);
            
            //CreateTable(
            //    "dbo.Login",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            KullaniciAdi = c.String(nullable: false, maxLength: 15),
            //            Parola = c.String(nullable: false, maxLength: 15),
            //            YetkiDuzeyi = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Talep", "Personel_PersonelID", "dbo.Personel");
            //DropForeignKey("dbo.Personel", "UnvanID", "dbo.Unvanlar");
            //DropForeignKey("dbo.Personel", "GorevYeriID", "dbo.PersonelGorevYerleri");
            //DropForeignKey("dbo.Birimler", "PersonelGorevYerleri_GorevYeriID", "dbo.PersonelGorevYerleri");
            //DropIndex("dbo.Personel", new[] { "GorevYeriID" });
            //DropIndex("dbo.Personel", new[] { "UnvanID" });
            //DropIndex("dbo.Talep", new[] { "Personel_PersonelID" });
            //DropIndex("dbo.Birimler", new[] { "PersonelGorevYerleri_GorevYeriID" });
            //DropTable("dbo.Login");
            //DropTable("dbo.Unvanlar");
            //DropTable("dbo.PersonelGorevYerleri");
            //DropTable("dbo.Personel");
            //DropTable("dbo.Talep");
            //DropTable("dbo.Birimler");
            //DropTable("dbo.Bilgi_Yazicilar");
            //DropTable("dbo.Bilgi_Tarayicilar");
            //DropTable("dbo.Bilgi_Monitorler");
            //DropTable("dbo.Bilgi_Bilgisayarlar");
        }
    }
}
