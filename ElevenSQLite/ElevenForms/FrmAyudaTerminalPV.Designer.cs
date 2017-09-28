/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 15:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmAyudaTerminalPV
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private DataGridView dataGridViewAyuda;
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
			this.dataGridViewAyuda = new DataGridView();
			this.bindingSource1 = new BindingSource(this.components);
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			((ISupportInitialize)this.dataGridViewAyuda).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.dataGridViewAyuda.AllowUserToAddRows = false;
			this.dataGridViewAyuda.AllowUserToDeleteRows = false;
			this.dataGridViewAyuda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAyuda.Dock = DockStyle.Fill;
			this.dataGridViewAyuda.Location = new Point(0, 0);
			this.dataGridViewAyuda.Name = "dataGridViewAyuda";
			this.dataGridViewAyuda.ReadOnly = true;
			this.dataGridViewAyuda.Size = new Size(340, 266);
			this.dataGridViewAyuda.TabIndex = 0;
			this.dataGridViewAyuda.KeyDown += new KeyEventHandler(this.dataGridViewAyuda_KeyDown);
			this.dataGridViewAyuda.KeyPress += new KeyPressEventHandler(this.dataGridViewAyuda_KeyPress);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 244);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(340, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(108, 17);
			this.toolStripStatusLabel1.Text = "Utilice ESC para salir.";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(340, 266);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.dataGridViewAyuda);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormAyudaTerminalPV";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Ayuda TerminalPV";
			base.Load += new EventHandler(this.FormAyudaTerminalPV_Load);
			((ISupportInitialize)this.dataGridViewAyuda).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
			
			// 
			// FrmAyudaTerminalPV
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmAyudaTerminalPV";
			this.Name = "FrmAyudaTerminalPV";
		}
	}
}
