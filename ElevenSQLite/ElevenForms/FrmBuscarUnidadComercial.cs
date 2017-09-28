/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:24
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
	/// Description of FrmBuscarUnidadComercial.
	/// </summary>
	public partial class FrmBuscarUnidadComercial : Form
	{
		public FrmBuscarUnidadComercial()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarUnidadComercial_Load(object sender, EventArgs e)
		{
			this.LlenarUnidadComercial();
		}

		private void LlenarUnidadComercial()
		{
			this.dataGridViewUnidadComercial.AutoGenerateColumns = false;
			int index = this.dataGridViewUnidadComercial.Columns.Add("Codigo", "Codigo");
			this.dataGridViewUnidadComercial.Columns[index].DataPropertyName = "Codigo";
			this.dataGridViewUnidadComercial.Columns[index].Width = 70;
			index = this.dataGridViewUnidadComercial.Columns.Add("Descripcion", "Descripcion");
			this.dataGridViewUnidadComercial.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewUnidadComercial.Columns[index].Width = 150;
			this.bindingSource1.DataSource = UnidadComercial.GetAll();
			this.dataGridViewUnidadComercial.DataSource = this.bindingSource1;
		}

		private void dataGridViewUnidadComercial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewUnidadComercial.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void FormBuscarUnidadComercial_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.dataGridViewUnidadComercial.SelectedRows.Count > 0) {
				UnidadComercial unidadMedida = (UnidadComercial)this.dataGridViewUnidadComercial.SelectedRows[0].DataBoundItem;
				FrmUnidadComercial frmUnidadComercial = (FrmUnidadComercial)base.Owner;
				frmUnidadComercial.UnidadMedida = unidadMedida;
				
				base.DialogResult = DialogResult.OK;
			}
		}

		private void dataGridViewUnidadComercial_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
