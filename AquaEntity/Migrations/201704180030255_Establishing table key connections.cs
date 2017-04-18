namespace AquaEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Establishingtablekeyconnections : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AquaticLives", "AquariumID", c => c.Int());
            AddColumn("dbo.AquaticLives", "OceanID", c => c.Int());
            CreateIndex("dbo.AquaticLives", "AquariumID");
            CreateIndex("dbo.AquaticLives", "OceanID");
            AddForeignKey("dbo.AquaticLives", "AquariumID", "dbo.Aquaria", "ID");
            AddForeignKey("dbo.AquaticLives", "OceanID", "dbo.Oceans", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AquaticLives", "OceanID", "dbo.Oceans");
            DropForeignKey("dbo.AquaticLives", "AquariumID", "dbo.Aquaria");
            DropIndex("dbo.AquaticLives", new[] { "OceanID" });
            DropIndex("dbo.AquaticLives", new[] { "AquariumID" });
            DropColumn("dbo.AquaticLives", "OceanID");
            DropColumn("dbo.AquaticLives", "AquariumID");
        }
    }
}
