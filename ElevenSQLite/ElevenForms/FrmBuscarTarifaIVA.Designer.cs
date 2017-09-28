/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarTarifaIVA
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private DataGridView dataGridViewTarifaIVA;
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
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.dataGridViewTarifaIVA = new DataGridView();
			this.bindingSource1 = new BindingSource(this.components);
			this.statusStrip1.SuspendLayout();
			((ISupportInitialize)this.dataGridViewTarifaIVA).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 154);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(441, 22);
			this.statusStrip1.TabIndex = 14;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(185, 17);
			this.toolStripStatusLabel1.Text = "Doble click y/o seleccione y cierre";
			this.dataGridViewTarifaIVA.AllowUserToAddRows = false;
			this.dataGridViewTarifaIVA.AllowUserToDeleteRows = false;
			this.dataGridViewTarifaIVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTarifaIVA.Dock = DockStyle.Fill;
			this.dataGridViewTarifaIVA.Location = new Point(0, 0);
			this.dataGridViewTarifaIVA.Name = "dataGridViewTarifaIVA";
			this.dataGridViewTarifaIVA.ReadOnly = true;
			this.dataGridViewTarifaIVA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewTarifaIVA.Size = new Size(441, 154);
			this.dataGridViewTarifaIVA.TabIndex = 15;
			this.dataGridViewTarifaIVA.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewTarifaIVA_CellDoubleClick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(441, 176);
			base.Controls.Add(this.dataGridViewTarifaIVA);
			base.Controls.Add(this.statusStrip1);
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar Tarifa IVA";
			base.FormClosing += new FormClosingEventHandler(this.FormBuscarTarifaIVA_FormClosing);
			base.Load += new EventHandler(this.FormBuscarTarifaIVA_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((ISupportInitialize)this.dataGridViewTarifaIVA).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
			// 
			// FrmBuscarTarifaIVA
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarTarifaIVA";
			this.Name = "FrmBuscarTarifaIVA";
		}
	}
}
