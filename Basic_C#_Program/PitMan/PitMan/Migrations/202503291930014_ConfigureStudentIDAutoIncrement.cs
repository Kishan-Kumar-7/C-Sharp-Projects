namespace PitMan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfigureStudentIDAutoIncrement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentFirstName = c.String(),
                        StudentLastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Course = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
