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
    public partial class AdmTipoTransmisions : Form
    {
        private TipoTransmision tipoTransmision { get; set; }
        private bool esModificacion = false;
        public AdmTipoTransmisions()
        {
            InitializeComponent();
            comboEstado.SelectedIndex = 0;
        }

        public AdmTipoTransmisions(TipoTransmision _tipoTransmision)
        {
            InitializeComponent();
            LbTituloCombustible.Text = "Modificar Tipo de Transimision";
            this.tipoTransmision = _tipoTransmision;
            txtNombreTransmision.Text = _tipoTransmision.NombreTransmision;
            if (_tipoTransmision.Estatus == "AC")
            {
                comboEstado.SelectedItem = "Activo";
            }
            else
            {
                comboEstado.SelectedItem = "Inactivo";
            }
            esModificacion = true;
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                TipoTransmisionRepositorio combustibleRepositorio = new TipoTransmisionRepositorio();
                TipoTransmision tipoTransmision = this.capturarDatos();

                if (this.esModificacion)
                {
                    combustibleRepositorio.Modificar(tipoTransmision);
                    MessageBox.Show("Datos actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    var feedback = combustibleRepositorio.Crear(tipoTransmision);

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

        TipoTransmision capturarDatos()
        {
            TipoTransmision tipoTransmision = new TipoTransmision();
            string estado = comboEstado.SelectedItem.ToString().Substring(0, 2).ToUpper();

            if (esModificacion)
            {
                tipoTransmision.Id = this.tipoTransmision.Id;
            }

            tipoTransmision.NombreTransmision = txtNombreTransmision.Text;
            tipoTransmision.Estatus = estado;
            tipoTransmision.Borrado = false;
            tipoTransmision.FechaRegistro = esModificacion ? this.tipoTransmision.FechaRegistro : DateTime.Now;
            tipoTransmision.FechaActualizacion = DateTime.Now;

            return tipoTransmision;
        }

        bool validacion()
        {
            if (string.IsNullOrWhiteSpace(txtNombreTransmision.Text))
            {
                MessageBox.Show("El tipo de transmision no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
