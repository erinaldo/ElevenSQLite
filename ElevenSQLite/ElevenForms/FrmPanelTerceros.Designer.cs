/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 9/09/2017
 * Hora: 12:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ElevenSQLite.ElevenForms
{
	partial class FrmPanelTerceros
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripComboBox cboBuscarPor;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripButton btnBuscar;
		private System.Windows.Forms.ToolStripButton btnNuevo;
		private System.Windows.Forms.ToolStripButton btnModificar;
		private System.Windows.Forms.ToolStripButton btnEliminar;
		private System.Windows.Forms.ToolStripButton btnCerrar;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dgvTerceros;
		private System.Windows.Forms.DataGridView dataGridView2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPanelTerceros));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.cboBuscarPor = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.btnBuscar = new System.Windows.Forms.ToolStripButton();
			this.btnNuevo = new System.Windows.Forms.ToolStripButton();
			this.btnModificar = new System.Windows.Forms.ToolStripButton();
			this.btnEliminar = new System.Windows.Forms.ToolStripButton();
			this.btnCerrar = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dgvTerceros = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTerceros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripLabel1,
			this.cboBuscarPor,
			this.toolStripTextBox1,
			this.btnBuscar,
			this.btnNuevo,
			this.btnModificar,
			this.btnEliminar,
			this.btnCerrar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(834, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
			this.toolStripLabel1.Text = "Buscar:";
			// 
			// cboBuscarPor
			// 
			this.cboBuscarPor.Name = "cboBuscarPor";
			this.cboBuscarPor.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(300, 25);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(62, 22);
			this.btnBuscar.Text = "Buscar";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(62, 22);
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(78, 22);
			this.btnModificar.Text = "Modificar";
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(70, 22);
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(59, 22);
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dgvTerceros);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
			this.splitContainer1.Size = new System.Drawing.Size(834, 236);
			this.splitContainer1.SplitterDistance = 206;
			this.splitContainer1.TabIndex = 2;
			// 
			// dgvTerceros
			// 
			this.dgvTerceros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvTerceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTerceros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTerceros.Location = new System.Drawing.Point(0, 0);
			this.dgvTerceros.MultiSelect = false;
			this.dgvTerceros.Name = "dgvTerceros";
			this.dgvTerceros.ReadOnly = true;
			this.dgvTerceros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTerceros.Size = new System.Drawing.Size(834, 206);
			this.dgvTerceros.TabIndex = 0;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(0, 0);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(834, 26);
			this.dataGridView2.TabIndex = 0;
			// 
			// FrmPanelTerceros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 261);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "FrmPanelTerceros";
			this.Text = "Listado de Terceros";
			this.Load += new System.EventHandler(this.FrmPanelTercerosLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTerceros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
