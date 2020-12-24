namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pgy2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonelGorevYerleriBirimlers",
                c => new
                    {
                        PersonelGorevYerleri_ID = c.Int(nullable: false),
                        Birimler_BirimID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PersonelGorevYerleri_ID, t.Birimler_BirimID })
                .ForeignKey("dbo.PersonelGorevYerleri", t => t.PersonelGorevYerleri_ID, cascadeDelete: true)
                .ForeignKey("dbo.Birimler", t => t.Birimler_BirimID, cascadeDelete: true)
                .Index(t => t.PersonelGorevYerleri_ID)
                .Index(t => t.Birimler_BirimID);
            
            DropColumn("dbo.PersonelGorevYerleri", "Birimler");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonelGorevYerleri", "Birimler", c => c.String(nullable: false, maxLength: 50));
            DropForeignKey("dbo.PersonelGorevYerleriBirimlers", "Birimler_BirimID", "dbo.Birimler");
            DropForeignKey("dbo.PersonelGorevYerleriBirimlers", "PersonelGorevYerleri_ID", "dbo.PersonelGorevYerleri");
            DropIndex("dbo.PersonelGorevYerleriBirimlers", new[] { "Birimler_BirimID" });
            DropIndex("dbo.PersonelGorevYerleriBirimlers", new[] { "PersonelGorevYerleri_ID" });
            DropTable("dbo.PersonelGorevYerleriBirimlers");
        }
    }
}
