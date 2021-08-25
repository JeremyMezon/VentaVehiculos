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
    public partial class AdmVehiculos : Form
    {
        private Vehiculo vehiculo { get; set; }
        private bool esModificacion = false;
        public AdmVehiculos()
        {
            InitializeComponent();
        }

        private void AdmVehiculos_Load(object sender, EventArgs e)
        {
            //Modelos
            ModeloRepositorio modeloRep = new ModeloRepositorio();
            comboModelo.DisplayMember = "NombreModelo";
            comboModelo.ValueMember = "Id";
            comboModelo.DataSource = modeloRep.GetAll();

            //Tipo de Transmision
            TipoTransmisionRepositorio tipoTrans = new TipoTransmisionRepositorio();
            comboTransmision.DisplayMember = "NombreTransmision";
            comboTransmision.ValueMember = "Id";
            comboTransmision.DataSource = tipoTrans.GetAll();

            //Tipo de Transmision
            TipoCombustibleRepositorio tipoCombus = new TipoCombustibleRepositorio();
            comboCombustible.DisplayMember = "NombreCombustible";
            comboCombustible.ValueMember = "Id";
            comboCombustible.DataSource = tipoCombus.GetAll();
        }

        public AdmVehiculos(Vehiculo _vehiculo)
        {
            InitializeComponent();
            LbTituloVehiculo.Text = "Modificar Vehiculo";
            this.vehiculo = _vehiculo;
            txtChasis.Text = _vehiculo.Chasis;
            txtPlaca.Text = _vehiculo.Placa;
            txtColor.Text = _vehiculo.Color;
            txtAnio.Text = _vehiculo.Anio;
            txtCilindraje.Text = _vehiculo.Cilindraje;
            txtCantidadPuertas.Text = _vehiculo.CantidadPuertas.ToString();
            txtKilometraje.Text = _vehiculo.Kilometraje;
            txtPrecioVehiculo.Text = _vehiculo.Precio.ToString();
            comboCombustible.SelectedValue = _vehiculo.TipoCombustibleId;
            comboModelo.SelectedValue = _vehiculo.ModeloId;
            comboTransmision.SelectedValue = _vehiculo.TipoTransmisionId;


            if (_vehiculo.Estatus == "AC")
            {
                comboEstado.SelectedItem = "Activo";
            }
            else
            {
                comboEstado.SelectedItem = "Inactivo";
            }
            esModificacion = true;
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                VehiculoRepositorio vehiculoRepositorio = new VehiculoRepositorio();
                Vehiculo vehiculo = capturarDatos();

                if (this.esModificacion)
                {
                    vehiculoRepositorio.Modificar(vehiculo);
                    MessageBox.Show("Datos actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    var feedback = vehiculoRepositorio.Crear(vehiculo);

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

        Vehiculo capturarDatos()
        {
            Vehiculo vehiculo = new Vehiculo();
            string estado = comboEstado.SelectedItem.ToString().Substring(0, 2).ToUpper();

            if (esModificacion)
            {
                vehiculo.Id = this.vehiculo.Id;
            }

            vehiculo.Chasis = txtChasis.Text;
            vehiculo.Placa = txtPlaca.Text;
            vehiculo.Color = txtColor.Text;
            vehiculo.Anio = txtAnio.Text;
            vehiculo.Cilindraje = txtCilindraje.Text;
            vehiculo.CantidadPuertas = int.Parse(txtCantidadPuertas.Text);
            vehiculo.Kilometraje = txtKilometraje.Text;
            vehiculo.Precio = int.Parse(txtPrecioVehiculo.Text);
            vehiculo.TipoCombustibleId = int.Parse(comboCombustible.SelectedValue.ToString());
            vehiculo.ModeloId = int.Parse(comboModelo.SelectedValue.ToString());
            vehiculo.TipoTransmisionId = int.Parse(comboTransmision.SelectedValue.ToString());
            vehiculo.Estatus = estado;
            vehiculo.Borrado = false;
            vehiculo.FechaRegistro = esModificacion ? this.vehiculo.FechaRegistro : DateTime.Now;
            vehiculo.FechaActualizacion = DateTime.Now;

            return vehiculo;
        }

        bool validacion()
        {
            if (string.IsNullOrWhiteSpace(txtChasis.Text))
            {
                MessageBox.Show("El chasis no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("La placa no puede estar vacia", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                MessageBox.Show("El año no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtKilometraje.Text))
            {
                MessageBox.Show("El kilometraje no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtCantidadPuertas.Text))
            {
                MessageBox.Show("La cantidad de puertas no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtPrecioVehiculo.Text))
            {
                MessageBox.Show("El precio del vehiculo no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("El color no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtCilindraje.Text))
            {
                MessageBox.Show("El cilindraje no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (comboCombustible.SelectedIndex < 0)
            {
                MessageBox.Show("El tipo de combustible no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (comboTransmision.SelectedIndex < 0)
            {
                MessageBox.Show("El tipo de transmision no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (comboModelo.SelectedIndex < 0)
            {
                MessageBox.Show("El tipo de modelo no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        
    }
}
