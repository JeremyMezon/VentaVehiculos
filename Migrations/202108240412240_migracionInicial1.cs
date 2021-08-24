namespace VentaVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracionInicial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modelo", "TipoCombustible_Id", c => c.Int());
            AddColumn("dbo.Modelo", "TipoTransmision_Id", c => c.Int());
            CreateIndex("dbo.Modelo", "TipoCombustible_Id");
            CreateIndex("dbo.Modelo", "TipoTransmision_Id");
            AddForeignKey("dbo.Modelo", "TipoCombustible_Id", "dbo.TipoCombustible", "TipoCombustibleID");
            AddForeignKey("dbo.Modelo", "TipoTransmision_Id", "dbo.TipoTransmision", "TipoTransmisionID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Modelo", "TipoTransmision_Id", "dbo.TipoTransmision");
            DropForeignKey("dbo.Modelo", "TipoCombustible_Id", "dbo.TipoCombustible");
            DropIndex("dbo.Modelo", new[] { "TipoTransmision_Id" });
            DropIndex("dbo.Modelo", new[] { "TipoCombustible_Id" });
            DropColumn("dbo.Modelo", "TipoTransmision_Id");
            DropColumn("dbo.Modelo", "TipoCombustible_Id");
        }
    }
}
