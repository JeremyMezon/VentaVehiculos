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
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        void actualizarTabla()
        {
            MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
            dataMarca.DataSource = marcaRepositorio.GetAll();

        }

        private void Marca_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            AdmMarcas admMarcas = new AdmMarcas();
            admMarcas.ShowDialog();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
            Marca marca = new Marca();
            if (dataMarca.Rows.Count > 0 && dataMarca.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataMarca.CurrentCell.RowIndex;
                int IDMarca = int.Parse(dataMarca.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                marca = marcaRepositorio.FIndById(IDMarca);
                //MessageBox.Show("Lo hizo");
                AdmMarcas admMarcas = new AdmMarcas(marca);
                admMarcas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrarMarca_Click(object sender, EventArgs e)
        {
            MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
            Marca cliente = new Marca();
            if (dataMarca.Rows.Count > 0 && dataMarca.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataMarca.CurrentCell.RowIndex;
                int IDMarca = int.Parse(dataMarca.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                cliente = marcaRepositorio.FIndById(IDMarca);

                DialogResult dialogResult = MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    marcaRepositorio.Eliminar(cliente);
                    MessageBox.Show("Registro eliminado correctamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
