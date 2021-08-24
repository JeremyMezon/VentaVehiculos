using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaVehiculos.Repositorios;

namespace VentaVehiculos.Pantallas_de_Mantenimiento
{
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void btnActualizarTablaVehiculos_Click(object sender, EventArgs e)
        {

        }

        void actualizarTabla()
        {
            VehiculoRepositorio vehiculoRepositorio = new VehiculoRepositorio();
            dataVehiculos.DataSource = vehiculoRepositorio.GetAll();
        }

        private void dataVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizarTabla();
        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
