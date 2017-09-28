/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 15:31
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
	/// Description of FormBanco.
	/// </summary>
	public partial class FrmBanco : Form
	{
		public Banco Banco { get; set; }
		int accion = 0;
		
		public FrmBanco()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			accion = 1;
			Banco = new Banco();
			Banco.FechaCreacion = DateTime.Now;
			Banco.Eliminado = false;
		}
		public FrmBanco(Banco ban)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			accion = 2;
			Banco = ban;
			Banco.FechaModificacion = DateTime.Now;
			Banco.Eliminado = false;
		}
		void FrmBanco_Load(object sender, EventArgs e)
		{
			if(accion == 2)Banco2Form();
		}

		public void Banco2Form()
		{
			txtDescripcion.Text = Banco.Descripcion;
		}
		public void Form2Banco()
		{
			Banco.Descripcion = txtDescripcion.Text.Trim();
		}
		bool Validar()
		{
			bool validado = true;
			if(txtDescripcion.Text.Trim() == string.Empty){
				lblInfo.Text = "Digite la descripcion";
				validado = false;
			}
			return validado;
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Form2Banco();
				switch (accion) {
					case 1:
						Banco.Save();
						break;
					case 2:
						Banco.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}
	}
}
