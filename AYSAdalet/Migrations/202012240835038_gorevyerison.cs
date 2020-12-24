namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gorevyerison : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonelGorevYerleri", "GorevYeri", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonelGorevYerleri", "GorevYeri");
        }
    }
}
