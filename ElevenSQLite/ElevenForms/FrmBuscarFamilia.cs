/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:34
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
	/// Description of FrmBuscarFamilia.
	/// </summary>
	public partial class FrmBuscarFamilia : Form
	{
		public FrmBuscarFamilia()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FrmBuscarFamilia_Load(object sender, EventArgs e)
		{
			this.LlenarFamilia();
		}

		private void LlenarFamilia()
		{
			this.dataGridViewFamilia.AutoGenerateColumns = false;
			int index = this.dataGridViewFamilia.Columns.Add("Codigo", "Codigo");
			this.dataGridViewFamilia.Columns[index].DataPropertyName = "Codigo";
			this.dataGridViewFamilia.Columns[index].Width = 70;
			index = this.dataGridViewFamilia.Columns.Add("Descripcion", "Descripcion");
			this.dataGridViewFamilia.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewFamilia.Columns[index].Width = 150;
			this.bindingSource1.DataSource = Familia.GetAll();
			this.dataGridViewFamilia.DataSource = this.bindingSource1;
		}

		private void FrmBuscarFamilia_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.dataGridViewFamilia.SelectedRows.Count > 0) {
				Familia familia = (Familia)this.dataGridViewFamilia.SelectedRows[0].DataBoundItem;
				FrmFamilia frmFamilia = (FrmFamilia)base.Owner;
				frmFamilia.Familia = familia;
				base.DialogResult = DialogResult.OK;
			}
		}

		private void dataGridViewFamilia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewFamilia.SelectedRows.Count > 0) {
				base.Close();
			}
		}
	}
}
