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
    public partial class TipoCombustible : Form
    {
        public TipoCombustible()
        {
            InitializeComponent();
        }

        void actualizarTabla()
        {
            TipoCombustibleRepositorio clienteRepositorio = new TipoCombustibleRepositorio();
            dataCombustible.DataSource = clienteRepositorio.GetAll();
        }

        private void btnActualizarTablaCombustible_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void TipoCombustible_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }
    }
}
