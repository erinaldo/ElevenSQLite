/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:25
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
	/// Description of FrmBuscarEmpleado.
	/// </summary>
	public partial class FrmBuscarEmpleado : Form
	{
		public FrmBuscarEmpleado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void LlenarEmpleado()
		{
			this.dataGridViewEmpleado.AutoGenerateColumns = false;
			int index = this.dataGridViewEmpleado.Columns.Add("Codigo", "Codigo");
			this.dataGridViewEmpleado.Columns[index].DataPropertyName = "Codigo";
			this.dataGridViewEmpleado.Columns[index].Width = 70;
			index = this.dataGridViewEmpleado.Columns.Add("NombreCompleto", "Nombre Completo");
			this.dataGridViewEmpleado.Columns[index].DataPropertyName = "NombreCompleto";
			this.dataGridViewEmpleado.Columns[index].Width = 150;
			this.bindingSource1.DataSource = Empleado.GetAll();
			this.dataGridViewEmpleado.DataSource = this.bindingSource1;
		}
		private void FormBuscarEmpleado_Load(object sender, EventArgs e)
		{
			this.LlenarEmpleado();
		}
		private void dataGridViewEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewEmpleado.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void FormBuscarEmpleado_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.dataGridViewEmpleado.SelectedRows.Count > 0) {
				Empleado empleado = (Empleado)this.dataGridViewEmpleado.SelectedRows[0].DataBoundItem;
				FrmEmpleado formEmpleado = (FrmEmpleado)base.Owner;
				formEmpleado.Empleado = empleado;				
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
