namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gorevyeri1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Birimler", "PersonelGorevYerleri_ID", "dbo.PersonelGorevYerleri");
            DropIndex("dbo.Birimler", new[] { "PersonelGorevYerleri_ID" });
            DropColumn("dbo.Birimler", "PersonelGorevYerleri_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Birimler", "PersonelGorevYerleri_ID", c => c.Int());
            CreateIndex("dbo.Birimler", "PersonelGorevYerleri_ID");
            AddForeignKey("dbo.Birimler", "PersonelGorevYerleri_ID", "dbo.PersonelGorevYerleri", "ID");
        }
    }
}
