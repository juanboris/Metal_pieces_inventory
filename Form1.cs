/*Interfaz del programa a partir de un
 form con el formato típico de windows*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioMetalForms
{
    public partial class Form1 : Form
    {

        ListaInventario listaInventario = new ListaInventario();

        /*Creo un array para mostrar los mensajes
         de error que pudieran surgir a lo largo del form*/
        public string[] mensajes = new string[]
        {
            "No has introducido un número entero",
            "Te has dejado algún campo vacío",
        };
        //Creo un método para actualizar las cifras de las cantidades
        public void RefrescarCantidades()
        {
            int numTo, numEs, numRo, numEj, numTa;

            numTo = listaInventario.CantidadesElementos("tornillo");
            numEs = listaInventario.CantidadesElementos("escuadra");
            numRo = listaInventario.CantidadesElementos("rodamiento");
            numEj = listaInventario.CantidadesElementos("eje");
            numTa = listaInventario.CantidadesElementos("taco");
            tbCantidadTotal.Text = listaInventario.Inventario.Count.ToString();
            tbNumeroTornillos.Text = numTo.ToString();
            tbNumeroEscuadras.Text = numEs.ToString();
            tbNumeroRodam.Text = numRo.ToString();
            tbNumeroEjes.Text = numEj.ToString();
            tbNumeroTacos.Text = numTa.ToString();
        }


        /*Método para actualizar la list box cuando se hace alguna modificación 
        en la lista. Primero borro lo que había anteriormente y luego muestro
        los nuevos datos*/
        public void ActualizarLista()
        {
            lbInventario.Items.Clear();

            foreach (Pieza p in listaInventario.Inventario)
            {

                lbInventario.Items.Add(p);
            }
        }
        public Form1()
        {
            InitializeComponent();
            listaInventario.CargarLista();
            RefrescarCantidades();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        /*Creo un evento para eliminar un producto de la lista
         dependiendo del elemento seleccionado por el usuario*/
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (lbInventario.SelectedIndices.Count == 1)
            {
                listaInventario.Inventario.Remove(listaInventario.Inventario[lbInventario.SelectedIndex]);
            }
            else
            {
                foreach (Pieza n in lbInventario.SelectedItems)
                {
                    listaInventario.Inventario.Remove(n);
                }
            }
            RefrescarCantidades();
            ActualizarLista();
        }

        //Evento para añadir un elemento escuadra
        private void btAnyadirEscuadra_Click(object sender, EventArgs e)
        {
            {
                int espesor, ancho, largo, cantidadEscuadra;

                //Compruebo si el text box viene vacío
                if (string.IsNullOrWhiteSpace(tbTipoAcero.Text) ||
                    string.IsNullOrWhiteSpace(tbAncho.Text)
                    || string.IsNullOrWhiteSpace(tbLargo.Text) ||
                    string.IsNullOrWhiteSpace(tbEspesor.Text))
                {
                    MessageBox.Show(mensajes[1], "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                else
                {
                    //Compruebo si los datos enteros lo son
                    if ((!Int32.TryParse(tbEspesor.Text, out espesor)) ||
                        (!Int32.TryParse(tbAncho.Text, out ancho))
                        || (!Int32.TryParse(tbLargo.Text, out largo)))
                    {
                        MessageBox.Show(mensajes[0], "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Compruebo si cantidad está vacío y le introduzco 
                        //un valor por defecto
                        if (tbCantidadEscuadra.Text.Equals(""))
                        {
                            cantidadEscuadra = 1;
                        }
                        else
                        {
                            Int32.TryParse(tbCantidadEscuadra.Text,
                                out cantidadEscuadra);
                        }
                        for (int i = 0; i < cantidadEscuadra; i++)
                        {
                            listaInventario.Inventario.Add(new Escuadra(
                                tbTipoAcero.Text.ToString(), espesor, ancho, largo));
                            RefrescarCantidades();
                            ActualizarLista();
                        }
                    }
                }
            }
        }

        //Evento para añadir un elemento tornillo
        private void btAnyadirTornillo_Click(object sender, EventArgs e)
        {
            {
                int medida, cantidadTornillo;
                float paso;
                bool tuercaSeg = false;

                //Compruebo si el text box viene vacío
                if (string.IsNullOrWhiteSpace(tbPaso.Text) ||
                    string.IsNullOrWhiteSpace(tbMedida.Text))
                {
                    MessageBox.Show(mensajes[1], "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                else
                {
                    //Compruebo si los datos enteros lo son
                    if ((!Single.TryParse(tbPaso.Text, out paso)) ||
                        (!Int32.TryParse(tbMedida.Text, out medida)))
                    {
                        MessageBox.Show(mensajes[0], "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Compruebo si cantidad está vacío y le introduzco un valor por defecto
                        if (tbCantidadTornillo.Text.Equals(""))
                        {
                            cantidadTornillo = 1;
                        }
                        else
                        {
                            Int32.TryParse(tbCantidadTornillo.Text, out cantidadTornillo);
                        }
                        if (rbSi.Checked)
                        {
                            tuercaSeg = true;
                        }
                        for (int i = 0; i < cantidadTornillo; i++)
                        {
                            listaInventario.Inventario.Add(new Tornillo(paso, medida, tuercaSeg));
                            RefrescarCantidades();
                            ActualizarLista();
                        }
                    }
                }
            }
        }
        //Método para añadir un elemento rodamiento, eje o taco
        private void AnyadirPiezaRedo(string tipoPiezaRedon, TextBox tamanyo, TextBox cantidad)
        {
            int tamanyoEntero, cantidadPieza;
            elem tipoPieza = elem.Eje;

            //Compruebo si el text box viene vacío
            if (string.IsNullOrWhiteSpace(tamanyo.Text))
            {
                //Establezco mensajes personalizados para cada tipo
                if (tipoPiezaRedon.Equals("rodamiento") || tipoPiezaRedon.Equals("eje"))
                {
                    MessageBox.Show("Te has dejado el campo diámetro vacío", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Te has dejado el campo longitud vacío", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                //Compruebo si los datos enteros recibidos lo son
                if ((!Int32.TryParse(tamanyo.Text, out tamanyoEntero)))
                {
                    MessageBox.Show(mensajes[0], "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    //Compruebo si el elemento cantidad está vacío y, si es así, 
                    //le pongo un valor por defecto
                    if (cantidad.Text.Equals(""))
                    {
                        cantidadPieza = 1;
                    }
                    else
                    {
                        Int32.TryParse(cantidad.Text, out cantidadPieza);
                    }

                    //Dependiendo del elemento a insertar le doy un valor
                    //de enumeración diferente
                    if (tipoPiezaRedon.Equals("rodamiento"))
                    {
                        tipoPieza = elem.Rodamiento;
                    }
                    else if (tipoPiezaRedon.Equals("taco"))
                    {
                        tipoPieza = elem.Taco;
                    }
                    for (int i = 0; i < cantidadPieza; i++)
                    {
                        listaInventario.Inventario.Add(new PiezaRedo(tamanyoEntero, tipoPieza));
                        RefrescarCantidades();
                        ActualizarLista();
                    }
                }
            }

        }
        //Evento para añadir un eje
        private void btAnyadir_Click(object sender, EventArgs e)
        {
            AnyadirPiezaRedo("eje", tbTamanyoEje, tbCantidadEje);
        }

        //Evento para añadir un rodamiento
        private void btAnyadirRodam_Click(object sender, EventArgs e)
        {
            AnyadirPiezaRedo("rodamiento", tbTamanyoRodam, tbCantidadRodam);
        }

        //Evento para añadir un taco
        private void btCantidadTaco_Click(object sender, EventArgs e)
        {
            AnyadirPiezaRedo("taco", tbTamanyoTaco, tbCantidadTaco);
        }

        //Creo el evento para guardar el inventario
        //El icono lo he sacado es de Freepik de www.flaticon.com
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            listaInventario.EscribirArchivo();
        }

        /*Evento que se inicia cuando se cierra el programa
         para presentar una ventana de confirmación y guardar
         la lista en un archivo si el usuario decide salir
         de forma definitiva*/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro que quieres salir?",
                "Salir",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                listaInventario.EscribirArchivo();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
