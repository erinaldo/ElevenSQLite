/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 9/09/2017
 * Hora: 12:50 p. m.
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
	/// Description of FrmPanelComprobantes.
	/// </summary>
	public partial class FrmPanelComprobantes : Form
	{
		public FrmPanelComprobantes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		protected override void OnLoad(EventArgs e)
	    {
			base.OnLoad(e);
	        this.ControlBox = false;
	        this.WindowState = FormWindowState.Maximized;
	        this.BringToFront();
	    }
		void CargarDocumentos()
		{
			dgvComprobantes.DataSource = Comprobante.GetAll();
		}
		void FrmPanelComprobantesLoad(object sender, EventArgs e)
		{
			CargarDocumentos();
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show(this.Owner, "Desea cerrar esta ventada?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dr == DialogResult.Yes)
			{
				Close();
			}
		}
		void BtnNuevoClick(object sender, EventArgs e)
		{
			var frmComprobante = new FrmComprobante();
			if(frmComprobante.ShowDialog() == DialogResult.OK)
			{
				
			}
		}
		
	}
}
