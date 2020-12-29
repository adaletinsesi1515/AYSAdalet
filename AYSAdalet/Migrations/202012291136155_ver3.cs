namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ver3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Personel", "BilgiTalepler_TalepID", "dbo.BilgiTalepler");
            DropIndex("dbo.Personel", new[] { "BilgiTalepler_TalepID" });
            AddColumn("dbo.BilgiTalepler", "PersonelId", c => c.String(nullable: false, maxLength: 15));
            AddColumn("dbo.BilgiTalepler", "Personel_Id", c => c.Int(nullable: false));
            AddColumn("dbo.BilgiTalepler", "Personel_PersonelID", c => c.Int());
            CreateIndex("dbo.BilgiTalepler", "Personel_PersonelID");
            AddForeignKey("dbo.BilgiTalepler", "Personel_PersonelID", "dbo.Personel", "PersonelID");
            DropColumn("dbo.BilgiTalepler", "PersonelSicili");
            DropColumn("dbo.Personel", "BilgiTalepler_TalepID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personel", "BilgiTalepler_TalepID", c => c.Int());
            AddColumn("dbo.BilgiTalepler", "PersonelSicili", c => c.String(nullable: false, maxLength: 15));
            DropForeignKey("dbo.BilgiTalepler", "Personel_PersonelID", "dbo.Personel");
            DropIndex("dbo.BilgiTalepler", new[] { "Personel_PersonelID" });
            DropColumn("dbo.BilgiTalepler", "Personel_PersonelID");
            DropColumn("dbo.BilgiTalepler", "Personel_Id");
            DropColumn("dbo.BilgiTalepler", "PersonelId");
            CreateIndex("dbo.Personel", "BilgiTalepler_TalepID");
            AddForeignKey("dbo.Personel", "BilgiTalepler_TalepID", "dbo.BilgiTalepler", "TalepID");
        }
    }
}
