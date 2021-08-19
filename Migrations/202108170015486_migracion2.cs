namespace VentaVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion2 : DbMigration
    {
        public override void Up()
        {
            
            DropForeignKey("dbo.Vehiculoes", "ModeloId", "dbo.Modeloes");
            DropForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Ventas", "VehiculoId", "dbo.Vehiculoes");
            RenameTable(name: "dbo.Clientes", newName: "Cliente");
            RenameTable(name: "dbo.Marcas", newName: "Marca");
            RenameTable(name: "dbo.Modeloes", newName: "Modelo");
            RenameTable(name: "dbo.Vehiculoes", newName: "Vehiculo");
            RenameTable(name: "dbo.TipoCombustibles", newName: "TipoCombustible");
            RenameTable(name: "dbo.TipoTransmisions", newName: "TipoTransmision");
            RenameTable(name: "dbo.Ventas", newName: "VentaVehiculo");
            DropIndex("dbo.Vehiculo", new[] { "ModeloId" });
            DropIndex("dbo.VentaVehiculo", new[] { "ClienteId" });
            RenameColumn(table: "dbo.Cliente", name: "Id", newName: "ClienteID");
            RenameColumn(table: "dbo.Marca", name: "Id", newName: "MarcaID");
            RenameColumn(table: "dbo.Modelo", name: "Id", newName: "ModeloID");
            RenameColumn(table: "dbo.Vehiculo", name: "Id", newName: "VehiculoID");
            RenameColumn(table: "dbo.TipoCombustible", name: "Id", newName: "TipoCombustibleID");
            RenameColumn(table: "dbo.TipoTransmision", name: "Id", newName: "TipoTransmisionID");
            RenameColumn(table: "dbo.VentaVehiculo", name: "Id", newName: "VentaVehiculoID");
            AlterColumn("dbo.Cliente", "Nombre", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Apellido", c => c.String());
            AlterColumn("dbo.Cliente", "Telefono", c => c.String(maxLength: 30, unicode: false));
            AlterColumn("dbo.Cliente", "Direccion", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Correo", c => c.String());
            AlterColumn("dbo.Cliente", "Cedula", c => c.String());
            AlterColumn("dbo.Cliente", "Estatus", c => c.String());
            AlterColumn("dbo.Marca", "Nombre", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Marca", "Estatus", c => c.String());
            AlterColumn("dbo.Modelo", "Nombre", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Modelo", "Estatus", c => c.String());
            AlterColumn("dbo.Vehiculo", "Placa", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Vehiculo", "Chasis", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Vehiculo", "Anio", c => c.String(nullable: false, maxLength: 4, unicode: false));
            AlterColumn("dbo.Vehiculo", "Color", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.Vehiculo", "Cilindraje", c => c.String());
            AlterColumn("dbo.Vehiculo", "KilometrosTablero", c => c.String());
            AlterColumn("dbo.Vehiculo", "ModeloId", c => c.Int());
            AlterColumn("dbo.Vehiculo", "Kilometraje", c => c.String());
            AlterColumn("dbo.Vehiculo", "Estatus", c => c.String());
            AlterColumn("dbo.TipoCombustible", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.TipoCombustible", "Estatus", c => c.String());
            AlterColumn("dbo.TipoTransmision", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.TipoTransmision", "Estatus", c => c.String());
            AlterColumn("dbo.VentaVehiculo", "ClienteId", c => c.Int());
            AlterColumn("dbo.VentaVehiculo", "Estatus", c => c.String());
            CreateIndex("dbo.Vehiculo", "ModeloId");
            CreateIndex("dbo.VentaVehiculo", "ClienteId");
            AddForeignKey("dbo.Vehiculo", "ModeloId", "dbo.Modelo", "ModeloID");
            AddForeignKey("dbo.VentaVehiculo", "ClienteId", "dbo.Cliente", "ClienteID");
            AddForeignKey("dbo.VentaVehiculo", "VehiculoId", "dbo.Vehiculo", "VehiculoID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VentaVehiculo", "VehiculoId", "dbo.Vehiculo");
            DropForeignKey("dbo.VentaVehiculo", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Vehiculo", "ModeloId", "dbo.Modelo");
            DropIndex("dbo.VentaVehiculo", new[] { "ClienteId" });
            DropIndex("dbo.Vehiculo", new[] { "ModeloId" });
            AlterColumn("dbo.VentaVehiculo", "Estatus", c => c.String(nullable: false, maxLength: 2, unicode: false));
            AlterColumn("dbo.VentaVehiculo", "ClienteId", c => c.Int(nullable: false));
            AlterColumn("dbo.TipoTransmision", "Estatus", c => c.String(nullable: false, maxLength: 2, unicode: false));
            AlterColumn("dbo.TipoTransmision", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.TipoCombustible", "Estatus", c => c.String(nullable: false, maxLength: 2, unicode: false));
            AlterColumn("dbo.TipoCombustible", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Vehiculo", "Estatus", c => c.String(nullable: false, maxLength: 2, unicode: false));
            AlterColumn("dbo.Vehiculo", "Kilometraje", c => c.String(nullable: false));
            AlterColumn("dbo.Vehiculo", "ModeloId", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehiculo", "KilometrosTablero", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehiculo", "Cilindraje", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehiculo", "Color", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehiculo", "Anio", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehiculo", "Chasis", c => c.String(nullable: false));
            AlterColumn("dbo.Vehiculo", "Placa", c => c.String(nullable: false));
            AlterColumn("dbo.Modelo", "Estatus", c => c.String(nullable: false, maxLength: 2, unicode: false));
            AlterColumn("dbo.Modelo", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Marca", "Estatus", c => c.String(nullable: false, maxLength: 2, unicode: false));
            AlterColumn("dbo.Marca", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Cliente", "Estatus", c => c.String(nullable: false, maxLength: 2, unicode: false));
            AlterColumn("dbo.Cliente", "Cedula", c => c.String(nullable: false));
            AlterColumn("dbo.Cliente", "Correo", c => c.String(nullable: false));
            AlterColumn("dbo.Cliente", "Direccion", c => c.String(nullable: false));
            AlterColumn("dbo.Cliente", "Telefono", c => c.String(nullable: false));
            AlterColumn("dbo.Cliente", "Apellido", c => c.String(nullable: false));
            AlterColumn("dbo.Cliente", "Nombre", c => c.String(nullable: false));
            RenameColumn(table: "dbo.VentaVehiculo", name: "VentaVehiculoID", newName: "Id");
            RenameColumn(table: "dbo.TipoTransmision", name: "TipoTransmisionID", newName: "Id");
            RenameColumn(table: "dbo.TipoCombustible", name: "TipoCombustibleID", newName: "Id");
            RenameColumn(table: "dbo.Vehiculo", name: "VehiculoID", newName: "Id");
            RenameColumn(table: "dbo.Modelo", name: "ModeloID", newName: "Id");
            RenameColumn(table: "dbo.Marca", name: "MarcaID", newName: "Id");
            RenameColumn(table: "dbo.Cliente", name: "ClienteID", newName: "Id");
            CreateIndex("dbo.VentaVehiculo", "ClienteId");
            CreateIndex("dbo.Vehiculo", "ModeloId");
            AddForeignKey("dbo.Ventas", "VehiculoId", "dbo.Vehiculoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Vehiculoes", "ModeloId", "dbo.Modeloes", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.VentaVehiculo", newName: "Ventas");
            RenameTable(name: "dbo.TipoTransmision", newName: "TipoTransmisions");
            RenameTable(name: "dbo.TipoCombustible", newName: "TipoCombustibles");
            RenameTable(name: "dbo.Vehiculo", newName: "Vehiculoes");
            RenameTable(name: "dbo.Modelo", newName: "Modeloes");
            RenameTable(name: "dbo.Marca", newName: "Marcas");
            RenameTable(name: "dbo.Cliente", newName: "Clientes");
        }
    }
}
