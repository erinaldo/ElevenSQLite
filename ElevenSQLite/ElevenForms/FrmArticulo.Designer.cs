/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 9/09/2017
 * Hora: 1:11 p. m.
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
	partial class FrmArticulo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulo));
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label32 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbRedondeoInferior = new System.Windows.Forms.RadioButton();
			this.rbRedondeoSuperior = new System.Windows.Forms.RadioButton();
			this.rbRedondeoSistema = new System.Windows.Forms.RadioButton();
			this.label27 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtValorNeto2 = new System.Windows.Forms.TextBox();
			this.txtPrecioVenta2 = new System.Windows.Forms.TextBox();
			this.txtValorNeto1 = new System.Windows.Forms.TextBox();
			this.cbIVA = new System.Windows.Forms.ComboBox();
			this.cbSeccion = new System.Windows.Forms.ComboBox();
			this.cbFamilia = new System.Windows.Forms.ComboBox();
			this.cbUnidadMedida = new System.Windows.Forms.ComboBox();
			this.txtCodigoPLU = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbExcluido = new System.Windows.Forms.RadioButton();
			this.rbExcento = new System.Windows.Forms.RadioButton();
			this.rbIVA = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.txtStockDisponible = new System.Windows.Forms.TextBox();
			this.txtStockActual = new System.Windows.Forms.TextBox();
			this.txtStockMinimo = new System.Windows.Forms.TextBox();
			this.txtStockMaximo = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtPrecioVenta1 = new System.Windows.Forms.TextBox();
			this.txtPrecioVenta = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtValorNeto = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescripcionCorta = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.txtPartidaArancelaria = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.txtUnidadesArticulo = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtImpuestoConsumo = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.txtCodigoAlternativo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.txtUtilidad2 = new System.Windows.Forms.TextBox();
			this.txtUtilidad1 = new System.Windows.Forms.TextBox();
			this.txtUtilidad = new System.Windows.Forms.TextBox();
			this.txtCostoPonderado = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCodigoBarras = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.checkServicio = new System.Windows.Forms.CheckBox();
			this.checkEstado = new System.Windows.Forms.CheckBox();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Código*:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(96, 14);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Descripción*:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(96, 40);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(537, 20);
			this.txtDescripcion.TabIndex = 4;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(1, 66);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(669, 248);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label32);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.label27);
			this.tabPage1.Controls.Add(this.label21);
			this.tabPage1.Controls.Add(this.label15);
			this.tabPage1.Controls.Add(this.txtValorNeto2);
			this.tabPage1.Controls.Add(this.txtPrecioVenta2);
			this.tabPage1.Controls.Add(this.txtValorNeto1);
			this.tabPage1.Controls.Add(this.cbIVA);
			this.tabPage1.Controls.Add(this.cbSeccion);
			this.tabPage1.Controls.Add(this.cbFamilia);
			this.tabPage1.Controls.Add(this.cbUnidadMedida);
			this.tabPage1.Controls.Add(this.txtCodigoPLU);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.label22);
			this.tabPage1.Controls.Add(this.txtPrecioVenta1);
			this.tabPage1.Controls.Add(this.txtPrecioVenta);
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.txtValorNeto);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.txtCosto);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.txtDescripcionCorta);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(661, 222);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Datos Basicos";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(7, 204);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(0, 13);
			this.label32.TabIndex = 23;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbRedondeoInferior);
			this.groupBox3.Controls.Add(this.rbRedondeoSuperior);
			this.groupBox3.Controls.Add(this.rbRedondeoSistema);
			this.groupBox3.Location = new System.Drawing.Point(456, 177);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(199, 40);
			this.groupBox3.TabIndex = 51;
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
			this.rbRedondeoInferior.CheckedChanged += new System.EventHandler(this.rbRedondeoInferior_CheckedChanged);
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
			this.rbRedondeoSuperior.CheckedChanged += new System.EventHandler(this.rbRedondeoSuperior_CheckedChanged);
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
			this.rbRedondeoSistema.CheckedChanged += new System.EventHandler(this.rbRedondeoNormal_CheckedChanged);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(329, 110);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(54, 13);
			this.label27.TabIndex = 50;
			this.label27.Text = "Precio 3";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(220, 110);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(54, 13);
			this.label21.TabIndex = 49;
			this.label21.Text = "Precio 2";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(105, 110);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(43, 13);
			this.label15.TabIndex = 48;
			this.label15.Text = "Precio";
			// 
			// txtValorNeto2
			// 
			this.txtValorNeto2.Location = new System.Drawing.Point(332, 126);
			this.txtValorNeto2.Name = "txtValorNeto2";
			this.txtValorNeto2.Size = new System.Drawing.Size(106, 20);
			this.txtValorNeto2.TabIndex = 8;
			this.txtValorNeto2.Text = "0";
			this.txtValorNeto2.TextChanged += new System.EventHandler(this.txtValorNeto2_TextChanged);
			// 
			// txtPrecioVenta2
			// 
			this.txtPrecioVenta2.Location = new System.Drawing.Point(332, 179);
			this.txtPrecioVenta2.Name = "txtPrecioVenta2";
			this.txtPrecioVenta2.ReadOnly = true;
			this.txtPrecioVenta2.Size = new System.Drawing.Size(106, 20);
			this.txtPrecioVenta2.TabIndex = 12;
			this.txtPrecioVenta2.Text = "0";
			// 
			// txtValorNeto1
			// 
			this.txtValorNeto1.Location = new System.Drawing.Point(220, 126);
			this.txtValorNeto1.Name = "txtValorNeto1";
			this.txtValorNeto1.Size = new System.Drawing.Size(106, 20);
			this.txtValorNeto1.TabIndex = 7;
			this.txtValorNeto1.Text = "0";
			this.txtValorNeto1.TextChanged += new System.EventHandler(this.txtValorNeto1_TextChanged);
			// 
			// cbIVA
			// 
			this.cbIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIVA.FormattingEnabled = true;
			this.cbIVA.Location = new System.Drawing.Point(108, 152);
			this.cbIVA.Name = "cbIVA";
			this.cbIVA.Size = new System.Drawing.Size(59, 21);
			this.cbIVA.TabIndex = 9;
			this.cbIVA.SelectedIndexChanged += new System.EventHandler(this.cbIVA_SelectedIndexChanged);
			// 
			// cbSeccion
			// 
			this.cbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSeccion.FormattingEnabled = true;
			this.cbSeccion.Location = new System.Drawing.Point(288, 60);
			this.cbSeccion.Name = "cbSeccion";
			this.cbSeccion.Size = new System.Drawing.Size(162, 21);
			this.cbSeccion.TabIndex = 4;
			// 
			// cbFamilia
			// 
			this.cbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFamilia.FormattingEnabled = true;
			this.cbFamilia.Location = new System.Drawing.Point(62, 60);
			this.cbFamilia.Name = "cbFamilia";
			this.cbFamilia.Size = new System.Drawing.Size(163, 21);
			this.cbFamilia.TabIndex = 3;
			this.cbFamilia.SelectedIndexChanged += new System.EventHandler(this.cbFamilia_SelectedIndexChanged);
			// 
			// cbUnidadMedida
			// 
			this.cbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUnidadMedida.FormattingEnabled = true;
			this.cbUnidadMedida.Location = new System.Drawing.Point(124, 33);
			this.cbUnidadMedida.Name = "cbUnidadMedida";
			this.cbUnidadMedida.Size = new System.Drawing.Size(194, 21);
			this.cbUnidadMedida.TabIndex = 2;
			// 
			// txtCodigoPLU
			// 
			this.txtCodigoPLU.Location = new System.Drawing.Point(90, 7);
			this.txtCodigoPLU.MaxLength = 20;
			this.txtCodigoPLU.Name = "txtCodigoPLU";
			this.txtCodigoPLU.Size = new System.Drawing.Size(77, 20);
			this.txtCodigoPLU.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 14);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 13);
			this.label10.TabIndex = 39;
			this.label10.Text = "Codigo PLU:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbExcluido);
			this.groupBox2.Controls.Add(this.rbExcento);
			this.groupBox2.Controls.Add(this.rbIVA);
			this.groupBox2.Location = new System.Drawing.Point(456, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(199, 46);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Impuesto a las Ventas";
			// 
			// rbExcluido
			// 
			this.rbExcluido.AutoSize = true;
			this.rbExcluido.Location = new System.Drawing.Point(128, 19);
			this.rbExcluido.Name = "rbExcluido";
			this.rbExcluido.Size = new System.Drawing.Size(65, 17);
			this.rbExcluido.TabIndex = 2;
			this.rbExcluido.TabStop = true;
			this.rbExcluido.Text = "Excluido";
			this.rbExcluido.UseVisualStyleBackColor = true;
			this.rbExcluido.CheckedChanged += new System.EventHandler(this.rbExcluido_CheckedChanged);
			// 
			// rbExcento
			// 
			this.rbExcento.AutoSize = true;
			this.rbExcento.Location = new System.Drawing.Point(58, 20);
			this.rbExcento.Name = "rbExcento";
			this.rbExcento.Size = new System.Drawing.Size(64, 17);
			this.rbExcento.TabIndex = 1;
			this.rbExcento.TabStop = true;
			this.rbExcento.Text = "Excento";
			this.rbExcento.UseVisualStyleBackColor = true;
			this.rbExcento.CheckedChanged += new System.EventHandler(this.rbExcento_CheckedChanged);
			// 
			// rbIVA
			// 
			this.rbIVA.AutoSize = true;
			this.rbIVA.Checked = true;
			this.rbIVA.Location = new System.Drawing.Point(10, 19);
			this.rbIVA.Name = "rbIVA";
			this.rbIVA.Size = new System.Drawing.Size(42, 17);
			this.rbIVA.TabIndex = 0;
			this.rbIVA.TabStop = true;
			this.rbIVA.Text = "IVA";
			this.rbIVA.UseVisualStyleBackColor = true;
			this.rbIVA.CheckedChanged += new System.EventHandler(this.rbIVA_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.txtStockDisponible);
			this.groupBox1.Controls.Add(this.txtStockActual);
			this.groupBox1.Controls.Add(this.txtStockMinimo);
			this.groupBox1.Controls.Add(this.txtStockMaximo);
			this.groupBox1.Location = new System.Drawing.Point(456, 55);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(199, 116);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stock";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(9, 96);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(56, 13);
			this.label26.TabIndex = 22;
			this.label26.Text = "Disponible";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(9, 70);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(40, 13);
			this.label25.TabIndex = 21;
			this.label25.Text = "Actual:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(9, 44);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(43, 13);
			this.label24.TabIndex = 20;
			this.label24.Text = "Maximo";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(9, 18);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(43, 13);
			this.label23.TabIndex = 19;
			this.label23.Text = "Minimo:";
			// 
			// txtStockDisponible
			// 
			this.txtStockDisponible.Location = new System.Drawing.Point(71, 89);
			this.txtStockDisponible.Name = "txtStockDisponible";
			this.txtStockDisponible.ReadOnly = true;
			this.txtStockDisponible.Size = new System.Drawing.Size(100, 20);
			this.txtStockDisponible.TabIndex = 3;
			this.txtStockDisponible.Text = "0";
			// 
			// txtStockActual
			// 
			this.txtStockActual.Location = new System.Drawing.Point(71, 63);
			this.txtStockActual.Name = "txtStockActual";
			this.txtStockActual.ReadOnly = true;
			this.txtStockActual.Size = new System.Drawing.Size(100, 20);
			this.txtStockActual.TabIndex = 2;
			this.txtStockActual.Text = "0";
			// 
			// txtStockMinimo
			// 
			this.txtStockMinimo.Location = new System.Drawing.Point(71, 11);
			this.txtStockMinimo.Name = "txtStockMinimo";
			this.txtStockMinimo.Size = new System.Drawing.Size(100, 20);
			this.txtStockMinimo.TabIndex = 0;
			this.txtStockMinimo.Text = "0";
			// 
			// txtStockMaximo
			// 
			this.txtStockMaximo.Location = new System.Drawing.Point(71, 37);
			this.txtStockMaximo.Name = "txtStockMaximo";
			this.txtStockMaximo.Size = new System.Drawing.Size(100, 20);
			this.txtStockMaximo.TabIndex = 1;
			this.txtStockMaximo.Text = "0";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(173, 160);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(16, 13);
			this.label22.TabIndex = 32;
			this.label22.Text = "%";
			// 
			// txtPrecioVenta1
			// 
			this.txtPrecioVenta1.Location = new System.Drawing.Point(220, 179);
			this.txtPrecioVenta1.Name = "txtPrecioVenta1";
			this.txtPrecioVenta1.ReadOnly = true;
			this.txtPrecioVenta1.Size = new System.Drawing.Size(106, 20);
			this.txtPrecioVenta1.TabIndex = 11;
			this.txtPrecioVenta1.Text = "0";
			// 
			// txtPrecioVenta
			// 
			this.txtPrecioVenta.Location = new System.Drawing.Point(108, 179);
			this.txtPrecioVenta.Name = "txtPrecioVenta";
			this.txtPrecioVenta.ReadOnly = true;
			this.txtPrecioVenta.Size = new System.Drawing.Size(106, 20);
			this.txtPrecioVenta.TabIndex = 10;
			this.txtPrecioVenta.Text = "0";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(6, 186);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(95, 13);
			this.label14.TabIndex = 21;
			this.label14.Text = "Precio Venta: $";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(6, 160);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(35, 13);
			this.label13.TabIndex = 19;
			this.label13.Text = "IVA: ";
			// 
			// txtValorNeto
			// 
			this.txtValorNeto.Location = new System.Drawing.Point(108, 126);
			this.txtValorNeto.Name = "txtValorNeto";
			this.txtValorNeto.Size = new System.Drawing.Size(106, 20);
			this.txtValorNeto.TabIndex = 6;
			this.txtValorNeto.Text = "0";
			this.txtValorNeto.TextChanged += new System.EventHandler(this.txtValorNeto_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(6, 133);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(98, 13);
			this.label12.TabIndex = 17;
			this.label12.Text = "Valor unitario* $";
			// 
			// txtCosto
			// 
			this.txtCosto.Location = new System.Drawing.Point(108, 87);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(106, 20);
			this.txtCosto.TabIndex = 5;
			this.txtCosto.Text = "0";
			this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 94);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "Costo: $";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(231, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Seccion:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Familia:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Unidad de medida:";
			// 
			// txtDescripcionCorta
			// 
			this.txtDescripcionCorta.Location = new System.Drawing.Point(288, 7);
			this.txtDescripcionCorta.MaxLength = 30;
			this.txtDescripcionCorta.Name = "txtDescripcionCorta";
			this.txtDescripcionCorta.Size = new System.Drawing.Size(162, 20);
			this.txtDescripcionCorta.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(176, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Descripción Corta:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtObservacion);
			this.tabPage2.Controls.Add(this.label31);
			this.tabPage2.Controls.Add(this.txtPartidaArancelaria);
			this.tabPage2.Controls.Add(this.label29);
			this.tabPage2.Controls.Add(this.txtUnidadesArticulo);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.txtImpuestoConsumo);
			this.tabPage2.Controls.Add(this.label30);
			this.tabPage2.Controls.Add(this.txtCodigoAlternativo);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(661, 222);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Otras Configuraciónes";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtObservacion
			// 
			this.txtObservacion.Location = new System.Drawing.Point(94, 60);
			this.txtObservacion.Multiline = true;
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.Size = new System.Drawing.Size(439, 34);
			this.txtObservacion.TabIndex = 46;
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label31.Location = new System.Drawing.Point(6, 65);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(82, 13);
			this.label31.TabIndex = 45;
			this.label31.Text = "Observación:";
			// 
			// txtPartidaArancelaria
			// 
			this.txtPartidaArancelaria.Location = new System.Drawing.Point(416, 30);
			this.txtPartidaArancelaria.Name = "txtPartidaArancelaria";
			this.txtPartidaArancelaria.Size = new System.Drawing.Size(117, 20);
			this.txtPartidaArancelaria.TabIndex = 44;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(278, 37);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(118, 13);
			this.label29.TabIndex = 43;
			this.label29.Text = "Partida arancelaria:";
			// 
			// txtUnidadesArticulo
			// 
			this.txtUnidadesArticulo.Location = new System.Drawing.Point(416, 4);
			this.txtUnidadesArticulo.Name = "txtUnidadesArticulo";
			this.txtUnidadesArticulo.Size = new System.Drawing.Size(117, 20);
			this.txtUnidadesArticulo.TabIndex = 42;
			this.txtUnidadesArticulo.Text = "0";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(278, 11);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(132, 13);
			this.label11.TabIndex = 41;
			this.label11.Text = "Unidades por articulo:";
			// 
			// txtImpuestoConsumo
			// 
			this.txtImpuestoConsumo.Location = new System.Drawing.Point(155, 34);
			this.txtImpuestoConsumo.Name = "txtImpuestoConsumo";
			this.txtImpuestoConsumo.Size = new System.Drawing.Size(117, 20);
			this.txtImpuestoConsumo.TabIndex = 40;
			this.txtImpuestoConsumo.Text = "0";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(6, 41);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(141, 13);
			this.label30.TabIndex = 39;
			this.label30.Text = "Impuesto al consumo: $";
			// 
			// txtCodigoAlternativo
			// 
			this.txtCodigoAlternativo.Location = new System.Drawing.Point(155, 8);
			this.txtCodigoAlternativo.Name = "txtCodigoAlternativo";
			this.txtCodigoAlternativo.Size = new System.Drawing.Size(117, 20);
			this.txtCodigoAlternativo.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 15);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(145, 13);
			this.label9.TabIndex = 15;
			this.label9.Text = "Art. alternativo (codigo):";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label33);
			this.tabPage3.Controls.Add(this.label34);
			this.tabPage3.Controls.Add(this.label35);
			this.tabPage3.Controls.Add(this.txtUtilidad2);
			this.tabPage3.Controls.Add(this.txtUtilidad1);
			this.tabPage3.Controls.Add(this.txtUtilidad);
			this.tabPage3.Controls.Add(this.txtCostoPonderado);
			this.tabPage3.Controls.Add(this.label28);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(661, 222);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Estadistica";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label33.Location = new System.Drawing.Point(11, 92);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(101, 13);
			this.label33.TabIndex = 58;
			this.label33.Text = "Utilidad Precio 3";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.Location = new System.Drawing.Point(11, 66);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(101, 13);
			this.label34.TabIndex = 57;
			this.label34.Text = "Utilidad Precio 2";
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Location = new System.Drawing.Point(11, 40);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(101, 13);
			this.label35.TabIndex = 54;
			this.label35.Text = "Utilidad Precio 1";
			// 
			// txtUtilidad2
			// 
			this.txtUtilidad2.Location = new System.Drawing.Point(125, 85);
			this.txtUtilidad2.Name = "txtUtilidad2";
			this.txtUtilidad2.ReadOnly = true;
			this.txtUtilidad2.Size = new System.Drawing.Size(100, 20);
			this.txtUtilidad2.TabIndex = 53;
			this.txtUtilidad2.Text = "0";
			// 
			// txtUtilidad1
			// 
			this.txtUtilidad1.Location = new System.Drawing.Point(125, 59);
			this.txtUtilidad1.Name = "txtUtilidad1";
			this.txtUtilidad1.ReadOnly = true;
			this.txtUtilidad1.Size = new System.Drawing.Size(100, 20);
			this.txtUtilidad1.TabIndex = 52;
			this.txtUtilidad1.Text = "0";
			// 
			// txtUtilidad
			// 
			this.txtUtilidad.Location = new System.Drawing.Point(125, 33);
			this.txtUtilidad.Name = "txtUtilidad";
			this.txtUtilidad.ReadOnly = true;
			this.txtUtilidad.Size = new System.Drawing.Size(100, 20);
			this.txtUtilidad.TabIndex = 51;
			this.txtUtilidad.Text = "0";
			// 
			// txtCostoPonderado
			// 
			this.txtCostoPonderado.Enabled = false;
			this.txtCostoPonderado.Location = new System.Drawing.Point(125, 7);
			this.txtCostoPonderado.Name = "txtCostoPonderado";
			this.txtCostoPonderado.ReadOnly = true;
			this.txtCostoPonderado.Size = new System.Drawing.Size(100, 20);
			this.txtCostoPonderado.TabIndex = 1;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(11, 14);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(108, 13);
			this.label28.TabIndex = 0;
			this.label28.Text = "Costo Ponderado:";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 352);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(668, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(481, 17);
			this.toolStripStatusLabel1.Text = "Para calcular el valor unitario con respecto a utilidades, doble click en precio " +
	"valor unitario";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(219, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Codigo Barras:";
			// 
			// txtCodigoBarras
			// 
			this.txtCodigoBarras.Location = new System.Drawing.Point(315, 14);
			this.txtCodigoBarras.MaxLength = 20;
			this.txtCodigoBarras.Name = "txtCodigoBarras";
			this.txtCodigoBarras.Size = new System.Drawing.Size(158, 20);
			this.txtCodigoBarras.TabIndex = 1;
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(75, 3);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(76, 20);
			this.textBox13.TabIndex = 19;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(3, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(45, 13);
			this.label16.TabIndex = 0;
			this.label16.Text = "Utilidad:";
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(157, 3);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(47, 20);
			this.textBox14.TabIndex = 20;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(3, 18);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(62, 13);
			this.label17.TabIndex = 21;
			this.label17.Text = "Descuento:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(3, 38);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(40, 20);
			this.label18.TabIndex = 22;
			this.label18.Text = "Precio Bruto:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(3, 58);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(27, 13);
			this.label19.TabIndex = 23;
			this.label19.Text = "IVA:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(3, 78);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(40, 20);
			this.label20.TabIndex = 24;
			this.label20.Text = "Precio Venta:";
			// 
			// checkServicio
			// 
			this.checkServicio.AutoSize = true;
			this.checkServicio.Location = new System.Drawing.Point(479, 16);
			this.checkServicio.Name = "checkServicio";
			this.checkServicio.Size = new System.Drawing.Size(64, 17);
			this.checkServicio.TabIndex = 2;
			this.checkServicio.Text = "Servicio";
			this.checkServicio.UseVisualStyleBackColor = true;
			// 
			// checkEstado
			// 
			this.checkEstado.AutoSize = true;
			this.checkEstado.Location = new System.Drawing.Point(552, 16);
			this.checkEstado.Name = "checkEstado";
			this.checkEstado.Size = new System.Drawing.Size(71, 17);
			this.checkEstado.TabIndex = 3;
			this.checkEstado.Text = "Inhabilitar";
			this.checkEstado.UseVisualStyleBackColor = true;
			// 
			// btnCerrar
			// 
			this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(568, 318);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(92, 28);
			this.btnCerrar.TabIndex = 12;
			this.btnCerrar.Text = "&Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(475, 318);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(92, 28);
			this.btnGuardar.TabIndex = 11;
			this.btnGuardar.Text = "&Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// FrmArticulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 374);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.checkEstado);
			this.Controls.Add(this.checkServicio);
			this.Controls.Add(this.txtCodigoBarras);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmArticulo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmArticulo";
			this.Load += new System.EventHandler(this.FormArticulo_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
		private Label label1;
		private Label label2;
		private TextBox txtDescripcion;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private StatusStrip statusStrip1;
		private Label label4;
		private TextBox txtDescripcionCorta;
		private Label label3;
		private Label label6;
		private Label label5;
		private Label label7;
		private TextBox txtCodigoBarras;
		private TextBox txtCosto;
		private Label label8;
		private TabPage tabPage3;
		private TextBox textBox13;
		private Label label16;
		private TextBox textBox14;
		private Label label17;
		private Label label18;
		private Label label19;
		private Label label20;
		private TextBox txtCodigoAlternativo;
		private Label label9;
		private Label label14;
		private Label label13;
		private TextBox txtValorNeto;
		private Label label12;
		private TextBox txtPrecioVenta;
		private Label label22;
		private TextBox txtPrecioVenta1;
		private GroupBox groupBox1;
		private TextBox txtStockDisponible;
		private TextBox txtStockActual;
		private TextBox txtStockMinimo;
		private TextBox txtStockMaximo;
		private TextBox txtCostoPonderado;
		private Label label28;
		private CheckBox checkServicio;
		private GroupBox groupBox2;
		private RadioButton rbExcluido;
		private RadioButton rbExcento;
		private RadioButton rbIVA;
		private CheckBox checkEstado;
		public TextBox txtCodigo;
		private Label label26;
		private Label label25;
		private Label label24;
		private Label label23;
		private ComboBox cbSeccion;
		private ComboBox cbFamilia;
		private ComboBox cbUnidadMedida;
		private TextBox txtCodigoPLU;
		private Label label10;
		private ComboBox cbIVA;
		private TextBox txtValorNeto2;
		private TextBox txtValorNeto1;
		private TextBox txtPrecioVenta2;
		private TextBox txtImpuestoConsumo;
		private Label label30;
		private Label label11;
		private Label label27;
		private Label label21;
		private Label label15;
		private TextBox txtUnidadesArticulo;
		private TextBox txtPartidaArancelaria;
		private Label label29;
		private TextBox txtObservacion;
		private Label label31;
		private Label label32;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private GroupBox groupBox3;
		private RadioButton rbRedondeoInferior;
		private RadioButton rbRedondeoSuperior;
		private RadioButton rbRedondeoSistema;
		private Label label33;
		private Label label34;
		private Label label35;
		private TextBox txtUtilidad2;
		private TextBox txtUtilidad1;
		private TextBox txtUtilidad;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnGuardar;
	}
}
