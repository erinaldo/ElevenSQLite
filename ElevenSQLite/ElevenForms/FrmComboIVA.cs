/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:28 p. m.
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
	/// Description of FrmComboIVA.
	/// </summary>
	public partial class FrmComboIVA : Form
	{
		public string TarifaIVA { get; set;	}
		
		public FrmComboIVA()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void FormComboIVA_Load(object sender, EventArgs e)
		{
			this.cbTarifaIVA.DataSource = ElevenCore.TarifaIVA.GetAll();
			this.cbTarifaIVA.DisplayMember = "Tarifa";
			this.cbTarifaIVA.ValueMember = "Id";
			this.cbTarifaIVA.SelectedIndex = this.cbTarifaIVA.FindStringExact(this.TarifaIVA);
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			this.TarifaIVA = Convert.ToString(((TarifaIVA)this.cbTarifaIVA.SelectedItem).Tarifa);
			base.DialogResult = DialogResult.OK;
			base.Close();
		}
	}
}
