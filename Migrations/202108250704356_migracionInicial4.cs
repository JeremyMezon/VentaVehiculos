namespace VentaVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracionInicial4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modelo", "NombreModelo", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AddColumn("dbo.TipoCombustible", "NombreCombustible", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.TipoTransmision", "NombreTransmision", c => c.String(nullable: false, maxLength: 50, unicode: false));
            DropColumn("dbo.Modelo", "Nombre");
            DropColumn("dbo.TipoCombustible", "Nombre");
            DropColumn("dbo.TipoTransmision", "Nombre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TipoTransmision", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.TipoCombustible", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.Modelo", "Nombre", c => c.String(nullable: false, maxLength: 100, unicode: false));
            DropColumn("dbo.TipoTransmision", "NombreTransmision");
            DropColumn("dbo.TipoCombustible", "NombreCombustible");
            DropColumn("dbo.Modelo", "NombreModelo");
        }
    }
}
