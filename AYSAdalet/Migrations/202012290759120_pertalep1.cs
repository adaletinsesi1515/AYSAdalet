namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pertalep1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BilgiTalepler",
                c => new
                    {
                        TalepID = c.Int(nullable: false, identity: true),
                        PersonelSicili = c.String(nullable: false, maxLength: 15),
                        TalepMesaji = c.String(nullable: false, maxLength: 2500),
                        BildirimTarihi = c.DateTime(nullable: false),
                        TeknikPersonelNotu = c.String(maxLength: 2500),
                        SonuclanmaTarihi = c.DateTime(),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TalepID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BilgiTalepler");
        }
    }
}
