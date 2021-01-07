namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zim12 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BilgiZimmet", "PersonelGorevYerleriID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BilgiZimmet", "PersonelGorevYerleriID", c => c.Int(nullable: false));
        }
    }
}
