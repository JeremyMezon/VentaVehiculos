namespace VentaVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracionInicial22 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Venta", new[] { "VehiculoId" });
            RenameColumn(table: "dbo.Venta", name: "VentaVehiculoID", newName: "Id");
            AlterColumn("dbo.Venta", "VehiculoId", c => c.Int());
            CreateIndex("dbo.Venta", "VehiculoId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Venta", new[] { "VehiculoId" });
            AlterColumn("dbo.Venta", "VehiculoId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Venta", name: "Id", newName: "VentaVehiculoID");
            CreateIndex("dbo.Venta", "VehiculoId");
        }
    }
}
