namespace Mesajlasma.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mesajlar", "GuncellemeZamani", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mesajlar", "GuncellemeZamani");
        }
    }
}
