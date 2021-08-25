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
    public partial class AdmTipoCombustibles : Form
    {
        private TipoCombustible tipocombustible { get; set; }
        private bool esModificacion = false;

        public AdmTipoCombustibles()
        {
            InitializeComponent();
            comboEstado.SelectedIndex = 0;
        }

        public AdmTipoCombustibles(TipoCombustible _tipoCombustible)
        {
            InitializeComponent();
            LbTituloCombustible.Text = "Modificar Tipo de Combustible";
            this.tipocombustible = _tipoCombustible;
            txtNombreCombustible.Text = _tipoCombustible.NombreCombustible;
            if (_tipoCombustible.Estatus == "AC")
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
                TipoCombustibleRepositorio combustibleRepositorio = new TipoCombustibleRepositorio();
                TipoCombustible tipoCombustible = this.capturarCombustible();

                if (this.esModificacion)
                {
                    combustibleRepositorio.Modificar(tipoCombustible);
                    MessageBox.Show("Datos actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var feedback = combustibleRepositorio.Crear(tipoCombustible);

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

        TipoCombustible capturarCombustible()
        {
            TipoCombustible tipoCombustible = new TipoCombustible();
            string estado = comboEstado.SelectedItem.ToString().Substring(0, 2).ToUpper();

            if (esModificacion)
            {
                tipoCombustible.Id = this.tipocombustible.Id;
            }

            tipoCombustible.NombreCombustible = txtNombreCombustible.Text;
            tipoCombustible.Estatus = estado;
            tipoCombustible.Borrado = false;
            tipoCombustible.FechaRegistro = esModificacion ? this.tipocombustible.FechaRegistro : DateTime.Now;
            tipoCombustible.FechaActualizacion = DateTime.Now;

            return tipoCombustible;
        }

        bool validacion()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCombustible.Text))
            {
                MessageBox.Show("El tipo de combustible no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
