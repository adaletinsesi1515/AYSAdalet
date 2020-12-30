namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class perv1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BilgiTalepler", "PersonelId", c => c.Int(nullable: false));
            CreateIndex("dbo.BilgiTalepler", "PersonelId");
            AddForeignKey("dbo.BilgiTalepler", "PersonelId", "dbo.Personel", "PersonelID", cascadeDelete: true);
            DropColumn("dbo.BilgiTalepler", "PersonelSicili");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BilgiTalepler", "PersonelSicili", c => c.String(nullable: false, maxLength: 15));
            DropForeignKey("dbo.BilgiTalepler", "PersonelId", "dbo.Personel");
            DropIndex("dbo.BilgiTalepler", new[] { "PersonelId" });
            DropColumn("dbo.BilgiTalepler", "PersonelId");
        }
    }
}
