/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:26
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
	/// Description of FrmUnidadComercial.
	/// </summary>
	public partial class FrmUnidadComercial : Form
	{
		int accion = 0;
		public UnidadComercial UnidadMedida { set; get; }
		
		public FrmUnidadComercial()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			accion = 1;
			UnidadMedida = new UnidadComercial();
			UnidadMedida.FechaCreacion = DateTime.Now;
			UnidadMedida.Eliminado = false;
			Text = "Crear Nueva Unidad de Medida";
		}
		public FrmUnidadComercial(UnidadComercial unidad)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			accion = 2;
			UnidadMedida = unidad;
			UnidadMedida.FechaModificacion = DateTime.Now;
			UnidadMedida.Eliminado = false;
			Text = "Modificar Unidad de Medida";
		}
		void UnidadComercial2Form()
		{
			this.txtDescripcion.Text = UnidadMedida.Descripcion;
			this.txtCodigo.Text = UnidadMedida.Codigo;
		}
		void Form2UnidadComercial()
		{
			UnidadMedida.Descripcion = this.txtDescripcion.Text;
			UnidadMedida.Codigo = this.txtCodigo.Text;
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
		private void FrmUnidadMedida_Load(object sender, EventArgs e)
		{
			if(accion == 2) UnidadComercial2Form();
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Form2UnidadComercial();
				switch (accion) {
					case 1:
						UnidadMedida.Save();
						break;
					case 2:
						UnidadMedida.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}

		
	}
}
