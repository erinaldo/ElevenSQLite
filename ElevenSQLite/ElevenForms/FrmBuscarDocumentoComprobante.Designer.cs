/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:03
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
	partial class FrmBuscarDocumentoComprobante
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
			this.components = new Container();
			this.dataGridViewDocumentos = new DataGridView();
			this.bindingSource1 = new BindingSource(this.components);
			this.button1 = new Button();
			((ISupportInitialize)this.dataGridViewDocumentos).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.dataGridViewDocumentos.AllowUserToAddRows = false;
			this.dataGridViewDocumentos.AllowUserToDeleteRows = false;
			this.dataGridViewDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDocumentos.Location = new Point(4, 4);
			this.dataGridViewDocumentos.MultiSelect = false;
			this.dataGridViewDocumentos.Name = "dataGridViewDocumentos";
			this.dataGridViewDocumentos.ReadOnly = true;
			this.dataGridViewDocumentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewDocumentos.Size = new Size(384, 321);
			this.dataGridViewDocumentos.TabIndex = 0;
			this.dataGridViewDocumentos.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewDocumentos_CellDoubleClick);
			this.dataGridViewDocumentos.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewDocumentos_CellFormatting);
			this.button1.Location = new Point(4, 331);
			this.button1.Name = "button1";
			this.button1.Size = new Size(113, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Limpiar documento";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(392, 366);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.dataGridViewDocumentos);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar documento";
			base.Load += new EventHandler(this.FormBuscarDocumentoComprobante_Load);
			
			((ISupportInitialize)this.dataGridViewDocumentos).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
			// 
			// FrmBuscarDocumentoComprobante
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarDocumentoComprobante";
			this.Name = "FrmBuscarDocumentoComprobante";
		}
		private DataGridView dataGridViewDocumentos;
		private BindingSource bindingSource1;
		private Button button1;
	}
}
