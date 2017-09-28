/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 11:28
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
	/// Description of FrmEmpleado.
	/// </summary>
	public partial class FrmEmpleado : Form
	{
		int accion = 0;
		public Empleado Empleado { set; get; }
		
		void Empleado2Form()
		{
			txtCodigo.Text = Empleado.Codigo;
			txtNombreCompleto.Text = Empleado.NombreCompleto;
		}
		void Form2Empleado()
		{
			Empleado.Codigo = txtCodigo.Text.Trim();
			Empleado.NombreCompleto = txtNombreCompleto.Text.Trim();
		}
		bool Validar()
		{
			bool validado = true;
			if(txtCodigo.Text.Trim() == string.Empty){
				lblInfo.Text = "Digite el codigo";
				validado = false;
			}else if(txtNombreCompleto.Text.Trim() == string.Empty){
				lblInfo.Text = "Digite el nombre";
				validado = false;
			}				
			return validado;
		}
		
		public FrmEmpleado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Empleado = new Empleado();
			Empleado.FechaCreacion = DateTime.Now;
			Empleado.Eliminado = false;
			accion = 1;
			Text = "Crear Nuevo Empleado";
		}
		public FrmEmpleado(Empleado emp)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Empleado = emp;
			Empleado.FechaModificacion = DateTime.Now;
			Empleado.Eliminado = false;
			accion = 2;
			Text = "Modificar Empleado";
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Form2Empleado();
				switch (accion) {
					case 1:
						Empleado.Save();
						break;
					case 2:
						Empleado.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}
		void FrmEmpleadoLoad(object sender, EventArgs e)
		{
			if(accion == 2) Empleado2Form();
		}		
	}
}
