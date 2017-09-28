/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarFamilia
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
			this.dataGridViewFamilia = new DataGridView();
			this.bindingSource1 = new BindingSource(this.components);
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			((ISupportInitialize)this.dataGridViewFamilia).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.dataGridViewFamilia.AllowUserToAddRows = false;
			this.dataGridViewFamilia.AllowUserToDeleteRows = false;
			this.dataGridViewFamilia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFamilia.Location = new Point(3, 2);
			this.dataGridViewFamilia.Name = "dataGridViewFamilia";
			this.dataGridViewFamilia.ReadOnly = true;
			this.dataGridViewFamilia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewFamilia.Size = new Size(436, 154);
			this.dataGridViewFamilia.TabIndex = 10;
			this.dataGridViewFamilia.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewFamilia_CellDoubleClick);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 158);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(442, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(166, 17);
			this.toolStripStatusLabel1.Text = "Doble click y/o seleccione y cierre";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(442, 180);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.dataGridViewFamilia);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar familia";
			base.Load += new EventHandler(this.FrmBuscarFamilia_Load);
			base.FormClosing += new FormClosingEventHandler(this.FrmBuscarFamilia_FormClosing);
			((ISupportInitialize)this.dataGridViewFamilia).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
			
			// 
			// FrmBuscarFamilia
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarFamilia";
			this.Name = "FrmBuscarFamilia";
		}
		private DataGridView dataGridViewFamilia;
		private BindingSource bindingSource1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
	}
}
