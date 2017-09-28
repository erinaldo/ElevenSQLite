/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 9/09/2017
 * Hora: 12:49 p. m.
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
	/// Description of FrmPanelDocumentos.
	/// </summary>
	public partial class FrmPanelDocumentos : Form
	{
		public FrmPanelDocumentos()
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
			dgvDocumentos.DataSource = Documento.GetAll();
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show(this.Owner, "Desea cerrar esta ventana?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dr == DialogResult.Yes)
			{
				Close();
			}
		}
		void BtnNuevoClick(object sender, EventArgs e)
		{
			var frmDocumento = new FrmDocumento();
			if(frmDocumento.ShowDialog() == DialogResult.Yes) {
				CargarDocumentos();
			}
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			if (dgvDocumentos.SelectedRows.Count > 0) {
				Documento documento = Documento.FindByID(Convert.ToInt16(dgvDocumentos.CurrentRow.Cells["ID"].Value.ToString()));
				var frmDocumento = new FrmDocumento(documento);
				if(frmDocumento.ShowDialog(this) == DialogResult.Yes) {
					CargarDocumentos();
				}
			}
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (dgvDocumentos.SelectedRows.Count > 0) {
				Documento documento = Documento.FindByID(Convert.ToInt16(dgvDocumentos.CurrentRow.Cells["ID"].Value.ToString()));
				if (MessageBox.Show("¿Esta seguro de eliminar el documento?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
					documento.Eliminado = true;
					documento.FechaModificacion = DateTime.Now;
					documento.Delete();
					MessageBox.Show("Articulo eliminado con exito!",  Application.ProductName , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					CargarDocumentos();
					return;
				}				
			}
		}
		void FrmPanelDocumentosLoad(object sender, EventArgs e)
		{
			CargarDocumentos();
		}
		void BtnAnularClick(object sender, EventArgs e)
		{
			if (dgvDocumentos.SelectedRows.Count > 0) {
				Documento documento = Documento.FindByID(Convert.ToInt16(dgvDocumentos.CurrentRow.Cells["ID"].Value.ToString()));
				var frmAnularDocumento = new FrmAnularDocumento(documento);
				if(frmAnularDocumento.ShowDialog() == DialogResult.OK){
				}
			}
			
		}
	}
}
