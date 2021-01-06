namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ver4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BilgiTalepler", "TeknikPersonelID", c => c.Int(nullable: false));
            CreateIndex("dbo.BilgiTalepler", "TeknikPersonelID");
            AddForeignKey("dbo.BilgiTalepler", "TeknikPersonelID", "dbo.TeknikPersonel", "TeknikPersonelID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BilgiTalepler", "TeknikPersonelID", "dbo.TeknikPersonel");
            DropIndex("dbo.BilgiTalepler", new[] { "TeknikPersonelID" });
            DropColumn("dbo.BilgiTalepler", "TeknikPersonelID");
        }
    }
}
