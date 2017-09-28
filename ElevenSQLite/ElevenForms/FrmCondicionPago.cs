/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:43
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
	/// Description of FrmCondicionPago.
	/// </summary>
	public partial class FrmCondicionPago : Form
	{
		public CondicionPago CondicionPago { set; get;  }
		int accion = 0;
		
		public FrmCondicionPago()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			CondicionPago = new CondicionPago();
			CondicionPago.FechaCreacion = DateTime.Now;
			CondicionPago.Eliminado = false;
			accion = 1;
			Text = "Crear Nueva Condicion de Pago";
		}
		public FrmCondicionPago(CondicionPago cp)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			CondicionPago = cp;
			CondicionPago.FechaModificacion = DateTime.Now;
			CondicionPago.Eliminado = false;
			accion = 2;
			Text = "Modificar Condicion de Pago";
		}
		bool Validar()
		{
			bool validado = true;
			if(txtDescripcion.Text.Trim() == string.Empty){
				lblInfo.Text = "Digite la descripcion";
				validado = false;
			}else if(numDias.Text.Trim() == string.Empty){
				lblInfo.Text = "Digite el numero de dias";
				validado = false;
			}				
			return validado;
		}
		void CondicionPago2Form()
		{
			this.txtDescripcion.Text = CondicionPago.Descripcion;
			this.numDias.Value = CondicionPago.Dias;
		}	
		void Form2CondicionPago()
		{
			CondicionPago.Descripcion = txtDescripcion.Text;
			CondicionPago.Dias = (int)numDias.Value;
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Form2CondicionPago();
				switch (accion) {
					case 1:
						CondicionPago.Save();
						break;
					case 2:
						CondicionPago.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}
		void FrmCondicionPagoLoad(object sender, EventArgs e)
		{
			if(accion == 2) CondicionPago2Form();
		}	
	}
}
