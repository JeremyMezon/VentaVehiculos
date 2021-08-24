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
    public partial class TipoTransmision : Form
    {
        public TipoTransmision()
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
    }
}
