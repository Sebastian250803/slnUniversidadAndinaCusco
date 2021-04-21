using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        //Atributos
        private string nombres;
        private string apellidos;
        private string lugarNacimiento;
        //Propiedades
        public string Nombres
        {
            get { return nombres; } //Lectura del atributo 
            set { nombres = value; } //Escritura del atributo 
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string LugarNacimiento
        {
            get { return lugarNacimiento; }
            set { lugarNacimiento = value; }
        }
        //Metodos u Operaciones 
        public string Supervisar()
        {
            return "No se ha implementado el metodo supervisar";
        }
        public string Administrar()
        {
            return "No se ha implementado el metodo administrar";
        }
        public string Controlar()
        {
            return "No se ha implementado el metodo controlar";
        }
    }
}
