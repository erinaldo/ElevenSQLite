/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 13:51
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
	/// Description of FrmBuscarPais.
	/// </summary>
	public partial class FrmBuscarPais : Form
	{
		public FrmBuscarPais()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarPais_Load(object sender, EventArgs e)
		{
			this.LlenarPais();
		}

		private void LlenarPais()
		{
			this.dataGridViewPais.AutoGenerateColumns = false;
			int index = this.dataGridViewPais.Columns.Add("Descripcion", "Descripción");
			this.dataGridViewPais.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewPais.Columns[index].Width = 250;
			this.bindingSource1.DataSource = Pais.GetAll();
			this.dataGridViewPais.DataSource = this.bindingSource1;
		}

		private void dataGridViewPais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewPais.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void FormBuscarPais_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.dataGridViewPais.SelectedRows.Count > 0) {
				Pais pais = (Pais)this.dataGridViewPais.SelectedRows[0].DataBoundItem;
				FrmPais frmPais = (FrmPais)base.Owner;
				frmPais.Pais = pais;
				
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
