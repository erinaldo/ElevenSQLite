/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmBuscarDocumentoComprobante.
	/// </summary>
	public partial class FrmBuscarDocumentoComprobante : Form
	{
		public Tercero Tercero { get; set;}
		public TipoDocumento TipoDocumento { get; set;}
		private bool borrar;
		
		public FrmBuscarDocumentoComprobante()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarDocumentoComprobante_Load(object sender, EventArgs e)
		{
			this.borrar = false;
			this.ConfigurarDataGridView();
		}

		private void ConfigurarDataGridView()
		{
			this.dataGridViewDocumentos.AutoGenerateColumns = false;
			int index = this.dataGridViewDocumentos.Columns.Add("TipoDocumento", "TipoDocumento");
			this.dataGridViewDocumentos.Columns[index].DataPropertyName = "TipoDocumento";
			this.dataGridViewDocumentos.Columns[index].Width = 50;
			index = this.dataGridViewDocumentos.Columns.Add("Consecutivo", "Consecutivo");
			this.dataGridViewDocumentos.Columns[index].DataPropertyName = "Consecutivo";
			this.dataGridViewDocumentos.Columns[index].Width = 80;
			index = this.dataGridViewDocumentos.Columns.Add("Total", "Total");
			this.dataGridViewDocumentos.Columns[index].DataPropertyName = "Total";
			this.dataGridViewDocumentos.Columns[index].DefaultCellStyle.Format = "##0";
			this.dataGridViewDocumentos.Columns[index].Width = 70;
			index = this.dataGridViewDocumentos.Columns.Add("TotalAbono", "Total Abono");
			this.dataGridViewDocumentos.Columns[index].DataPropertyName = "TotalAbono";
			this.dataGridViewDocumentos.Columns[index].Width = 70;
			this.dataGridViewDocumentos.Columns[index].DefaultCellStyle.Format = "##0";
			if (this.TipoDocumento.Codigo == TipoDocumentoMaestro.COMPROBANTE_EGRESO) {
				TipoDocumentoMaestro tipoDocumentoMaestro = TipoDocumentoMaestro.FindByTipoDocumentoMaestro(TipoDocumentoMaestro.FACTURA_COMPRA);
				this.bindingSource1.DataSource = Documento.FindByTerceroTipoDocumentoMaestroPagado(tipoDocumentoMaestro, this.Tercero);
			}
			else {
				TipoDocumentoMaestro tipoDocumentoMaestro2 = TipoDocumentoMaestro.FindByTipoDocumentoMaestro(TipoDocumentoMaestro.FACTURA_VENTA);
				IList<Documento> dataSource = Documento.FindByTerceroTipoDocumentoMaestroPagado(tipoDocumentoMaestro2, this.Tercero);
				this.bindingSource1.DataSource = dataSource;
			}
			this.dataGridViewDocumentos.DataSource = this.bindingSource1;
		}

		private void dataGridViewDocumentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value != null) {
				if (e.Value is TipoDocumento) {
					TipoDocumento tipoDocumento = TipoDocumento.Get(((TipoDocumento)e.Value).ID);
					e.Value = tipoDocumento.Codigo;
				}
				if (this.dataGridViewDocumentos.Columns[e.ColumnIndex].Name == "Consecutivo") {
					TipoDocumento tipoDocumento2 = (TipoDocumento)this.dataGridViewDocumentos["TipoDocumento", e.RowIndex].Value;
					tipoDocumento2 = TipoDocumento.Get(tipoDocumento2.ID);
					e.CellStyle.Format = this.CalcularCerosIzquierda(tipoDocumento2.CerosIzquierda);
				}
				if (this.dataGridViewDocumentos.Columns[e.ColumnIndex].Name == "Total" || this.dataGridViewDocumentos.Columns[e.ColumnIndex].Name == "TotalAbono") {
					TipoDocumento tipoDocumento3 = (TipoDocumento)this.dataGridViewDocumentos["TipoDocumento", e.RowIndex].Value;
					tipoDocumento3 = TipoDocumento.Get(tipoDocumento3.ID);
					if (tipoDocumento3.CantidadDecimal > 0) {
						e.CellStyle.Format = "##0" + this.CalcularNumeroDecimal(tipoDocumento3.CantidadDecimal);
					}
				}
			}
		}

		private void dataGridViewDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewDocumentos.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private string CalcularCerosIzquierda(int p)
		{
			string text = "";
			for (int i = 0; i < p; i++) {
				text += "0";
			}
			return text;
		}

		private string CalcularNumeroDecimal(int p)
		{
			string text = ".";
			for (int i = 0; i < p; i++) {
				text += "#";
			}
			return text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.borrar = true;
			base.Close();
		}
	}
}
