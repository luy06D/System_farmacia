﻿namespace DESIGNER.Formularios
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.rbBoleta = new System.Windows.Forms.RadioButton();
            this.rdFactura = new System.Windows.Forms.RadioButton();
            this.BOLETA = new System.Windows.Forms.Label();
            this.txtdatos = new System.Windows.Forms.TextBox();
            this.lbldatos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtneto = new System.Windows.Forms.TextBox();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnd = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEmpresa = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnregistrarP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbBoleta
            // 
            this.rbBoleta.AutoSize = true;
            this.rbBoleta.Checked = true;
            this.rbBoleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBoleta.Location = new System.Drawing.Point(476, 57);
            this.rbBoleta.Margin = new System.Windows.Forms.Padding(4);
            this.rbBoleta.Name = "rbBoleta";
            this.rbBoleta.Size = new System.Drawing.Size(67, 21);
            this.rbBoleta.TabIndex = 5;
            this.rbBoleta.TabStop = true;
            this.rbBoleta.Text = "Boleta";
            this.rbBoleta.UseVisualStyleBackColor = false;
            this.rbBoleta.CheckedChanged += new System.EventHandler(this.rbBoleta_CheckedChanged);
            // 
            // rdFactura
            // 
            this.rdFactura.AutoSize = true;
            this.rdFactura.Location = new System.Drawing.Point(476, 96);
            this.rdFactura.Margin = new System.Windows.Forms.Padding(4);
            this.rdFactura.Name = "rdFactura";
            this.rdFactura.Size = new System.Drawing.Size(75, 21);
            this.rdFactura.TabIndex = 6;
            this.rdFactura.Text = "Factura";
            this.rdFactura.UseVisualStyleBackColor = true;
            this.rdFactura.CheckedChanged += new System.EventHandler(this.rdFactura_CheckedChanged);
            // 
            // BOLETA
            // 
            this.BOLETA.AutoSize = true;
            this.BOLETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOLETA.Location = new System.Drawing.Point(472, 25);
            this.BOLETA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BOLETA.Name = "BOLETA";
            this.BOLETA.Size = new System.Drawing.Size(156, 18);
            this.BOLETA.TabIndex = 4;
            this.BOLETA.Text = "Comprobante de pago";
            // 
            // txtdatos
            // 
            this.txtdatos.Enabled = false;
            this.txtdatos.Location = new System.Drawing.Point(821, 79);
            this.txtdatos.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatos.Name = "txtdatos";
            this.txtdatos.Size = new System.Drawing.Size(400, 23);
            this.txtdatos.TabIndex = 10;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Location = new System.Drawing.Point(688, 82);
            this.lbldatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(124, 17);
            this.lbldatos.TabIndex = 9;
            this.lbldatos.Text = "Datos del Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(31, 64);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(624, 23);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Location = new System.Drawing.Point(873, 113);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(142, 39);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Réiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(31, 122);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(65, 23);
            this.txtStock.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(170, 122);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(66, 23);
            this.txtPrecio.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Stock:";
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.colIdProducto,
            this.Descripcion,
            this.precioventa,
            this.total,
            this.unidad,
            this.btnEliminar});
            this.gridProductos.Location = new System.Drawing.Point(146, 369);
            this.gridProductos.Margin = new System.Windows.Forms.Padding(4);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersWidth = 62;
            this.gridProductos.Size = new System.Drawing.Size(1252, 278);
            this.gridProductos.TabIndex = 3;
            this.gridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellContentClick);
            this.gridProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridProductos_CellPainting);
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 8;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 150;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // precioventa
            // 
            this.precioventa.HeaderText = "Precio";
            this.precioventa.MinimumWidth = 8;
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Width = 200;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 150;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            this.unidad.Width = 150;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Text = "";
            this.btnEliminar.Width = 70;
            // 
            // txtneto
            // 
            this.txtneto.Enabled = false;
            this.txtneto.Location = new System.Drawing.Point(1318, 733);
            this.txtneto.Margin = new System.Windows.Forms.Padding(4);
            this.txtneto.Name = "txtneto";
            this.txtneto.Size = new System.Drawing.Size(80, 23);
            this.txtneto.TabIndex = 8;
            // 
            // txtigv
            // 
            this.txtigv.Enabled = false;
            this.txtigv.Location = new System.Drawing.Point(1318, 699);
            this.txtigv.Margin = new System.Windows.Forms.Padding(4);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(80, 23);
            this.txtigv.TabIndex = 6;
            // 
            // txtsub
            // 
            this.txtsub.Enabled = false;
            this.txtsub.Location = new System.Drawing.Point(1318, 665);
            this.txtsub.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(80, 23);
            this.txtsub.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1270, 736);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Neto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1275, 705);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "IGV:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1244, 668);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Subtotal:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(154, 766);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            this.lblUsuario.TabIndex = 28;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Location = new System.Drawing.Point(1217, 766);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(181, 41);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(996, 766);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(181, 41);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 842);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(1547, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(313, 122);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(66, 23);
            this.numCantidad.TabIndex = 11;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("barcode font", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(25, 38);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(132, 57);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // txtempresa
            // 
            this.txtempresa.Enabled = false;
            this.txtempresa.Location = new System.Drawing.Point(821, 79);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(400, 23);
            this.txtempresa.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarProductos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUnd);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.btnReiniciar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.numCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(352, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 171);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de productos";
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.Location = new System.Drawing.Point(511, 30);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(144, 27);
            this.btnBuscarProductos.TabIndex = 14;
            this.btnBuscarProductos.Text = "Buscar Productos";
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "UNIDAD / BLISTER";
            // 
            // txtUnd
            // 
            this.txtUnd.Location = new System.Drawing.Point(453, 121);
            this.txtUnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnd.Name = "txtUnd";
            this.txtUnd.Size = new System.Drawing.Size(111, 23);
            this.txtUnd.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(874, 60);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 37);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarEmpresa);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnEmpresa);
            this.groupBox2.Controls.Add(this.btnregistrarP);
            this.groupBox2.Controls.Add(this.lbldatos);
            this.groupBox2.Controls.Add(this.txtdatos);
            this.groupBox2.Controls.Add(this.txtempresa);
            this.groupBox2.Controls.Add(this.BOLETA);
            this.groupBox2.Controls.Add(this.rbBoleta);
            this.groupBox2.Controls.Add(this.rdFactura);
            this.groupBox2.Location = new System.Drawing.Point(146, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1252, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del cliente";
            // 
            // btnBuscarEmpresa
            // 
            this.btnBuscarEmpresa.Enabled = false;
            this.btnBuscarEmpresa.Location = new System.Drawing.Point(1079, 47);
            this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
            this.btnBuscarEmpresa.Size = new System.Drawing.Size(142, 25);
            this.btnBuscarEmpresa.TabIndex = 38;
            this.btnBuscarEmpresa.Text = "Buscar Empresa";
            this.btnBuscarEmpresa.UseVisualStyleBackColor = true;
            this.btnBuscarEmpresa.Click += new System.EventHandler(this.btnBuscarEmpresa_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1079, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 27);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar cliente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nueva empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nuevo cliente";
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpresa.BackgroundImage")));
            this.btnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.Location = new System.Drawing.Point(309, 92);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(52, 28);
            this.btnEmpresa.TabIndex = 3;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnregistrarP
            // 
            this.btnregistrarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrarP.BackgroundImage")));
            this.btnregistrarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregistrarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrarP.Location = new System.Drawing.Point(309, 22);
            this.btnregistrarP.Name = "btnregistrarP";
            this.btnregistrarP.Size = new System.Drawing.Size(52, 28);
            this.btnregistrarP.TabIndex = 1;
            this.btnregistrarP.UseVisualStyleBackColor = true;
            this.btnregistrarP.Click += new System.EventHandler(this.btnregistrarP_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBarcode);
            this.groupBox3.Location = new System.Drawing.Point(146, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 116);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscador por codigo";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1547, 865);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.txtigv);
            this.Controls.Add(this.txtneto);
            this.Controls.Add(this.gridProductos);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBoleta;
        private System.Windows.Forms.RadioButton rdFactura;
        private System.Windows.Forms.Label BOLETA;
        private System.Windows.Forms.TextBox txtdatos;
        private System.Windows.Forms.Label lbldatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.TextBox txtneto;
        private System.Windows.Forms.TextBox txtigv;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.Button btnregistrarP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnd;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Button btnBuscarEmpresa;
    }
}