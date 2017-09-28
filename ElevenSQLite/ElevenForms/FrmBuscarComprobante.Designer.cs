/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarComprobante
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
			this.dataGridViewComprobante = new DataGridView();
			this.bindingSource1 = new BindingSource(this.components);
			this.groupBox1 = new GroupBox();
			this.rbTodos = new RadioButton();
			this.rbTercero = new RadioButton();
			this.txtBusqueda = new TextBox();
			this.btnBuscar = new Button();
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			((ISupportInitialize)this.dataGridViewComprobante).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.dataGridViewComprobante.AllowUserToAddRows = false;
			this.dataGridViewComprobante.AllowUserToDeleteRows = false;
			this.dataGridViewComprobante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewComprobante.Location = new Point(1, 80);
			this.dataGridViewComprobante.Name = "dataGridViewComprobante";
			this.dataGridViewComprobante.ReadOnly = true;
			this.dataGridViewComprobante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewComprobante.Size = new Size(634, 165);
			this.dataGridViewComprobante.TabIndex = 12;
			this.dataGridViewComprobante.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewComprobante_CellDoubleClick);
			this.dataGridViewComprobante.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewComprobante_CellFormatting);
			this.groupBox1.Controls.Add(this.rbTodos);
			this.groupBox1.Controls.Add(this.rbTercero);
			this.groupBox1.Controls.Add(this.txtBusqueda);
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Location = new Point(1, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(634, 71);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Busqueda de comprobante";
			this.rbTodos.AutoSize = true;
			this.rbTodos.Location = new Point(77, 45);
			this.rbTodos.Name = "rbTodos";
			this.rbTodos.Size = new Size(132, 17);
			this.rbTodos.TabIndex = 3;
			this.rbTodos.Text = "Todos los documentos";
			this.rbTodos.UseVisualStyleBackColor = true;
			this.rbTodos.CheckedChanged += new EventHandler(this.rbTodos_CheckedChanged);
			this.rbTercero.AutoSize = true;
			this.rbTercero.Checked = true;
			this.rbTercero.Location = new Point(9, 45);
			this.rbTercero.Name = "rbTercero";
			this.rbTercero.Size = new Size(62, 17);
			this.rbTercero.TabIndex = 2;
			this.rbTercero.TabStop = true;
			this.rbTercero.Text = "Tercero";
			this.rbTercero.UseVisualStyleBackColor = true;
			this.rbTercero.CheckedChanged += new EventHandler(this.rbTercero_CheckedChanged);
			this.txtBusqueda.Location = new Point(6, 19);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new Size(495, 20);
			this.txtBusqueda.TabIndex = 1;
			this.btnBuscar.Location = new Point(528, 19);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new Size(75, 23);
			this.btnBuscar.TabIndex = 0;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new EventHandler(this.btnBuscar_Click);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 248);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(639, 22);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(166, 17);
			this.toolStripStatusLabel1.Text = "Doble click y/o seleccione y cierre";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(639, 270);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.dataGridViewComprobante);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar comprobante";
			base.Load += new EventHandler(this.FormBuscarComprobante_Load);
			
			((ISupportInitialize)this.dataGridViewComprobante).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
			// 
			// FrmBuscarComprobante
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarComprobante";
			this.Name = "FrmBuscarComprobante";
		}
		
		private DataGridView dataGridViewComprobante;
		private BindingSource bindingSource1;
		private GroupBox groupBox1;
		private RadioButton rbTodos;
		private RadioButton rbTercero;
		private TextBox txtBusqueda;
		private Button btnBuscar;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
	}
}
