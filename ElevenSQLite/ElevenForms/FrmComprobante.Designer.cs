/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmComprobante
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private GroupBox groupBox1;
		private RadioButton rbEgreso;
		private RadioButton rbIngreso;
		private StatusStrip statusStrip1;
		private Label lbConsecutivo;
		private Label label3;
		private GroupBox gbTercero;
		private Button btnBuscarCliente;
		private Label label8;
		public TextBox txtCodigoTercero;
		private TextBox txtNombreComercial;
		private Label label7;
		private TabControl tabControlDetalle;
		private TabPage tabPageConcepto;
		private TabPage tabPageDocumentos;
		private GroupBox groupBox3;
		private Label label2;
		private Label label22;
		private DateTimePicker dtpFechaCreacion;
		private ComboBox cbCondicion;
		private DataGridView dataGridViewDetalles;
		private TextBox txtTotal;
		private Label label18;
		private TabControl tabControl2;
		private TabPage tabPage3;
		private TabPage tabPage4;
		private ComboBox cbBanco;
		private Label label4;
		private Label label1;
		private TextBox txtNumeroCheque;
		private Button btnRemove;
		private Button btnAdd;
		private TextBox txtRetencion;
		private Label label5;
		private TextBox txtDescuento;
		private Label label6;
		private TextBox txtObservacion;
		private Label lbMensaje;
		private TabPage tabPage5;
		private ComboBox cbImpresionComprobante;
		private Label label25;
		private BindingSource bindingSource1;
		private DataGridView dataGridViewDocumentos;
		private BindingSource bindingSource2;
		private TextBox txtSucursal;
		private Label label9;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprobante));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbConsecutivo = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rbEgreso = new System.Windows.Forms.RadioButton();
			this.rbIngreso = new System.Windows.Forms.RadioButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.gbTercero = new System.Windows.Forms.GroupBox();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCodigoTercero = new System.Windows.Forms.TextBox();
			this.txtNombreComercial = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tabControlDetalle = new System.Windows.Forms.TabControl();
			this.tabPageConcepto = new System.Windows.Forms.TabPage();
			this.dataGridViewDetalles = new System.Windows.Forms.DataGridView();
			this.tabPageDocumentos = new System.Windows.Forms.TabPage();
			this.dataGridViewDocumentos = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbCondicion = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.txtSucursal = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cbBanco = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumeroCheque = new System.Windows.Forms.TextBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.cbImpresionComprobante = new System.Windows.Forms.ComboBox();
			this.label25 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtRetencion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbMensaje = new System.Windows.Forms.Label();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.gbTercero.SuspendLayout();
			this.tabControlDetalle.SuspendLayout();
			this.tabPageConcepto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).BeginInit();
			this.tabPageDocumentos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocumentos)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbConsecutivo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.rbEgreso);
			this.groupBox1.Controls.Add(this.rbIngreso);
			this.groupBox1.Location = new System.Drawing.Point(4, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(700, 44);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo comprobante";
			// 
			// lbConsecutivo
			// 
			this.lbConsecutivo.AutoSize = true;
			this.lbConsecutivo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbConsecutivo.Location = new System.Drawing.Point(539, 18);
			this.lbConsecutivo.Name = "lbConsecutivo";
			this.lbConsecutivo.Size = new System.Drawing.Size(53, 18);
			this.lbConsecutivo.TabIndex = 82;
			this.lbConsecutivo.Text = "00001";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(452, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 81;
			this.label3.Text = "Consecutivo:";
			// 
			// rbEgreso
			// 
			this.rbEgreso.AutoSize = true;
			this.rbEgreso.Location = new System.Drawing.Point(74, 18);
			this.rbEgreso.Name = "rbEgreso";
			this.rbEgreso.Size = new System.Drawing.Size(58, 17);
			this.rbEgreso.TabIndex = 1;
			this.rbEgreso.Text = "Egreso";
			this.rbEgreso.UseVisualStyleBackColor = true;
			this.rbEgreso.CheckedChanged += new System.EventHandler(this.rbEgreso_CheckedChanged);
			// 
			// rbIngreso
			// 
			this.rbIngreso.AutoSize = true;
			this.rbIngreso.Location = new System.Drawing.Point(10, 18);
			this.rbIngreso.Name = "rbIngreso";
			this.rbIngreso.Size = new System.Drawing.Size(60, 17);
			this.rbIngreso.TabIndex = 0;
			this.rbIngreso.Text = "Ingreso";
			this.rbIngreso.UseVisualStyleBackColor = true;
			this.rbIngreso.CheckedChanged += new System.EventHandler(this.rbIngreso_CheckedChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 464);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(710, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// gbTercero
			// 
			this.gbTercero.Controls.Add(this.btnBuscarCliente);
			this.gbTercero.Controls.Add(this.label8);
			this.gbTercero.Controls.Add(this.txtCodigoTercero);
			this.gbTercero.Controls.Add(this.txtNombreComercial);
			this.gbTercero.Controls.Add(this.label7);
			this.gbTercero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTercero.Location = new System.Drawing.Point(4, 61);
			this.gbTercero.Name = "gbTercero";
			this.gbTercero.Size = new System.Drawing.Size(400, 66);
			this.gbTercero.TabIndex = 13;
			this.gbTercero.TabStop = false;
			this.gbTercero.Text = "RECIBO DE:";
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
			this.btnBuscarCliente.Location = new System.Drawing.Point(222, 12);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(24, 24);
			this.btnBuscarCliente.TabIndex = 54;
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
			this.label8.TabIndex = 50;
			this.label8.Text = "Codigo:";
			// 
			// txtCodigoTercero
			// 
			this.txtCodigoTercero.Location = new System.Drawing.Point(81, 16);
			this.txtCodigoTercero.Name = "txtCodigoTercero";
			this.txtCodigoTercero.Size = new System.Drawing.Size(135, 20);
			this.txtCodigoTercero.TabIndex = 0;
			// 
			// txtNombreComercial
			// 
			this.txtNombreComercial.Enabled = false;
			this.txtNombreComercial.Location = new System.Drawing.Point(81, 39);
			this.txtNombreComercial.Name = "txtNombreComercial";
			this.txtNombreComercial.ReadOnly = true;
			this.txtNombreComercial.Size = new System.Drawing.Size(292, 20);
			this.txtNombreComercial.TabIndex = 49;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(7, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 13);
			this.label7.TabIndex = 53;
			this.label7.Text = "Nombre:";
			// 
			// tabControlDetalle
			// 
			this.tabControlDetalle.Controls.Add(this.tabPageConcepto);
			this.tabControlDetalle.Controls.Add(this.tabPageDocumentos);
			this.tabControlDetalle.Location = new System.Drawing.Point(4, 137);
			this.tabControlDetalle.Name = "tabControlDetalle";
			this.tabControlDetalle.SelectedIndex = 0;
			this.tabControlDetalle.Size = new System.Drawing.Size(704, 169);
			this.tabControlDetalle.TabIndex = 14;
			this.tabControlDetalle.SelectedIndexChanged += new System.EventHandler(this.tabControlDetalle_SelectedIndexChanged);
			// 
			// tabPageConcepto
			// 
			this.tabPageConcepto.Controls.Add(this.dataGridViewDetalles);
			this.tabPageConcepto.Location = new System.Drawing.Point(4, 22);
			this.tabPageConcepto.Name = "tabPageConcepto";
			this.tabPageConcepto.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageConcepto.Size = new System.Drawing.Size(696, 143);
			this.tabPageConcepto.TabIndex = 0;
			this.tabPageConcepto.Text = "Concepto";
			this.tabPageConcepto.UseVisualStyleBackColor = true;
			// 
			// dataGridViewDetalles
			// 
			this.dataGridViewDetalles.AllowUserToAddRows = false;
			this.dataGridViewDetalles.AllowUserToDeleteRows = false;
			this.dataGridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewDetalles.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewDetalles.MultiSelect = false;
			this.dataGridViewDetalles.Name = "dataGridViewDetalles";
			this.dataGridViewDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewDetalles.Size = new System.Drawing.Size(690, 137);
			this.dataGridViewDetalles.TabIndex = 0;
			this.dataGridViewDetalles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalles_CellDoubleClick);
			this.dataGridViewDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalles_CellEndEdit);
			this.dataGridViewDetalles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDetalles_CellFormatting);
			// 
			// tabPageDocumentos
			// 
			this.tabPageDocumentos.Controls.Add(this.dataGridViewDocumentos);
			this.tabPageDocumentos.Location = new System.Drawing.Point(4, 22);
			this.tabPageDocumentos.Name = "tabPageDocumentos";
			this.tabPageDocumentos.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDocumentos.Size = new System.Drawing.Size(696, 143);
			this.tabPageDocumentos.TabIndex = 1;
			this.tabPageDocumentos.Text = "Documentos";
			this.tabPageDocumentos.UseVisualStyleBackColor = true;
			// 
			// dataGridViewDocumentos
			// 
			this.dataGridViewDocumentos.AllowUserToAddRows = false;
			this.dataGridViewDocumentos.AllowUserToDeleteRows = false;
			this.dataGridViewDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewDocumentos.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewDocumentos.Name = "dataGridViewDocumentos";
			this.dataGridViewDocumentos.Size = new System.Drawing.Size(690, 137);
			this.dataGridViewDocumentos.TabIndex = 0;
			this.dataGridViewDocumentos.VirtualMode = true;
			this.dataGridViewDocumentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDocumentos_CellFormatting);
			this.dataGridViewDocumentos.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridViewDocumentos_CellValueNeeded);
			this.dataGridViewDocumentos.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridViewDocumentos_CellValuePushed);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbCondicion);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.dtpFechaCreacion);
			this.groupBox3.Location = new System.Drawing.Point(410, 61);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(294, 66);
			this.groupBox3.TabIndex = 78;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Documento";
			// 
			// cbCondicion
			// 
			this.cbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCondicion.FormattingEnabled = true;
			this.cbCondicion.Items.AddRange(new object[] {
			"Efectivo",
			"Cheque"});
			this.cbCondicion.Location = new System.Drawing.Point(146, 31);
			this.cbCondicion.Name = "cbCondicion";
			this.cbCondicion.Size = new System.Drawing.Size(132, 21);
			this.cbCondicion.TabIndex = 1;
			this.cbCondicion.SelectedIndexChanged += new System.EventHandler(this.cbCondicion_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 80;
			this.label2.Text = "Fecha Creación:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(146, 16);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(95, 13);
			this.label22.TabIndex = 84;
			this.label22.Text = "Forma de pago:";
			// 
			// dtpFechaCreacion
			// 
			this.dtpFechaCreacion.CustomFormat = "yyyy/MM/dd";
			this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFechaCreacion.Location = new System.Drawing.Point(9, 32);
			this.dtpFechaCreacion.Name = "dtpFechaCreacion";
			this.dtpFechaCreacion.Size = new System.Drawing.Size(131, 20);
			this.dtpFechaCreacion.TabIndex = 0;
			// 
			// txtTotal
			// 
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(568, 394);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(133, 20);
			this.txtTotal.TabIndex = 2;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(490, 401);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(51, 13);
			this.label18.TabIndex = 79;
			this.label18.Text = "TOTAL:";
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Controls.Add(this.tabPage5);
			this.tabControl2.Location = new System.Drawing.Point(4, 343);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(480, 81);
			this.tabControl2.TabIndex = 81;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.txtSucursal);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.cbBanco);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.label1);
			this.tabPage3.Controls.Add(this.txtNumeroCheque);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(472, 55);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Banco";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// txtSucursal
			// 
			this.txtSucursal.Location = new System.Drawing.Point(72, 32);
			this.txtSucursal.Name = "txtSucursal";
			this.txtSucursal.Size = new System.Drawing.Size(217, 20);
			this.txtSucursal.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 36);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 13);
			this.label9.TabIndex = 87;
			this.label9.Text = "Sucursal:";
			// 
			// cbBanco
			// 
			this.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBanco.FormattingEnabled = true;
			this.cbBanco.Location = new System.Drawing.Point(70, 5);
			this.cbBanco.Name = "cbBanco";
			this.cbBanco.Size = new System.Drawing.Size(219, 21);
			this.cbBanco.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Banco:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(308, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cheque No:";
			// 
			// txtNumeroCheque
			// 
			this.txtNumeroCheque.Location = new System.Drawing.Point(311, 29);
			this.txtNumeroCheque.Name = "txtNumeroCheque";
			this.txtNumeroCheque.Size = new System.Drawing.Size(155, 20);
			this.txtNumeroCheque.TabIndex = 2;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.txtObservacion);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(472, 55);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Observación";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// txtObservacion
			// 
			this.txtObservacion.Location = new System.Drawing.Point(3, 3);
			this.txtObservacion.Multiline = true;
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.Size = new System.Drawing.Size(463, 49);
			this.txtObservacion.TabIndex = 0;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.cbImpresionComprobante);
			this.tabPage5.Controls.Add(this.label25);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(472, 55);
			this.tabPage5.TabIndex = 2;
			this.tabPage5.Text = "Configuración";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// cbImpresionComprobante
			// 
			this.cbImpresionComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbImpresionComprobante.FormattingEnabled = true;
			this.cbImpresionComprobante.Location = new System.Drawing.Point(77, 11);
			this.cbImpresionComprobante.Name = "cbImpresionComprobante";
			this.cbImpresionComprobante.Size = new System.Drawing.Size(389, 21);
			this.cbImpresionComprobante.TabIndex = 92;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(6, 19);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(65, 13);
			this.label25.TabIndex = 91;
			this.label25.Text = "Impresión:";
			// 
			// btnRemove
			// 
			this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
			this.btnRemove.Location = new System.Drawing.Point(33, 318);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(23, 23);
			this.btnRemove.TabIndex = 87;
			this.btnRemove.Tag = "Menos para eliminar el producto o servicio";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(4, 318);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(23, 23);
			this.btnAdd.TabIndex = 86;
			this.btnAdd.Tag = "Mas para agregar un nuevo producto o servicio";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtRetencion
			// 
			this.txtRetencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRetencion.Location = new System.Drawing.Point(568, 368);
			this.txtRetencion.Name = "txtRetencion";
			this.txtRetencion.ReadOnly = true;
			this.txtRetencion.Size = new System.Drawing.Size(133, 20);
			this.txtRetencion.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(490, 375);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 88;
			this.label5.Text = "Retención:";
			// 
			// txtDescuento
			// 
			this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescuento.Location = new System.Drawing.Point(568, 342);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.ReadOnly = true;
			this.txtDescuento.Size = new System.Drawing.Size(133, 20);
			this.txtDescuento.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(490, 349);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 13);
			this.label6.TabIndex = 90;
			this.label6.Text = "Descuento:";
			// 
			// lbMensaje
			// 
			this.lbMensaje.AutoSize = true;
			this.lbMensaje.Location = new System.Drawing.Point(309, 318);
			this.lbMensaje.Name = "lbMensaje";
			this.lbMensaje.Size = new System.Drawing.Size(402, 13);
			this.lbMensaje.TabIndex = 92;
			this.lbMensaje.Text = "(+) y doble click en la casilla documento o doble click en la casilla concepto -e" +
	"ditar-.";
			// 
			// btnCerrar
			// 
			this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(609, 427);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(92, 28);
			this.btnCerrar.TabIndex = 101;
			this.btnCerrar.Text = "&Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(516, 427);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(92, 28);
			this.btnGuardar.TabIndex = 100;
			this.btnGuardar.Text = "&Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// FrmComprobante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 486);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lbMensaje);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtRetencion);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.tabControl2);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.tabControlDetalle);
			this.Controls.Add(this.gbTercero);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmComprobante";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FormComprobante_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbTercero.ResumeLayout(false);
			this.gbTercero.PerformLayout();
			this.tabControlDetalle.ResumeLayout(false);
			this.tabPageConcepto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).EndInit();
			this.tabPageDocumentos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocumentos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
