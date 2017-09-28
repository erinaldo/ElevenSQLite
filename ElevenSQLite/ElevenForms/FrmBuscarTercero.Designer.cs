/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 5:25 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarTercero
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
			this.components = new System.ComponentModel.Container();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.dataGridViewTerceros = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbUltimosDocumento = new System.Windows.Forms.RadioButton();
			this.rbUltimosModificados = new System.Windows.Forms.RadioButton();
			this.rbNit = new System.Windows.Forms.RadioButton();
			this.rbCodigo = new System.Windows.Forms.RadioButton();
			this.rbNombreComercial = new System.Windows.Forms.RadioButton();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerceros)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(468, 19);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 0;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(6, 19);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(459, 20);
			this.txtBusqueda.TabIndex = 1;
			// 
			// dataGridViewTerceros
			// 
			this.dataGridViewTerceros.AllowUserToAddRows = false;
			this.dataGridViewTerceros.AllowUserToDeleteRows = false;
			this.dataGridViewTerceros.AllowUserToOrderColumns = true;
			this.dataGridViewTerceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTerceros.Location = new System.Drawing.Point(3, 78);
			this.dataGridViewTerceros.Name = "dataGridViewTerceros";
			this.dataGridViewTerceros.ReadOnly = true;
			this.dataGridViewTerceros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewTerceros.Size = new System.Drawing.Size(549, 165);
			this.dataGridViewTerceros.TabIndex = 2;
			this.dataGridViewTerceros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTerceros_CellDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbUltimosDocumento);
			this.groupBox1.Controls.Add(this.rbUltimosModificados);
			this.groupBox1.Controls.Add(this.rbNit);
			this.groupBox1.Controls.Add(this.rbCodigo);
			this.groupBox1.Controls.Add(this.rbNombreComercial);
			this.groupBox1.Controls.Add(this.txtBusqueda);
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Location = new System.Drawing.Point(3, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(549, 71);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Busqueda de terceros";
			// 
			// rbUltimosDocumento
			// 
			this.rbUltimosDocumento.AutoSize = true;
			this.rbUltimosDocumento.Location = new System.Drawing.Point(137, 48);
			this.rbUltimosDocumento.Name = "rbUltimosDocumento";
			this.rbUltimosDocumento.Size = new System.Drawing.Size(115, 17);
			this.rbUltimosDocumento.TabIndex = 6;
			this.rbUltimosDocumento.Text = "Ultimos documento";
			this.rbUltimosDocumento.UseVisualStyleBackColor = true;
			this.rbUltimosDocumento.CheckedChanged += new System.EventHandler(this.rbUltimosFacturados_CheckedChanged);
			// 
			// rbUltimosModificados
			// 
			this.rbUltimosModificados.AutoSize = true;
			this.rbUltimosModificados.Checked = true;
			this.rbUltimosModificados.Location = new System.Drawing.Point(9, 48);
			this.rbUltimosModificados.Name = "rbUltimosModificados";
			this.rbUltimosModificados.Size = new System.Drawing.Size(118, 17);
			this.rbUltimosModificados.TabIndex = 5;
			this.rbUltimosModificados.TabStop = true;
			this.rbUltimosModificados.Text = "Ultimos modificados";
			this.rbUltimosModificados.UseVisualStyleBackColor = true;
			this.rbUltimosModificados.CheckedChanged += new System.EventHandler(this.rbUltimos_CheckedChanged);
			// 
			// rbNit
			// 
			this.rbNit.AutoSize = true;
			this.rbNit.Location = new System.Drawing.Point(447, 48);
			this.rbNit.Name = "rbNit";
			this.rbNit.Size = new System.Drawing.Size(49, 17);
			this.rbNit.TabIndex = 4;
			this.rbNit.Text = "N.I.T";
			this.rbNit.UseVisualStyleBackColor = true;
			// 
			// rbCodigo
			// 
			this.rbCodigo.AutoSize = true;
			this.rbCodigo.Location = new System.Drawing.Point(259, 48);
			this.rbCodigo.Name = "rbCodigo";
			this.rbCodigo.Size = new System.Drawing.Size(58, 17);
			this.rbCodigo.TabIndex = 3;
			this.rbCodigo.Text = "Codigo";
			this.rbCodigo.UseVisualStyleBackColor = true;
			
			// 
			// rbNombreComercial
			// 
			this.rbNombreComercial.AutoSize = true;
			this.rbNombreComercial.Location = new System.Drawing.Point(327, 48);
			this.rbNombreComercial.Name = "rbNombreComercial";
			this.rbNombreComercial.Size = new System.Drawing.Size(110, 17);
			this.rbNombreComercial.TabIndex = 2;
			this.rbNombreComercial.Text = "Nombre comercial";
			this.rbNombreComercial.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 250);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Doble click y/o seleccione y cierre";
			// 
			// FrmBuscarTercero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 266);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridViewTerceros);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmBuscarTercero";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buscar Tercero";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBuscarTercero_FormClosing);
			this.Load += new System.EventHandler(this.FormBuscarTercero_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerceros)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
		private Button btnBuscar;
		private TextBox txtBusqueda;
		private DataGridView dataGridViewTerceros;
		private GroupBox groupBox1;
		private RadioButton rbNit;
		private RadioButton rbCodigo;
		private RadioButton rbNombreComercial;
		private BindingSource bindingSource1;
		private Label label1;
		private RadioButton rbUltimosModificados;
		private RadioButton rbUltimosDocumento;
	}
}
