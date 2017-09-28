/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:30
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
	/// Description of FrmBuscarEstado.
	/// </summary>
	public partial class FrmBuscarEstado : Form
	{
		public FrmBuscarEstado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Pais Pais { get; set;	}
		private void FrmBuscarEstado_Load(object sender, EventArgs e)
		{
			this.LlenarEstado();
		}

		private void LlenarEstado()
		{
			this.dataGridViewEstado.AutoGenerateColumns = false;
			int index = this.dataGridViewEstado.Columns.Add("Descripcion", "Descripción");
			this.dataGridViewEstado.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewEstado.Columns[index].Width = 250;
			this.bindingSource1.DataSource = Estado.GetAllByPais(this.Pais);
			this.dataGridViewEstado.DataSource = this.bindingSource1;
		}

		private void dataGridViewEstado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewEstado.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void FrmBuscarEstado_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.dataGridViewEstado.SelectedRows.Count > 0) {
				Estado estado = (Estado)this.dataGridViewEstado.SelectedRows[0].DataBoundItem;
				FrmEstado frmEstado = (FrmEstado)base.Owner;
				frmEstado.Estado = estado;
				
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
