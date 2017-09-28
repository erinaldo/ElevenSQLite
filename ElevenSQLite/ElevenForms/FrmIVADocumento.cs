/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:05 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmIVADocumento.
	/// </summary>
	public partial class FrmIVADocumento : Form
	{
		
		public bool Recalculo { get; set; }
		public string FormatoNumero { get; set; }
		public int Iva { get; set; }
		
		public FrmIVADocumento()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormIVADocumento_Load(object sender, EventArgs e)
		{
			this.txtIVA.Text = this.Iva.ToString(this.FormatoNumero);
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			this.Iva = Convert.ToInt32(this.txtIVA.Text);
			this.Recalculo = this.checkRecalculo.Checked;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}
	}
}
