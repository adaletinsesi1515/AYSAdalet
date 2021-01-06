namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeknikPersonel", "BilgiTalepler_TalepID", c => c.Int());
            CreateIndex("dbo.TeknikPersonel", "BilgiTalepler_TalepID");
            AddForeignKey("dbo.TeknikPersonel", "BilgiTalepler_TalepID", "dbo.BilgiTalepler", "TalepID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeknikPersonel", "BilgiTalepler_TalepID", "dbo.BilgiTalepler");
            DropIndex("dbo.TeknikPersonel", new[] { "BilgiTalepler_TalepID" });
            DropColumn("dbo.TeknikPersonel", "BilgiTalepler_TalepID");
        }
    }
}
