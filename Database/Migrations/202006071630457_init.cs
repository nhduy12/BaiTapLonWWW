namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenMonHoc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HoTen = c.String(),
                        MSSV = c.String(),
                        MonHocId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MonHocs", t => t.MonHocId, cascadeDelete: true)
                .Index(t => t.MonHocId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "MonHocId", "dbo.MonHocs");
            DropIndex("dbo.SinhViens", new[] { "MonHocId" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.MonHocs");
        }
    }
}
