namespace VentaVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracionInicial5 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.VentaVehiculo", newName: "Venta");
            AddColumn("dbo.Venta", "MetodoPago", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Venta", "MetodoPago", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Venta", "MetodoPago", c => c.String());
            RenameTable(name: "dbo.Venta", newName: "VentaVehiculo");
        }
    }
}
