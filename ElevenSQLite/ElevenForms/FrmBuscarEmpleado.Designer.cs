/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarEmpleado
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
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.dataGridViewEmpleado = new DataGridView();
			this.bindingSource1 = new BindingSource(this.components);
			this.statusStrip1.SuspendLayout();
			((ISupportInitialize)this.dataGridViewEmpleado).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 157);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(441, 22);
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(185, 17);
			this.toolStripStatusLabel1.Text = "Doble click y/o seleccione y cierre";
			this.dataGridViewEmpleado.AllowUserToAddRows = false;
			this.dataGridViewEmpleado.AllowUserToDeleteRows = false;
			this.dataGridViewEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmpleado.Location = new Point(3, 1);
			this.dataGridViewEmpleado.Name = "dataGridViewEmpleado";
			this.dataGridViewEmpleado.ReadOnly = true;
			this.dataGridViewEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewEmpleado.Size = new Size(436, 154);
			this.dataGridViewEmpleado.TabIndex = 12;
			this.dataGridViewEmpleado.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewEmpleado_CellDoubleClick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(441, 179);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.dataGridViewEmpleado);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar Empleado";
			base.Load += new EventHandler(this.FormBuscarEmpleado_Load);
			base.FormClosing += new FormClosingEventHandler(this.FormBuscarEmpleado_FormClosing);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((ISupportInitialize)this.dataGridViewEmpleado).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
			// 
			// FrmBuscarEmpleado
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarEmpleado";
			this.Name = "FrmBuscarEmpleado";
		}
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private DataGridView dataGridViewEmpleado;
		private BindingSource bindingSource1;
	}
}
