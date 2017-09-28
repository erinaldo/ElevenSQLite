/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 13:54
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
	/// Description of FrmPais.
	/// </summary>
	public partial class FrmPais : Form
	{
		public Pais Pais {set; get;}
		int accion = 0;
			
		public FrmPais()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Pais = new Pais();
			Pais.FechaCreacion = DateTime.Now;
			Pais.Eliminado = false;
			Text = "Crear Nuevo Pais";
			accion = 1;
		}
		public FrmPais(Pais p)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Pais = p;
			Pais.FechaModificacion = DateTime.Now;
			Pais.Eliminado = false;
			Text = "Modificar Pais";
			accion = 2;
		}
		void Pais2Form()
		{
			this.txtCodigo.Text = Pais.Codigo;
			this.txtDescripcion.Text = Pais.Descripcion;
		}
		void Form2Pais()
		{
			Pais.Codigo = this.txtCodigo.Text;
			Pais.Descripcion = this.txtDescripcion.Text;
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
		void FrmPaisLoad(object sender, EventArgs e)
		{
			if(accion ==2) Pais2Form();
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Form2Pais();
				switch (accion) {
					case 1:
						Pais.Save();
						break;
					case 2:
						Pais.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}

		
	}
}
