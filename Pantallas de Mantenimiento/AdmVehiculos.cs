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

        public AdmVehiculos(Vehiculo _vehiculo)
        {

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {

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

        private void AdmVehiculos_Load(object sender, EventArgs e)
        {
            //Modelos
            ModeloRepositorio modeloRep = new ModeloRepositorio();
            comboModelo.DisplayMember = "Nombre";
            comboModelo.ValueMember = "Id";
            comboModelo.DataSource = modeloRep.GetAll();

            //Tipo de Transmision
            TipoTransmisionRepositorio tipoTrans = new TipoTransmisionRepositorio();
            comboTransmision.DisplayMember = "Nombre";
            comboTransmision.ValueMember = "Id";
            comboTransmision.DataSource = tipoTrans.GetAll();

            //Tipo de Transmision
            TipoCombustibleRepositorio tipoCombus = new TipoCombustibleRepositorio();
            comboCombustible.DisplayMember = "Nombre";
            comboCombustible.ValueMember = "Id";
            comboCombustible.DataSource = tipoCombus.GetAll();
        }
    }
}
