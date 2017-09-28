/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:41 p. m.
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
	/// Description of FrmTerceroLite.
	/// </summary>
	public partial class FrmTerceroLite : Form
	{
		public Tercero Tercero { get; set; }
		private static Empresa empresa = Empresa.Get();
		
		public FrmTerceroLite()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
		{
			this.TeclaEnter(e);
		}

		private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
		{
			this.TeclaEnter(e);
		}

		private void TeclaEnter(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}

		private void txtNombreComercial_KeyDown(object sender, KeyEventArgs e)
		{
			this.TeclaEnter(e);
		}

		private void txtNombreComercial_KeyUp(object sender, KeyEventArgs e)
		{
			this.TeclaEnter(e);
		}

		private void txtDireccion_KeyUp(object sender, KeyEventArgs e)
		{
			this.TeclaEnter(e);
		}

		private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
		{
			this.TeclaEnter(e);
		}

		private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
		{
			this.TeclaEnter(e);
		}

		private void txtTelefono_KeyUp(object sender, KeyEventArgs e)
		{
			this.TeclaEnter(e);
		}

		private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r') {
				e.Handled = true;
				SendKeys.Send("{TAB}");
			}
		}

		private void txtNombreComercial_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r') {
				e.Handled = true;
				SendKeys.Send("{TAB}");
			}
		}

		private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r') {
				e.Handled = true;
				SendKeys.Send("{TAB}");
			}
		}

		private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r') {
				e.Handled = true;
				SendKeys.Send("{TAB}");
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (this.txtNombreComercial.Text != string.Empty) {
				this.Tercero.Codigo = this.txtCodigo.Text;
				int nit = 0;
				bool flag = int.TryParse(this.txtCodigo.Text, out nit);
				if (flag) {
					this.Tercero.Nit = nit;
				}
				this.Tercero.NombreComercial = this.txtNombreComercial.Text;
				this.Tercero.DireccionPrincipal = this.txtDireccion.Text;
				this.Tercero.TelefonoPrincipal = this.txtTelefono.Text;
				this.Tercero.TipoRegimen = Tercero.REGIMEN_SIMPLIFICADO;
				this.Tercero.ClienteNacional = true;
				this.Tercero.RazonSocial = string.Empty;
				if (empresa.CiudadID != 0) {
					Ciudad ciudad = Ciudad.Get(empresa.CiudadID.GetValueOrDefault());
					this.Tercero.CiudadID = ciudad.ID;
				}
				this.Tercero.Calificacion = 3;
				this.Tercero.TipoPrecioVenta = 0;
				this.Tercero.UsuarioID = Entorno.USUARIO.ID;
				if (this.Tercero.ID == 0) {
					Tercero.Save();
					MessageBox.Show("Tercero grabado con exito!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					base.DialogResult = DialogResult.OK;
				}
				base.Close();
				return;
			}
			MessageBox.Show("Nombre comercial es requerido!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			this.txtNombreComercial.Focus();
		}

		private void FormTerceroLite_Load(object sender, EventArgs e)
		{
			this.Tercero = new Tercero();
			this.Tercero.FechaCreacion = DateTime.Now;
			this.txtNombreComercial.Focus();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
