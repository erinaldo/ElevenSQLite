/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 9:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ElevenSQLite.ElevenCore;
using ElevenSQLite.ElevenUtils;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmDocumento.
	/// </summary>
	public partial class FrmDocumento : Form
	{
		static string FORMATO_NUMERO = "##0";
		static string FORMATO_DECIMAL = "{0:N0}";
		static string CODIGO = "Codigo";
		static string DESCRIPCION = "Descripcion";
		static string CANTIDAD = "Cantidad";
		static string VALOR_NETO = "ValorNeto";
		static string VALOR_UNITARIO = "ValorUnitario";
		static string SUBTOTAL = "SubTotal";
		static string DESCUENTO = "Descuento";
		static string TARIFA_IVA = "TarifaIva";
		static string IVA = "Iva";
		static string TARIFA_RETENCION = "TarifaRetencion";
		static string RETENCION = "Retencion";
		static string TOTAL = "Total";
		static string OBSERVACION = "Observacion";
		static string IMPUESTO_CONSUMO = "ImpuestoConsumo";
		bool IVA_INCLUIDO;
		bool CLIENTE_EXCENTO;
		string CEROS_IZQUIERDA = "{0:0}";
		static string MONEDA_DEFECTO;
		bool cambioConsecutivo;
		int consecutivoCambio;

		
		TipoDocumento tipoDocumento;
		Dictionary<DetalleDocumento, decimal> dicDetallesDocumento;
		Dictionary<int, DetalleDocumento> dicDetalles;
		TipoDocumentoMaestro tipoDocumentoMaestro;		
		static Preferencias preferencias = Preferencias.Get(Entorno.USUARIO);
		static Empresa empresa = Empresa.Get();
		
		public TipoDocumento TipoDocumento { set; get;}
		public Tercero Tercero { set; get;}
		public Documento Documento { set; get;}
		public Articulo Articulo { set; get;}
		
		public FrmDocumento()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Documento = new Documento();
			Documento.FechaCreacion = DateTime.Now;
			Documento.CalcularDescuento = true;
			Documento.CalcularIva = true;
			Text = "Crear Nuevo Documento";
		}
		public FrmDocumento(Documento doc)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Documento = doc;
			Documento.FechaModificacion = DateTime.Now;
			Text = "Modificar Documento";
		}
		
		string CalcularNumeroDecimal(int p)
		{
			string text = ".";
			for (int i = 0; i < p; i++) {
				text += "#";
			}
			return text;
		}

		string CalcularCerosIzquierda(int p)
		{
			string text = "";
			for (int i = 0; i < p; i++) {
				text += "0";
			}
			return text;
		}
		
		void ConfigurarDataGrid()
		{
			int index = dataGridViewDetalles.Columns.Add(CODIGO, "Código");
			dataGridViewDetalles.Columns[index].DataPropertyName = CODIGO;
			dataGridViewDetalles.Columns[index].ReadOnly = true;
			dataGridViewDetalles.Columns[index].Width = 60;
			index = dataGridViewDetalles.Columns.Add(DESCRIPCION, "Descripción");
			dataGridViewDetalles.Columns[index].DataPropertyName = DESCRIPCION;
			dataGridViewDetalles.Columns[index].Width = 300;
			index = dataGridViewDetalles.Columns.Add(CANTIDAD, "Cantidad");
			dataGridViewDetalles.Columns[index].DataPropertyName = CANTIDAD;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = FORMATO_NUMERO;
			dataGridViewDetalles.Columns[index].Width = 60;
			index = dataGridViewDetalles.Columns.Add(VALOR_NETO, "V/Neto");
			dataGridViewDetalles.Columns[index].DataPropertyName = VALOR_NETO;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = FORMATO_NUMERO;
			index = dataGridViewDetalles.Columns.Add(VALOR_UNITARIO, "V/Unitario");
			dataGridViewDetalles.Columns[index].DataPropertyName = VALOR_UNITARIO;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = FORMATO_NUMERO;
			index = dataGridViewDetalles.Columns.Add(SUBTOTAL, "Subtotal");
			dataGridViewDetalles.Columns[index].DataPropertyName = SUBTOTAL;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = FORMATO_NUMERO;
			dataGridViewDetalles.Columns[index].ReadOnly = true;
			index = dataGridViewDetalles.Columns.Add(DESCUENTO, "Descuento");
			dataGridViewDetalles.Columns[index].DataPropertyName = DESCUENTO;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = FORMATO_NUMERO;
			index = dataGridViewDetalles.Columns.Add(TARIFA_IVA, "Tarifa Iva");
			dataGridViewDetalles.Columns[index].DataPropertyName = TARIFA_IVA;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = "##0.##";
			dataGridViewDetalles.Columns[index].ReadOnly = true;
			index = dataGridViewDetalles.Columns.Add(IVA, "IVA");
			dataGridViewDetalles.Columns[index].DataPropertyName = IVA;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = "##0";
			dataGridViewDetalles.Columns[index].ReadOnly = true;
			index = dataGridViewDetalles.Columns.Add(TARIFA_RETENCION, "Tarifa Retención");
			dataGridViewDetalles.Columns[index].DataPropertyName = TARIFA_RETENCION;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = "##0.##";
			dataGridViewDetalles.Columns[index].ReadOnly = true;
			index = dataGridViewDetalles.Columns.Add(RETENCION, "Retención");
			dataGridViewDetalles.Columns[index].DataPropertyName = RETENCION;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = "##0";
			dataGridViewDetalles.Columns[index].ReadOnly = true;
			index = dataGridViewDetalles.Columns.Add(TOTAL, "Total");
			dataGridViewDetalles.Columns[index].DataPropertyName = TOTAL;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = FORMATO_NUMERO;
			dataGridViewDetalles.Columns[index].ReadOnly = true;
			index = dataGridViewDetalles.Columns.Add(OBSERVACION, "Observación");
			dataGridViewDetalles.Columns[index].DataPropertyName = OBSERVACION;
			index = dataGridViewDetalles.Columns.Add(IMPUESTO_CONSUMO, "ImpuestoConsumo");
			dataGridViewDetalles.Columns[index].DataPropertyName = IMPUESTO_CONSUMO;
			dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = FORMATO_NUMERO;
			dataGridViewDetalles.Columns[index].Visible = false;
			dataGridViewDetalles.AutoGenerateColumns = false;
		}
		
		void LlenarTipoMoneda()
		{
			cbTipoMoneda.DataSource = TipoMoneda.GetAll();
			cbTipoMoneda.DisplayMember = "Descripcion";
			cbTipoMoneda.ValueMember = "Id";
		}

		void LlenarTipoDocumentoMaestro()
		{
			cbTipoDocumentoMaestro.DataSource = TipoDocumentoMaestro.GetAllGrupo(TipoDocumentoMaestro.GRUPO_DOCUMENTO);
			cbTipoDocumentoMaestro.DisplayMember = "Descripcion";
			cbTipoDocumentoMaestro.ValueMember = "Id";
		}
		
		void CreateFormatString()
		{
			CEROS_IZQUIERDA = "{0:0}";
			if (tipoDocumento.CerosIzquierda > 0) {
				CEROS_IZQUIERDA = "{0:" + CalcularCerosIzquierda(tipoDocumento.CerosIzquierda) + "}";
			}
			FORMATO_NUMERO = "##0";
			if (tipoDocumento.CantidadDecimal > 0) {
				FORMATO_NUMERO += CalcularNumeroDecimal(tipoDocumento.CantidadDecimal);
			}
			FORMATO_DECIMAL = "{0:N0}";
			if (tipoDocumento.CantidadDecimal > 0) {
				FORMATO_DECIMAL = "{0:N" + tipoDocumento.CantidadDecimal + "}";
			}
		}

		public void LlenarTipoDocumento()
		{
			if (tipoDocumento != null) {
				CreateFormatString();
				txtTipoDocumento.Text = tipoDocumento.Descripcion;
				lbConsecutivo.Text = string.Format(CEROS_IZQUIERDA, tipoDocumento.ConsecutivoActual);
				return;
			}
			MessageBox.Show("No existen documentos de " + tipoDocumentoMaestro.Descripcion, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			int num = cbTipoDocumentoMaestro.SelectedIndex + 1;
			if (num == cbTipoDocumentoMaestro.Items.Count) {
				cbTipoDocumentoMaestro.SelectedIndex = 0;
				return;
			}
			cbTipoDocumentoMaestro.SelectedIndex = num;
		}

		void LlenarImpresionDocumento()
		{
			tipoDocumentoMaestro = (cbTipoDocumentoMaestro.SelectedItem as TipoDocumentoMaestro);
			tipoDocumentoMaestro.Load();
			IList<ImpresionDocumento> impresionesDocumento = tipoDocumentoMaestro.ImpresionesDocumento;
			if (impresionesDocumento != null && impresionesDocumento.Count > 0) {
				cbImpresionDocumento.DataSource = impresionesDocumento;
				cbImpresionDocumento.DisplayMember = "Descripcion";
				cbImpresionDocumento.ValueMember = "Id";
				if (tipoDocumentoMaestro.ImpresionDocumentoID != null) {
					cbImpresionDocumento.SelectedValue = tipoDocumentoMaestro.ImpresionDocumentoID;
				}
				if (tipoDocumento != null && tipoDocumento.ImpresionDocumentoID != null) {
					cbImpresionDocumento.SelectedValue = tipoDocumento.ImpresionDocumentoID;
				}
				//btnVistaPrevia.Enabled = true;
				return;
			}
			cbImpresionDocumento.DataSource = null;
			//btnVistaPrevia.Enabled = false;
		}

		void LlenarEstadoDocumento()
		{
			tipoDocumentoMaestro = (cbTipoDocumentoMaestro.SelectedItem as TipoDocumentoMaestro);
			IList<EstadoDocumento> estadosDocumento = tipoDocumentoMaestro.EstadosDocumento;
			cbEstadoDocumento.DataSource = estadosDocumento;
			cbEstadoDocumento.DisplayMember = "Descripcion";
			cbEstadoDocumento.ValueMember = "Id";
			if (tipoDocumentoMaestro.EstadoDocumentoID != null) {
				cbEstadoDocumento.SelectedValue = tipoDocumentoMaestro.EstadoDocumentoID;
			}
			if (tipoDocumento != null && tipoDocumento.EstadoDocumentoID != null) {
				cbEstadoDocumento.SelectedValue = tipoDocumento.EstadoDocumentoID;
			}
		}
		void LlenarCondicionPago()
		{
			cbCondicion.DataSource = CondicionPago.GetAll();
			cbCondicion.DisplayMember = "Descripcion";
			cbCondicion.ValueMember = "Id";
		}
		void LlenarEmpleado()
		{
			cbEmpleado.DataSource = Empleado.GetAll();
			cbEmpleado.DisplayMember = "NombreCompleto";
			cbEmpleado.ValueMember = "Id";
		}
		
		public void LlenarTercero()
		{
			txtCodigoTercero.Text = Tercero.Codigo;
			txtNombreComercial.Text = Tercero.NombreComercial;
			txtDireccionTercero.Text = Tercero.DireccionPrincipal;
			CLIENTE_EXCENTO = Tercero.ExcentoIva;
		}
		void LlenarDataGrid()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add(new DataColumn(CODIGO, typeof(string)));
			dataTable.Columns.Add(new DataColumn(DESCRIPCION, typeof(string)));
			dataTable.Columns.Add(new DataColumn(CANTIDAD, typeof(decimal)));
			dataTable.Columns.Add(new DataColumn(VALOR_NETO, typeof(decimal)));
			dataTable.Columns.Add(new DataColumn(VALOR_UNITARIO, typeof(decimal)));
			dataTable.Columns.Add(new DataColumn(SUBTOTAL, typeof(decimal)));
			dataTable.Columns.Add(new DataColumn(DESCUENTO, typeof(decimal)));
			dataTable.Columns.Add(new DataColumn(TARIFA_IVA, typeof(float)));
			dataTable.Columns.Add(new DataColumn(IVA, typeof(int)));
			dataTable.Columns.Add(new DataColumn(TARIFA_RETENCION, typeof(float)));
			dataTable.Columns.Add(new DataColumn(RETENCION, typeof(int)));
			dataTable.Columns.Add(new DataColumn(TOTAL, typeof(decimal)));
			dataTable.Columns.Add(new DataColumn(OBSERVACION, typeof(string)));
			dataTable.Columns.Add(new DataColumn(IMPUESTO_CONSUMO, typeof(decimal)));
			dicDetalles = new Dictionary<int, DetalleDocumento>();
			foreach (DetalleDocumento current in Documento.Detalles) {
				object[] values = new object[] {
					current.Codigo,
					current.Descripcion,
					current.Cantidad,
					current.ValorNeto,
					current.ValorUnitario,
					current.SubTotal,
					current.Descuento,
					current.TarifaIva,
					current.Iva,
					current.TarifaRetencion,
					current.Retencion,
					current.Total,
					current.Observacion,
					current.ImpuestoConsumo
				};
				dataTable.Rows.Add(values);
				dicDetalles.Add(dataTable.Rows.Count - 1, current);
			}
			bindingSource1.DataSource = dataTable;
			dataGridViewDetalles.DataSource = bindingSource1;
		}
		
		internal void LlenarDocumento()
		{
			Tercero = Tercero.Get(Documento.TerceroID);
			LlenarTercero();
			LlenarDataGrid();
			tipoDocumentoMaestro = TipoDocumentoMaestro.Get(TipoDocumento.Get(Documento.TipoDocumentoID).TipoDocumentoMaestroID.GetValueOrDefault());
			cbTipoDocumentoMaestro.SelectedValue = tipoDocumentoMaestro.ID;
			tipoDocumento = TipoDocumento.Get(Documento.TipoDocumentoID);
			FORMATO_NUMERO = "##0";
			if (tipoDocumento.CantidadDecimal > 0) {
				FORMATO_NUMERO += CalcularNumeroDecimal(tipoDocumento.CantidadDecimal);
			}
			CEROS_IZQUIERDA = "{0:0}";
			if (tipoDocumento.CerosIzquierda > 0) {
				CEROS_IZQUIERDA = "{0:" + CalcularCerosIzquierda(tipoDocumento.CerosIzquierda) + "}";
			}
			if (Documento.ImpresionDocumentoID != 0) {
				cbImpresionDocumento.SelectedValue = Documento.ImpresionDocumentoID;
			}
			if (Documento.TipoMonedaID != 0) {
				cbTipoMoneda.SelectedItem = Documento.TipoMonedaID;
				txtCambio.Text = Documento.CambioTipoMoneda.ToString(FORMATO_NUMERO);
			}
			dtpFechaCreacion.Value = Documento.FechaDocumento.Value;
			dtpFechaVencimiento.Value = Documento.FechaVencimiento.Value;
			txtReferencia.Text = Documento.Referencia;
			FORMATO_DECIMAL = "{0:N" + tipoDocumento.CantidadDecimal + "}";
			txtSubtotal.Text = string.Format(FORMATO_DECIMAL, Documento.SubTotal);
			txtDescuento.Text = string.Format(FORMATO_DECIMAL, Documento.TotalDescuento);
			txtIVA.Text = string.Format(FORMATO_DECIMAL, Documento.TotalIva);
			txtTotal.Text = string.Format(FORMATO_DECIMAL, Documento.Total);
			txtObservacion.Text = Documento.Observacion;
			txtNombreProyecto.Text = Documento.Texto1;
			txtObservacionAlterna.Text = Documento.Texto2;
			lbConsecutivo.Text = string.Format(CEROS_IZQUIERDA, Documento.Consecutivo);
			if (Documento.Condicion != null && Documento.Condicion != string.Empty) {
				cbCondicion.SelectedIndex = cbCondicion.FindStringExact(Documento.Condicion);
			}
			else {
				cbCondicion.SelectedIndex = 0;
			}
			cbEstadoDocumento.SelectedValue = Documento.EstadoDocumentoID;
			BloquearTipoDocumento();
			dicDetallesDocumento = new Dictionary<DetalleDocumento, decimal>();
			IList<DetalleDocumento> detalles = Documento.Detalles;
			foreach (DetalleDocumento current in detalles) {
				dicDetallesDocumento.Add(current, current.Cantidad);
			}
		}
		void BloquearTipoDocumento()
		{
			if (Documento.Detalles.Count > 0) {
				cbTipoDocumentoMaestro.Enabled = false;
				return;
			}
			cbTipoDocumentoMaestro.Enabled = true;
		}
		void EvaluarTipoMoneda()
		{
			if (cbTipoMoneda.Text == MONEDA_DEFECTO) {
				txtCambio.ReadOnly = true;
				txtCambio.Text = string.Empty;
				return;
			}
			txtCambio.ReadOnly = false;
		}
		
		void NuevoDocumento()
		{
			Documento = new Documento();
			Documento.FechaCreacion = DateTime.Now;
			Documento.CalcularIva = true;
			Documento.CalcularDescuento = true;			
			bool ultimaConfiguracion = preferencias.UltimaConfiguracion;
			if (ultimaConfiguracion && preferencias.UltimoTipoDocumentoID != null) {
				tipoDocumento = TipoDocumento.Get(preferencias.UltimoTipoDocumentoID.GetValueOrDefault());
				tipoDocumentoMaestro = TipoDocumentoMaestro.Get(tipoDocumento.TipoDocumentoMaestroID.GetValueOrDefault());
				cbTipoDocumentoMaestro.SelectedValue = tipoDocumentoMaestro.ID;
			}
			tipoDocumento = TipoDocumento.Get(tipoDocumento.ID);
			LlenarTipoDocumento();
			BloquearTipoDocumento();
			//Reconfigurar();
			txtCodigoTercero.Focus();
		}
		void CalcularTotalArticulo()
		{
			decimal d;
			try {
				d = Convert.ToDecimal(txtCantidadArticulo.Text);
			}
			catch {
				d = 0m;
			}
			decimal d2;
			try {
				d2 = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text);
			}
			catch {
				d2 = 0m;
			}
			decimal d3;
			try {
				d3 = Convert.ToDecimal(txtDescuentoArticulo.Text);
			}
			catch {
				d3 = 0m;
			}
			decimal d4 = d * d2;
			decimal num = d4 - d4 * (d3 / 100m);
			if (tipoDocumento.RedondeoAutomatico) {
				txtTotalArticulo.Text = num.ToString(FORMATO_NUMERO);
				return;
			}
			txtTotalArticulo.Text = num.ToString();
		}
		void CalcularTotalDocumento()
		{
			decimal num = 0m;
			int num2 = 0;
			decimal num3 = 0m;
			decimal num4 = 0m;
			decimal num5 = 0m;
			decimal num6 = 0m;
			IList<DetalleDocumento> detalles = Documento.Detalles;
			foreach (DetalleDocumento current in detalles) {
				num += current.SubTotal;
				num3 += current.Descuento;
				num5 += current.Total;
				num6 += current.ImpuestoConsumo;
				num2 += current.Iva;
				num4 += current.Retencion;
			}
			Documento.SubTotal = num;
			if (Documento.CalcularDescuento) {
				Documento.TotalDescuento = num3;
			}
			if (Documento.CalcularIva) {
				Documento.TotalIva = num2;
			}
			Documento.TotalImpuestoConsumo = num6;
			Documento.Total = num5;
			Documento.TotalRetencion = num4;
			FORMATO_DECIMAL = "{0:N" + tipoDocumento.CantidadDecimal + "}";
			txtSubtotal.Text = string.Format(FORMATO_DECIMAL, Documento.SubTotal);
			txtDescuento.Text = string.Format(FORMATO_DECIMAL, Documento.TotalDescuento);
			txtIVA.Text = string.Format(FORMATO_DECIMAL, Documento.TotalIva);
			txtTotal.Text = string.Format(FORMATO_DECIMAL, Documento.Total);
		}
		
		void RefrescarDetalleDocumentoGrid(int p)
		{
			int value = Convert.ToInt32(dataGridViewDetalles.Rows[p].Cells["Cantidad"].Value);
			float num = Convert.ToSingle(dataGridViewDetalles.Rows[p].Cells["TarifaIVA"].Value);
			float num2 = Convert.ToSingle(dataGridViewDetalles.Rows[p].Cells["TarifaRetencion"].Value);
			decimal d = Convert.ToDecimal(dataGridViewDetalles.Rows[p].Cells["Descuento"].Value);
			decimal num3 = 0m;
			decimal num4 = 0m;
			Articulo articulo = Articulo.FindByCodigo(dicDetalles[p].Codigo);
			decimal num5;
			decimal num6;
			if (IVA_INCLUIDO) {
				num5 = Convert.ToDecimal(dataGridViewDetalles.Rows[p].Cells["ValorUnitario"].Value);
				num6 = num5 / Convert.ToDecimal(1f + num / 100f);
				if (articulo.RedondeoSistema) {
					num3 = Math.Round(num6, preferencias.NumeroDecimal);
				}
				else {
					if (articulo.RedondeoInferior) {
						num3 = Math.Floor(num6);
					}
					else {
						if (articulo.RedondeoSuperior) {
							num3 = Math.Ceiling(num6);
						}
					}
				}
				dataGridViewDetalles.Rows[p].Cells["ValorNeto"].Value = num3;
				dicDetalles[p].ValorNeto = num3;
			}
			else {
				num6 = Convert.ToDecimal(dataGridViewDetalles.Rows[p].Cells["ValorNeto"].Value);
				num5 = num6 * Convert.ToDecimal(1f + num / 100f);
				if (articulo.RedondeoSistema) {
					num4 = Math.Round(num5, preferencias.NumeroDecimal);
				}
				else {
					if (articulo.RedondeoInferior) {
						num4 = Math.Floor(num5);
					}
					else {
						if (articulo.RedondeoSuperior) {
							num4 = Math.Ceiling(num5);
						}
					}
				}
				dataGridViewDetalles.Rows[p].Cells["ValorUnitario"].Value = num4;
				dicDetalles[p].ValorUnitario = num4;
			}
			decimal num7 = value * num6;
			decimal d2 = Convert.ToDecimal(dicDetalles[p].Cantidad * num6);
			Convert.ToDecimal(dicDetalles[p].Cantidad * num5);
			decimal num8 = d2 * Convert.ToDecimal(dicDetalles[p].TarifaIva / 100f);
			if (dicDetalles[p].Descuento > 0m) {
				num8 = (dicDetalles[p].SubTotal - dicDetalles[p].Descuento) * Convert.ToDecimal(Articulo.Iva / 100f);
			}
			if (articulo.RedondeoSistema) {
				num8 = Math.Round(num8, preferencias.NumeroDecimal);
			}
			else {
				if (articulo.RedondeoInferior) {
					num8 = Math.Floor(num8);
				}
				else {
					if (articulo.RedondeoSuperior) {
						num8 = Math.Ceiling(num8);
					}
				}
			}
			decimal num9 = (num7 - d) * Convert.ToDecimal(num2 / 100f);
			dataGridViewDetalles.Rows[p].Cells["SubTotal"].Value = num7;
			dicDetalles[p].SubTotal = num7;
			decimal num10 = value * articulo.ImpuestoConsumo;
			dicDetalles[p].ImpuestoConsumo = num10;
			decimal num11 = num7 - d + num8 + num10;
			dataGridViewDetalles.Rows[p].Cells["Total"].Value = num11;
			dicDetalles[p].Total = num11;
			dataGridViewDetalles.Rows[p].Cells["Iva"].Value = num8;
			dicDetalles[p].Iva = Convert.ToInt32(num8);
			dataGridViewDetalles.Rows[p].Cells["Retencion"].Value = num9;
			dicDetalles[p].Retencion = Convert.ToInt32(num9);
			Documento.Detalles[p] = dicDetalles[p];
		}
		void ResetDocumento()
		{
			txtCambio.Text = string.Empty;
			dtpFechaCreacion.Value = DateTime.Now;
			dtpFechaVencimiento.Value = DateTime.Now;
			txtReferencia.Text = string.Empty;
			txtObservacion.Text = string.Empty;
			checkObservacion1.Checked = false;
			checkObservacion2.Checked = false;
			txtSubtotal.Text = string.Empty;
			txtDescuento.Text = string.Empty;
			txtIVA.Text = string.Empty;
			txtTotal.Text = string.Empty;
			ResetTercero();
			ResetArticulo();
			LlenarDataGrid();
			if (cbCondicion.Items.Count > 0) {
				cbCondicion.SelectedIndex = 0;
			}
			txtRecargo.Text = "0";
			txtProntoPago.Text = "0";
		}
		void ResetArticulo()
		{
			txtCodigoArticulo.Text = string.Empty;
			txtDescripcionArticulo.Text = string.Empty;
			txtCantidadArticulo.Text = string.Empty;
			txtPrecioUnitarioArticulo.Text = string.Empty;
			txtDescuentoArticulo.Text = string.Empty;
			txtTotalArticulo.Text = string.Empty;
			Articulo = null;
		}
		void ResetTercero()
		{
			Tercero = null;
			txtCodigoTercero.Text = string.Empty;
			txtNombreComercial.Text = string.Empty;
			txtDireccionTercero.Text = string.Empty;
		}
		public void LlenarArticulo()
		{
			txtCodigoArticulo.Text = Articulo.Codigo;
			txtDescripcionArticulo.Text = Articulo.Descripcion;
			txtCantidadArticulo.Text = "1";
			if (tipoDocumentoMaestro.Codigo != TipoDocumentoMaestro.FACTURA_COMPRA && tipoDocumentoMaestro.Codigo != TipoDocumentoMaestro.REMISION && tipoDocumentoMaestro.Codigo != TipoDocumentoMaestro.SALIDA_INVENTARIO && tipoDocumentoMaestro.Codigo != TipoDocumentoMaestro.ENTRADA_INVENTARIO) {
				if (IVA_INCLUIDO) {
					txtPrecioUnitarioArticulo.Text = Articulo.PrecioVenta.ToString(FORMATO_NUMERO);
				}
				else {
					txtPrecioUnitarioArticulo.Text = Articulo.ValorNeto.ToString(FORMATO_NUMERO);
				}
				if (CLIENTE_EXCENTO) {
					txtPrecioUnitarioArticulo.Text = Articulo.ValorNeto.ToString(FORMATO_NUMERO);
				}
				if (Tercero != null) {
					if (Tercero.TipoPrecioVenta == 1) {
						if (IVA_INCLUIDO) {
							txtPrecioUnitarioArticulo.Text = Articulo.PrecioVenta1.ToString(FORMATO_NUMERO);
						}
						else {
							txtPrecioUnitarioArticulo.Text = Articulo.ValorNeto1.ToString(FORMATO_NUMERO);
						}
						if (CLIENTE_EXCENTO) {
							txtPrecioUnitarioArticulo.Text = Articulo.ValorNeto1.ToString(FORMATO_NUMERO);
						}
					}
					else {
						if (Tercero.TipoPrecioVenta == 2) {
							if (IVA_INCLUIDO) {
								txtPrecioUnitarioArticulo.Text = Articulo.PrecioVenta2.ToString(FORMATO_NUMERO);
							}
							else {
								txtPrecioUnitarioArticulo.Text = Articulo.ValorNeto2.ToString(FORMATO_NUMERO);
							}
							if (CLIENTE_EXCENTO) {
								txtPrecioUnitarioArticulo.Text = Articulo.ValorNeto2.ToString(FORMATO_NUMERO);
							}
						}
					}
					if (Tercero.TipoPrecioVenta == 3) {
						if (IVA_INCLUIDO) {
							txtPrecioUnitarioArticulo.Text = Articulo.PrecioVenta2.ToString(FORMATO_NUMERO);
						}
						else {
							txtPrecioUnitarioArticulo.Text = Articulo.ValorNeto3.ToString(FORMATO_NUMERO);
						}
						if (CLIENTE_EXCENTO) {
							txtPrecioUnitarioArticulo.Text = Articulo.ValorNeto3.ToString(FORMATO_NUMERO);
						}
					}
				}
			}
			else {
				txtPrecioUnitarioArticulo.Text = "0";
			}
			txtDescuentoArticulo.Text = "0";
		}
		void BuscarArticulo()
		{
			Articulo = null;
			Articulo = Articulo.FindByCodigo(txtCodigoArticulo.Text);
			if (Articulo != null) {				
				LlenarArticulo();
			}
			if (tipoDocumento.Factor == TipoDocumento.FACTOR_RESTA && Articulo.StockMinimo > --Articulo.StockDisponible) {
				MessageBox.Show("El stock de articulos a disminuido demasiado!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (tipoDocumento.Factor == TipoDocumento.FACTOR_SUMA && Articulo.StockMaximo < ++Articulo.StockDisponible) {
				MessageBox.Show("El stock de articulos a aumentado demasiado!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			txtCantidadArticulo.Focus();
		}
		void CalcularFechaVencimiento()
		{
			if (tipoDocumentoMaestro.Codigo == TipoDocumentoMaestro.COTIZACION_VENTA || tipoDocumentoMaestro.Codigo == TipoDocumentoMaestro.FACTURA_VENTA || tipoDocumentoMaestro.Codigo == TipoDocumentoMaestro.FACTURA_COMPRA) {
				var condicionPago = (CondicionPago)cbCondicion.SelectedItem;
				if (condicionPago != null && tipoDocumentoMaestro.Codigo == TipoDocumentoMaestro.FACTURA_VENTA) {
					dtpFechaVencimiento.Value = dtpFechaCreacion.Value.AddDays((double)condicionPago.Dias);
					txtRecargo.Text = condicionPago.Recargo.ToString(FORMATO_NUMERO);
					txtProntoPago.Text = condicionPago.ProntoPago.ToString(FORMATO_NUMERO);
				}
				if (tipoDocumentoMaestro.Codigo == TipoDocumentoMaestro.FACTURA_VENTA || tipoDocumentoMaestro.Codigo == TipoDocumentoMaestro.FACTURA_COMPRA) {
					if (condicionPago.Dias == 0) {
						EstadoDocumento estadoDocumento = EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO);
						cbEstadoDocumento.SelectedValue = estadoDocumento.ID;
						return;
					}
					EstadoDocumento estadoDocumento2 = EstadoDocumento.FindByEstado(EstadoDocumento.FACTURADO);
					cbEstadoDocumento.SelectedValue = estadoDocumento2.ID;
				}
			}
		}
		void Reconfigurar()
		{
			CreateFormatString();
			IVA_INCLUIDO = tipoDocumento.IvaIncluido;
			if (tipoDocumento.TipoMonedaID != null) {
				cbTipoMoneda.SelectedValue = tipoDocumento.TipoMonedaID;
			}
			else {
				TipoMoneda tipoMoneda = TipoMoneda.Get(preferencias.TipoMonedaID.GetValueOrDefault());
				if (tipoMoneda != null) {
					MONEDA_DEFECTO = tipoMoneda.Descripcion;
				}
				cbTipoMoneda.SelectedIndex = cbTipoMoneda.FindStringExact(MONEDA_DEFECTO);
			}
			cambioConsecutivo = false;
			txtDescuentoArticulo.Enabled = true;
			txtPrecioUnitarioArticulo.Enabled = true;
			lbValor.Text = "Valor Unitario:";
			dataGridViewDetalles.Columns[VALOR_NETO].ReadOnly = false;
			cbCondicion.Enabled = false;
			txtRecargo.Enabled = false;
			txtProntoPago.Enabled = false;
			txtProntoPago.Text = "0";
			txtRecargo.Text = "0";
			if (tipoDocumentoMaestro.Codigo.Equals(TipoDocumentoMaestro.COTIZACION_VENTA)) {
				cbCondicion.Enabled = true;
				txtRecargo.Enabled = true;
				txtProntoPago.Enabled = true;
			}
			if (tipoDocumentoMaestro.Codigo.Equals(TipoDocumentoMaestro.ORDEN_PEDIDO)) {
				txtDescuentoArticulo.Enabled = false;
				dataGridViewDetalles.Columns[DESCUENTO].ReadOnly = true;
			}
			if (tipoDocumentoMaestro.Codigo.Equals(TipoDocumentoMaestro.REMISION)) {
				txtDescuentoArticulo.Enabled = false;
				txtPrecioUnitarioArticulo.Enabled = false;
				dataGridViewDetalles.Columns[VALOR_NETO].ReadOnly = true;
				dataGridViewDetalles.Columns[VALOR_UNITARIO].ReadOnly = true;
				dataGridViewDetalles.Columns[DESCUENTO].ReadOnly = true;
				dataGridViewDetalles.Columns[TARIFA_IVA].ReadOnly = true;
				dataGridViewDetalles.Columns[TARIFA_RETENCION].ReadOnly = true;
			}
			if (tipoDocumentoMaestro.Codigo.Equals(TipoDocumentoMaestro.FACTURA_VENTA)) {
				if (IVA_INCLUIDO) {
					dataGridViewDetalles.Columns[VALOR_NETO].ReadOnly = true;
					dataGridViewDetalles.Columns[VALOR_UNITARIO].ReadOnly = false;
				}
				else {
					dataGridViewDetalles.Columns[VALOR_NETO].ReadOnly = false;
					dataGridViewDetalles.Columns[VALOR_UNITARIO].ReadOnly = true;
				}
				cbCondicion.Enabled = true;
				txtRecargo.Enabled = true;
				txtProntoPago.Enabled = true;
			}
			if (tipoDocumentoMaestro.Codigo.Equals(TipoDocumentoMaestro.SALIDA_INVENTARIO)) {
				txtDescuentoArticulo.Enabled = false;
				txtPrecioUnitarioArticulo.Enabled = false;
				dataGridViewDetalles.Columns[VALOR_NETO].ReadOnly = true;
				dataGridViewDetalles.Columns[VALOR_UNITARIO].ReadOnly = true;
				dataGridViewDetalles.Columns[DESCUENTO].ReadOnly = true;
				dataGridViewDetalles.Columns[TARIFA_IVA].ReadOnly = true;
				dataGridViewDetalles.Columns[TARIFA_RETENCION].ReadOnly = true;
			}
			if (tipoDocumentoMaestro.Codigo.Equals(TipoDocumentoMaestro.ORDEN_COMPRA)) {
				txtDescuentoArticulo.Enabled = false;
				txtPrecioUnitarioArticulo.Enabled = true;
				dataGridViewDetalles.Columns[DESCUENTO].ReadOnly = true;
			}
			if (tipoDocumentoMaestro.Codigo.Equals(TipoDocumentoMaestro.FACTURA_COMPRA)) {
				txtDescuentoArticulo.Enabled = false;
				lbValor.Text = "Costo:";
				dataGridViewDetalles.Columns[DESCUENTO].ReadOnly = true;
				dataGridViewDetalles.Columns[VALOR_UNITARIO].ReadOnly = true;
				cbCondicion.Enabled = true;
			}
			if (tipoDocumentoMaestro.Codigo.Equals(TipoDocumentoMaestro.ENTRADA_INVENTARIO)) {
				txtDescuentoArticulo.Enabled = false;
				txtPrecioUnitarioArticulo.Enabled = false;
				dataGridViewDetalles.Columns[VALOR_NETO].ReadOnly = true;
				dataGridViewDetalles.Columns[VALOR_UNITARIO].ReadOnly = true;
				dataGridViewDetalles.Columns[DESCUENTO].ReadOnly = true;
				dataGridViewDetalles.Columns[TARIFA_IVA].ReadOnly = true;
				dataGridViewDetalles.Columns[TARIFA_RETENCION].ReadOnly = true;
			}
			if (tipoDocumentoMaestro.Codigo.Equals(TipoDocumentoMaestro.DEVOLUCION_VENTA)) {
				txtDescuentoArticulo.Enabled = false;
				dataGridViewDetalles.Columns[VALOR_NETO].ReadOnly = true;
				dataGridViewDetalles.Columns[VALOR_UNITARIO].ReadOnly = true;
				dataGridViewDetalles.Columns[DESCUENTO].ReadOnly = true;
			}
			if (tipoDocumentoMaestro.Codigo.Equals(TipoDocumentoMaestro.INVENTARIO_INICIAL)) {
				txtDescuentoArticulo.Enabled = false;
				lbValor.Text = "Costo:";
				dataGridViewDetalles.Columns[VALOR_NETO].ReadOnly = true;
				dataGridViewDetalles.Columns[VALOR_UNITARIO].ReadOnly = true;
				dataGridViewDetalles.Columns[DESCUENTO].ReadOnly = true;
			}
			lbConsecutivo.Text = string.Format(CEROS_IZQUIERDA, tipoDocumento.ConsecutivoActual);
		}
		
		void FrmDocumento_Load(object sender, EventArgs e)
		{
			ConfigurarDataGrid();
			LlenarTipoMoneda();
			LlenarTipoDocumentoMaestro();
			LlenarCondicionPago();
			LlenarEmpleado();
			bool ultimaConfiguracion = preferencias.UltimaConfiguracion;
			if (ultimaConfiguracion && preferencias.UltimoTipoDocumentoID != null) {
				tipoDocumento = TipoDocumento.Get(preferencias.UltimoTipoDocumentoID.GetValueOrDefault());
				tipoDocumentoMaestro = TipoDocumentoMaestro.Get(tipoDocumento.TipoDocumentoMaestroID.GetValueOrDefault());
				cbTipoDocumentoMaestro.SelectedValue = tipoDocumentoMaestro.ID;
			}
			if(Documento.ID > 0) LlenarDocumento();
			txtCodigoTercero.Focus();
		}
		void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			var frmBuscarTercero = new FrmBuscarTercero();
			if(frmBuscarTercero.ShowDialog() == DialogResult.OK)
			{
				Tercero = frmBuscarTercero.Tercero;
				if(Tercero != null){ LlenarTercero();}
			}
			
			
		}
		void cbTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
		{
			EvaluarTipoMoneda();
		}
		void btnBuscarArticulo_Click(object sender, EventArgs e)
		{
			var frmBuscarArticulo = new FrmBuscarArticulo();
			if(frmBuscarArticulo.ShowDialog(this) == DialogResult.OK)
			{
				Articulo = frmBuscarArticulo.Articulo;
				if(Articulo != null) LlenarArticulo();
			}
		}
		void btBuscarTipoDocumento_Click(object sender, EventArgs e)
		{
			var frmBuscarTipoDocumento = new FrmBuscarTipoDocumento();
			if(frmBuscarTipoDocumento.ShowDialog(this) == DialogResult.OK)
			{
				TipoDocumento = frmBuscarTipoDocumento.TipoDocumento;
				if(TipoDocumento != null)  LlenarTipoDocumento();
			}
		}
		void txtTotalArticulo_TextChanged(object sender, EventArgs e)
		{
			CalcularTotalDocumento();
		}
		void txtPrecioUnitarioArticulo_TextChanged(object sender, EventArgs e)
		{
			CalcularTotalArticulo();
		}
		void txtDescuentoArticulo_TextChanged(object sender, EventArgs e)
		{
			CalcularTotalArticulo();
		}
		void lbConsecutivo_DoubleClick(object sender, EventArgs e)
		{
			var frmCambiarConsecutivo = new FrmCambiarConsecutivo();
			frmCambiarConsecutivo.Consecutivo = Documento.Consecutivo;
			consecutivoCambio = Documento.Consecutivo;
			if (frmCambiarConsecutivo.ShowDialog(this) == DialogResult.OK) {
				Documento.Consecutivo = frmCambiarConsecutivo.Consecutivo;
				lbConsecutivo.Text = string.Format(CEROS_IZQUIERDA, Documento.Consecutivo);
				cambioConsecutivo = (consecutivoCambio != Documento.Consecutivo);
			}
		}
		void btnCambiarIVA_Click(object sender, EventArgs e)
		{
			var frmIVADocumento = new FrmIVADocumento();
			frmIVADocumento.Recalculo = Documento.CalcularIva;
			frmIVADocumento.Iva = Documento.TotalIva;
			frmIVADocumento.FormatoNumero = "##0";
			if (frmIVADocumento.ShowDialog(this) == DialogResult.OK) {
				if (frmIVADocumento.Recalculo) {
					Documento.CalcularIva = false;
					Documento.TotalIva = frmIVADocumento.Iva;
					txtIVA.Text = Documento.TotalIva.ToString(FORMATO_NUMERO);
					Documento.Total = Documento.SubTotal - Documento.TotalDescuento + Documento.TotalIva + Documento.TotalImpuestoConsumo;
					txtTotal.Text = Documento.Total.ToString(FORMATO_NUMERO);
					return;
				}
				Documento.CalcularIva = true;
				CalcularTotalDocumento();
			}
		}
		void btnCambiarDescuento_Click(object sender, EventArgs e)
		{
			var frmDescuentoDocumento = new FrmDescuentoDocumento();
			frmDescuentoDocumento.Descuento = Documento.TotalDescuento;
			frmDescuentoDocumento.FormatoNumero = FORMATO_NUMERO;
			frmDescuentoDocumento.Recalculo = Documento.CalcularDescuento;
			if (frmDescuentoDocumento.ShowDialog(this) == DialogResult.OK) {
				if (frmDescuentoDocumento.Recalculo) {
					Documento.CalcularDescuento = false;
					Documento.TotalDescuento = frmDescuentoDocumento.Descuento;
					txtDescuento.Text = Documento.TotalDescuento.ToString(FORMATO_NUMERO);
					Documento.Total = Documento.SubTotal - Documento.TotalDescuento + Documento.TotalIva + Documento.TotalImpuestoConsumo;
					txtTotal.Text = Documento.Total.ToString(FORMATO_NUMERO);
					return;
				}
				Documento.CalcularDescuento = true;
				CalcularTotalDocumento();
			}
		}
		void dataGridViewDetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex > 0) {
				if (dataGridViewDetalles.Columns[e.ColumnIndex].Name == "TarifaIva") {
					var frmComboIVA = new FrmComboIVA();
					frmComboIVA.TarifaIVA = Convert.ToString(Convert.ToDecimal(dataGridViewDetalles[e.ColumnIndex, e.RowIndex].Value, CultureInfo.CurrentCulture));
					if (frmComboIVA.ShowDialog(this) == DialogResult.OK) {
						dataGridViewDetalles[e.ColumnIndex, e.RowIndex].Value = frmComboIVA.TarifaIVA;
						dicDetalles[e.RowIndex].TarifaIva = Convert.ToSingle(frmComboIVA.TarifaIVA);
						RefrescarDetalleDocumentoGrid(e.RowIndex);
						CalcularTotalDocumento();
					}
				}
				if (dataGridViewDetalles.Columns[e.ColumnIndex].Name == "TarifaRetencion") {
					var frmComboRetencion = new FrmComboRetencion();
					frmComboRetencion.TarifaRetencion = Convert.ToString(Convert.ToDecimal(dataGridViewDetalles[e.ColumnIndex, e.RowIndex].Value, CultureInfo.CurrentCulture));
					if (frmComboRetencion.ShowDialog(this) == DialogResult.OK) {
						dataGridViewDetalles[e.ColumnIndex, e.RowIndex].Value = frmComboRetencion.TarifaRetencion;
						dicDetalles[e.RowIndex].TarifaRetencion = Convert.ToSingle(frmComboRetencion.TarifaRetencion);
						RefrescarDetalleDocumentoGrid(e.RowIndex);
						CalcularTotalDocumento();
					}
				}
			}
		}
		void btnBorrarCliente_Click(object sender, EventArgs e)
		{
			ResetTercero();
		}
		
		void txtDescripcionArticulo_DoubleClick(object sender, EventArgs e)
		{
			var frmDescripcionLarga = new FrmDescripcionLarga();
			frmDescripcionLarga.Descripcion = txtDescripcionArticulo.Text;
			if (frmDescripcionLarga.ShowDialog(this) == DialogResult.OK) {
				txtDescripcionArticulo.Text = frmDescripcionLarga.Descripcion;
			}
		}
		void txtCodigoArticulo_Validating(object sender, CancelEventArgs e)
		{
			if (txtCodigoArticulo.Text != string.Empty) {
				BuscarArticulo();
			}
		}
		void txtCodigoTercero_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r') {
				e.Handled = true;
				if (txtCodigoTercero.Text != string.Empty) {
					Tercero = Tercero.FindByCodigo(txtCodigoTercero.Text);
					if (Tercero != null) {
						LlenarTercero();
						txtCodigoArticulo.Focus();
						return;
					}
					if (MessageBox.Show("No existe el tercero (" + txtCodigoTercero.Text + ") ¿Desea crearlo?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
						var frmTerceroLite = new FrmTerceroLite();
						frmTerceroLite.txtCodigo.Text = txtCodigoTercero.Text;
						if (frmTerceroLite.ShowDialog(this) == DialogResult.OK) {
							Tercero = frmTerceroLite.Tercero;
							LlenarTercero();
							return;
						}
						ResetTercero();
						return;
					}
					else {
						ResetTercero();
					}
				}
			}
		}
		void cbImpresionDocumento_SelectedIndexChanged(object sender, EventArgs e)
		{
			var impresionDocumento = (cbImpresionDocumento.SelectedItem as ImpresionDocumento);
			if (impresionDocumento != null) {
				if (impresionDocumento.TipoImpresion == ImpresionDocumento.IMPRESION_POS) {
					//btnVistaPrevia.Visible = false;
					//btnImprimir.Visible = true;
					return;
				}
				//btnVistaPrevia.Visible = true;
				//btnImprimir.Visible = false;
			}
		}
		void cbTipoDocumentoMaestro_SelectedIndexChanged(object sender, EventArgs e)
		{
			tipoDocumentoMaestro = (cbTipoDocumentoMaestro.SelectedItem as TipoDocumentoMaestro);
			tipoDocumento = TipoDocumento.Get(tipoDocumentoMaestro.ID);
			if (tipoDocumento != null) {
				TipoMoneda tipoMoneda = TipoMoneda.Get(tipoDocumento.TipoMonedaID.GetValueOrDefault());
				MONEDA_DEFECTO = tipoMoneda.Descripcion;
				EvaluarTipoMoneda();
			}
			LlenarTipoDocumento();
			LlenarImpresionDocumento();
			LlenarEstadoDocumento();
			Reconfigurar();
			BloquearTipoDocumento();
		}
		void dtpFechaCreacion_ValueChanged(object sender, EventArgs e)
		{
			CalcularFechaVencimiento();
		}
		void cbCondicion_SelectedIndexChanged(object sender, EventArgs e)
		{
			CalcularFechaVencimiento();
		}
		void checkObservacion1_CheckedChanged(object sender, EventArgs e)
		{
			string observacionDocumento = preferencias.ObservacionDocumento;
			if (observacionDocumento != string.Empty) {
				if (checkObservacion1.Checked) {
					if (txtObservacion.Text != string.Empty && observacionDocumento != string.Empty) {
						txtObservacion.Text = txtObservacion.Text + Environment.NewLine + observacionDocumento;
						return;
					}
					txtObservacion.Text = observacionDocumento;
					return;
				}
				else {
					txtObservacion.Text = txtObservacion.Text.Replace(Environment.NewLine + observacionDocumento, string.Empty);
					if (txtObservacion.Text.Length == observacionDocumento.Length) {
						txtObservacion.Text = txtObservacion.Text.Replace(observacionDocumento, string.Empty);
					}
				}
			}
		}
		void btnRemove_Click(object sender, EventArgs e)
		{
			if (dataGridViewDetalles.SelectedCells.Count > 0) {
				foreach (DataGridViewCell dataGridViewCell in dataGridViewDetalles.SelectedCells) {
					int rowIndex = dataGridViewCell.RowIndex;
					dataGridViewDetalles.Rows.Remove(dataGridViewCell.OwningRow);
					Documento.Detalles.Remove(dicDetalles[rowIndex]);
					bindingSource1.ResetBindings(false);
				}
				LlenarDataGrid();
				CalcularTotalDocumento();
				BloquearTipoDocumento();
			}
		}
		void txtCantidadArticulo_TextChanged(object sender, EventArgs e)
		{
			CalcularTotalArticulo();
		}
		
		void btnAdd_Click(object sender, EventArgs e)
		{
			DetalleDocumento detalleDocumento = null;
			StringBuilder stringBuilder = new StringBuilder();
			if (Articulo == null) {
				MessageBox.Show("Debe agregar un articulo!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			int limiteRegistro = tipoDocumento.LimiteRegistro;
			if (limiteRegistro == Documento.Detalles.Count) {
				stringBuilder.AppendLine("Se ha superado el tope de registros el maximo es (" + limiteRegistro + ")");
			}
			float value = 1f + Articulo.Iva / 100f;
			detalleDocumento = new DetalleDocumento();
			detalleDocumento.Codigo = Articulo.Codigo;
			detalleDocumento.Descripcion = txtDescripcionArticulo.Text;
			detalleDocumento.TarifaIva = Articulo.Iva;
			try {
				detalleDocumento.Cantidad = Convert.ToDecimal(txtCantidadArticulo.Text);
				if (detalleDocumento.Cantidad <= 0m) {
					stringBuilder.AppendLine("La cantidad debe ser mayor a cero (0)!");
				}
			}
			catch {
				stringBuilder.AppendLine("La cantidad debe ser un numero!");
				detalleDocumento.Cantidad = 0m;
			}
			detalleDocumento.Costo = Articulo.Costo;
			if (tipoDocumentoMaestro.Codigo != TipoDocumentoMaestro.REMISION && tipoDocumentoMaestro.Codigo != TipoDocumentoMaestro.ENTRADA_INVENTARIO && tipoDocumentoMaestro.Codigo != TipoDocumentoMaestro.SALIDA_INVENTARIO) {
				try {
					if (IVA_INCLUIDO) {
						detalleDocumento.ValorNeto = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text) / Convert.ToDecimal(value);
						detalleDocumento.ValorUnitario = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text);
					}
					else {
						detalleDocumento.ValorNeto = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text);
						detalleDocumento.ValorUnitario = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text) * Convert.ToDecimal(value);
					}
					if (CLIENTE_EXCENTO) {
						detalleDocumento.ValorUnitario = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text);
						detalleDocumento.ValorNeto = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text);
					}
					if (tipoDocumento.TipoFacturacion == Tercero.REGIMEN_SIMPLIFICADO) {
						detalleDocumento.ValorUnitario = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text);
						detalleDocumento.ValorNeto = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text);
					}
					if (Articulo.Impuesto == Articulo.EXCENTO || Articulo.Impuesto == Articulo.EXCLUIDO) {
						detalleDocumento.ValorUnitario = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text);
						detalleDocumento.ValorNeto = Convert.ToDecimal(txtPrecioUnitarioArticulo.Text);
					}
					if (detalleDocumento.ValorUnitario <= 0m) {
						stringBuilder.AppendLine("El valor unitario debe ser mayor a cero (0)!");
					}
					if (tipoDocumento.RedondeoAutomatico) {
						if (Articulo.RedondeoSistema) {
							detalleDocumento.ValorUnitario = Math.Round(detalleDocumento.ValorUnitario, tipoDocumento.CantidadDecimal);
							detalleDocumento.ValorNeto = Math.Round(detalleDocumento.ValorNeto, tipoDocumento.CantidadDecimal);
						}
						else {
							if (Articulo.RedondeoInferior) {
								if (tipoDocumento.CantidadDecimal > 0) {
									detalleDocumento.ValorUnitario = Math.Round(detalleDocumento.ValorUnitario, tipoDocumento.CantidadDecimal, MidpointRounding.AwayFromZero);
									detalleDocumento.ValorNeto = Math.Round(detalleDocumento.ValorNeto, tipoDocumento.CantidadDecimal, MidpointRounding.AwayFromZero);
								}
								else {
									detalleDocumento.ValorUnitario = Math.Floor(detalleDocumento.ValorUnitario);
									detalleDocumento.ValorNeto = Math.Floor(detalleDocumento.ValorNeto);
								}
							}
							else {
								if (Articulo.RedondeoSuperior) {
									if (tipoDocumento.CantidadDecimal > 0) {
										detalleDocumento.ValorUnitario = Math.Round(detalleDocumento.ValorUnitario, tipoDocumento.CantidadDecimal, MidpointRounding.ToEven);
										detalleDocumento.ValorNeto = Math.Round(detalleDocumento.ValorNeto, tipoDocumento.CantidadDecimal, MidpointRounding.ToEven);
									}
									else {
										detalleDocumento.ValorUnitario = Math.Ceiling(detalleDocumento.ValorUnitario);
										detalleDocumento.ValorNeto = Math.Ceiling(detalleDocumento.ValorNeto);
									}
								}
							}
						}
					}
				}
				catch {
					stringBuilder.AppendLine("El valor unitario debe ser un numero!");
					detalleDocumento.ValorUnitario = 0m;
				}
				decimal d = 0m;
				try {
					d = Convert.ToDecimal(txtDescuentoArticulo.Text);
				}
				catch {
					stringBuilder.AppendLine("El descuento debe ser un numero!");
					detalleDocumento.Descuento = 0m;
				}
				detalleDocumento.ImpuestoConsumo = Articulo.ImpuestoConsumo * detalleDocumento.Cantidad;
				detalleDocumento.SubTotal = detalleDocumento.Cantidad * detalleDocumento.ValorNeto;
				if (tipoDocumento.RedondeoAutomatico) {
					if (tipoDocumento.CantidadDecimal > 0) {
						detalleDocumento.SubTotal = Math.Round(detalleDocumento.Cantidad * detalleDocumento.ValorNeto, tipoDocumento.CantidadDecimal);
					}
					else {
						detalleDocumento.SubTotal = Math.Round(detalleDocumento.Cantidad * detalleDocumento.ValorNeto);
					}
				}
				detalleDocumento.Descuento = detalleDocumento.SubTotal * (d / 100m);
				if (CLIENTE_EXCENTO) {
					detalleDocumento.Iva = 0;
					detalleDocumento.TarifaIva = 0f;
				}
				else {
					decimal d2 = Convert.ToDecimal(detalleDocumento.Cantidad * detalleDocumento.ValorNeto);
					Convert.ToDecimal(detalleDocumento.Cantidad * detalleDocumento.ValorUnitario);
					decimal num = d2 * Convert.ToDecimal(Articulo.Iva / 100f);
					if (detalleDocumento.Descuento > 0m) {
						num = (detalleDocumento.SubTotal - detalleDocumento.Descuento) * Convert.ToDecimal(Articulo.Iva / 100f);
					}
					if (Articulo.RedondeoSistema) {
						num = Math.Round(num, preferencias.NumeroDecimal);
					}
					else {
						if (Articulo.RedondeoInferior) {
							num = Math.Floor(num);
						}
						else {
							if (Articulo.RedondeoSuperior) {
								num = Math.Ceiling(num);
							}
						}
					}
					detalleDocumento.Iva = Convert.ToInt32(num);
					detalleDocumento.TarifaIva = Articulo.Iva;
				}
				if (tipoDocumento.TipoFacturacion == Tercero.REGIMEN_SIMPLIFICADO) {
					detalleDocumento.Iva = 0;
					detalleDocumento.TarifaIva = 0f;
				}
				if (Articulo.Impuesto == Articulo.EXCENTO || Articulo.Impuesto == Articulo.EXCLUIDO) {
					detalleDocumento.Iva = 0;
					detalleDocumento.TarifaIva = 0f;
					if (Articulo.Impuesto == Articulo.EXCENTO) {
						detalleDocumento.ObservacionInterna = Articulo.EXCENTO;
					}
					else {
						if (Articulo.Impuesto == Articulo.EXCLUIDO) {
							detalleDocumento.ObservacionInterna = Articulo.EXCLUIDO;
						}
					}
				}
				detalleDocumento.Total = detalleDocumento.SubTotal - detalleDocumento.Descuento + detalleDocumento.Iva + detalleDocumento.ImpuestoConsumo;
			}
			else {
				detalleDocumento.Iva = 0;
				detalleDocumento.TarifaIva = 0f;
			}
			if (tipoDocumento.Factor == TipoDocumento.FACTOR_RESTA && Articulo.StockDisponible < detalleDocumento.Cantidad && !Articulo.Servicio) {
				stringBuilder.AppendLine("No existe la cantidad de articulos en el stock, solo hay disponibles (").Append(Articulo.StockDisponible).Append(")");
			}
			if (stringBuilder.Length > 0) {
				MessageBox.Show(stringBuilder.ToString(), "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			Documento.Detalles.Add(detalleDocumento);
			LlenarDataGrid();
			ResetArticulo();
			CalcularTotalDocumento();
			BloquearTipoDocumento();
		}
		
		void dataGridViewDetalles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value != null) {
				if (e.Value is Articulo) {
					Articulo = (e.Value as Articulo);
					e.Value = Articulo.Codigo;
				}
				if ((dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Cantidad" || dataGridViewDetalles.Columns[e.ColumnIndex].Name == "ValorNeto" || dataGridViewDetalles.Columns[e.ColumnIndex].Name == "ValorUnitario" || dataGridViewDetalles.Columns[e.ColumnIndex].Name == "SubTotal" || dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Descuento" || dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Iva" || dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Total" || dataGridViewDetalles.Columns[e.ColumnIndex].Name == "ImpuestoConsumo") && tipoDocumento.CantidadDecimal > 0) {
					e.CellStyle.Format = "##0" + CalcularNumeroDecimal(tipoDocumento.CantidadDecimal);
				}
			}
		}
		
		void dataGridViewDetalles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Cantidad") {
				decimal num = Convert.ToDecimal(dataGridViewDetalles[e.ColumnIndex, e.RowIndex].Value);
				dicDetalles[e.RowIndex].Cantidad = num;
				if (tipoDocumento.Factor == TipoDocumento.FACTOR_RESTA) {
					Articulo articulo = Articulo.FindByCodigo( dicDetalles[e.RowIndex].Codigo);
					if (articulo.StockDisponible < num && !articulo.Servicio) {
						MessageBox.Show("No existe la cantidad de articulos en el stock, solo hay disponibles (" + articulo.StockDisponible + ")", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						dataGridViewDetalles.Rows[e.RowIndex].Cells["Cantidad"].Value = articulo.StockDisponible;
						dicDetalles[e.RowIndex].Cantidad = Articulo.StockDisponible;
					}
				}
				RefrescarDetalleDocumentoGrid(e.RowIndex);
				CalcularTotalDocumento();
			}
			if (dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Descripcion") {
				dicDetalles[e.RowIndex].Descripcion = Convert.ToString(dataGridViewDetalles[e.ColumnIndex, e.RowIndex].Value);
				RefrescarDetalleDocumentoGrid(e.RowIndex);
			}
			if (dataGridViewDetalles.Columns[e.ColumnIndex].Name == "ValorNeto") {
				dicDetalles[e.RowIndex].ValorNeto = Convert.ToDecimal(dataGridViewDetalles[e.ColumnIndex, e.RowIndex].Value);
				RefrescarDetalleDocumentoGrid(e.RowIndex);
				CalcularTotalDocumento();
			}
			if (dataGridViewDetalles.Columns[e.ColumnIndex].Name == "ValorUnitario") {
				dicDetalles[e.RowIndex].ValorUnitario = Convert.ToDecimal(dataGridViewDetalles[e.ColumnIndex, e.RowIndex].Value);
				RefrescarDetalleDocumentoGrid(e.RowIndex);
				CalcularTotalDocumento();
			}
			if (dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Descuento") {
				dicDetalles[e.RowIndex].Descuento = Convert.ToDecimal(dataGridViewDetalles[e.ColumnIndex, e.RowIndex].Value);
				RefrescarDetalleDocumentoGrid(e.RowIndex);
				CalcularTotalDocumento();
			}
		}

		void checkObservacion2_CheckedChanged(object sender, EventArgs e)
		{
			string otraObservacionDocumento = preferencias.OtraObservacionDocumento;
			if (otraObservacionDocumento != string.Empty) {
				if (checkObservacion2.Checked) {
					if (txtObservacion.Text != string.Empty && otraObservacionDocumento != string.Empty) {
						txtObservacion.Text = txtObservacion.Text + Environment.NewLine + otraObservacionDocumento;
						return;
					}
					txtObservacion.Text = otraObservacionDocumento;
					return;
				}
				else {
					txtObservacion.Text = txtObservacion.Text.Replace(Environment.NewLine + otraObservacionDocumento, string.Empty);
					if (txtObservacion.Text.Length == otraObservacionDocumento.Length) {
						txtObservacion.Text = txtObservacion.Text.Replace(otraObservacionDocumento, string.Empty);
					}
				}
			}
		}
		void btnGuardar_Click(object sender, EventArgs e)
		{
			if (Documento.FechaAnulacion.HasValue) {
				MessageBox.Show("No se puede grabar el documento ya que ha sido anulado!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (Tercero != null) {
				Documento.TerceroID = Tercero.ID;
				Documento.CodigoTercero = Tercero.Codigo;
				Documento.NombreComercialTercero = Tercero.NombreComercial;
				Documento.NitTercero = Tercero.Nit;
				Documento.DigitoVerificacionTercero = Tercero.DigitoVerificacion;
				Documento.DireccionPrincipalTercero = Tercero.DireccionPrincipal;
				Documento.TelefonoPrincipalTercero = Tercero.TelefonoPrincipal;
				try {
					Ciudad ciudad = Ciudad.Get(Tercero.CiudadID);
					Documento.CiudadPrincipalTercero = ciudad.Descripcion;
				}
				catch (Exception) {	}
			}else{
				stringBuilder.Append("No existe tercero! \n");
			}
			
			if (Documento.Detalles.Count == 0) {
				stringBuilder.Append("No existen detalles! \n");
			}
			Documento.TipoDocumentoID = tipoDocumento.ID;
			if (!(cbTipoMoneda.Text == MONEDA_DEFECTO)) {
				Documento.TipoMonedaID = (cbTipoMoneda.SelectedItem as TipoMoneda).ID;
				try {
					decimal num = Convert.ToDecimal(txtCambio.Text);
					Documento.CambioTipoMoneda = num;
					if (num < 0m) {
						stringBuilder.Append("El cambio de moneda debe ser mayor o igual a cero (0)\n");
					}					
				}
				catch {
					stringBuilder.Append("El cambio de moneda debe ser un numero o cero (0)\n");
					txtCambio.Text = "0";
				}
			}
			Documento.TipoMonedaID = preferencias.TipoMonedaID.GetValueOrDefault();
			Documento.FechaDocumento = new DateTime?(dtpFechaCreacion.Value);
			Documento.FechaVencimiento = new DateTime?(dtpFechaVencimiento.Value);
			Documento.Referencia = txtReferencia.Text;
			Documento.TipoDocumentoID = tipoDocumento.ID;
			Documento.EstadoDocumentoID = (cbEstadoDocumento.SelectedItem as EstadoDocumento).ID;
			Documento.EmpleadoID = (cbEmpleado.SelectedItem as Empleado).ID;
			Documento.AgenteComercial = Empleado.FindByID(Documento.EmpleadoID).NombreCompleto;
			Documento.Observacion = txtObservacion.Text;
			Documento.Texto1 = txtNombreProyecto.Text;
			Documento.Texto2 = txtObservacionAlterna.Text;
			if (!(tipoDocumentoMaestro.Codigo == TipoDocumentoMaestro.COTIZACION_VENTA)) {
				if (!(tipoDocumentoMaestro.Codigo == TipoDocumentoMaestro.FACTURA_VENTA)) {
					
				}
			}
			try {
				Documento.Recargo = Convert.ToSingle(txtRecargo.Text);
			}
			catch {
				stringBuilder.Append("Recargo debe ser un numero o cero!\n");
			}
			try {
				Documento.ProntoPago = Convert.ToSingle(txtProntoPago.Text);
			}
			catch {
				stringBuilder.Append("Pronto pago debe ser un numero o cero!\n");
			}
			var condicionPago = (CondicionPago)cbCondicion.SelectedItem;
			Documento.Condicion = condicionPago.Descripcion;
			
			var impresionDocumento = (ImpresionDocumento)cbImpresionDocumento.SelectedItem;
			if (impresionDocumento != null) {
				Documento.ImpresionDocumentoID = impresionDocumento.ID;
			}
			if (stringBuilder.Length > 0) {
				MessageBox.Show(stringBuilder.ToString(), "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			bool ultimaConfiguracion = preferencias.UltimaConfiguracion;
			if (ultimaConfiguracion) {
				if (preferencias.UltimoTipoDocumentoID == null) {
					//preferencias = new PreferenciasFactory().GetPreferencias(Entorno.USUARIO);
					preferencias.UltimoTipoDocumentoID = Documento.TipoDocumentoID;
					preferencias.Update();
				}
				else {
					if (preferencias.UltimoTipoDocumentoID != tipoDocumento.ID) {
						//preferencias = new PreferenciasFactory().GetPreferencias(Entorno.USUARIO);
						preferencias.UltimoTipoDocumentoID = Documento.TipoDocumentoID;
						preferencias.Update();
					}
				}
			}
			Documento.UsuarioID = Entorno.USUARIO.ID;
			//MessageBox.Show(Documento.ID.ToString());
			if (Documento.ID == 0) {
				tipoDocumento = TipoDocumento.Get(tipoDocumento.ID);
				if (!cambioConsecutivo) {
					Documento.Consecutivo = tipoDocumento.ConsecutivoActual;
				}
				Documento.Save();
				if (cambioConsecutivo) {					
					if (Documento.Consecutivo > tipoDocumento.ConsecutivoActual) {
						tipoDocumento.ConsecutivoActual = Documento.Consecutivo;
						tipoDocumento.Update();
					}
				}
				else {
					tipoDocumento.ConsecutivoActual++;
					tipoDocumento.Update();
				}
				dicDetallesDocumento = new Dictionary<DetalleDocumento, decimal>();
				IList<DetalleDocumento> detalles = Documento.Detalles;
				using (IEnumerator<DetalleDocumento> enumerator = detalles.GetEnumerator()) {
					while (enumerator.MoveNext()) {
						DetalleDocumento current = enumerator.Current;
						dicDetallesDocumento.Add(current, current.Cantidad);
						//Documento.Detalles.Add(current);
					}
				}
				
			}
			if (( TipoDocumento.Get(Documento.TipoDocumentoID).Factor == TipoDocumento.FACTOR_SUMA || TipoDocumento.Get(Documento.TipoDocumentoID).Factor == TipoDocumento.FACTOR_RESTA) && dicDetallesDocumento != null && dicDetallesDocumento.Count > 0) {
				foreach (KeyValuePair<DetalleDocumento, decimal> current2 in dicDetallesDocumento) {
					DetalleDocumento key = current2.Key;
					decimal value = current2.Value;
					Articulo articulo = Articulo.FindByCodigo(key.Codigo);
					if (TipoDocumento.Get(Documento.TipoDocumentoID).Factor == TipoDocumento.FACTOR_SUMA && !articulo.Servicio) {
						articulo.StockActual -= value;
						articulo.StockDisponible -= value;
					}
					if (TipoDocumento.Get(Documento.TipoDocumentoID).Factor == TipoDocumento.FACTOR_RESTA && !articulo.Servicio) {
						articulo.StockActual += value;
						articulo.StockDisponible += value;
					}
					articulo.Update();
				}
			}
			
			if(Documento.ID > 0) Documento.Update();
			if (cambioConsecutivo) {
				tipoDocumento = TipoDocumento.Get(tipoDocumento.ID);				
				if (consecutivoCambio == tipoDocumento.ConsecutivoActual--) {
					tipoDocumento.ConsecutivoActual--;
					tipoDocumento.Update();
				}
				if (Documento.Consecutivo > tipoDocumento.ConsecutivoActual) {
					tipoDocumento.ConsecutivoActual = Documento.Consecutivo;
					tipoDocumento.Update();
				}
			}
			dicDetallesDocumento = new Dictionary<DetalleDocumento, decimal>();
			IList<DetalleDocumento> detalles2 = Documento.Detalles;
			foreach (DetalleDocumento current3 in detalles2) {
				dicDetallesDocumento.Add(current3, current3.Cantidad);
			}
			
				if (TipoDocumento.Get(Documento.TipoDocumentoID).Factor == TipoDocumento.FACTOR_SUMA) {
				IList<DetalleDocumento> detalles3 = Documento.Detalles;
				foreach (DetalleDocumento current4 in detalles3) {
					Articulo articulo2 = Articulo.FindByCodigo(current4.Codigo);
					if (!articulo2.Servicio) {
						articulo2.StockActual += current4.Cantidad;
						articulo2.StockDisponible += current4.Cantidad;
					}
					if (TipoDocumento.Get(Documento.TipoDocumentoID).Codigo == TipoDocumentoMaestro.FACTURA_COMPRA) {
						if (articulo2.CostoMaximo < current4.ValorUnitario) {
							articulo2.CostoMaximo = current4.ValorUnitario;
						}
						if (articulo2.CostoMinimo > current4.ValorUnitario) {
							articulo2.CostoMinimo = current4.ValorUnitario;
						}
						articulo2.UltimoCosto = current4.ValorUnitario;
					}
					articulo2.Update();
				}
			}
			if (TipoDocumento.Get(Documento.TipoDocumentoID).Factor == TipoDocumento.FACTOR_RESTA) {
				IList<DetalleDocumento> detalles4 = Documento.Detalles;
				foreach (DetalleDocumento current5 in detalles4) {
					Articulo articulo3 = Articulo.FindByCodigo(current5.Codigo);
					if (!articulo3.Servicio) {
						articulo3.StockActual -= current5.Cantidad;
						articulo3.StockDisponible -= current5.Cantidad;
						articulo3.Update();
					}
				}
			}
			MessageBox.Show("Documento grabado con exito!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		
	}
}
