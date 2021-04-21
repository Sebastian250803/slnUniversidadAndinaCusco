using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class fmrRector : Form
    {
        public fmrRector()
        {
            InitializeComponent();
        }
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string lugarNacimiento = txtLugarNacimiento.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.LugarNacimiento = lugarNacimiento;
            MessageBox.Show("Se han registrado correctamente los datos de Rector 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombres;
            string lugarNacimiento = rector1.LugarNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Lugar Nacimiento: " + lugarNacimiento);
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Supervisar());
        }

        private void btnAdministar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Administrar());
        }

        private void btnControlar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Controlar());
        }
    }
}
