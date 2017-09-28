/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:32
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
	/// Description of FrmEstado.
	/// </summary>
	public partial class FrmEstado : Form
	{
		public Estado Estado { set; get;}
		int accion = 0;
		
		public FrmEstado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Estado = new Estado();
			Estado.FechaCreacion = DateTime.Now;
			Estado.Eliminado = false;
			accion = 1;
			Text = "Crear Nuevo Estado";
		}
		public FrmEstado(Estado est)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Estado = est;
			Estado.FechaModificacion = DateTime.Now;
			Estado.Eliminado = false;
			accion = 2;
			Text = "Modificar Estado";
		}
		void CargarPais()
		{
			this.cbPais.DataSource = Pais.GetAll();
			this.cbPais.DisplayMember = "Descripcion";
			this.cbPais.ValueMember = "Id";
		}

		void Estado2Form()
		{
			this.txtCodigo.Text = Estado.Codigo;
			this.txtDescripcion.Text = Estado.Descripcion;
			this.cbPais.SelectedValue = Estado.PaisID;
			
		}
		void Form2Estado()
		{
			Estado.Codigo = txtCodigo.Text;
			Estado.Descripcion = txtDescripcion.Text;
			Estado.PaisID = (cbPais.SelectedItem as Pais).ID;
		}
		bool Validar()
		{
			bool validado = true;
			if(txtCodigo.Text.Trim() == string.Empty){
				lblInfo.Text = "Digite el Codigo";
				validado = false;
			}else if(txtDescripcion.Text.Trim() == string.Empty){
				lblInfo.Text = "Digite la descripcion";
				validado = false;
			}
			return validado;
		}

		private void cbPais_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			this.txtCodigo.Text = string.Empty;
			this.txtDescripcion.Text = string.Empty;
		}
		void FrmEstadoLoad(object sender, EventArgs e)
		{
			CargarPais();
			if(accion == 2) Estado2Form();
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Form2Estado();
				switch (accion) {
					case 1:
						Estado.Save();
						break;
					case 2:
						Estado.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}
	}
}
