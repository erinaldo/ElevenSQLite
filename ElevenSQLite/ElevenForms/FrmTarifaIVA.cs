/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:04
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
	/// Description of FrmTarifaIVA.
	/// </summary>
	public partial class FrmTarifaIVA : Form
	{
		public TarifaIVA TarifaIVA { set; get; }
		int accion = 0;
				
		public FrmTarifaIVA()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			TarifaIVA = new TarifaIVA();
			TarifaIVA.FechaCreacion = DateTime.Now;
			TarifaIVA.Eliminado = false;
			accion = 1;
			Text = "Crear Nueva Tarifa de IVA";
		}
		public FrmTarifaIVA(TarifaIVA tIva)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			TarifaIVA = tIva;
			TarifaIVA.FechaModificacion = DateTime.Now;
			TarifaIVA.Eliminado = false;
			accion = 2;
			Text = "Crear Nueva Tarifa de IVA";
		}
		
		void TarifaIVA2Form()
		{
			txtValor.Text = TarifaIVA.Tarifa.ToString();
		}
		void Form2TarifaIVA()
		{
			TarifaIVA.Tarifa = float.Parse(txtValor.Text.Trim());
		}
		bool Validar()
		{
			bool validado = true;
			if(txtValor.Text.Trim() == string.Empty){
				lblInfo.Text = "Digite el valor";
				validado = false;
			}
			return validado;
		}
		void FrmTarifaIVALoad(object sender, EventArgs e)
		{
			if(accion ==2) TarifaIVA2Form();
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(Validar()){
				Form2TarifaIVA();
				switch (accion) {
					case 1:
						TarifaIVA.Save();
						break;
					case 2:
						TarifaIVA.Update();
						break;
				}
				DialogResult = DialogResult.Yes;
				Close();
			}
		}
	}
}
