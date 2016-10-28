namespace Mesajlasma.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kisiler",
                c => new
                    {
                        KisiID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 25, unicode: false),
                        Password = c.String(nullable: false, maxLength: 8),
                    })
                .PrimaryKey(t => t.KisiID)
                .Index(t => t.UserName, unique: true);
            
            CreateTable(
                "dbo.Mesajlar",
                c => new
                    {
                        MesajID = c.Guid(nullable: false),
                        KisiID = c.Int(nullable: false),
                        Baslik = c.String(nullable: false, maxLength: 50),
                        Icerik = c.String(nullable: false),
                        MesajZamani = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MesajID)
                .ForeignKey("dbo.Kisiler", t => t.KisiID, cascadeDelete: true)
                .Index(t => t.KisiID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mesajlar", "KisiID", "dbo.Kisiler");
            DropIndex("dbo.Mesajlar", new[] { "KisiID" });
            DropIndex("dbo.Kisiler", new[] { "UserName" });
            DropTable("dbo.Mesajlar");
            DropTable("dbo.Kisiler");
        }
    }
}
