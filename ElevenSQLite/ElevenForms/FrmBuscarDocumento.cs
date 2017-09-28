/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:51
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
	/// Description of FrmBuscarDocumento.
	/// </summary>
	public partial class FrmBuscarDocumento : Form
	{
		public TipoDocumento TipoDocumento { get; set; }
		
		public FrmBuscarDocumento()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarDocumento_Load(object sender, EventArgs e)
		{
			this.LlenarDocumentos();
		}

		private void LlenarDocumentos()
		{
			this.dataGridViewDocumento.AutoGenerateColumns = false;
			int index = this.dataGridViewDocumento.Columns.Add("Consecutivo", "Consecutivo");
			this.dataGridViewDocumento.Columns[index].DataPropertyName = "Consecutivo";
			this.dataGridViewDocumento.Columns[index].Width = 80;
			index = this.dataGridViewDocumento.Columns.Add("FechaDocumento", "Fecha Documento");
			this.dataGridViewDocumento.Columns[index].DataPropertyName = "FechaDocumento";
			this.dataGridViewDocumento.Columns[index].DefaultCellStyle.Format = "yyyy/MM/dd";
			this.dataGridViewDocumento.Columns[index].Width = 100;
			index = this.dataGridViewDocumento.Columns.Add("Tercero", "Tercero");
			this.dataGridViewDocumento.Columns[index].DataPropertyName = "Tercero";
			this.dataGridViewDocumento.Columns[index].Width = 250;
			index = this.dataGridViewDocumento.Columns.Add("Total", "Total Documento");
			this.dataGridViewDocumento.Columns[index].DataPropertyName = "Total";
			this.dataGridViewDocumento.Columns[index].Width = 100;
			this.dataGridViewDocumento.Columns[index].DefaultCellStyle.Format = "##0";
			index = this.dataGridViewDocumento.Columns.Add("EstadoDocumento", "Estado");
			this.dataGridViewDocumento.Columns[index].DataPropertyName = "EstadoDocumento";
			this.dataGridViewDocumento.Columns[index].Width = 100;
			this.bindingSource1.DataSource = Documento.GetUltimosDocumentos(this.TipoDocumento, 25);
			this.dataGridViewDocumento.DataSource = this.bindingSource1;
		}

		private void FormBuscarDocumento_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.dataGridViewDocumento.SelectedRows.Count > 0) {
				Documento documento = (Documento)this.dataGridViewDocumento.SelectedRows[0].DataBoundItem;
				FrmDocumento frmDocumento = (FrmDocumento)base.Owner;
				frmDocumento.Documento = documento;
				frmDocumento.LlenarDocumento();
			}
		}

		private void dataGridViewDocumento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value is Tercero) {
				Tercero tercero = (Tercero)e.Value;
				e.Value = tercero.NombreComercial;
			}
			if (e.Value is EstadoDocumento) {
				EstadoDocumento estadoDocumento = (EstadoDocumento)e.Value;
				e.Value = estadoDocumento.Descripcion;
			}
		}

		private void dataGridViewDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void dataGridViewDocumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewDocumento.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			
			if (this.rbTercero.Checked) {
				string tercero = "%" + this.txtBusqueda.Text + "%";
				this.bindingSource1.DataSource = Documento.FindByLikeTerceroTipoDocumento(this.TipoDocumento, tercero);
			}
			else {
				if (this.rbConsecutivo.Checked) {
					try {
						Convert.ToInt32(this.txtBusqueda.Text);
						int consecutivo = Convert.ToInt32(this.txtBusqueda.Text);
						this.bindingSource1.DataSource = Documento.FindByLikeConsecutivo(this.TipoDocumento, consecutivo);
						goto IL_DC;
					}
					catch {
						MessageBox.Show("No es un numero!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						goto IL_DC;
					}
				}
				if (this.rbUltimos.Checked) {
					this.bindingSource1.DataSource = Documento.GetUltimosDocumentos(this.TipoDocumento, 25);
				}
			}
			IL_DC:
			this.dataGridViewDocumento.DataSource = this.bindingSource1;
		}

		private void rbUltimos_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbUltimos.Checked) {
				this.btnBuscar.PerformClick();
			}
		}

		private void rbTodos_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbTodos.Checked) {
				this.bindingSource1.DataSource = Documento.GetAll(this.TipoDocumento);
				this.dataGridViewDocumento.DataSource = this.bindingSource1;
			}
		}

		private void rbConsecutivo_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void rbTercero_CheckedChanged(object sender, EventArgs e)
		{
		}
	}
}
