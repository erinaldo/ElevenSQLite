/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 9:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmDocumento
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private StatusStrip statusStrip1;
		private Label label2;
		private TextBox txtTipoDocumento;
		private Label label3;
		private Label lbConsecutivo;
		private GroupBox groupBox1;
		private TabControl tabControl1;
		private DateTimePicker dtpFechaCreacion;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private GroupBox groupBox2;
		private CheckBox checkObservacion2;
		private CheckBox checkObservacion1;
		private Label label19;
		private TextBox txtTotal;
		private TextBox txtIVA;
		private TextBox txtDescuento;
		private TextBox txtSubtotal;
		private Label label18;
		private Label label17;
		private Label label16;
		private TextBox txtObservacion;
		private TabControl tabControl2;
		private TabPage tabPage3;
		private TabPage tabPage4;
		private GroupBox groupBox3;
		private TextBox txtReferencia;
		private Label label1;
		private Label label22;
		
		private Label label21;
		private Label label14;
		private ComboBox cbCondicion;
		private DateTimePicker dtpFechaVencimiento;
		private Label label24;
		private ComboBox cbTipoMoneda;
		private Button btnBuscarCliente;
		private Label label8;
		private TextBox txtDireccionTercero;
		public TextBox txtCodigoTercero;
		private TextBox txtNombreComercial;
		private Label label6;
		private Label label7;
		private Label label9;
		private TextBox txtDescuentoArticulo;
		private Button btnRemove;
		private Button btnAdd;
		private Button btnBuscarArticulo;
		private Label label13;
		private Label label12;
		private TextBox txtTotalArticulo;
		private Label lbValor;
		private TextBox txtPrecioUnitarioArticulo;
		private Label label10;
		private TextBox txtCantidadArticulo;
		private Label label15;
		private TextBox txtDescripcionArticulo;
		public TextBox txtCodigoArticulo;
		private Label label20;
		private DataGridView dataGridViewDetalles;
		private Label label23;
		private ComboBox cbEstadoDocumento;
		private TextBox txtCambio;
		private ComboBox cbTipoDocumentoMaestro;
		private Label label25;
		private BindingSource bindingSource1;
		private Button btBuscarTipoDocumento;
		private TextBox txtProntoPago;
		private TextBox txtRecargo;
		private Label label5;
		private Label label4;
		private Button btnDocumentoPadre;
		private Button btnCambiarDescuento;
		private Button btnCambiarIVA;
		private ComboBox cbImpresionDocumento;
		private Button btnBorrarCliente;
		private Label label11;
		private ComboBox cbEmpleado;
		private Label label26;
		private Label label28;
		private TextBox txtObservacionAlterna;
		private TextBox txtNombreProyecto;
		private Label label27;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnGuardar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocumento));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTipoDocumento = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbConsecutivo = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btBuscarTipoDocumento = new System.Windows.Forms.Button();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.cbTipoMoneda = new System.Windows.Forms.ComboBox();
			this.cbTipoDocumentoMaestro = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridViewDetalles = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label28 = new System.Windows.Forms.Label();
			this.txtObservacionAlterna = new System.Windows.Forms.TextBox();
			this.txtNombreProyecto = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.cbEmpleado = new System.Windows.Forms.ComboBox();
			this.txtProntoPago = new System.Windows.Forms.TextBox();
			this.txtRecargo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnBorrarCliente = new System.Windows.Forms.Button();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDireccionTercero = new System.Windows.Forms.TextBox();
			this.txtCodigoTercero = new System.Windows.Forms.TextBox();
			this.txtNombreComercial = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.checkObservacion2 = new System.Windows.Forms.CheckBox();
			this.checkObservacion1 = new System.Windows.Forms.CheckBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtIVA = new System.Windows.Forms.TextBox();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.cbImpresionDocumento = new System.Windows.Forms.ComboBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.cbEstadoDocumento = new System.Windows.Forms.ComboBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDocumentoPadre = new System.Windows.Forms.Button();
			this.txtReferencia = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
			this.label21 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.cbCondicion = new System.Windows.Forms.ComboBox();
			this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDescuentoArticulo = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtTotalArticulo = new System.Windows.Forms.TextBox();
			this.lbValor = new System.Windows.Forms.Label();
			this.txtPrecioUnitarioArticulo = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCantidadArticulo = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
			this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnCambiarIVA = new System.Windows.Forms.Button();
			this.btnCambiarDescuento = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnBuscarArticulo = new System.Windows.Forms.Button();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 574);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(794, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tipo:";
			// 
			// txtTipoDocumento
			// 
			this.txtTipoDocumento.Location = new System.Drawing.Point(200, 14);
			this.txtTipoDocumento.Name = "txtTipoDocumento";
			this.txtTipoDocumento.ReadOnly = true;
			this.txtTipoDocumento.Size = new System.Drawing.Size(156, 20);
			this.txtTipoDocumento.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(601, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Consecutivo:";
			// 
			// lbConsecutivo
			// 
			this.lbConsecutivo.AutoSize = true;
			this.lbConsecutivo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbConsecutivo.Location = new System.Drawing.Point(688, 15);
			this.lbConsecutivo.Name = "lbConsecutivo";
			this.lbConsecutivo.Size = new System.Drawing.Size(87, 18);
			this.lbConsecutivo.TabIndex = 9;
			this.lbConsecutivo.Text = "FV-000001";
			this.lbConsecutivo.DoubleClick += new System.EventHandler(this.lbConsecutivo_DoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btBuscarTipoDocumento);
			this.groupBox1.Controls.Add(this.txtCambio);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.cbTipoMoneda);
			this.groupBox1.Controls.Add(this.lbConsecutivo);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbTipoDocumentoMaestro);
			this.groupBox1.Controls.Add(this.txtTipoDocumento);
			this.groupBox1.Location = new System.Drawing.Point(4, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(786, 45);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo documento";
			// 
			// btBuscarTipoDocumento
			// 
			this.btBuscarTipoDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarTipoDocumento.Image")));
			this.btBuscarTipoDocumento.Location = new System.Drawing.Point(362, 11);
			this.btBuscarTipoDocumento.Name = "btBuscarTipoDocumento";
			this.btBuscarTipoDocumento.Size = new System.Drawing.Size(24, 24);
			this.btBuscarTipoDocumento.TabIndex = 94;
			this.btBuscarTipoDocumento.UseVisualStyleBackColor = true;
			this.btBuscarTipoDocumento.Click += new System.EventHandler(this.btBuscarTipoDocumento_Click);
			// 
			// txtCambio
			// 
			this.txtCambio.Location = new System.Drawing.Point(531, 13);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(64, 20);
			this.txtCambio.TabIndex = 2;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(392, 20);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(56, 13);
			this.label24.TabIndex = 64;
			this.label24.Text = "Moneda:";
			// 
			// cbTipoMoneda
			// 
			this.cbTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoMoneda.FormattingEnabled = true;
			this.cbTipoMoneda.Location = new System.Drawing.Point(450, 12);
			this.cbTipoMoneda.Name = "cbTipoMoneda";
			this.cbTipoMoneda.Size = new System.Drawing.Size(75, 21);
			this.cbTipoMoneda.TabIndex = 1;
			this.cbTipoMoneda.SelectedIndexChanged += new System.EventHandler(this.cbTipoMoneda_SelectedIndexChanged);
			// 
			// cbTipoDocumentoMaestro
			// 
			this.cbTipoDocumentoMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoDocumentoMaestro.FormattingEnabled = true;
			this.cbTipoDocumentoMaestro.Location = new System.Drawing.Point(37, 13);
			this.cbTipoDocumentoMaestro.Name = "cbTipoDocumentoMaestro";
			this.cbTipoDocumentoMaestro.Size = new System.Drawing.Size(156, 21);
			this.cbTipoDocumentoMaestro.TabIndex = 0;
			this.cbTipoDocumentoMaestro.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocumentoMaestro_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(4, 249);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(786, 173);
			this.tabControl1.TabIndex = 9;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridViewDetalles);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(778, 147);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Detalle documento";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridViewDetalles
			// 
			this.dataGridViewDetalles.AllowUserToAddRows = false;
			this.dataGridViewDetalles.AllowUserToDeleteRows = false;
			this.dataGridViewDetalles.AllowUserToOrderColumns = true;
			this.dataGridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewDetalles.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewDetalles.MultiSelect = false;
			this.dataGridViewDetalles.Name = "dataGridViewDetalles";
			this.dataGridViewDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewDetalles.Size = new System.Drawing.Size(772, 141);
			this.dataGridViewDetalles.TabIndex = 0;
			this.dataGridViewDetalles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalles_CellDoubleClick);
			this.dataGridViewDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalles_CellEndEdit);
			this.dataGridViewDetalles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDetalles_CellFormatting);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label28);
			this.tabPage2.Controls.Add(this.txtObservacionAlterna);
			this.tabPage2.Controls.Add(this.txtNombreProyecto);
			this.tabPage2.Controls.Add(this.label27);
			this.tabPage2.Controls.Add(this.label26);
			this.tabPage2.Controls.Add(this.cbEmpleado);
			this.tabPage2.Controls.Add(this.txtProntoPago);
			this.tabPage2.Controls.Add(this.txtRecargo);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(778, 147);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Otros datos";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(272, 39);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(125, 13);
			this.label28.TabIndex = 96;
			this.label28.Text = "Observación alterna:";
			// 
			// txtObservacionAlterna
			// 
			this.txtObservacionAlterna.Location = new System.Drawing.Point(403, 32);
			this.txtObservacionAlterna.Name = "txtObservacionAlterna";
			this.txtObservacionAlterna.Size = new System.Drawing.Size(208, 20);
			this.txtObservacionAlterna.TabIndex = 95;
			// 
			// txtNombreProyecto
			// 
			this.txtNombreProyecto.Location = new System.Drawing.Point(403, 6);
			this.txtNombreProyecto.Name = "txtNombreProyecto";
			this.txtNombreProyecto.Size = new System.Drawing.Size(208, 20);
			this.txtNombreProyecto.TabIndex = 94;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(272, 13);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(128, 13);
			this.label27.TabIndex = 93;
			this.label27.Text = "Nombre del proyecto:";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(9, 9);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(54, 13);
			this.label26.TabIndex = 92;
			this.label26.Text = "Elaboro:";
			// 
			// cbEmpleado
			// 
			this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEmpleado.FormattingEnabled = true;
			this.cbEmpleado.Location = new System.Drawing.Point(100, 6);
			this.cbEmpleado.Name = "cbEmpleado";
			this.cbEmpleado.Size = new System.Drawing.Size(152, 21);
			this.cbEmpleado.TabIndex = 91;
			// 
			// txtProntoPago
			// 
			this.txtProntoPago.Location = new System.Drawing.Point(100, 63);
			this.txtProntoPago.Name = "txtProntoPago";
			this.txtProntoPago.Size = new System.Drawing.Size(44, 20);
			this.txtProntoPago.TabIndex = 3;
			// 
			// txtRecargo
			// 
			this.txtRecargo.Location = new System.Drawing.Point(100, 33);
			this.txtRecargo.Name = "txtRecargo";
			this.txtRecargo.Size = new System.Drawing.Size(44, 20);
			this.txtRecargo.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "% Pronto pago:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "% Recargo:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnBorrarCliente);
			this.groupBox2.Controls.Add(this.btnBuscarCliente);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtDireccionTercero);
			this.groupBox2.Controls.Add(this.txtCodigoTercero);
			this.groupBox2.Controls.Add(this.txtNombreComercial);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(4, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(446, 100);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tercero-Cliente-Proveedor";
			// 
			// btnBorrarCliente
			// 
			this.btnBorrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarCliente.Image")));
			this.btnBorrarCliente.Location = new System.Drawing.Point(252, 12);
			this.btnBorrarCliente.Name = "btnBorrarCliente";
			this.btnBorrarCliente.Size = new System.Drawing.Size(24, 24);
			this.btnBorrarCliente.TabIndex = 7;
			this.btnBorrarCliente.UseVisualStyleBackColor = true;
			this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
			this.btnBuscarCliente.Location = new System.Drawing.Point(222, 12);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(24, 24);
			this.btnBuscarCliente.TabIndex = 6;
			this.btnBuscarCliente.UseVisualStyleBackColor = true;
			this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(7, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Código:";
			// 
			// txtDireccionTercero
			// 
			this.txtDireccionTercero.Enabled = false;
			this.txtDireccionTercero.Location = new System.Drawing.Point(81, 65);
			this.txtDireccionTercero.Name = "txtDireccionTercero";
			this.txtDireccionTercero.ReadOnly = true;
			this.txtDireccionTercero.Size = new System.Drawing.Size(292, 20);
			this.txtDireccionTercero.TabIndex = 5;
			// 
			// txtCodigoTercero
			// 
			this.txtCodigoTercero.Location = new System.Drawing.Point(81, 16);
			this.txtCodigoTercero.Name = "txtCodigoTercero";
			this.txtCodigoTercero.Size = new System.Drawing.Size(135, 20);
			this.txtCodigoTercero.TabIndex = 1;
			this.txtCodigoTercero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoTercero_KeyPress);
			// 
			// txtNombreComercial
			// 
			this.txtNombreComercial.Enabled = false;
			this.txtNombreComercial.Location = new System.Drawing.Point(81, 39);
			this.txtNombreComercial.Name = "txtNombreComercial";
			this.txtNombreComercial.ReadOnly = true;
			this.txtNombreComercial.Size = new System.Drawing.Size(292, 20);
			this.txtNombreComercial.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(7, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Dirección:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(7, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Nombre:";
			// 
			// checkObservacion2
			// 
			this.checkObservacion2.AutoSize = true;
			this.checkObservacion2.Location = new System.Drawing.Point(171, 54);
			this.checkObservacion2.Name = "checkObservacion2";
			this.checkObservacion2.Size = new System.Drawing.Size(158, 17);
			this.checkObservacion2.TabIndex = 77;
			this.checkObservacion2.Text = "Plantilla de observación dos";
			this.checkObservacion2.UseVisualStyleBackColor = true;
			this.checkObservacion2.CheckedChanged += new System.EventHandler(this.checkObservacion2_CheckedChanged);
			// 
			// checkObservacion1
			// 
			this.checkObservacion1.AutoSize = true;
			this.checkObservacion1.Location = new System.Drawing.Point(6, 54);
			this.checkObservacion1.Name = "checkObservacion1";
			this.checkObservacion1.Size = new System.Drawing.Size(159, 17);
			this.checkObservacion1.TabIndex = 76;
			this.checkObservacion1.Text = "Plantilla de observación uno";
			this.checkObservacion1.UseVisualStyleBackColor = true;
			this.checkObservacion1.CheckedChanged += new System.EventHandler(this.checkObservacion1_CheckedChanged);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(568, 467);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(72, 13);
			this.label19.TabIndex = 75;
			this.label19.Text = "Descuento:";
			// 
			// txtTotal
			// 
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(642, 513);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(120, 20);
			this.txtTotal.TabIndex = 10;
			// 
			// txtIVA
			// 
			this.txtIVA.Location = new System.Drawing.Point(642, 487);
			this.txtIVA.Name = "txtIVA";
			this.txtIVA.ReadOnly = true;
			this.txtIVA.Size = new System.Drawing.Size(120, 20);
			this.txtIVA.TabIndex = 9;
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(642, 461);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.ReadOnly = true;
			this.txtDescuento.Size = new System.Drawing.Size(120, 20);
			this.txtDescuento.TabIndex = 8;
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(642, 437);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.ReadOnly = true;
			this.txtSubtotal.Size = new System.Drawing.Size(120, 20);
			this.txtSubtotal.TabIndex = 7;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(568, 520);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(51, 13);
			this.label18.TabIndex = 70;
			this.label18.Text = "TOTAL:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(568, 494);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(27, 13);
			this.label17.TabIndex = 69;
			this.label17.Text = "IVA";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(568, 444);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(66, 13);
			this.label16.TabIndex = 68;
			this.label16.Text = "Sub Total:";
			// 
			// txtObservacion
			// 
			this.txtObservacion.Location = new System.Drawing.Point(3, 3);
			this.txtObservacion.Multiline = true;
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtObservacion.Size = new System.Drawing.Size(545, 47);
			this.txtObservacion.TabIndex = 67;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Location = new System.Drawing.Point(4, 435);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(559, 100);
			this.tabControl2.TabIndex = 10;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.cbImpresionDocumento);
			this.tabPage4.Controls.Add(this.label25);
			this.tabPage4.Controls.Add(this.label23);
			this.tabPage4.Controls.Add(this.cbEstadoDocumento);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(551, 74);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Configuración";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// cbImpresionDocumento
			// 
			this.cbImpresionDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbImpresionDocumento.FormattingEnabled = true;
			this.cbImpresionDocumento.Location = new System.Drawing.Point(144, 6);
			this.cbImpresionDocumento.Name = "cbImpresionDocumento";
			this.cbImpresionDocumento.Size = new System.Drawing.Size(238, 21);
			this.cbImpresionDocumento.TabIndex = 90;
			this.cbImpresionDocumento.SelectedIndexChanged += new System.EventHandler(this.cbImpresionDocumento_SelectedIndexChanged);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(7, 14);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(131, 13);
			this.label25.TabIndex = 89;
			this.label25.Text = "Formato de impresión:";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(7, 41);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(137, 13);
			this.label23.TabIndex = 88;
			this.label23.Text = "Estado del documento:";
			// 
			// cbEstadoDocumento
			// 
			this.cbEstadoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEstadoDocumento.FormattingEnabled = true;
			this.cbEstadoDocumento.Location = new System.Drawing.Point(144, 33);
			this.cbEstadoDocumento.Name = "cbEstadoDocumento";
			this.cbEstadoDocumento.Size = new System.Drawing.Size(238, 21);
			this.cbEstadoDocumento.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.checkObservacion2);
			this.tabPage3.Controls.Add(this.txtObservacion);
			this.tabPage3.Controls.Add(this.checkObservacion1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(551, 74);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Observación";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnDocumentoPadre);
			this.groupBox3.Controls.Add(this.txtReferencia);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.dtpFechaCreacion);
			this.groupBox3.Controls.Add(this.label21);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.cbCondicion);
			this.groupBox3.Controls.Add(this.dtpFechaVencimiento);
			this.groupBox3.Location = new System.Drawing.Point(457, 64);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(333, 100);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Documento";
			// 
			// btnDocumentoPadre
			// 
			this.btnDocumentoPadre.Enabled = false;
			this.btnDocumentoPadre.Image = ((System.Drawing.Image)(resources.GetObject("btnDocumentoPadre.Image")));
			this.btnDocumentoPadre.Location = new System.Drawing.Point(146, 68);
			this.btnDocumentoPadre.Name = "btnDocumentoPadre";
			this.btnDocumentoPadre.Size = new System.Drawing.Size(24, 24);
			this.btnDocumentoPadre.TabIndex = 95;
			this.btnDocumentoPadre.UseVisualStyleBackColor = true;
			// 
			// txtReferencia
			// 
			this.txtReferencia.Location = new System.Drawing.Point(9, 72);
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.Size = new System.Drawing.Size(131, 20);
			this.txtReferencia.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 80;
			this.label1.Text = "Fecha Creación:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(9, 59);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(120, 13);
			this.label22.TabIndex = 84;
			this.label22.Text = "Orden/Factura/Ref.";
			// 
			// dtpFechaCreacion
			// 
			this.dtpFechaCreacion.CustomFormat = "yyyy/MM/dd";
			this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFechaCreacion.Location = new System.Drawing.Point(9, 32);
			this.dtpFechaCreacion.Name = "dtpFechaCreacion";
			this.dtpFechaCreacion.Size = new System.Drawing.Size(131, 20);
			this.dtpFechaCreacion.TabIndex = 0;
			this.dtpFechaCreacion.ValueChanged += new System.EventHandler(this.dtpFechaCreacion_ValueChanged);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(176, 55);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(67, 13);
			this.label21.TabIndex = 83;
			this.label21.Text = "Condición:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(176, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(119, 13);
			this.label14.TabIndex = 81;
			this.label14.Text = "Fecha Vencimiento:";
			// 
			// cbCondicion
			// 
			this.cbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCondicion.FormattingEnabled = true;
			this.cbCondicion.Location = new System.Drawing.Point(176, 71);
			this.cbCondicion.Name = "cbCondicion";
			this.cbCondicion.Size = new System.Drawing.Size(132, 21);
			this.cbCondicion.TabIndex = 3;
			this.cbCondicion.SelectedIndexChanged += new System.EventHandler(this.cbCondicion_SelectedIndexChanged);
			// 
			// dtpFechaVencimiento
			// 
			this.dtpFechaVencimiento.CustomFormat = "yyyy/MM/dd";
			this.dtpFechaVencimiento.Enabled = false;
			this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFechaVencimiento.Location = new System.Drawing.Point(176, 32);
			this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
			this.dtpFechaVencimiento.Size = new System.Drawing.Size(131, 20);
			this.dtpFechaVencimiento.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(629, 175);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 13);
			this.label9.TabIndex = 93;
			this.label9.Text = "% desc";
			// 
			// txtDescuentoArticulo
			// 
			this.txtDescuentoArticulo.Location = new System.Drawing.Point(632, 193);
			this.txtDescuentoArticulo.Name = "txtDescuentoArticulo";
			this.txtDescuentoArticulo.Size = new System.Drawing.Size(38, 20);
			this.txtDescuentoArticulo.TabIndex = 6;
			this.txtDescuentoArticulo.TextChanged += new System.EventHandler(this.txtDescuentoArticulo_TextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(115, 216);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(189, 10);
			this.label13.TabIndex = 91;
			this.label13.Text = "Doble click en el texto para cambiar la descripción.";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(682, 175);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(62, 13);
			this.label12.TabIndex = 90;
			this.label12.Text = "SubTotal:";
			// 
			// txtTotalArticulo
			// 
			this.txtTotalArticulo.Enabled = false;
			this.txtTotalArticulo.Location = new System.Drawing.Point(676, 193);
			this.txtTotalArticulo.Name = "txtTotalArticulo";
			this.txtTotalArticulo.ReadOnly = true;
			this.txtTotalArticulo.Size = new System.Drawing.Size(106, 20);
			this.txtTotalArticulo.TabIndex = 14;
			this.txtTotalArticulo.TextChanged += new System.EventHandler(this.txtTotalArticulo_TextChanged);
			// 
			// lbValor
			// 
			this.lbValor.AutoSize = true;
			this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbValor.Location = new System.Drawing.Point(527, 176);
			this.lbValor.Name = "lbValor";
			this.lbValor.Size = new System.Drawing.Size(88, 13);
			this.lbValor.TabIndex = 88;
			this.lbValor.Text = "Valor Unitario:";
			// 
			// txtPrecioUnitarioArticulo
			// 
			this.txtPrecioUnitarioArticulo.Location = new System.Drawing.Point(527, 194);
			this.txtPrecioUnitarioArticulo.Name = "txtPrecioUnitarioArticulo";
			this.txtPrecioUnitarioArticulo.Size = new System.Drawing.Size(100, 20);
			this.txtPrecioUnitarioArticulo.TabIndex = 5;
			this.txtPrecioUnitarioArticulo.TextChanged += new System.EventHandler(this.txtPrecioUnitarioArticulo_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(462, 176);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 13);
			this.label10.TabIndex = 87;
			this.label10.Text = "Cantidad:";
			// 
			// txtCantidadArticulo
			// 
			this.txtCantidadArticulo.Location = new System.Drawing.Point(462, 194);
			this.txtCantidadArticulo.Name = "txtCantidadArticulo";
			this.txtCantidadArticulo.Size = new System.Drawing.Size(61, 20);
			this.txtCantidadArticulo.TabIndex = 4;
			this.txtCantidadArticulo.TextChanged += new System.EventHandler(this.txtCantidadArticulo_TextChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(115, 174);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(78, 13);
			this.label15.TabIndex = 86;
			this.label15.Text = "Descripción:";
			// 
			// txtDescripcionArticulo
			// 
			this.txtDescripcionArticulo.Location = new System.Drawing.Point(115, 194);
			this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
			this.txtDescripcionArticulo.ReadOnly = true;
			this.txtDescripcionArticulo.Size = new System.Drawing.Size(344, 20);
			this.txtDescripcionArticulo.TabIndex = 13;
			this.txtDescripcionArticulo.DoubleClick += new System.EventHandler(this.txtDescripcionArticulo_DoubleClick);
			// 
			// txtCodigoArticulo
			// 
			this.txtCodigoArticulo.Location = new System.Drawing.Point(7, 194);
			this.txtCodigoArticulo.Name = "txtCodigoArticulo";
			this.txtCodigoArticulo.Size = new System.Drawing.Size(72, 20);
			this.txtCodigoArticulo.TabIndex = 3;
			this.txtCodigoArticulo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoArticulo_Validating);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(17, 175);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(50, 13);
			this.label20.TabIndex = 82;
			this.label20.Text = "Código:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(496, 422);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(289, 12);
			this.label11.TabIndex = 97;
			this.label11.Text = "Doble click o F2 para cambiar algún ítem del detalle del documento.";
			// 
			// btnCambiarIVA
			// 
			this.btnCambiarIVA.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarIVA.Image")));
			this.btnCambiarIVA.Location = new System.Drawing.Point(766, 483);
			this.btnCambiarIVA.Name = "btnCambiarIVA";
			this.btnCambiarIVA.Size = new System.Drawing.Size(24, 24);
			this.btnCambiarIVA.TabIndex = 96;
			this.btnCambiarIVA.UseVisualStyleBackColor = true;
			this.btnCambiarIVA.Click += new System.EventHandler(this.btnCambiarIVA_Click);
			// 
			// btnCambiarDescuento
			// 
			this.btnCambiarDescuento.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarDescuento.Image")));
			this.btnCambiarDescuento.Location = new System.Drawing.Point(766, 457);
			this.btnCambiarDescuento.Name = "btnCambiarDescuento";
			this.btnCambiarDescuento.Size = new System.Drawing.Size(24, 24);
			this.btnCambiarDescuento.TabIndex = 95;
			this.btnCambiarDescuento.UseVisualStyleBackColor = true;
			this.btnCambiarDescuento.Click += new System.EventHandler(this.btnCambiarDescuento_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
			this.btnRemove.Location = new System.Drawing.Point(34, 214);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(23, 23);
			this.btnRemove.TabIndex = 8;
			this.btnRemove.Tag = "Menos para eliminar el producto o servicio";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(7, 214);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(23, 23);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Tag = "Mas para agregar un nuevo producto o servicio";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnBuscarArticulo
			// 
			this.btnBuscarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarArticulo.Image")));
			this.btnBuscarArticulo.Location = new System.Drawing.Point(85, 190);
			this.btnBuscarArticulo.Name = "btnBuscarArticulo";
			this.btnBuscarArticulo.Size = new System.Drawing.Size(24, 24);
			this.btnBuscarArticulo.TabIndex = 12;
			this.btnBuscarArticulo.UseVisualStyleBackColor = true;
			this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(696, 540);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(92, 28);
			this.btnCerrar.TabIndex = 99;
			this.btnCerrar.Text = "&Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(603, 540);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(92, 28);
			this.btnGuardar.TabIndex = 98;
			this.btnGuardar.Text = "&Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// FrmDocumento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 596);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.btnCambiarIVA);
			this.Controls.Add(this.btnCambiarDescuento);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtDescuentoArticulo);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnBuscarArticulo);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtTotalArticulo);
			this.Controls.Add(this.lbValor);
			this.Controls.Add(this.txtPrecioUnitarioArticulo);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtCantidadArticulo);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtDescripcionArticulo);
			this.Controls.Add(this.txtCodigoArticulo);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.tabControl2);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtIVA);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmDocumento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmDocumento";
			this.Load += new System.EventHandler(this.FrmDocumento_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
