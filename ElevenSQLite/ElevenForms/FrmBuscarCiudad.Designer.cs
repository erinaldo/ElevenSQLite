/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarCiudad
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
			this.groupBox1 = new GroupBox();
			this.rbTodos = new RadioButton();
			this.rbCiudad = new RadioButton();
			this.txtBusqueda = new TextBox();
			this.btnBuscar = new Button();
			this.dataGridViewCiudad = new DataGridView();
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.bindingSource1 = new BindingSource(this.components);
			this.groupBox1.SuspendLayout();
			((ISupportInitialize)this.dataGridViewCiudad).BeginInit();
			this.statusStrip1.SuspendLayout();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.rbTodos);
			this.groupBox1.Controls.Add(this.rbCiudad);
			this.groupBox1.Controls.Add(this.txtBusqueda);
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Location = new Point(2, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(485, 71);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Busqueda de ciudad";
			this.rbTodos.AutoSize = true;
			this.rbTodos.Checked = true;
			this.rbTodos.Location = new Point(109, 45);
			this.rbTodos.Name = "rbTodos";
			this.rbTodos.Size = new Size(55, 17);
			this.rbTodos.TabIndex = 5;
			this.rbTodos.TabStop = true;
			this.rbTodos.Text = "Todos";
			this.rbTodos.UseVisualStyleBackColor = true;
			this.rbCiudad.AutoSize = true;
			this.rbCiudad.Location = new Point(6, 45);
			this.rbCiudad.Name = "rbCiudad";
			this.rbCiudad.Size = new Size(97, 17);
			this.rbCiudad.TabIndex = 2;
			this.rbCiudad.Text = "Nombre ciudad";
			this.rbCiudad.UseVisualStyleBackColor = true;
			this.txtBusqueda.Location = new Point(6, 19);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new Size(370, 20);
			this.txtBusqueda.TabIndex = 1;
			this.btnBuscar.Location = new Point(394, 19);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new Size(75, 23);
			this.btnBuscar.TabIndex = 0;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new EventHandler(this.btnBuscar_Click);
			this.dataGridViewCiudad.AllowUserToAddRows = false;
			this.dataGridViewCiudad.AllowUserToDeleteRows = false;
			this.dataGridViewCiudad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCiudad.Location = new Point(2, 89);
			this.dataGridViewCiudad.Name = "dataGridViewCiudad";
			this.dataGridViewCiudad.ReadOnly = true;
			this.dataGridViewCiudad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewCiudad.Size = new Size(485, 165);
			this.dataGridViewCiudad.TabIndex = 13;
			this.dataGridViewCiudad.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewCiudad_CellDoubleClick);
			this.dataGridViewCiudad.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewCiudad_CellFormatting);
			this.dataGridViewCiudad.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewCiudad_CellContentClick);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 259);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(492, 22);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(166, 17);
			this.toolStripStatusLabel1.Text = "Doble click y/o seleccione y cierre";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(492, 281);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.dataGridViewCiudad);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar ciudad";
			base.Load += new EventHandler(this.FormBuscarCiudad_Load);
			base.FormClosed += new FormClosedEventHandler(this.FormBuscarCiudad_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((ISupportInitialize)this.dataGridViewCiudad).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
			
			// 
			// FrmBuscarCiudad
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarCiudad";
			this.Name = "FrmBuscarCiudad";
		}
		private GroupBox groupBox1;
		private RadioButton rbTodos;
		private RadioButton rbCiudad;
		private TextBox txtBusqueda;
		private Button btnBuscar;
		private DataGridView dataGridViewCiudad;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private BindingSource bindingSource1;
	}
}
