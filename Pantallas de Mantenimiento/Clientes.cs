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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            AdmClientes admClientes = new AdmClientes();
            admClientes.ShowDialog();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            dataClientes.DataSource = clienteRepositorio.GetAll();
            
        }
    }
}
