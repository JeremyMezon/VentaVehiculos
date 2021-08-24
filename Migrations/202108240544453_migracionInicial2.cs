
    namespace VentaVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracionInicial2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Modelo", "TipoCombustible_Id", "dbo.TipoCombustible");
            DropForeignKey("dbo.Modelo", "TipoTransmision_Id", "dbo.TipoTransmision");
            DropIndex("dbo.Modelo", new[] { "TipoCombustible_Id" });
            DropIndex("dbo.Modelo", new[] { "TipoTransmision_Id" });
            DropColumn("dbo.Modelo", "TipoCombustible_Id");
            DropColumn("dbo.Modelo", "TipoTransmision_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Modelo", "TipoTransmision_Id", c => c.Int());
            AddColumn("dbo.Modelo", "TipoCombustible_Id", c => c.Int());
            CreateIndex("dbo.Modelo", "TipoTransmision_Id");
            CreateIndex("dbo.Modelo", "TipoCombustible_Id");
            AddForeignKey("dbo.Modelo", "TipoTransmision_Id", "dbo.TipoTransmision", "TipoTransmisionID");
            AddForeignKey("dbo.Modelo", "TipoCombustible_Id", "dbo.TipoCombustible", "TipoCombustibleID");
        }
    }
}
