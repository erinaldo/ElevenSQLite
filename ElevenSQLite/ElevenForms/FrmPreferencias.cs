/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 12/09/2017
 * Hora: 17:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;
using ElevenSQLite.ElevenUtils;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmPreferencias.
	/// </summary>
	public partial class FrmPreferencias : Form
	{
		private Preferencias preferencias;
		private Empresa empresa;
		private Tercero tercero;
		private string TIPO_MONEDA = "PESO";
		private Bitmap MyImage;
		
		
		public FrmPreferencias()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		private DataGridViewCheckBoxColumn CreateCheckBoxColumn(string cabeza, string nombre)
		{
			return new DataGridViewCheckBoxColumn {
				HeaderText = cabeza,
				Name = nombre,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
				FlatStyle = FlatStyle.Standard,
				ThreeState = false,
				CellTemplate = new DataGridViewCheckBoxCell(),
				ReadOnly = true
			};
		}
		private void CargarTipoDocumento()
		{
			int index = dataGridViewTipoDocumentoMaestro.Columns.Add("Codigo", "Codigo");
			dataGridViewTipoDocumentoMaestro.Columns[index].DataPropertyName = "Codigo";
			dataGridViewTipoDocumentoMaestro.Columns[index].ReadOnly = true;
			dataGridViewTipoDocumentoMaestro.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			index = dataGridViewTipoDocumentoMaestro.Columns.Add("Descripcion", "Descripcion");
			dataGridViewTipoDocumentoMaestro.Columns[index].DataPropertyName = "Descripcion";
			dataGridViewTipoDocumentoMaestro.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			index = dataGridViewTipoDocumentoMaestro.Columns.Add("ConsecutivoInicial", "Inicial");
			dataGridViewTipoDocumentoMaestro.Columns[index].DataPropertyName = "ConsecutivoInicial";
			dataGridViewTipoDocumentoMaestro.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			index = dataGridViewTipoDocumentoMaestro.Columns.Add("ConsecutivoFinal", "Final");
			dataGridViewTipoDocumentoMaestro.Columns[index].DataPropertyName = "ConsecutivoFinal";
			dataGridViewTipoDocumentoMaestro.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			index = dataGridViewTipoDocumentoMaestro.Columns.Add("ConsecutivoActual", "Actual");
			dataGridViewTipoDocumentoMaestro.Columns[index].DataPropertyName = "ConsecutivoActual";
			dataGridViewTipoDocumentoMaestro.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			index = dataGridViewTipoDocumentoMaestro.Columns.Add("Prefijo", "Prefijo");
			dataGridViewTipoDocumentoMaestro.Columns[index].DataPropertyName = "Prefijo";
			dataGridViewTipoDocumentoMaestro.Columns[index].ReadOnly = true;
			dataGridViewTipoDocumentoMaestro.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			index = dataGridViewTipoDocumentoMaestro.Columns.Add("Factor", "Inventario");
			dataGridViewTipoDocumentoMaestro.Columns[index].DataPropertyName = "Factor";
			dataGridViewTipoDocumentoMaestro.Columns[index].ReadOnly = true;
			dataGridViewTipoDocumentoMaestro.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			index = dataGridViewTipoDocumentoMaestro.Columns.Add("Index", "Indice");
			dataGridViewTipoDocumentoMaestro.Columns[index].DataPropertyName = "Index";
			dataGridViewTipoDocumentoMaestro.Columns[index].ReadOnly = true;
			dataGridViewTipoDocumentoMaestro.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewTipoDocumentoMaestro.AutoGenerateColumns = false;
			bindingSource1.DataSource = TipoDocumento.GetAll();
			dataGridViewTipoDocumentoMaestro.DataSource = bindingSource1;
		}
		private void CargarTipoMoneda()
		{
			cbTipoMoneda.DataSource = TipoMoneda.GetAll();
			cbTipoMoneda.DisplayMember = "Descripcion";
			cbTipoMoneda.ValueMember = "Id";
		}
		private void CargarPais()
		{
			cbPais.DataSource = Pais.GetAll();
			cbPais.DisplayMember = "Descripcion";
			cbPais.ValueMember = "Id";
		}

		private void CargarDepartamento()
		{
			cbDepartamento.DataSource = Estado.GetAllByPais(((Pais)cbPais.SelectedItem));
			cbDepartamento.DisplayMember = "Descripcion";
			cbDepartamento.ValueMember = "Id";
		}

		private void CargarMunicipio()
		{
			cbMunicipio.DataSource = Ciudad.GetAllByEstado(((Estado)cbDepartamento.SelectedItem));
			cbMunicipio.DisplayMember = "Descripcion";
			cbMunicipio.ValueMember = "Id";
		}
		private void CargarUsuarios()
		{
			dataGridViewUsuarios.AutoGenerateColumns = false;
			int index = dataGridViewUsuarios.Columns.Add("Usuario", "Usuario");
			dataGridViewUsuarios.Columns[index].DataPropertyName = "Usuario";
			dataGridViewUsuarios.Columns[index].ReadOnly = true;
			dataGridViewUsuarios.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			index = dataGridViewUsuarios.Columns.Add(CreateCheckBoxColumn("Maestros", "Maestros"));
			index = dataGridViewUsuarios.Columns.Add(CreateCheckBoxColumn("Articulos", "Articulos"));
			index = dataGridViewUsuarios.Columns.Add(CreateCheckBoxColumn("Terceros", "Terceros"));
			index = dataGridViewUsuarios.Columns.Add(CreateCheckBoxColumn("Documentos", "Documentos"));
			index = dataGridViewUsuarios.Columns.Add(CreateCheckBoxColumn("Terminal PV", "TerminalPV"));
			index = dataGridViewUsuarios.Columns.Add(CreateCheckBoxColumn("Comprobantes", "Comprobantes"));
			index = dataGridViewUsuarios.Columns.Add(CreateCheckBoxColumn("Informes", "Informes"));
			index = dataGridViewUsuarios.Columns.Add(CreateCheckBoxColumn("Preferencias", "Preferencias"));
			bindingSource2.DataSource = Permiso.GetAll();
			dataGridViewUsuarios.DataSource = bindingSource2;
		}
		private void LoadXML()
		{
			empresa = Empresa.Get();
			preferencias = Preferencias.Get(Entorno.USUARIO);
			string value = "";
			if (preferencias != null) {
				checkControlaInventario.Checked = preferencias.ControlaInventario;
				checkUltimaConfiguracion.Checked = preferencias.UltimaConfiguracion;
				txtLetraCambio.Text = preferencias.MensajeTituloValor;
				txtAdvertencia.Text = preferencias.MensajeCentralRiesgo;
				txtFirmaRemision.Text = preferencias.FirmaRemision;
				txtFirmaFactura.Text = preferencias.FirmaFactura;
				txtFirmaComprobante.Text = preferencias.FirmaComprobante;
				txtFirmaNotas.Text = preferencias.FirmaNotas;
				txtFirmaOrdenCompra.Text = preferencias.FirmaOrdenCompra;
				txtFirmaOrdenPedido.Text = preferencias.FirmaOrdenPedido;
				txtFirmaCotizacion.Text = preferencias.FirmaCotizacion;
				txtColor.Text = preferencias.ColorConsecutivo;
				txtPlantillaObservacion1.Text = preferencias.ObservacionDocumento;
				txtPlantillaObservacion2.Text = preferencias.OtraObservacionDocumento;
				checkActivarPuntoVenta.Checked = preferencias.ActivarPuntoVenta;
				checkEnvioFormaAnonima.Checked = preferencias.EnvioInformacionAnonima;
				if (preferencias.ActivarPuntoVenta) {
					if (preferencias.TerceroPuntoVentaID != null) {
						tercero = Tercero.Get(preferencias.TerceroPuntoVentaID.GetValueOrDefault());
						txtTercero.Text = tercero.NombreComercial;
					}
					if (preferencias.TipoDocumentoPuntoVentaID != null) {
						cbTipoDocumentoFactura.SelectedValue = preferencias.TipoDocumentoPuntoVentaID;
					}
				}
				checkActivarCajonMonedero.Checked = preferencias.ActivarCajonMonedero;
				checkImprimirTirilla.Checked = preferencias.ImprimirTirilla;
				txtCajonMonedero.Text = preferencias.CodigoCajonMonedero;
				cbPuertoSalida.Text = preferencias.PuertoSalida;
				rbRedondeoInferior.Checked = preferencias.RedondeoInferior;
				rbRedondeoSistema.Checked = preferencias.RedondeoSistema;
				rbRedondeoSuperior.Checked = preferencias.RedondeoSuperior;
				TipoMoneda tipoMoneda = TipoMoneda.Get(preferencias.TipoMonedaID.GetValueOrDefault());
				if (tipoMoneda != null) {
					cbTipoMoneda.SelectedValue = tipoMoneda.ID;
				}
				else {
					cbTipoMoneda.SelectedIndex = cbTipoMoneda.FindString(TIPO_MONEDA);
				}
				nudNumeroDecimal.Value = preferencias.NumeroDecimal;
				string separadorMiles = preferencias.SeparadorMiles;
				if (separadorMiles == "es-CO") {
					rbComa.Checked = true;
				}
				else {
					rbPunto.Checked = true;
				}
				checkImpresionEncabezado.Checked = preferencias.ImpresionEncabezado;
				checkImpresionLogotipo.Checked = preferencias.ImpresionLogotipo;
				cbLectorCodigo.Text = preferencias.BusquedaLector;
				if (preferencias.BusquedaLector == string.Empty) {
					cbLectorCodigo.SelectedIndex = 0;
				}
				if (preferencias.PuertoSalida == string.Empty) {
					cbPuertoSalida.SelectedIndex = 0;
				}
				value = preferencias.ImpresoraPredeterminada;
			}
			if (empresa != null) {
				txtIdentidad.Text = empresa.Nit;
				txtRazonSocial.Text = empresa.RazonSocial;
				txtDireccion.Text = empresa.Direccion;
				txtTelefono.Text = empresa.TelefonoPrincipal;
				txtEmail.Text = empresa.Email;
				txtFax.Text = empresa.Fax;
				txtFrase.Text = empresa.Frase;
				txtLogo.Text = empresa.RutaLogo;
				if (empresa.CiudadID != null) {
					Ciudad ciudad = Ciudad.Get(empresa.CiudadID.GetValueOrDefault());
					Estado estado = Estado.Get(ciudad.EstadoID.GetValueOrDefault());
					Pais pais = Pais.Get(estado.PaisID);
					cbPais.SelectedValue = pais.ID;
					cbDepartamento.SelectedValue = estado.ID;
					cbMunicipio.SelectedValue = ciudad.ID;
				}
				else {
					cbPais.SelectedIndex = 0;
				}
				txtCodigoCIIU.Text = empresa.CodigoCIIU;
				txtOtroTelefono.Text = empresa.OtroTelefono;
				txtTelefonoMovil.Text = empresa.Movil;
				txtPaginaWeb.Text = empresa.PaginaWeb;
				txtFondoPapel.Text = empresa.RutaFondoPapel;
			}
			int selectedIndex = 0;
			int num = 0;
			foreach (string text in PrinterSettings.InstalledPrinters) {
				cbImpresoras.Items.Add(text);
				if (text.Equals(value)) {
					selectedIndex = num;
				}
				num++;
			}
			if (num > 0) {
				cbImpresoras.SelectedIndex = selectedIndex;
			}
			/*string item = LicenciaXML.GetItem("ClaveAcceso");
			if (item != string.Empty && Convert.ToBoolean(item)) {
				Sistema sistema = new SistemaFactory().GetSistema();
				checkClaveAcceso.Checked = sistema.ClaveAcceso;
			}*/
		}
		public void ActualizarTipoDocumento()
		{
			bindingSource1.DataSource = TipoDocumento.GetAll();
			dataGridViewTipoDocumentoMaestro.DataSource = bindingSource1;
			bindingSource1.ResetBindings(false);
		}
		private string SelectImagenFile()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Imagen jpg (*.jpg)|*.jpg|Imagen gif (*.gif)|*.gif|Imagen png (*.png)|*.png";
			openFileDialog.Title = "Seleccione una imagen";
			if (openFileDialog.ShowDialog() != DialogResult.OK) {
				return null;
			}
			return openFileDialog.FileName;
		}
		public void ShowFirma(string fileToDisplay, int xSize, int ySize)
		{
			if (MyImage != null) {
				MyImage.Dispose();
			}
			if (fileToDisplay == string.Empty) {
				return;
			}
			if (!File.Exists(fileToDisplay)) {
				return;
			}
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			MyImage = new Bitmap(fileToDisplay);
			pictureBox1.ClientSize = new Size(xSize, ySize);
			pictureBox1.Image = MyImage;
		}

		public void HideFirma()
		{
			if (MyImage != null) {
				MyImage.Dispose();
			}
			pictureBox1.Image = null;
		}
		private void FrmPreferencias_Load(object sender, EventArgs e)
		{
			cbTipoDocumentoFactura.DataSource = TipoDocumento.GetAll();
			cbTipoDocumentoFactura.DisplayMember = "Descripcion";
			cbTipoDocumentoFactura.ValueMember = "Id";
			CargarTipoDocumento();
			CargarTipoMoneda();
			CargarPais();
			CargarUsuarios();
			cbDepartamento.SelectedIndex = 0;
			cbLectorCodigo.SelectedIndex = 0;
			cbPuertoSalida.SelectedIndex = 0;
			LoadXML();			
		}
		private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
		{
			CargarDepartamento();
		}
		private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
		{
			CargarMunicipio();
		}
		private void btnExaminar_Click_1(object sender, EventArgs e)
		{
			txtLogo.Text = SelectImagenFile();
		}
		private void dataGridViewTipoDocumentoMaestro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dataGridViewTipoDocumentoMaestro.Columns[e.ColumnIndex].Name == "Factor") {
				switch (Convert.ToInt32(e.Value)) {
					case -1:
						e.Value = "RESTA";
						return;
					case 0:
						e.Value = "NEUTRAL";
						return;
					case 1:
						e.Value = "SUMA";
						break;
					default:
						return;
				}
			}
		}
		
		private void dataGridViewTipoDocumentoMaestro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var td = TipoDocumento.FindByCodigo(dataGridViewTipoDocumentoMaestro.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
			var frmTipoDocumento = new FrmTipoDocumento(td);
			if(frmTipoDocumento.ShowDialog(this) == DialogResult.OK)
			{
				ActualizarTipoDocumento();
			}
			/*if (new FrmTipoDocumento {
				TipoDocumento = td
			}.ShowDialog(this) == DialogResult.OK) {
				ActualizarTipoDocumento();
			}*/
			 
			
		}
		private void dataGridViewUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var permiso = (dataGridViewUsuarios.Rows[e.RowIndex].DataBoundItem as Permiso);
			if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Usuario") {
				var usuario = Usuario.Get((dataGridViewUsuarios.Rows[e.RowIndex].DataBoundItem as Permiso).UsuarioID.GetValueOrDefault());
				e.Value = usuario.NombreUsuario;
				
			}
			if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Articulos") {
				e.Value = permiso.Articulos;
			}
			if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Maestros") {
				e.Value = permiso.Maestros;
			}
			if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Terceros") {
				e.Value = permiso.Terceros;
			}
			if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "TerminalPV") {
				e.Value = permiso.TerminalPV;
			}
			if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Documentos") {
				e.Value = permiso.Documentos;
			}
			if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Informes") {
				e.Value = permiso.Informes;
			}
			if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Comprobantes") {
				e.Value = permiso.Comprobantes;
			}
			if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Preferencias") {
				e.Value = permiso.Preferencias;
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (dataGridViewTipoDocumentoMaestro.SelectedCells.Count > 0) {
				TipoDocumento tipoDocumento = (TipoDocumento)dataGridViewTipoDocumentoMaestro.CurrentCell.OwningRow.DataBoundItem;
				if (MessageBox.Show("Esta seguro de eliminar el tipo de documento " + tipoDocumento.Descripcion,Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
					if (!tipoDocumento.Reservado) {
						IntegracionContable integracionContable = IntegracionContable.FindByTipoDocumento(tipoDocumento);
						if (integracionContable != null) {
							integracionContable.Delete();
						}
						IList<PermisoTipoDocumento> list = PermisoTipoDocumento.FindByTipoDocumento(tipoDocumento);
						foreach (PermisoTipoDocumento current in list) {
							current.Delete();
						}
						tipoDocumento.Delete();
						MessageBox.Show("Eliminado con exito!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						ActualizarTipoDocumento();
					}
					else {
						MessageBox.Show("No es posible eliminar este tipo de documento esta reservado para el sistema", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				dataGridViewTipoDocumentoMaestro.Focus();
			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			FrmTipoDocumento formTipoDocumento = new FrmTipoDocumento();
			if (formTipoDocumento.ShowDialog(this) == DialogResult.OK) {
				ActualizarTipoDocumento();
			}
		}
		private void btnRemision_Click(object sender, EventArgs e)
		{
			txtFirmaRemision.Text = SelectImagenFile();
			if (txtFirmaRemision.Text != string.Empty) {
				ShowFirma(txtFirmaRemision.Text, 250, 100);
			}
		}
		private void btnFactura_Click(object sender, EventArgs e)
		{
			txtFirmaFactura.Text = SelectImagenFile();
			if (txtFirmaFactura.Text != string.Empty) {
				ShowFirma(txtFirmaFactura.Text, 250, 100);
			}
		}
		private void btnOrdenPedido_Click(object sender, EventArgs e)
		{
			txtFirmaOrdenPedido.Text = SelectImagenFile();
			if (txtFirmaOrdenPedido.Text != string.Empty) {
				ShowFirma(txtFirmaOrdenPedido.Text, 250, 100);
			}
		}

		private void btnComprobante_Click(object sender, EventArgs e)
		{
			txtFirmaComprobante.Text = SelectImagenFile();
			if (txtFirmaComprobante.Text != string.Empty) {
				ShowFirma(txtFirmaComprobante.Text, 250, 100);
			}
		}

		private void btnNotas_Click(object sender, EventArgs e)
		{
			txtFirmaNotas.Text = SelectImagenFile();
			if (txtFirmaNotas.Text != string.Empty) {
				ShowFirma(txtFirmaNotas.Text, 250, 100);
			}
		}

		private void btnOrdenCompra_Click(object sender, EventArgs e)
		{
			txtFirmaOrdenCompra.Text = SelectImagenFile();
			if (txtFirmaOrdenCompra.Text != string.Empty) {
				ShowFirma(txtFirmaOrdenCompra.Text, 250, 100);
			}
		}
		
		private void btnCotizacion_Click(object sender, EventArgs e)
		{
			txtFirmaCotizacion.Text = SelectImagenFile();
			if (txtFirmaCotizacion.Text != string.Empty) {
				ShowFirma(txtFirmaCotizacion.Text, 250, 100);
			}
		}
		
		private void btnExaminarFondo_Click(object sender, EventArgs e)
		{
			txtFondoPapel.Text = SelectImagenFile();
		}	
		
		private void txtFirmaFactura_MouseLeave(object sender, EventArgs e)
		{
			HideFirma();
		}

		private void txtFirmaRemision_MouseLeave(object sender, EventArgs e)
		{
			HideFirma();
		}

		private void txtFirmaFactura_MouseHover(object sender, EventArgs e)
		{
			ShowFirma(txtFirmaFactura.Text, 250, 100);
		}

		private void txtFirmaComprobante_MouseHover(object sender, EventArgs e)
		{
			ShowFirma(txtFirmaComprobante.Text, 250, 100);
		}

		private void txtFirmaNotas_MouseHover(object sender, EventArgs e)
		{
			ShowFirma(txtFirmaNotas.Text, 250, 100);
		}

		private void txtFirmaOrdenCompra_MouseHover(object sender, EventArgs e)
		{
			ShowFirma(txtFirmaOrdenCompra.Text, 250, 100);
		}

		private void txtFirmaComprobante_MouseLeave(object sender, EventArgs e)
		{
			HideFirma();
		}

		private void txtFirmaNotas_MouseLeave(object sender, EventArgs e)
		{
			HideFirma();
		}

		private void txtFirmaOrdenCompra_MouseLeave(object sender, EventArgs e)
		{
			HideFirma();
		}

		private void txtFirmaOrdenPedido_MouseHover(object sender, EventArgs e)
		{
			ShowFirma(txtFirmaOrdenPedido.Text, 250, 100);
		}

		private void txtFirmaOrdenPedido_MouseLeave(object sender, EventArgs e)
		{
			HideFirma();
		}
		private void txtFirmaCotizacion_MouseHover(object sender, EventArgs e)
		{
			ShowFirma(txtFirmaCotizacion.Text, 250, 100);
		}

		private void txtFirmaCotizacion_MouseLeave(object sender, EventArgs e)
		{
			HideFirma();
		}
		
		private void btnLimpiarCotizacion_Click(object sender, EventArgs e)
		{
			txtFirmaCotizacion.Text = string.Empty;
		}

		private void btnLimpiarRemision_Click(object sender, EventArgs e)
		{
			txtFirmaRemision.Text = string.Empty;
		}

		private void btnLimpiarFactura_Click(object sender, EventArgs e)
		{
			txtFirmaFactura.Text = string.Empty;
		}

		private void btnLimpiarComprobante_Click(object sender, EventArgs e)
		{
			txtFirmaComprobante.Text = string.Empty;
		}

		private void btnLimpiarNotas_Click(object sender, EventArgs e)
		{
			txtFirmaNotas.Text = string.Empty;
		}

		private void btnLimpiarOrdenCompra_Click(object sender, EventArgs e)
		{
			txtFirmaOrdenCompra.Text = string.Empty;
		}

		private void btnLimpiarOrdenPedido_Click(object sender, EventArgs e)
		{
			txtFirmaOrdenPedido.Text = string.Empty;
		}
		
		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			FrmBuscarTercero frmBuscarTercero = new FrmBuscarTercero();
			if (frmBuscarTercero.ShowDialog(this) == DialogResult.OK) {
				tercero = frmBuscarTercero.Tercero;
				txtTercero.Text = tercero.NombreComercial;
			}
		}
		private void btnModificarDocumento_Click(object sender, EventArgs e)
		{
			if (dataGridViewTipoDocumentoMaestro.SelectedCells.Count > 0 && new FrmTipoDocumento {
				TipoDocumento = (TipoDocumento)dataGridViewTipoDocumentoMaestro.Rows[dataGridViewTipoDocumentoMaestro.SelectedCells[0].RowIndex].DataBoundItem
			}.ShowDialog(this) == DialogResult.OK) {
				ActualizarTipoDocumento();
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() != DialogResult.Cancel) {
				string text = ColorTranslator.ToHtml(colorDialog1.Color);
				txtColor.Text = text;
			}
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			//empresa = new EmpresaFactory().GetEmpresa();
			empresa.Nit = txtIdentidad.Text;
			empresa.RazonSocial = txtRazonSocial.Text;
			empresa.Direccion = txtDireccion.Text;
			empresa.TelefonoPrincipal = txtTelefono.Text;
			empresa.CiudadID = (cbMunicipio.SelectedItem as Ciudad).ID;
			//empresa.EstadoID = (cbMunicipio.SelectedItem as Ciudad).EstadoID.GetValueOrDefault();
			//empresa.PaisID = Pais.Get((cbMunicipio.SelectedItem as Ciudad).EstadoID.GetValueOrDefault()).ID;
			empresa.Email = txtEmail.Text;
			empresa.Fax = txtFax.Text;
			empresa.Frase = txtFrase.Text;
			empresa.RutaLogo = txtLogo.Text;
			empresa.CodigoCIIU = txtCodigoCIIU.Text;
			empresa.OtroTelefono = txtOtroTelefono.Text;
			empresa.Movil = txtTelefonoMovil.Text;
			empresa.PaginaWeb = txtPaginaWeb.Text;
			empresa.RutaFondoPapel = txtFondoPapel.Text;
			if (empresa.ID == 0) {
				empresa.Save();
			}
			else {
				empresa.Update();
			}
			//preferencias = new PreferenciasFactory().GetPreferencias(Entorno.USUARIO);
			if (preferencias == null) {
				preferencias = new Preferencias();
				preferencias.UsuarioID = Entorno.USUARIO.ID;
				preferencias.FechaCreacion = DateTime.Now;
			}
			preferencias.ControlaInventario = checkControlaInventario.Checked;
			preferencias.ImpresoraPredeterminada = cbImpresoras.Text;
			preferencias.FirmaRemision = txtFirmaRemision.Text;
			preferencias.FirmaFactura = txtFirmaFactura.Text;
			preferencias.FirmaComprobante = txtFirmaComprobante.Text;
			preferencias.FirmaNotas = txtFirmaNotas.Text;
			preferencias.FirmaOrdenCompra = txtFirmaOrdenCompra.Text;
			preferencias.FirmaOrdenPedido = txtFirmaOrdenPedido.Text;
			preferencias.FirmaCotizacion = txtFirmaCotizacion.Text;
			preferencias.MensajeTituloValor = txtLetraCambio.Text;
			preferencias.MensajeCentralRiesgo = txtAdvertencia.Text;
			preferencias.ObservacionDocumento = txtPlantillaObservacion1.Text;
			preferencias.OtraObservacionDocumento = txtPlantillaObservacion2.Text;
			preferencias.TipoMonedaID = (cbTipoMoneda.SelectedItem as TipoMoneda).ID;
			preferencias.UltimaConfiguracion = checkUltimaConfiguracion.Checked;
			preferencias.NumeroDecimal = Convert.ToInt32(nudNumeroDecimal.Value);
			preferencias.ImpresionEncabezado = checkImpresionEncabezado.Checked;
			preferencias.ImpresionLogotipo = checkImpresionLogotipo.Checked;
			preferencias.ColorConsecutivo = txtColor.Text;
			preferencias.BusquedaLector = cbLectorCodigo.Text;
			preferencias.TipoDocumentoPuntoVentaID = (cbTipoDocumentoFactura.SelectedItem as TipoDocumento).ID;
			preferencias.ActivarPuntoVenta = checkActivarPuntoVenta.Checked;
			preferencias.TerceroPuntoVentaID = tercero == null ? 0 : tercero.ID;
			preferencias.RedondeoInferior = rbRedondeoInferior.Checked;
			preferencias.RedondeoSistema = rbRedondeoSistema.Checked;
			preferencias.RedondeoSuperior = rbRedondeoSuperior.Checked;
			if (checkActivarPuntoVenta.Checked && preferencias.TerceroPuntoVentaID == 0) {
				MessageBox.Show("Tercero en el punto de venta es requerido!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				checkActivarPuntoVenta.Checked = (preferencias.ActivarPuntoVenta = false);
			}
			if (checkActivarPuntoVenta.Checked && preferencias.BusquedaLector == string.Empty) {
				MessageBox.Show("Busqueda del lector venta es requerido!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				checkActivarPuntoVenta.Checked = (preferencias.ActivarPuntoVenta = false);
			}
			preferencias.ActivarCajonMonedero = checkActivarCajonMonedero.Checked;
			preferencias.ImprimirTirilla = checkImprimirTirilla.Checked;
			preferencias.CodigoCajonMonedero = txtCajonMonedero.Text;
			preferencias.PuertoSalida = cbPuertoSalida.Text;
			preferencias.EnvioInformacionAnonima = checkEnvioFormaAnonima.Checked;
			if (rbComa.Checked) {
				preferencias.SeparadorMiles = "es-CO";
				Thread.CurrentThread.CurrentCulture = new CultureInfo("es-CO");
			}
			else {
				preferencias.SeparadorMiles = "en-US";
				Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			}
			if (preferencias.ID == 0) {
				preferencias.Save();
			}
			else {
				preferencias.Update();
			}
			/*string item = LicenciaXML.GetItem("ClaveAcceso");
			if (item != string.Empty && Convert.ToBoolean(item)) {
				Sistema sistema = new SistemaFactory().GetSistema();
				sistema.ClaveAcceso = checkClaveAcceso.Checked;
				persistentFactory.Update(sistema);
			}*/
			//Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
			MessageBox.Show("Grabado con exito!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			DialogResult = DialogResult.OK;
			Close();
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
