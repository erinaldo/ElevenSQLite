/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 13:58
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
	/// Description of FrmSeccion.
	/// </summary>
	public partial class FrmSeccion : Form
	{
		public Seccion Seccion { set; get;}
		int accion = 0;
		
		public FrmSeccion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			accion = 1;
			Text = "Crear Nueva Seccion";
			Seccion = new Seccion();
			Seccion.FechaCreacion = DateTime.Now;
			Seccion.Eliminado = false;
		}
		public FrmSeccion(Seccion sec)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			accion = 2;
			Text = "Modificar Seccion";
			Seccion = sec;
			Seccion.FechaModificacion = DateTime.Now;
			Seccion.Eliminado = false;
		}
		void CargarFamilia()
		{
			cbFamilia.Refresh();			
			cbFamilia.DataSource =Familia.GetAll();
			cbFamilia.DisplayMember = "Descripcion";			
			cbFamilia.ValueMember = "ID";
		}
		void Seccion2Form()
		{
			txtCodigo.Text = Seccion.Codigo;
			txtDescripcion.Text = Seccion.Descripcion;
			cbFamilia.SelectedValue = Seccion.FamiliaID;
		}
		void Form2Seccion()
		{
			Seccion.Codigo = txtCodigo.Text;
			Seccion.Descripcion = txtDescripcion.Text;
			Seccion.FamiliaID = (cbFamilia.SelectedItem as Familia).ID;
		}
		bool Validar()
		{
			bool validado = true;
			if (txtCodigo.Text != null) {
				if (txtCodigo.Text.Length <= 10) {
					Seccion.Codigo = txtCodigo.Text;
				}
				else {
					lblInfo.Text = "El codigo debe ser inferior a 10 caracteres!";
					validado = false;
				}
			}
			else {
				lblInfo.Text ="El codigo es requerido!\n";
				validado = false;
			}
			if (txtDescripcion.Text != null) {
				Seccion.Descripcion = txtDescripcion.Text;
			}
			else {
				validado = false;
				lblInfo.Text ="La descripción es requerida!\n";
			}
			Seccion.FamiliaID = (cbFamilia.SelectedItem as Familia).ID;			
			return validado;
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Seccion2Form();
				switch (accion) {
					case 1:
						Seccion.Save();
						break;
					case 2:
						Seccion.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}
		void FrmSeccionLoad(object sender, EventArgs e)
		{
			CargarFamilia();
			if(accion == 2 ) Seccion2Form();
		}
		
		
	}
}
