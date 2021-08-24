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
        public AdmModelos()
        {
            InitializeComponent();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {

        }

        private void AdmModelos_Load(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            ModeloRepositorio modeloRep = new ModeloRepositorio();
            comboMarcas.DataSource = modeloRep.GetAll();
            

        }
    }
}
