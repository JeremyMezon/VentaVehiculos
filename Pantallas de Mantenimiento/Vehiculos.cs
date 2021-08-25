using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaVehiculos.DataModel.Entities;
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
            actualizarTabla();
        }

        void actualizarTabla()
        {
            VehiculoRepositorio vehiculoRepositorio = new VehiculoRepositorio();
            var datosVehiculo = vehiculoRepositorio.GetAll();
            dataVehiculos.DataSource = datosVehiculo.Select(x => new { 
                x.Id, x.Chasis, x.Placa, x.Color, x.Kilometraje, x.Precio, x.CantidadPuertas, x.Anio, x.Cilindraje, x.TipoCombustible.NombreCombustible,x.Modelo.NombreModelo,x.TipoTransmision.NombreTransmision
            }).ToList();
        }

        private void dataVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizarTabla();
        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            AdmVehiculos admVehiculos = new AdmVehiculos();
            admVehiculos.ShowDialog();
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            VehiculoRepositorio vehiculoRepositorio = new VehiculoRepositorio();
            Vehiculo vehiculo = new Vehiculo();
            if (dataVehiculos.Rows.Count > 0 && dataVehiculos.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataVehiculos.CurrentCell.RowIndex;
                int IDVehiculo = int.Parse(dataVehiculos.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                vehiculo = vehiculoRepositorio.FIndById(IDVehiculo);
                AdmVehiculos admVehiculos = new AdmVehiculos(vehiculo);
                admVehiculos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            VehiculoRepositorio vehiculoRepositorio = new VehiculoRepositorio();
            Vehiculo vehiculo = new Vehiculo();
            if (dataVehiculos.Rows.Count > 0 && dataVehiculos.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataVehiculos.CurrentCell.RowIndex;
                int IDVehiculo = int.Parse(dataVehiculos.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                vehiculo = vehiculoRepositorio.FIndById(IDVehiculo);

                DialogResult dialogResult = MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    vehiculoRepositorio.Eliminar(vehiculo);
                    MessageBox.Show("Registro eliminado correctamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }
    }
}
