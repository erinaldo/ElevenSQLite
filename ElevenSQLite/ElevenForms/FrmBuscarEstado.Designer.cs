/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarEstado
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
			this.dataGridViewEstado = new DataGridView();
			this.statusStrip1 = new StatusStrip();
			this.bindingSource1 = new BindingSource(this.components);
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			((ISupportInitialize)this.dataGridViewEstado).BeginInit();
			this.statusStrip1.SuspendLayout();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.dataGridViewEstado.AllowUserToAddRows = false;
			this.dataGridViewEstado.AllowUserToDeleteRows = false;
			this.dataGridViewEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEstado.Dock = DockStyle.Fill;
			this.dataGridViewEstado.Location = new Point(0, 0);
			this.dataGridViewEstado.Name = "dataGridViewEstado";
			this.dataGridViewEstado.ReadOnly = true;
			this.dataGridViewEstado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewEstado.Size = new Size(337, 208);
			this.dataGridViewEstado.TabIndex = 13;
			this.dataGridViewEstado.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewEstado_CellDoubleClick);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 186);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(337, 22);
			this.statusStrip1.TabIndex = 14;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(152, 17);
			this.toolStripStatusLabel1.Text = "Docle click para seleccionar";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(337, 208);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.dataGridViewEstado);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar Estado";
			base.FormClosed += new FormClosedEventHandler(this.FrmBuscarEstado_FormClosed);
			base.Load += new EventHandler(this.FrmBuscarEstado_Load);
			((ISupportInitialize)this.dataGridViewEstado).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
			
			// 
			// FrmBuscarEstado
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarEstado";
			this.Name = "FrmBuscarEstado";
		}
		
		private DataGridView dataGridViewEstado;
		private StatusStrip statusStrip1;
		private BindingSource bindingSource1;
		private ToolStripStatusLabel toolStripStatusLabel1;
	}
}
