using System;
using System.Windows.Forms;

namespace InventarioMetalForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbInventario = new System.Windows.Forms.ListBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbCantidadEscuadra = new System.Windows.Forms.TextBox();
            this.lbCantidadEscuadra = new System.Windows.Forms.Label();
            this.btAnyadirEscuadra = new System.Windows.Forms.Button();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.tbEspesor = new System.Windows.Forms.TextBox();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbTipoAcero = new System.Windows.Forms.TextBox();
            this.lbAncho = new System.Windows.Forms.Label();
            this.lbLargo = new System.Windows.Forms.Label();
            this.lbEspesor = new System.Windows.Forms.Label();
            this.lbTipoAcero = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btAnyadirTornillo = new System.Windows.Forms.Button();
            this.lbTuercaSeg = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.tbCantidadTornillo = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.tbMedida = new System.Windows.Forms.TextBox();
            this.lbMedida = new System.Windows.Forms.Label();
            this.tbPaso = new System.Windows.Forms.TextBox();
            this.lbPaso = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btAnyadir = new System.Windows.Forms.Button();
            this.tbCantidadEje = new System.Windows.Forms.TextBox();
            this.lbCantidadEje = new System.Windows.Forms.Label();
            this.tbTamanyoEje = new System.Windows.Forms.TextBox();
            this.lbTamanyoEje = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbCantidadRodam = new System.Windows.Forms.TextBox();
            this.tbTamanyoRodam = new System.Windows.Forms.TextBox();
            this.lbCantidadRodam = new System.Windows.Forms.Label();
            this.btAnyadirRodam = new System.Windows.Forms.Button();
            this.lbTamanyoRodam = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btCantidadTaco = new System.Windows.Forms.Button();
            this.lbTamanyoTaco = new System.Windows.Forms.Label();
            this.lbCantidadTaco = new System.Windows.Forms.Label();
            this.tbTamanyoTaco = new System.Windows.Forms.TextBox();
            this.tbCantidadTaco = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCantidadTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumeroEscuadras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumeroTornillos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumeroEjes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNumeroRodam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumeroTacos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInventario
            // 
            this.lbInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInventario.FormattingEnabled = true;
            this.lbInventario.ItemHeight = 16;
            this.lbInventario.Location = new System.Drawing.Point(416, 89);
            this.lbInventario.Name = "lbInventario";
            this.lbInventario.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbInventario.Size = new System.Drawing.Size(539, 356);
            this.lbInventario.TabIndex = 5;
            // 
            // btEliminar
            // 
            this.btEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btEliminar.Location = new System.Drawing.Point(640, 468);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 38);
            this.btEliminar.TabIndex = 6;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 400);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbCantidadEscuadra);
            this.tabPage1.Controls.Add(this.lbCantidadEscuadra);
            this.tabPage1.Controls.Add(this.btAnyadirEscuadra);
            this.tabPage1.Controls.Add(this.tbLargo);
            this.tabPage1.Controls.Add(this.tbEspesor);
            this.tabPage1.Controls.Add(this.tbAncho);
            this.tabPage1.Controls.Add(this.tbTipoAcero);
            this.tabPage1.Controls.Add(this.lbAncho);
            this.tabPage1.Controls.Add(this.lbLargo);
            this.tabPage1.Controls.Add(this.lbEspesor);
            this.tabPage1.Controls.Add(this.lbTipoAcero);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Escuadra";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbCantidadEscuadra
            // 
            this.tbCantidadEscuadra.Location = new System.Drawing.Point(128, 214);
            this.tbCantidadEscuadra.Name = "tbCantidadEscuadra";
            this.tbCantidadEscuadra.Size = new System.Drawing.Size(100, 22);
            this.tbCantidadEscuadra.TabIndex = 4;
            // 
            // lbCantidadEscuadra
            // 
            this.lbCantidadEscuadra.AutoSize = true;
            this.lbCantidadEscuadra.Location = new System.Drawing.Point(141, 194);
            this.lbCantidadEscuadra.Name = "lbCantidadEscuadra";
            this.lbCantidadEscuadra.Size = new System.Drawing.Size(64, 17);
            this.lbCantidadEscuadra.TabIndex = 3;
            this.lbCantidadEscuadra.Text = "Cantidad";
            // 
            // btAnyadirEscuadra
            // 
            this.btAnyadirEscuadra.Location = new System.Drawing.Point(141, 278);
            this.btAnyadirEscuadra.Name = "btAnyadirEscuadra";
            this.btAnyadirEscuadra.Size = new System.Drawing.Size(75, 30);
            this.btAnyadirEscuadra.TabIndex = 2;
            this.btAnyadirEscuadra.Text = "Añadir";
            this.btAnyadirEscuadra.UseVisualStyleBackColor = true;
            this.btAnyadirEscuadra.Click += new System.EventHandler(this.btAnyadirEscuadra_Click);
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(201, 150);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(100, 22);
            this.tbLargo.TabIndex = 1;
            // 
            // tbEspesor
            // 
            this.tbEspesor.Location = new System.Drawing.Point(58, 150);
            this.tbEspesor.Name = "tbEspesor";
            this.tbEspesor.Size = new System.Drawing.Size(100, 22);
            this.tbEspesor.TabIndex = 1;
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(201, 82);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(100, 22);
            this.tbAncho.TabIndex = 1;
            // 
            // tbTipoAcero
            // 
            this.tbTipoAcero.Location = new System.Drawing.Point(58, 82);
            this.tbTipoAcero.Name = "tbTipoAcero";
            this.tbTipoAcero.Size = new System.Drawing.Size(100, 22);
            this.tbTipoAcero.TabIndex = 1;
            // 
            // lbAncho
            // 
            this.lbAncho.AutoSize = true;
            this.lbAncho.Location = new System.Drawing.Point(198, 62);
            this.lbAncho.Name = "lbAncho";
            this.lbAncho.Size = new System.Drawing.Size(48, 17);
            this.lbAncho.TabIndex = 0;
            this.lbAncho.Text = "Ancho";
            // 
            // lbLargo
            // 
            this.lbLargo.AutoSize = true;
            this.lbLargo.Location = new System.Drawing.Point(198, 130);
            this.lbLargo.Name = "lbLargo";
            this.lbLargo.Size = new System.Drawing.Size(45, 17);
            this.lbLargo.TabIndex = 0;
            this.lbLargo.Text = "Largo";
            // 
            // lbEspesor
            // 
            this.lbEspesor.AutoSize = true;
            this.lbEspesor.Location = new System.Drawing.Point(55, 130);
            this.lbEspesor.Name = "lbEspesor";
            this.lbEspesor.Size = new System.Drawing.Size(60, 17);
            this.lbEspesor.TabIndex = 0;
            this.lbEspesor.Text = "Espesor";
            // 
            // lbTipoAcero
            // 
            this.lbTipoAcero.AutoSize = true;
            this.lbTipoAcero.Location = new System.Drawing.Point(55, 62);
            this.lbTipoAcero.Name = "lbTipoAcero";
            this.lbTipoAcero.Size = new System.Drawing.Size(96, 17);
            this.lbTipoAcero.TabIndex = 0;
            this.lbTipoAcero.Text = "Tipo de acero";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btAnyadirTornillo);
            this.tabPage2.Controls.Add(this.lbTuercaSeg);
            this.tabPage2.Controls.Add(this.rbNo);
            this.tabPage2.Controls.Add(this.rbSi);
            this.tabPage2.Controls.Add(this.tbCantidadTornillo);
            this.tabPage2.Controls.Add(this.lbCantidad);
            this.tabPage2.Controls.Add(this.tbMedida);
            this.tabPage2.Controls.Add(this.lbMedida);
            this.tabPage2.Controls.Add(this.tbPaso);
            this.tabPage2.Controls.Add(this.lbPaso);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tornillo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btAnyadirTornillo
            // 
            this.btAnyadirTornillo.Location = new System.Drawing.Point(141, 311);
            this.btAnyadirTornillo.Name = "btAnyadirTornillo";
            this.btAnyadirTornillo.Size = new System.Drawing.Size(75, 29);
            this.btAnyadirTornillo.TabIndex = 9;
            this.btAnyadirTornillo.Text = "Añadir";
            this.btAnyadirTornillo.UseVisualStyleBackColor = true;
            this.btAnyadirTornillo.Click += new System.EventHandler(this.btAnyadirTornillo_Click);
            // 
            // lbTuercaSeg
            // 
            this.lbTuercaSeg.AutoSize = true;
            this.lbTuercaSeg.Location = new System.Drawing.Point(107, 162);
            this.lbTuercaSeg.Name = "lbTuercaSeg";
            this.lbTuercaSeg.Size = new System.Drawing.Size(142, 17);
            this.lbTuercaSeg.TabIndex = 9;
            this.lbTuercaSeg.Text = "Tuerca de Seguridad";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(181, 191);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(47, 21);
            this.rbNo.TabIndex = 9;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(125, 191);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(41, 21);
            this.rbSi.TabIndex = 9;
            this.rbSi.Text = "Sí";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // tbCantidadTornillo
            // 
            this.tbCantidadTornillo.Location = new System.Drawing.Point(128, 253);
            this.tbCantidadTornillo.Name = "tbCantidadTornillo";
            this.tbCantidadTornillo.Size = new System.Drawing.Size(100, 22);
            this.tbCantidadTornillo.TabIndex = 1;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(143, 233);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(64, 17);
            this.lbCantidad.TabIndex = 0;
            this.lbCantidad.Text = "Cantidad";
            // 
            // tbMedida
            // 
            this.tbMedida.Location = new System.Drawing.Point(128, 117);
            this.tbMedida.Name = "tbMedida";
            this.tbMedida.Size = new System.Drawing.Size(100, 22);
            this.tbMedida.TabIndex = 1;
            // 
            // lbMedida
            // 
            this.lbMedida.AutoSize = true;
            this.lbMedida.Location = new System.Drawing.Point(153, 97);
            this.lbMedida.Name = "lbMedida";
            this.lbMedida.Size = new System.Drawing.Size(54, 17);
            this.lbMedida.TabIndex = 0;
            this.lbMedida.Text = "Medida";
            // 
            // tbPaso
            // 
            this.tbPaso.Location = new System.Drawing.Point(128, 50);
            this.tbPaso.Name = "tbPaso";
            this.tbPaso.Size = new System.Drawing.Size(100, 22);
            this.tbPaso.TabIndex = 1;
            // 
            // lbPaso
            // 
            this.lbPaso.AutoSize = true;
            this.lbPaso.Location = new System.Drawing.Point(153, 30);
            this.lbPaso.Name = "lbPaso";
            this.lbPaso.Size = new System.Drawing.Size(40, 17);
            this.lbPaso.TabIndex = 0;
            this.lbPaso.Text = "Paso";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btAnyadir);
            this.tabPage3.Controls.Add(this.tbCantidadEje);
            this.tabPage3.Controls.Add(this.lbCantidadEje);
            this.tabPage3.Controls.Add(this.tbTamanyoEje);
            this.tabPage3.Controls.Add(this.lbTamanyoEje);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(356, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eje";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btAnyadir
            // 
            this.btAnyadir.Location = new System.Drawing.Point(141, 162);
            this.btAnyadir.Name = "btAnyadir";
            this.btAnyadir.Size = new System.Drawing.Size(75, 30);
            this.btAnyadir.TabIndex = 9;
            this.btAnyadir.Text = "Añadir";
            this.btAnyadir.UseVisualStyleBackColor = true;
            this.btAnyadir.Click += new System.EventHandler(this.btAnyadir_Click);
            // 
            // tbCantidadEje
            // 
            this.tbCantidadEje.Location = new System.Drawing.Point(128, 112);
            this.tbCantidadEje.Name = "tbCantidadEje";
            this.tbCantidadEje.Size = new System.Drawing.Size(100, 22);
            this.tbCantidadEje.TabIndex = 9;
            // 
            // lbCantidadEje
            // 
            this.lbCantidadEje.AutoSize = true;
            this.lbCantidadEje.Location = new System.Drawing.Point(146, 92);
            this.lbCantidadEje.Name = "lbCantidadEje";
            this.lbCantidadEje.Size = new System.Drawing.Size(64, 17);
            this.lbCantidadEje.TabIndex = 9;
            this.lbCantidadEje.Text = "Cantidad";
            // 
            // tbTamanyoEje
            // 
            this.tbTamanyoEje.Location = new System.Drawing.Point(128, 48);
            this.tbTamanyoEje.Name = "tbTamanyoEje";
            this.tbTamanyoEje.Size = new System.Drawing.Size(100, 22);
            this.tbTamanyoEje.TabIndex = 9;
            // 
            // lbTamanyoEje
            // 
            this.lbTamanyoEje.AutoSize = true;
            this.lbTamanyoEje.Location = new System.Drawing.Point(146, 28);
            this.lbTamanyoEje.Name = "lbTamanyoEje";
            this.lbTamanyoEje.Size = new System.Drawing.Size(65, 17);
            this.lbTamanyoEje.TabIndex = 9;
            this.lbTamanyoEje.Text = "Diámetro";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tbCantidadRodam);
            this.tabPage4.Controls.Add(this.tbTamanyoRodam);
            this.tabPage4.Controls.Add(this.lbCantidadRodam);
            this.tabPage4.Controls.Add(this.btAnyadirRodam);
            this.tabPage4.Controls.Add(this.lbTamanyoRodam);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(356, 371);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rodamiento";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbCantidadRodam
            // 
            this.tbCantidadRodam.Location = new System.Drawing.Point(128, 112);
            this.tbCantidadRodam.Name = "tbCantidadRodam";
            this.tbCantidadRodam.Size = new System.Drawing.Size(100, 22);
            this.tbCantidadRodam.TabIndex = 10;
            // 
            // tbTamanyoRodam
            // 
            this.tbTamanyoRodam.Location = new System.Drawing.Point(128, 48);
            this.tbTamanyoRodam.Name = "tbTamanyoRodam";
            this.tbTamanyoRodam.Size = new System.Drawing.Size(100, 22);
            this.tbTamanyoRodam.TabIndex = 10;
            // 
            // lbCantidadRodam
            // 
            this.lbCantidadRodam.AutoSize = true;
            this.lbCantidadRodam.Location = new System.Drawing.Point(146, 92);
            this.lbCantidadRodam.Name = "lbCantidadRodam";
            this.lbCantidadRodam.Size = new System.Drawing.Size(64, 17);
            this.lbCantidadRodam.TabIndex = 9;
            this.lbCantidadRodam.Text = "Cantidad";
            // 
            // btAnyadirRodam
            // 
            this.btAnyadirRodam.Location = new System.Drawing.Point(141, 162);
            this.btAnyadirRodam.Name = "btAnyadirRodam";
            this.btAnyadirRodam.Size = new System.Drawing.Size(75, 30);
            this.btAnyadirRodam.TabIndex = 0;
            this.btAnyadirRodam.Text = "Añadir";
            this.btAnyadirRodam.UseVisualStyleBackColor = true;
            this.btAnyadirRodam.Click += new System.EventHandler(this.btAnyadirRodam_Click);
            // 
            // lbTamanyoRodam
            // 
            this.lbTamanyoRodam.AutoSize = true;
            this.lbTamanyoRodam.Location = new System.Drawing.Point(146, 28);
            this.lbTamanyoRodam.Name = "lbTamanyoRodam";
            this.lbTamanyoRodam.Size = new System.Drawing.Size(65, 17);
            this.lbTamanyoRodam.TabIndex = 9;
            this.lbTamanyoRodam.Text = "Diámetro";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btCantidadTaco);
            this.tabPage5.Controls.Add(this.lbTamanyoTaco);
            this.tabPage5.Controls.Add(this.lbCantidadTaco);
            this.tabPage5.Controls.Add(this.tbTamanyoTaco);
            this.tabPage5.Controls.Add(this.tbCantidadTaco);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(356, 371);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Taco";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btCantidadTaco
            // 
            this.btCantidadTaco.Location = new System.Drawing.Point(141, 162);
            this.btCantidadTaco.Name = "btCantidadTaco";
            this.btCantidadTaco.Size = new System.Drawing.Size(75, 30);
            this.btCantidadTaco.TabIndex = 11;
            this.btCantidadTaco.Text = "Añadir";
            this.btCantidadTaco.UseVisualStyleBackColor = true;
            this.btCantidadTaco.Click += new System.EventHandler(this.btCantidadTaco_Click);
            // 
            // lbTamanyoTaco
            // 
            this.lbTamanyoTaco.AutoSize = true;
            this.lbTamanyoTaco.Location = new System.Drawing.Point(147, 28);
            this.lbTamanyoTaco.Name = "lbTamanyoTaco";
            this.lbTamanyoTaco.Size = new System.Drawing.Size(63, 17);
            this.lbTamanyoTaco.TabIndex = 9;
            this.lbTamanyoTaco.Text = "Longitud";
            // 
            // lbCantidadTaco
            // 
            this.lbCantidadTaco.AutoSize = true;
            this.lbCantidadTaco.Location = new System.Drawing.Point(146, 92);
            this.lbCantidadTaco.Name = "lbCantidadTaco";
            this.lbCantidadTaco.Size = new System.Drawing.Size(64, 17);
            this.lbCantidadTaco.TabIndex = 9;
            this.lbCantidadTaco.Text = "Cantidad";
            // 
            // tbTamanyoTaco
            // 
            this.tbTamanyoTaco.Location = new System.Drawing.Point(128, 48);
            this.tbTamanyoTaco.Name = "tbTamanyoTaco";
            this.tbTamanyoTaco.Size = new System.Drawing.Size(100, 22);
            this.tbTamanyoTaco.TabIndex = 10;
            // 
            // tbCantidadTaco
            // 
            this.tbCantidadTaco.Location = new System.Drawing.Point(128, 112);
            this.tbCantidadTaco.Name = "tbCantidadTaco";
            this.tbCantidadTaco.Size = new System.Drawing.Size(100, 22);
            this.tbCantidadTaco.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1015, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(29, 24);
            this.tsbGuardar.Text = "toolStripButton1";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cantidad total";
            // 
            // tbCantidadTotal
            // 
            this.tbCantidadTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidadTotal.Location = new System.Drawing.Point(565, 6);
            this.tbCantidadTotal.Name = "tbCantidadTotal";
            this.tbCantidadTotal.Size = new System.Drawing.Size(87, 26);
            this.tbCantidadTotal.TabIndex = 11;
            this.tbCantidadTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Escuadras";
            // 
            // tbNumeroEscuadras
            // 
            this.tbNumeroEscuadras.Location = new System.Drawing.Point(93, 13);
            this.tbNumeroEscuadras.Name = "tbNumeroEscuadras";
            this.tbNumeroEscuadras.Size = new System.Drawing.Size(45, 22);
            this.tbNumeroEscuadras.TabIndex = 13;
            this.tbNumeroEscuadras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tornillos";
            // 
            // tbNumeroTornillos
            // 
            this.tbNumeroTornillos.Location = new System.Drawing.Point(210, 13);
            this.tbNumeroTornillos.Name = "tbNumeroTornillos";
            this.tbNumeroTornillos.Size = new System.Drawing.Size(45, 22);
            this.tbNumeroTornillos.TabIndex = 13;
            this.tbNumeroTornillos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ejes";
            // 
            // tbNumeroEjes
            // 
            this.tbNumeroEjes.Location = new System.Drawing.Point(300, 13);
            this.tbNumeroEjes.Name = "tbNumeroEjes";
            this.tbNumeroEjes.Size = new System.Drawing.Size(45, 22);
            this.tbNumeroEjes.TabIndex = 13;
            this.tbNumeroEjes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rodamientos";
            // 
            // tbNumeroRodam
            // 
            this.tbNumeroRodam.Location = new System.Drawing.Point(446, 13);
            this.tbNumeroRodam.Name = "tbNumeroRodam";
            this.tbNumeroRodam.Size = new System.Drawing.Size(45, 22);
            this.tbNumeroRodam.TabIndex = 13;
            this.tbNumeroRodam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tacos";
            // 
            // tbNumeroTacos
            // 
            this.tbNumeroTacos.Location = new System.Drawing.Point(548, 13);
            this.tbNumeroTacos.Name = "tbNumeroTacos";
            this.tbNumeroTacos.Size = new System.Drawing.Size(45, 22);
            this.tbNumeroTacos.TabIndex = 13;
            this.tbNumeroTacos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNumeroTacos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbNumeroRodam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbNumeroEjes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNumeroTornillos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNumeroEscuadras);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(397, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 48);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbCantidadTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.lbInventario);
            this.Name = "Form1";
            this.Text = "Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbInventario;
        private System.Windows.Forms.Button btEliminar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lbAncho;
        private Label lbLargo;
        private Label lbEspesor;
        private Label lbTipoAcero;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button btAnyadirEscuadra;
        private TextBox tbLargo;
        private TextBox tbEspesor;
        private TextBox tbAncho;
        private TextBox tbTipoAcero;
        private TextBox tbCantidadEscuadra;
        private Label lbCantidadEscuadra;
        private TextBox tbCantidadTornillo;
        private Label lbCantidad;
        private TextBox tbMedida;
        private Label lbMedida;
        private TextBox tbPaso;
        private Label lbPaso;
        private Label lbTuercaSeg;
        private RadioButton rbNo;
        private RadioButton rbSi;
        private Button btAnyadirTornillo;
        private Button btAnyadir;
        private TextBox tbCantidadEje;
        private Label lbCantidadEje;
        private TextBox tbTamanyoEje;
        private Label lbTamanyoEje;
        private TextBox tbCantidadRodam;
        private TextBox tbTamanyoRodam;
        private Label lbCantidadRodam;
        private Button btAnyadirRodam;
        private Label lbTamanyoRodam;
        private Button btCantidadTaco;
        private Label lbTamanyoTaco;
        private Label lbCantidadTaco;
        private TextBox tbTamanyoTaco;
        private TextBox tbCantidadTaco;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbGuardar;
        private Label label1;
        private TextBox tbCantidadTotal;
        private Label label2;
        private TextBox tbNumeroEscuadras;
        private Label label3;
        private TextBox tbNumeroTornillos;
        private Label label4;
        private TextBox tbNumeroEjes;
        private Label label5;
        private TextBox tbNumeroRodam;
        private Label label6;
        private TextBox tbNumeroTacos;
        private GroupBox groupBox1;
    }
}

