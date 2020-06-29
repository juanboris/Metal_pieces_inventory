/*Clase que define las piezas con los
 atributos id y fecha*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventarioMetalForms
{
    public abstract class Pieza : IComparable<Pieza>
    {
        private int id;
        private DateTime fecha;

        /*Constructor que no recibe parámetros y que 
         se utilizará para añadir productos desde
         el programa*/
        public Pieza()
        {
            this.fecha = DateTime.Now;

            StreamReader leerID, leerErrores;

            string linea;
            int idHeredado = 0;
            StreamWriter escribirError, escribirID;

            //Creo un archivo de texto para almacenar los errores
            //que surjan de la creación de archivos
            try
            {
                leerErrores = File.OpenText("erroresId.txt");
            }
            catch (FileNotFoundException)
            {
                escribirError = File.CreateText("erroresId.txt");
                escribirError.Close();
            }

            /*Creo un archivo de texto que almacenará la id
             * de cada elemento del inventario y que irá 
             * aumentando a medida que se añadan productos
             */
            try
            {
                leerID = File.OpenText("idPiezasMetal.txt");

                linea = leerID.ReadLine();
                if (linea != null)
                {
                    idHeredado = Convert.ToInt32(linea);
                }

                leerID.Close();

                idHeredado += 1;
                Id = idHeredado;

                using (escribirID = new StreamWriter("idPiezasMetal.txt", false))
                {
                    escribirID.WriteLine(Id);
                }
            }
            catch (FileNotFoundException)
            {
                using (escribirID = new StreamWriter("idPiezasMetal.txt"))
                {
                    id++;
                    escribirID.WriteLine(Id);
                }
            }
            catch (DirectoryNotFoundException x)
            {
                escribirError = File.AppendText("erroresId.txt");
                escribirError.Write("Mensaje del {0}:\n", fecha);
                escribirError.WriteLine(x.Message);
                escribirError.Close();

            }
            catch (IOException e)
            {
                escribirError = File.AppendText("erroresId.txt");
                escribirError.Write("Mensaje del {0}:\n", fecha);
                escribirError.WriteLine(e.Message);
                escribirError.Close();
            }

        }

        /*Constructor que recibe dos parámetros y que 
         se utilizará para leer los elementos dispuestos
         en el fichero que guarda los productos de
         forma permanente*/
        public Pieza(int id, DateTime fecha)
        {
            this.fecha = fecha;

            this.id = id;

        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        //Método que ordena ascendentemente los productos según su id
        public int CompareTo(Pieza p)
        {
            return id.CompareTo(p.id);
        }

        //Método para escribir los atributos en el archivo
        public virtual string FormatoArchivo()
        {
            return Id + ";" + fecha;
        }
    }
}

