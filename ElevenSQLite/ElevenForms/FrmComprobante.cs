/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;
using ElevenSQLite.ElevenUtils;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmComprobante.
	/// </summary>
	public partial class FrmComprobante : Form
	{
		int accion = 0;
		Comprobante comprobante;
		Documento documento;
		Tercero tercero;
		private static Preferencias preferencias = Preferencias.Get(Entorno.USUARIO);
		private static string EFECTIVO = "Efectivo";
		private static string CHEQUE = "Cheque";
		private static string formateo = "##0";
		
		private TipoDocumento tipoDocumento;
		private Dictionary<Documento, decimal> dicDetallesComprobante;
		private Dictionary<string, bool> documentos = new Dictionary<string, bool>();
		
		public FrmComprobante()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			accion = 1;
		}
		
		private void AdicionarConcepto(Documento doc)
		{
			var detalleComprobante = new DetalleComprobante();
			detalleComprobante.Documento = documento;
			tipoDocumento = TipoDocumento.Get(documento.TipoDocumentoID);
			detalleComprobante.Concepto = string.Concat(new string[] {
				" PAGO ",
				tipoDocumento.Descripcion,
				" Numero ",
				tipoDocumento.Codigo,
				"-",
				string.Format("{0:" + this.CalcularCerosIzquierda(tipoDocumento.CerosIzquierda) + "}", documento.Consecutivo)
			});
			detalleComprobante.TotalDocumento = documento.Total - documento.TotalAbono;
			detalleComprobante.Total = documento.Total - documento.TotalAbono;
			this.comprobante.Detalles.Add(detalleComprobante);
			this.LlenarDataGrid();
			this.EvaluarTercero();
		}
		
		internal void LlenarComprobante()
		{
			this.comprobante.Load();
			this.tipoDocumento = TipoDocumento.Get(this.comprobante.TipoDocumentoID);
			formateo = "##0";
			if (this.tipoDocumento.CantidadDecimal > 0) {
				formateo += this.CalcularNumeroDecimal(this.tipoDocumento.CantidadDecimal);
			}
			this.tercero = Tercero.Get(this.comprobante.TerceroID);
			this.txtCodigoTercero.Text = this.tercero.Codigo;
			this.txtNombreComercial.Text = this.tercero.NombreComercial;
			this.dtpFechaCreacion.Value = this.comprobante.FechaComprobante.Value;
			this.lbConsecutivo.Text = string.Format("{0:" + this.CalcularCerosIzquierda(TipoDocumento.Get(this.comprobante.TipoDocumentoID).CerosIzquierda) + "}", this.comprobante.Consecutivo);
			this.LlenarDataGrid();
			this.txtObservacion.Text = this.comprobante.Observacion;
			if (this.comprobante.FormaPago == Comprobante.CHEQUE) {
				this.txtSucursal.Text = this.comprobante.Sucursal;
				this.txtNumeroCheque.Text = this.comprobante.NumeroCheque;
				this.cbBanco.SelectedValue = this.comprobante.BancoID;
			}
			this.cbCondicion.SelectedIndex = this.cbCondicion.FindStringExact(this.comprobante.FormaPago);
			string format = "{0:N" + this.tipoDocumento.CantidadDecimal + "}";
			this.txtDescuento.Text = string.Format(format, this.comprobante.TotalDescuento);
			this.txtRetencion.Text = string.Format(format, this.comprobante.TotalRetencion);
			this.txtTotal.Text = string.Format(format, this.comprobante.Total);
			if (TipoDocumento.Get(this.comprobante.TipoDocumentoID).Codigo == TipoDocumentoMaestro.COMPROBANTE_EGRESO) {
				this.rbEgreso.PerformClick();
			}
			else {
				this.rbIngreso.PerformClick();
			}
			this.cbImpresionComprobante.SelectedValue = this.comprobante.ImpresionDocumentoID;
			if (!string.IsNullOrEmpty(comprobante.EstadoDocumentoID.ToString())  && EstadoDocumento.Get(this.comprobante.EstadoDocumentoID).Descripcion == EstadoDocumento.ANULADO) {
				//this.btnAnular.Enabled = false;
			}
			this.dicDetallesComprobante = new Dictionary<Documento, decimal>();
			foreach (DetalleComprobante current in this.comprobante.Detalles) {
				if (current.Documento != null) {
					this.dicDetallesComprobante.Add(current.Documento, current.Total);
				}
			}
			this.EvaluarTercero();
		}
		
		private void CargarTipoImpresion()
		{
			TipoDocumentoMaestro tipoDocumentoMaestro = TipoDocumentoMaestro.Get(this.tipoDocumento.TipoDocumentoMaestroID.GetValueOrDefault());
			tipoDocumentoMaestro.Load();
			this.cbImpresionComprobante.DataSource = tipoDocumentoMaestro.ImpresionesDocumento;
			this.cbImpresionComprobante.ValueMember = "Id";
			this.cbImpresionComprobante.DisplayMember = "Descripcion";
			if (this.tipoDocumento.ImpresionDocumentoID != null) {
				this.cbImpresionComprobante.SelectedValue = this.tipoDocumento.ImpresionDocumentoID;
			}
		}
		private void ConfigurarDataGridView()
		{
			this.dataGridViewDetalles.AutoGenerateColumns = false;
			int index = this.dataGridViewDetalles.Columns.Add("Id", "Id");
			this.dataGridViewDetalles.Columns[index].DataPropertyName = "Id";
			this.dataGridViewDetalles.Columns[index].Visible = false;
			index = this.dataGridViewDetalles.Columns.Add("Documento", "Documento");
			this.dataGridViewDetalles.Columns[index].DataPropertyName = "Documento";
			this.dataGridViewDetalles.Columns[index].Width = 70;
			this.dataGridViewDetalles.Columns[index].ReadOnly = true;
			index = this.dataGridViewDetalles.Columns.Add("Concepto", "Concepto");
			this.dataGridViewDetalles.Columns[index].DataPropertyName = "Concepto";
			this.dataGridViewDetalles.Columns[index].Width = 300;
			index = this.dataGridViewDetalles.Columns.Add("TotalDocumento", "Total doc.");
			this.dataGridViewDetalles.Columns[index].DataPropertyName = "TotalDocumento";
			this.dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = formateo;
			this.dataGridViewDetalles.Columns[index].Width = 70;
			index = this.dataGridViewDetalles.Columns.Add("Descuento", "Descuento");
			this.dataGridViewDetalles.Columns[index].DataPropertyName = "Descuento";
			this.dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = formateo;
			this.dataGridViewDetalles.Columns[index].Width = 70;
			index = this.dataGridViewDetalles.Columns.Add("Retencion", "Retencion");
			this.dataGridViewDetalles.Columns[index].DataPropertyName = "Retencion";
			this.dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = formateo;
			this.dataGridViewDetalles.Columns[index].Width = 70;
			index = this.dataGridViewDetalles.Columns.Add("Total", "Total pago");
			this.dataGridViewDetalles.Columns[index].DataPropertyName = "Total";
			this.dataGridViewDetalles.Columns[index].DefaultCellStyle.Format = formateo;
			this.dataGridViewDetalles.Columns[index].Width = 70;
			this.bindingSource1.DataSource = this.comprobante.Detalles;
			this.dataGridViewDetalles.DataSource = this.bindingSource1;
		}
		private void LlenarDataGrid()
		{
			this.bindingSource1.DataSource = this.comprobante.Detalles;
			this.dataGridViewDetalles.DataSource = this.bindingSource1;
			this.bindingSource1.ResetBindings(false);
		}
		private void ResetComprobante()
		{
			this.ResetTercero();
			this.dtpFechaCreacion.Value = DateTime.Now;
			this.cbCondicion.SelectedIndex = this.cbCondicion.FindStringExact(EFECTIVO);
			this.dataGridViewDetalles.Rows.Clear();
			//this.btnAnular.Enabled = true;
			this.EvaluarTercero();
		}

		private void ResetTercero()
		{
			this.tercero = null;
			this.txtCodigoTercero.Text = string.Empty;
			this.txtNombreComercial.Text = string.Empty;
		}

		public void LlenarTercero()
		{
			this.txtCodigoTercero.Text = this.tercero.Codigo;
			this.txtNombreComercial.Text = this.tercero.NombreComercial;
		}
		
		private void EvaluarTercero()
		{
			if (this.comprobante.Detalles.Count > 0) {
				this.txtCodigoTercero.Enabled = false;
				this.btnBuscarCliente.Enabled = false;
				this.rbEgreso.Enabled = false;
				this.rbIngreso.Enabled = false;
				return;
			}
			this.txtCodigoTercero.Enabled = true;
			this.btnBuscarCliente.Enabled = true;
			this.rbEgreso.Enabled = true;
			this.rbIngreso.Enabled = true;
		}
		private void RefrescarDetalleComprobanteGrid(int p)
		{
			decimal d = Convert.ToDecimal(this.dataGridViewDetalles.Rows[p].Cells["TotalDocumento"].Value);
			decimal d2 = Convert.ToDecimal(this.dataGridViewDetalles.Rows[p].Cells["Descuento"].Value);
			decimal d3 = Convert.ToDecimal(this.dataGridViewDetalles.Rows[p].Cells["Retencion"].Value);
			decimal num = d - (d2 + d3);
			this.dataGridViewDetalles.Rows[p].Cells["Total"].Value = num;
		}

		private void CalcularTotales()
		{
			decimal num = 0m;
			decimal num2 = 0m;
			decimal num3 = 0m;
			IList<DetalleComprobante> detalles = this.comprobante.Detalles;
			foreach (DetalleComprobante current in detalles) {
				num += current.Descuento;
				num3 += current.Total;
				num2 += current.Retencion;
			}
			this.comprobante.Total = num3;
			this.comprobante.TotalDescuento = num;
			this.comprobante.TotalRetencion = num2;
			string format = "{0:N" + this.tipoDocumento.CantidadDecimal + "}";
			this.txtDescuento.Text = string.Format(format, this.comprobante.TotalDescuento);
			this.txtRetencion.Text = string.Format(format, this.comprobante.TotalRetencion);
			this.txtTotal.Text = string.Format(format, this.comprobante.Total);
		}
		
		private string CalcularNumeroDecimal(int p)
		{
			string text = ".";
			for (int i = 0; i < p; i++) {
				text += "#";
			}
			return text;
		}

		internal void DocumentoDetalle()
		{
			if (this.documento != null) {
				this.dataGridViewDetalles.SelectedCells[0].Value = this.documento;
			}
			else {
				this.dataGridViewDetalles.SelectedCells[0].Value = "";
			}
			int rowIndex = this.dataGridViewDetalles.SelectedCells[0].RowIndex;
			tipoDocumento = TipoDocumento.Get(this.documento.TipoDocumentoID);
			this.dataGridViewDetalles.Rows[rowIndex].Cells["Concepto"].Value = string.Concat(new string[] {
				"PAGO ",
				tipoDocumento.Descripcion,
				" Numero ",
				tipoDocumento.Codigo,
				"-",
				string.Format("{0:" + this.CalcularCerosIzquierda(tipoDocumento.CerosIzquierda) + "}", this.documento.Consecutivo)
			});
		}
		private void ConfigurarDataGridDocumentos()
		{
			this.dataGridViewDocumentos.AutoGenerateColumns = false;
			var dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			dataGridViewCheckBoxColumn.HeaderText = "Seleccionar";
			dataGridViewCheckBoxColumn.Name = "CheckBoxes";
			dataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewCheckBoxColumn.FlatStyle = FlatStyle.Standard;
			dataGridViewCheckBoxColumn.ThreeState = false;
			dataGridViewCheckBoxColumn.CellTemplate = new DataGridViewCheckBoxCell();
			dataGridViewCheckBoxColumn.CellTemplate.Style.BackColor = Color.Beige;
			dataGridViewCheckBoxColumn.ReadOnly = false;
			int index = this.dataGridViewDocumentos.Columns.Add(dataGridViewCheckBoxColumn);
			this.dataGridViewDocumentos.Columns[index].ReadOnly = false;
			index = this.dataGridViewDocumentos.Columns.Add("Id", "Id");
			this.dataGridViewDocumentos.Columns[index].DataPropertyName = "ID";
			this.dataGridViewDocumentos.Columns[index].Visible = false;
			index = this.dataGridViewDocumentos.Columns.Add("Consecutivo", "Consecutivo");
			this.dataGridViewDocumentos.Columns[index].DataPropertyName = "Consecutivo";
			this.dataGridViewDocumentos.Columns[index].Width = 70;
			this.dataGridViewDocumentos.Columns[index].ReadOnly = true;
			index = this.dataGridViewDocumentos.Columns.Add("FechaDocumento", "FechaDocumento");
			this.dataGridViewDocumentos.Columns[index].DataPropertyName = "FechaDocumento";
			this.dataGridViewDocumentos.Columns[index].Width = 100;
			this.dataGridViewDocumentos.Columns[index].ReadOnly = true;
			this.dataGridViewDocumentos.Columns[index].DefaultCellStyle.Format = "yyyy/MM/dd";
			index = this.dataGridViewDocumentos.Columns.Add("Total", "Total");
			this.dataGridViewDocumentos.Columns[index].DataPropertyName = "Total";
			this.dataGridViewDocumentos.Columns[index].Width = 100;
			this.dataGridViewDocumentos.Columns[index].DefaultCellStyle.Format = formateo;
			this.dataGridViewDocumentos.Columns[index].ReadOnly = true;
			index = this.dataGridViewDocumentos.Columns.Add("TotalAbono", "Abono");
			this.dataGridViewDocumentos.Columns[index].DataPropertyName = "TotalAbono";
			this.dataGridViewDocumentos.Columns[index].DefaultCellStyle.Format = formateo;
			this.dataGridViewDocumentos.Columns[index].Width = 100;
			this.dataGridViewDocumentos.Columns[index].ReadOnly = true;
			index = this.dataGridViewDocumentos.Columns.Add("EstadoDocumento", "EstadoDocumento");
			this.dataGridViewDocumentos.Columns[index].DataPropertyName = "EstadoDocumento";
			this.dataGridViewDocumentos.Columns[index].Width = 150;
			this.dataGridViewDocumentos.Columns[index].ReadOnly = true;
		}

		private void LlenarDataGridDocumentos()
		{
			if (this.tercero != null) {
				if (this.tipoDocumento.Codigo == TipoDocumentoMaestro.COMPROBANTE_EGRESO) {
					TipoDocumentoMaestro tipoDocumentoMaestro = TipoDocumentoMaestro.FindByTipoDocumentoMaestro(TipoDocumentoMaestro.FACTURA_COMPRA);
					this.bindingSource2.DataSource = Documento.FindByTerceroTipoDocumentoMaestroPagado(tipoDocumentoMaestro, this.tercero);
				}
				else {
					TipoDocumentoMaestro tipoDocumentoMaestro2 = TipoDocumentoMaestro.FindByTipoDocumentoMaestro(TipoDocumentoMaestro.FACTURA_VENTA);
					this.bindingSource2.DataSource = Documento.FindByTerceroTipoDocumentoMaestroPagado(tipoDocumentoMaestro2, this.tercero);
				}
			}
			else {
				this.bindingSource2.DataSource = null;
			}
			this.dataGridViewDocumentos.DataSource = this.bindingSource2;
			this.bindingSource2.ResetBindings(false);
		}
		protected string CalcularCerosIzquierda(int p)
		{
			string text = "";
			for (int i = 0; i < p; i++) {
				text += "0";
			}
			return text;
		}
		
		private void FormComprobante_Load(object sender, EventArgs e)
		{
			
			this.dicDetallesComprobante = null;
			this.comprobante = new Comprobante();
			this.comprobante.FechaCreacion = DateTime.Now;
			this.ConfigurarDataGridView();
			this.ConfigurarDataGridDocumentos();
			this.cbCondicion.SelectedIndex = this.cbCondicion.FindStringExact(EFECTIVO);
			this.cbBanco.DataSource = Banco.GetAll();
			this.cbBanco.ValueMember = "Id";
			this.cbBanco.DisplayMember = "Descripcion";
			this.cbBanco.Enabled = true;
			this.rbIngreso.PerformClick();
			this.cbBanco.Enabled = false;
			this.txtNumeroCheque.Enabled = false;
			switch(accion){
				case 1:
					Nuevo();
					break;
			}
		}
		private void rbIngreso_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbIngreso.Checked) {
				this.gbTercero.Text = "RECIBO DE:";
				this.tipoDocumento = TipoDocumento.FindByCodigo(TipoDocumento.COMPROBANTE_INGRESO);
				this.lbConsecutivo.Text = string.Format("{0:" + this.CalcularCerosIzquierda(this.tipoDocumento.CerosIzquierda) + "}", this.tipoDocumento.ConsecutivoActual);
				this.CargarTipoImpresion();
			}
		}
		private void rbEgreso_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbEgreso.Checked) {
				this.gbTercero.Text = "PAGADO A:";
				this.tipoDocumento = TipoDocumento.FindByCodigo(TipoDocumento.COMPROBANTE_EGRESO);
				this.lbConsecutivo.Text = string.Format("{0:" + this.CalcularCerosIzquierda(this.tipoDocumento.CerosIzquierda) + "}", this.tipoDocumento.ConsecutivoActual);
				this.CargarTipoImpresion();
			}
		}
		private void cbCondicion_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Convert.ToString(this.cbCondicion.SelectedItem) == CHEQUE) {
				this.cbBanco.Enabled = true;
				this.txtNumeroCheque.Enabled = true;
				this.txtSucursal.Enabled = true;
				return;
			}
			this.cbBanco.Enabled = false;
			this.txtNumeroCheque.Enabled = false;
			this.txtSucursal.Enabled = false;
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.tercero != null) {
				this.comprobante.TerceroID = this.tercero.ID;
			}
			else {
				stringBuilder.Append("Tercero es requerido!\n");
			}
			if (this.comprobante.Detalles.Count == 0) {
				stringBuilder.Append("No existen detalles! \n");
			}
			IList<DetalleComprobante> detalles = this.comprobante.Detalles;
			foreach (DetalleComprobante current in detalles) {
				if (current.Concepto == string.Empty) {
					stringBuilder.Append("El concepto debe contener una descripción\n");
				}
				if (current.Total <= 0m) {
					stringBuilder.Append("El total debe contener un valor\n");
				}
			}
			if (this.comprobante.Total == 0m) {
				stringBuilder.Append("El total debe contener un valor\n");
			}
			this.comprobante.TipoDocumentoID = this.tipoDocumento.ID;
			this.comprobante.FechaComprobante = new DateTime?(this.dtpFechaCreacion.Value);
			this.comprobante.FormaPago = Convert.ToString(this.cbCondicion.SelectedItem);
			if (this.comprobante.FormaPago == CHEQUE) {
				this.comprobante.NumeroCheque = this.txtNumeroCheque.Text;
				this.comprobante.BancoID = (this.cbBanco.SelectedItem as Banco).ID;
				this.comprobante.Sucursal = this.txtSucursal.Text;
			}
			this.comprobante.Observacion = this.txtObservacion.Text;
			this.comprobante.ImpresionDocumentoID = (this.cbImpresionComprobante.SelectedItem as ImpresionDocumento).ID;
			if (stringBuilder.Length > 0) {
				MessageBox.Show(stringBuilder.ToString(), "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			this.comprobante.UsuarioID = Entorno.USUARIO.ID;
			if (this.comprobante.ID == 0) {
				//this.tipoDocumento.Load();
				this.comprobante.Consecutivo = this.tipoDocumento.ConsecutivoActual;
				this.comprobante.Save();
				
				this.tipoDocumento.ConsecutivoActual++;
				this.tipoDocumento.Update();
				using (IEnumerator<DetalleComprobante> enumerator2 = this.comprobante.Detalles.GetEnumerator()) {
					while (enumerator2.MoveNext()) {
						DetalleComprobante current2 = enumerator2.Current;
						if (current2.Documento != null) {
							documento = current2.Documento;
							//documento.LoadByComprobante(comprobante);
							documento.TotalAbono += current2.Total + current2.Retencion + current2.Descuento;
							if (preferencias.RedondeoSistema) {
								documento.TotalAbono = Math.Round(documento.TotalAbono, preferencias.NumeroDecimal);
							}
							else {
								if (preferencias.RedondeoInferior) {
									documento.TotalAbono = Math.Floor(documento.TotalAbono);
								}
								else {
									if (preferencias.RedondeoSuperior) {
										documento.TotalAbono = Math.Ceiling(documento.TotalAbono);
									}
								}
							}
							if (documento.TotalAbono >= documento.Total) {
								documento.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO).ID;
							}
							else {
								documento.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO_PARCIALMENTE).ID;
							}
							documento.Update();
						}
					}
					
				}
			}
			if (this.dicDetallesComprobante != null && this.dicDetallesComprobante.Count > 0) {
				foreach (KeyValuePair<Documento, decimal> current3 in this.dicDetallesComprobante) {
					Documento key = current3.Key;
					//key.LoadByComprobante();
					key.TotalAbono -= current3.Value;
					if (key.TotalAbono == 0m) {
						key.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.FACTURADO).ID;
					}
					else {
						key.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO_PARCIALMENTE).ID;
					}
					key.Update();
				}
			}
			foreach (DetalleComprobante current4 in this.comprobante.Detalles) {
				if (current4.Documento != null) {
					Documento documento2 = current4.Documento;
					//documento2.LoadByComprobante();
					documento2.TotalAbono += current4.Total + current4.Retencion + current4.Descuento;
					if (documento2.TotalAbono >= documento2.Total) {
						documento2.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO).ID;
					}
					else {
						documento2.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO_PARCIALMENTE).ID;
					}
					documento2.Update();
				}
			}
			this.comprobante.Update();
			MessageBox.Show("Comprobante grabado con exito!", "SoluPYME " + Entorno.VERSION, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		private void Nuevo()
		{
			this.dicDetallesComprobante = null;
			this.comprobante = new Comprobante();
			this.comprobante.FechaCreacion = DateTime.Now;
			if (this.rbIngreso.Checked) {
				this.tipoDocumento = TipoDocumento.FindByCodigo(TipoDocumento.COMPROBANTE_INGRESO);
				this.lbConsecutivo.Text = string.Format("{0:" + this.CalcularCerosIzquierda(this.tipoDocumento.CerosIzquierda) + "}", this.tipoDocumento.ConsecutivoActual);
			}
			else {
				this.tipoDocumento = TipoDocumento.FindByCodigo(TipoDocumento.COMPROBANTE_EGRESO);
				this.lbConsecutivo.Text = string.Format("{0:" + this.CalcularCerosIzquierda(this.tipoDocumento.CerosIzquierda) + "}", this.tipoDocumento.ConsecutivoActual);
			}
			
			this.ResetComprobante();
			this.LlenarDataGrid();
			this.LlenarDataGridDocumentos();
		}
		
		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			new FrmBuscarTercero {
				TipoDocumento = this.tipoDocumento
			}.ShowDialog(this);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (this.tabControlDetalle.SelectedTab.Name == "tabPageDocumentos") {
				return;
			}
			var detalleComprobante = new DetalleComprobante();
			detalleComprobante.Concepto = string.Empty;
			if (this.tercero != null) {
				this.comprobante.Detalles.Add(detalleComprobante);
				this.LlenarDataGrid();
				this.EvaluarTercero();
				this.dataGridViewDetalles.Focus();
				return;
			}
			MessageBox.Show("Tercero es requerido!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (this.tabControlDetalle.SelectedTab.Name == "tabPageDocumentos") {
				return;
			}
			if (this.dataGridViewDetalles.SelectedCells.Count > 0) {
				foreach (DataGridViewCell dataGridViewCell in this.dataGridViewDetalles.SelectedCells) {
					this.dataGridViewDetalles.Rows.Remove(dataGridViewCell.OwningRow);
				}
				this.CalcularTotales();
				this.EvaluarTercero();
			}
		}

		private void dataGridViewDetalles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewDetalles.Columns[e.ColumnIndex].Name == "TotalDocumento" || this.dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Descuento" || this.dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Retencion") {
				this.RefrescarDetalleComprobanteGrid(e.RowIndex);
			}
			this.CalcularTotales();
		}

		private void dataGridViewDetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Documento") {
				if (this.tercero != null) {
					new FrmBuscarDocumentoComprobante {
						Tercero = this.tercero,
						TipoDocumento = this.tipoDocumento
					}.ShowDialog(this);
					return;
				}
				MessageBox.Show("No ha seleccionado tercero!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void dataGridViewDetalles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value != null) {
				if (e.Value is Documento) {
					documento = (Documento)e.Value;
					tipoDocumento = TipoDocumento.Get(documento.TipoDocumentoID);
					e.Value = tipoDocumento.Codigo + "-" + string.Format("{0:" + this.CalcularCerosIzquierda(tipoDocumento.CerosIzquierda) + "}", documento.Consecutivo);
				}
				if ((this.dataGridViewDetalles.Columns[e.ColumnIndex].Name == "TotalDocumento" || this.dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Descuento" || this.dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Retencion" || this.dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Total") && this.tipoDocumento.CantidadDecimal > 0) {
					e.CellStyle.Format = "##0" + this.CalcularNumeroDecimal(this.tipoDocumento.CantidadDecimal);
				}
			}
		}

		

		private void tabControlDetalle_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.tabControlDetalle.SelectedTab.Name == "tabPageDocumentos") {
				if (this.tercero != null) {
					this.LlenarDataGridDocumentos();
					Dictionary <string, bool> dictionary = new Dictionary<string, bool>();
					foreach (KeyValuePair<string, bool> current in this.documentos) {
						string key = current.Key;
						bool arg_5F_0 = current.Value;
						if (!dictionary.ContainsKey(key)) {
							dictionary.Add(key, false);
						}
						foreach (DetalleComprobante current2 in this.comprobante.Detalles) {
							if (current2.Documento != null) {
								string b = current2.Documento.ID.ToString();
								if (key == b) {
									dictionary[key] = true;
								}
							}
						}
					}
					using (Dictionary<string, bool>.Enumerator enumerator3 = dictionary.GetEnumerator()) {
						while (enumerator3.MoveNext()) {
							KeyValuePair<string, bool> current3 = enumerator3.Current;
							this.documentos[current3.Key] = current3.Value;
						}
					}
				}
				MessageBox.Show("No existe tercero!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.lbMensaje.Text = "Para vincular un documento click en casilla seleccionar y pasar a concepto";
				this.btnAdd.Enabled = false;
				this.btnRemove.Enabled = false;
				return;
			}
			Dictionary<string, bool> dictionary2 = new Dictionary<string, bool>();
			foreach (KeyValuePair<string, bool> current4 in this.documentos) {
				long guid = long.Parse(current4.Key);
				bool value = current4.Value;
				bool flag = false;
				foreach (DetalleComprobante current5 in this.comprobante.Detalles) {
					if (current5.Documento != null && current5.Documento.ID == guid) {
						dictionary2.Add(current4.Key, true);
						flag = true;
						break;
					}
				}
				if (!flag && value) {
					Documento documento = Documento.Get(guid);
					this.AdicionarConcepto(documento);
				}
			}
			foreach (KeyValuePair<string, bool> current6 in dictionary2) {
				this.documentos[current6.Key] = current6.Value;
			}
			this.LlenarDataGrid();
			this.EvaluarTercero();
			this.CalcularTotales();
			this.lbMensaje.Text = "(+) y doble click en la casilla documento o doble click en la casilla concepto -editar-.";
			this.btnAdd.Enabled = true;
			this.btnRemove.Enabled = true;
		}		

		private string GetKey(DataGridViewCellValueEventArgs cell)
		{
			return this.dataGridViewDocumentos.Rows[cell.RowIndex].Cells["Id"].Value.ToString();
		}

		private bool IsCheckBoxColumn(int columnIndex)
		{
			DataGridViewColumn dataGridViewColumn = this.dataGridViewDocumentos.Columns["CheckBoxes"];
			return this.dataGridViewDocumentos.Columns[columnIndex] == dataGridViewColumn;
		}

		private void dataGridViewDocumentos_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			if (this.IsCheckBoxColumn(e.ColumnIndex)) {
				string key = this.GetKey(e);
				if (!this.documentos.ContainsKey(key)) {
					bool value = false;
					this.documentos.Add(key, value);
				}
				e.Value = this.documentos[key];
			}
		}

		private void dataGridViewDocumentos_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
		{
			if (this.IsCheckBoxColumn(e.ColumnIndex)) {
				string key = this.GetKey(e);
				if (!this.documentos.ContainsKey(key)) {
					this.documentos.Add(key, (bool)e.Value);
					return;
				}
				this.documentos[key] = (bool)e.Value;
			}
		}

		private void btnVistaPrevia_Click(object sender, EventArgs e)
		{
			FrmImpresionDocumento formImpresionDocumento = new FrmImpresionDocumento();
			if (string.IsNullOrEmpty(this.comprobante.ImpresionDocumentoID.ToString())) {
				MessageBox.Show("No existen comprobantes de impresion vinculados o no se ha grabado!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (this.comprobante.Consecutivo != 0) {
				formImpresionDocumento.Comprobante = this.comprobante;
				formImpresionDocumento.ShowDialog(this);
				return;
			}
			MessageBox.Show("No se puede imprimir porque no se ha grabado!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			new FrmBuscarComprobante {
				TipoDocumento = this.tipoDocumento
			}.ShowDialog(this);
		}

		private void dataGridViewDocumentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value is EstadoDocumento) {
				EstadoDocumento estadoDocumento = (EstadoDocumento)e.Value;
				//estadoDocumento.Load();
				e.Value = estadoDocumento.Descripcion;
			}
		}

		private void btnAnular_Click(object sender, EventArgs e)
		{
			if (comprobante.ID != 0) {
				if (new FrmAnularComprobante {
					Comprobante = this.comprobante
				}.ShowDialog(this) != DialogResult.Cancel) {
					//this.btnNuevo.PerformClick();
					return;
				}
			}
			else {
				MessageBox.Show("No se puede anular porque no se ha grabado!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}
