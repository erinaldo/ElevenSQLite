/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 15:40
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
	/// Description of FrmBuscarTipoDocumento.
	/// </summary>
	public partial class FrmBuscarTipoDocumento : Form
	{
		public TipoDocumentoMaestro TipoDocumentoMaestro { set; get;}
		public TipoDocumento TipoDocumento{ get; set; }
		
		public FrmBuscarTipoDocumento()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void FormBuscarTipoDocumento_Load(object sender, EventArgs e)
		{
			this.LlenarTipoDocumento();
		}

		private void LlenarTipoDocumento()
		{
			this.dataGridViewTipoDocumento.AutoGenerateColumns = false;
			int index = this.dataGridViewTipoDocumento.Columns.Add("Codigo", "Codigo");
			this.dataGridViewTipoDocumento.Columns[index].DataPropertyName = "Codigo";
			this.dataGridViewTipoDocumento.Columns[index].Width = 50;
			index = this.dataGridViewTipoDocumento.Columns.Add("Descripcion", "Descripcion");
			this.dataGridViewTipoDocumento.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewTipoDocumento.Columns[index].Width = 250;
			index = this.dataGridViewTipoDocumento.Columns.Add("ConsecutivoActual", "Actual");
			this.dataGridViewTipoDocumento.Columns[index].DataPropertyName = "ConsecutivoActual";
			this.dataGridViewTipoDocumento.Columns[index].Width = 70;
			this.bindingSource1.DataSource = TipoDocumento.FindTiposDocumento(TipoDocumentoMaestro);
			this.dataGridViewTipoDocumento.DataSource = this.bindingSource1;
		}

		private void dataGridViewTipoDocumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewTipoDocumento.SelectedRows.Count > 0) {
				Close();
			}
		}

		private void FormBuscarTipoDocumento_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.dataGridViewTipoDocumento.SelectedRows.Count > 0) {
				TipoDocumento = TipoDocumento.FindByCodigo(dataGridViewTipoDocumento.CurrentRow.Cells["Codigo"].Value.ToString());
				//MessageBox.Show(TipoDocumento.Descripcion);
				DialogResult = DialogResult.OK;
			}
		}
	}
}
