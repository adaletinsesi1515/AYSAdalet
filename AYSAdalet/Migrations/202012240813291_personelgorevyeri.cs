namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personelgorevyeri : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonelGorevYerleri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GorevYeri = c.String(nullable: false, maxLength: 50),
                        Personel_PersonelID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Personel", t => t.Personel_PersonelID)
                .Index(t => t.Personel_PersonelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonelGorevYerleri", "Personel_PersonelID", "dbo.Personel");
            DropIndex("dbo.PersonelGorevYerleri", new[] { "Personel_PersonelID" });
            DropTable("dbo.PersonelGorevYerleri");
        }
    }
}
