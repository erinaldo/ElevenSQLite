/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:17
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
	/// Description of FrmCiudad.
	/// </summary>
	public partial class FrmCiudad : Form
	{
		public Ciudad Ciudad {set; get;}
		int accion = 0;
		
		public FrmCiudad()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Ciudad = new Ciudad();
			Ciudad.FechaCreacion = DateTime.Now;
			Ciudad.Eliminado = false;
			accion = 1;
			Text = "Crear Nueva Ciudad";
		}
		public FrmCiudad(Ciudad ciu)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Ciudad = ciu;
			Ciudad.FechaModificacion = DateTime.Now;
			Ciudad.Eliminado = false;
			accion = 2;
			Text = "Modificar Ciudad";
		}
		
		public void Ciudad2Form()
		{
			this.txtCodigo.Text = this.Ciudad.Codigo;
			this.txtDescripcion.Text = this.Ciudad.Descripcion;
			Estado estado = Estado.Get(this.Ciudad.EstadoID.GetValueOrDefault());
			this.cbPais.SelectedValue = estado.PaisID;
			this.cbEstado.SelectedValue = estado.ID;
		}
		public void Form2Ciudad()
		{
			this.Ciudad.Codigo = this.txtCodigo.Text.Trim();
			this.Ciudad.Descripcion = this.txtDescripcion.Text.Trim();
			Estado estado = Estado.Get(this.Ciudad.EstadoID.GetValueOrDefault());
			Ciudad.EstadoID = (cbEstado.SelectedItem as Estado).ID;
			
		}
		private void CargarPais()
		{
			this.cbPais.DataSource = Pais.GetAll();
			this.cbPais.DisplayMember = "Descripcion";
			this.cbPais.ValueMember = "ID";
		}

		private void CargarEstado()
		{
			this.cbEstado.DataSource = Estado.GetAllByPais((this.cbPais.SelectedItem as Pais));
			this.cbEstado.DisplayMember = "Descripcion";
			this.cbEstado.ValueMember = "Id";
		}
		private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
		{
			CargarEstado();
			this.txtCodigo.Text = string.Empty;
			this.txtDescripcion.Text = string.Empty;
		}
		bool Validar()
		{
			bool validado = true;
			if(txtCodigo.Text.Trim() == string.Empty){
				lblInfo.Text = "Digite el codigo";
				validado = false;
			}else if(txtDescripcion.Text.Trim() == string.Empty){
				lblInfo.Text = "Digite la descripicion";
				validado = false;
			}
			return validado;
		}
		void FrmCiudadLoad(object sender, EventArgs e)
		{
			CargarPais();
			if(accion ==2) Ciudad2Form();
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Form2Ciudad();
				switch (accion) {
					case 1:
						Ciudad.Save();
						break;
					case 2:
						Ciudad.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}
	}
}
