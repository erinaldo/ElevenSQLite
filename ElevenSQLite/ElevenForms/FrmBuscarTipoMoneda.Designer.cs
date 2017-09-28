/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarTipoMoneda
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private DataGridView dataGridViewTipoMoneda;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private BindingSource bindingSource1;
		
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
			this.dataGridViewTipoMoneda = new DataGridView();
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.bindingSource1 = new BindingSource(this.components);
			((ISupportInitialize)this.dataGridViewTipoMoneda).BeginInit();
			this.statusStrip1.SuspendLayout();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.dataGridViewTipoMoneda.AllowUserToAddRows = false;
			this.dataGridViewTipoMoneda.AllowUserToDeleteRows = false;
			this.dataGridViewTipoMoneda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTipoMoneda.Dock = DockStyle.Fill;
			this.dataGridViewTipoMoneda.Location = new Point(0, 0);
			this.dataGridViewTipoMoneda.Name = "dataGridViewTipoMoneda";
			this.dataGridViewTipoMoneda.ReadOnly = true;
			this.dataGridViewTipoMoneda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewTipoMoneda.Size = new Size(367, 134);
			this.dataGridViewTipoMoneda.TabIndex = 16;
			this.dataGridViewTipoMoneda.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewTipoMoneda_CellDoubleClick);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 112);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(367, 22);
			this.statusStrip1.TabIndex = 18;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(160, 17);
			this.toolStripStatusLabel1.Text = "Doble click ó seleccione y cierre.";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(367, 134);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.dataGridViewTipoMoneda);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar TipoMoneda";
			base.Load += new EventHandler(this.FormBuscarTipoMoneda_Load);
			base.FormClosed += new FormClosedEventHandler(this.FormBuscarTipoMoneda_FormClosed);
			((ISupportInitialize)this.dataGridViewTipoMoneda).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
			// 
			// FormBuscarTipoMoneda
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FormBuscarTipoMoneda";
			this.Name = "FormBuscarTipoMoneda";
		}
	}
}
