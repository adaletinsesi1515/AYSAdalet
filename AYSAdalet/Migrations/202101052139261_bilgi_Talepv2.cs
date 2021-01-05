namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bilgi_Talepv2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TeknikPersonel", "CepTelefonu");
            DropColumn("dbo.TeknikPersonel", "DahiliNo1");
            DropColumn("dbo.TeknikPersonel", "DahiliNo2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeknikPersonel", "DahiliNo2", c => c.String());
            AddColumn("dbo.TeknikPersonel", "DahiliNo1", c => c.String());
            AddColumn("dbo.TeknikPersonel", "CepTelefonu", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
