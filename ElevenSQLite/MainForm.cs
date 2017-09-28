/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 6:09 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;
using ElevenSQLite.ElevenUtils;
using ElevenSQLite.ElevenForms;


namespace ElevenSQLite
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private const int CP_NOCLOSE_BUTTON = 0x200;
		protected override CreateParams CreateParams
		{
		    get
		    {
		     	CreateParams myCp = base.CreateParams;
		     	myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON ;
		     	return myCp;
		    }
		} 
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			Text = string.Format("{0} Version : {1}", Application.ProductName, Application.ProductVersion);
			
			if(Empresa.ExisteEmpresa()){
				Entorno.EMPRESA = Empresa.Get();
				lblInfo.Text = string.Format("Razon Social :{0} Nit : {1} {2:dd/MM/yyyy hh:mm:ss tt}", Entorno.EMPRESA.RazonSocial, Entorno.EMPRESA.Nit, DateTime.Now);
				lblData.Text = string.Format("Ruta Datos : {0}\\Data.db", Application.StartupPath );
				lblUsuario.Text = string.Format("Usuario : {0}", "SESION NO INICIADA");
				timer1.Enabled = true;
				var frmLogin = new FrmLogin();
				if(frmLogin.ShowDialog() == DialogResult.Cancel)
				{
					Application.Exit();
				}
				lblUsuario.Text = string.Format("Usuario : {0}", Entorno.USUARIO.NombreUsuario);
			}else{
				var nuevaEmpresa = new NuevaEmpresa();
				nuevaEmpresa.LlenarDB();
				nuevaEmpresa.Sistema();
				nuevaEmpresa.Permisos();
				Application.Restart();
			}
			
			
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			lblInfo.Text = string.Format("Razon Social :{0} Nit : {1} {2:dd/MM/yyyy hh:mm:ss tt}", Entorno.EMPRESA.RazonSocial, Entorno.EMPRESA.Nit, DateTime.Now);
			
		}
		void RibbonButtonArticulosClick(object sender, EventArgs e)
		{
			foreach (Form f in MdiChildren)
	         {
	            if (f.GetType() == typeof(FrmPanelArticulos))
	            {
	               f.Activate();
	               return;
	            }
	         }
	         Form form = new FrmPanelArticulos();
	         form.MdiParent = this;
	         form.Show();
		}
		void RibbonButtonTercerosClick(object sender, EventArgs e)
		{
			foreach (Form f in MdiChildren)
	         {
	            if (f.GetType() == typeof(FrmPanelTerceros))
	            {
	               f.Activate();
	               return;
	            }
	         }
	         Form form = new FrmPanelTerceros();
	         form.MdiParent = this;
	         form.Show();
		}
		void RibbonButtonDocumentosClick(object sender, EventArgs e)
		{
			foreach (Form f in MdiChildren)
	         {
	            if (f.GetType() == typeof(FrmPanelDocumentos))
	            {
	               f.Activate();
	               return;
	            }
	         }
	         Form form = new FrmPanelDocumentos();
	         form.MdiParent = this;
	         form.Show();
		}
		void RibbonButtonComprobantesClick(object sender, EventArgs e)
		{
			foreach (Form f in MdiChildren)
	         {
	            if (f.GetType() == typeof(FrmPanelComprobantes))
	            {
	               f.Activate();
	               return;
	            }
	         }
	         Form form = new FrmPanelComprobantes();
	         form.MdiParent = this;
	         form.Show();
		}
		void RibbonButtonSalirClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show(Owner, "Desea salir?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dr == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
		void RibbonButtonMaestrosClick(object sender, EventArgs e)
		{
			foreach (Form f in MdiChildren)
	         {
	            if (f.GetType() == typeof(FrmPanelMaestros))
	            {
	               f.Activate();
	               return;
	            }
	         }
	         Form form = new FrmPanelMaestros();
	         form.MdiParent = this;
	         form.Show();
		}
		void RibbonButtonPreferenciasClick(object sender, EventArgs e)
		{
			var frmPreferencias = new FrmPreferencias();
			if(frmPreferencias.ShowDialog(this) == DialogResult.OK){
				Entorno.EMPRESA = Empresa.Get();
				lblInfo.Text = string.Format("Razon Social :{0} Nit : {1} {2:dd/MM/yyyy hh:mm:ss tt}", Entorno.EMPRESA.RazonSocial, Entorno.EMPRESA.Nit, DateTime.Now);
				lblData.Text = string.Format("Ruta Datos : {0}\\Data.db", Application.StartupPath );
				lblUsuario.Text = string.Format("Usuario : {0}", "SESION NO INICIADA");
				lblUsuario.Text = string.Format("Usuario : {0}", Entorno.USUARIO.NombreUsuario);
			}
		}
	}
}
