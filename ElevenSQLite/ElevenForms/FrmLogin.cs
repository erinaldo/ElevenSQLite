/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 9/09/2017
 * Hora: 11:54 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;
using ElevenSQLite.ElevenUtils;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmLogin.
	/// </summary>
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Text = string.Format("Ingreso a {0}", Application.ProductName);
		}
		void BtnAceptarClick(object sender, EventArgs e)
		{
			Usuario usuario = Usuario.Login(txtUsuario.Text, ClientMethods.EncriptarClave(txtClave.Text));
			if (usuario == null) {
				MessageBox.Show("Usuario o clave incorrecta!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtUsuario.Text = string.Empty;
				txtClave.Text = string.Empty;
			}else{
				Entorno.USUARIO = usuario;
				DialogResult = DialogResult.OK;
				Close();
			}
			
		}
	}
}
