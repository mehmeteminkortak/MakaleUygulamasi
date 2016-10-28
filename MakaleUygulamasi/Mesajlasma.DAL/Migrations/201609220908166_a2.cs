namespace Mesajlasma.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kisiler", "KayitTarihi", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
            AddColumn("dbo.Kisiler", "DogumTarihi", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kisiler", "DogumTarihi");
            DropColumn("dbo.Kisiler", "KayitTarihi");
        }
    }
}
