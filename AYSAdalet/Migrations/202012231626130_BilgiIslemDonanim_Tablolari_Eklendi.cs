namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BilgiIslemDonanim_Tablolari_Eklendi : DbMigration
    {
        public override void Up()
        {
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
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.YaziciID);
            
            AlterColumn("dbo.Bilgi_Bilgisayarlar", "BilgisayarSeriNo", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bilgi_Bilgisayarlar", "BilgisayarSeriNo", c => c.String(nullable: false, maxLength: 50));
            DropTable("dbo.Bilgi_Yazicilar");
            DropTable("dbo.Bilgi_Tarayicilar");
            DropTable("dbo.Bilgi_Monitorler");
        }
    }
}
