/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:04
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
	/// Description of FrmBuscarBanco.
	/// </summary>
	public partial class FrmBuscarBanco : Form
	{
		public FrmBuscarBanco()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void LlenarBancos()
		{
			this.dataGridViewBanco.AutoGenerateColumns = false;
			int index = this.dataGridViewBanco.Columns.Add("Descripcion", "Descripción");
			this.dataGridViewBanco.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewBanco.Columns[index].Width = 250;
			this.bindingSource1.DataSource = Banco.GetAll();
			this.dataGridViewBanco.DataSource = this.bindingSource1;
		}
		
		private void FormBuscarBanco_Load(object sender, EventArgs e)
		{
			this.LlenarBancos();
		}

		private void dataGridViewBanco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewBanco.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void FrmBuscarBanco_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.dataGridViewBanco.SelectedRows.Count > 0) {
				Banco banco = (Banco)this.dataGridViewBanco.SelectedRows[0].DataBoundItem;
				/*FrmBanco formBanco = (FrmBanco)base.Owner;
				frmBanco.Banco = banco;
				frmBanco.LlenarBanco();*/
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
