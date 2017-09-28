/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarUnidadComercial
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private DataGridView dataGridViewUnidadComercial;
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
			this.components = new Container();
			this.dataGridViewUnidadComercial = new DataGridView();
			this.bindingSource1 = new BindingSource(this.components);
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			((ISupportInitialize)this.dataGridViewUnidadComercial).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.dataGridViewUnidadComercial.AllowUserToAddRows = false;
			this.dataGridViewUnidadComercial.AllowUserToDeleteRows = false;
			this.dataGridViewUnidadComercial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUnidadComercial.Dock = DockStyle.Fill;
			this.dataGridViewUnidadComercial.Location = new Point(0, 0);
			this.dataGridViewUnidadComercial.Name = "dataGridViewUnidadComercial";
			this.dataGridViewUnidadComercial.ReadOnly = true;
			this.dataGridViewUnidadComercial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewUnidadComercial.Size = new Size(535, 176);
			this.dataGridViewUnidadComercial.TabIndex = 14;
			this.dataGridViewUnidadComercial.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewUnidadComercial_CellDoubleClick);
			this.dataGridViewUnidadComercial.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewUnidadComercial_CellContentClick);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 154);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(535, 22);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(166, 17);
			this.toolStripStatusLabel1.Text = "Doble click y/o seleccione y cierre";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(535, 176);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.dataGridViewUnidadComercial);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar unidad comercial";
			base.Load += new EventHandler(this.FormBuscarUnidadComercial_Load);
			base.FormClosing += new FormClosingEventHandler(this.FormBuscarUnidadComercial_FormClosing);
			((ISupportInitialize)this.dataGridViewUnidadComercial).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
			
			// 
			// FrmBuscarUnidadComercial
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarUnidadComercial";
			this.Name = "FrmBuscarUnidadComercial";
		}
	}
}
