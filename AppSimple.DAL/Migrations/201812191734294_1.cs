namespace AppSimple.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BirthOfDate = c.DateTime(),
                        Name = c.String(nullable: false),
                        Firstname = c.String(),
                        Rating = c.Double(),
                        CampusId = c.Int(),
                        ClassRoomId = c.Int(),
                        HireDate = c.DateTime(),
                        Salary = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassRooms", t => t.ClassRoomId, cascadeDelete: true)
                .Index(t => t.ClassRoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "ClassRoomId", "dbo.ClassRooms");
            DropIndex("dbo.People", new[] { "ClassRoomId" });
            DropTable("dbo.People");
            DropTable("dbo.ClassRooms");
        }
    }
}
