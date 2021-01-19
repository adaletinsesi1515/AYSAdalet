namespace AYSAdalet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personelgorevyeri : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IdariTalepler", "PersonelGorevYeri", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.IdariTalepler", "PersonelGorevYeri");
        }
    }
}
