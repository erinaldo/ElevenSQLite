/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 13/09/2017
 * Hora: 10:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;
using ElevenSQLite.ElevenUtils;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmTipoDocumento.
	/// </summary>
	public partial class FrmTipoDocumento : Form
	{
		int accion = 0;
		static string NOMBRE_CUENTA = "Nombre Cuenta";
		static string CUENTA_CONTABLE = "Cuenta contable";
		static string NATURALEZA = "Naturaleza";
		static string MONEDA_DEFECTO = "3";
		
		static Preferencias preferencias = Preferencias.Get(Entorno.USUARIO);
		IntegracionContable integracion;
		static Empresa empresa = Empresa.Get();		
		public TipoDocumento TipoDocumento { set; get; }
		
		public FrmTipoDocumento()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			accion = 1;
			TipoDocumento = new TipoDocumento();
			TipoDocumento.FechaCreacion = DateTime.Now;									
		}
		public FrmTipoDocumento(TipoDocumento td)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			accion = 2;
			TipoDocumento = td;
		}
		void TipoDocumento2Form()
		{
			TipoDocumento = TipoDocumento.Get(TipoDocumento.ID);
			txtCodigo.Text = TipoDocumento.Codigo;
			txtDescripcion.Text = TipoDocumento.Descripcion;
			txtInicial.Text = Convert.ToString(TipoDocumento.ConsecutivoInicial);
			txtFinal.Text = Convert.ToString(TipoDocumento.ConsecutivoFinal);
			txtActual.Text = Convert.ToString(TipoDocumento.ConsecutivoActual);
			txtSufijo.Text = TipoDocumento.Sufijo;
			txtPrefijo.Text = TipoDocumento.Prefijo;
			cbTipoDocumentoMaestro.SelectedValue = TipoDocumento.TipoDocumentoMaestroID.GetValueOrDefault();
			cbTipoDocumentoMaestro.Enabled = true;
			if (TipoDocumento.Factor == TipoDocumento.FACTOR_NULO) {
				rbNeutral.Checked = true;
			}
			else {
				if (TipoDocumento.Factor == TipoDocumento.FACTOR_RESTA) {
					rbResta.Checked = true;
				}
				else {
					if (TipoDocumento.Factor == TipoDocumento.FACTOR_SUMA) {
						rbSuma.Checked = true;
					}
				}
			}
			nudIndice.Value = TipoDocumento.Indice;
			nudCantidadDecimales.Value = TipoDocumento.CantidadDecimal;
			nudCerosIzquierda.Value = TipoDocumento.CerosIzquierda;
			nudLimiteRegistros.Value = TipoDocumento.LimiteRegistro;
			cbTipoMoneda.SelectedValue = TipoDocumento.TipoMonedaID;
			if (TipoDocumento.TipoFacturacion == Tercero.REGIMEN_COMUN) {
				rbRC.Checked = true;
			}
			else {
				rbRS.Checked = true;
			}
			checkIvaIncluido.Checked = TipoDocumento.IvaIncluido;
			txtAutorizacion.Text = TipoDocumento.Autorizacion;
			dtpFechaAutorizacion.Value = (TipoDocumento.FechaAutorizacion ?? DateTime.Now);
			txtNumeracionDesde.Text = TipoDocumento.NumeracionDianDesde;
			txtNumeracionHasta.Text = TipoDocumento.NumeracionDianHasta;
			txtColor.Text = TipoDocumento.ColorConsecutivo;
			checkFondoPapel.Checked = TipoDocumento.FondoPapel;
			checkImpresionEncabezado.Checked = TipoDocumento.ImpresionEncabezado;
			checkImpresionLogotipo.Checked = TipoDocumento.ImpresionLogotipo;
			checkImpresionDetalleCantidad.Checked = TipoDocumento.ImpresionDetalleCantidad;
			checkImpresionDetalleDescuento.Checked = TipoDocumento.ImpresionDetalleDescuento;
			checkImpresionDetalleIVA.Checked = TipoDocumento.ImpresionDetalleIVA;
			checkImpresionDetalleCodigo.Checked = TipoDocumento.ImpresionDetalleCodigo;
			checkRedondeo.Checked = TipoDocumento.RedondeoAutomatico;
			checkCliente.Checked = TipoDocumento.ClienteNacional;
			checkClienteExterior.Checked = TipoDocumento.ClienteExtranjero;
			checkProveedor.Checked = TipoDocumento.ProveedorNacional;
			checkProveedorExterior.Checked = TipoDocumento.ProveedorExtranjero;
			checkInterno.Checked = TipoDocumento.Interno;
			checkOtro.Checked = TipoDocumento.OtroTipoTercero;
			checkObservacion1.Checked = TipoDocumento.MensajeGeneral;
			checkObservacion2.Checked = TipoDocumento.OtroMensaje;
			checkComprobante.Checked = TipoDocumento.Comprobante;
			integracion = IntegracionContable.FindByTipoDocumento(TipoDocumento);
			TipoDocumentoMaestro tipoDocumentoMaestro = ( cbTipoDocumentoMaestro.SelectedItem as TipoDocumentoMaestro);
			if (tipoDocumentoMaestro.EstadoDocumentoID != null) {
				cbEstadoDocumento.SelectedValue = tipoDocumentoMaestro.EstadoDocumentoID;
			}
			if (TipoDocumento != null && TipoDocumento.EstadoDocumentoID != null) {
				cbEstadoDocumento.SelectedValue = TipoDocumento.EstadoDocumentoID;
			}
			if (tipoDocumentoMaestro.ImpresionDocumentoID != null) {
				cbImpresionDocumento.SelectedValue = tipoDocumentoMaestro.ImpresionDocumentoID;
			}
			if (TipoDocumento != null && TipoDocumento.ImpresionDocumentoID != null) {
				cbImpresionDocumento.SelectedValue = TipoDocumento.ImpresionDocumentoID;
			}
			
		}
		DataGridViewCheckBoxColumn CreateCheckBoxColumn(string cabeza, string nombre)
		{
			return new DataGridViewCheckBoxColumn {
				HeaderText = cabeza,
				Name = nombre,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
				FlatStyle = FlatStyle.Standard,
				ThreeState = false,
				//CellTemplate = new DataGridViewCheckBoxCell(),
				CellTemplate =  {
					Style =  {
						BackColor = Color.Beige
					}
				},
				ReadOnly = true
			};
		}
		void LlenarPermisosTipoDocumento()
		{
			dataGridViewPermisos.AutoGenerateColumns = false;
			int index = dataGridViewPermisos.Columns.Add("Usuario", "Usuario");
			dataGridViewPermisos.Columns[index].DataPropertyName = "Usuario";
			dataGridViewPermisos.Columns[index].ReadOnly = true;
			dataGridViewPermisos.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			index = dataGridViewPermisos.Columns.Add(CreateCheckBoxColumn("Nuevo", "Nuevo"));
			index = dataGridViewPermisos.Columns.Add(CreateCheckBoxColumn("Modificar", "Modificar"));
			index = dataGridViewPermisos.Columns.Add(CreateCheckBoxColumn("Anular", "Anular"));
			index = dataGridViewPermisos.Columns.Add(CreateCheckBoxColumn("Eliminar", "Eliminar"));
			index = dataGridViewPermisos.Columns.Add(CreateCheckBoxColumn("Imprimir", "Imprimir"));
			if (TipoDocumento.ID == 0) {
				bindingSource2.DataSource = null;
			}
			else {
				bindingSource2.DataSource = PermisoTipoDocumento.FindByTipoDocumento(TipoDocumento);
			}
			dataGridViewPermisos.DataSource = bindingSource2;
		}

		void LlenarImpresionDocumento()
		{
			TipoDocumentoMaestro tipoDocumentoMaestro = (TipoDocumentoMaestro)cbTipoDocumentoMaestro.SelectedItem;
			//TipoDocumentoMaestroFactory().Load(tipoDocumentoMaestro);
			tipoDocumentoMaestro.Load();
			IList<ImpresionDocumento> impresionesDocumento = tipoDocumentoMaestro.ImpresionesDocumento;
			if (impresionesDocumento != null && impresionesDocumento.Count > 0) {
				cbImpresionDocumento.DataSource = impresionesDocumento;
				cbImpresionDocumento.DisplayMember = "Descripcion";
				cbImpresionDocumento.ValueMember = "ID";
				return;
			}
			cbImpresionDocumento.DataSource = null;
		}

		void LlenarEstadoDocumento()
		{
			TipoDocumentoMaestro tipoDocumentoMaestro = (TipoDocumentoMaestro)cbTipoDocumentoMaestro.SelectedItem;			
			tipoDocumentoMaestro.Load();			
			cbEstadoDocumento.DataSource = tipoDocumentoMaestro.EstadosDocumento;
			cbEstadoDocumento.DisplayMember = "Descripcion";
			cbEstadoDocumento.ValueMember = "ID";
			cbEstadoDocumento.SelectedValue = "3";
			if (tipoDocumentoMaestro.EstadoDocumentoID != null) {
				cbEstadoDocumento.SelectedValue = tipoDocumentoMaestro.EstadoDocumentoID;
			}
		}

		void LlenarContabilidad()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add(NOMBRE_CUENTA);
			dataTable.Columns.Add(CUENTA_CONTABLE);
			dataTable.Columns.Add(new DataColumn(NATURALEZA, typeof(string)));
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[0][0] = "INVENTARIO GRABADO";
			dataTable.Rows[0][1] = integracion.InventarioGrabado;
			dataTable.Rows[0][2] = integracion.NaturalezaInventarioGrabado;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[1][0] = "INVENTARIO EXCENTO";
			dataTable.Rows[1][1] = integracion.InventarioExcento;
			dataTable.Rows[1][2] = integracion.NaturalezaInventarioExcento;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[2][0] = "INVENTARIO EXCLUIDO";
			dataTable.Rows[2][1] = integracion.InventarioExcluido;
			dataTable.Rows[2][2] = integracion.NaturalezaInventarioExcluido;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[3][0] = "COSTO MERCANCIA";
			dataTable.Rows[3][1] = integracion.CostoMercancia;
			dataTable.Rows[3][2] = integracion.NaturalezaCostoMercancia;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[4][0] = "CAJA O BANCOS";
			dataTable.Rows[4][1] = integracion.CajaBanco;
			dataTable.Rows[4][2] = integracion.NaturalezaCajaBanco;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[5][0] = "COMPRAS";
			dataTable.Rows[5][1] = integracion.Compra;
			dataTable.Rows[5][2] = integracion.NaturalezaCompra;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[6][0] = "VENTAS";
			dataTable.Rows[6][1] = integracion.Venta;
			dataTable.Rows[6][2] = integracion.NaturalezaVenta;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[7][0] = "CUENTAS POR PAGAR";
			dataTable.Rows[7][1] = integracion.CuentaPagar;
			dataTable.Rows[7][2] = integracion.NaturalezaCuentaPagar;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[8][0] = "CUENTAS POR COBRAR";
			dataTable.Rows[8][1] = integracion.CuentaCobrar;
			dataTable.Rows[8][2] = integracion.NaturalezaCuentaCobrar;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[9][0] = "DESCUENTOS";
			dataTable.Rows[9][1] = integracion.Descuento;
			dataTable.Rows[9][2] = integracion.NaturalezaDescuento;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[10][0] = "GASTOS";
			dataTable.Rows[10][1] = integracion.Gasto;
			dataTable.Rows[10][2] = integracion.NaturalezaGasto;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[11][0] = "RETENCION";
			dataTable.Rows[11][1] = integracion.Retencion;
			dataTable.Rows[11][2] = integracion.NaturalezaRetencion;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[12][0] = "FLETES";
			dataTable.Rows[12][1] = integracion.Fletes;
			dataTable.Rows[12][2] = integracion.NaturalezaFletes;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[13][0] = "ANTICIPOS";
			dataTable.Rows[13][1] = integracion.Anticipos;
			dataTable.Rows[13][2] = integracion.NaturalezaAnticipos;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[14][0] = "PRONTO PAGO";
			dataTable.Rows[14][1] = integracion.ProntoPago;
			dataTable.Rows[14][2] = integracion.NaturalezaProntoPago;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[15][0] = "IVA (16%)";
			dataTable.Rows[15][1] = integracion.Iva;
			dataTable.Rows[15][2] = integracion.NaturalezaIva;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[16][0] = "RETENCION DE IVA";
			dataTable.Rows[16][1] = integracion.RetencionIVA;
			dataTable.Rows[16][2] = integracion.NaturalezaRetencionIVA;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[17][0] = "RETENCION DE ICA";
			dataTable.Rows[17][1] = integracion.RetencionICA;
			dataTable.Rows[17][2] = integracion.NaturalezaRetencionICA;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[18][0] = "DEVOLUCION IVA";
			dataTable.Rows[18][1] = integracion.DevolucionIVA;
			dataTable.Rows[18][2] = integracion.NaturalezaDevolucionIVA;
			dataTable.Rows.Add(dataTable.NewRow());
			dataTable.Rows[19][0] = "DEVOLUCION RETENCION";
			dataTable.Rows[19][1] = integracion.DevolucionRetencion;
			dataTable.Rows[19][2] = integracion.NaturalezaDevolucionRetencion;
			DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
			dataGridViewComboBoxColumn.HeaderText = NATURALEZA;
			dataGridViewComboBoxColumn.Items.AddRange(new object[] {
				"DB",
				"CR"
			});
			dataGridViewComboBoxColumn.Name = NATURALEZA;
			dataGridViewContabilidad.AutoGenerateColumns = false;
			int index = dataGridViewContabilidad.Columns.Add(NOMBRE_CUENTA, NOMBRE_CUENTA);
			dataGridViewContabilidad.Columns[index].DataPropertyName = NOMBRE_CUENTA;
			dataGridViewContabilidad.Columns[NOMBRE_CUENTA].Width = 150;
			index = dataGridViewContabilidad.Columns.Add(CUENTA_CONTABLE, CUENTA_CONTABLE);
			dataGridViewContabilidad.Columns[index].DataPropertyName = CUENTA_CONTABLE;
			dataGridViewContabilidad.Columns[CUENTA_CONTABLE].Width = 120;
			index = dataGridViewContabilidad.Columns.Add(dataGridViewComboBoxColumn);
			dataGridViewContabilidad.Columns[index].DataPropertyName = NATURALEZA;
			dataGridViewContabilidad.Columns[NATURALEZA].Width = 60;
			bindingSource1.DataSource = dataTable;
			dataGridViewContabilidad.DataSource = bindingSource1;
		}

		void LlenarTipoMoneda()
		{
			//IList<TipoMoneda> all = new TipoMonedaFactory().GetAll();
			cbTipoMoneda.DataSource = TipoMoneda.GetAll();
			cbTipoMoneda.DisplayMember = "Descripcion";
			cbTipoMoneda.ValueMember = "ID";
			cbTipoMoneda.SelectedIndex = 0;
		}

		void LlenarTipoDocumentoMaestro()
		{
			//IList<TipoDocumentoMaestro> all = new TipoDocumentoMaestroFactory().GetAll();
			cbTipoDocumentoMaestro.DataSource = TipoDocumentoMaestro.GetAll();
			cbTipoDocumentoMaestro.DisplayMember = "Descripcion";
			cbTipoDocumentoMaestro.ValueMember = "ID";
		}
		
		void FormTipoDocumento_Load(object sender, EventArgs e)
		{
			LlenarTipoDocumentoMaestro();
			LlenarTipoMoneda();
			if( accion ==2 ) TipoDocumento2Form();
			cbTipoMoneda.SelectedIndex = cbTipoMoneda.FindStringExact(MONEDA_DEFECTO);			
			if (integracion == null) {
				integracion = new IntegracionContable();
				integracion.FechaCreacion = default(DateTime);
				integracion.TipoDocumentoID = TipoDocumento.ID;
			}
			LlenarContabilidad();
			LlenarPermisosTipoDocumento();
			TipoMoneda tipoMoneda = TipoMoneda.Get(preferencias.TipoMonedaID.GetValueOrDefault());
			if (tipoMoneda != null) {
				MONEDA_DEFECTO = tipoMoneda.Descripcion;
			}
		}
		
		void dataGridViewPermisos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			PermisoTipoDocumento permisoTipoDocumento = (dataGridViewPermisos.Rows[e.RowIndex].DataBoundItem as PermisoTipoDocumento);
			if (dataGridViewPermisos.Columns[e.ColumnIndex].Name == "Usuario") {
				Usuario usuario = Usuario.Get(permisoTipoDocumento.UsuarioID.GetValueOrDefault());
				e.Value = usuario.NombreUsuario;
			}
			if (dataGridViewPermisos.Columns[e.ColumnIndex].Name == "Nuevo") {
				e.Value = permisoTipoDocumento.Nuevo;
			}
			if (dataGridViewPermisos.Columns[e.ColumnIndex].Name == "Modificar") {
				e.Value = permisoTipoDocumento.Modificar;
			}
			if (dataGridViewPermisos.Columns[e.ColumnIndex].Name == "Imprimir") {
				e.Value = permisoTipoDocumento.Imprimir;
			}
			if (dataGridViewPermisos.Columns[e.ColumnIndex].Name == "Eliminar") {
				e.Value = permisoTipoDocumento.Eliminar;
			}
			if (dataGridViewPermisos.Columns[e.ColumnIndex].Name == "Anular") {
				e.Value = permisoTipoDocumento.Anular;
			}
		}
		void btnColor_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() != DialogResult.Cancel) {
				string text = ColorTranslator.ToHtml(colorDialog1.Color);
				txtColor.Text = text;
			}
		}
		void cbTipoDocumentoMaestro_SelectedIndexChanged(object sender, EventArgs e)
		{
			LlenarImpresionDocumento();
			LlenarEstadoDocumento();
		}
		void FormTipoDocumento_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}
		void btnAceptar_Click(object sender, EventArgs e)
		{
			TipoDocumento.Codigo = txtCodigo.Text;
			TipoDocumento.Descripcion = txtDescripcion.Text;
			TipoDocumento.ConsecutivoActual = Convert.ToInt32(txtActual.Text);
			TipoDocumento.ConsecutivoFinal = Convert.ToInt32(txtFinal.Text);
			TipoDocumento.ConsecutivoInicial = Convert.ToInt32(txtInicial.Text);
			if (rbNeutral.Checked) {
				TipoDocumento.Factor = TipoDocumento.FACTOR_NULO;
			}
			else {
				if (rbSuma.Checked) {
					TipoDocumento.Factor = TipoDocumento.FACTOR_SUMA;
				}
				else {
					if (rbResta.Checked) {
						TipoDocumento.Factor = TipoDocumento.FACTOR_RESTA;
					}
				}
			}
			TipoDocumento.TipoDocumentoMaestroID = (cbTipoDocumentoMaestro.SelectedItem as TipoDocumentoMaestro).ID;
			TipoDocumento.Indice = Convert.ToInt32(nudIndice.Value);
			TipoDocumento.Prefijo = txtPrefijo.Text;
			TipoDocumento.Sufijo = txtSufijo.Text;
			TipoDocumento.CantidadDecimal = Convert.ToInt32(nudCantidadDecimales.Value);
			TipoDocumento.CerosIzquierda = Convert.ToInt32(nudCerosIzquierda.Value);
			TipoDocumento.LimiteRegistro = Convert.ToInt32(nudLimiteRegistros.Value);
			TipoDocumento.FondoPapel = checkFondoPapel.Checked;
			TipoDocumento.ImpresionEncabezado = checkImpresionEncabezado.Checked;
			TipoDocumento.ImpresionLogotipo = checkImpresionLogotipo.Checked;
			TipoDocumento.ImpresionDetalleCantidad = checkImpresionDetalleCantidad.Checked;
			TipoDocumento.ImpresionDetalleDescuento = checkImpresionDetalleDescuento.Checked;
			TipoDocumento.ImpresionDetalleIVA = checkImpresionDetalleIVA.Checked;
			TipoDocumento.ImpresionDetalleCodigo = checkImpresionDetalleCodigo.Checked;
			TipoDocumento.RedondeoAutomatico = checkRedondeo.Checked;
			TipoDocumento.ColorConsecutivo = txtColor.Text;
			TipoDocumento.OtroTipoTercero = checkOtro.Checked;
			TipoDocumento.ProveedorExtranjero = checkProveedorExterior.Checked;
			TipoDocumento.ProveedorNacional = checkProveedor.Checked;
			TipoDocumento.ClienteExtranjero = checkClienteExterior.Checked;
			TipoDocumento.ClienteNacional = checkCliente.Checked;
			TipoDocumento.Interno = checkInterno.Checked;
			TipoDocumento.Comprobante = checkComprobante.Checked;
			if(cbTipoMoneda.SelectedItem != null) 
				TipoDocumento.TipoMonedaID = (cbTipoMoneda.SelectedItem as TipoMoneda).ID;
			TipoDocumento.TipoFacturacion = rbRC.Checked ? Tercero.REGIMEN_COMUN : Tercero.REGIMEN_SIMPLIFICADO;
			TipoDocumento.IvaIncluido = checkIvaIncluido.Checked;
			TipoDocumento.Autorizacion = txtAutorizacion.Text;
			TipoDocumento.FechaAutorizacion = new DateTime?(dtpFechaAutorizacion.Value);
			TipoDocumento.NumeracionDianHasta = txtNumeracionHasta.Text;
			TipoDocumento.NumeracionDianDesde = txtNumeracionDesde.Text;
			TipoDocumento.ImpresionDocumentoID = (cbImpresionDocumento.SelectedItem as ImpresionDocumento).ID;
			TipoDocumento.EstadoDocumentoID = (cbEstadoDocumento.SelectedItem as EstadoDocumento).ID;
			TipoDocumento.MensajeGeneral = checkObservacion1.Checked;
			TipoDocumento.OtroMensaje = checkObservacion2.Checked;
			switch (accion) {
				case 1:
					TipoDocumento.Save();
					foreach (var current in Usuario.GetAll()) {
						var permisoTipoDocumento = new PermisoTipoDocumento();
						permisoTipoDocumento.FechaCreacion = DateTime.Now;
						permisoTipoDocumento.UsuarioID = current.ID;
						permisoTipoDocumento.TipoDocumentoID = TipoDocumento.ID;
						permisoTipoDocumento.Nuevo = true;
						permisoTipoDocumento.Modificar = true;
						permisoTipoDocumento.Anular = true;
						permisoTipoDocumento.Eliminar = true;
						permisoTipoDocumento.Imprimir = true;
						permisoTipoDocumento.Save();
					}
					break;
				case 2:
					TipoDocumento.Update();
					break;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (DataGridViewRow dataGridViewRow in ((IEnumerable)dataGridViewContabilidad.Rows)) {
				if (dataGridViewRow.Cells[CUENTA_CONTABLE].Value != DBNull.Value && dataGridViewRow.Cells[NATURALEZA].Value != DBNull.Value) {
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "INVENTARIO GRABADO") {
						integracion.InventarioGrabado = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaInventarioGrabado = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "INVENTARIO EXCENTO") {
						integracion.InventarioExcento = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaInventarioExcento = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "INVENTARIO EXCLUIDO") {
						integracion.InventarioExcluido = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaInventarioExcluido = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "COSTO MERCANCIA") {
						integracion.CostoMercancia = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaCostoMercancia = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "CAJA O BANCOS") {
						integracion.CajaBanco = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaCajaBanco = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "COMPRA") {
						integracion.Compra = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaCompra = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "VENTA") {
						integracion.Venta = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaVenta = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "CUENTA PAGAR") {
						integracion.CuentaPagar = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaCuentaPagar = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "CUENTA COBRAR") {
						integracion.CuentaCobrar = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaCuentaCobrar = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "DESCUENTO") {
						integracion.Descuento = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaDescuento = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "GASTO") {
						integracion.Gasto = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaGasto = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "RETENCION") {
						integracion.Retencion = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaRetencion = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "FLETES") {
						integracion.Fletes = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaFletes = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "ANTICIPOS") {
						integracion.Anticipos = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaAnticipos = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "PRONTO PAGO") {
						integracion.ProntoPago = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaProntoPago = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "IVA (16%)") {
						integracion.Iva = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaIva = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "RETENCION DE IVA") {
						integracion.RetencionIVA = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaRetencionIVA = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "RETENCION DE ICA") {
						integracion.RetencionICA = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaRetencionICA = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "DEVOLUCION IVA") {
						integracion.DevolucionIVA = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaDevolucionIVA = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
					if ((string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value == "DEVOLUCION RETENCION") {
						integracion.DevolucionRetencion = (string)dataGridViewRow.Cells[CUENTA_CONTABLE].Value;
						integracion.NaturalezaDevolucionRetencion = (string)dataGridViewRow.Cells[NATURALEZA].Value;
					}
				}
				else {
					if (dataGridViewRow.Cells[CUENTA_CONTABLE].Value != DBNull.Value && dataGridViewRow.Cells[NATURALEZA].Value == DBNull.Value) {
						stringBuilder.AppendLine("La Naturaleza contable " + (string)dataGridViewRow.Cells[NOMBRE_CUENTA].Value + " es requerida!");
					}
				}
			}
			integracion.UsuarioID = Entorno.USUARIO.ID;
			integracion.Save();
			MessageBox.Show("Tipo documento grabado con exito!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			if (stringBuilder.Length > 0) {
				MessageBox.Show("No se grabaron algunas cuentas contables!\n" + stringBuilder.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			DialogResult = DialogResult.OK;
			base.Close();
		}
	}
}
