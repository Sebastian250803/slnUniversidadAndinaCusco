using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento; 
        //Propiedades
        public string Apellidos
        {
            get { return apellidos; } //Lectura del atributo 
            set { apellidos = value; } //Escritura del atributo 
        }
        public string Nombres
        {
            get { return nombres; } //Lectura del atributo 
            set { nombres = value; } //Escritura del atributo 
        }
        public int Edad
        {
            get { return edad; } //Lectura del atributo 
            set { edad = value; } //Escritura del atributo 
        }
        public string LugarNacimiento
        {
            get { return this.lugarNacimiento; } //Lectura del atributo 
            set { this.lugarNacimiento = value; } //Escritura del atributo 
        }
        //Metodos u Operaciones 
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string AprobarExamen()
        {
            return "No se ha implementado el metodo aprobar examen";
        }
    }
}
