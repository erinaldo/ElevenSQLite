/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 13/09/2017
 * Hora: 10:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmTipoDocumento
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private NumericUpDown nudIndice;
		private Label label9;
		private GroupBox groupBox2;
		private RadioButton rbResta;
		private RadioButton rbSuma;
		private RadioButton rbNeutral;
		private GroupBox groupBox1;
		private Label label4;
		private TextBox txtInicial;
		private TextBox txtFinal;
		private TextBox txtActual;
		private Label label5;
		private Label label6;
		private Label label3;
		private TextBox txtDescripcion;
		private TextBox txtCodigo;
		private Label label2;
		private ComboBox cbTipoDocumentoMaestro;
		private Label label1;
		private Button btnAceptar;
		private TabPage tabPage2;
		private Label label10;
		private NumericUpDown nudCantidadDecimales;
		private NumericUpDown nudLimiteRegistros;
		private Label label12;
		private NumericUpDown nudCerosIzquierda;
		private Label label11;
		private ComboBox cbTipoMoneda;
		private Label label13;
		private GroupBox groupBox3;
		private RadioButton rbRS;
		private RadioButton rbRC;
		private StatusStrip statusStrip1;
		private CheckBox checkIvaIncluido;
		private Label label14;
		private TextBox txtNumeracionDesde;
		private Label label16;
		private TextBox txtAutorizacion;
		private Label label15;
		private DateTimePicker dtpFechaAutorizacion;
		private GroupBox groupBox4;
		private Label label18;
		private TextBox txtNumeracionHasta;
		private Label label17;
		private GroupBox groupBox5;
		private Label label19;
		private TabPage tabPage3;
		private DataGridView dataGridViewContabilidad;
		private BindingSource bindingSource1;
		private Label label20;
		private TextBox txtSufijo;
		private Label label8;
		private TextBox txtPrefijo;
		private Label label7;
		private ComboBox cbImpresionDocumento;
		private TabPage tabPage4;
		private CheckBox checkImpresionLogotipo;
		private CheckBox checkImpresionEncabezado;
		private Label label21;
		private Button btnColor;
		private TextBox txtColor;
		private ColorDialog colorDialog1;
		private CheckBox checkFondoPapel;
		private GroupBox groupBox6;
		private CheckBox checkInterno;
		private CheckBox checkOtro;
		private CheckBox checkProveedorExterior;
		private CheckBox checkProveedor;
		private CheckBox checkClienteExterior;
		private CheckBox checkCliente;
		private Label label22;
		private ComboBox cbEstadoDocumento;
		private TabPage tabPage5;
		private DataGridView dataGridViewPermisos;
		private BindingSource bindingSource2;
		private CheckBox checkObservacion2;
		private CheckBox checkObservacion1;
		private CheckBox checkComprobante;
		private CheckBox checkImpresionDetalleIVA;
		private CheckBox checkImpresionDetalleCantidad;
		private CheckBox checkImpresionDetalleDescuento;
		private CheckBox checkImpresionDetalleCodigo;
		private GroupBox groupBox7;
		private CheckBox checkRedondeo;
		private GroupBox groupBox8;
		private RadioButton rbRecibiServicio;
		private RadioButton rbRecibiMercancia;
		private RadioButton rbRecibiProducto;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoDocumento));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.checkRedondeo = new System.Windows.Forms.CheckBox();
			this.checkComprobante = new System.Windows.Forms.CheckBox();
			this.cbImpresionDocumento = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.checkIvaIncluido = new System.Windows.Forms.CheckBox();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbRS = new System.Windows.Forms.RadioButton();
			this.rbRC = new System.Windows.Forms.RadioButton();
			this.cbTipoMoneda = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.nudLimiteRegistros = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.nudCerosIzquierda = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.nudCantidadDecimales = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.nudIndice = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbResta = new System.Windows.Forms.RadioButton();
			this.rbSuma = new System.Windows.Forms.RadioButton();
			this.rbNeutral = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtInicial = new System.Windows.Forms.TextBox();
			this.txtFinal = new System.Windows.Forms.TextBox();
			this.txtActual = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbTipoDocumentoMaestro = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtSufijo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPrefijo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtNumeracionHasta = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtNumeracionDesde = new System.Windows.Forms.TextBox();
			this.dtpFechaAutorizacion = new System.Windows.Forms.DateTimePicker();
			this.label16 = new System.Windows.Forms.Label();
			this.txtAutorizacion = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.rbRecibiProducto = new System.Windows.Forms.RadioButton();
			this.rbRecibiServicio = new System.Windows.Forms.RadioButton();
			this.rbRecibiMercancia = new System.Windows.Forms.RadioButton();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.checkImpresionDetalleCodigo = new System.Windows.Forms.CheckBox();
			this.checkImpresionDetalleIVA = new System.Windows.Forms.CheckBox();
			this.checkImpresionDetalleCantidad = new System.Windows.Forms.CheckBox();
			this.checkImpresionDetalleDescuento = new System.Windows.Forms.CheckBox();
			this.checkObservacion2 = new System.Windows.Forms.CheckBox();
			this.checkObservacion1 = new System.Windows.Forms.CheckBox();
			this.cbEstadoDocumento = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.checkInterno = new System.Windows.Forms.CheckBox();
			this.checkOtro = new System.Windows.Forms.CheckBox();
			this.checkProveedorExterior = new System.Windows.Forms.CheckBox();
			this.checkProveedor = new System.Windows.Forms.CheckBox();
			this.checkClienteExterior = new System.Windows.Forms.CheckBox();
			this.checkCliente = new System.Windows.Forms.CheckBox();
			this.checkFondoPapel = new System.Windows.Forms.CheckBox();
			this.checkImpresionLogotipo = new System.Windows.Forms.CheckBox();
			this.checkImpresionEncabezado = new System.Windows.Forms.CheckBox();
			this.label21 = new System.Windows.Forms.Label();
			this.btnColor = new System.Windows.Forms.Button();
			this.txtColor = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataGridViewContabilidad = new System.Windows.Forms.DataGridView();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.dataGridViewPermisos = new System.Windows.Forms.DataGridView();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudLimiteRegistros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCerosIzquierda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidadDecimales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudIndice)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewContabilidad)).BeginInit();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Location = new System.Drawing.Point(1, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(411, 440);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.checkRedondeo);
			this.tabPage1.Controls.Add(this.checkComprobante);
			this.tabPage1.Controls.Add(this.cbImpresionDocumento);
			this.tabPage1.Controls.Add(this.label20);
			this.tabPage1.Controls.Add(this.checkIvaIncluido);
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.cbTipoMoneda);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.nudLimiteRegistros);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.nudCerosIzquierda);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.nudCantidadDecimales);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.nudIndice);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.txtDescripcion);
			this.tabPage1.Controls.Add(this.txtCodigo);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.cbTipoDocumentoMaestro);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(403, 414);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Configuración";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// checkRedondeo
			// 
			this.checkRedondeo.AutoSize = true;
			this.checkRedondeo.Location = new System.Drawing.Point(9, 262);
			this.checkRedondeo.Name = "checkRedondeo";
			this.checkRedondeo.Size = new System.Drawing.Size(131, 17);
			this.checkRedondeo.TabIndex = 53;
			this.checkRedondeo.Text = "Redondeo automatico";
			this.checkRedondeo.UseVisualStyleBackColor = true;
			// 
			// checkComprobante
			// 
			this.checkComprobante.AutoSize = true;
			this.checkComprobante.Location = new System.Drawing.Point(199, 239);
			this.checkComprobante.Name = "checkComprobante";
			this.checkComprobante.Size = new System.Drawing.Size(171, 17);
			this.checkComprobante.TabIndex = 52;
			this.checkComprobante.Text = "Comprobante (Ingreso/Egreso)";
			this.checkComprobante.UseVisualStyleBackColor = true;
			// 
			// cbImpresionDocumento
			// 
			this.cbImpresionDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbImpresionDocumento.FormattingEnabled = true;
			this.cbImpresionDocumento.Location = new System.Drawing.Point(120, 88);
			this.cbImpresionDocumento.Name = "cbImpresionDocumento";
			this.cbImpresionDocumento.Size = new System.Drawing.Size(263, 21);
			this.cbImpresionDocumento.TabIndex = 51;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(6, 96);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(113, 13);
			this.label20.TabIndex = 50;
			this.label20.Text = "Formato impresión:";
			// 
			// checkIvaIncluido
			// 
			this.checkIvaIncluido.AutoSize = true;
			this.checkIvaIncluido.Location = new System.Drawing.Point(9, 239);
			this.checkIvaIncluido.Name = "checkIvaIncluido";
			this.checkIvaIncluido.Size = new System.Drawing.Size(184, 17);
			this.checkIvaIncluido.TabIndex = 49;
			this.checkIvaIncluido.Text = "Los productos tienen IVA incluido";
			this.checkIvaIncluido.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(6, 214);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(107, 13);
			this.label14.TabIndex = 48;
			this.label14.Text = "Tipo Facturación:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbRS);
			this.groupBox3.Controls.Add(this.rbRC);
			this.groupBox3.Location = new System.Drawing.Point(120, 195);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(263, 38);
			this.groupBox3.TabIndex = 47;
			this.groupBox3.TabStop = false;
			// 
			// rbRS
			// 
			this.rbRS.AutoSize = true;
			this.rbRS.Location = new System.Drawing.Point(115, 15);
			this.rbRS.Name = "rbRS";
			this.rbRS.Size = new System.Drawing.Size(126, 17);
			this.rbRS.TabIndex = 2;
			this.rbRS.Text = "Régimen Simplificado";
			this.rbRS.UseVisualStyleBackColor = true;
			// 
			// rbRC
			// 
			this.rbRC.AutoSize = true;
			this.rbRC.Checked = true;
			this.rbRC.Location = new System.Drawing.Point(6, 15);
			this.rbRC.Name = "rbRC";
			this.rbRC.Size = new System.Drawing.Size(103, 17);
			this.rbRC.TabIndex = 1;
			this.rbRC.TabStop = true;
			this.rbRC.Text = "Régimen Común";
			this.rbRC.UseVisualStyleBackColor = true;
			// 
			// cbTipoMoneda
			// 
			this.cbTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoMoneda.FormattingEnabled = true;
			this.cbTipoMoneda.Location = new System.Drawing.Point(121, 168);
			this.cbTipoMoneda.Name = "cbTipoMoneda";
			this.cbTipoMoneda.Size = new System.Drawing.Size(121, 21);
			this.cbTipoMoneda.TabIndex = 45;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(6, 176);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(102, 13);
			this.label13.TabIndex = 44;
			this.label13.Text = "Tipo de moneda:";
			// 
			// nudLimiteRegistros
			// 
			this.nudLimiteRegistros.Location = new System.Drawing.Point(331, 140);
			this.nudLimiteRegistros.Name = "nudLimiteRegistros";
			this.nudLimiteRegistros.Size = new System.Drawing.Size(52, 20);
			this.nudLimiteRegistros.TabIndex = 43;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(202, 146);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(110, 13);
			this.label12.TabIndex = 42;
			this.label12.Text = "Maximo Registros:";
			// 
			// nudCerosIzquierda
			// 
			this.nudCerosIzquierda.Location = new System.Drawing.Point(120, 141);
			this.nudCerosIzquierda.Name = "nudCerosIzquierda";
			this.nudCerosIzquierda.Size = new System.Drawing.Size(51, 20);
			this.nudCerosIzquierda.TabIndex = 41;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 147);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(99, 13);
			this.label11.TabIndex = 40;
			this.label11.Text = "Ceros Izquierda:";
			// 
			// nudCantidadDecimales
			// 
			this.nudCantidadDecimales.Location = new System.Drawing.Point(331, 115);
			this.nudCantidadDecimales.Name = "nudCantidadDecimales";
			this.nudCantidadDecimales.Size = new System.Drawing.Size(52, 20);
			this.nudCantidadDecimales.TabIndex = 39;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(202, 121);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(123, 13);
			this.label10.TabIndex = 38;
			this.label10.Text = "Cantidad Decimales:";
			// 
			// nudIndice
			// 
			this.nudIndice.Location = new System.Drawing.Point(120, 115);
			this.nudIndice.Name = "nudIndice";
			this.nudIndice.Size = new System.Drawing.Size(51, 20);
			this.nudIndice.TabIndex = 37;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 121);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 13);
			this.label9.TabIndex = 36;
			this.label9.Text = "Orden - Prioridad:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbResta);
			this.groupBox2.Controls.Add(this.rbSuma);
			this.groupBox2.Controls.Add(this.rbNeutral);
			this.groupBox2.Location = new System.Drawing.Point(3, 300);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(371, 40);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Factor de cambio / manejo del inventario";
			// 
			// rbResta
			// 
			this.rbResta.AutoSize = true;
			this.rbResta.Location = new System.Drawing.Point(253, 19);
			this.rbResta.Name = "rbResta";
			this.rbResta.Size = new System.Drawing.Size(113, 17);
			this.rbResta.TabIndex = 2;
			this.rbResta.Text = "Resta al inventario";
			this.rbResta.UseVisualStyleBackColor = true;
			// 
			// rbSuma
			// 
			this.rbSuma.AutoSize = true;
			this.rbSuma.Location = new System.Drawing.Point(141, 19);
			this.rbSuma.Name = "rbSuma";
			this.rbSuma.Size = new System.Drawing.Size(112, 17);
			this.rbSuma.TabIndex = 1;
			this.rbSuma.Text = "Suma al inventario";
			this.rbSuma.UseVisualStyleBackColor = true;
			// 
			// rbNeutral
			// 
			this.rbNeutral.AutoSize = true;
			this.rbNeutral.Checked = true;
			this.rbNeutral.Location = new System.Drawing.Point(9, 20);
			this.rbNeutral.Name = "rbNeutral";
			this.rbNeutral.Size = new System.Drawing.Size(126, 17);
			this.rbNeutral.TabIndex = 0;
			this.rbNeutral.TabStop = true;
			this.rbNeutral.Text = "Neutral (NO modifica)";
			this.rbNeutral.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtInicial);
			this.groupBox1.Controls.Add(this.txtFinal);
			this.groupBox1.Controls.Add(this.txtActual);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(3, 341);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(371, 67);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Consecutivos";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(121, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Final:";
			// 
			// txtInicial
			// 
			this.txtInicial.Location = new System.Drawing.Point(6, 32);
			this.txtInicial.Name = "txtInicial";
			this.txtInicial.Size = new System.Drawing.Size(112, 20);
			this.txtInicial.TabIndex = 8;
			this.txtInicial.Text = "1";
			// 
			// txtFinal
			// 
			this.txtFinal.Location = new System.Drawing.Point(124, 32);
			this.txtFinal.Name = "txtFinal";
			this.txtFinal.Size = new System.Drawing.Size(112, 20);
			this.txtFinal.TabIndex = 10;
			this.txtFinal.Text = "1000";
			// 
			// txtActual
			// 
			this.txtActual.Location = new System.Drawing.Point(242, 32);
			this.txtActual.Name = "txtActual";
			this.txtActual.Size = new System.Drawing.Size(112, 20);
			this.txtActual.TabIndex = 12;
			this.txtActual.Text = "1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Inicial:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(242, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Actual:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 28;
			this.label3.Text = "Descripción:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(120, 61);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(263, 20);
			this.txtDescripcion.TabIndex = 27;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(120, 35);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(112, 20);
			this.txtCodigo.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 25;
			this.label2.Text = "Codigo:";
			// 
			// cbTipoDocumentoMaestro
			// 
			this.cbTipoDocumentoMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoDocumentoMaestro.FormattingEnabled = true;
			this.cbTipoDocumentoMaestro.Location = new System.Drawing.Point(120, 7);
			this.cbTipoDocumentoMaestro.Name = "cbTipoDocumentoMaestro";
			this.cbTipoDocumentoMaestro.Size = new System.Drawing.Size(263, 21);
			this.cbTipoDocumentoMaestro.TabIndex = 24;
			this.cbTipoDocumentoMaestro.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocumentoMaestro_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "Tipo documento:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtSufijo);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.txtPrefijo);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.groupBox5);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Controls.Add(this.dtpFechaAutorizacion);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.txtAutorizacion);
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(403, 414);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "DIAN";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtSufijo
			// 
			this.txtSufijo.Location = new System.Drawing.Point(61, 130);
			this.txtSufijo.Name = "txtSufijo";
			this.txtSufijo.Size = new System.Drawing.Size(112, 20);
			this.txtSufijo.TabIndex = 88;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 137);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 13);
			this.label8.TabIndex = 87;
			this.label8.Text = "Sufijo:";
			// 
			// txtPrefijo
			// 
			this.txtPrefijo.Location = new System.Drawing.Point(61, 104);
			this.txtPrefijo.Name = "txtPrefijo";
			this.txtPrefijo.Size = new System.Drawing.Size(112, 20);
			this.txtPrefijo.TabIndex = 86;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 111);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 13);
			this.label7.TabIndex = 85;
			this.label7.Text = "Prefijo:";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label19);
			this.groupBox5.Location = new System.Drawing.Point(6, 344);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(385, 59);
			this.groupBox5.TabIndex = 84;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Ayuda";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(9, 20);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(352, 13);
			this.label19.TabIndex = 0;
			this.label19.Text = "Cambiar el tipo de facturación a régimen común -> Pestaña configuración";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.txtNumeracionHasta);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.txtNumeracionDesde);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(6, 32);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(389, 66);
			this.groupBox4.TabIndex = 83;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Numeración";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(6, 16);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(47, 13);
			this.label17.TabIndex = 80;
			this.label17.Text = "Desde:";
			// 
			// txtNumeracionHasta
			// 
			this.txtNumeracionHasta.Location = new System.Drawing.Point(190, 32);
			this.txtNumeracionHasta.Name = "txtNumeracionHasta";
			this.txtNumeracionHasta.Size = new System.Drawing.Size(125, 20);
			this.txtNumeracionHasta.TabIndex = 81;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(187, 16);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(44, 13);
			this.label18.TabIndex = 82;
			this.label18.Text = "Hasta:";
			// 
			// txtNumeracionDesde
			// 
			this.txtNumeracionDesde.Location = new System.Drawing.Point(9, 32);
			this.txtNumeracionDesde.Name = "txtNumeracionDesde";
			this.txtNumeracionDesde.Size = new System.Drawing.Size(125, 20);
			this.txtNumeracionDesde.TabIndex = 27;
			// 
			// dtpFechaAutorizacion
			// 
			this.dtpFechaAutorizacion.CustomFormat = "yyyy/MM/dd";
			this.dtpFechaAutorizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFechaAutorizacion.Location = new System.Drawing.Point(294, 6);
			this.dtpFechaAutorizacion.Name = "dtpFechaAutorizacion";
			this.dtpFechaAutorizacion.Size = new System.Drawing.Size(91, 20);
			this.dtpFechaAutorizacion.TabIndex = 79;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(263, 13);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(25, 13);
			this.label16.TabIndex = 26;
			this.label16.Text = "de:";
			// 
			// txtAutorizacion
			// 
			this.txtAutorizacion.Location = new System.Drawing.Point(87, 6);
			this.txtAutorizacion.Name = "txtAutorizacion";
			this.txtAutorizacion.Size = new System.Drawing.Size(170, 20);
			this.txtAutorizacion.TabIndex = 25;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(7, 13);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(74, 13);
			this.label15.TabIndex = 24;
			this.label15.Text = "Resolución:";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.groupBox8);
			this.tabPage4.Controls.Add(this.groupBox7);
			this.tabPage4.Controls.Add(this.checkObservacion2);
			this.tabPage4.Controls.Add(this.checkObservacion1);
			this.tabPage4.Controls.Add(this.cbEstadoDocumento);
			this.tabPage4.Controls.Add(this.label22);
			this.tabPage4.Controls.Add(this.groupBox6);
			this.tabPage4.Controls.Add(this.checkFondoPapel);
			this.tabPage4.Controls.Add(this.checkImpresionLogotipo);
			this.tabPage4.Controls.Add(this.checkImpresionEncabezado);
			this.tabPage4.Controls.Add(this.label21);
			this.tabPage4.Controls.Add(this.btnColor);
			this.tabPage4.Controls.Add(this.txtColor);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(403, 414);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Impresión";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.rbRecibiProducto);
			this.groupBox8.Controls.Add(this.rbRecibiServicio);
			this.groupBox8.Controls.Add(this.rbRecibiMercancia);
			this.groupBox8.Location = new System.Drawing.Point(9, 119);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(386, 46);
			this.groupBox8.TabIndex = 61;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Recibo a satisfacción";
			// 
			// rbRecibiProducto
			// 
			this.rbRecibiProducto.AutoSize = true;
			this.rbRecibiProducto.Location = new System.Drawing.Point(102, 20);
			this.rbRecibiProducto.Name = "rbRecibiProducto";
			this.rbRecibiProducto.Size = new System.Drawing.Size(68, 17);
			this.rbRecibiProducto.TabIndex = 2;
			this.rbRecibiProducto.Text = "Producto";
			this.rbRecibiProducto.UseVisualStyleBackColor = true;
			// 
			// rbRecibiServicio
			// 
			this.rbRecibiServicio.AutoSize = true;
			this.rbRecibiServicio.Location = new System.Drawing.Point(178, 20);
			this.rbRecibiServicio.Name = "rbRecibiServicio";
			this.rbRecibiServicio.Size = new System.Drawing.Size(63, 17);
			this.rbRecibiServicio.TabIndex = 1;
			this.rbRecibiServicio.Text = "Servicio";
			this.rbRecibiServicio.UseVisualStyleBackColor = true;
			// 
			// rbRecibiMercancia
			// 
			this.rbRecibiMercancia.AutoSize = true;
			this.rbRecibiMercancia.Checked = true;
			this.rbRecibiMercancia.Location = new System.Drawing.Point(19, 20);
			this.rbRecibiMercancia.Name = "rbRecibiMercancia";
			this.rbRecibiMercancia.Size = new System.Drawing.Size(77, 17);
			this.rbRecibiMercancia.TabIndex = 0;
			this.rbRecibiMercancia.TabStop = true;
			this.rbRecibiMercancia.Text = "Mercancía";
			this.rbRecibiMercancia.UseVisualStyleBackColor = true;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.checkImpresionDetalleCodigo);
			this.groupBox7.Controls.Add(this.checkImpresionDetalleIVA);
			this.groupBox7.Controls.Add(this.checkImpresionDetalleCantidad);
			this.groupBox7.Controls.Add(this.checkImpresionDetalleDescuento);
			this.groupBox7.Location = new System.Drawing.Point(200, 6);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(200, 75);
			this.groupBox7.TabIndex = 60;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Imprimir en el detalle:";
			// 
			// checkImpresionDetalleCodigo
			// 
			this.checkImpresionDetalleCodigo.Location = new System.Drawing.Point(8, 19);
			this.checkImpresionDetalleCodigo.Name = "checkImpresionDetalleCodigo";
			this.checkImpresionDetalleCodigo.Size = new System.Drawing.Size(62, 17);
			this.checkImpresionDetalleCodigo.TabIndex = 59;
			this.checkImpresionDetalleCodigo.Text = "Codigo";
			this.checkImpresionDetalleCodigo.UseVisualStyleBackColor = true;
			// 
			// checkImpresionDetalleIVA
			// 
			this.checkImpresionDetalleIVA.Location = new System.Drawing.Point(93, 19);
			this.checkImpresionDetalleIVA.Name = "checkImpresionDetalleIVA";
			this.checkImpresionDetalleIVA.Size = new System.Drawing.Size(62, 17);
			this.checkImpresionDetalleIVA.TabIndex = 56;
			this.checkImpresionDetalleIVA.Text = "% IVA";
			this.checkImpresionDetalleIVA.UseVisualStyleBackColor = true;
			// 
			// checkImpresionDetalleCantidad
			// 
			this.checkImpresionDetalleCantidad.Location = new System.Drawing.Point(8, 42);
			this.checkImpresionDetalleCantidad.Name = "checkImpresionDetalleCantidad";
			this.checkImpresionDetalleCantidad.Size = new System.Drawing.Size(79, 17);
			this.checkImpresionDetalleCantidad.TabIndex = 58;
			this.checkImpresionDetalleCantidad.Text = "Cantidad";
			this.checkImpresionDetalleCantidad.UseVisualStyleBackColor = true;
			// 
			// checkImpresionDetalleDescuento
			// 
			this.checkImpresionDetalleDescuento.Location = new System.Drawing.Point(93, 42);
			this.checkImpresionDetalleDescuento.Name = "checkImpresionDetalleDescuento";
			this.checkImpresionDetalleDescuento.Size = new System.Drawing.Size(79, 17);
			this.checkImpresionDetalleDescuento.TabIndex = 57;
			this.checkImpresionDetalleDescuento.Text = "Descuento";
			this.checkImpresionDetalleDescuento.UseVisualStyleBackColor = true;
			// 
			// checkObservacion2
			// 
			this.checkObservacion2.Location = new System.Drawing.Point(10, 333);
			this.checkObservacion2.Name = "checkObservacion2";
			this.checkObservacion2.Size = new System.Drawing.Size(237, 17);
			this.checkObservacion2.TabIndex = 55;
			this.checkObservacion2.Text = "Selección por defecto la observacion dos";
			this.checkObservacion2.UseVisualStyleBackColor = true;
			// 
			// checkObservacion1
			// 
			this.checkObservacion1.Location = new System.Drawing.Point(10, 310);
			this.checkObservacion1.Name = "checkObservacion1";
			this.checkObservacion1.Size = new System.Drawing.Size(237, 17);
			this.checkObservacion1.TabIndex = 54;
			this.checkObservacion1.Text = "Selección por defecto la observacion uno";
			this.checkObservacion1.UseVisualStyleBackColor = true;
			// 
			// cbEstadoDocumento
			// 
			this.cbEstadoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEstadoDocumento.FormattingEnabled = true;
			this.cbEstadoDocumento.Location = new System.Drawing.Point(129, 283);
			this.cbEstadoDocumento.Name = "cbEstadoDocumento";
			this.cbEstadoDocumento.Size = new System.Drawing.Size(266, 21);
			this.cbEstadoDocumento.TabIndex = 53;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(7, 291);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(116, 13);
			this.label22.TabIndex = 52;
			this.label22.Text = "Estado documento:";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.checkInterno);
			this.groupBox6.Controls.Add(this.checkOtro);
			this.groupBox6.Controls.Add(this.checkProveedorExterior);
			this.groupBox6.Controls.Add(this.checkProveedor);
			this.groupBox6.Controls.Add(this.checkClienteExterior);
			this.groupBox6.Controls.Add(this.checkCliente);
			this.groupBox6.Location = new System.Drawing.Point(9, 205);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(386, 72);
			this.groupBox6.TabIndex = 50;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Solo mostrar terceros";
			// 
			// checkInterno
			// 
			this.checkInterno.AutoSize = true;
			this.checkInterno.Location = new System.Drawing.Point(6, 42);
			this.checkInterno.Name = "checkInterno";
			this.checkInterno.Size = new System.Drawing.Size(59, 17);
			this.checkInterno.TabIndex = 11;
			this.checkInterno.Text = "Interno";
			this.checkInterno.UseVisualStyleBackColor = true;
			// 
			// checkOtro
			// 
			this.checkOtro.AutoSize = true;
			this.checkOtro.Location = new System.Drawing.Point(71, 42);
			this.checkOtro.Name = "checkOtro";
			this.checkOtro.Size = new System.Drawing.Size(91, 17);
			this.checkOtro.TabIndex = 10;
			this.checkOtro.Text = "Externo - Otro";
			this.checkOtro.UseVisualStyleBackColor = true;
			// 
			// checkProveedorExterior
			// 
			this.checkProveedorExterior.AutoSize = true;
			this.checkProveedorExterior.Location = new System.Drawing.Point(252, 19);
			this.checkProveedorExterior.Name = "checkProveedorExterior";
			this.checkProveedorExterior.Size = new System.Drawing.Size(112, 17);
			this.checkProveedorExterior.TabIndex = 9;
			this.checkProveedorExterior.Text = "Proveedor exterior";
			this.checkProveedorExterior.UseVisualStyleBackColor = true;
			// 
			// checkProveedor
			// 
			this.checkProveedor.AutoSize = true;
			this.checkProveedor.Checked = true;
			this.checkProveedor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkProveedor.Location = new System.Drawing.Point(171, 19);
			this.checkProveedor.Name = "checkProveedor";
			this.checkProveedor.Size = new System.Drawing.Size(75, 17);
			this.checkProveedor.TabIndex = 8;
			this.checkProveedor.Text = "Proveedor";
			this.checkProveedor.UseVisualStyleBackColor = true;
			// 
			// checkClienteExterior
			// 
			this.checkClienteExterior.AutoSize = true;
			this.checkClienteExterior.Location = new System.Drawing.Point(70, 19);
			this.checkClienteExterior.Name = "checkClienteExterior";
			this.checkClienteExterior.Size = new System.Drawing.Size(95, 17);
			this.checkClienteExterior.TabIndex = 7;
			this.checkClienteExterior.Text = "Cliente exterior";
			this.checkClienteExterior.UseVisualStyleBackColor = true;
			// 
			// checkCliente
			// 
			this.checkCliente.AutoSize = true;
			this.checkCliente.Checked = true;
			this.checkCliente.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkCliente.Location = new System.Drawing.Point(6, 19);
			this.checkCliente.Name = "checkCliente";
			this.checkCliente.Size = new System.Drawing.Size(58, 17);
			this.checkCliente.TabIndex = 6;
			this.checkCliente.Text = "Cliente";
			this.checkCliente.UseVisualStyleBackColor = true;
			// 
			// checkFondoPapel
			// 
			this.checkFondoPapel.Location = new System.Drawing.Point(7, 52);
			this.checkFondoPapel.Name = "checkFondoPapel";
			this.checkFondoPapel.Size = new System.Drawing.Size(237, 17);
			this.checkFondoPapel.TabIndex = 49;
			this.checkFondoPapel.Text = "Imprimir fondo en el papel";
			this.checkFondoPapel.UseVisualStyleBackColor = true;
			// 
			// checkImpresionLogotipo
			// 
			this.checkImpresionLogotipo.Location = new System.Drawing.Point(7, 29);
			this.checkImpresionLogotipo.Name = "checkImpresionLogotipo";
			this.checkImpresionLogotipo.Size = new System.Drawing.Size(237, 17);
			this.checkImpresionLogotipo.TabIndex = 48;
			this.checkImpresionLogotipo.Text = "Imprimir logotipo de la empresa";
			this.checkImpresionLogotipo.UseVisualStyleBackColor = true;
			// 
			// checkImpresionEncabezado
			// 
			this.checkImpresionEncabezado.Checked = true;
			this.checkImpresionEncabezado.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkImpresionEncabezado.Location = new System.Drawing.Point(7, 6);
			this.checkImpresionEncabezado.Name = "checkImpresionEncabezado";
			this.checkImpresionEncabezado.Size = new System.Drawing.Size(237, 17);
			this.checkImpresionEncabezado.TabIndex = 47;
			this.checkImpresionEncabezado.Text = "Imprimir encabezado de la empresa";
			this.checkImpresionEncabezado.UseVisualStyleBackColor = true;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(11, 95);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(170, 13);
			this.label21.TabIndex = 46;
			this.label21.Text = "Color impresión consecutivo:";
			// 
			// btnColor
			// 
			this.btnColor.Location = new System.Drawing.Point(293, 84);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(21, 23);
			this.btnColor.TabIndex = 45;
			this.btnColor.Text = "...";
			this.btnColor.UseVisualStyleBackColor = true;
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// txtColor
			// 
			this.txtColor.Location = new System.Drawing.Point(187, 87);
			this.txtColor.Name = "txtColor";
			this.txtColor.ReadOnly = true;
			this.txtColor.Size = new System.Drawing.Size(100, 20);
			this.txtColor.TabIndex = 44;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dataGridViewContabilidad);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(403, 414);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Contabilidad";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dataGridViewContabilidad
			// 
			this.dataGridViewContabilidad.AllowUserToAddRows = false;
			this.dataGridViewContabilidad.AllowUserToDeleteRows = false;
			this.dataGridViewContabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewContabilidad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewContabilidad.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewContabilidad.Name = "dataGridViewContabilidad";
			this.dataGridViewContabilidad.Size = new System.Drawing.Size(397, 408);
			this.dataGridViewContabilidad.TabIndex = 0;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.dataGridViewPermisos);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(403, 414);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Permisos";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// dataGridViewPermisos
			// 
			this.dataGridViewPermisos.AllowUserToAddRows = false;
			this.dataGridViewPermisos.AllowUserToDeleteRows = false;
			this.dataGridViewPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewPermisos.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewPermisos.Name = "dataGridViewPermisos";
			this.dataGridViewPermisos.ReadOnly = true;
			this.dataGridViewPermisos.Size = new System.Drawing.Size(397, 408);
			this.dataGridViewPermisos.TabIndex = 0;
			this.dataGridViewPermisos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPermisos_CellFormatting);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(322, 447);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(85, 23);
			this.btnAceptar.TabIndex = 22;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 475);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(412, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// FrmTipoDocumento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 497);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnAceptar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmTipoDocumento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tipo Documento";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTipoDocumento_FormClosing);
			this.Load += new System.EventHandler(this.FormTipoDocumento_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudLimiteRegistros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCerosIzquierda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidadDecimales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudIndice)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewContabilidad)).EndInit();
			this.tabPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
