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
    }
}
