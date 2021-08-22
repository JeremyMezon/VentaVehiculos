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

        private Cliente cliente { get; set; }
        private bool esModificacion = false;

        public AdmClientes()
        {
            InitializeComponent();
        }

        public AdmClientes(Cliente _cliente)
        {
            InitializeComponent();
            LbTituloCliente.Text = "Modificar Cliente";
            this.cliente = _cliente;
            txtNombreCliente.Text = _cliente.Nombre;
            txtApellidoCliente.Text = _cliente.Apellido;
            txtCedula.Text = _cliente.Cedula;
            txtCorreo.Text = _cliente.Correo;
            txtDireccion.Text = _cliente.Direccion;
            txtTelefono.Text = _cliente.Telefono;
            esModificacion = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {

            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            Cliente cliente = this.capturarCliente();

            if (this.esModificacion)
            {
                clienteRepositorio.Modificar(cliente);
                MessageBox.Show("Datos actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
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


        Cliente capturarCliente()
        {
            Cliente cliente = new Cliente();
              string estado = comboEstado.SelectedItem.ToString().Substring(0, 2).ToUpper();

            if (esModificacion)
            {
                cliente.Id = this.cliente.Id;
            }

            cliente.Cedula = txtCedula.Text;
            cliente.Nombre = txtNombreCliente.Text;
            cliente.Apellido = txtApellidoCliente.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Estatus = estado;
            cliente.Borrado = false;
            cliente.FechaRegistro = esModificacion ? this.cliente.FechaRegistro : DateTime.Now;
            cliente.FechaActualizacion = DateTime.Now;

            return cliente; 
        }
    }
}
