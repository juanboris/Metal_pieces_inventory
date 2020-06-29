/*Clase que define las piezas redondas, a partir
 de la clase pieza, mediante sus atributos tamaño
 y el tipo de elemento que es: eje, rodamiento
 o taco*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioMetalForms
{
    public enum elem { Eje, Rodamiento, Taco };
    public class PiezaRedo : Pieza
    {
        private int tamanyo;
        private elem elemento;

        /*Constructor para construir objetos desde 
        la lectura de un archivo*/
        public PiezaRedo(int diametro, elem elemento,
            int id, DateTime fecha) : base(id, fecha)
        {
            this.tamanyo = diametro;
            this.elemento = elemento;
        }

        /*Constructor para construir objetos en la función
        añadir del programa*/
        public PiezaRedo(int diametro, elem elemento)
        {
            this.tamanyo = diametro;
            this.elemento = elemento;
        }

        public int Tamanyo
        {
            get
            {
                return tamanyo;
            }
            set
            {
                tamanyo = value;
            }
        }
        public elem Elemento
        {
            get
            {
                return elemento;
            }
            set
            {
                elemento = value;
            }
        }

        //Método para mostrar en pantalla los objetos
        public override string ToString()
        {
            string resultado;

            if (Elemento.Equals(elem.Eje))
            {
                resultado = "Eje.- Diámetro: " + Tamanyo;
            }
            else if (Elemento.Equals(elem.Rodamiento))
            {
                resultado = "Rodamiento.- Diámetro: " + Tamanyo;
            }
            else
            {
                resultado = "Taco.- Longitud: " + Tamanyo;
            }

            return resultado;
        }
        
        //Método para escribir en un archivo los objetos
        public override string FormatoArchivo()
        {
            string resultado;

            if (Elemento.Equals(elem.Eje))
            {
                resultado = "Eje;" + Tamanyo + ";" + 
                    base.FormatoArchivo();
            }
            else if (Elemento.Equals(elem.Rodamiento))
            {
                resultado = "Rodamiento;" + Tamanyo + ";" + 
                    base.FormatoArchivo();
            }
            else
            {
                resultado = "Taco;" + Tamanyo + ";" + 
                    base.FormatoArchivo();
            }

            return resultado;
        }
    }
}
