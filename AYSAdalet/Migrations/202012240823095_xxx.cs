namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xxx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonelGorevYerleri", "Birimler", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.PersonelGorevYerleri", "GorevYeri");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonelGorevYerleri", "GorevYeri", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.PersonelGorevYerleri", "Birimler");
        }
    }
}
