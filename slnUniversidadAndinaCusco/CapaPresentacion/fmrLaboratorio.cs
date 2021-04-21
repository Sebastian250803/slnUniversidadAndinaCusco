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
    public partial class fmrLaboratorio : Form
    {
        public fmrLaboratorio()
        {
            InitializeComponent();
        }
        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string ubicacion = txtUbicacion.Text;
            int creditos = int.Parse(txtCreditos.Text);
            laboratorio1.Nombres = nombres;
            laboratorio1.Ubicacion = ubicacion;
            laboratorio1.Creditos = creditos;
            MessageBox.Show("Se han registrado correctamente los datos del Laboratorio 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1 
            string nombres = laboratorio1.Nombres;
            string ubicacion = laboratorio1.Ubicacion;
            int creditos = laboratorio1.Creditos;
            MessageBox.Show("Nombres: " + nombres + "Ubicacion: " + ubicacion + "Creditos: " + creditos);
        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Experimentar());
        }

        private void btnEnsamblar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Ensamblar());
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Cortar());
        }
    }
}
