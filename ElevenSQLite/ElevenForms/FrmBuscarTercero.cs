/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 5:25 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmBuscarTercero.
	/// </summary>
	public partial class FrmBuscarTercero : Form
	{
		
		public TipoDocumento TipoDocumento { get; set; }
		public Tercero Tercero { get; set; }
		public FrmBuscarTercero()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarTercero_Load(object sender, EventArgs e)
		{
			fill();
		}

		private void fill()
		{
			dataGridViewTerceros.AutoGenerateColumns = false;
			int index = dataGridViewTerceros.Columns.Add("Id", "Id");
			dataGridViewTerceros.Columns[index].DataPropertyName = "Id";
			dataGridViewTerceros.Columns[index].Visible = false;
			index = dataGridViewTerceros.Columns.Add("Codigo", "Codigo");
			dataGridViewTerceros.Columns[index].DataPropertyName = "Codigo";
			index = dataGridViewTerceros.Columns.Add("NombreComercial", "Nombre Comercial");
			dataGridViewTerceros.Columns[index].DataPropertyName = "NombreComercial";
			dataGridViewTerceros.Columns[index].Width = 250;
			index = dataGridViewTerceros.Columns.Add("Nit", "NIT");
			dataGridViewTerceros.Columns[index].DataPropertyName = "Nit";
			if (TipoDocumento == null) {
				bindingSource1.DataSource = Tercero.GetUltimos(25);
			}
			else {
				bindingSource1.DataSource = Tercero.GetUltimos(TipoDocumento, 25);
			}
			dataGridViewTerceros.DataSource = bindingSource1;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			IList<Tercero> list = null;
			string text = txtBusqueda.Text + "%";
			if (rbCodigo.Checked) {
				list = Tercero.FindByLikeCodigo(text);
			}
			else {
				if (rbUltimosModificados.Checked) {
					list = Tercero.GetUltimos(25);
				}
				else {
					if (rbNombreComercial.Checked) {
						text = "%" + txtBusqueda.Text + "%";
						list = Tercero.FindByLikeNombreComercial(text);
					}
					else {
						if (rbNit.Checked) {
							list = Tercero.FindByLikeNit(text);
						}
						else {
							if (rbUltimosDocumento.Checked) {
								if (TipoDocumento == null) {
									list = Tercero.GetUltimos(25);
								}
								else {
									if (TipoDocumento.Comprobante) {
										list = Comprobante.FindUltimosTerceroComprobante(TipoDocumento, 25);
									}
									else {
										//list = Documento.FindUltimosTerceroDocumento(TipoDocumento, 25);
									}
								}
							}
						}
					}
				}
			}
			if (list != null) {
				bindingSource1.DataSource = list;
				dataGridViewTerceros.DataSource = bindingSource1;
				bindingSource1.ResetBindings(false);
			}
		}		
		private void dataGridViewTerceros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewTerceros.SelectedRows.Count > 0) {
				Close();
			}
		}

		private void FormBuscarTercero_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (dataGridViewTerceros.SelectedRows.Count > 0) {
				Tercero = Tercero.FindByCodigo(dataGridViewTerceros.CurrentRow.Cells["Codigo"].Value.ToString());
				DialogResult = DialogResult.OK;
			}
		}

		private void rbUltimos_CheckedChanged(object sender, EventArgs e)
		{
			btnBuscar.PerformClick();
		}

		private void rbUltimosFacturados_CheckedChanged(object sender, EventArgs e)
		{
			btnBuscar.PerformClick();
		}
	}
}
