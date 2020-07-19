namespace Phu.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Student",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 100),
                    Address = c.String(nullable: false, maxLength: 256),
                    Age = c.Int(nullable: false),
                    Gender = c.Boolean(nullable: false),
                    ClassId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Class", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.ClassId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Student", "ClassId", "dbo.Class");
            DropIndex("dbo.Student", new[] { "ClassId" });
            DropTable("dbo.Student");
            DropTable("dbo.Class");
        }
    }
}