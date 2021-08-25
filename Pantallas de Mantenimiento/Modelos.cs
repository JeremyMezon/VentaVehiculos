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
    public partial class Modelos : Form
    {
        public Modelos()
        {
            InitializeComponent();
        }

        private void btnActualizarTablaModelos_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        void actualizarTabla()
        {
            ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
            dataModelos.DataSource = modeloRepositorio.GetAll();

        }

        private void Modelos_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnNuevoModelo_Click(object sender, EventArgs e)
        {
            AdmModelos admModelos = new AdmModelos();
            admModelos.ShowDialog();
        }

        private void btnModificarModelo_Click(object sender, EventArgs e)
        {
            ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
            Modelo modelo = new Modelo();
            if (dataModelos.Rows.Count > 0 && dataModelos.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataModelos.CurrentCell.RowIndex;
                int IDModelo = int.Parse(dataModelos.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                modelo = modeloRepositorio.FIndById(IDModelo);
                //MessageBox.Show("Lo hizo");
                AdmModelos admModelos = new AdmModelos(modelo);
                admModelos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrarModelo_Click(object sender, EventArgs e)
        {
            ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
            Modelo modelo = new Modelo();
            if (dataModelos.Rows.Count > 0 && dataModelos.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataModelos.CurrentCell.RowIndex;
                int IDModelo = int.Parse(dataModelos.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                modelo = modeloRepositorio.FIndById(IDModelo);

                DialogResult dialogResult = MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    modeloRepositorio.Eliminar(modelo);
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
