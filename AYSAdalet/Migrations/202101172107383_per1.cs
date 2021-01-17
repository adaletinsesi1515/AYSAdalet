namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class per1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personel", "PersonelSicil", c => c.String(maxLength: 10));
            AlterColumn("dbo.Personel", "CepTelefonu", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personel", "CepTelefonu", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Personel", "PersonelSicil", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
