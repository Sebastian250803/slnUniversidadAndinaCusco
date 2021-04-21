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
    public partial class fmrAsignatura : Form
    {
        public fmrAsignatura()
        {
            InitializeComponent();
        }
        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            int creditos = int.Parse(txtCreditos.Text);
            int notaAprobar = int.Parse(txtNotaAprobar.Text);
            asignatura1.Nombres = nombres;
            asignatura1.Creditos = creditos;
            asignatura1.NotaAprobar = notaAprobar;
            MessageBox.Show("Se han registrado correctamente los datos de Asignatura 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = asignatura1.Nombres;
            int creditos = asignatura1.Creditos;
            int notaAprobar = asignatura1.NotaAprobar;
            MessageBox.Show("Nombres: " + nombres + "Creditos: " + creditos + "Nota Aprobar: " + notaAprobar);
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Estudiar());
        }

        private void btnParticipar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Participar());
        }

        private void btnPreguntar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Preguntar());
        }
    }
}
