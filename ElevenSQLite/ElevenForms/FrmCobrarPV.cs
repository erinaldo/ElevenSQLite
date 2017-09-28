/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;
using ElevenSQLite.ElevenUtils;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmCobrarPV.
	/// </summary>
	public partial class FrmCobrarPV : Form
	{
		public Empresa Empresa { get; set; }

		public Preferencias Preferencias { get; set; }
		public TipoDocumento TipoDocumento { get; set; }
		public Documento Documento { get; set; }
		private string FORMATO_DECIMAL;
		private decimal cambio;
		
		public FrmCobrarPV()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void FormCobrarPV_Load(object sender, EventArgs e)
		{
			this.cbFormaPago.SelectedIndex = 0;
			this.FORMATO_DECIMAL = "{0:N" + this.TipoDocumento.CantidadDecimal + "}";
			this.txtTotal.Text = string.Format(this.FORMATO_DECIMAL, this.Documento.Total);
			this.txtEntregado.Text = Convert.ToString(this.Documento.Total);
			this.txtEntregado.Focus();
			this.txtEntregado.SelectAll();
		}

		private void txtEntregado_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}

		private void txtEntregado_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r' || e.KeyChar == '\t') {
				e.Handled = true;
				try {
					this.cambio = Convert.ToDecimal(this.txtEntregado.Text) - this.Documento.Total;
				}
				catch {
					this.cambio = 0m;
				}
				this.txtCambio.Text = string.Format(this.FORMATO_DECIMAL, this.cambio);
				this.cbFormaPago.Focus();
			}
			if (e.KeyChar == '\u001b') {
				base.Close();
			}
		}

		private void txtEntregado_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}

		private void cbFormaPago_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}

		private void cbFormaPago_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r') {
				e.Handled = true;
				SendKeys.Send("{TAB}");
			}
			if (e.KeyChar == '\u001b') {
				base.Close();
			}
		}

		private void cbFormaPago_Layout(object sender, LayoutEventArgs e)
		{
		}

		private void cbFormaPago_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			this.GrabarDocumento();
			this.AbrirCajonMonedero();
			if (this.Preferencias.ImprimirTirilla) {
				this.ImprimirTirilla();
			}
			base.Close();
		}

		private void AbrirCajonMonedero()
		{
			if (this.Preferencias.ActivarCajonMonedero) {
				CajonMonedero cajonMonedero = new CajonMonedero(this.Preferencias.PuertoSalida, this.Preferencias.CodigoCajonMonedero);
				cajonMonedero.AbrirCajonMonedero();
			}
		}

		private void ImprimirTirilla()
		{
			Ticket ticket = new Ticket();
			ticket.AddHeaderLine(this.Centrar(this.Empresa.RazonSocial, ticket.MaxChar));
			ticket.AddHeaderLine(this.Centrar(this.Empresa.Nit, ticket.MaxChar));
			ticket.AddHeaderLine(this.Centrar(this.Empresa.Direccion, ticket.MaxChar));
			ticket.AddHeaderLine(this.Centrar("TEL. " + this.Empresa.TelefonoPrincipal, ticket.MaxChar));
			ticket.AddHeaderLine(this.Centrar("Email: " + this.Empresa.Email, ticket.MaxChar));
			ticket.AddHeaderLine("");
			if (this.TipoDocumento.TipoFacturacion == Tercero.REGIMEN_SIMPLIFICADO) {
				ticket.AddHeaderLine(this.Centrar("REGIMEN SIMPLIFICADO", ticket.MaxChar));
			}
			else {
				ticket.AddHeaderLine(this.Centrar("IVA REGIMEN COMUN", ticket.MaxChar));
			}
			ticket.AddHeaderLine(this.Centrar("AGENTE NO RETENEDOR DE IVA", ticket.MaxChar));
			ticket.AddHeaderLine("");
			ticket.AddHeaderLine(this.Centrar("FACTURACION POR SISTEMA POS", ticket.MaxChar));
			ticket.AddHeaderLine("");
			ticket.AddHeaderLine("FACTURA # " + TipoDocumento.Get(this.Documento.TipoDocumentoID).Prefijo + string.Format("{0:" + this.CalcularCerosIzquierda(TipoDocumento.Get(this.Documento.TipoDocumentoID).CerosIzquierda) + "}", this.Documento.Consecutivo));
			ticket.AddHeaderLine("FECHA:" + DateTime.Now.ToString("yyyy/MM/dd") + "    HORA:" + DateTime.Now.ToShortTimeString());
			foreach (DetalleDocumento current in this.Documento.Detalles) {
				if (Entorno.IS_VALID_LICENCE) {
					string item = "true";
					if (item != string.Empty && Convert.ToBoolean(item)) {
						ticket.AddItem(Convert.ToString(current.Cantidad), current.Descripcion, string.Format(this.FORMATO_DECIMAL, current.Total));
					}
					else {
						ticket.AddItem(Convert.ToString(current.Cantidad), "NO HAY LICENCIA", string.Format(this.FORMATO_DECIMAL, current.Total));
					}
				}
				else {
					ticket.AddItem(Convert.ToString(current.Cantidad), "NO HAY LICENCIA", string.Format(this.FORMATO_DECIMAL, current.Total));
				}
			}
			ticket.AddTotal("SUBTOTAL", string.Format(this.FORMATO_DECIMAL, this.Documento.SubTotal));
			ticket.AddTotal("IVA", string.Format(this.FORMATO_DECIMAL, this.Documento.TotalIva));
			ticket.AddTotal("TOTAL", string.Format(this.FORMATO_DECIMAL, this.Documento.Total));
			ticket.AddTotal("", "");
			ticket.AddTotal("RECIBIDO", string.Format(this.FORMATO_DECIMAL, Convert.ToDecimal(this.txtEntregado.Text)));
			ticket.AddTotal("CAMBIO", string.Format(this.FORMATO_DECIMAL, this.cambio));
			if (this.TipoDocumento.TipoFacturacion == Tercero.REGIMEN_COMUN) {
				ticket.AddFooterLine("FACTURA AUTORIZADA RES" + this.TipoDocumento.Autorizacion);
				ticket.AddFooterLine(string.Concat(new string[] {
					"DE ",
					this.TipoDocumento.FechaAutorizacion.Value.ToString("yyyy/MM/dd"),
					" DEL ",
					this.TipoDocumento.NumeracionDianDesde,
					" AL ",
					this.TipoDocumento.NumeracionDianHasta
				}));
			}
			ticket.AddFooterLine("");
			ticket.AddFooterLine("LE ATENDIO: " + Entorno.USUARIO.NombreUsuario);
			ticket.AddFooterLine("");
			ticket.AddFooterLine(this.Centrar("... GRACIAS POR SUS COMPRAS ...", ticket.MaxChar));
			ticket.PrintTicket(this.Preferencias.ImpresoraPredeterminada);
		}

		private string Centrar(string p, int max)
		{
			int num = (max - p.Length) / 2;
			string str = "";
			for (int i = 0; i < num; i++) {
				str += " ";
			}
			return str + p;
		}

		private void GrabarDocumento()
		{			
			this.Documento.Observacion = this.cbFormaPago.Text;
			this.Documento.UsuarioID = Entorno.USUARIO.ID;
			if (this.Documento.ID == 0) {
				this.TipoDocumento = TipoDocumento.Get(this.TipoDocumento.ID);
				this.Documento.Consecutivo = this.TipoDocumento.ConsecutivoActual;
				Documento.Save();
				this.TipoDocumento.ConsecutivoActual++;
				TipoDocumento.Update();
			}
		}

		private void txtCambio_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}

		private void txtCambio_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r') {
				e.Handled = true;
				SendKeys.Send("{TAB}");
			}
			if (e.KeyChar == '\u001b') {
				base.Close();
			}
		}

		private void txtCambio_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}

		private void txtTotal_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}

		private void txtTotal_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) {
				e.Handled = true;
			}
		}

		private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r') {
				e.Handled = true;
				SendKeys.Send("{TAB}");
			}
		}

		private string CalcularNumeroDecimal(int p)
		{
			string text = ".";
			for (int i = 0; i < p; i++) {
				text += "#";
			}
			return text;
		}

		private string CalcularCerosIzquierda(int p)
		{
			string text = "";
			for (int i = 0; i < p; i++) {
				text += "0";
			}
			return text;
		}
	}
}
