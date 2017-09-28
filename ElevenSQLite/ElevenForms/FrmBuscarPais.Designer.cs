/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 13:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarPais
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
			this.dataGridViewPais = new DataGridView();
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.bindingSource1 = new BindingSource(this.components);
			((ISupportInitialize)this.dataGridViewPais).BeginInit();
			this.statusStrip1.SuspendLayout();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.dataGridViewPais.AllowUserToAddRows = false;
			this.dataGridViewPais.AllowUserToDeleteRows = false;
			this.dataGridViewPais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPais.Dock = DockStyle.Fill;
			this.dataGridViewPais.Location = new Point(0, 0);
			this.dataGridViewPais.Name = "dataGridViewPais";
			this.dataGridViewPais.ReadOnly = true;
			this.dataGridViewPais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPais.Size = new Size(310, 221);
			this.dataGridViewPais.TabIndex = 14;
			this.dataGridViewPais.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewPais_CellDoubleClick);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 199);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(310, 22);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(152, 17);
			this.toolStripStatusLabel1.Text = "Docle click para seleccionar";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(310, 221);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.dataGridViewPais);
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar Pais";
			base.FormClosed += new FormClosedEventHandler(this.FormBuscarPais_FormClosed);
			base.Load += new EventHandler(this.FormBuscarPais_Load);
			((ISupportInitialize)this.dataGridViewPais).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
			
			// 
			// FrmBuscarPais
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarPais";
			this.Name = "FrmBuscarPais";
		}
		private DataGridView dataGridViewPais;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private BindingSource bindingSource1;
	}
}
