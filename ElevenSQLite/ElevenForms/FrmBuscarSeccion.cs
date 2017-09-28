/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 13:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmBuscarSeccion.
	/// </summary>
	public partial class FrmBuscarSeccion : Form
	{
		public FrmBuscarSeccion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormBuscarSeccion_Load(object sender, EventArgs e)
		{
			this.LlenarSeccion();
		}

		private void LlenarSeccion()
		{
			this.dataGridViewSeccion.AutoGenerateColumns = false;
			int index = this.dataGridViewSeccion.Columns.Add("Id", "Id");
			this.dataGridViewSeccion.Columns[index].DataPropertyName = "Id";
			this.dataGridViewSeccion.Columns[index].Visible = false;
			index = this.dataGridViewSeccion.Columns.Add("Codigo", "Codigo");
			this.dataGridViewSeccion.Columns[index].DataPropertyName = "Codigo";
			this.dataGridViewSeccion.Columns[index].Width = 70;
			index = this.dataGridViewSeccion.Columns.Add("Descripcion", "Descripcion");
			this.dataGridViewSeccion.Columns[index].DataPropertyName = "Descripcion";
			this.dataGridViewSeccion.Columns[index].Width = 150;
			index = this.dataGridViewSeccion.Columns.Add("Familia", "Familia");
			this.dataGridViewSeccion.Columns[index].DataPropertyName = "Familia";
			this.dataGridViewSeccion.Columns[index].Width = 150;
			this.bindingSource1.DataSource = Seccion.GetAll();
			this.dataGridViewSeccion.DataSource = this.bindingSource1;
		}

		private void FormBuscarSeccion_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.dataGridViewSeccion.SelectedRows.Count > 0) {
				Seccion seccion = (Seccion)this.dataGridViewSeccion.SelectedRows[0].DataBoundItem;
				FrmSeccion frmSeccion = (FrmSeccion)base.Owner;
				frmSeccion.Seccion = seccion;
				
				base.DialogResult = DialogResult.OK;
			}
		}

		private void dataGridViewFamilia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewSeccion.SelectedRows.Count > 0) {
				base.Close();
			}
		}

		private void dataGridViewSeccion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (Regex.Match(e.Value.ToString(), "(SoluPYME.Objetos)(.*)").Success) {
				Familia familia = (Familia)e.Value;
				e.Value = familia.Descripcion;
			}
		}

		private void dataGridViewSeccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
