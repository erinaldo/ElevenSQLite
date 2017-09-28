/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:27
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
	/// Description of FrmCantidadTerminalPV.
	/// </summary>
	public partial class FrmCantidadTerminalPV : Form
	{
		public Articulo Articulo { get; set; }
		public decimal Cantidad { get; set; }
		
		public FrmCantidadTerminalPV()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormCantidadTerminalPV_Load(object sender, EventArgs e)
		{
			this.txtCantidad.Text = Convert.ToString(this.Cantidad);
			this.lbDescripcionCorta.Text = this.Articulo.DescripcionCorta;
			this.txtCantidad.Focus();
		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r') {
				try {
					this.Cantidad = Convert.ToInt32(this.txtCantidad.Text);
					base.DialogResult = DialogResult.OK;
				}
				catch {
					MessageBox.Show("No es un numero!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					base.DialogResult = DialogResult.Cancel;
				}
				base.Close();
			}
			if (e.KeyChar == '\u001b') {
				base.Close();
			}
		}

		private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}

		private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}
	}
}
