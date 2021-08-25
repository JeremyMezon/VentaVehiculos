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
            comboEstado.SelectedIndex = 0;
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
            if(_cliente.Estatus == "AC")
            {
                comboEstado.SelectedItem = "Activo";
            }
            else
            {
                comboEstado.SelectedItem = "Inactivo";
            }
            esModificacion = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {

            if (validacionClientes())
            {
                ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
                Cliente cliente = this.capturarCliente();

                if (this.esModificacion)
                {
                    clienteRepositorio.Modificar(cliente);
                    MessageBox.Show("Datos actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    var feedback = clienteRepositorio.Crear(cliente);

                    if (feedback.Success)
                    {
                        MessageBox.Show(feedback.Message, "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(feedback.Message, "No se pudo guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
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

        bool validacionClientes()
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("La Cedula no puede estar vacia", "Campos vacios",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show("El nombre no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtApellidoCliente.Text))
            {
                MessageBox.Show("El apellido no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La Direccion no puede estar vacia", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El Correo no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AdmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
