/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 15:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarTipoDocumento
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private DataGridView dataGridViewTipoDocumento;
		private BindingSource bindingSource1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		
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
			this.dataGridViewTipoDocumento = new System.Windows.Forms.DataGridView();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoDocumento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewTipoDocumento
			// 
			this.dataGridViewTipoDocumento.AllowUserToAddRows = false;
			this.dataGridViewTipoDocumento.AllowUserToDeleteRows = false;
			this.dataGridViewTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTipoDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewTipoDocumento.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewTipoDocumento.Name = "dataGridViewTipoDocumento";
			this.dataGridViewTipoDocumento.ReadOnly = true;
			this.dataGridViewTipoDocumento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewTipoDocumento.Size = new System.Drawing.Size(441, 177);
			this.dataGridViewTipoDocumento.TabIndex = 12;
			this.dataGridViewTipoDocumento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipoDocumento_CellDoubleClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 155);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(441, 22);
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(185, 17);
			this.toolStripStatusLabel1.Text = "Doble click y/o seleccione y cierre";
			// 
			// FrmBuscarTipoDocumento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 177);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.dataGridViewTipoDocumento);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmBuscarTipoDocumento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buscar Tipo de Documento";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBuscarTipoDocumento_FormClosing);
			this.Load += new System.EventHandler(this.FormBuscarTipoDocumento_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoDocumento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
