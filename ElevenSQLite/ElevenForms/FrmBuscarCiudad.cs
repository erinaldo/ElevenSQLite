/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:10
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
	/// Description of FrmBuscarCiudad.
	/// </summary>
	public partial class FrmBuscarCiudad : Form
	{
		public FrmBuscarCiudad()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarCiudad_Load(object sender, EventArgs e)
		{
			this.LlenarCiudad();
		}

		private void LlenarCiudad()
		{
			this.dataGridViewCiudad.AutoGenerateColumns = false;
			int index = this.dataGridViewCiudad.Columns.Add("Descripcion", "Descripción");
			this.dataGridViewCiudad.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewCiudad.Columns[index].Width = 250;
			index = this.dataGridViewCiudad.Columns.Add("Estado", "Estado");
			this.dataGridViewCiudad.Columns[index].DataPropertyName = "Estado";
			this.dataGridViewCiudad.Columns[index].Width = 250;
			this.bindingSource1.DataSource = Ciudad.GetAll();
			this.dataGridViewCiudad.DataSource = this.bindingSource1;
		}

		private void dataGridViewCiudad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewCiudad.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void FormBuscarCiudad_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.dataGridViewCiudad.SelectedRows.Count > 0) {
				Ciudad ciudad = (Ciudad)this.dataGridViewCiudad.SelectedRows[0].DataBoundItem;
				FrmCiudad frmCiudad = (FrmCiudad)base.Owner;
				frmCiudad.Ciudad = ciudad;
				base.DialogResult = DialogResult.OK;
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (this.rbCiudad.Checked) {
				this.bindingSource1.DataSource = Ciudad.FindByLikeNombreCiudad( this.txtBusqueda.Text);
				this.dataGridViewCiudad.DataSource = this.bindingSource1;
				return;
			}
			this.bindingSource1.DataSource = Ciudad.GetAll();
			this.dataGridViewCiudad.DataSource = this.bindingSource1;
		}

		private void dataGridViewCiudad_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value is Estado) {
				Estado estado = (Estado)e.Value;
				Estado estado2 = Estado.Get(estado.ID);
				e.Value = estado2.Descripcion;
			}
		}

		private void dataGridViewCiudad_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
