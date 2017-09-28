/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;
using ElevenSQLite.ElevenUtils;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmAnularComprobante.
	/// </summary>
	public partial class FrmAnularComprobante : Form
	{
		public Comprobante Comprobante { get; set; }
		
		public FrmAnularComprobante()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void FormAnularComprobante_Load(object sender, EventArgs e)
		{
			this.lbTipoDocumento.Text = TipoDocumento.Get(Comprobante.TipoDocumentoID).Descripcion.ToUpper();
			this.lbConsecutivo.Text = string.Format("{0:" + this.CalcularCerosIzquierda( TipoDocumento.Get(Comprobante.TipoDocumentoID).CerosIzquierda) + "}", this.Comprobante.Consecutivo);
			this.checkEliminar.Enabled = false;
			TipoDocumento tipoDocumento = TipoDocumento.Get(this.Comprobante.TipoDocumentoID);
			if (tipoDocumento.ConsecutivoActual - 1 == this.Comprobante.Consecutivo) {
				this.checkEliminar.Enabled = true;
			}
		}

		private string CalcularCerosIzquierda(int p)
		{
			string text = "";
			for (int i = 0; i < p; i++) {
				text += "0";
			}
			return text;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			this.Comprobante.FechaAnulacion = new DateTime?(DateTime.Now);
			foreach (DetalleComprobante current in this.Comprobante.Detalles) {
				if (current.Documento != null) {
					Documento documento = current.Documento;
					//this.ddao.Load(documento);
					documento.TotalAbono -= current.Total + current.Retencion + current.Descuento;
					if (documento.TotalAbono <= 0m) {
						documento.TotalAbono = 0m;
						documento.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.FACTURADO).ID;
					}
					else {
						documento.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO_PARCIALMENTE).ID;
					}
					documento.Update();;
				}
			}
			if (this.checkEliminar.Checked) {
				TipoDocumento tipoDocumento = TipoDocumento.Get(Comprobante.TipoDocumentoID);
				//this.tdao.Load(tipoDocumento);
				if (tipoDocumento.ConsecutivoActual - 1 == this.Comprobante.Consecutivo) {
					tipoDocumento.ConsecutivoActual--;
					tipoDocumento.Update();
					Comprobante.Delete();
					MessageBox.Show("Comprobante se elimino con exito!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					base.Close();
					return;
				}
			}
			if (this.Comprobante.Observacion != string.Empty) {
				Comprobante expr_191 = this.Comprobante;
				expr_191.Observacion += Environment.NewLine;
			}
			Comprobante expr_1AC = this.Comprobante;
			expr_1AC.Observacion += "ANULADA";
			if (this.txtMotivo.Text != string.Empty) {
				Comprobante expr_1DE = this.Comprobante;
				expr_1DE.Observacion = expr_1DE.Observacion + " Motivo:" + this.txtMotivo.Text;
			}
			this.Comprobante.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO).ID;
			Comprobante.Update();
			MessageBox.Show("Documento se anulo con exito!", "SoluPYME " + Entorno.VERSION, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			base.Close();
		}
	}
}
