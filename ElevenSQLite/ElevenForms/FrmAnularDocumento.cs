/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 15:14
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
	/// Description of FrmAnularDocumento.
	/// </summary>
	public partial class FrmAnularDocumento : Form
	{
		public Documento Documento { get; set; }
		public FrmAnularDocumento(Documento doc)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Documento = doc;
		}
		void FormAnularDocumento_Load(object sender, EventArgs e)
		{
			lbTipoDocumento.Text = TipoDocumento.Get( Documento.TipoDocumentoID).Descripcion.ToUpper();
			lbConsecutivo.Text = string.Format("{0:" + CalcularCerosIzquierda(TipoDocumento.Get(Documento.TipoDocumentoID).CerosIzquierda) + "}", Documento.Consecutivo);
			checkEliminar.Enabled = false;
			TipoDocumento tipoDocumento = TipoDocumento.Get(Documento.TipoDocumentoID);
			if (tipoDocumento.ConsecutivoActual - 1 == Documento.Consecutivo) {
				checkEliminar.Enabled = true;
			}
		}

		void btnAceptar_Click(object sender, EventArgs e)
		{
			Documento.FechaAnulacion = new DateTime?(DateTime.Now);
			TipoDocumento tipoDocumento = TipoDocumento.Get(Documento.TipoDocumentoID);
			if (checkEliminar.Checked && tipoDocumento.ConsecutivoActual - 1 == Documento.Consecutivo) {
				tipoDocumento.ConsecutivoActual--;
				tipoDocumento.Update();
				updateArticulo();
				Documento.Delete();
				MessageBox.Show("Documento se elimino con exito!", Application.ProductName , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (Documento.Observacion != string.Empty) {
				Documento expr_11C = Documento;
				expr_11C.Observacion += Environment.NewLine;
			}
			Documento expr_137 = Documento;
			expr_137.Observacion += "ANULADA";
			if (txtMotivo.Text != string.Empty) {
				Documento expr_169 = Documento;
				expr_169.Observacion = expr_169.Observacion + " Motivo:" + txtMotivo.Text;
			}
			Documento.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO).ID;
			updateArticulo();
			Documento.Update();
			MessageBox.Show("Documento se anulo con exito!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		void updateArticulo()
		{
			if ( TipoDocumento.Get(Documento.TipoDocumentoID).Factor == TipoDocumento.FACTOR_SUMA || TipoDocumento.Get(Documento.TipoDocumentoID).Factor == TipoDocumento.FACTOR_RESTA) {
				foreach (DetalleDocumento current in Documento.Detalles) {
					Articulo articulo = Articulo.Get(current.ArticuloID);
					if (TipoDocumento.Get(Documento.TipoDocumentoID).Factor == TipoDocumento.FACTOR_SUMA && !articulo.Servicio) {
						articulo.StockActual -= current.Cantidad;
						articulo.StockDisponible -= current.Cantidad;
					}
					if (TipoDocumento.Get(Documento.TipoDocumentoID).Factor == TipoDocumento.FACTOR_RESTA && !articulo.Servicio) {
						articulo.StockActual += current.Cantidad;
						articulo.StockDisponible += current.Cantidad;
					}
					articulo.Update();
				}
			}
		}

		string CalcularCerosIzquierda(int p)
		{
			string text = "";
			for (int i = 0; i < p; i++) {
				text += "0";
			}
			return text;
		}
	}
}
