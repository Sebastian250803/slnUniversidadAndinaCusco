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
    public partial class fmrNotas : Form
    {
        public fmrNotas()
        {
            InitializeComponent();
        }
        CapaNegocio.Notas notas1 = new CapaNegocio.Notas();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string curso = txtCurso.Text;
            string aporte = txtAporte.Text;
            string semestre = txtSemestre.Text;
            notas1.Curso = curso;
            notas1.Aporte = aporte;
            notas1.Semestre = semestre;
            MessageBox.Show("Se han registrado correctamente los datos de Notas 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string curso = notas1.Curso;
            string aporte = notas1.Aporte;
            string semestre = notas1.Semestre;
            MessageBox.Show("Curso: " + curso + "Aporte: " + aporte + "Semestre: " + semestre);
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Desaprobar());
        }
    }
}
