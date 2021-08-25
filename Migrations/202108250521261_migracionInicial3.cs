namespace VentaVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracionInicial3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Vehiculo", new[] { "TipoCombustible_Id" });
            DropIndex("dbo.Vehiculo", new[] { "TipoTransmision_Id" });
            DropColumn("dbo.Vehiculo", "TipoCombustibleId");
            DropColumn("dbo.Vehiculo", "TipoTransmisionId");
            RenameColumn(table: "dbo.Vehiculo", name: "TipoCombustible_Id", newName: "TipoCombustibleId");
            RenameColumn(table: "dbo.Vehiculo", name: "TipoTransmision_Id", newName: "TipoTransmisionId");
            AlterColumn("dbo.Vehiculo", "TipoTransmisionId", c => c.Int());
            AlterColumn("dbo.Vehiculo", "TipoCombustibleId", c => c.Int());
            CreateIndex("dbo.Vehiculo", "TipoTransmisionId");
            CreateIndex("dbo.Vehiculo", "TipoCombustibleId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Vehiculo", new[] { "TipoCombustibleId" });
            DropIndex("dbo.Vehiculo", new[] { "TipoTransmisionId" });
            AlterColumn("dbo.Vehiculo", "TipoCombustibleId", c => c.String());
            AlterColumn("dbo.Vehiculo", "TipoTransmisionId", c => c.String());
            RenameColumn(table: "dbo.Vehiculo", name: "TipoTransmisionId", newName: "TipoTransmision_Id");
            RenameColumn(table: "dbo.Vehiculo", name: "TipoCombustibleId", newName: "TipoCombustible_Id");
            AddColumn("dbo.Vehiculo", "TipoTransmisionId", c => c.String());
            AddColumn("dbo.Vehiculo", "TipoCombustibleId", c => c.String());
            CreateIndex("dbo.Vehiculo", "TipoTransmision_Id");
            CreateIndex("dbo.Vehiculo", "TipoCombustible_Id");
        }
    }
}
