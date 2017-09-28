/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 8:20 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmTercero
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTercero));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.txtReferenciaComercial = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.checkGranContribuyente = new System.Windows.Forms.CheckBox();
			this.checkExcentoIVA = new System.Windows.Forms.CheckBox();
			this.cbMunicipio = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.cbDepartamento = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtTelefono2 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkInterno = new System.Windows.Forms.CheckBox();
			this.checkOtro = new System.Windows.Forms.CheckBox();
			this.checkProveedorExterior = new System.Windows.Forms.CheckBox();
			this.checkProveedor = new System.Windows.Forms.CheckBox();
			this.checkClienteExterior = new System.Windows.Forms.CheckBox();
			this.checkCliente = new System.Windows.Forms.CheckBox();
			this.txtContacto = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtSegundoApellido = new System.Windows.Forms.TextBox();
			this.txtPrimerApellido = new System.Windows.Forms.TextBox();
			this.txtOtroNombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrimerNombre = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbSimplificado = new System.Windows.Forms.RadioButton();
			this.rbComun = new System.Windows.Forms.RadioButton();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.cbTipoPrecio = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.cbCalificacion = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.cbPais = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNIT = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDigitoVerificacion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombreComercial = new System.Windows.Forms.TextBox();
			this.checkInhabilitar = new System.Windows.Forms.CheckBox();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 424);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(661, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 65);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(660, 321);
			this.tabControl1.TabIndex = 10;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.txtObservacion);
			this.tabPage1.Controls.Add(this.label23);
			this.tabPage1.Controls.Add(this.txtReferenciaComercial);
			this.tabPage1.Controls.Add(this.label22);
			this.tabPage1.Controls.Add(this.checkGranContribuyente);
			this.tabPage1.Controls.Add(this.checkExcentoIVA);
			this.tabPage1.Controls.Add(this.cbMunicipio);
			this.tabPage1.Controls.Add(this.label19);
			this.tabPage1.Controls.Add(this.txtCelular);
			this.tabPage1.Controls.Add(this.label18);
			this.tabPage1.Controls.Add(this.cbDepartamento);
			this.tabPage1.Controls.Add(this.label17);
			this.tabPage1.Controls.Add(this.txtEmail);
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.txtTelefono2);
			this.tabPage1.Controls.Add(this.label15);
			this.tabPage1.Controls.Add(this.txtFax);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.txtTelefono);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.txtDireccion);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.txtContacto);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.txtSegundoApellido);
			this.tabPage1.Controls.Add(this.txtPrimerApellido);
			this.tabPage1.Controls.Add(this.txtOtroNombre);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.txtPrimerNombre);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.txtRazonSocial);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(652, 295);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// txtObservacion
			// 
			this.txtObservacion.Location = new System.Drawing.Point(100, 248);
			this.txtObservacion.Multiline = true;
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.Size = new System.Drawing.Size(434, 34);
			this.txtObservacion.TabIndex = 15;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(3, 269);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(82, 13);
			this.label23.TabIndex = 50;
			this.label23.Text = "Observación:";
			// 
			// txtReferenciaComercial
			// 
			this.txtReferenciaComercial.Location = new System.Drawing.Point(100, 222);
			this.txtReferenciaComercial.Name = "txtReferenciaComercial";
			this.txtReferenciaComercial.Size = new System.Drawing.Size(434, 20);
			this.txtReferenciaComercial.TabIndex = 14;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(3, 229);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(73, 13);
			this.label22.TabIndex = 49;
			this.label22.Text = "Referencia:";
			// 
			// checkGranContribuyente
			// 
			this.checkGranContribuyente.AutoSize = true;
			this.checkGranContribuyente.Location = new System.Drawing.Point(550, 98);
			this.checkGranContribuyente.Name = "checkGranContribuyente";
			this.checkGranContribuyente.Size = new System.Drawing.Size(88, 17);
			this.checkGranContribuyente.TabIndex = 43;
			this.checkGranContribuyente.Text = "Gran Contrib.";
			this.checkGranContribuyente.UseVisualStyleBackColor = true;
			// 
			// checkExcentoIVA
			// 
			this.checkExcentoIVA.AutoSize = true;
			this.checkExcentoIVA.Location = new System.Drawing.Point(550, 74);
			this.checkExcentoIVA.Name = "checkExcentoIVA";
			this.checkExcentoIVA.Size = new System.Drawing.Size(88, 17);
			this.checkExcentoIVA.TabIndex = 42;
			this.checkExcentoIVA.Text = "Excento IVA.";
			this.checkExcentoIVA.UseVisualStyleBackColor = true;
			// 
			// cbMunicipio
			// 
			this.cbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMunicipio.FormattingEnabled = true;
			this.cbMunicipio.Location = new System.Drawing.Point(321, 192);
			this.cbMunicipio.Name = "cbMunicipio";
			this.cbMunicipio.Size = new System.Drawing.Size(213, 21);
			this.cbMunicipio.TabIndex = 13;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(250, 200);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(65, 13);
			this.label19.TabIndex = 40;
			this.label19.Text = "Municipio:";
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(428, 140);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(106, 20);
			this.txtCelular.TabIndex = 9;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(377, 147);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(50, 13);
			this.label18.TabIndex = 38;
			this.label18.Text = "Celular:";
			// 
			// cbDepartamento
			// 
			this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDepartamento.FormattingEnabled = true;
			this.cbDepartamento.Location = new System.Drawing.Point(100, 195);
			this.cbDepartamento.Name = "cbDepartamento";
			this.cbDepartamento.Size = new System.Drawing.Size(144, 21);
			this.cbDepartamento.TabIndex = 12;
			this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(3, 200);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(90, 13);
			this.label17.TabIndex = 36;
			this.label17.Text = "Departamento:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(264, 166);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(270, 20);
			this.txtEmail.TabIndex = 11;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(195, 173);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(45, 13);
			this.label14.TabIndex = 32;
			this.label14.Text = "E-mail:";
			// 
			// txtTelefono2
			// 
			this.txtTelefono2.Location = new System.Drawing.Point(264, 140);
			this.txtTelefono2.Name = "txtTelefono2";
			this.txtTelefono2.Size = new System.Drawing.Size(107, 20);
			this.txtTelefono2.TabIndex = 8;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(195, 147);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 13);
			this.label15.TabIndex = 30;
			this.label15.Text = "Teléfono 2:";
			// 
			// txtFax
			// 
			this.txtFax.Location = new System.Drawing.Point(72, 166);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(121, 20);
			this.txtFax.TabIndex = 10;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(3, 173);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(31, 13);
			this.label12.TabIndex = 28;
			this.label12.Text = "Fax:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(72, 140);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(121, 20);
			this.txtTelefono.TabIndex = 7;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(3, 147);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(61, 13);
			this.label13.TabIndex = 26;
			this.label13.Text = "Teléfono:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(71, 114);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(463, 20);
			this.txtDireccion.TabIndex = 6;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(3, 121);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(65, 13);
			this.label11.TabIndex = 24;
			this.label11.Text = "Dirección:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkInterno);
			this.groupBox2.Controls.Add(this.checkOtro);
			this.groupBox2.Controls.Add(this.checkProveedorExterior);
			this.groupBox2.Controls.Add(this.checkProveedor);
			this.groupBox2.Controls.Add(this.checkClienteExterior);
			this.groupBox2.Controls.Add(this.checkCliente);
			this.groupBox2.Location = new System.Drawing.Point(544, 121);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(100, 158);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tipo tercero";
			// 
			// checkInterno
			// 
			this.checkInterno.AutoSize = true;
			this.checkInterno.Location = new System.Drawing.Point(6, 135);
			this.checkInterno.Name = "checkInterno";
			this.checkInterno.Size = new System.Drawing.Size(59, 17);
			this.checkInterno.TabIndex = 5;
			this.checkInterno.Text = "Interno";
			this.checkInterno.UseVisualStyleBackColor = true;
			// 
			// checkOtro
			// 
			this.checkOtro.AutoSize = true;
			this.checkOtro.Location = new System.Drawing.Point(6, 114);
			this.checkOtro.Name = "checkOtro";
			this.checkOtro.Size = new System.Drawing.Size(91, 17);
			this.checkOtro.TabIndex = 4;
			this.checkOtro.Text = "Externo - Otro";
			this.checkOtro.UseVisualStyleBackColor = true;
			// 
			// checkProveedorExterior
			// 
			this.checkProveedorExterior.AutoSize = true;
			this.checkProveedorExterior.Location = new System.Drawing.Point(6, 92);
			this.checkProveedorExterior.Name = "checkProveedorExterior";
			this.checkProveedorExterior.Size = new System.Drawing.Size(92, 17);
			this.checkProveedorExterior.TabIndex = 3;
			this.checkProveedorExterior.Text = "Proveedor ext";
			this.checkProveedorExterior.UseVisualStyleBackColor = true;
			this.checkProveedorExterior.CheckedChanged += new System.EventHandler(this.checkProveedorExterior_CheckedChanged);
			// 
			// checkProveedor
			// 
			this.checkProveedor.AutoSize = true;
			this.checkProveedor.Location = new System.Drawing.Point(6, 68);
			this.checkProveedor.Name = "checkProveedor";
			this.checkProveedor.Size = new System.Drawing.Size(75, 17);
			this.checkProveedor.TabIndex = 2;
			this.checkProveedor.Text = "Proveedor";
			this.checkProveedor.UseVisualStyleBackColor = true;
			this.checkProveedor.CheckedChanged += new System.EventHandler(this.checkProveedor_CheckedChanged);
			// 
			// checkClienteExterior
			// 
			this.checkClienteExterior.AutoSize = true;
			this.checkClienteExterior.Location = new System.Drawing.Point(6, 44);
			this.checkClienteExterior.Name = "checkClienteExterior";
			this.checkClienteExterior.Size = new System.Drawing.Size(95, 17);
			this.checkClienteExterior.TabIndex = 1;
			this.checkClienteExterior.Text = "Cliente exterior";
			this.checkClienteExterior.UseVisualStyleBackColor = true;
			this.checkClienteExterior.CheckedChanged += new System.EventHandler(this.checkClienteExterior_CheckedChanged);
			// 
			// checkCliente
			// 
			this.checkCliente.AutoSize = true;
			this.checkCliente.Checked = true;
			this.checkCliente.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkCliente.Location = new System.Drawing.Point(6, 20);
			this.checkCliente.Name = "checkCliente";
			this.checkCliente.Size = new System.Drawing.Size(58, 17);
			this.checkCliente.TabIndex = 0;
			this.checkCliente.Text = "Cliente";
			this.checkCliente.UseVisualStyleBackColor = true;
			this.checkCliente.CheckedChanged += new System.EventHandler(this.checkCliente_CheckedChanged);
			// 
			// txtContacto
			// 
			this.txtContacto.Location = new System.Drawing.Point(71, 88);
			this.txtContacto.Name = "txtContacto";
			this.txtContacto.Size = new System.Drawing.Size(463, 20);
			this.txtContacto.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(3, 95);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "Contacto:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(3, 66);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "Primer apellido:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(249, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "Segundo apellido:";
			// 
			// txtSegundoApellido
			// 
			this.txtSegundoApellido.Location = new System.Drawing.Point(364, 59);
			this.txtSegundoApellido.Name = "txtSegundoApellido";
			this.txtSegundoApellido.Size = new System.Drawing.Size(170, 20);
			this.txtSegundoApellido.TabIndex = 4;
			// 
			// txtPrimerApellido
			// 
			this.txtPrimerApellido.Location = new System.Drawing.Point(100, 59);
			this.txtPrimerApellido.Name = "txtPrimerApellido";
			this.txtPrimerApellido.Size = new System.Drawing.Size(143, 20);
			this.txtPrimerApellido.TabIndex = 3;
			// 
			// txtOtroNombre
			// 
			this.txtOtroNombre.Location = new System.Drawing.Point(364, 33);
			this.txtOtroNombre.Name = "txtOtroNombre";
			this.txtOtroNombre.Size = new System.Drawing.Size(170, 20);
			this.txtOtroNombre.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(249, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Otro nombre:";
			// 
			// txtPrimerNombre
			// 
			this.txtPrimerNombre.Location = new System.Drawing.Point(100, 33);
			this.txtPrimerNombre.Name = "txtPrimerNombre";
			this.txtPrimerNombre.Size = new System.Drawing.Size(143, 20);
			this.txtPrimerNombre.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Primer nombre:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbSimplificado);
			this.groupBox1.Controls.Add(this.rbComun);
			this.groupBox1.Location = new System.Drawing.Point(544, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(100, 61);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Regimen";
			// 
			// rbSimplificado
			// 
			this.rbSimplificado.AutoSize = true;
			this.rbSimplificado.Location = new System.Drawing.Point(6, 42);
			this.rbSimplificado.Name = "rbSimplificado";
			this.rbSimplificado.Size = new System.Drawing.Size(81, 17);
			this.rbSimplificado.TabIndex = 1;
			this.rbSimplificado.Text = "Simplificado";
			this.rbSimplificado.UseVisualStyleBackColor = true;
			// 
			// rbComun
			// 
			this.rbComun.AutoSize = true;
			this.rbComun.Checked = true;
			this.rbComun.Location = new System.Drawing.Point(6, 19);
			this.rbComun.Name = "rbComun";
			this.rbComun.Size = new System.Drawing.Size(58, 17);
			this.rbComun.TabIndex = 0;
			this.rbComun.TabStop = true;
			this.rbComun.Text = "Común";
			this.rbComun.UseVisualStyleBackColor = true;
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.Location = new System.Drawing.Point(100, 7);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(434, 20);
			this.txtRazonSocial.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Razón social:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.cbTipoPrecio);
			this.tabPage2.Controls.Add(this.label20);
			this.tabPage2.Controls.Add(this.cbCalificacion);
			this.tabPage2.Controls.Add(this.label21);
			this.tabPage2.Controls.Add(this.cbPais);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(652, 295);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Otros datos";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// cbTipoPrecio
			// 
			this.cbTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoPrecio.FormattingEnabled = true;
			this.cbTipoPrecio.Items.AddRange(new object[] {
			"0",
			"1",
			"2"});
			this.cbTipoPrecio.Location = new System.Drawing.Point(91, 60);
			this.cbTipoPrecio.Name = "cbTipoPrecio";
			this.cbTipoPrecio.Size = new System.Drawing.Size(74, 21);
			this.cbTipoPrecio.TabIndex = 51;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(8, 68);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(75, 13);
			this.label20.TabIndex = 50;
			this.label20.Text = "Tipo precio:";
			// 
			// cbCalificacion
			// 
			this.cbCalificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCalificacion.FormattingEnabled = true;
			this.cbCalificacion.Items.AddRange(new object[] {
			"1",
			"2",
			"3",
			"4",
			"5"});
			this.cbCalificacion.Location = new System.Drawing.Point(91, 33);
			this.cbCalificacion.Name = "cbCalificacion";
			this.cbCalificacion.Size = new System.Drawing.Size(74, 21);
			this.cbCalificacion.TabIndex = 49;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(8, 41);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(77, 13);
			this.label21.TabIndex = 48;
			this.label21.Text = "Calificación:";
			// 
			// cbPais
			// 
			this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPais.FormattingEnabled = true;
			this.cbPais.Location = new System.Drawing.Point(42, 6);
			this.cbPais.Name = "cbPais";
			this.cbPais.Size = new System.Drawing.Size(121, 21);
			this.cbPais.TabIndex = 37;
			this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(6, 14);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(35, 13);
			this.label16.TabIndex = 36;
			this.label16.Text = "Pais:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código *:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(128, 11);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(119, 20);
			this.txtCodigo.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(251, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "N.I.T o R.U.T *:";
			// 
			// txtNIT
			// 
			this.txtNIT.Location = new System.Drawing.Point(347, 12);
			this.txtNIT.MaxLength = 15;
			this.txtNIT.Name = "txtNIT";
			this.txtNIT.Size = new System.Drawing.Size(153, 20);
			this.txtNIT.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(506, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "D.V:";
			// 
			// txtDigitoVerificacion
			// 
			this.txtDigitoVerificacion.Location = new System.Drawing.Point(544, 13);
			this.txtDigitoVerificacion.MaxLength = 1;
			this.txtDigitoVerificacion.Name = "txtDigitoVerificacion";
			this.txtDigitoVerificacion.Size = new System.Drawing.Size(29, 20);
			this.txtDigitoVerificacion.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nombre comercial *:";
			// 
			// txtNombreComercial
			// 
			this.txtNombreComercial.Location = new System.Drawing.Point(128, 37);
			this.txtNombreComercial.Name = "txtNombreComercial";
			this.txtNombreComercial.Size = new System.Drawing.Size(372, 20);
			this.txtNombreComercial.TabIndex = 3;
			// 
			// checkInhabilitar
			// 
			this.checkInhabilitar.AutoSize = true;
			this.checkInhabilitar.Location = new System.Drawing.Point(506, 40);
			this.checkInhabilitar.Name = "checkInhabilitar";
			this.checkInhabilitar.Size = new System.Drawing.Size(71, 17);
			this.checkInhabilitar.TabIndex = 9;
			this.checkInhabilitar.Text = "Inhabilitar";
			this.checkInhabilitar.UseVisualStyleBackColor = true;
			// 
			// btnCerrar
			// 
			this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(564, 390);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(92, 28);
			this.btnCerrar.TabIndex = 14;
			this.btnCerrar.Text = "&Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(471, 390);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(92, 28);
			this.btnGuardar.TabIndex = 13;
			this.btnGuardar.Text = "&Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// FrmTercero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 446);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.checkInhabilitar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNombreComercial);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDigitoVerificacion);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.txtNIT);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCodigo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmTercero";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmTerceros";
			this.Load += new System.EventHandler(this.FormTerceros_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
		private StatusStrip statusStrip1;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private Label label2;
		private TextBox txtCodigo;
		private Label label1;
		private TextBox txtNombreComercial;
		private Label label4;
		private TextBox txtDigitoVerificacion;
		private Label label3;
		private TextBox txtNIT;
		private CheckBox checkInhabilitar;
		private TextBox txtRazonSocial;
		private Label label5;
		private GroupBox groupBox1;
		private RadioButton rbSimplificado;
		private RadioButton rbComun;
		private Label label9;
		private Label label8;
		private TextBox txtSegundoApellido;
		private TextBox txtPrimerApellido;
		private TextBox txtOtroNombre;
		private Label label7;
		private TextBox txtPrimerNombre;
		private Label label6;
		private GroupBox groupBox2;
		private TextBox txtContacto;
		private Label label10;
		private CheckBox checkOtro;
		private CheckBox checkProveedorExterior;
		private CheckBox checkProveedor;
		private CheckBox checkClienteExterior;
		private CheckBox checkCliente;
		private TextBox txtFax;
		private Label label12;
		private TextBox txtTelefono;
		private Label label13;
		private TextBox txtDireccion;
		private Label label11;
		private TextBox txtCelular;
		private Label label18;
		private ComboBox cbDepartamento;
		private Label label17;
		private TextBox txtEmail;
		private Label label14;
		private TextBox txtTelefono2;
		private Label label15;
		private ComboBox cbMunicipio;
		private Label label19;
		private CheckBox checkExcentoIVA;
		private ComboBox cbPais;
		private Label label16;
		private CheckBox checkGranContribuyente;
		private CheckBox checkInterno;
		private TextBox txtReferenciaComercial;
		private Label label22;
		private ComboBox cbTipoPrecio;
		private Label label20;
		private ComboBox cbCalificacion;
		private Label label21;
		private TextBox txtObservacion;
		private Label label23;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnGuardar;
	}
}
