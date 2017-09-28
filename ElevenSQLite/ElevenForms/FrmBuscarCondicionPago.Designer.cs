/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarCondicionPago
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
			this.dataGridViewCondicionPago = new DataGridView();
			this.bindingSource1 = new BindingSource(this.components);
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			((ISupportInitialize)this.dataGridViewCondicionPago).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.dataGridViewCondicionPago.AllowUserToAddRows = false;
			this.dataGridViewCondicionPago.AllowUserToDeleteRows = false;
			this.dataGridViewCondicionPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCondicionPago.Dock = DockStyle.Fill;
			this.dataGridViewCondicionPago.Location = new Point(0, 0);
			this.dataGridViewCondicionPago.Name = "dataGridViewCondicionPago";
			this.dataGridViewCondicionPago.ReadOnly = true;
			this.dataGridViewCondicionPago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewCondicionPago.Size = new Size(442, 177);
			this.dataGridViewCondicionPago.TabIndex = 12;
			this.dataGridViewCondicionPago.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewCondicionPago_CellDoubleClick);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 155);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(442, 22);
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(166, 17);
			this.toolStripStatusLabel1.Text = "Doble click y/o seleccione y cierre";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(442, 177);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.dataGridViewCondicionPago);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar condicion pago";
			base.Load += new EventHandler(this.FrmBuscarCondicionPago_Load);
			base.FormClosing += new FormClosingEventHandler(this.FrmBuscarCondicionPago_FormClosing);
			((ISupportInitialize)this.dataGridViewCondicionPago).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
			
			// 
			// FrmBuscarCondicionPago
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarCondicionPago";
			this.Name = "FrmBuscarCondicionPago";
		}
		private DataGridView dataGridViewCondicionPago;
		private BindingSource bindingSource1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
	}
}
