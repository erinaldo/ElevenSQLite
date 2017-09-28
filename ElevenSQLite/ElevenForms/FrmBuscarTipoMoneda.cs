/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:12
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
	/// Description of FormBuscarTipoMoneda.
	/// </summary>
	public partial class FrmBuscarTipoMoneda : Form
	{
		public FrmBuscarTipoMoneda()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void FormBuscarTipoMoneda_Load(object sender, EventArgs e)
		{
			this.LlenarTipoMoneda();
		}

		private void LlenarTipoMoneda()
		{
			this.dataGridViewTipoMoneda.AutoGenerateColumns = false;
			int index = this.dataGridViewTipoMoneda.Columns.Add("Codigo", "Código");
			this.dataGridViewTipoMoneda.Columns[index].DataPropertyName = "Codigo";
			this.dataGridViewTipoMoneda.Columns[index].Width = 70;
			index = this.dataGridViewTipoMoneda.Columns.Add("Descripcion", "Descripción");
			this.dataGridViewTipoMoneda.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewTipoMoneda.Columns[index].Width = 250;
			this.bindingSource1.DataSource = TipoMoneda.GetAll();
			this.dataGridViewTipoMoneda.DataSource = this.bindingSource1;
		}

		private void FormBuscarTipoMoneda_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.dataGridViewTipoMoneda.SelectedRows.Count > 0) {
				TipoMoneda tipoMoneda = (TipoMoneda)this.dataGridViewTipoMoneda.SelectedRows[0].DataBoundItem;
				FrmTipoMoneda frmTipoMoneda = (FrmTipoMoneda)base.Owner;
				frmTipoMoneda.TipoMoneda = tipoMoneda;
				
				base.DialogResult = DialogResult.OK;
			}
		}

		private void dataGridViewTipoMoneda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewTipoMoneda.SelectedRows.Count > 0) {
				base.Close();
			}
		}
	}
}
