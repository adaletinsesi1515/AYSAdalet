namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class per12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personel", "PersonelSicil", c => c.String());
            AlterColumn("dbo.Personel", "PersonelAdSoyad", c => c.String());
            AlterColumn("dbo.Personel", "CepTelefonu", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personel", "CepTelefonu", c => c.String(maxLength: 15));
            AlterColumn("dbo.Personel", "PersonelAdSoyad", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Personel", "PersonelSicil", c => c.String(maxLength: 10));
        }
    }
}
