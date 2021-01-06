namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
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
                        Durum = c.Boolean(nullable: false),
                        UnvanID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeknikPersonelID)
                .ForeignKey("dbo.Unvanlar", t => t.UnvanID, cascadeDelete: true)
                .Index(t => t.UnvanID);
            
            AddColumn("dbo.BilgiTalepler", "PersonelId", c => c.Int(nullable: false));
            AddColumn("dbo.BilgiTalepler", "TeknikPersonel_TeknikPersonelID", c => c.Int());
            CreateIndex("dbo.BilgiTalepler", "PersonelId");
            CreateIndex("dbo.BilgiTalepler", "TeknikPersonel_TeknikPersonelID");
            AddForeignKey("dbo.BilgiTalepler", "PersonelId", "dbo.Personel", "PersonelID", cascadeDelete: true);
            AddForeignKey("dbo.BilgiTalepler", "TeknikPersonel_TeknikPersonelID", "dbo.TeknikPersonel", "TeknikPersonelID");
            DropColumn("dbo.BilgiTalepler", "PersonelSicili");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BilgiTalepler", "PersonelSicili", c => c.String(nullable: false, maxLength: 15));
            DropForeignKey("dbo.BilgiTalepler", "TeknikPersonel_TeknikPersonelID", "dbo.TeknikPersonel");
            DropForeignKey("dbo.TeknikPersonel", "UnvanID", "dbo.Unvanlar");
            DropForeignKey("dbo.BilgiTalepler", "PersonelId", "dbo.Personel");
            DropIndex("dbo.TeknikPersonel", new[] { "UnvanID" });
            DropIndex("dbo.BilgiTalepler", new[] { "TeknikPersonel_TeknikPersonelID" });
            DropIndex("dbo.BilgiTalepler", new[] { "PersonelId" });
            DropColumn("dbo.BilgiTalepler", "TeknikPersonel_TeknikPersonelID");
            DropColumn("dbo.BilgiTalepler", "PersonelId");
            DropTable("dbo.TeknikPersonel");
        }
    }
}
