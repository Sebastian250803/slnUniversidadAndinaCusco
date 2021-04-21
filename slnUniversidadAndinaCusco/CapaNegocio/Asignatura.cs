using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //Atributos
        private string nombres;
        private int creditos;
        private int notaAprobar;
        //Propiedades
        public string Nombres
        {
            get { return nombres; } //Lectura del atributo 
            set { nombres = value; } //Escritura del atributo 
        }
        public int Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
        public int NotaAprobar
        {
            get { return notaAprobar; }
            set { notaAprobar = value; }
        }
        //Metodos u Operaciones 
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
        public string Participar()
        {
            return "No se ha implementado el metodo participar";
        }
        public string Preguntar()
        {
            return "No se ha implementado el metodo preguntar";
        }
    }
}
