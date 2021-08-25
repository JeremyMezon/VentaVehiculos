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
    public partial class TipoCombustibles : Form
    {
        public TipoCombustibles()
        {
            InitializeComponent();
        }

        void actualizarTabla()
        {
            try
            { 
                TipoCombustibleRepositorio clienteRepositorio = new TipoCombustibleRepositorio();
                dataCombustible.DataSource = clienteRepositorio.GetAll().Select(x => new { 
                    x.Id,
                    x.NombreCombustible,x.Vehiculos,x.FechaRegistro,x.FechaActualizacion
                }).ToList();
            }
            catch(Exception e)
            {
                MessageBox.Show("No hay datos que mostrar en la tabla");
            }
        }

        private void btnActualizarTablaCombustible_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void TipoCombustible_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnNuevoCombustible_Click(object sender, EventArgs e)
        {
            AdmTipoCombustibles admTipoCombustible = new AdmTipoCombustibles();
            admTipoCombustible.ShowDialog();
        }

        private void btnModificarCombustible_Click(object sender, EventArgs e)
        {
            TipoCombustibleRepositorio tipoCombustibleRepositorio = new TipoCombustibleRepositorio();
            TipoCombustible tipoCombustible = new TipoCombustible();
            if (dataCombustible.Rows.Count > 0 && dataCombustible.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataCombustible.CurrentCell.RowIndex;
                int IDTipoCombustible = int.Parse(dataCombustible.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                tipoCombustible = tipoCombustibleRepositorio.FIndById(IDTipoCombustible);
                AdmTipoCombustibles admTipoCombustible = new AdmTipoCombustibles(tipoCombustible);
                admTipoCombustible.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrarCombustible_Click(object sender, EventArgs e)
        {
            TipoCombustibleRepositorio tipoCombustibleRepositorio = new TipoCombustibleRepositorio();
            TipoCombustible tipoCombustible = new TipoCombustible();
            if (dataCombustible.Rows.Count > 0 && dataCombustible.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataCombustible.CurrentCell.RowIndex;
                int IDTipoCombustible = int.Parse(dataCombustible.Rows[filaSeleccionada].Cells["Id"].Value.ToString());
                tipoCombustible = tipoCombustibleRepositorio.FIndById(IDTipoCombustible);

                DialogResult dialogResult = MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    tipoCombustibleRepositorio.Eliminar(tipoCombustible);
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
