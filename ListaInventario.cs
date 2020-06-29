/*
 *Clase utilizada para alojar la lista del inventario
 * Carga los elementos que hay en un archivo,
 * si existieran, y si no crea un archivo para
 * almacenarlos
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioMetalForms
{
    struct fechaArchErr
    {
        public int anyo;
        public int mes;
        public int dia;
        public int hora;
        public int minutos;
        public int segundos;
    }

    public class ListaInventario
    {
        private List<Pieza> inventario;

        public ListaInventario()
        {
            inventario = new List<Pieza>();
        }

        public List<Pieza> Inventario
        {
            get
            {
                return inventario;
            }
        }

        //Método para cargar los elementos presentes 
        //en un archivo a la lista
        public void CargarLista()
        {
            const char BARRA = '/';
            const char PUNTOCOMA = ';';
            const char DOSPUNTOS = ':';
            StreamReader leerInventario, leerInvErro;
            StreamWriter escribirInventario, escErrInv;
            string linea, fechaCade, fechaHoy;
            DateTime fechaActual = DateTime.Now;
            fechaArchErr fechaError;
            fechaCade = fechaActual.ToString();
            string[] fechaCadeTemp = fechaCade.Split();
            string[] numerosDiaErr = fechaCadeTemp[0].Split(BARRA);
            string[] numerosHoraErr = fechaCadeTemp[1].Split(DOSPUNTOS);
            fechaError.anyo = Convert.ToInt32(numerosDiaErr[2]);
            fechaError.mes = Convert.ToInt32(numerosDiaErr[1]);
            fechaError.dia = Convert.ToInt32(numerosDiaErr[0]);
            fechaError.hora = Convert.ToInt32(numerosHoraErr[0]);
            fechaError.minutos = Convert.ToInt32(numerosHoraErr[1]);
            fechaError.segundos = Convert.ToInt32(numerosHoraErr[2]);

            fechaHoy = FechaStruct("estándar");

            //Leo y creo un documento de errores
            try
            {
                leerInvErro = File.OpenText("erroresInve.txt");
            }
            catch (FileNotFoundException)
            {
                escErrInv = File.CreateText("erroresInve.txt");
                escErrInv.Close();
            }

            try
            {

                leerInventario = File.OpenText("inventarioGlobal.txt");

                do
                {
                    linea = leerInventario.ReadLine();
                    if (linea != null)
                    {
                        string[] lineaTemp = linea.Split(PUNTOCOMA);
                        if (lineaTemp[0].Equals("Tornillo"))
                        {
                            string[] fechaTemp = lineaTemp[4].Split();
                            string[] numerosDia = fechaTemp[0].Split(BARRA);
                            string[] numerosHora = fechaTemp[1].Split(DOSPUNTOS);
                            inventario.Add(new Tornillo(Convert.ToSingle(lineaTemp[1]), Convert.ToInt32(lineaTemp[2]),
                                false, Convert.ToInt32(lineaTemp[3]), new DateTime(Convert.ToInt32(numerosDia[2]),
                                Convert.ToInt32(numerosDia[1]), Convert.ToInt32(numerosDia[0]),
                                Convert.ToInt32(numerosHora[0]), Convert.ToInt32(numerosHora[1]),
                                Convert.ToInt32(numerosHora[2]))));
                        }
                        else if (lineaTemp[0].Equals("TornilloSeg"))
                        {
                            string[] fechaTemp = lineaTemp[4].Split();
                            string[] numerosDia = fechaTemp[0].Split(BARRA);
                            string[] numerosHora = fechaTemp[1].Split(DOSPUNTOS);
                            inventario.Add(new Tornillo(Convert.ToSingle(lineaTemp[1]), 
                                Convert.ToInt32(lineaTemp[2]), true, Convert.ToInt32(lineaTemp[3]), 
                                new DateTime(Convert.ToInt32(numerosDia[2]),
                                Convert.ToInt32(numerosDia[1]), Convert.ToInt32(numerosDia[0]),
                                Convert.ToInt32(numerosHora[0]), Convert.ToInt32(numerosHora[1]),
                                Convert.ToInt32(numerosHora[2]))));
                        }
                        else if (lineaTemp[0].Equals("Eje"))
                        {
                            string[] fechaTemp = lineaTemp[3].Split();
                            string[] numerosDia = fechaTemp[0].Split(BARRA);
                            string[] numerosHora = fechaTemp[1].Split(DOSPUNTOS);
                            inventario.Add(new PiezaRedo(Convert.ToInt32(lineaTemp[1]), 
                                elem.Eje, Convert.ToInt32(lineaTemp[2]),
                                new DateTime(Convert.ToInt32(numerosDia[2]), 
                                Convert.ToInt32(numerosDia[1]), Convert.ToInt32(numerosDia[0]),
                                Convert.ToInt32(numerosHora[0]), Convert.ToInt32(numerosHora[1]),
                                Convert.ToInt32(numerosHora[2]))));
                        }
                        else if (lineaTemp[0].Equals("Rodamiento"))
                        {
                            string[] fechaTemp = lineaTemp[3].Split();
                            string[] numerosDia = fechaTemp[0].Split(BARRA);
                            string[] numerosHora = fechaTemp[1].Split(DOSPUNTOS);
                            inventario.Add(new PiezaRedo(Convert.ToInt32(lineaTemp[1]), 
                                elem.Rodamiento, Convert.ToInt32(lineaTemp[2]),
                                new DateTime(Convert.ToInt32(numerosDia[2]), 
                                Convert.ToInt32(numerosDia[1]), Convert.ToInt32(numerosDia[0]),
                                Convert.ToInt32(numerosHora[0]), Convert.ToInt32(numerosHora[1]),
                                Convert.ToInt32(numerosHora[2]))));
                        }
                        else if (lineaTemp[0].Equals("Taco"))
                        {
                            string[] fechaTemp = lineaTemp[3].Split();
                            string[] numerosDia = fechaTemp[0].Split(BARRA);
                            string[] numerosHora = fechaTemp[1].Split(DOSPUNTOS);
                            inventario.Add(new PiezaRedo(Convert.ToInt32(lineaTemp[1]), elem.Taco, 
                                Convert.ToInt32(lineaTemp[2]), new DateTime(Convert.ToInt32(numerosDia[2]), 
                                Convert.ToInt32(numerosDia[1]), Convert.ToInt32(numerosDia[0]),
                                Convert.ToInt32(numerosHora[0]), Convert.ToInt32(numerosHora[1]),
                                Convert.ToInt32(numerosHora[2]))));
                        }
                        else if (lineaTemp[0].Equals("Escuadra"))
                        {
                            string[] fechaTemp = lineaTemp[6].Split();
                            string[] numerosDia = fechaTemp[0].Split(BARRA);
                            string[] numerosHora = fechaTemp[1].Split(DOSPUNTOS);
                            this.inventario.Add(new Escuadra(lineaTemp[1], Convert.ToInt32(lineaTemp[2]), 
                                Convert.ToInt32(lineaTemp[3]), Convert.ToInt32(lineaTemp[4]), 
                                Convert.ToInt32(lineaTemp[5]), new DateTime(Convert.ToInt32(numerosDia[2]),
                                Convert.ToInt32(numerosDia[1]), Convert.ToInt32(numerosDia[0]),
                                Convert.ToInt32(numerosHora[0]), Convert.ToInt32(numerosHora[1]),
                                Convert.ToInt32(numerosHora[2]))));
                        }

                    }
                } while (linea != null);

                leerInventario.Close();
            }
            //Si no existe el archivo, lo creo
            catch (FileNotFoundException)
            {
                using (escribirInventario = new StreamWriter("inventarioGlobal.txt"))
                {
                }
            }
            //Introduzco los posibles mensajes de error en un archivo
            catch (DirectoryNotFoundException x)
            {
                escErrInv = File.AppendText("erroresInve.txt");
                escErrInv.Write("Mensaje del {0}:\n", fechaHoy);
                escErrInv.WriteLine(x.Message);
                escErrInv.Close();

            }
            catch (IOException e)
            {
                escErrInv = File.AppendText("erroresInve.txt");
                escErrInv.Write("Mensaje del {0}:\n", fechaHoy);
                escErrInv.WriteLine(e.Message);
                escErrInv.Close();
            }
        }
        /*Método que crea una cadena con la fecha
        decimal hoy a partir de un struct y un
        DateTime*/
        public string FechaStruct(string tipo)
        {
            const char BARRA = '/';
            const char DOSPUNTOS = ':';
            string fechaCade, fechaHoy;
            DateTime fechaActual = DateTime.Now;
            fechaArchErr fechaError;
            fechaCade = fechaActual.ToString();
            string[] fechaCadeTemp = fechaCade.Split();
            string[] numerosDiaErr = fechaCadeTemp[0].Split(BARRA);
            string[] numerosHoraErr = fechaCadeTemp[1].Split(DOSPUNTOS);
            fechaError.anyo = Convert.ToInt32(numerosDiaErr[2]);
            fechaError.mes = Convert.ToInt32(numerosDiaErr[1]);
            fechaError.dia = Convert.ToInt32(numerosDiaErr[0]);
            fechaError.hora = Convert.ToInt32(numerosHoraErr[0]);
            fechaError.minutos = Convert.ToInt32(numerosHoraErr[1]);
            fechaError.segundos = Convert.ToInt32(numerosHoraErr[2]);
            
            if (tipo.Equals("estándar"))
            {
                fechaHoy = fechaError.dia + "/" + fechaError.mes + "/" + 
                    fechaError.anyo + " " + fechaError.hora + ":" + 
                    fechaError.minutos + ":" + fechaError.segundos;
            }
            else
            {
                fechaHoy = fechaError.dia + "_" + fechaError.mes + "_" + 
                    fechaError.anyo + "_" + fechaError.hora + "_" + 
                    fechaError.minutos + "_" + fechaError.segundos;
            }
            
            return fechaHoy;
        }

        //Calculo los elementos que hay en la lista
        //para poder mostrarlos en la interfaz
        public int CantidadesElementos(string tipo)
        {
            int cantidad = 0;

            if (tipo.Equals("tornillo"))
            {
                foreach (Pieza p in inventario)
                {
                    if (p is Tornillo piez)
                    {
                        cantidad++;
                    }
                }
            }
            else if (tipo.Equals("escuadra"))
            {
                foreach (Pieza p in inventario)
                {
                    if (p is Escuadra piez)
                    {
                        cantidad++;
                    }
                }
            }
            else if (tipo.Equals("rodamiento"))
            {
                foreach (Pieza p in inventario)
                {
                    if (p is PiezaRedo piez && piez.Elemento.Equals(elem.Rodamiento))
                    {
                        cantidad++;
                    }
                }
            }
            else if (tipo.Equals("eje"))
            {
                foreach (Pieza p in inventario)
                {
                    if (p is PiezaRedo piez && piez.Elemento.Equals(elem.Eje))
                    {
                        cantidad++;
                    }
                }
            }
            else if (tipo.Equals("taco"))
            {
                foreach (Pieza p in inventario)
                {
                    if (p is PiezaRedo piez && piez.Elemento.Equals(elem.Taco))
                    {
                        cantidad++;
                    }
                }
            }
            return cantidad;
        }

        /*Método para escribir la lista en un archivo de texto.
         Creo un archivo si este no existe y, si existe, lo
         sobreescribo con el inventario actualizado*/
        public void EscribirArchivo()
        {
            StreamWriter escribirInventario, escribirError;
            StreamReader leerErroresInve;
            string nomFichero, fechaFichero, copiasSegDirectorio, ficheroErr,
                fechaErr;
            
            fechaFichero = FechaStruct("fichero");
            inventario.Sort();
            DateTime fecha = DateTime.Now;

            fechaErr = fecha.ToString("g");
            ficheroErr = "erroresInvEscrib.txt";

            //Creo un archivo de texto para almacenar los errores
            //que surjan de la creación de archivos
            try
            {
                leerErroresInve = File.OpenText(ficheroErr);
            }
            catch (FileNotFoundException)
            {
                escribirError = File.CreateText(ficheroErr);
                escribirError.Close();
            }

            //Sobrescribo el archivo del inventario global
            try
            {
                using (escribirInventario = new StreamWriter("inventarioGlobal.txt", false))
                {
                    foreach (Pieza p in inventario)
                    {
                        escribirInventario.WriteLine(p.FormatoArchivo());
                    }
                }
            }
            catch (DirectoryNotFoundException x)
            {
                escribirError = File.AppendText(ficheroErr);
                escribirError.Write("Mensaje del {0}:\n", fechaErr);
                escribirError.WriteLine(x.Message);
                escribirError.Close();

            }
            catch (IOException e)
            {
                escribirError = File.AppendText(ficheroErr);
                escribirError.Write("Mensaje del {0}:\n", fechaErr);
                escribirError.WriteLine(e.Message);
                escribirError.Close();
            }

            //Creo un archivo con el inventario de hoy
            copiasSegDirectorio = "copiasSeguridadInven";

            //Creo un directorio para meter en él las copias de seguridad
            if (!Directory.Exists(copiasSegDirectorio))
            {
                Directory.CreateDirectory(copiasSegDirectorio);
            }
            nomFichero = "copiasSeguridadInven\\inventario" + fechaFichero + ".txt";

            try
            {
                using (escribirInventario = new StreamWriter(nomFichero, false))
                {
                    foreach (Pieza p in inventario)
                    {
                        escribirInventario.WriteLine(p.FormatoArchivo());
                    }
                }
            }
            catch (DirectoryNotFoundException x)
            {
                escribirError = File.AppendText(ficheroErr);
                escribirError.Write("Mensaje del {0}:\n", fechaErr);
                escribirError.WriteLine(x.Message);
                escribirError.Close();

            }
            catch (IOException e)
            {
                escribirError = File.AppendText(ficheroErr);
                escribirError.Write("Mensaje del {0}:\n", fechaErr);
                escribirError.WriteLine(e.Message);
                escribirError.Close();
            }
        }
    }
}
