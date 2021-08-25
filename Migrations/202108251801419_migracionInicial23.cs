namespace VentaVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracionInicial23 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Venta", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Venta", "VehiculoId", "dbo.Vehiculo");
            DropIndex("dbo.Venta", new[] { "ClienteId" });
            DropIndex("dbo.Venta", new[] { "VehiculoId" });
            AlterColumn("dbo.Venta", "ClienteId", c => c.Int(nullable: false));
            AlterColumn("dbo.Venta", "VehiculoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Venta", "ClienteId");
            CreateIndex("dbo.Venta", "VehiculoId");
            AddForeignKey("dbo.Venta", "ClienteId", "dbo.Cliente", "ClienteID", cascadeDelete: true);
            AddForeignKey("dbo.Venta", "VehiculoId", "dbo.Vehiculo", "VehiculoID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venta", "VehiculoId", "dbo.Vehiculo");
            DropForeignKey("dbo.Venta", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Venta", new[] { "VehiculoId" });
            DropIndex("dbo.Venta", new[] { "ClienteId" });
            AlterColumn("dbo.Venta", "VehiculoId", c => c.Int());
            AlterColumn("dbo.Venta", "ClienteId", c => c.Int());
            CreateIndex("dbo.Venta", "VehiculoId");
            CreateIndex("dbo.Venta", "ClienteId");
            AddForeignKey("dbo.Venta", "VehiculoId", "dbo.Vehiculo", "VehiculoID");
            AddForeignKey("dbo.Venta", "ClienteId", "dbo.Cliente", "ClienteID");
        }
    }
}
