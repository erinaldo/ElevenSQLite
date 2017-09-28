/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:36
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
	/// Description of FrmFamilia.
	/// </summary>
	public partial class FrmFamilia : Form
	{
		public Familia Familia { set; get;}
		int accion = 0;
		
		public FrmFamilia()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Familia = new Familia();
			Familia.FechaCreacion = DateTime.Now;
			Familia.Eliminado = false;
			accion = 1;
			Text = "Crear Nueva Familia";
		}
		public FrmFamilia(Familia fam)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Familia = fam;
			Familia.FechaModificacion = DateTime.Now;
			Familia.Eliminado = false;
			accion = 2;
			Text = "Modificar Familia";
		}
		void Familia2Form()
		{
			this.txtCodigo.Text = Familia.Codigo;
			this.txtDescripcion.Text = Familia.Descripcion;
		}
		void Form2Familia()
		{
			Familia.Codigo = txtCodigo.Text;
			Familia.Descripcion = txtDescripcion.Text;
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
		void FrmFamiliaLoad(object sender, EventArgs e)
		{
			if(accion == 2) Familia2Form();
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Form2Familia();
				switch (accion) {
					case 1:
						Familia.Save();
						break;
					case 2:
						Familia.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}
		
	}
}
