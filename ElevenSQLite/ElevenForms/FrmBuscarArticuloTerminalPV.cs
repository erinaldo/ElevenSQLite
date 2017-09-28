/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 9:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;
using ElevenSQLite.ElevenUtils;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmBuscarArticuloTerminalPV.
	/// </summary>
	public partial class FrmBuscarArticuloTerminalPV : Form
	{
		public bool Descripcion { get; set; }
		public bool CodigoPLU { get; set; }
		bool seleccion;
		
		public FrmBuscarArticuloTerminalPV()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarArticuloTerminalPV_Load(object sender, EventArgs e)
		{
			this.LlenarDataGridView();			
			this.txtBusqueda.Focus();
		}

		private void LlenarDataGridView()
		{
			this.dataGridViewArticulo.AutoGenerateColumns = false;
			int index = this.dataGridViewArticulo.Columns.Add("Descripcion", "Descripción");
			this.dataGridViewArticulo.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewArticulo.Columns[index].Width = 300;
			index = this.dataGridViewArticulo.Columns.Add("PrecioVenta", "Precio Venta");
			this.dataGridViewArticulo.Columns[index].DataPropertyName = "PrecioVenta";
			this.dataGridViewArticulo.Columns[index].DefaultCellStyle.Format = "##0";
			this.dataGridViewArticulo.Columns[index].Width = 100;
			this.dataGridViewArticulo.DataSource = this.bindingSource1;
		}

		private void txtCampo_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) {
				e.Handled = false;
				base.Close();
			}
			if (e.KeyCode == Keys.Return) {
				e.Handled = false;
				this.seleccion = true;
				this.SeleccionarArticulo();
			}
		}

		private void SeleccionarArticulo()
		{
			if (this.dataGridViewArticulo.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
		{
		}

		private void txtBusqueda_TextChanged(object sender, EventArgs e)
		{
			if (this.txtBusqueda.Text != string.Empty) {
				string codigo = "%" + this.txtBusqueda.Text + "%";
				IList<Articulo> list = null;
				if (this.Descripcion) {
					list = Articulo.FindByLikeDescripcion(codigo);
				}
				if (this.CodigoPLU) {
					list = Articulo.FindByLikeCodigoPLU(codigo);
				}
				if (list != null) {
					this.bindingSource1.DataSource = list;
					this.dataGridViewArticulo.DataSource = this.bindingSource1;
					this.bindingSource1.ResetBindings(false);
				}
			}
		}

		private void FormBuscarArticuloTerminalPV_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.dataGridViewArticulo.SelectedRows.Count > 0 && this.seleccion) {
				Articulo articulo = (Articulo)this.dataGridViewArticulo.SelectedRows[0].DataBoundItem;
				if (base.Owner is FrmTerminalPV) {
					FrmTerminalPV formTerminalPV = (FrmTerminalPV)base.Owner;
					formTerminalPV.Articulo = articulo;
				}
				base.DialogResult = DialogResult.OK;
			}
		}

		private void dataGridViewArticulo_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) {
				e.Handled = false;
				base.Close();
			}
			if (e.KeyCode == Keys.Return) {
				e.Handled = false;
				this.seleccion = true;
				this.SeleccionarArticulo();
			}
		}
	}
}
