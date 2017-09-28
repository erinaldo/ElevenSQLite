/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 9/09/2017
 * Hora: 1:11 p. m.
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
	/// Description of FrmArticulo.
	/// </summary>
	public partial class FrmArticulo : Form
	{
		int accion = 0;
		Articulo articulo = null;		
		public Familia familia;
		public Seccion seccion;
		public UnidadComercial unidadMedida;
		private static Preferencias preferencias = null;
		private static string FORMATO_NUMERO = "##0";
		private static string IVA_DEFECTO = "19";
		private static string IVA_CERO = "0";
		
		
		public FrmArticulo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Text = "Crear Nuevo Articulo";
			accion = 1;
			articulo = new Articulo();
			articulo.FechaCreacion = DateTime.Now;
			articulo.UsuarioID = Entorno.USUARIO.ID;
		}
		public FrmArticulo( Articulo articulo)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Text = "Modificar Articulo";
			this.articulo = articulo;
			this.articulo.FechaModificacion = DateTime.Now;
			this.accion = 2;
		}
		
		private void FormArticulo_Load(object sender, EventArgs e)
		{
			preferencias = Preferencias.Get(Entorno.USUARIO);
			CargarUnidadMedida();
			CargarFamilia();
			CargarTarifaIVA();
			int numeroDecimal = preferencias.NumeroDecimal;
			if (numeroDecimal > 0) {
				FORMATO_NUMERO += CalcularNumeroDecimal(numeroDecimal);
			}
			
			if(accion == 2) Articulo2Form();
			
		}

		private string CalcularNumeroDecimal(int p)
		{
			string text = ".";
			for (int i = 0; i < p; i++) {
				text += "#";
			}
			return text;
		}

		private void CargarTarifaIVA()
		{
			cbIVA.Refresh();
			cbIVA.DataSource = TarifaIVA.GetAll();
			cbIVA.DisplayMember = "Tarifa";
			cbIVA.ValueMember = "Factor";
			cbIVA.SelectedIndex = cbIVA.FindString(IVA_DEFECTO);
		}

		private void CargarFamilia()
		{
			cbFamilia.Refresh();
			cbFamilia.DataSource = Familia.GetAll();
			cbFamilia.DisplayMember = "Descripcion";
			cbFamilia.ValueMember = "Id";
			CargarSeccion();
		}

		private void CargarSeccion()
		{
			cbSeccion.Refresh();
			familia = (Familia)cbFamilia.SelectedItem;
			cbSeccion.DataSource = Seccion.FindByFamilia(familia);
			cbSeccion.DisplayMember = "Descripcion";
			cbSeccion.ValueMember = "Id";
		}

		private void CargarUnidadMedida()
		{
			cbUnidadMedida.Refresh();
			cbUnidadMedida.DataSource = UnidadComercial.GetAll();
			cbUnidadMedida.DisplayMember = "Descripcion";
			cbUnidadMedida.ValueMember = "Id";
			cbUnidadMedida.SelectedIndex = cbUnidadMedida.FindString("U");
		}

		private void Reset()
		{
			CargarUnidadMedida();
			CargarFamilia();
			CargarTarifaIVA();
			txtCodigo.Text = string.Empty;
			txtCodigoBarras.Text = string.Empty;
			checkServicio.Checked = false;
			checkEstado.Checked = false;
			txtDescripcion.Text = string.Empty;
			txtCodigoPLU.Text = string.Empty;
			txtDescripcionCorta.Text = string.Empty;
			rbIVA.Checked = true;
			rbExcento.Checked = false;
			rbExcluido.Checked = false;
			txtCosto.Text = "0";
			txtValorNeto.Text = "0";
			txtValorNeto1.Text = "0";
			txtValorNeto2.Text = "0";
			txtPrecioVenta.Text = "0";
			txtPrecioVenta1.Text = "0";
			txtPrecioVenta2.Text = "0";
			txtUnidadesArticulo.Text = "1";
			txtCodigoAlternativo.Text = string.Empty;
			txtImpuestoConsumo.Text = "0";
			txtStockActual.Text = "0";
			txtStockDisponible.Text = "0";
			txtStockMaximo.Text = "0";
			txtStockMinimo.Text = "0";
			rbRedondeoSistema.Checked = true;
		}
		
		bool ValidarForm2Articulo()
		{
			bool validado = true;
			StringBuilder stringBuilder = new StringBuilder();
			if (txtCodigo.Text != string.Empty) {
				articulo.Codigo = txtCodigo.Text;
			}
			else {
				stringBuilder.Append("El codigo es requerido!\n");
			}
			if (txtDescripcion.Text != string.Empty) {
				articulo.Descripcion = txtDescripcion.Text;
			}
			else {
				stringBuilder.Append("La descripción es requerida!\n");
			}
			articulo.CodigoBarras = txtCodigoBarras.Text;
			articulo.Servicio = checkServicio.Checked;
			articulo.Estado = checkEstado.Checked;
			articulo.RedondeoInferior = rbRedondeoInferior.Checked;
			articulo.RedondeoSistema = rbRedondeoSistema.Checked;
			articulo.RedondeoSuperior = rbRedondeoSuperior.Checked;
			if (txtCodigoPLU.Text != string.Empty) {
				articulo.CodigoPLU = txtCodigoPLU.Text;
			}
			if (txtDescripcionCorta.Text != string.Empty) {
				articulo.DescripcionCorta = txtDescripcionCorta.Text;
			}
			if (rbIVA.Checked) {
				articulo.Impuesto = Articulo.IVA;
			}
			else {
				if (rbExcluido.Checked) {
					articulo.Impuesto = Articulo.EXCLUIDO;
				}
				else {
					if (rbExcento.Checked) {
						articulo.Impuesto = Articulo.EXCENTO;
					}
				}
			}
			if (cbUnidadMedida.SelectedItem != null) {
				articulo.UnidadComercialID = (cbUnidadMedida.SelectedItem as UnidadComercial).ID;
			}
			else {
				stringBuilder.Append("La unidad de medida es requerida!\n");
			}
			if (cbSeccion.SelectedItem != null) {
				articulo.SeccionID = (cbSeccion.SelectedItem as Seccion).ID;
			}
			else {
				stringBuilder.Append("La sección es requerida!\n");
			}
			if (txtCosto.Text == string.Empty) {
				stringBuilder.Append("El costo debe ser cero o mayor que cero!\n");
			}
			else {
				try {
					articulo.Costo = Convert.ToDecimal(txtCosto.Text);
				}
				catch {
					stringBuilder.Append("El costo debe ser un numero o cero!\n");
				}
			}
			if (txtValorNeto.Text == string.Empty) {
				stringBuilder.Append("El valor unitario debe ser mayor a cero!\n");
			}
			else {
				try {
					articulo.ValorNeto = Convert.ToDecimal(txtValorNeto.Text);
					if (articulo.ValorNeto <= 0m) {
						stringBuilder.Append("El valor unitario debe ser un numero mayor a cero!\n");
					}
				}
				catch {
					stringBuilder.Append("El valor unitario debe ser un numero o cero!\n");
				}
			}
			if (txtValorNeto1.Text == string.Empty) {
				stringBuilder.Append("El valor unitario dos (2) debe ser cero o mayor a cero!\n");
			}
			else {
				try {
					articulo.ValorNeto1 = Convert.ToDecimal(txtValorNeto1.Text);
				}
				catch {
					stringBuilder.Append("El valor unitario dos (2) debe ser un numero o cero!\n");
				}
			}
			if (txtValorNeto2.Text == string.Empty) {
				stringBuilder.Append("El valor unitario tres (3) debe ser cero o mayor a cero!\n");
			}
			else {
				try {
					articulo.ValorNeto2 = Convert.ToDecimal(txtValorNeto2.Text);
				}
				catch {
					stringBuilder.Append("El valor unitario tres (3) debe ser un numero o cero!\n");
				}
			}
			articulo.Iva = ((TarifaIVA)cbIVA.SelectedItem).Tarifa;
			articulo.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
			articulo.PrecioVenta1 = Convert.ToDecimal(txtPrecioVenta1.Text);
			articulo.PrecioVenta2 = Convert.ToDecimal(txtPrecioVenta2.Text);
			articulo.Utilidad = Convert.ToDecimal(txtUtilidad.Text);
			articulo.Utilidad1 = Convert.ToDecimal(txtUtilidad1.Text);
			articulo.Utilidad2 = Convert.ToDecimal(txtUtilidad2.Text);
			articulo.Impresion = true;
			articulo.Catalogo = true;
			articulo.PartidaArancelaria = txtPartidaArancelaria.Text;
			articulo.Observacion = txtObservacion.Text;
			if (!checkServicio.Checked) {
				if (txtStockMinimo.Text == string.Empty) {
					stringBuilder.Append("El stock minino debe ser cero o mayor a cero!\n");
				}
				else {
					try {
						articulo.StockMinimo = Convert.ToInt32(txtStockMinimo.Text);
					}
					catch {
						stringBuilder.Append("El stock minimo debe ser un numero o cero!\n");
					}
				}
				if (txtStockMaximo.Text == string.Empty) {
					stringBuilder.Append("El stock maximo debe ser cero o mayor a cero!\n");
					goto IL_559;
				}
				try {
					articulo.StockMaximo = Convert.ToInt32(txtStockMaximo.Text);
					goto IL_559;
				}
				catch {
					stringBuilder.Append("El stock maximo debe ser un numero o cero!\n");
					goto IL_559;
				}
			}
			articulo.StockMaximo = 0;
			articulo.StockMinimo = 0;
			IL_559:
			if (preferencias.ControlaInventario && !checkServicio.Checked) {
				if (articulo.StockMinimo <= 0) {
					stringBuilder.Append("El stock minimo debe ser mayor a cero!\n");
				}
				if (articulo.StockMaximo <= 0) {
					stringBuilder.Append("El stock maximo debe ser mayor a cero!\n");
				}
				if (articulo.StockMinimo >= articulo.StockMaximo) {
					stringBuilder.Append("El stock maximo debe ser mayor a stock minimo!\n");
				}
			}
			if (txtCodigoAlternativo.Text != string.Empty) {
				Articulo art = Articulo.FindByCodigo(txtCodigoAlternativo.Text);
				if (art != null) {
					articulo.CodigoAlternativo = txtCodigoAlternativo.Text;
				}
				else {
					stringBuilder.Append("El articulo alternativo no existe!\n");
				}
			}
			if (txtImpuestoConsumo.Text == string.Empty) {
				stringBuilder.Append("El impuesto al consumo debe ser cero o mayor a cero!\n");
			}
			else {
				try {
					articulo.ImpuestoConsumo = Convert.ToDecimal(txtImpuestoConsumo.Text);
				}
				catch {
					stringBuilder.Append("El impuesto al consumo debe ser un numero o cero!\n");
				}
			}
			if (txtUnidadesArticulo.Text == string.Empty) {
				stringBuilder.Append("Las unidades por articulo debe ser cero o mayor a cero!\n");
			}
			else {
				try {
					articulo.UnidadesArticulo = Convert.ToInt32(txtUnidadesArticulo.Text);
				}
				catch {
					stringBuilder.Append("Las unidades por articulo debe ser un numero o cero!\n");
				}
			}
			if (stringBuilder.Length > 0) {
				MessageBox.Show(stringBuilder.ToString(), "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				validado = false;
			}
			return validado;
		}
		
		public void Articulo2Form()
		{
			txtCodigo.Text = articulo.Codigo;
			txtDescripcion.Text = articulo.Descripcion;
			checkEstado.Checked = articulo.Estado;
			checkServicio.Checked = articulo.Servicio;
			txtCodigoPLU.Text = articulo.CodigoPLU;
			txtDescripcionCorta.Text = articulo.DescripcionCorta;
			txtCodigoBarras.Text = articulo.CodigoBarras;
			cbUnidadMedida.SelectedValue = articulo.UnidadComercialID;
			cbSeccion.SelectedValue = articulo.SeccionID.GetValueOrDefault();
			cbFamilia.SelectedValue = Seccion.Get(articulo.SeccionID.GetValueOrDefault()).FamiliaID.GetValueOrDefault();
			
			//cbSeccion.SelectedIndex = 0;
			//cbUnidadMedida.SelectedIndex = 0;			
			
			if (articulo.Impuesto.Equals(Articulo.IVA)) {
				rbIVA.PerformClick();
			}
			else {
				if (articulo.Impuesto.Equals(Articulo.EXCENTO)) {
					rbExcento.PerformClick();
				}
				else {
					rbExcluido.PerformClick();
				}
			}
			txtCosto.Text = articulo.Costo.ToString(FORMATO_NUMERO);
			txtValorNeto.Text = articulo.ValorNeto.ToString(FORMATO_NUMERO);
			txtValorNeto1.Text = articulo.ValorNeto1.ToString(FORMATO_NUMERO);
			txtValorNeto2.Text = articulo.ValorNeto2.ToString(FORMATO_NUMERO);
			cbIVA.SelectedIndex = cbIVA.FindStringExact(Convert.ToString(articulo.Iva));
			txtPrecioVenta.Text = articulo.PrecioVenta.ToString(FORMATO_NUMERO);
			txtPrecioVenta1.Text = articulo.PrecioVenta1.ToString(FORMATO_NUMERO);
			txtPrecioVenta2.Text = articulo.PrecioVenta2.ToString(FORMATO_NUMERO);
			txtStockActual.Text = Convert.ToString(articulo.StockActual);
			txtStockDisponible.Text = Convert.ToString(articulo.StockDisponible);
			txtStockMaximo.Text = Convert.ToString(articulo.StockMaximo);
			txtStockMinimo.Text = Convert.ToString(articulo.StockMinimo);
			txtCodigoAlternativo.Text = articulo.CodigoAlternativo;
			txtImpuestoConsumo.Text = articulo.ImpuestoConsumo.ToString(FORMATO_NUMERO);
			txtUnidadesArticulo.Text = Convert.ToString(articulo.UnidadesArticulo);
			txtPartidaArancelaria.Text = articulo.PartidaArancelaria;
			txtObservacion.Text = articulo.Observacion;
			if (articulo.RedondeoSistema) {
				rbRedondeoSistema.Checked = articulo.RedondeoSistema;
			}
			else {
				if (articulo.RedondeoSuperior) {
					rbRedondeoSuperior.Checked = articulo.RedondeoSuperior;
				}
				else {
					if (articulo.RedondeoInferior) {
						rbRedondeoInferior.Checked = articulo.RedondeoInferior;
					}
				}
			}
			txtUtilidad.Text = articulo.Utilidad.ToString(FORMATO_NUMERO);
			txtUtilidad1.Text = articulo.Utilidad1.ToString(FORMATO_NUMERO);
			txtUtilidad2.Text = articulo.Utilidad2.ToString(FORMATO_NUMERO);
		}
		
		private void CalcularUtilidad()
		{
			decimal num = 0m;
			try {
				num = Convert.ToDecimal(txtCosto.Text);
			}
			catch {
				num = 0m;
			}
			decimal d = 0m;
			try {
				d = Convert.ToDecimal(txtValorNeto.Text);
			}
			catch {
				d = 0m;
			}
			decimal utilidad;
			if (d > 0m && num > 0m) {
				utilidad = (d - num) / num * 100m;
			}
			else {
				if (num == 0m) {
					utilidad = 100m;
				}
				else {
					utilidad = 0m;
				}
			}
			txtUtilidad.Text = utilidad.ToString(FORMATO_NUMERO);
			articulo.Utilidad = utilidad;
		}

		private void CalcularUtilidad2()
		{
			decimal num = 0m;
			try {
				num = Convert.ToDecimal(txtCosto.Text);
			}
			catch {
				num = 0m;
			}
			decimal d = 0m;
			try {
				d = Convert.ToDecimal(txtValorNeto2.Text);
			}
			catch {
				d = 0m;
			}
			decimal utilidad;
			if (d > 0m && num > 0m) {
				utilidad = (d - num) / num * 100m;
			}
			else {
				if (num == 0m) {
					utilidad = 100m;
				}
				else {
					utilidad = 0m;
				}
			}
			txtUtilidad2.Text = utilidad.ToString(FORMATO_NUMERO);
			articulo.Utilidad2 = utilidad;
		}

		private void CalcularUtilidad1()
		{
			decimal num = 0m;
			try {
				num = Convert.ToDecimal(txtCosto.Text);
			}
			catch {
				num = 0m;
			}
			decimal d = 0m;
			try {
				d = Convert.ToDecimal(txtValorNeto1.Text);
			}
			catch {
				d = 0m;
			}
			decimal utilidad;
			if (d > 0m && num > 0m) {
				utilidad = (d - num) / num * 100m;
			}
			else {
				if (num == 0m) {
					utilidad = 100m;
				}
				else {
					utilidad = 0m;
				}
			}
			txtUtilidad1.Text = utilidad.ToString(FORMATO_NUMERO);
			articulo.Utilidad1 = utilidad;
		}
		private void CalcularPrecioVenta()
		{
			decimal d = 0m;
			try {
				d = Convert.ToDecimal(txtValorNeto.Text);
			}
			catch {
				d = 0m;
			}
			float factor = ((TarifaIVA)cbIVA.SelectedItem).Factor;
			decimal num = 0m;
			if (rbRedondeoSuperior.Checked) {
				num = Math.Ceiling(d * Convert.ToDecimal(factor));
			}
			if (rbRedondeoInferior.Checked) {
				num = Math.Floor(d * Convert.ToDecimal(factor));
			}
			if (rbRedondeoSistema.Checked) {
				num = Math.Round(d * Convert.ToDecimal(factor), preferencias.NumeroDecimal);
			}
			txtPrecioVenta.Text = num.ToString(FORMATO_NUMERO);
		}

		private void CalcularPrecioVenta2()
		{
			decimal d = 0m;
			try {
				d = Convert.ToDecimal(txtValorNeto2.Text);
			}
			catch {
				d = 0m;
			}
			float factor = ((TarifaIVA)cbIVA.SelectedItem).Factor;
			decimal num = 0m;
			if (rbRedondeoSuperior.Checked) {
				num = Math.Ceiling(d * Convert.ToDecimal(factor));
			}
			if (rbRedondeoInferior.Checked) {
				num = Math.Floor(d * Convert.ToDecimal(factor));
			}
			if (rbRedondeoSistema.Checked) {
				num = Math.Round(d * Convert.ToDecimal(factor), preferencias.NumeroDecimal);
			}
			txtPrecioVenta2.Text = num.ToString(FORMATO_NUMERO);
		}

		private void CalcularPrecioVenta1()
		{
			decimal d = 0m;
			try {
				d = Convert.ToDecimal(txtValorNeto1.Text);
			}
			catch {
				d = 0m;
			}
			float factor = ((TarifaIVA)cbIVA.SelectedItem).Factor;
			decimal num = 0m;
			if (rbRedondeoSuperior.Checked) {
				num = Math.Ceiling(d * Convert.ToDecimal(factor));
			}
			if (rbRedondeoInferior.Checked) {
				num = Math.Floor(d * Convert.ToDecimal(factor));
			}
			if (rbRedondeoSistema.Checked) {
				num = Math.Round(d * Convert.ToDecimal(factor), preferencias.NumeroDecimal);
			}
			txtPrecioVenta1.Text = num.ToString(FORMATO_NUMERO);
		}
		
		void CalcularValorNeto()
		{
			decimal num = Convert.ToDecimal(txtCosto.Text) * +(articulo.Utilidad / 100m);
			txtValorNeto.Text = num.ToString(FORMATO_NUMERO);
		}

		void CalcularValorNeto1()
		{
			decimal num = Convert.ToDecimal(txtCosto.Text) * +(articulo.Utilidad1 / 100m);
			txtValorNeto1.Text = num.ToString(FORMATO_NUMERO);
		}

		void CalcularValorNeto2()
		{
			decimal num = Convert.ToDecimal(txtCosto.Text) *+(articulo.Utilidad2 / 100m);
			txtValorNeto2.Text = num.ToString(FORMATO_NUMERO);
		}
		
		void txtCosto_TextChanged(object sender, EventArgs e)
		{
			CalcularUtilidad();
			CalcularUtilidad1();
			CalcularUtilidad2();
		}
		void txtValorNeto_TextChanged(object sender, EventArgs e)
		{
			CalcularPrecioVenta();
			CalcularUtilidad();
		}
		void txtValorNeto1_TextChanged(object sender, EventArgs e)
		{
			CalcularPrecioVenta1();
			CalcularUtilidad1();
		}

		void txtValorNeto2_TextChanged(object sender, EventArgs e)
		{
			CalcularPrecioVenta2();
			CalcularUtilidad2();
		}
		
		void cbIVA_SelectedIndexChanged(object sender, EventArgs e)
		{
			CalcularPrecioVenta();
			CalcularPrecioVenta1();
			CalcularPrecioVenta2();
		}
		void cbFamilia_SelectedIndexChanged(object sender, EventArgs e)
		{
			CargarSeccion();
		}
		void rbExcento_CheckedChanged(object sender, EventArgs e)
		{
			cbIVA.SelectedIndex = cbIVA.FindString(IVA_CERO);
		}

		void rbExcluido_CheckedChanged(object sender, EventArgs e)
		{
			cbIVA.SelectedIndex = cbIVA.FindString(IVA_CERO);
		}

		void rbIVA_CheckedChanged(object sender, EventArgs e)
		{
			cbIVA.SelectedIndex = cbIVA.FindString(IVA_DEFECTO);
		}
		void rbRedondeoNormal_CheckedChanged(object sender, EventArgs e)
		{
			CalcularPrecioVenta();
			CalcularPrecioVenta1();
			CalcularPrecioVenta2();
		}

		void rbRedondeoSuperior_CheckedChanged(object sender, EventArgs e)
		{
			CalcularPrecioVenta();
			CalcularPrecioVenta1();
			CalcularPrecioVenta2();
		}

		void rbRedondeoInferior_CheckedChanged(object sender, EventArgs e)
		{
			CalcularPrecioVenta();
			CalcularPrecioVenta1();
			CalcularPrecioVenta2();
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(ValidarForm2Articulo())
			{
				switch(accion){
					case 1:
						articulo.Save();
						DialogResult = DialogResult.Yes;
						Close();
						break;
					case 2:
						articulo.Update();
						DialogResult = DialogResult.Yes;
						Close();
						break;
				}
			}
		}		
	}
}
