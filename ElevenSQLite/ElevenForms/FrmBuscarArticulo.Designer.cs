/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 9/09/2017
 * Hora: 1:47 p. m.
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
	partial class FrmBuscarArticulo
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
			this.groupBox1 = new GroupBox();
			this.rbCodigo = new RadioButton();
			this.rbDescripcion = new RadioButton();
			this.txtBusqueda = new TextBox();
			this.btnBuscar = new Button();
			this.bindingSource1 = new BindingSource(this.components);
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			((ISupportInitialize)this.dataGridViewArticulo).BeginInit();
			this.groupBox1.SuspendLayout();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.dataGridViewArticulo.AllowUserToAddRows = false;
			this.dataGridViewArticulo.AllowUserToDeleteRows = false;
			this.dataGridViewArticulo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewArticulo.Location = new Point(9, 89);
			this.dataGridViewArticulo.Name = "dataGridViewArticulo";
			this.dataGridViewArticulo.ReadOnly = true;
			this.dataGridViewArticulo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewArticulo.Size = new Size(668, 165);
			this.dataGridViewArticulo.TabIndex = 7;
			this.dataGridViewArticulo.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewTerceros_CellDoubleClick);
			this.dataGridViewArticulo.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewArticulo_CellFormatting);
			this.groupBox1.Controls.Add(this.rbCodigo);
			this.groupBox1.Controls.Add(this.rbDescripcion);
			this.groupBox1.Controls.Add(this.txtBusqueda);
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Location = new Point(9, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(668, 71);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Busqueda de articulos";
			this.rbCodigo.AutoSize = true;
			this.rbCodigo.Location = new Point(9, 45);
			this.rbCodigo.Name = "rbCodigo";
			this.rbCodigo.Size = new Size(58, 17);
			this.rbCodigo.TabIndex = 3;
			this.rbCodigo.Text = "Codigo";
			this.rbCodigo.UseVisualStyleBackColor = true;
			this.rbDescripcion.AutoSize = true;
			this.rbDescripcion.Checked = true;
			this.rbDescripcion.Location = new Point(73, 45);
			this.rbDescripcion.Name = "rbDescripcion";
			this.rbDescripcion.Size = new Size(81, 17);
			this.rbDescripcion.TabIndex = 2;
			this.rbDescripcion.TabStop = true;
			this.rbDescripcion.Text = "Descripción";
			this.rbDescripcion.UseVisualStyleBackColor = true;
			this.txtBusqueda.Location = new Point(6, 19);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new Size(575, 20);
			this.txtBusqueda.TabIndex = 1;
			this.btnBuscar.Location = new Point(587, 19);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new Size(75, 23);
			this.btnBuscar.TabIndex = 0;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new EventHandler(this.btnBuscar_Click);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 257);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(689, 22);
			this.statusStrip1.TabIndex = 10;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(185, 17);
			this.toolStripStatusLabel1.Text = "Doble click y/o seleccione y cierre";
			base.ClientSize = new Size(689, 279);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.dataGridViewArticulo);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;			
			base.StartPosition = FormStartPosition.CenterScreen;
			base.FormClosing += new FormClosingEventHandler(this.FormBuscarArticulo_FormClosing);
			base.Load += new EventHandler(this.FormBuscarArticulo_Load);
			((ISupportInitialize)this.dataGridViewArticulo).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((ISupportInitialize)this.bindingSource1).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
			// 
			// FrmBuscarArticulo
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarArticulo";
			this.Name = "FrmBuscarArticulo";
		}
		
		private DataGridView dataGridViewArticulo;
		private GroupBox groupBox1;
		private RadioButton rbCodigo;
		private RadioButton rbDescripcion;
		private TextBox txtBusqueda;
		private Button btnBuscar;
		private BindingSource bindingSource1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
	}
}
