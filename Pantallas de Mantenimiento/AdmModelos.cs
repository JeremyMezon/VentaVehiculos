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
    public partial class AdmModelos : Form
    {
        private Modelo modelo { get; set; }
        private bool esModificacion = false;
        public AdmModelos()
        {
            InitializeComponent();
            comboEstado.SelectedIndex = 0;
        }


        private void AdmModelos_Load(object sender, EventArgs e)
        {

            MarcaRepositorio marcaRep = new MarcaRepositorio();
            comboMarcas.DisplayMember = "Nombre";
            comboMarcas.ValueMember = "Id";
            comboMarcas.DataSource = marcaRep.GetAll();

            if (this.esModificacion)
            {

                comboMarcas.SelectedValue = modelo.Marca.Id;
            }

        }

        public AdmModelos(Modelo _modelo)
        {
            InitializeComponent();
            MarcaRepositorio marcaRep = new MarcaRepositorio();
            comboMarcas.DisplayMember = "Nombre";
            comboMarcas.ValueMember = "Id";
            comboMarcas.DataSource = marcaRep.GetAll();
            int FkMarca = _modelo.Marca.Id;
            
            LbTituloModelo.Text = "Modificar Modelo";
            this.modelo = _modelo;
            txtNombreModelo.Text = _modelo.NombreModelo;

            if (_modelo.Estatus == "AC")
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
            if (validacionModelos())
            {
                ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
                Modelo modelo = this.capturarModelo();

                if (this.esModificacion)
                {
                    modeloRepositorio.Modificar(modelo);
                    MessageBox.Show("Datos actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    var feedback = modeloRepositorio.Crear(modelo);

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


        Modelo capturarModelo()
        {
            Modelo modelo = new Modelo();
            string estado = comboEstado.SelectedItem.ToString().Substring(0, 2).ToUpper();

            if (esModificacion)
            {
                modelo.Id = this.modelo.Id;
            }

            modelo.NombreModelo = txtNombreModelo.Text;
            modelo.MarcaId = int.Parse(comboMarcas.SelectedValue.ToString());
            modelo.Estatus = estado;
            modelo.Borrado = false;
            modelo.FechaRegistro = esModificacion ? this.modelo.FechaRegistro : DateTime.Now;
            modelo.FechaActualizacion = DateTime.Now;

            return modelo;
        }

        bool validacionModelos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreModelo.Text))
            {
                MessageBox.Show("El modelo no puede estar vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(comboMarcas.SelectedIndex < 0)
            {
                MessageBox.Show("Debe tomar una marca", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
