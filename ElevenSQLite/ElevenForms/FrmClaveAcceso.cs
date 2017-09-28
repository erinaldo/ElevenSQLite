/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 16:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ElevenSQLite.ElevenUtils;
using ElevenSQLite.ElevenCore;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmClaveAcceso.
	/// </summary>
	public partial class FrmClaveAcceso : Form
	{
		public FrmClaveAcceso()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void btnCambioClave_Click(object sender, EventArgs e)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.txtNuevaClave.Text == string.Empty) {
				stringBuilder.Append("Nueva clave esta vacia");
			}
			if (this.txtRepitaClave.Text == string.Empty) {
				stringBuilder.Append("Repita la clave esta vacia");
			}
			if (this.txtNuevaClave.Text != string.Empty && this.txtNuevaClave.Text.Length < 5) {
				stringBuilder.Append("Nueva clave debe tener 5 o mas caracteres!");
			}
			if (this.txtNuevaClave.Text != string.Empty && this.txtRepitaClave.Text == string.Empty && this.txtNuevaClave.Text != this.txtRepitaClave.Text) {
				stringBuilder.Append("Deben ser iguales");
			}
			if (stringBuilder.Length == 0) {
				Usuario usuario = Usuario.FindByUsername(Entorno.USUARIO.NombreUsuario);
				usuario.Clave = ClientMethods.EncriptarClave(this.txtNuevaClave.Text);
				usuario.Update();
				MessageBox.Show("Cambio realizado con exito!", Application.ProductName);
				return;
			}
			MessageBox.Show(stringBuilder.ToString(), Application.ProductName);
		}
	}
}
