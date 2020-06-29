/*Clase que define una escuadra, a partir
 de la clase pieza, mediante los atributos
 tipo de acero, espesor, ancho y largo*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioMetalForms
{
    public class Escuadra : Pieza
    {
        private string tipo_acero;
        private int espesor;
        private int ancho;
        private int largo;

        /*Constructor para construir objetos desde 
        la lectura de un archivo*/
        public Escuadra(string tipo_acero, int espesor,
            int ancho, int largo, int id, DateTime fecha) :
            base(id, fecha)
        {
            this.tipo_acero = tipo_acero;
            this.espesor = espesor;
            this.ancho = ancho;
            this.largo = largo;
        }

        /*Constructor para construir objetos en la función
        añadir del programa*/
        public Escuadra(string tipo_acero, int espesor,
        int ancho, int largo)
        {
            this.tipo_acero = tipo_acero;
            this.espesor = espesor;
            this.ancho = ancho;
            this.largo = largo;
        }

        public string Tipo_Acero
        {
            get
            {
                return tipo_acero;
            }
            set
            {
                tipo_acero = value;
            }
        }
        public int Espesor
        {
            get
            {
                return espesor;
            }
            set
            {
                espesor = value;
            }
        }

        public int Ancho
        {
            get
            {
                return espesor;
            }
            set
            {
                espesor = value;
            }
        }

        public int Largo
        {
            get
            {
                return largo;
            }
            set
            {
                largo = value;
            }
        }

        //Método para mostrar en pantalla los objetos
        public override string ToString()
        {
            return "Escuadra.- Acero: " + Tipo_Acero + " Espesor: " + 
                Espesor + " Ancho:" + Ancho + " Largo: " + Largo;
        }

        //Método para escribir en un archivo los objetos
        public override string FormatoArchivo()
        {
            return "Escuadra;" + Tipo_Acero + ";" + Espesor + ";" + 
                Ancho + ";" + Largo + ";" + base.FormatoArchivo();
        }
    }
}
