namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bilgi_Talepv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeknikPersonel",
                c => new
                    {
                        TeknikPersonelID = c.Int(nullable: false, identity: true),
                        PersonelSicil = c.String(nullable: false, maxLength: 10),
                        PersonelAdSoyad = c.String(nullable: false, maxLength: 50),
                        CepTelefonu = c.String(nullable: false, maxLength: 15),
                        DahiliNo1 = c.String(),
                        DahiliNo2 = c.String(),
                        Durum = c.Boolean(nullable: false),
                        UnvanID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeknikPersonelID)
                .ForeignKey("dbo.Unvanlar", t => t.UnvanID, cascadeDelete: true)
                .Index(t => t.UnvanID);
            
            AddColumn("dbo.BilgiTalepler", "TeknikPersonel_TeknikPersonelID", c => c.Int());
            CreateIndex("dbo.BilgiTalepler", "TeknikPersonel_TeknikPersonelID");
            AddForeignKey("dbo.BilgiTalepler", "TeknikPersonel_TeknikPersonelID", "dbo.TeknikPersonel", "TeknikPersonelID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BilgiTalepler", "TeknikPersonel_TeknikPersonelID", "dbo.TeknikPersonel");
            DropForeignKey("dbo.TeknikPersonel", "UnvanID", "dbo.Unvanlar");
            DropIndex("dbo.TeknikPersonel", new[] { "UnvanID" });
            DropIndex("dbo.BilgiTalepler", new[] { "TeknikPersonel_TeknikPersonelID" });
            DropColumn("dbo.BilgiTalepler", "TeknikPersonel_TeknikPersonelID");
            DropTable("dbo.TeknikPersonel");
        }
    }
}
