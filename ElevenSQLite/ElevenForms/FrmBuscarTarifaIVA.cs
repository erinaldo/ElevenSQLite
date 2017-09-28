/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:01
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
	/// Description of FrmBuscarTarifaIVA.
	/// </summary>
	public partial class FrmBuscarTarifaIVA : Form
	{
		public FrmBuscarTarifaIVA()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarTarifaIVA_Load(object sender, EventArgs e)
		{
			this.LlenarTarifaIVA();
		}

		private void LlenarTarifaIVA()
		{
			this.dataGridViewTarifaIVA.AutoGenerateColumns = false;
			int index = this.dataGridViewTarifaIVA.Columns.Add("Id", "Id");
			this.dataGridViewTarifaIVA.Columns[index].DataPropertyName = "Id";
			this.dataGridViewTarifaIVA.Columns[index].Visible = false;
			index = this.dataGridViewTarifaIVA.Columns.Add("Tarifa", "Tarifa");
			this.dataGridViewTarifaIVA.Columns[index].DataPropertyName = "Tarifa";
			this.dataGridViewTarifaIVA.Columns[index].Width = 70;
			this.bindingSource1.DataSource = TarifaIVA.GetAll();
			this.dataGridViewTarifaIVA.DataSource = this.bindingSource1;
		}

		private void dataGridViewTarifaIVA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewTarifaIVA.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void FormBuscarTarifaIVA_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.dataGridViewTarifaIVA.SelectedRows.Count > 0) {
				TarifaIVA tarifaIVA = (TarifaIVA)this.dataGridViewTarifaIVA.SelectedRows[0].DataBoundItem;
				FrmTarifaIVA frmTarifaIVA = (FrmTarifaIVA)base.Owner;
				frmTarifaIVA.TarifaIVA = tarifaIVA;
				
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
