/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 3:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmCambiarConsecutivo.
	/// </summary>
	public partial class FrmCambiarConsecutivo : Form
	{
		public int Consecutivo { get; set; }
		
		public FrmCambiarConsecutivo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormCambiarConsecutivo_Load(object sender, EventArgs e)
		{
			this.txtConsecutivo.Text = Convert.ToString(this.Consecutivo);
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			this.Consecutivo = Convert.ToInt32(this.txtConsecutivo.Text);
		}
	}
}
