namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class perv1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonelGorevYerleri", "Durum", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonelGorevYerleri", "Durum");
        }
    }
}
