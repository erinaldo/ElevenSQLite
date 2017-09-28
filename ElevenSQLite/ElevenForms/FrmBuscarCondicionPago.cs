/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:39
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
	/// Description of FrmBuscarCondicionPago.
	/// </summary>
	public partial class FrmBuscarCondicionPago : Form
	{
		public FrmBuscarCondicionPago()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FrmBuscarCondicionPago_Load(object sender, EventArgs e)
		{
			this.LlenarFormaPago();
		}

		private void LlenarFormaPago()
		{
			this.dataGridViewCondicionPago.AutoGenerateColumns = false;
			int index = this.dataGridViewCondicionPago.Columns.Add("Descripcion", "Descripcion");
			this.dataGridViewCondicionPago.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewCondicionPago.Columns[index].Width = 150;
			index = this.dataGridViewCondicionPago.Columns.Add("Dias", "Dias");
			this.dataGridViewCondicionPago.Columns[index].DataPropertyName = "Dias";
			this.dataGridViewCondicionPago.Columns[index].Width = 50;
			this.bindingSource1.DataSource = CondicionPago.GetAll();
			this.dataGridViewCondicionPago.DataSource = this.bindingSource1;
		}

		private void dataGridViewCondicionPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewCondicionPago.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void FrmBuscarCondicionPago_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.dataGridViewCondicionPago.SelectedRows.Count > 0) {
				CondicionPago condicionPago = (CondicionPago)this.dataGridViewCondicionPago.SelectedRows[0].DataBoundItem;
				FrmCondicionPago formCondicionPago = (FrmCondicionPago)base.Owner;
				formCondicionPago.CondicionPago = condicionPago;
				
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
