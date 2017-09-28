/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:19 p. m.
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
	/// Description of FrmComboRetencion.
	/// </summary>
	public partial class FrmComboRetencion : Form
	{
		public string TarifaRetencion {	get; set; }
		public FrmComboRetencion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void FormComboRetencion_Load(object sender, EventArgs e)
		{
			this.cbTarifaRetencion.DataSource = ElevenCore.TarifaRetencion.GetAll();
			this.cbTarifaRetencion.DisplayMember = "Tarifa";
			this.cbTarifaRetencion.ValueMember = "Id";
			this.cbTarifaRetencion.SelectedIndex = this.cbTarifaRetencion.FindStringExact(this.TarifaRetencion);
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			this.TarifaRetencion = Convert.ToString(((TarifaRetencion)this.cbTarifaRetencion.SelectedItem).Tarifa);
			base.DialogResult = DialogResult.OK;
			base.Close();
		}
	}
}
