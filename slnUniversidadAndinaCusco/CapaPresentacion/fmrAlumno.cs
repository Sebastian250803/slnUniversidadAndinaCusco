﻿using System;
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
    public partial class fmrAlumno : Form
    {
        public fmrAlumno()
        {
            InitializeComponent();
        }

        //Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Alumno alumno1 = new CapaNegocio.Alumno();
        
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarNacimiento = txtLugarNacimiento.Text;
            alumno1.Apellidos = apellidos;
            alumno1.Nombres = nombres;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = lugarNacimiento;
            MessageBox.Show("Se han registrado correctamente los datos del Alumno 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1 
            string apellidos = alumno1.Apellidos;
            string nombres = alumno1.Nombres;
            int edad = alumno1.Edad;
            string lugarNacimiento = alumno1.LugarNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Edad: " + edad + "Lugar Nacimiento: " + lugarNacimiento);
        }

        private void btbEstudiar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Estudiar
            MessageBox.Show(alumno1.Estudiar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.Trabajar());
        }

        private void btnAprobarExamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.AprobarExamen());
        }
    }
}
