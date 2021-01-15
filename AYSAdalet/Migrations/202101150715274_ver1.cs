namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ver1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bilgi_Bilgisayarlar",
                c => new
                    {
                        BilgisayarID = c.Int(nullable: false, identity: true),
                        BilgisayarMarka = c.String(nullable: false, maxLength: 50),
                        BilgisayarModel = c.String(nullable: false, maxLength: 50),
                        BilgisayarSeriNo = c.String(maxLength: 50),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BilgisayarID);
            
            CreateTable(
                "dbo.Bilgi_Monitorler",
                c => new
                    {
                        MonitorID = c.Int(nullable: false, identity: true),
                        MonitorMarka = c.String(nullable: false, maxLength: 50),
                        MonitorModel = c.String(nullable: false, maxLength: 50),
                        MonitorSeriNo = c.String(maxLength: 50),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MonitorID);
            
            CreateTable(
                "dbo.BilgiTalepler",
                c => new
                    {
                        TalepID = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        BildirimTarihi = c.DateTime(nullable: false),
                        TalepMesaji = c.String(nullable: false, maxLength: 2500),
                        TeknikPersonelNotu = c.String(maxLength: 2500),
                        SonuclanmaTarihi = c.DateTime(),
                        Durum = c.Boolean(nullable: false),
                        TeknikPersonelID = c.Int(),
                    })
                .PrimaryKey(t => t.TalepID)
                .ForeignKey("dbo.Personel", t => t.PersonelId, cascadeDelete: true)
                .ForeignKey("dbo.TeknikPersonel", t => t.TeknikPersonelID)
                .Index(t => t.PersonelId)
                .Index(t => t.TeknikPersonelID);
            
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        PersonelID = c.Int(nullable: false, identity: true),
                        PersonelSicil = c.String(nullable: false, maxLength: 10),
                        PersonelAdSoyad = c.String(nullable: false, maxLength: 50),
                        CepTelefonu = c.String(nullable: false, maxLength: 15),
                        DahiliNo1 = c.String(),
                        DahiliNo2 = c.String(),
                        Durum = c.Boolean(nullable: false),
                        UnvanID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelID)
                .ForeignKey("dbo.Unvanlar", t => t.UnvanID, cascadeDelete: true)
                .Index(t => t.UnvanID);
            
            CreateTable(
                "dbo.NobetSistemi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NobetBirimi = c.String(),
                        BaslamaTarihi = c.DateTime(nullable: false),
                        BitisTarihi = c.DateTime(nullable: false),
                        Personel_PersonelID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personel", t => t.Personel_PersonelID)
                .Index(t => t.Personel_PersonelID);
            
            CreateTable(
                "dbo.PersonelGorevYerleri",
                c => new
                    {
                        GorevYeriID = c.Int(nullable: false, identity: true),
                        PersonelID = c.Int(nullable: false),
                        BirimID = c.Int(nullable: false),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GorevYeriID)
                .ForeignKey("dbo.Birimler", t => t.BirimID, cascadeDelete: true)
                .ForeignKey("dbo.Personel", t => t.PersonelID, cascadeDelete: true)
                .Index(t => t.PersonelID)
                .Index(t => t.BirimID);
            
            CreateTable(
                "dbo.Birimler",
                c => new
                    {
                        BirimID = c.Int(nullable: false, identity: true),
                        BirimAdi = c.String(nullable: false, maxLength: 100),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BirimID);
            
            CreateTable(
                "dbo.Unvanlar",
                c => new
                    {
                        UnvanID = c.Int(nullable: false, identity: true),
                        Unvani = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.UnvanID);
            
            CreateTable(
                "dbo.TeknikPersonel",
                c => new
                    {
                        TeknikPersonelID = c.Int(nullable: false, identity: true),
                        PersonelSicil = c.String(nullable: false, maxLength: 10),
                        PersonelAdSoyad = c.String(nullable: false, maxLength: 50),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TeknikPersonelID);
            
            CreateTable(
                "dbo.Bilgi_Tarayicilar",
                c => new
                    {
                        TarayiciID = c.Int(nullable: false, identity: true),
                        TarayiciMarka = c.String(nullable: false, maxLength: 50),
                        TarayiciModel = c.String(nullable: false, maxLength: 50),
                        TarayiciSeriNo = c.String(maxLength: 50),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TarayiciID);
            
            CreateTable(
                "dbo.Bilgi_Yazicilar",
                c => new
                    {
                        YaziciID = c.Int(nullable: false, identity: true),
                        YaziciMarka = c.String(nullable: false, maxLength: 50),
                        YaziciModel = c.String(nullable: false, maxLength: 50),
                        YaziciSeriNo = c.String(maxLength: 50),
                        YaziciCounter = c.String(maxLength: 10),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.YaziciID);
            
            CreateTable(
                "dbo.Envanterlers",
                c => new
                    {
                        EnvanterlerId = c.Int(nullable: false, identity: true),
                        EnvanterTipleriId = c.Int(nullable: false),
                        Marka = c.String(),
                        Model = c.String(),
                        SeriNo = c.String(),
                        Domain = c.String(),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EnvanterlerId)
                .ForeignKey("dbo.EnvanterTipleris", t => t.EnvanterTipleriId, cascadeDelete: true)
                .Index(t => t.EnvanterTipleriId);
            
            CreateTable(
                "dbo.EnvanterTipleris",
                c => new
                    {
                        EnvanterTipleriId = c.Int(nullable: false, identity: true),
                        EnvanterTip = c.String(),
                    })
                .PrimaryKey(t => t.EnvanterTipleriId);
            
            CreateTable(
                "dbo.IdariTalepler",
                c => new
                    {
                        TalepID = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        BildirimTarihi = c.DateTime(nullable: false),
                        TalepMesaji = c.String(nullable: false, maxLength: 2500),
                        TeknikPersonelNotu = c.String(maxLength: 2500),
                        SonuclanmaTarihi = c.DateTime(),
                        Durum = c.Boolean(nullable: false),
                        TeknikPersonelID = c.Int(),
                    })
                .PrimaryKey(t => t.TalepID)
                .ForeignKey("dbo.Personel", t => t.PersonelId, cascadeDelete: true)
                .ForeignKey("dbo.TeknikPersonel", t => t.TeknikPersonelID)
                .Index(t => t.PersonelId)
                .Index(t => t.TeknikPersonelID);
            
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 15),
                        Parola = c.String(nullable: false, maxLength: 15),
                        YetkiDuzeyi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ZimmetEnvanters",
                c => new
                    {
                        ZimmetEnvanterId = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        EnvanterlerId = c.Int(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ZimmetEnvanterId)
                .ForeignKey("dbo.Envanterlers", t => t.EnvanterlerId, cascadeDelete: true)
                .ForeignKey("dbo.Personel", t => t.PersonelId, cascadeDelete: true)
                .Index(t => t.PersonelId)
                .Index(t => t.EnvanterlerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ZimmetEnvanters", "PersonelId", "dbo.Personel");
            DropForeignKey("dbo.ZimmetEnvanters", "EnvanterlerId", "dbo.Envanterlers");
            DropForeignKey("dbo.IdariTalepler", "TeknikPersonelID", "dbo.TeknikPersonel");
            DropForeignKey("dbo.IdariTalepler", "PersonelId", "dbo.Personel");
            DropForeignKey("dbo.Envanterlers", "EnvanterTipleriId", "dbo.EnvanterTipleris");
            DropForeignKey("dbo.BilgiTalepler", "TeknikPersonelID", "dbo.TeknikPersonel");
            DropForeignKey("dbo.BilgiTalepler", "PersonelId", "dbo.Personel");
            DropForeignKey("dbo.Personel", "UnvanID", "dbo.Unvanlar");
            DropForeignKey("dbo.PersonelGorevYerleri", "PersonelID", "dbo.Personel");
            DropForeignKey("dbo.PersonelGorevYerleri", "BirimID", "dbo.Birimler");
            DropForeignKey("dbo.NobetSistemi", "Personel_PersonelID", "dbo.Personel");
            DropIndex("dbo.ZimmetEnvanters", new[] { "EnvanterlerId" });
            DropIndex("dbo.ZimmetEnvanters", new[] { "PersonelId" });
            DropIndex("dbo.IdariTalepler", new[] { "TeknikPersonelID" });
            DropIndex("dbo.IdariTalepler", new[] { "PersonelId" });
            DropIndex("dbo.Envanterlers", new[] { "EnvanterTipleriId" });
            DropIndex("dbo.PersonelGorevYerleri", new[] { "BirimID" });
            DropIndex("dbo.PersonelGorevYerleri", new[] { "PersonelID" });
            DropIndex("dbo.NobetSistemi", new[] { "Personel_PersonelID" });
            DropIndex("dbo.Personel", new[] { "UnvanID" });
            DropIndex("dbo.BilgiTalepler", new[] { "TeknikPersonelID" });
            DropIndex("dbo.BilgiTalepler", new[] { "PersonelId" });
            DropTable("dbo.ZimmetEnvanters");
            DropTable("dbo.Login");
            DropTable("dbo.IdariTalepler");
            DropTable("dbo.EnvanterTipleris");
            DropTable("dbo.Envanterlers");
            DropTable("dbo.Bilgi_Yazicilar");
            DropTable("dbo.Bilgi_Tarayicilar");
            DropTable("dbo.TeknikPersonel");
            DropTable("dbo.Unvanlar");
            DropTable("dbo.Birimler");
            DropTable("dbo.PersonelGorevYerleri");
            DropTable("dbo.NobetSistemi");
            DropTable("dbo.Personel");
            DropTable("dbo.BilgiTalepler");
            DropTable("dbo.Bilgi_Monitorler");
            DropTable("dbo.Bilgi_Bilgisayarlar");
        }
    }
}
