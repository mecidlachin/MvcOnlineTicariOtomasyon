namespace MvcOnlineTicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mesajlar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mesajlars",
                c => new
                {
                    MesajID = c.Int(nullable: false, identity: true),
                    KiGondericimden = c.String(maxLength: 50, unicode: false),
                    Alici = c.String(maxLength: 50, unicode: false),
                    Konu = c.String(maxLength: 50, unicode: false),
                    Kimden = c.String(maxLength: 2000, unicode: false),
                    Tarih = c.DateTime(nullable: false, storeType: "smalldatetime"),
                })
                .PrimaryKey(t => t.MesajID);
        }

        public override void Down()
        {
            DropTable("dbo.Mesajlars");
        }
    }
}
