/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmBuscarComprobante.
	/// </summary>
	public partial class FrmBuscarComprobante : Form
	{
		public TipoDocumento TipoDocumento { set; get; }
		public FrmBuscarComprobante()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarComprobante_Load(object sender, EventArgs e)
		{
			this.LlenarComprobante();
		}

		private void LlenarComprobante()
		{
			this.dataGridViewComprobante.AutoGenerateColumns = false;
			int index = this.dataGridViewComprobante.Columns.Add("Consecutivo", "Consecutivo");
			this.dataGridViewComprobante.Columns[index].DataPropertyName = "Consecutivo";
			this.dataGridViewComprobante.Columns[index].Width = 80;
			index = this.dataGridViewComprobante.Columns.Add("Tercero", "Tercero");
			this.dataGridViewComprobante.Columns[index].DataPropertyName = "Tercero";
			this.dataGridViewComprobante.Columns[index].Width = 220;
			index = this.dataGridViewComprobante.Columns.Add("FechaComprobante", "FechaComprobante");
			this.dataGridViewComprobante.Columns[index].DataPropertyName = "FechaComprobante";
			this.dataGridViewComprobante.Columns[index].DefaultCellStyle.Format = "yyyy/MM/dd";
			this.dataGridViewComprobante.Columns[index].Width = 80;
			index = this.dataGridViewComprobante.Columns.Add("Total", "Total");
			this.dataGridViewComprobante.Columns[index].DataPropertyName = "Total";
			this.dataGridViewComprobante.Columns[index].Width = 100;
			this.dataGridViewComprobante.Columns[index].DefaultCellStyle.Format = "##0";
			index = this.dataGridViewComprobante.Columns.Add("EstadoDocumento", "EstadoDocumento");
			this.dataGridViewComprobante.Columns[index].DataPropertyName = "EstadoDocumento";
			this.dataGridViewComprobante.Columns[index].Width = 100;
			this.dataGridViewComprobante.Columns[index].DefaultCellStyle.Format = "##0";
			this.bindingSource1.DataSource = Comprobante.GetUltimos(this.TipoDocumento, 25);
			this.dataGridViewComprobante.DataSource = this.bindingSource1;
		}

		private void dataGridViewComprobante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewComprobante.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void dataGridViewComprobante_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value is Tercero) {
				e.Value = ((Tercero)e.Value).NombreComercial;
			}
			if (e.Value is EstadoDocumento) {
				var estadoDocumento = (EstadoDocumento)e.Value;
				e.Value = estadoDocumento.Descripcion;
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (this.rbTercero.Checked) {
				this.bindingSource1.DataSource = Comprobante.FindByLikeTipoDocumentoTercero(this.TipoDocumento, "%" + this.txtBusqueda.Text + "%");
				this.dataGridViewComprobante.DataSource = this.bindingSource1;
			}
			if (this.rbTodos.Checked) {
				this.bindingSource1.DataSource = Comprobante.GetAll(this.TipoDocumento);
				this.dataGridViewComprobante.DataSource = this.bindingSource1;
			}
		}

		private void rbTercero_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void rbTodos_CheckedChanged(object sender, EventArgs e)
		{
			this.btnBuscar.PerformClick();
		}
	}
}
