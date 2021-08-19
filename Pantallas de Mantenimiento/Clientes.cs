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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            AdmClientes admClientes = new AdmClientes();
            admClientes.ShowDialog();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            Cliente cliente = new Cliente();
            if(dataClientes.Rows.Count > 0 && dataClientes.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataClientes.CurrentCell.RowIndex;
                int IDCliente = int.Parse(dataClientes.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                cliente = clienteRepositorio.FIndById(IDCliente);
                //MessageBox.Show("Lo hizo");
                AdmClientes admClientes = new AdmClientes(cliente);
                admClientes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void actualizarTabla()
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            dataClientes.DataSource = clienteRepositorio.GetAll();

        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            Cliente cliente = new Cliente();
            if (dataClientes.Rows.Count > 0 && dataClientes.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataClientes.CurrentCell.RowIndex;
                int IDCliente = int.Parse(dataClientes.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                cliente = clienteRepositorio.FIndById(IDCliente);

                DialogResult dialogResult = MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    clienteRepositorio.Eliminar(cliente);
                    MessageBox.Show("Registro eliminado correctamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
