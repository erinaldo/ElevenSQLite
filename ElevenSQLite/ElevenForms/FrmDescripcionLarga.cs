/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:35 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmDescripcionLarga.
	/// </summary>
	public partial class FrmDescripcionLarga : Form
	{
		public string Descripcion { get; set; }
		
		public FrmDescripcionLarga()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormDescripcionLarga_Load(object sender, EventArgs e)
		{
			this.txtDescripcion.Text = this.Descripcion;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			this.Descripcion = this.txtDescripcion.Text;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		
	}
}
