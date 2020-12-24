namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class birimlertablosudaekleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Birimler", "Durum", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Birimler", "Durum");
        }
    }
}
