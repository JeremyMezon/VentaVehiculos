namespace VentaVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracionInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        Correo = c.String(nullable: false),
                        Cedula = c.String(nullable: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        MarcaId = c.Int(nullable: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: false)
                .Index(t => t.MarcaId);
            
            CreateTable(
                "dbo.Vehiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoTransmisionId = c.String(nullable: false),
                        TipoCombustibleId = c.String(nullable: false),
                        Placa = c.String(nullable: false),
                        Chasis = c.String(nullable: false),
                        Anio = c.Int(nullable: false),
                        Color = c.Int(nullable: false),
                        Cilindraje = c.Int(nullable: false),
                        KilometrosTablero = c.Int(nullable: false),
                        Precio = c.Int(nullable: false),
                        ModeloId = c.Int(nullable: false),
                        Kilometraje = c.String(nullable: false),
                        CantidadPuertas = c.Int(nullable: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                        TipoCombustible_Id = c.Int(nullable: false),
                        TipoTransmision_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modeloes", t => t.ModeloId, cascadeDelete: false)
                .ForeignKey("dbo.TipoCombustibles", t => t.TipoCombustible_Id, cascadeDelete: false)
                .ForeignKey("dbo.TipoTransmisions", t => t.TipoTransmision_Id, cascadeDelete: false)
                .Index(t => t.ModeloId)
                .Index(t => t.TipoCombustible_Id)
                .Index(t => t.TipoTransmision_Id);
            
            CreateTable(
                "dbo.TipoCombustibles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoTransmisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        VehiculoId = c.Int(nullable: false),
                        Precio = c.Int(nullable: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                        MetodoPago_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: false)
                .ForeignKey("dbo.Vehiculoes", t => t.MetodoPago_Id, cascadeDelete: false)
                .ForeignKey("dbo.Vehiculoes", t => t.VehiculoId, cascadeDelete: false)
                .Index(t => t.ClienteId)
                .Index(t => t.VehiculoId)
                .Index(t => t.MetodoPago_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "VehiculoId", "dbo.Vehiculoes");
            DropForeignKey("dbo.Ventas", "MetodoPago_Id", "dbo.Vehiculoes");
            DropForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Vehiculoes", "TipoTransmision_Id", "dbo.TipoTransmisions");
            DropForeignKey("dbo.Vehiculoes", "TipoCombustible_Id", "dbo.TipoCombustibles");
            DropForeignKey("dbo.Vehiculoes", "ModeloId", "dbo.Modeloes");
            DropForeignKey("dbo.Modeloes", "MarcaId", "dbo.Marcas");
            DropIndex("dbo.Ventas", new[] { "MetodoPago_Id" });
            DropIndex("dbo.Ventas", new[] { "VehiculoId" });
            DropIndex("dbo.Ventas", new[] { "ClienteId" });
            DropIndex("dbo.Vehiculoes", new[] { "TipoTransmision_Id" });
            DropIndex("dbo.Vehiculoes", new[] { "TipoCombustible_Id" });
            DropIndex("dbo.Vehiculoes", new[] { "ModeloId" });
            DropIndex("dbo.Modeloes", new[] { "MarcaId" });
            DropTable("dbo.Ventas");
            DropTable("dbo.TipoTransmisions");
            DropTable("dbo.TipoCombustibles");
            DropTable("dbo.Vehiculoes");
            DropTable("dbo.Modeloes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Clientes");
        }
    }
}
