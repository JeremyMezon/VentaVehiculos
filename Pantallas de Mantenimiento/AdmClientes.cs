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
using VentaVehiculos.DataModel.Entities;

namespace VentaVehiculos.Pantallas_de_Mantenimiento
{
    public partial class AdmClientes : Form
    {
        public AdmClientes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            Cliente cliente = new Cliente();

            cliente.Cedula = txtCedula.Text;
            cliente.Nombre = txtNombreCliente.Text;
            cliente.Apellido = txtApellidoCliente.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Estatus = "AC";
            cliente.Borrado = false;
            cliente.FechaRegistro = DateTime.Now;
            cliente.FechaActualizacion = DateTime.Now;

            var feedback = clienteRepositorio.Crear(cliente);

            if (feedback.Success)
            {
                MessageBox.Show(feedback.Message, "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(feedback.Message, "No se pudo guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
