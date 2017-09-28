/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 12/09/2017
 * Hora: 17:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmPreferencias
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private TabControl tabControlPreferencias;
		private TabPage tabPageSistema;
		private TabPage tabPageEmpresa;
		private Button btnExaminar;
		private TextBox txtLogo;
		private Label label13;
		private TextBox txtFrase;
		private Label label12;
		private TextBox txtIdentidad;
		private Label label14;
		private TextBox txtRazonSocial;
		private Label label15;
		private Label label21;
		private TextBox txtTelefono;
		private Label label17;
		private TextBox txtDireccion;
		private Label label16;
		private Label label22;
		private TextBox txtFax;
		private TextBox txtEmail;
		private CheckBox checkControlaInventario;
		private TabPage tabPageTiposDocumento;
		private TabPage tabPagePlantilla;
		private Label label25;
		private TextBox txtAdvertencia;
		private Label label24;
		private Label label23;
		private TextBox txtLetraCambio;
		private StatusStrip statusStrip1;
		private BindingSource bindingSource1;
		private Label label33;
		private TextBox txtPlantillaObservacion2;
		private Label label30;
		private TextBox txtPlantillaObservacion1;
		private ComboBox cbTipoMoneda;
		private Label label34;
		private TabPage tabPageFirmas;
		private DataGridView dataGridViewTipoDocumentoMaestro;
		private GroupBox groupBox5;
		private RadioButton rbPunto;
		private RadioButton rbComa;
		private CheckBox checkUltimaConfiguracion;
		private Button btnRemove;
		private Button btnAdd;
		private PictureBox pictureBox1;
		private Button btnRemision;
		private Label label27;
		private TextBox txtFirmaRemision;
		private Button btnOrdenCompra;
		private Label label37;
		private TextBox txtFirmaOrdenCompra;
		private Button btnNotas;
		private Label label36;
		private TextBox txtFirmaNotas;
		private Button btnComprobante;
		private Label label32;
		private TextBox txtFirmaComprobante;
		private Button btnFactura;
		private Label label31;
		private TextBox txtFirmaFactura;
		private NumericUpDown nudNumeroDecimal;
		private Label label1;
		private TextBox txtTelefonoMovil;
		private Label label3;
		private TextBox txtOtroTelefono;
		private Label label2;
		private Label label4;
		private TextBox txtPaginaWeb;
		private TextBox txtCodigoCIIU;
		private Label label5;
		private Label label6;
		private Button btnOrdenPedido;
		private Label label7;
		private TextBox txtFirmaOrdenPedido;
		private Button button1;
		private TextBox txtColor;
		private ColorDialog colorDialog1;
		private Label label8;
		private Button btnModificarDocumento;
		private Label label10;
		private ComboBox cbPais;
		private ComboBox cbDepartamento;
		private Label label9;
		private ComboBox cbMunicipio;
		private Label label19;
		private Button btnCotizacion;
		private Label label11;
		private TextBox txtFirmaCotizacion;
		private Label label18;
		private CheckBox checkImpresionLogotipo;
		private CheckBox checkImpresionEncabezado;
		private Button btnExaminarFondo;
		private TextBox txtFondoPapel;
		private Label label20;
		private CheckBox checkClaveAcceso;
		private Button btnLimpiarCotizacion;
		private Button btnLimpiarOrdenPedido;
		private Button btnLimpiarRemision;
		private Button btnLimpiarFactura;
		private Button btnLimpiarComprobante;
		private Button btnLimpiarNotas;
		private Button btnLimpiarOrdenCompra;
		private Label label26;
		private TabPage tabPageUsuarios;
		private Label label29;
		private DataGridView dataGridViewUsuarios;
		private BindingSource bindingSource2;
		private GroupBox groupBox3;
		private RadioButton rbRedondeoInferior;
		private RadioButton rbRedondeoSuperior;
		private RadioButton rbRedondeoSistema;
		private TabPage tabPage1;
		private GroupBox groupBox1;
		private CheckBox checkImprimirTirilla;
		private Label label42;
		public TextBox txtCajonMonedero;
		private ComboBox cbPuertoSalida;
		private Label label41;
		private Label label40;
		private CheckBox checkActivarCajonMonedero;
		private ComboBox cbLectorCodigo;
		private Label label39;
		private ComboBox cbTipoDocumentoFactura;
		private Label label38;
		private Label label35;
		private Button btnBuscarCliente;
		public TextBox txtTercero;
		private ComboBox cbImpresoras;
		private CheckBox checkActivarPuntoVenta;
		private Label label28;
		private CheckBox checkEnvioFormaAnonima;
		private ToolTip toolTip1;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreferencias));
			this.tabControlPreferencias = new System.Windows.Forms.TabControl();
			this.tabPageEmpresa = new System.Windows.Forms.TabPage();
			this.btnExaminarFondo = new System.Windows.Forms.Button();
			this.txtFondoPapel = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.cbMunicipio = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.cbDepartamento = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cbPais = new System.Windows.Forms.ComboBox();
			this.txtCodigoCIIU = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPaginaWeb = new System.Windows.Forms.TextBox();
			this.txtTelefonoMovil = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOtroTelefono = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtIdentidad = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.btnExaminar = new System.Windows.Forms.Button();
			this.txtLogo = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtFrase = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tabPageSistema = new System.Windows.Forms.TabPage();
			this.checkEnvioFormaAnonima = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbRedondeoInferior = new System.Windows.Forms.RadioButton();
			this.rbRedondeoSuperior = new System.Windows.Forms.RadioButton();
			this.rbRedondeoSistema = new System.Windows.Forms.RadioButton();
			this.checkClaveAcceso = new System.Windows.Forms.CheckBox();
			this.checkImpresionLogotipo = new System.Windows.Forms.CheckBox();
			this.checkImpresionEncabezado = new System.Windows.Forms.CheckBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtColor = new System.Windows.Forms.TextBox();
			this.nudNumeroDecimal = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.checkUltimaConfiguracion = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.rbPunto = new System.Windows.Forms.RadioButton();
			this.rbComa = new System.Windows.Forms.RadioButton();
			this.cbTipoMoneda = new System.Windows.Forms.ComboBox();
			this.label34 = new System.Windows.Forms.Label();
			this.checkControlaInventario = new System.Windows.Forms.CheckBox();
			this.tabPageTiposDocumento = new System.Windows.Forms.TabPage();
			this.btnModificarDocumento = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dataGridViewTipoDocumentoMaestro = new System.Windows.Forms.DataGridView();
			this.tabPagePlantilla = new System.Windows.Forms.TabPage();
			this.label33 = new System.Windows.Forms.Label();
			this.txtPlantillaObservacion2 = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.txtPlantillaObservacion1 = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.txtAdvertencia = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.txtLetraCambio = new System.Windows.Forms.TextBox();
			this.tabPageFirmas = new System.Windows.Forms.TabPage();
			this.label26 = new System.Windows.Forms.Label();
			this.btnLimpiarOrdenPedido = new System.Windows.Forms.Button();
			this.btnLimpiarRemision = new System.Windows.Forms.Button();
			this.btnLimpiarFactura = new System.Windows.Forms.Button();
			this.btnLimpiarComprobante = new System.Windows.Forms.Button();
			this.btnLimpiarNotas = new System.Windows.Forms.Button();
			this.btnLimpiarOrdenCompra = new System.Windows.Forms.Button();
			this.btnLimpiarCotizacion = new System.Windows.Forms.Button();
			this.btnCotizacion = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.txtFirmaCotizacion = new System.Windows.Forms.TextBox();
			this.btnOrdenPedido = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFirmaOrdenPedido = new System.Windows.Forms.TextBox();
			this.btnOrdenCompra = new System.Windows.Forms.Button();
			this.label37 = new System.Windows.Forms.Label();
			this.txtFirmaOrdenCompra = new System.Windows.Forms.TextBox();
			this.btnNotas = new System.Windows.Forms.Button();
			this.label36 = new System.Windows.Forms.Label();
			this.txtFirmaNotas = new System.Windows.Forms.TextBox();
			this.btnComprobante = new System.Windows.Forms.Button();
			this.label32 = new System.Windows.Forms.Label();
			this.txtFirmaComprobante = new System.Windows.Forms.TextBox();
			this.btnFactura = new System.Windows.Forms.Button();
			this.label31 = new System.Windows.Forms.Label();
			this.txtFirmaFactura = new System.Windows.Forms.TextBox();
			this.btnRemision = new System.Windows.Forms.Button();
			this.label27 = new System.Windows.Forms.Label();
			this.txtFirmaRemision = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabPageUsuarios = new System.Windows.Forms.TabPage();
			this.label29 = new System.Windows.Forms.Label();
			this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkImprimirTirilla = new System.Windows.Forms.CheckBox();
			this.label42 = new System.Windows.Forms.Label();
			this.txtCajonMonedero = new System.Windows.Forms.TextBox();
			this.cbPuertoSalida = new System.Windows.Forms.ComboBox();
			this.label41 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.checkActivarCajonMonedero = new System.Windows.Forms.CheckBox();
			this.cbLectorCodigo = new System.Windows.Forms.ComboBox();
			this.label39 = new System.Windows.Forms.Label();
			this.cbTipoDocumentoFactura = new System.Windows.Forms.ComboBox();
			this.label38 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.txtTercero = new System.Windows.Forms.TextBox();
			this.cbImpresoras = new System.Windows.Forms.ComboBox();
			this.checkActivarPuntoVenta = new System.Windows.Forms.CheckBox();
			this.label28 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.tabControlPreferencias.SuspendLayout();
			this.tabPageEmpresa.SuspendLayout();
			this.tabPageSistema.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNumeroDecimal)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.tabPageTiposDocumento.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoDocumentoMaestro)).BeginInit();
			this.tabPagePlantilla.SuspendLayout();
			this.tabPageFirmas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPageUsuarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlPreferencias
			// 
			this.tabControlPreferencias.Controls.Add(this.tabPageEmpresa);
			this.tabControlPreferencias.Controls.Add(this.tabPageSistema);
			this.tabControlPreferencias.Controls.Add(this.tabPageTiposDocumento);
			this.tabControlPreferencias.Controls.Add(this.tabPagePlantilla);
			this.tabControlPreferencias.Controls.Add(this.tabPageFirmas);
			this.tabControlPreferencias.Controls.Add(this.tabPageUsuarios);
			this.tabControlPreferencias.Controls.Add(this.tabPage1);
			this.tabControlPreferencias.Location = new System.Drawing.Point(1, 6);
			this.tabControlPreferencias.Name = "tabControlPreferencias";
			this.tabControlPreferencias.SelectedIndex = 0;
			this.tabControlPreferencias.Size = new System.Drawing.Size(593, 347);
			this.tabControlPreferencias.TabIndex = 0;
			// 
			// tabPageEmpresa
			// 
			this.tabPageEmpresa.Controls.Add(this.btnExaminarFondo);
			this.tabPageEmpresa.Controls.Add(this.txtFondoPapel);
			this.tabPageEmpresa.Controls.Add(this.label20);
			this.tabPageEmpresa.Controls.Add(this.cbMunicipio);
			this.tabPageEmpresa.Controls.Add(this.label19);
			this.tabPageEmpresa.Controls.Add(this.cbDepartamento);
			this.tabPageEmpresa.Controls.Add(this.label9);
			this.tabPageEmpresa.Controls.Add(this.label10);
			this.tabPageEmpresa.Controls.Add(this.cbPais);
			this.tabPageEmpresa.Controls.Add(this.txtCodigoCIIU);
			this.tabPageEmpresa.Controls.Add(this.label5);
			this.tabPageEmpresa.Controls.Add(this.label4);
			this.tabPageEmpresa.Controls.Add(this.txtPaginaWeb);
			this.tabPageEmpresa.Controls.Add(this.txtTelefonoMovil);
			this.tabPageEmpresa.Controls.Add(this.label3);
			this.tabPageEmpresa.Controls.Add(this.txtOtroTelefono);
			this.tabPageEmpresa.Controls.Add(this.label2);
			this.tabPageEmpresa.Controls.Add(this.label22);
			this.tabPageEmpresa.Controls.Add(this.txtFax);
			this.tabPageEmpresa.Controls.Add(this.txtEmail);
			this.tabPageEmpresa.Controls.Add(this.label21);
			this.tabPageEmpresa.Controls.Add(this.txtTelefono);
			this.tabPageEmpresa.Controls.Add(this.label17);
			this.tabPageEmpresa.Controls.Add(this.txtDireccion);
			this.tabPageEmpresa.Controls.Add(this.label16);
			this.tabPageEmpresa.Controls.Add(this.txtRazonSocial);
			this.tabPageEmpresa.Controls.Add(this.label15);
			this.tabPageEmpresa.Controls.Add(this.txtIdentidad);
			this.tabPageEmpresa.Controls.Add(this.label14);
			this.tabPageEmpresa.Controls.Add(this.btnExaminar);
			this.tabPageEmpresa.Controls.Add(this.txtLogo);
			this.tabPageEmpresa.Controls.Add(this.label13);
			this.tabPageEmpresa.Controls.Add(this.txtFrase);
			this.tabPageEmpresa.Controls.Add(this.label12);
			this.tabPageEmpresa.Location = new System.Drawing.Point(4, 22);
			this.tabPageEmpresa.Name = "tabPageEmpresa";
			this.tabPageEmpresa.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageEmpresa.Size = new System.Drawing.Size(585, 321);
			this.tabPageEmpresa.TabIndex = 2;
			this.tabPageEmpresa.Text = "Empresa";
			this.tabPageEmpresa.UseVisualStyleBackColor = true;
			// 
			// btnExaminarFondo
			// 
			this.btnExaminarFondo.Location = new System.Drawing.Point(502, 292);
			this.btnExaminarFondo.Name = "btnExaminarFondo";
			this.btnExaminarFondo.Size = new System.Drawing.Size(75, 23);
			this.btnExaminarFondo.TabIndex = 49;
			this.btnExaminarFondo.Text = "Examinar";
			this.btnExaminarFondo.UseVisualStyleBackColor = true;
			this.btnExaminarFondo.Click += new System.EventHandler(this.btnExaminarFondo_Click);
			// 
			// txtFondoPapel
			// 
			this.txtFondoPapel.Location = new System.Drawing.Point(149, 295);
			this.txtFondoPapel.Name = "txtFondoPapel";
			this.txtFondoPapel.ReadOnly = true;
			this.txtFondoPapel.Size = new System.Drawing.Size(352, 20);
			this.txtFondoPapel.TabIndex = 48;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(6, 302);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(141, 13);
			this.label20.TabIndex = 47;
			this.label20.Text = "Fondo papel (800x600):";
			// 
			// cbMunicipio
			// 
			this.cbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMunicipio.FormattingEnabled = true;
			this.cbMunicipio.Location = new System.Drawing.Point(93, 161);
			this.cbMunicipio.Name = "cbMunicipio";
			this.cbMunicipio.Size = new System.Drawing.Size(154, 21);
			this.cbMunicipio.TabIndex = 9;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(6, 169);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(50, 13);
			this.label19.TabIndex = 46;
			this.label19.Text = "Ciudad:";
			// 
			// cbDepartamento
			// 
			this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDepartamento.FormattingEnabled = true;
			this.cbDepartamento.Location = new System.Drawing.Point(360, 134);
			this.cbDepartamento.Name = "cbDepartamento";
			this.cbDepartamento.Size = new System.Drawing.Size(141, 21);
			this.cbDepartamento.TabIndex = 8;
			this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(263, 139);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(90, 13);
			this.label9.TabIndex = 44;
			this.label9.Text = "Departamento:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 142);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 42;
			this.label10.Text = "Pais:";
			// 
			// cbPais
			// 
			this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPais.FormattingEnabled = true;
			this.cbPais.Location = new System.Drawing.Point(94, 134);
			this.cbPais.Name = "cbPais";
			this.cbPais.Size = new System.Drawing.Size(152, 21);
			this.cbPais.TabIndex = 7;
			this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
			// 
			// txtCodigoCIIU
			// 
			this.txtCodigoCIIU.Location = new System.Drawing.Point(94, 214);
			this.txtCodigoCIIU.Name = "txtCodigoCIIU";
			this.txtCodigoCIIU.Size = new System.Drawing.Size(153, 20);
			this.txtCodigoCIIU.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 221);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 40;
			this.label5.Text = "Codigo CIIU:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(266, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 38;
			this.label4.Text = "Pagina web:";
			// 
			// txtPaginaWeb
			// 
			this.txtPaginaWeb.Location = new System.Drawing.Point(360, 188);
			this.txtPaginaWeb.Name = "txtPaginaWeb";
			this.txtPaginaWeb.Size = new System.Drawing.Size(218, 20);
			this.txtPaginaWeb.TabIndex = 11;
			// 
			// txtTelefonoMovil
			// 
			this.txtTelefonoMovil.Location = new System.Drawing.Point(359, 108);
			this.txtTelefonoMovil.Name = "txtTelefonoMovil";
			this.txtTelefonoMovil.Size = new System.Drawing.Size(142, 20);
			this.txtTelefonoMovil.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(265, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 35;
			this.label3.Text = "Movil:";
			// 
			// txtOtroTelefono
			// 
			this.txtOtroTelefono.Location = new System.Drawing.Point(359, 82);
			this.txtOtroTelefono.Name = "txtOtroTelefono";
			this.txtOtroTelefono.Size = new System.Drawing.Size(142, 20);
			this.txtOtroTelefono.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(264, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "Otro Teléfono:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(6, 115);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(31, 13);
			this.label22.TabIndex = 32;
			this.label22.Text = "Fax:";
			// 
			// txtFax
			// 
			this.txtFax.Location = new System.Drawing.Point(93, 108);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(153, 20);
			this.txtFax.TabIndex = 5;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(94, 188);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(153, 20);
			this.txtEmail.TabIndex = 10;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(6, 195);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(41, 13);
			this.label21.TabIndex = 29;
			this.label21.Text = "Email:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(93, 82);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(153, 20);
			this.txtTelefono.TabIndex = 3;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(6, 89);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(61, 13);
			this.label17.TabIndex = 21;
			this.label17.Text = "Teléfono:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(93, 56);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(309, 20);
			this.txtDireccion.TabIndex = 2;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(6, 63);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(65, 13);
			this.label16.TabIndex = 19;
			this.label16.Text = "Dirección:";
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.Location = new System.Drawing.Point(93, 30);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(309, 20);
			this.txtRazonSocial.TabIndex = 1;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(6, 37);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(86, 13);
			this.label15.TabIndex = 17;
			this.label15.Text = "Razon Social:";
			// 
			// txtIdentidad
			// 
			this.txtIdentidad.Location = new System.Drawing.Point(93, 4);
			this.txtIdentidad.Name = "txtIdentidad";
			this.txtIdentidad.Size = new System.Drawing.Size(154, 20);
			this.txtIdentidad.TabIndex = 0;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(6, 11);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 13);
			this.label14.TabIndex = 15;
			this.label14.Text = "N.I.T/R.U.T:";
			// 
			// btnExaminar
			// 
			this.btnExaminar.Location = new System.Drawing.Point(502, 266);
			this.btnExaminar.Name = "btnExaminar";
			this.btnExaminar.Size = new System.Drawing.Size(75, 23);
			this.btnExaminar.TabIndex = 15;
			this.btnExaminar.Text = "Examinar";
			this.btnExaminar.UseVisualStyleBackColor = true;
			this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click_1);
			// 
			// txtLogo
			// 
			this.txtLogo.Location = new System.Drawing.Point(149, 269);
			this.txtLogo.Name = "txtLogo";
			this.txtLogo.ReadOnly = true;
			this.txtLogo.Size = new System.Drawing.Size(352, 20);
			this.txtLogo.TabIndex = 14;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(6, 273);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(140, 13);
			this.label13.TabIndex = 12;
			this.label13.Text = "Logotipo      (320x100):";
			// 
			// txtFrase
			// 
			this.txtFrase.Location = new System.Drawing.Point(94, 240);
			this.txtFrase.Name = "txtFrase";
			this.txtFrase.Size = new System.Drawing.Size(407, 20);
			this.txtFrase.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(6, 247);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(42, 13);
			this.label12.TabIndex = 10;
			this.label12.Text = "Frase:";
			// 
			// tabPageSistema
			// 
			this.tabPageSistema.Controls.Add(this.checkEnvioFormaAnonima);
			this.tabPageSistema.Controls.Add(this.groupBox3);
			this.tabPageSistema.Controls.Add(this.checkClaveAcceso);
			this.tabPageSistema.Controls.Add(this.checkImpresionLogotipo);
			this.tabPageSistema.Controls.Add(this.checkImpresionEncabezado);
			this.tabPageSistema.Controls.Add(this.label18);
			this.tabPageSistema.Controls.Add(this.label8);
			this.tabPageSistema.Controls.Add(this.button1);
			this.tabPageSistema.Controls.Add(this.txtColor);
			this.tabPageSistema.Controls.Add(this.nudNumeroDecimal);
			this.tabPageSistema.Controls.Add(this.label1);
			this.tabPageSistema.Controls.Add(this.checkUltimaConfiguracion);
			this.tabPageSistema.Controls.Add(this.groupBox5);
			this.tabPageSistema.Controls.Add(this.cbTipoMoneda);
			this.tabPageSistema.Controls.Add(this.label34);
			this.tabPageSistema.Controls.Add(this.checkControlaInventario);
			this.tabPageSistema.Location = new System.Drawing.Point(4, 22);
			this.tabPageSistema.Name = "tabPageSistema";
			this.tabPageSistema.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSistema.Size = new System.Drawing.Size(585, 321);
			this.tabPageSistema.TabIndex = 0;
			this.tabPageSistema.Text = "Sistema";
			this.tabPageSistema.UseVisualStyleBackColor = true;
			// 
			// checkEnvioFormaAnonima
			// 
			this.checkEnvioFormaAnonima.Location = new System.Drawing.Point(7, 298);
			this.checkEnvioFormaAnonima.Name = "checkEnvioFormaAnonima";
			this.checkEnvioFormaAnonima.Size = new System.Drawing.Size(340, 17);
			this.checkEnvioFormaAnonima.TabIndex = 53;
			this.checkEnvioFormaAnonima.Text = "Enviar estadisticas a P&&M Software S.A.S de forma anonima.";
			this.toolTip1.SetToolTip(this.checkEnvioFormaAnonima, "Toda la información sobre el diagnóstico y uso se recopila y envía a SoluPYME de " +
		"forma anónima. \r\nNinguna información enviada identifica la empresa, ni sus datos" +
		" de facturación.");
			this.checkEnvioFormaAnonima.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbRedondeoInferior);
			this.groupBox3.Controls.Add(this.rbRedondeoSuperior);
			this.groupBox3.Controls.Add(this.rbRedondeoSistema);
			this.groupBox3.Location = new System.Drawing.Point(269, 119);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(199, 40);
			this.groupBox3.TabIndex = 52;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Formateo de numeros ::: redondeo";
			// 
			// rbRedondeoInferior
			// 
			this.rbRedondeoInferior.AutoSize = true;
			this.rbRedondeoInferior.Location = new System.Drawing.Point(136, 19);
			this.rbRedondeoInferior.Name = "rbRedondeoInferior";
			this.rbRedondeoInferior.Size = new System.Drawing.Size(57, 17);
			this.rbRedondeoInferior.TabIndex = 2;
			this.rbRedondeoInferior.TabStop = true;
			this.rbRedondeoInferior.Text = "Inferior";
			this.rbRedondeoInferior.UseVisualStyleBackColor = true;
			// 
			// rbRedondeoSuperior
			// 
			this.rbRedondeoSuperior.AutoSize = true;
			this.rbRedondeoSuperior.Location = new System.Drawing.Point(70, 19);
			this.rbRedondeoSuperior.Name = "rbRedondeoSuperior";
			this.rbRedondeoSuperior.Size = new System.Drawing.Size(64, 17);
			this.rbRedondeoSuperior.TabIndex = 1;
			this.rbRedondeoSuperior.TabStop = true;
			this.rbRedondeoSuperior.Text = "Superior";
			this.rbRedondeoSuperior.UseVisualStyleBackColor = true;
			// 
			// rbRedondeoSistema
			// 
			this.rbRedondeoSistema.AutoSize = true;
			this.rbRedondeoSistema.Checked = true;
			this.rbRedondeoSistema.Location = new System.Drawing.Point(3, 19);
			this.rbRedondeoSistema.Name = "rbRedondeoSistema";
			this.rbRedondeoSistema.Size = new System.Drawing.Size(62, 17);
			this.rbRedondeoSistema.TabIndex = 0;
			this.rbRedondeoSistema.TabStop = true;
			this.rbRedondeoSistema.Text = "Sistema";
			this.rbRedondeoSistema.UseVisualStyleBackColor = true;
			// 
			// checkClaveAcceso
			// 
			this.checkClaveAcceso.AutoSize = true;
			this.checkClaveAcceso.Location = new System.Drawing.Point(6, 6);
			this.checkClaveAcceso.Name = "checkClaveAcceso";
			this.checkClaveAcceso.Size = new System.Drawing.Size(211, 17);
			this.checkClaveAcceso.TabIndex = 44;
			this.checkClaveAcceso.Text = "Activar seguridad por clave de acceso.";
			this.checkClaveAcceso.UseVisualStyleBackColor = true;
			// 
			// checkImpresionLogotipo
			// 
			this.checkImpresionLogotipo.Location = new System.Drawing.Point(6, 94);
			this.checkImpresionLogotipo.Name = "checkImpresionLogotipo";
			this.checkImpresionLogotipo.Size = new System.Drawing.Size(247, 17);
			this.checkImpresionLogotipo.TabIndex = 43;
			this.checkImpresionLogotipo.Text = "Imprimir logotipo de la empresa (Informes)";
			this.checkImpresionLogotipo.UseVisualStyleBackColor = true;
			// 
			// checkImpresionEncabezado
			// 
			this.checkImpresionEncabezado.Checked = true;
			this.checkImpresionEncabezado.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkImpresionEncabezado.Location = new System.Drawing.Point(6, 72);
			this.checkImpresionEncabezado.Name = "checkImpresionEncabezado";
			this.checkImpresionEncabezado.Size = new System.Drawing.Size(247, 17);
			this.checkImpresionEncabezado.TabIndex = 42;
			this.checkImpresionEncabezado.Text = "Imprimir encabezado de la empresa (Informes)";
			this.checkImpresionEncabezado.UseVisualStyleBackColor = true;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(266, 63);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(116, 13);
			this.label18.TabIndex = 41;
			this.label18.Text = "Separador decimal:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(265, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(170, 13);
			this.label8.TabIndex = 40;
			this.label8.Text = "Color impresión consecutivo:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(548, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(21, 23);
			this.button1.TabIndex = 39;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtColor
			// 
			this.txtColor.Location = new System.Drawing.Point(442, 7);
			this.txtColor.Name = "txtColor";
			this.txtColor.ReadOnly = true;
			this.txtColor.Size = new System.Drawing.Size(100, 20);
			this.txtColor.TabIndex = 38;
			// 
			// nudNumeroDecimal
			// 
			this.nudNumeroDecimal.Location = new System.Drawing.Point(442, 33);
			this.nudNumeroDecimal.Name = "nudNumeroDecimal";
			this.nudNumeroDecimal.Size = new System.Drawing.Size(53, 20);
			this.nudNumeroDecimal.TabIndex = 35;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(265, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 13);
			this.label1.TabIndex = 34;
			this.label1.Text = "Numero decimales impresión:";
			// 
			// checkUltimaConfiguracion
			// 
			this.checkUltimaConfiguracion.Checked = true;
			this.checkUltimaConfiguracion.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkUltimaConfiguracion.Location = new System.Drawing.Point(6, 50);
			this.checkUltimaConfiguracion.Name = "checkUltimaConfiguracion";
			this.checkUltimaConfiguracion.Size = new System.Drawing.Size(237, 17);
			this.checkUltimaConfiguracion.TabIndex = 7;
			this.checkUltimaConfiguracion.Text = "Guardar ultima configuración del documento.";
			this.checkUltimaConfiguracion.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.rbPunto);
			this.groupBox5.Controls.Add(this.rbComa);
			this.groupBox5.Location = new System.Drawing.Point(442, 51);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(127, 31);
			this.groupBox5.TabIndex = 33;
			this.groupBox5.TabStop = false;
			// 
			// rbPunto
			// 
			this.rbPunto.AutoSize = true;
			this.rbPunto.Location = new System.Drawing.Point(64, 10);
			this.rbPunto.Name = "rbPunto";
			this.rbPunto.Size = new System.Drawing.Size(53, 17);
			this.rbPunto.TabIndex = 1;
			this.rbPunto.Text = "Punto";
			this.rbPunto.UseVisualStyleBackColor = true;
			// 
			// rbComa
			// 
			this.rbComa.AutoSize = true;
			this.rbComa.Checked = true;
			this.rbComa.Location = new System.Drawing.Point(6, 10);
			this.rbComa.Name = "rbComa";
			this.rbComa.Size = new System.Drawing.Size(52, 17);
			this.rbComa.TabIndex = 0;
			this.rbComa.TabStop = true;
			this.rbComa.Text = "Coma";
			this.rbComa.UseVisualStyleBackColor = true;
			// 
			// cbTipoMoneda
			// 
			this.cbTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoMoneda.FormattingEnabled = true;
			this.cbTipoMoneda.Location = new System.Drawing.Point(442, 88);
			this.cbTipoMoneda.Name = "cbTipoMoneda";
			this.cbTipoMoneda.Size = new System.Drawing.Size(129, 21);
			this.cbTipoMoneda.TabIndex = 9;
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.Location = new System.Drawing.Point(265, 91);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(171, 13);
			this.label34.TabIndex = 28;
			this.label34.Text = "Tipo de moneda por defecto:";
			// 
			// checkControlaInventario
			// 
			this.checkControlaInventario.AutoSize = true;
			this.checkControlaInventario.Location = new System.Drawing.Point(6, 28);
			this.checkControlaInventario.Name = "checkControlaInventario";
			this.checkControlaInventario.Size = new System.Drawing.Size(206, 17);
			this.checkControlaInventario.TabIndex = 1;
			this.checkControlaInventario.Text = "Controlar inventario desde el software.";
			this.checkControlaInventario.UseVisualStyleBackColor = true;
			// 
			// tabPageTiposDocumento
			// 
			this.tabPageTiposDocumento.Controls.Add(this.btnModificarDocumento);
			this.tabPageTiposDocumento.Controls.Add(this.label6);
			this.tabPageTiposDocumento.Controls.Add(this.btnRemove);
			this.tabPageTiposDocumento.Controls.Add(this.btnAdd);
			this.tabPageTiposDocumento.Controls.Add(this.dataGridViewTipoDocumentoMaestro);
			this.tabPageTiposDocumento.Location = new System.Drawing.Point(4, 22);
			this.tabPageTiposDocumento.Name = "tabPageTiposDocumento";
			this.tabPageTiposDocumento.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTiposDocumento.Size = new System.Drawing.Size(585, 321);
			this.tabPageTiposDocumento.TabIndex = 3;
			this.tabPageTiposDocumento.Text = "Tipos documentos";
			this.tabPageTiposDocumento.UseVisualStyleBackColor = true;
			// 
			// btnModificarDocumento
			// 
			this.btnModificarDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarDocumento.Image")));
			this.btnModificarDocumento.Location = new System.Drawing.Point(555, 291);
			this.btnModificarDocumento.Name = "btnModificarDocumento";
			this.btnModificarDocumento.Size = new System.Drawing.Size(24, 24);
			this.btnModificarDocumento.TabIndex = 96;
			this.btnModificarDocumento.UseVisualStyleBackColor = true;
			this.btnModificarDocumento.Click += new System.EventHandler(this.btnModificarDocumento_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(302, 292);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(246, 13);
			this.label6.TabIndex = 88;
			this.label6.Text = "Doble click en el tipo de documento para modificar";
			// 
			// btnRemove
			// 
			this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
			this.btnRemove.Location = new System.Drawing.Point(34, 292);
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
			this.btnAdd.Location = new System.Drawing.Point(7, 292);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(23, 23);
			this.btnAdd.TabIndex = 86;
			this.btnAdd.Tag = "Mas para agregar un nuevo producto o servicio";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dataGridViewTipoDocumentoMaestro
			// 
			this.dataGridViewTipoDocumentoMaestro.AllowUserToAddRows = false;
			this.dataGridViewTipoDocumentoMaestro.AllowUserToDeleteRows = false;
			this.dataGridViewTipoDocumentoMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTipoDocumentoMaestro.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewTipoDocumentoMaestro.Name = "dataGridViewTipoDocumentoMaestro";
			this.dataGridViewTipoDocumentoMaestro.ReadOnly = true;
			this.dataGridViewTipoDocumentoMaestro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewTipoDocumentoMaestro.Size = new System.Drawing.Size(579, 286);
			this.dataGridViewTipoDocumentoMaestro.TabIndex = 0;
			this.dataGridViewTipoDocumentoMaestro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipoDocumentoMaestro_CellDoubleClick);
			this.dataGridViewTipoDocumentoMaestro.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewTipoDocumentoMaestro_CellFormatting);
			// 
			// tabPagePlantilla
			// 
			this.tabPagePlantilla.Controls.Add(this.label33);
			this.tabPagePlantilla.Controls.Add(this.txtPlantillaObservacion2);
			this.tabPagePlantilla.Controls.Add(this.label30);
			this.tabPagePlantilla.Controls.Add(this.txtPlantillaObservacion1);
			this.tabPagePlantilla.Controls.Add(this.label25);
			this.tabPagePlantilla.Controls.Add(this.txtAdvertencia);
			this.tabPagePlantilla.Controls.Add(this.label24);
			this.tabPagePlantilla.Controls.Add(this.label23);
			this.tabPagePlantilla.Controls.Add(this.txtLetraCambio);
			this.tabPagePlantilla.Location = new System.Drawing.Point(4, 22);
			this.tabPagePlantilla.Name = "tabPagePlantilla";
			this.tabPagePlantilla.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePlantilla.Size = new System.Drawing.Size(585, 321);
			this.tabPagePlantilla.TabIndex = 4;
			this.tabPagePlantilla.Text = "Plantilla de mensajes";
			this.tabPagePlantilla.UseVisualStyleBackColor = true;
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(12, 245);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(139, 13);
			this.label33.TabIndex = 22;
			this.label33.Text = "Plantilla de observación dos";
			// 
			// txtPlantillaObservacion2
			// 
			this.txtPlantillaObservacion2.Location = new System.Drawing.Point(15, 261);
			this.txtPlantillaObservacion2.Multiline = true;
			this.txtPlantillaObservacion2.Name = "txtPlantillaObservacion2";
			this.txtPlantillaObservacion2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtPlantillaObservacion2.Size = new System.Drawing.Size(543, 45);
			this.txtPlantillaObservacion2.TabIndex = 21;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(13, 181);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(140, 13);
			this.label30.TabIndex = 20;
			this.label30.Text = "Plantilla de observación uno";
			// 
			// txtPlantillaObservacion1
			// 
			this.txtPlantillaObservacion1.Location = new System.Drawing.Point(16, 197);
			this.txtPlantillaObservacion1.Multiline = true;
			this.txtPlantillaObservacion1.Name = "txtPlantillaObservacion1";
			this.txtPlantillaObservacion1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtPlantillaObservacion1.Size = new System.Drawing.Size(543, 45);
			this.txtPlantillaObservacion1.TabIndex = 19;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(12, 158);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(218, 13);
			this.label25.TabIndex = 18;
			this.label25.Text = "Para mostrar la empresa utilize {0} o eliminelo";
			// 
			// txtAdvertencia
			// 
			this.txtAdvertencia.Location = new System.Drawing.Point(15, 105);
			this.txtAdvertencia.Multiline = true;
			this.txtAdvertencia.Name = "txtAdvertencia";
			this.txtAdvertencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAdvertencia.Size = new System.Drawing.Size(543, 50);
			this.txtAdvertencia.TabIndex = 17;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(12, 89);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(211, 13);
			this.label24.TabIndex = 16;
			this.label24.Text = "Mensaje de advertencia - central de riesgo.";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(12, 13);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(164, 13);
			this.label23.TabIndex = 14;
			this.label23.Text = "Mensaje letra cambio - titulo valor";
			// 
			// txtLetraCambio
			// 
			this.txtLetraCambio.Location = new System.Drawing.Point(15, 29);
			this.txtLetraCambio.Multiline = true;
			this.txtLetraCambio.Name = "txtLetraCambio";
			this.txtLetraCambio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtLetraCambio.Size = new System.Drawing.Size(543, 48);
			this.txtLetraCambio.TabIndex = 13;
			// 
			// tabPageFirmas
			// 
			this.tabPageFirmas.Controls.Add(this.label26);
			this.tabPageFirmas.Controls.Add(this.btnLimpiarOrdenPedido);
			this.tabPageFirmas.Controls.Add(this.btnLimpiarRemision);
			this.tabPageFirmas.Controls.Add(this.btnLimpiarFactura);
			this.tabPageFirmas.Controls.Add(this.btnLimpiarComprobante);
			this.tabPageFirmas.Controls.Add(this.btnLimpiarNotas);
			this.tabPageFirmas.Controls.Add(this.btnLimpiarOrdenCompra);
			this.tabPageFirmas.Controls.Add(this.btnLimpiarCotizacion);
			this.tabPageFirmas.Controls.Add(this.btnCotizacion);
			this.tabPageFirmas.Controls.Add(this.label11);
			this.tabPageFirmas.Controls.Add(this.txtFirmaCotizacion);
			this.tabPageFirmas.Controls.Add(this.btnOrdenPedido);
			this.tabPageFirmas.Controls.Add(this.label7);
			this.tabPageFirmas.Controls.Add(this.txtFirmaOrdenPedido);
			this.tabPageFirmas.Controls.Add(this.btnOrdenCompra);
			this.tabPageFirmas.Controls.Add(this.label37);
			this.tabPageFirmas.Controls.Add(this.txtFirmaOrdenCompra);
			this.tabPageFirmas.Controls.Add(this.btnNotas);
			this.tabPageFirmas.Controls.Add(this.label36);
			this.tabPageFirmas.Controls.Add(this.txtFirmaNotas);
			this.tabPageFirmas.Controls.Add(this.btnComprobante);
			this.tabPageFirmas.Controls.Add(this.label32);
			this.tabPageFirmas.Controls.Add(this.txtFirmaComprobante);
			this.tabPageFirmas.Controls.Add(this.btnFactura);
			this.tabPageFirmas.Controls.Add(this.label31);
			this.tabPageFirmas.Controls.Add(this.txtFirmaFactura);
			this.tabPageFirmas.Controls.Add(this.btnRemision);
			this.tabPageFirmas.Controls.Add(this.label27);
			this.tabPageFirmas.Controls.Add(this.txtFirmaRemision);
			this.tabPageFirmas.Controls.Add(this.pictureBox1);
			this.tabPageFirmas.Location = new System.Drawing.Point(4, 22);
			this.tabPageFirmas.Name = "tabPageFirmas";
			this.tabPageFirmas.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFirmas.Size = new System.Drawing.Size(585, 321);
			this.tabPageFirmas.TabIndex = 6;
			this.tabPageFirmas.Text = "Imagen de firmas";
			this.tabPageFirmas.UseVisualStyleBackColor = true;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(7, 196);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(273, 13);
			this.label26.TabIndex = 31;
			this.label26.Text = "Vista previa de la imagen. (pasa por la ruta de la imagen)";
			// 
			// btnLimpiarOrdenPedido
			// 
			this.btnLimpiarOrdenPedido.Location = new System.Drawing.Point(519, 159);
			this.btnLimpiarOrdenPedido.Name = "btnLimpiarOrdenPedido";
			this.btnLimpiarOrdenPedido.Size = new System.Drawing.Size(63, 23);
			this.btnLimpiarOrdenPedido.TabIndex = 30;
			this.btnLimpiarOrdenPedido.Text = "Limpiar";
			this.btnLimpiarOrdenPedido.UseVisualStyleBackColor = true;
			this.btnLimpiarOrdenPedido.Click += new System.EventHandler(this.btnLimpiarOrdenPedido_Click);
			// 
			// btnLimpiarRemision
			// 
			this.btnLimpiarRemision.Location = new System.Drawing.Point(519, 29);
			this.btnLimpiarRemision.Name = "btnLimpiarRemision";
			this.btnLimpiarRemision.Size = new System.Drawing.Size(63, 23);
			this.btnLimpiarRemision.TabIndex = 29;
			this.btnLimpiarRemision.Text = "Limpiar";
			this.btnLimpiarRemision.UseVisualStyleBackColor = true;
			this.btnLimpiarRemision.Click += new System.EventHandler(this.btnLimpiarRemision_Click);
			// 
			// btnLimpiarFactura
			// 
			this.btnLimpiarFactura.Location = new System.Drawing.Point(519, 55);
			this.btnLimpiarFactura.Name = "btnLimpiarFactura";
			this.btnLimpiarFactura.Size = new System.Drawing.Size(63, 23);
			this.btnLimpiarFactura.TabIndex = 28;
			this.btnLimpiarFactura.Text = "Limpiar";
			this.btnLimpiarFactura.UseVisualStyleBackColor = true;
			this.btnLimpiarFactura.Click += new System.EventHandler(this.btnLimpiarFactura_Click);
			// 
			// btnLimpiarComprobante
			// 
			this.btnLimpiarComprobante.Location = new System.Drawing.Point(519, 81);
			this.btnLimpiarComprobante.Name = "btnLimpiarComprobante";
			this.btnLimpiarComprobante.Size = new System.Drawing.Size(63, 23);
			this.btnLimpiarComprobante.TabIndex = 27;
			this.btnLimpiarComprobante.Text = "Limpiar";
			this.btnLimpiarComprobante.UseVisualStyleBackColor = true;
			this.btnLimpiarComprobante.Click += new System.EventHandler(this.btnLimpiarComprobante_Click);
			// 
			// btnLimpiarNotas
			// 
			this.btnLimpiarNotas.Location = new System.Drawing.Point(519, 108);
			this.btnLimpiarNotas.Name = "btnLimpiarNotas";
			this.btnLimpiarNotas.Size = new System.Drawing.Size(63, 23);
			this.btnLimpiarNotas.TabIndex = 26;
			this.btnLimpiarNotas.Text = "Limpiar";
			this.btnLimpiarNotas.UseVisualStyleBackColor = true;
			this.btnLimpiarNotas.Click += new System.EventHandler(this.btnLimpiarNotas_Click);
			// 
			// btnLimpiarOrdenCompra
			// 
			this.btnLimpiarOrdenCompra.Location = new System.Drawing.Point(519, 134);
			this.btnLimpiarOrdenCompra.Name = "btnLimpiarOrdenCompra";
			this.btnLimpiarOrdenCompra.Size = new System.Drawing.Size(63, 23);
			this.btnLimpiarOrdenCompra.TabIndex = 25;
			this.btnLimpiarOrdenCompra.Text = "Limpiar";
			this.btnLimpiarOrdenCompra.UseVisualStyleBackColor = true;
			this.btnLimpiarOrdenCompra.Click += new System.EventHandler(this.btnLimpiarOrdenCompra_Click);
			// 
			// btnLimpiarCotizacion
			// 
			this.btnLimpiarCotizacion.Location = new System.Drawing.Point(519, 3);
			this.btnLimpiarCotizacion.Name = "btnLimpiarCotizacion";
			this.btnLimpiarCotizacion.Size = new System.Drawing.Size(63, 23);
			this.btnLimpiarCotizacion.TabIndex = 24;
			this.btnLimpiarCotizacion.Text = "Limpiar";
			this.btnLimpiarCotizacion.UseVisualStyleBackColor = true;
			this.btnLimpiarCotizacion.Click += new System.EventHandler(this.btnLimpiarCotizacion_Click);
			// 
			// btnCotizacion
			// 
			this.btnCotizacion.Location = new System.Drawing.Point(447, 3);
			this.btnCotizacion.Name = "btnCotizacion";
			this.btnCotizacion.Size = new System.Drawing.Size(66, 23);
			this.btnCotizacion.TabIndex = 23;
			this.btnCotizacion.Text = "Examinar";
			this.btnCotizacion.UseVisualStyleBackColor = true;
			this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(7, 13);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(66, 13);
			this.label11.TabIndex = 22;
			this.label11.Text = "Cotización";
			// 
			// txtFirmaCotizacion
			// 
			this.txtFirmaCotizacion.Location = new System.Drawing.Point(101, 6);
			this.txtFirmaCotizacion.Name = "txtFirmaCotizacion";
			this.txtFirmaCotizacion.ReadOnly = true;
			this.txtFirmaCotizacion.Size = new System.Drawing.Size(340, 20);
			this.txtFirmaCotizacion.TabIndex = 21;
			this.txtFirmaCotizacion.MouseLeave += new System.EventHandler(this.txtFirmaCotizacion_MouseLeave);
			this.txtFirmaCotizacion.MouseHover += new System.EventHandler(this.txtFirmaCotizacion_MouseHover);
			// 
			// btnOrdenPedido
			// 
			this.btnOrdenPedido.Location = new System.Drawing.Point(447, 159);
			this.btnOrdenPedido.Name = "btnOrdenPedido";
			this.btnOrdenPedido.Size = new System.Drawing.Size(66, 23);
			this.btnOrdenPedido.TabIndex = 20;
			this.btnOrdenPedido.Text = "Examinar";
			this.btnOrdenPedido.UseVisualStyleBackColor = true;
			this.btnOrdenPedido.Click += new System.EventHandler(this.btnOrdenPedido_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(7, 169);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Orden Pedido:";
			// 
			// txtFirmaOrdenPedido
			// 
			this.txtFirmaOrdenPedido.Location = new System.Drawing.Point(101, 162);
			this.txtFirmaOrdenPedido.Name = "txtFirmaOrdenPedido";
			this.txtFirmaOrdenPedido.ReadOnly = true;
			this.txtFirmaOrdenPedido.Size = new System.Drawing.Size(342, 20);
			this.txtFirmaOrdenPedido.TabIndex = 18;
			this.txtFirmaOrdenPedido.MouseLeave += new System.EventHandler(this.txtFirmaOrdenCompra_MouseLeave);
			this.txtFirmaOrdenPedido.MouseHover += new System.EventHandler(this.txtFirmaOrdenPedido_MouseHover);
			// 
			// btnOrdenCompra
			// 
			this.btnOrdenCompra.Location = new System.Drawing.Point(447, 133);
			this.btnOrdenCompra.Name = "btnOrdenCompra";
			this.btnOrdenCompra.Size = new System.Drawing.Size(66, 23);
			this.btnOrdenCompra.TabIndex = 17;
			this.btnOrdenCompra.Text = "Examinar";
			this.btnOrdenCompra.UseVisualStyleBackColor = true;
			this.btnOrdenCompra.Click += new System.EventHandler(this.btnOrdenCompra_Click);
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label37.Location = new System.Drawing.Point(7, 143);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(91, 13);
			this.label37.TabIndex = 16;
			this.label37.Text = "Orden Compra:";
			// 
			// txtFirmaOrdenCompra
			// 
			this.txtFirmaOrdenCompra.Location = new System.Drawing.Point(101, 136);
			this.txtFirmaOrdenCompra.Name = "txtFirmaOrdenCompra";
			this.txtFirmaOrdenCompra.ReadOnly = true;
			this.txtFirmaOrdenCompra.Size = new System.Drawing.Size(342, 20);
			this.txtFirmaOrdenCompra.TabIndex = 15;
			this.txtFirmaOrdenCompra.MouseLeave += new System.EventHandler(this.txtFirmaOrdenCompra_MouseLeave);
			this.txtFirmaOrdenCompra.MouseHover += new System.EventHandler(this.txtFirmaOrdenCompra_MouseHover);
			// 
			// btnNotas
			// 
			this.btnNotas.Location = new System.Drawing.Point(447, 107);
			this.btnNotas.Name = "btnNotas";
			this.btnNotas.Size = new System.Drawing.Size(66, 23);
			this.btnNotas.TabIndex = 14;
			this.btnNotas.Text = "Examinar";
			this.btnNotas.UseVisualStyleBackColor = true;
			this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(7, 117);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(44, 13);
			this.label36.TabIndex = 13;
			this.label36.Text = "Notas:";
			// 
			// txtFirmaNotas
			// 
			this.txtFirmaNotas.Location = new System.Drawing.Point(101, 110);
			this.txtFirmaNotas.Name = "txtFirmaNotas";
			this.txtFirmaNotas.ReadOnly = true;
			this.txtFirmaNotas.Size = new System.Drawing.Size(342, 20);
			this.txtFirmaNotas.TabIndex = 12;
			this.txtFirmaNotas.MouseLeave += new System.EventHandler(this.txtFirmaNotas_MouseLeave);
			this.txtFirmaNotas.MouseHover += new System.EventHandler(this.txtFirmaNotas_MouseHover);
			// 
			// btnComprobante
			// 
			this.btnComprobante.Location = new System.Drawing.Point(447, 81);
			this.btnComprobante.Name = "btnComprobante";
			this.btnComprobante.Size = new System.Drawing.Size(66, 23);
			this.btnComprobante.TabIndex = 11;
			this.btnComprobante.Text = "Examinar";
			this.btnComprobante.UseVisualStyleBackColor = true;
			this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label32.Location = new System.Drawing.Point(7, 91);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(85, 13);
			this.label32.TabIndex = 10;
			this.label32.Text = "Comprobante:";
			// 
			// txtFirmaComprobante
			// 
			this.txtFirmaComprobante.Location = new System.Drawing.Point(101, 84);
			this.txtFirmaComprobante.Name = "txtFirmaComprobante";
			this.txtFirmaComprobante.ReadOnly = true;
			this.txtFirmaComprobante.Size = new System.Drawing.Size(342, 20);
			this.txtFirmaComprobante.TabIndex = 9;
			this.txtFirmaComprobante.MouseLeave += new System.EventHandler(this.txtFirmaComprobante_MouseLeave);
			this.txtFirmaComprobante.MouseHover += new System.EventHandler(this.txtFirmaComprobante_MouseHover);
			// 
			// btnFactura
			// 
			this.btnFactura.Location = new System.Drawing.Point(447, 55);
			this.btnFactura.Name = "btnFactura";
			this.btnFactura.Size = new System.Drawing.Size(66, 23);
			this.btnFactura.TabIndex = 8;
			this.btnFactura.Text = "Examinar";
			this.btnFactura.UseVisualStyleBackColor = true;
			this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label31.Location = new System.Drawing.Point(7, 65);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(54, 13);
			this.label31.TabIndex = 7;
			this.label31.Text = "Factura:";
			// 
			// txtFirmaFactura
			// 
			this.txtFirmaFactura.Location = new System.Drawing.Point(101, 58);
			this.txtFirmaFactura.Name = "txtFirmaFactura";
			this.txtFirmaFactura.ReadOnly = true;
			this.txtFirmaFactura.Size = new System.Drawing.Size(342, 20);
			this.txtFirmaFactura.TabIndex = 6;
			this.txtFirmaFactura.MouseLeave += new System.EventHandler(this.txtFirmaFactura_MouseLeave);
			this.txtFirmaFactura.MouseHover += new System.EventHandler(this.txtFirmaFactura_MouseHover);
			// 
			// btnRemision
			// 
			this.btnRemision.Location = new System.Drawing.Point(447, 29);
			this.btnRemision.Name = "btnRemision";
			this.btnRemision.Size = new System.Drawing.Size(66, 23);
			this.btnRemision.TabIndex = 5;
			this.btnRemision.Text = "Examinar";
			this.btnRemision.UseVisualStyleBackColor = true;
			this.btnRemision.Click += new System.EventHandler(this.btnRemision_Click);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(7, 39);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(58, 13);
			this.label27.TabIndex = 4;
			this.label27.Text = "Remisión";
			// 
			// txtFirmaRemision
			// 
			this.txtFirmaRemision.Location = new System.Drawing.Point(101, 32);
			this.txtFirmaRemision.Name = "txtFirmaRemision";
			this.txtFirmaRemision.ReadOnly = true;
			this.txtFirmaRemision.Size = new System.Drawing.Size(342, 20);
			this.txtFirmaRemision.TabIndex = 3;
			this.txtFirmaRemision.MouseLeave += new System.EventHandler(this.txtFirmaRemision_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(7, 215);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(250, 100);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// tabPageUsuarios
			// 
			this.tabPageUsuarios.Controls.Add(this.label29);
			this.tabPageUsuarios.Controls.Add(this.dataGridViewUsuarios);
			this.tabPageUsuarios.Location = new System.Drawing.Point(4, 22);
			this.tabPageUsuarios.Name = "tabPageUsuarios";
			this.tabPageUsuarios.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageUsuarios.Size = new System.Drawing.Size(585, 321);
			this.tabPageUsuarios.TabIndex = 8;
			this.tabPageUsuarios.Text = "Usuarios";
			this.tabPageUsuarios.UseVisualStyleBackColor = true;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(368, 293);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(181, 13);
			this.label29.TabIndex = 100;
			this.label29.Text = "Doble click en usuario para modificar";
			// 
			// dataGridViewUsuarios
			// 
			this.dataGridViewUsuarios.AllowUserToAddRows = false;
			this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
			this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsuarios.Location = new System.Drawing.Point(3, 4);
			this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
			this.dataGridViewUsuarios.ReadOnly = true;
			this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewUsuarios.Size = new System.Drawing.Size(579, 286);
			this.dataGridViewUsuarios.TabIndex = 97;
			this.dataGridViewUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewUsuarios_CellFormatting);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(585, 321);
			this.tabPage1.TabIndex = 9;
			this.tabPage1.Text = "TPV";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkImprimirTirilla);
			this.groupBox1.Controls.Add(this.label42);
			this.groupBox1.Controls.Add(this.txtCajonMonedero);
			this.groupBox1.Controls.Add(this.cbPuertoSalida);
			this.groupBox1.Controls.Add(this.label41);
			this.groupBox1.Controls.Add(this.label40);
			this.groupBox1.Controls.Add(this.checkActivarCajonMonedero);
			this.groupBox1.Controls.Add(this.cbLectorCodigo);
			this.groupBox1.Controls.Add(this.label39);
			this.groupBox1.Controls.Add(this.cbTipoDocumentoFactura);
			this.groupBox1.Controls.Add(this.label38);
			this.groupBox1.Controls.Add(this.label35);
			this.groupBox1.Controls.Add(this.btnBuscarCliente);
			this.groupBox1.Controls.Add(this.txtTercero);
			this.groupBox1.Controls.Add(this.cbImpresoras);
			this.groupBox1.Controls.Add(this.checkActivarPuntoVenta);
			this.groupBox1.Controls.Add(this.label28);
			this.groupBox1.Location = new System.Drawing.Point(7, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(257, 314);
			this.groupBox1.TabIndex = 47;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Terminal punto de venta";
			// 
			// checkImprimirTirilla
			// 
			this.checkImprimirTirilla.AutoSize = true;
			this.checkImprimirTirilla.Location = new System.Drawing.Point(6, 291);
			this.checkImprimirTirilla.Name = "checkImprimirTirilla";
			this.checkImprimirTirilla.Size = new System.Drawing.Size(88, 17);
			this.checkImprimirTirilla.TabIndex = 58;
			this.checkImprimirTirilla.Text = "Imprimir Tirilla";
			this.checkImprimirTirilla.UseVisualStyleBackColor = true;
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label42.Location = new System.Drawing.Point(6, 256);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(128, 13);
			this.label42.TabIndex = 57;
			this.label42.Text = "Ejemplo: 27,112,0,25,250";
			// 
			// txtCajonMonedero
			// 
			this.txtCajonMonedero.Location = new System.Drawing.Point(6, 233);
			this.txtCajonMonedero.Name = "txtCajonMonedero";
			this.txtCajonMonedero.Size = new System.Drawing.Size(245, 20);
			this.txtCajonMonedero.TabIndex = 56;
			// 
			// cbPuertoSalida
			// 
			this.cbPuertoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPuertoSalida.FormattingEnabled = true;
			this.cbPuertoSalida.Items.AddRange(new object[] {
			"LPT1",
			"LPT2",
			"LPT3",
			"LPT4",
			"COM1",
			"COM2",
			"COM3",
			"COM4"});
			this.cbPuertoSalida.Location = new System.Drawing.Point(98, 183);
			this.cbPuertoSalida.Name = "cbPuertoSalida";
			this.cbPuertoSalida.Size = new System.Drawing.Size(153, 21);
			this.cbPuertoSalida.TabIndex = 55;
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label41.Location = new System.Drawing.Point(6, 217);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(122, 13);
			this.label41.TabIndex = 54;
			this.label41.Text = "Código cajón monedero:";
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label40.Location = new System.Drawing.Point(6, 191);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(86, 13);
			this.label40.TabIndex = 53;
			this.label40.Text = "Puerto de salida:";
			// 
			// checkActivarCajonMonedero
			// 
			this.checkActivarCajonMonedero.AutoSize = true;
			this.checkActivarCajonMonedero.Location = new System.Drawing.Point(113, 291);
			this.checkActivarCajonMonedero.Name = "checkActivarCajonMonedero";
			this.checkActivarCajonMonedero.Size = new System.Drawing.Size(141, 17);
			this.checkActivarCajonMonedero.TabIndex = 52;
			this.checkActivarCajonMonedero.Text = "Activar cajón monedero.";
			this.checkActivarCajonMonedero.UseVisualStyleBackColor = true;
			// 
			// cbLectorCodigo
			// 
			this.cbLectorCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLectorCodigo.FormattingEnabled = true;
			this.cbLectorCodigo.Items.AddRange(new object[] {
			"BARRAS",
			"PLU",
			"GENERAL"});
			this.cbLectorCodigo.Location = new System.Drawing.Point(109, 120);
			this.cbLectorCodigo.Name = "cbLectorCodigo";
			this.cbLectorCodigo.Size = new System.Drawing.Size(143, 21);
			this.cbLectorCodigo.TabIndex = 51;
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label39.Location = new System.Drawing.Point(7, 128);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(96, 13);
			this.label39.TabIndex = 50;
			this.label39.Text = "Buscar codigo por:";
			// 
			// cbTipoDocumentoFactura
			// 
			this.cbTipoDocumentoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoDocumentoFactura.FormattingEnabled = true;
			this.cbTipoDocumentoFactura.Location = new System.Drawing.Point(7, 93);
			this.cbTipoDocumentoFactura.Name = "cbTipoDocumentoFactura";
			this.cbTipoDocumentoFactura.Size = new System.Drawing.Size(245, 21);
			this.cbTipoDocumentoFactura.TabIndex = 49;
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label38.Location = new System.Drawing.Point(7, 77);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(192, 13);
			this.label38.TabIndex = 48;
			this.label38.Text = "Tipo de documento (Factura de venta):";
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Location = new System.Drawing.Point(6, 35);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(104, 13);
			this.label35.TabIndex = 47;
			this.label35.Text = "Tercero por defecto:";
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
			this.btnBuscarCliente.Location = new System.Drawing.Point(227, 47);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(24, 24);
			this.btnBuscarCliente.TabIndex = 47;
			this.btnBuscarCliente.UseVisualStyleBackColor = true;
			this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
			// 
			// txtTercero
			// 
			this.txtTercero.Location = new System.Drawing.Point(6, 51);
			this.txtTercero.Name = "txtTercero";
			this.txtTercero.ReadOnly = true;
			this.txtTercero.Size = new System.Drawing.Size(216, 20);
			this.txtTercero.TabIndex = 46;
			// 
			// cbImpresoras
			// 
			this.cbImpresoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbImpresoras.FormattingEnabled = true;
			this.cbImpresoras.Location = new System.Drawing.Point(9, 160);
			this.cbImpresoras.Name = "cbImpresoras";
			this.cbImpresoras.Size = new System.Drawing.Size(245, 21);
			this.cbImpresoras.TabIndex = 8;
			// 
			// checkActivarPuntoVenta
			// 
			this.checkActivarPuntoVenta.AutoSize = true;
			this.checkActivarPuntoVenta.Location = new System.Drawing.Point(6, 18);
			this.checkActivarPuntoVenta.Name = "checkActivarPuntoVenta";
			this.checkActivarPuntoVenta.Size = new System.Drawing.Size(176, 17);
			this.checkActivarPuntoVenta.TabIndex = 45;
			this.checkActivarPuntoVenta.Text = "Activar terminal punto de venta.";
			this.checkActivarPuntoVenta.UseVisualStyleBackColor = true;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(6, 144);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(132, 13);
			this.label28.TabIndex = 5;
			this.label28.Text = "Impresora predeterminada:";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 386);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(594, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolTip1
			// 
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			// 
			// btnCerrar
			// 
			this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(498, 354);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(92, 28);
			this.btnCerrar.TabIndex = 4;
			this.btnCerrar.Text = "&Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(405, 354);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(92, 28);
			this.btnGuardar.TabIndex = 5;
			this.btnGuardar.Text = "&Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// FrmPreferencias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 408);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControlPreferencias);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmPreferencias";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Preferencias";
			this.Load += new System.EventHandler(this.FrmPreferencias_Load);
			this.tabControlPreferencias.ResumeLayout(false);
			this.tabPageEmpresa.ResumeLayout(false);
			this.tabPageEmpresa.PerformLayout();
			this.tabPageSistema.ResumeLayout(false);
			this.tabPageSistema.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNumeroDecimal)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.tabPageTiposDocumento.ResumeLayout(false);
			this.tabPageTiposDocumento.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoDocumentoMaestro)).EndInit();
			this.tabPagePlantilla.ResumeLayout(false);
			this.tabPagePlantilla.PerformLayout();
			this.tabPageFirmas.ResumeLayout(false);
			this.tabPageFirmas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPageUsuarios.ResumeLayout(false);
			this.tabPageUsuarios.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
