/*Clase que define un tornillo, a partir
 de la clase pieza, mediante los atributos
 de paso, medida y tuerca de seguridad*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioMetalForms
{
    public class Tornillo : Pieza
    {
        private float paso;
        private int medida;
        private bool tuercaSeg;

        /*Constructor para construir objetos desde 
         la lectura de un archivo*/
        public Tornillo(float paso, int medida, bool tuercaSeg,
            int id, DateTime fecha) : base(id, fecha)
        {
            this.paso = paso;
            this.medida = medida;
            this.tuercaSeg = tuercaSeg;
        }

        /*Constructor para construir objetos en la función
         añadir del programa*/
        public Tornillo(float paso, int medida, bool tuercaSeg)
        {
            this.paso = paso;
            this.medida = medida;
            this.tuercaSeg = tuercaSeg;
        }

        public float Paso
        {
            get
            {
                return paso;
            }
            set
            {
                paso = value;
            }
        }

        public int Medida
        {
            get
            {
                return medida;
            }
            set
            {
                medida = value;
            }
        }
        public bool TuercaSeg
        {
            get
            {
                return tuercaSeg;
            }
            set
            {
                tuercaSeg = value;
            }
        }

        //Método para mostrar en pantalla los objetos
        public override string ToString()
        {
            string resultado;

            if (tuercaSeg)
            {
                resultado = "Tornillo con Tuerca de Seguridad.- Paso: " + 
                    Paso + " Medida: " + Medida;
            }
            else
            {
                resultado = "Tornillo.- Paso: " + Paso + " Medida: " + Medida;
            }
            return resultado;
        }

        //Método para escribir en un archivo los objetos
        public override string FormatoArchivo()
        {
            string resultado;

            if (tuercaSeg)
            {
                resultado = "TornilloSeg;" + Paso + ";" + Medida + ";" + 
                    base.FormatoArchivo();
            }
            else
            {
                resultado = "Tornillo;" + Paso + ";" + Medida + ";" + 
                    base.FormatoArchivo();
            }
            return resultado;
        }
    }
}
