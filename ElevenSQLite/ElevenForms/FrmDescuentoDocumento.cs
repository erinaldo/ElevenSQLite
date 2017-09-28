/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:11 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmDescuentoDocumento.
	/// </summary>
	public partial class FrmDescuentoDocumento : Form
	{
		public bool Recalculo { get; set;}
		public string FormatoNumero { get; set;}
		public decimal Descuento { get; set;}
		
		public FrmDescuentoDocumento()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormDescuentoDocumento_Load(object sender, EventArgs e)
		{
			this.txtDescuento.Text = this.Descuento.ToString(this.FormatoNumero);
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			this.Descuento = Convert.ToDecimal(this.txtDescuento.Text);
			this.Recalculo = this.checkRecalculo.Checked;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}
	}
}
