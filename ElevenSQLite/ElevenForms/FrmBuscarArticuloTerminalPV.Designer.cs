/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 9:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarArticuloTerminalPV
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
			this.dataGridViewArticulo = new DataGridView();
			this.txtBusqueda = new TextBox();
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.bindingSource1 = new BindingSource(this.components);
			this.groupBox1 = new GroupBox();
			((ISupportInitialize)this.dataGridViewArticulo).BeginInit();
			this.statusStrip1.SuspendLayout();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.dataGridViewArticulo.AllowUserToAddRows = false;
			this.dataGridViewArticulo.AllowUserToDeleteRows = false;
			this.dataGridViewArticulo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewArticulo.Location = new Point(2, 56);
			this.dataGridViewArticulo.Name = "dataGridViewArticulo";
			this.dataGridViewArticulo.ReadOnly = true;
			this.dataGridViewArticulo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewArticulo.Size = new Size(568, 133);
			this.dataGridViewArticulo.TabIndex = 1;
			this.dataGridViewArticulo.KeyUp += new KeyEventHandler(this.dataGridViewArticulo_KeyUp);
			this.txtBusqueda.Location = new Point(6, 19);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new Size(453, 20);
			this.txtBusqueda.TabIndex = 0;
			this.txtBusqueda.TextChanged += new EventHandler(this.txtBusqueda_TextChanged);
			this.txtBusqueda.KeyDown += new KeyEventHandler(this.txtBusqueda_KeyDown);
			this.txtBusqueda.KeyUp += new KeyEventHandler(this.txtBusqueda_KeyUp);
			this.txtBusqueda.KeyPress += new KeyPressEventHandler(this.txtCampo_KeyPress);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 191);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(582, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(465, 17);
			this.toolStripStatusLabel1.Text = "ESC: Para salir  ENTER: para seleccionar el articulo  TAB y TECLAS: para seleccionar un articulo.";
			this.groupBox1.Controls.Add(this.txtBusqueda);
			this.groupBox1.Location = new Point(2, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(568, 47);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Busqueda de articulos";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(582, 213);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.dataGridViewArticulo);
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar Articulo";
			base.Load += new EventHandler(this.FormBuscarArticuloTerminalPV_Load);
			base.FormClosed += new FormClosedEventHandler(this.FormBuscarArticuloTerminalPV_FormClosed);
			((ISupportInitialize)this.dataGridViewArticulo).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((ISupportInitialize)this.bindingSource1).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
			
			// 
			// FrmBuscarArticuloTerminalPV
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarArticuloTerminalPV";
			this.Name = "FrmBuscarArticuloTerminalPV";
		}
		
		private DataGridView dataGridViewArticulo;
		private TextBox txtBusqueda;
		private StatusStrip statusStrip1;
		private BindingSource bindingSource1;
		private GroupBox groupBox1;
		private ToolStripStatusLabel toolStripStatusLabel1;
	}
}
