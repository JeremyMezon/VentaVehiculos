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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        void actualizarTabla()
        {
            VentaRepositorio ventaRepositorio = new VentaRepositorio();
            dataVenta.DataSource = ventaRepositorio.GetAll();

        }

        private void btnActualizarTablaVenta_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            AdmVentas admVentas = new AdmVentas();
            admVentas.ShowDialog();
        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            VentaRepositorio ventaRepositorio = new VentaRepositorio();
            Venta venta = new Venta();
            if (dataVenta.Rows.Count > 0 && dataVenta.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataVenta.CurrentCell.RowIndex;
                int IDVenta = int.Parse(dataVenta.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                venta = ventaRepositorio.FIndById(IDVenta);
                AdmVentas admVentas = new AdmVentas(/*venta*/);
                admVentas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrarVenta_Click(object sender, EventArgs e)
        {
            VentaRepositorio ventaRepositorio = new VentaRepositorio();
            Venta venta = new Venta();
            if (dataVenta.Rows.Count > 0 && dataVenta.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataVenta.CurrentCell.RowIndex;
                int IDVenta = int.Parse(dataVenta.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                venta = ventaRepositorio.FIndById(IDVenta);

                DialogResult dialogResult = MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    ventaRepositorio.Eliminar(venta);
                    MessageBox.Show("Registro eliminado correctamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }
    }
}
