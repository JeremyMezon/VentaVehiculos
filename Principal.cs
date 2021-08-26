using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaVehiculos.Pantallas_de_Mantenimiento;

namespace VentaVehiculos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void manteminiemtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas marca = new Marcas();
            marca.ShowDialog();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelos modelos = new Modelos();
            modelos.ShowDialog();
        }

        private void tipoDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoCombustibles tipoCombustibles = new TipoCombustibles();
            tipoCombustibles.ShowDialog();
        }

        private void tipoDeTransmisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoTransmisions tipoTransmisions = new TipoTransmisions();
            tipoTransmisions.ShowDialog();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.ShowDialog();
        }

        private void ventaDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
