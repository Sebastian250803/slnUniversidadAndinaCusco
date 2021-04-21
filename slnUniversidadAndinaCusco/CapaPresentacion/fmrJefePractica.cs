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
    public partial class fmrJefePractica : Form
    {
        public fmrJefePractica()
        {
            InitializeComponent();
        }
        CapaNegocio.JefePractica jefePractica1 = new CapaNegocio.JefePractica();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string dni = txtDni.Text;
            jefePractica1.Nombres = nombres;
            jefePractica1.Apellidos = apellidos;
            jefePractica1.Dni = dni;
            MessageBox.Show("Se han registrado correctamente los datos de Jefe Practica 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = jefePractica1.Nombres;
            string apellidos = jefePractica1.Apellidos;
            string dni = jefePractica1.Dni;
            MessageBox.Show("Nombres: " + nombres + "Apellidos: " + apellidos + "Dni: " + dni);
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Supervisar());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Enseñar());
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Corregir());
        }
    }
}
