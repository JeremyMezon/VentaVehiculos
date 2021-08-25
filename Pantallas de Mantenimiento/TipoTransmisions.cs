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
    public partial class TipoTransmisions : Form
    {
        public TipoTransmisions()
        {
            InitializeComponent();
        }

        private void btnActualizarTablaTransmision_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        void actualizarTabla()
        {
            TipoTransmisionRepositorio transmisionRepositorio = new TipoTransmisionRepositorio();
            dataTransmision.DataSource = transmisionRepositorio.GetAll();
        }

        private void TipoTransmision_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnNuevoTransmision_Click(object sender, EventArgs e)
        {
            AdmTipoTransmisions admTipoTransmision = new AdmTipoTransmisions();
            admTipoTransmision.ShowDialog();
        }

        private void btnModificarTransmision_Click(object sender, EventArgs e)
        {
            TipoTransmisionRepositorio tipoTransmisionRepositorio = new TipoTransmisionRepositorio();
            TipoTransmision tipoTransmision = new TipoTransmision();
            if (dataTransmision.Rows.Count > 0 && dataTransmision.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataTransmision.CurrentCell.RowIndex;
                int IDTipoTransmision = int.Parse(dataTransmision.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                tipoTransmision = tipoTransmisionRepositorio.FIndById(IDTipoTransmision);
                AdmTipoTransmisions admTipoTransmision = new AdmTipoTransmisions(tipoTransmision);
                admTipoTransmision.ShowDialog();


            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrarTransmision_Click(object sender, EventArgs e)
        {
            TipoTransmisionRepositorio tipoTransmisionRepositorio = new TipoTransmisionRepositorio();
            TipoTransmision tipoTransmision = new TipoTransmision();
            if (dataTransmision.Rows.Count > 0 && dataTransmision.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataTransmision.CurrentCell.RowIndex;
                int IDTipoTransmision = int.Parse(dataTransmision.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                tipoTransmision = tipoTransmisionRepositorio.FIndById(IDTipoTransmision);

                DialogResult dialogResult = MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    tipoTransmisionRepositorio.Eliminar(tipoTransmision);
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
