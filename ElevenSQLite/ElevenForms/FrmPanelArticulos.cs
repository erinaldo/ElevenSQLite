/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 9/09/2017
 * Hora: 12:40 p. m.
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
	/// Description of FrmPanelArticulos.
	/// </summary>
	public partial class FrmPanelArticulos : Form
	{
		public FrmPanelArticulos()
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
		void CargarArticulos()
		{
			dgvArticulos.DataSource = Articulo.GetAll(30);
		}
		void FrmPanelArticulosLoad(object sender, EventArgs e)
		{
			CargarArticulos();
		}
		void BtnNuevoClick(object sender, EventArgs e)
		{
			var frmArticulo = new FrmArticulo();
			if(frmArticulo.ShowDialog() == DialogResult.Yes) {
				CargarArticulos();
			}
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show(this.Owner, "Desea cerrar esta ventada?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dr == DialogResult.Yes)
			{
				Close();
			}
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			if (dgvArticulos.SelectedRows.Count > 0) {
				Articulo articulo = Articulo.FindByID(Convert.ToInt16(dgvArticulos.CurrentRow.Cells["ID"].Value.ToString()));
				var frmArticulo = new FrmArticulo(articulo);
				if(frmArticulo.ShowDialog() == DialogResult.Yes) {
					CargarArticulos();
				}
			}
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (dgvArticulos.SelectedRows.Count > 0) {
				Articulo articulo = Articulo.FindByID(Convert.ToInt16(dgvArticulos.CurrentRow.Cells["ID"].Value.ToString()));
				if (MessageBox.Show("¿Esta seguro de eliminar el articulo?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
					articulo.Estado = false;
					articulo.Eliminado = true;
					articulo.FechaModificacion = DateTime.Now;
					articulo.Delete();
					MessageBox.Show("Articulo eliminado con exito!",  Application.ProductName , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					CargarArticulos();
					return;
				}				
			}
		}
	}
}
