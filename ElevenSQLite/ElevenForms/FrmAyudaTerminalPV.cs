/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 15:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ElevenSQLite.ElevenUtils;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmAyudaTerminalPV.
	/// </summary>
	public partial class FrmAyudaTerminalPV : Form
	{
		private string TECLA = "Tecla";
		private string DESCRIPCION = "Descripción";
		
		public FrmAyudaTerminalPV()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormAyudaTerminalPV_Load(object sender, EventArgs e)
		{
			this.Text = "SoluPYME " + Entorno.VERSION + " - Ayuda Terminal PV";
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add(this.TECLA);
			dataTable.Columns.Add(this.DESCRIPCION);
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[0][0] = "F1";
			dataTable.Rows[0][1] = "AYUDA";
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[1][0] = "F2";
			dataTable.Rows[1][1] = "EDITAR DESCRIPCIÓN";
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[2][0] = "F3";
			dataTable.Rows[2][1] = "BUSCAR POR NOMBRE";
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[3][0] = "F4";
			dataTable.Rows[3][1] = "NUEVA TIRILLA";
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[4][0] = "F5";
			dataTable.Rows[4][1] = "BUSCAR POR CODIGO PLU";
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[5][0] = "F6";
			dataTable.Rows[5][1] = "CAMBIAR CLIENTE";
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[6][0] = "F7";
			dataTable.Rows[6][1] = "CAMBIAR CANTIDAD ULTIMO ARTICULO";
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[7][0] = "SUPR";
			dataTable.Rows[7][1] = "ELIMINAR ULTIMO ARTICULO";
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[8][0] = "F12";
			dataTable.Rows[8][1] = "IMPRIMIR Y GUARDAR";
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[9][0] = "ESC";
			dataTable.Rows[9][1] = "REGRESA AL LECTOR DE CODIGO";
			this.dataGridViewAyuda.AutoGenerateColumns = false;
			int index = this.dataGridViewAyuda.Columns.Add(this.TECLA, this.TECLA);
			this.dataGridViewAyuda.Columns[index].DataPropertyName = this.TECLA;
			this.dataGridViewAyuda.Columns[this.TECLA].Width = 50;
			index = this.dataGridViewAyuda.Columns.Add(this.DESCRIPCION, this.DESCRIPCION);
			this.dataGridViewAyuda.Columns[index].DataPropertyName = this.DESCRIPCION;
			this.dataGridViewAyuda.Columns[this.DESCRIPCION].Width = 250;
			this.bindingSource1.DataSource = dataTable;
			this.dataGridViewAyuda.DataSource = this.bindingSource1;
		}

		private void dataGridViewAyuda_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void dataGridViewAyuda_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\u001b') {
				base.Close();
			}
		}
	}
}
