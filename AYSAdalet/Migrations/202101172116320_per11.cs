namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class per11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personel", "PersonelAdSoyad", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personel", "PersonelAdSoyad", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
