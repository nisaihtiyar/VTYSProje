namespace VTYSProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tBorcs",
                c => new
                    {
                        borcNo = c.Int(nullable: false, identity: true),
                        musteriId = c.Int(nullable: false),
                        borcTarihi = c.String(),
                        borcMiktar = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.borcNo);
            
            CreateTable(
                "dbo.tIrsaliyes",
                c => new
                    {
                        satirNo = c.Int(nullable: false, identity: true),
                        irsaliyeID = c.Int(nullable: false),
                        urunId = c.Int(nullable: false),
                        girisTarih = c.DateTime(nullable: false),
                        girdiFiyat = c.Single(nullable: false),
                        miktar = c.Int(nullable: false),
                        tedarikciId = c.Int(nullable: false),
                        urunAdi = c.String(),
                    })
                .PrimaryKey(t => t.satirNo);
            
            CreateTable(
                "dbo.tKasiyers",
                c => new
                    {
                        kasiyerId = c.Int(nullable: false, identity: true),
                        kullaniciAdi = c.String(),
                        kullaniciSifre = c.String(),
                    })
                .PrimaryKey(t => t.kasiyerId);
            
            CreateTable(
                "dbo.tMusteris",
                c => new
                    {
                        musteriId = c.Int(nullable: false, identity: true),
                        musteriAdi = c.String(),
                        musteriSoyadi = c.String(),
                        musteriGSM = c.String(),
                        kayitTarihi = c.String(),
                        musteriBorc = c.Single(nullable: false),
                        odenenMiktar = c.Single(nullable: false),
                        kalanBorc = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.musteriId);
            
            CreateTable(
                "dbo.tSatis",
                c => new
                    {
                        satisNo = c.Int(nullable: false, identity: true),
                        satisTutar = c.Single(nullable: false),
                        urunAdi = c.String(),
                        satisMiktar = c.Int(nullable: false),
                        satisTarih = c.String(),
                    })
                .PrimaryKey(t => t.satisNo);
            
            CreateTable(
                "dbo.ttedarikciOdemes",
                c => new
                    {
                        odemeNo = c.Int(nullable: false, identity: true),
                        tedarikciID = c.Int(nullable: false),
                        toplamBorc = c.Single(nullable: false),
                        odenenMiktar = c.Single(nullable: false),
                        kalanMiktar = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.odemeNo);
            
            CreateTable(
                "dbo.tTedarikcis",
                c => new
                    {
                        girisNo = c.Int(nullable: false, identity: true),
                        tedarikciId = c.Int(nullable: false),
                        borcMiktar = c.Single(nullable: false),
                        girisTarihi = c.String(),
                    })
                .PrimaryKey(t => t.girisNo);
            
            CreateTable(
                "dbo.tUruns",
                c => new
                    {
                        urunId = c.Int(nullable: false, identity: true),
                        barkodNo = c.Long(nullable: false),
                        urunAdi = c.String(),
                        miktar = c.Int(nullable: false),
                        satisFiyat = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.urunId);
            
            CreateTable(
                "dbo.tYoneticis",
                c => new
                    {
                        yoneticiID = c.Int(nullable: false, identity: true),
                        yKullaniciAdi = c.String(),
                        ySifre = c.String(),
                    })
                .PrimaryKey(t => t.yoneticiID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tYoneticis");
            DropTable("dbo.tUruns");
            DropTable("dbo.tTedarikcis");
            DropTable("dbo.ttedarikciOdemes");
            DropTable("dbo.tSatis");
            DropTable("dbo.tMusteris");
            DropTable("dbo.tKasiyers");
            DropTable("dbo.tIrsaliyes");
            DropTable("dbo.tBorcs");
        }
    }
}
