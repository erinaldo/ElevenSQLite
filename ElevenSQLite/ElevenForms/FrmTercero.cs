/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 8:20 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;
using ElevenSQLite.ElevenUtils;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmTerceros.
	/// </summary>
	public partial class FrmTercero : Form
	{
		Preferencias preferencias = Preferencias.Get(Entorno.USUARIO);
		Empresa empresa = Empresa.Get();
		Tercero tercero;
		int accion;
		
		public FrmTercero()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.tercero = new Tercero();
			this.tercero.FechaCreacion = DateTime.Now;
			accion = 1;
			Text = "Crear Nuevo Tercero";
		}
		public FrmTercero(Tercero ter)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.tercero = ter;
			this.tercero.FechaModificacion = DateTime.Now;
			accion = 2;
			Text = "Modificar Tercero";
		}
		
		public void Tercero2Form()
		{
			this.txtCodigo.Text = this.tercero.Codigo;
			this.txtNIT.Text = Convert.ToString(this.tercero.Nit);
			this.txtDigitoVerificacion.Text = Convert.ToString(this.tercero.DigitoVerificacion);
			this.txtNombreComercial.Text = this.tercero.NombreComercial;
			this.checkInhabilitar.Checked = this.tercero.Inhabilitar;
			this.txtRazonSocial.Text = this.tercero.RazonSocial;
			this.txtPrimerNombre.Text = this.tercero.PrimerNombre;
			this.txtOtroNombre.Text = this.tercero.OtroNombre;
			this.txtPrimerApellido.Text = this.tercero.PrimerApellido;
			this.txtSegundoApellido.Text = this.tercero.SegundoApellido;
			this.txtContacto.Text = this.tercero.ContactoPrincipal;
			this.txtDireccion.Text = this.tercero.DireccionPrincipal;
			this.txtTelefono.Text = this.tercero.TelefonoPrincipal;
			this.txtFax.Text = this.tercero.Fax;
			this.txtCelular.Text = this.tercero.TelefonoMovilPrincipal;
			this.txtTelefono2.Text = this.tercero.OtroTelefonoPrincipal;
			this.txtEmail.Text = this.tercero.Email;
			this.CargarPaises();
			if (this.tercero.CiudadID != 0) {
				Ciudad ciudad = Ciudad.Get(tercero.CiudadID);
				Estado estado = Estado.Get(ciudad.EstadoID.GetValueOrDefault());
				Pais pais = Pais.Get(estado.PaisID);
				this.cbPais.SelectedValue = pais.ID;
				this.cbDepartamento.SelectedValue = estado.ID;
				this.cbMunicipio.SelectedValue = ciudad.ID;
			}
			this.checkExcentoIVA.Checked = this.tercero.ExcentoIva;
			this.checkGranContribuyente.Checked = this.tercero.GranContribuyente;
			if (this.tercero.TipoRegimen == Tercero.REGIMEN_COMUN) {
				this.rbComun.Checked = true;
			}
			else {
				this.rbSimplificado.Checked = true;
			}
			this.checkCliente.Checked = this.tercero.ClienteNacional;
			this.checkClienteExterior.Checked = this.tercero.ClienteExtranjero;
			this.checkProveedorExterior.Checked = this.tercero.ProveedorExtranjero;
			this.checkProveedor.Checked = this.tercero.ProveedorNacional;
			this.checkOtro.Checked = this.tercero.OtroTipoTercero;
			this.checkInterno.Checked = this.tercero.Interno;
			this.txtReferenciaComercial.Text = this.tercero.ReferenciaComercial;
			this.cbCalificacion.SelectedIndex = this.cbCalificacion.FindStringExact(this.tercero.Calificacion.ToString());
			this.cbTipoPrecio.SelectedIndex = this.cbTipoPrecio.FindStringExact(this.tercero.TipoPrecioVenta.ToString());
			this.txtObservacion.Text = this.tercero.Observacion;
		}
		private void Clear()
		{
			this.txtCodigo.Text = string.Empty;
			this.txtNIT.Text = string.Empty;
			this.txtDigitoVerificacion.Text = string.Empty;
			this.txtNombreComercial.Text = string.Empty;
			this.checkInhabilitar.Checked = false;
			this.txtRazonSocial.Text = string.Empty;
			this.txtPrimerNombre.Text = string.Empty;
			this.txtOtroNombre.Text = string.Empty;
			this.txtPrimerApellido.Text = string.Empty;
			this.txtSegundoApellido.Text = string.Empty;
			this.txtContacto.Text = string.Empty;
			this.txtDireccion.Text = string.Empty;
			this.txtTelefono.Text = string.Empty;
			this.txtFax.Text = string.Empty;
			this.txtCelular.Text = string.Empty;
			this.txtTelefono2.Text = string.Empty;
			this.txtEmail.Text = string.Empty;
			this.checkExcentoIVA.Checked = false;
			this.checkGranContribuyente.Checked = false;
			this.rbComun.Checked = true;
			this.rbSimplificado.Checked = false;
			this.checkCliente.Checked = true;
			this.checkClienteExterior.Checked = false;
			this.checkProveedor.Checked = false;
			this.checkProveedorExterior.Checked = false;
			this.checkOtro.Checked = false;
			this.checkInterno.Checked = false;
			this.txtReferenciaComercial.Text = string.Empty;
			this.CargarPaises();
			this.cbTipoPrecio.SelectedIndex = 0;
			this.cbCalificacion.SelectedIndex = 2;
			this.txtObservacion.Text = string.Empty;
			if (empresa.CiudadID != 0) {
				Ciudad ciudad = Ciudad.Get(empresa.CiudadID.GetValueOrDefault());
				Estado estado = Estado.Get(ciudad.EstadoID.GetValueOrDefault());
				Pais pais = Pais.Get(estado.PaisID);
				this.cbPais.SelectedValue = pais.ID;
				this.cbDepartamento.SelectedValue = estado.ID;
				this.cbMunicipio.SelectedValue = ciudad.ID;
			}
		}
		void CargarPaises()
		{
			this.cbPais.DataSource = Pais.GetAll();
			this.cbPais.DisplayMember = "Descripcion";
			this.cbPais.ValueMember = "ID";
		}

		void CargarEstados()
		{
			Pais pais = (cbPais.SelectedItem as Pais);
			this.cbDepartamento.DataSource =Estado.GetAllByPais(pais);
			this.cbDepartamento.DisplayMember = "Descripcion";
			this.cbDepartamento.ValueMember = "Id";
		}
		void CargarCiudades()
		{
			Estado estado = (cbDepartamento.SelectedItem as Estado);
			this.cbMunicipio.DataSource = Ciudad.GetAllByEstado(estado);
			this.cbMunicipio.DisplayMember = "Descripcion";
			this.cbMunicipio.ValueMember = "Id";
		}
		bool isNacional()
		{
			return this.checkCliente.Checked || this.checkProveedor.Checked;
		}

		bool isExtranjero()
		{
			return this.checkClienteExterior.Checked || this.checkProveedorExterior.Checked;
		}
		private bool Validar()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.txtCodigo.Text == string.Empty) {
				stringBuilder.Append("Codigo es requerido!\n");
			}
			if (this.txtNombreComercial.Text == string.Empty) {
				stringBuilder.Append("Nombre comercial es requerido!\n");
			}
			if (this.txtNIT.Text == string.Empty && this.isNacional()) {
				stringBuilder.Append("N.I.T es requerido!\n");
			}
			if (this.txtNIT.Text == string.Empty && this.isNacional() && this.rbComun.Checked) {
				stringBuilder.Append("Digito de verificación es requerido!\n");
			}
			if (this.txtNIT.Text != string.Empty) {
				try {
					Convert.ToInt32(this.txtNIT.Text);
				}
				catch {
					stringBuilder.Append("N.I.T debe ser un numero!\n");
				}
			}
			if (this.txtDigitoVerificacion.Text != string.Empty) {
				try {
					Convert.ToInt32(this.txtDigitoVerificacion.Text);
				}
				catch {
					stringBuilder.Append("Digito verificación debe ser un numero!\n");
				}
			}
			string text = string.Concat(new string[] {
				this.txtPrimerNombre.Text,
				(this.txtOtroNombre.Text != string.Empty) ? (" " + this.txtOtroNombre.Text) : "",
				" ",
				this.txtPrimerApellido.Text,
				(this.txtSegundoApellido.Text != string.Empty) ? (" " + this.txtSegundoApellido.Text) : ""
			}).Trim();
			if (this.txtRazonSocial.Text != string.Empty && text != string.Empty) {
				stringBuilder.Append("Existe una Razón social, no es posible ingresar Nombre Completo:" + text + " (Elimine uno de los dos)\n");
			}
			if (this.txtRazonSocial.Text == string.Empty && this.txtPrimerNombre.Text != string.Empty && this.txtPrimerApellido.Text == string.Empty) {
				stringBuilder.Append("El primer apellido es requerido\n");
			}
			if (stringBuilder.Length > 0) {
				MessageBox.Show(stringBuilder.ToString(), "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			return true;
		}
		private void FormTerceros_Load(object sender, EventArgs e)
		{
			
			CargarPaises();
			this.cbTipoPrecio.SelectedIndex = 0;
			this.cbCalificacion.SelectedIndex = 2;
			if (!string.IsNullOrEmpty(empresa.CiudadID.ToString())) {
				Ciudad ciudad = Ciudad.Get(empresa.CiudadID.GetValueOrDefault());
				Estado estado = Estado.Get(ciudad.EstadoID.GetValueOrDefault());
				Pais pais = Pais.Get(estado.PaisID);
				this.cbPais.SelectedValue = pais.ID;
				this.cbDepartamento.SelectedValue = estado.ID;
				this.cbMunicipio.SelectedValue = ciudad.ID;
			}
			if(accion == 2) Tercero2Form();
			
		}		
		void cbPais_SelectedIndexChanged(object sender, EventArgs e)
		{
			CargarEstados();
		}
		void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
		{
			CargarCiudades();
		}
		void checkClienteExterior_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkClienteExterior.Checked) {
				this.rbSimplificado.Checked = true;
				this.checkExcentoIVA.Checked = true;
				this.checkCliente.Checked = false;
			}
		}

		void checkCliente_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkCliente.Checked) {
				this.checkClienteExterior.Checked = false;
			}
		}

		void checkProveedor_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkProveedor.Checked) {
				this.checkProveedorExterior.Checked = false;
			}
		}

		void checkProveedorExterior_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkProveedorExterior.Checked) {
				this.checkProveedor.Checked = false;
			}
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if (this.Validar()) {
				this.tercero.Codigo = this.txtCodigo.Text;
				if (this.txtNIT.Text != string.Empty) {
					this.tercero.Nit = Convert.ToInt32(this.txtNIT.Text);
				}
				if (this.txtDigitoVerificacion.Text != string.Empty) {
					this.tercero.DigitoVerificacion = (int)Convert.ToInt16(this.txtDigitoVerificacion.Text);
				}
				this.tercero.NombreComercial = this.txtNombreComercial.Text;
				this.tercero.RazonSocial = this.txtRazonSocial.Text;
				this.tercero.PrimerNombre = this.txtPrimerNombre.Text;
				this.tercero.OtroNombre = this.txtOtroNombre.Text;
				this.tercero.PrimerApellido = this.txtPrimerApellido.Text;
				this.tercero.SegundoApellido = this.txtSegundoApellido.Text;
				this.tercero.ContactoPrincipal = this.txtContacto.Text;
				this.tercero.DireccionPrincipal = this.txtDireccion.Text;
				this.tercero.TelefonoPrincipal = this.txtTelefono.Text;
				this.tercero.OtroTelefonoPrincipal = this.txtTelefono2.Text;
				this.tercero.TelefonoMovilPrincipal = this.txtCelular.Text;
				this.tercero.Fax = this.txtFax.Text;
				this.tercero.Email = this.txtEmail.Text;
				this.tercero.ExcentoIva = this.checkExcentoIVA.Checked;
				this.tercero.GranContribuyente = this.checkGranContribuyente.Checked;
				if (this.rbComun.Checked) {
					this.tercero.TipoRegimen = Tercero.REGIMEN_COMUN;
				}
				else {
					this.tercero.TipoRegimen = Tercero.REGIMEN_SIMPLIFICADO;
				}
				this.tercero.CiudadID = (this.cbMunicipio.SelectedItem as Ciudad).ID;
				this.tercero.ClienteNacional = this.checkCliente.Checked;
				this.tercero.ClienteExtranjero = this.checkClienteExterior.Checked;
				this.tercero.ProveedorExtranjero = this.checkProveedorExterior.Checked;
				this.tercero.ProveedorNacional = this.checkProveedor.Checked;
				this.tercero.OtroTipoTercero = this.checkOtro.Checked;
				this.tercero.Inhabilitar = this.checkInhabilitar.Checked;
				this.tercero.Calificacion = Convert.ToInt32(this.cbCalificacion.Text);
				this.tercero.TipoPrecioVenta = Convert.ToInt32(this.cbTipoPrecio.Text);
				this.tercero.UsuarioID = Entorno.USUARIO.ID;
				this.tercero.Interno = this.checkInterno.Checked;
				this.tercero.ReferenciaComercial = this.txtReferenciaComercial.Text;
				this.tercero.Observacion = this.txtObservacion.Text;
				string msg = "";
				switch(accion)
				{
					case 1:
						tercero.Save();
						msg = "Tercero creado";
						break;
					case 2:
						tercero.Update();
						msg = "Tercero actualizado";
						break;
				}
				MessageBox.Show( msg + " con exito!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				DialogResult = DialogResult.Yes;
				Close();
			}
		}
	}
}
