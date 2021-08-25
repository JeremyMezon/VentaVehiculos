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
    public partial class AdmMarcas : Form
    {
        private Marca marca { get; set; }
        private bool esModificacion = false;
        public AdmMarcas()
        {
            InitializeComponent();
            comboEstado.SelectedIndex = 0;
        }

        public AdmMarcas(Marca _marca)
        {
            InitializeComponent();
            LbTituloMarca.Text = "Modificar Marca";
            this.marca = _marca;
            txtNombreMarca.Text = _marca.Nombre;
            if (_marca.Estatus == "AC")
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
            if (validacionMarcas())
            {
                MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
                Marca marca = this.capturarCliente();

                if (this.esModificacion)
                {
                    marcaRepositorio.Modificar(marca);
                    MessageBox.Show("Datos actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    var feedback = marcaRepositorio.Crear(marca);

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

        Marca capturarCliente()
        {
            Marca marca = new Marca();
            string estado = comboEstado.SelectedItem.ToString().Substring(0, 2).ToUpper();

            if (esModificacion)
            {
                marca.Id = this.marca.Id;
            }

            marca.Nombre = txtNombreMarca.Text;
            marca.Estatus = estado;
            marca.Borrado = false;
            marca.FechaRegistro = esModificacion ? this.marca.FechaRegistro : DateTime.Now;
            marca.FechaActualizacion = DateTime.Now;

            return marca;
        }

        bool validacionMarcas()
        {
            if (string.IsNullOrWhiteSpace(txtNombreMarca.Text))
            {
                MessageBox.Show("La Marca no puede estar vacia", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
