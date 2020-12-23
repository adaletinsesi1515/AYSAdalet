namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bilgi_Bilgisayar_Tablosu_Eklendi : DbMigration
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
                        BilgisayarSeriNo = c.String(nullable: false, maxLength: 50),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BilgisayarID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bilgi_Bilgisayarlar");
        }
    }
}
