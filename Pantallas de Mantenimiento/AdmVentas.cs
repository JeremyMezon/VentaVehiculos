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
    public partial class AdmVentas : Form
    {
        private Venta venta { get; set; }
        private bool esModificacion = false;

        private void AdmVentas_Load(object sender, EventArgs e)
        {

            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            comboClientes.DisplayMember = "Nombre";
            comboClientes.ValueMember = "Id";
            comboClientes.DataSource = clienteRepositorio.GetAll();


            VehiculoRepositorio vehiculoRepositorio = new VehiculoRepositorio();
            comboVehiculo.DisplayMember = "Nombre";
            comboVehiculo.ValueMember = "Id";
            comboVehiculo.DataSource = vehiculoRepositorio.GetAll();


        }

        public AdmVentas()
        {
            InitializeComponent();
            comboEstado.SelectedIndex = 0;
        }
        public AdmVentas(Venta _venta)
        {
            InitializeComponent();
            LbTituloVenta.Text = "Modificar Venta";
            this.venta = _venta;
            comboClientes.SelectedIndex = int.Parse(comboClientes.SelectedItem.ToString());
            comboVehiculo.SelectedIndex = int.Parse(comboVehiculo.SelectedItem.ToString());
            comboMetodoPago.SelectedIndex = int.Parse(comboMetodoPago.SelectedItem.ToString());
            txtPrecio.Text = _venta.Precio.ToString();
            if (_venta.Estatus == "AC")
            {
                comboEstado.SelectedItem = "Activo";
            }
            else
            {
                comboEstado.SelectedItem = "Inactivo";
            }
            esModificacion = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LbTituloMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (validacionVentas())
            {
                VentaRepositorio ventaRepositorio = new VentaRepositorio();
                Venta venta = this.capturarVenta();

                if (this.esModificacion)
                {
                    ventaRepositorio.Modificar(venta);
                    MessageBox.Show("Datos actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var feedback = ventaRepositorio.Crear(venta);

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

        Venta capturarVenta()
        {
            Venta venta = new Venta();

            string estado = comboEstado.SelectedItem.ToString().Substring(0, 2).ToUpper();

            if (esModificacion)
            {
                venta.Id = this.venta.Id;
            }

            venta.ClienteId = int.Parse(comboClientes.SelectedItem.ToString());
            venta.VehiculoId = int.Parse(comboVehiculo.SelectedItem.ToString());
            venta.MetodoPago = comboMetodoPago.SelectedItem.ToString();
            venta.Precio = int.Parse(txtPrecio.Text);
            venta.Estatus = estado;
            venta.Borrado = false;
            venta.FechaRegistro = esModificacion ? this.venta.FechaRegistro : DateTime.Now;
            venta.FechaActualizacion = DateTime.Now;



            return venta;
        }

        bool validacionVentas()
        {
            if (comboClientes.SelectedIndex <0)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (comboVehiculo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (comboMetodoPago.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar el metodo de pago", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Debe digitar el precio del vehiculo a vender", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}