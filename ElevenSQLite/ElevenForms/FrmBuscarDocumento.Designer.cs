/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmBuscarDocumento
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
			this.rbUltimos = new RadioButton();
			this.rbConsecutivo = new RadioButton();
			this.rbTercero = new RadioButton();
			this.txtBusqueda = new TextBox();
			this.btnBuscar = new Button();
			this.dataGridViewDocumento = new DataGridView();
			this.bindingSource1 = new BindingSource(this.components);
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.groupBox1.SuspendLayout();
			((ISupportInitialize)this.dataGridViewDocumento).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.rbTodos);
			this.groupBox1.Controls.Add(this.rbUltimos);
			this.groupBox1.Controls.Add(this.rbConsecutivo);
			this.groupBox1.Controls.Add(this.rbTercero);
			this.groupBox1.Controls.Add(this.txtBusqueda);
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Location = new Point(9, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(653, 71);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Busqueda de documento";
			this.rbTodos.AutoSize = true;
			this.rbTodos.Location = new Point(374, 45);
			this.rbTodos.Name = "rbTodos";
			this.rbTodos.Size = new Size(55, 17);
			this.rbTodos.TabIndex = 5;
			this.rbTodos.Text = "Todos";
			this.rbTodos.UseVisualStyleBackColor = true;
			this.rbTodos.CheckedChanged += new EventHandler(this.rbTodos_CheckedChanged);
			this.rbUltimos.AutoSize = true;
			this.rbUltimos.Checked = true;
			this.rbUltimos.Location = new Point(6, 45);
			this.rbUltimos.Name = "rbUltimos";
			this.rbUltimos.Size = new Size(120, 17);
			this.rbUltimos.TabIndex = 4;
			this.rbUltimos.TabStop = true;
			this.rbUltimos.Text = "Ultimos documentos";
			this.rbUltimos.UseVisualStyleBackColor = true;
			this.rbUltimos.CheckedChanged += new EventHandler(this.rbUltimos_CheckedChanged);
			this.rbConsecutivo.AutoSize = true;
			this.rbConsecutivo.Location = new Point(284, 45);
			this.rbConsecutivo.Name = "rbConsecutivo";
			this.rbConsecutivo.Size = new Size(84, 17);
			this.rbConsecutivo.TabIndex = 3;
			this.rbConsecutivo.Text = "Consecutivo";
			this.rbConsecutivo.UseVisualStyleBackColor = true;
			this.rbConsecutivo.CheckedChanged += new EventHandler(this.rbConsecutivo_CheckedChanged);
			this.rbTercero.AutoSize = true;
			this.rbTercero.Location = new Point(132, 45);
			this.rbTercero.Name = "rbTercero";
			this.rbTercero.Size = new Size(146, 17);
			this.rbTercero.TabIndex = 2;
			this.rbTercero.Text = "Nombre comercial tercero";
			this.rbTercero.UseVisualStyleBackColor = true;
			this.rbTercero.CheckedChanged += new EventHandler(this.rbTercero_CheckedChanged);
			this.txtBusqueda.Location = new Point(6, 19);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new Size(556, 20);
			this.txtBusqueda.TabIndex = 1;
			this.btnBuscar.Location = new Point(568, 17);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new Size(75, 23);
			this.btnBuscar.TabIndex = 0;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new EventHandler(this.btnBuscar_Click);
			this.dataGridViewDocumento.AllowUserToAddRows = false;
			this.dataGridViewDocumento.AllowUserToDeleteRows = false;
			this.dataGridViewDocumento.AllowUserToOrderColumns = true;
			this.dataGridViewDocumento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDocumento.Location = new Point(9, 79);
			this.dataGridViewDocumento.Name = "dataGridViewDocumento";
			this.dataGridViewDocumento.ReadOnly = true;
			this.dataGridViewDocumento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewDocumento.Size = new Size(653, 165);
			this.dataGridViewDocumento.TabIndex = 10;
			this.dataGridViewDocumento.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewDocumento_CellContentClick);
			this.dataGridViewDocumento.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewDocumento_CellDoubleClick);
			this.dataGridViewDocumento.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewDocumento_CellFormatting);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] {
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new Point(0, 247);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(674, 22);
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(185, 17);
			this.toolStripStatusLabel1.Text = "Doble click y/o seleccione y cierre";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(674, 269);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.dataGridViewDocumento);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buscar documento";
			base.FormClosing += new FormClosingEventHandler(this.FormBuscarDocumento_FormClosing);
			base.Load += new EventHandler(this.FormBuscarDocumento_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((ISupportInitialize)this.dataGridViewDocumento).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
			// 
			// FrmBuscarDocumento
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmBuscarDocumento";
			this.Name = "FrmBuscarDocumento";
		}
		
		private GroupBox groupBox1;
		private RadioButton rbTercero;
		private TextBox txtBusqueda;
		private Button btnBuscar;
		private DataGridView dataGridViewDocumento;
		private BindingSource bindingSource1;
		private RadioButton rbConsecutivo;
		private RadioButton rbUltimos;
		private RadioButton rbTodos;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
	}
}
