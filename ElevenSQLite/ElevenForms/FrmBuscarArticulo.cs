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
using ElevenSQLite.ElevenCore;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmBuscarArticulo.
	/// </summary>
	public partial class FrmBuscarArticulo : Form
	{
		public Articulo Articulo {set; get;}
		
		public FrmBuscarArticulo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarArticulo_Load(object sender, EventArgs e)
		{
			this.LlenarArticulos();
			this.txtBusqueda.Focus();
		}

		private void LlenarArticulos()
		{
			this.dataGridViewArticulo.AutoGenerateColumns = false;
			int index = this.dataGridViewArticulo.Columns.Add("Codigo", "Codigo");
			this.dataGridViewArticulo.Columns[index].DataPropertyName = "Codigo";
			this.dataGridViewArticulo.Columns[index].Width = 70;
			index = this.dataGridViewArticulo.Columns.Add("Descripcion", "Descripcion");
			this.dataGridViewArticulo.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewArticulo.Columns[index].Width = 250;
			this.dataGridViewArticulo.Columns[index].SortMode = DataGridViewColumnSortMode.Automatic;
			index = this.dataGridViewArticulo.Columns.Add("PrecioVenta", "Precio Venta");
			this.dataGridViewArticulo.Columns[index].DataPropertyName = "PrecioVenta";
			this.dataGridViewArticulo.Columns[index].DefaultCellStyle.Format = "##0";
			this.dataGridViewArticulo.Columns[index].Width = 100;
			index = this.dataGridViewArticulo.Columns.Add("StockActual", "Actual");
			this.dataGridViewArticulo.Columns[index].DataPropertyName = "StockActual";
			this.dataGridViewArticulo.Columns[index].Width = 60;
			index = this.dataGridViewArticulo.Columns.Add("StockDisponible", "Disponible");
			this.dataGridViewArticulo.Columns[index].DataPropertyName = "StockDisponible";
			this.dataGridViewArticulo.Columns[index].Width = 60;
			index = this.dataGridViewArticulo.Columns.Add("Servicio", "Tipo");
			this.dataGridViewArticulo.Columns[index].DataPropertyName = "Servicio";
			this.dataGridViewArticulo.Columns[index].Width = 80;
			this.bindingSource1.DataSource = Articulo.GetAll(25);
			this.dataGridViewArticulo.DataSource = this.bindingSource1;
		}

		private void FormBuscarArticulo_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.dataGridViewArticulo.SelectedRows.Count > 0) {
				Articulo = Articulo.FindByCodigo(dataGridViewArticulo.CurrentRow.Cells["Codigo"].Value.ToString());
				//MessageBox.Show(Articulo.Descripcion);
				DialogResult = DialogResult.OK;
			}
		}

		private void dataGridViewTerceros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewArticulo.SelectedRows.Count > 0) {
				Close();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			string text = this.txtBusqueda.Text + "%";
			IList<Articulo> list;
			if (this.rbCodigo.Checked) {
				list = Articulo.FindByLikeCodigo(text);
			}
			else {
				list = Articulo.FindByLikeDescripcion(text);
			}
			if (list != null) {
				this.bindingSource1.DataSource = list;
				this.dataGridViewArticulo.DataSource = this.bindingSource1;
				this.bindingSource1.ResetBindings(false);
			}
		}

		private void dataGridViewArticulo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.dataGridViewArticulo.Columns[e.ColumnIndex].Name == "Servicio") {
				e.Value = (Convert.ToBoolean(e.Value) ? "SERVICIO" : "ARTICULO");
			}
		}
	}
}
