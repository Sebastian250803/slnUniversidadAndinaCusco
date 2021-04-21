using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        //Atributos
        private string nombreAlumno;
        private string apellidoAlumno;
        private string lugarPractica;
        //Propiedades
        public string NombresAlumno
        {
            get { return nombreAlumno; } //Lectura del atributo 
            set { nombreAlumno = value; } //Escritura del atributo 
        }
        public string ApellidosAlumno
        {
            get { return apellidoAlumno; }
            set { apellidoAlumno = value; }
        }
        public string LugarPractica
        {
            get { return lugarPractica; }
            set { lugarPractica = value; }
        }
        //Metodos u Operaciones 
        public string Experimentar()
        {
            return "No se ha implementado el metodo experimentar";
        }
        public string Aprender()
        {
            return "No se ha implementado el metodo aprender";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
    }
}
