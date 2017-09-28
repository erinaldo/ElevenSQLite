/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:23
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
	/// Description of FrmTipoMoneda.
	/// </summary>
	public partial class FrmTipoMoneda : Form
	{
		public TipoMoneda TipoMoneda { set; get; }
		int accion = 0;
		
		public FrmTipoMoneda()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			TipoMoneda = new TipoMoneda();
			TipoMoneda.FechaCreacion = DateTime.Now;
			TipoMoneda.Eliminado = false;
			Text = "Crear Moneda";
			accion = 1;
		}
		public FrmTipoMoneda(TipoMoneda tm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			TipoMoneda = tm;
			TipoMoneda.FechaModificacion = DateTime.Now;
			TipoMoneda.Eliminado = false;
			Text = "Modificar Moneda";
			accion = 2;
		}
		public void TipoMoneda2Form()
		{
			this.txtCodigo.Text = TipoMoneda.Codigo;
			this.txtDescripcion.Text = TipoMoneda.Descripcion;
		}
		public void Form2TipoMoneda()
		{
			TipoMoneda.Codigo = this.txtCodigo.Text;
			TipoMoneda.Descripcion = this.txtDescripcion.Text;
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
		void FrmTipoMonedaLoad(object sender, EventArgs e)
		{
			if(accion == 2)TipoMoneda2Form();
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Form2TipoMoneda();
				switch (accion) {
					case 1:
						TipoMoneda.Save();
						break;
					case 2:
						TipoMoneda.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}
	}
}
