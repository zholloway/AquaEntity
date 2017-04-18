namespace AquaEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AqLifeandOceanstablescreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AquaticLives",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        Type = c.String(),
                        DateAddedToTank = c.DateTime(nullable: false),
                        IsInQuarantine = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Oceans",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AverageTemperature = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Oceans");
            DropTable("dbo.AquaticLives");
        }
    }
}
