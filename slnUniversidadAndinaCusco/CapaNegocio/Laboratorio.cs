using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //Atributos
        private string nombres;
        private string ubicacion;
        private int creditos;
        //Propiedades
        public string Nombres
        {
            get { return nombres; } //Lectura del atributo 
            set { nombres = value; } //Escritura del atributo 
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public int Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
        //Metodos u Operaciones 
        public string Experimentar()
        {
            return "No se ha implementado el metodo experimentar";
        }
        public string Ensamblar()
        {
            return "No se ha implementado el metodo ensamblar";
        }
        public string Cortar()
        {
            return "No se ha implementado el metodo aprobar cortar";
        }
    }
}
