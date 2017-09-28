/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 9/09/2017
 * Hora: 12:48 p. m.
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
	/// Description of FrmPanelTerceros.
	/// </summary>
	public partial class FrmPanelTerceros : Form
	{
		public FrmPanelTerceros()
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
		void CargarTerceros(){
			dgvTerceros.DataSource = Tercero.GetAll(30);
		}
		void FrmPanelTercerosLoad(object sender, EventArgs e)
		{
			CargarTerceros();
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
			var frmTercero = new FrmTercero();
			if(frmTercero.ShowDialog() == DialogResult.Yes) {
				CargarTerceros();
			}
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			if (dgvTerceros.SelectedRows.Count > 0) {
				Tercero tercero = Tercero.FindByID(Convert.ToInt16(dgvTerceros.CurrentRow.Cells["ID"].Value.ToString()));
				var frmTercero = new FrmTercero(tercero);
				if(frmTercero.ShowDialog() == DialogResult.Yes) {
					CargarTerceros();
				}
			}
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (dgvTerceros.SelectedRows.Count > 0) {
				Tercero tercero = Tercero.FindByID(Convert.ToInt16(dgvTerceros.CurrentRow.Cells["ID"].Value.ToString()));
				if (MessageBox.Show("¿Esta seguro de eliminar el tercero?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
					tercero.Eliminado = true;
					tercero.FechaModificacion = DateTime.Now;
					tercero.Delete();
					MessageBox.Show("Articulo eliminado con exito!",  Application.ProductName , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					CargarTerceros();
					return;
				}
				
			}
		}		
	}
}
