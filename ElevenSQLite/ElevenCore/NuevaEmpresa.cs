/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 11:57 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using ElevenSQLite.ElevenUtils;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of NuevaEmpresa.
	/// </summary>
	public class NuevaEmpresa : Persistent
	{
		public string Pais { get; set; }
		public NuevaEmpresa()
		{
			Pais = "169";
		}
		public void Permisos()
		{
			var usuario = Usuario.FindByUsername("admin");
			var permiso = new Permiso();
			permiso.FechaCreacion = DateTime.Now;
			permiso.UsuarioID = usuario.ID;
			permiso.Articulos = true;
			permiso.Comprobantes = true;
			permiso.Documentos = true;
			permiso.EliminarDetalleTicket = true;
			permiso.Empresa = true;
			permiso.Imagenes = true;
			permiso.Informes = true;
			permiso.Maestros = true;
			permiso.Mantenimiento = true;
			permiso.Mensajes = true;
			permiso.NuevoTicket = true;
			permiso.Preferencias = true;
			permiso.Sistema = true;
			permiso.Terceros = true;
			permiso.TerminalPV = true;
			permiso.TiposDocumento = true;
			permiso.Usuarios = true;
			permiso.Save();
			IList<TipoDocumento> all = TipoDocumento.GetAll();
			foreach (TipoDocumento current in all) {
				var permisoTipoDocumento = new PermisoTipoDocumento();
				permisoTipoDocumento.FechaCreacion = DateTime.Now;
				permisoTipoDocumento.UsuarioID = usuario.ID;
				permisoTipoDocumento.TipoDocumentoID = current.ID;
				permisoTipoDocumento.Nuevo = true;
				permisoTipoDocumento.Modificar = true;
				permisoTipoDocumento.Anular = true;
				permisoTipoDocumento.Eliminar = true;
				permisoTipoDocumento.Imprimir = true;
				permisoTipoDocumento.Save();
			}
		}
		public void Sistema()
		{			
			var sistema = new Sistema();
			sistema.FechaCreacion = DateTime.Now;
			sistema.Empresa = "VERSION DEMO";
			sistema.VersionDB = (float)Entorno.VERSION_DB;
			sistema.Serial = RandomSNKGenerator.GetSerialKeyAlphaNumeric(SNKeyLength.SN16, SNDelimiter.Hyphen, 4);
			sistema.Red = false;
			sistema.Email = "NINGUNO";
			sistema.ClaveAcceso = false;
			sistema.GlobalTime = DateTime.Now.Ticks;
			sistema.ActualizarSoftware = true;
			char c = Entorno.RUTA[0];
			if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) {
				sistema.VolumenSerial = SerialInformation.GetVolumeSerial(Convert.ToString(c));
			}
			sistema.Save();
			var usuario = new Usuario();
			usuario.NombreUsuario = "admin";
			usuario.Clave = ClientMethods.EncriptarClave("admin");
			usuario.FechaCreacion = DateTime.Now;
			usuario.Save();
			var empresa = new Empresa();
			empresa.FechaCreacion = DateTime.Now;
			empresa.RazonSocial = "EMPRESA DE PRUEBA";
			empresa.Nit = "123.456.789-0";
			empresa.CiudadID = 181;
			empresa.Save();
			var preferencias = new Preferencias();
			preferencias.FechaCreacion = DateTime.Now;
			preferencias.MensajeCentralRiesgo = "Esta factura causara un interés de mora a la tasa máxima permitida por la ley a partir de su fecha de vencimiento. Autorizamos a {0} o a quien represente sus derechos para que reporte a las centrales de riesgo financiero, bien sea FENALCO, PROCREDITO O DATACREDITO O cualquier otra base de datos que cumpla esta función cualquier incumplimiento del deudor.";
			preferencias.MensajeTituloValor = "La presente factura cambiaria se asimila en todos sus efectos legales a una letra de cambio (art. 774 del código de comercio). El cliente firma en señal de aceptación y de haber recibido a entera satisfacción, real y materialmente, la mercancía aquí descrita. Se hace constar que la firma de persona distinta al comprador supone que dicha persona esta autorizada por el comprador para firmar y recibir, confesar la deuda y obligar al comprador.";
			preferencias.ControlaInventario = false;
			preferencias.ObservacionDocumento = "GRACIAS POR SU COMPRA.";
			preferencias.OtraObservacionDocumento = "OBSERVACION DOS (preferencias->mensajes facturación).";
			preferencias.SeparadorMiles = "en-US";
			preferencias.ImpresionLogotipo = false;
			preferencias.ImpresionEncabezado = true;
			preferencias.ObservacionNotaDebito = "Se ha cargado en su cuenta corriente por concepto de intereses o diferencias de mayor precio, segun factura numero {0} de fecha {1} la que es aumentada en ese valor.";
			preferencias.ObservacionNotaCredito = "Se ha abonado en su cuenta corriente por concepto de descuento o devolución de mercancia, segun factura numero {0} de fecha {1} la que se disminuira en este valor.";
			preferencias.UltimaConfiguracion = true;
			preferencias.UsuarioID = usuario.ID;
			preferencias.PuertoSalida = "LPT1";
			preferencias.BusquedaLector = "BARRAS";
			preferencias.RedondeoSistema = true;
			preferencias.ImprimirTirilla = true;
			preferencias.EnvioInformacionAnonima = true;
			preferencias.Save();
		}
		
		public void LlenarDB()
		{
			var estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.ACTIVADO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.ANULADO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.COTIZADO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.DESACTIVADO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.DEVUELTO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.FACTURADO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.INVENTARIADO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.NO_PAGADO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.ORDENADO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.PAGADO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.PAGADO_PARCIALMENTE;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.PEDIDO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.PROCESADO;
			estadoDocumento.Save();
			estadoDocumento = new EstadoDocumento();
			estadoDocumento.FechaCreacion = DateTime.Now;
			estadoDocumento.Descripcion = EstadoDocumento.REMISIONADO;
			estadoDocumento.Save();
			
			foreach (KeyValuePair<string, string> current in new Dictionary<string, string> {
				{
					"COTIZACION VENTA CARTA",
					"CotizacionVenta"
				},
				{
					"PEDIDO CARTA",
					"OrdenPedido"
				},
				{
					"REMISION CARTA",
					"Remision"
				},
				{
					"FACTURA VENTA CARTA",
					"FacturaVenta"
				},
				{
					"ORDEN COMPRA CARTA",
					"OrdenCompra"
				},
				{
					"NOTA DEBITO CARTA",
					"NotaDebito"
				},
				{
					"NOTA CREDITO CARTA",
					"NotaCredito"
				},
				{
					"DEVOLUCION VENTA CARTA - NC",
					"DevolucionVenta"
				},
				{
					"DEVOLUCION COMPRA CARTA - ND",
					"DevolucionCompra"
				},
				{
					"COMPROBANTE DE INGRESO CARTA",
					"ComprobanteIngreso"
				},
				{
					"COMPROBANTE DE EGRESO CARTA",
					"ComprobanteEgreso"
				}
			}) {
				var impresionDocumento = new ImpresionDocumento();
				impresionDocumento.Descripcion = current.Key;
				impresionDocumento.FechaCreacion = DateTime.Now;
				impresionDocumento.Clase = "SoluPYME.Reportes.GenericaCarta";
				impresionDocumento.Metodo = current.Value;
				impresionDocumento.TipoImpresion = ImpresionDocumento.IMPRESION_NORMAL;
				impresionDocumento.Save();
			}
			
			foreach (KeyValuePair<string, string> current2 in new Dictionary<string, string> {
				{
					"PEDIDO 1/2 CARTA",
					"OrdenPedido"
				},
				{
					"REMISION 1/2 CARTA",
					"Remision"
				},
				{
					"FACTURA VENTA 1/2 CARTA",
					"FacturaVenta"
				},
				{
					"COTIZACION COMPRA 1/2 CARTA",
					"CotizacionCompra"
				},
				{
					"ORDEN COMPRA 1/2 CARTA",
					"OrdenCompra"
				},
				{
					"NOTA DEBITO 1/2 CARTA",
					"NotaDebito"
				},
				{
					"NOTA CREDITO 1/2 CARTA",
					"NotaCredito"
				},
				{
					"DEVOLUCION VENTA 1/2 CARTA - NC",
					"DevolucionVenta"
				},
				{
					"DEVOLUCION COMPRA 1/2 CARTA - ND",
					"DevolucionCompra"
				},
				{
					"COMPROBANTE DE INGRESO 1/2 CARTA",
					"ComprobanteIngreso"
				},
				{
					"COMPROBANTE DE EGRESO 1/2 CARTA",
					"ComprobanteEgreso"
				}
			}) {
				var impresionDocumento = new ImpresionDocumento();
				impresionDocumento.Descripcion = current2.Key;
				impresionDocumento.FechaCreacion = DateTime.Now;
				impresionDocumento.Clase = "SoluPYME.Reportes.GenericaMediaCarta";
				impresionDocumento.Metodo = current2.Value;
				impresionDocumento.TipoImpresion = ImpresionDocumento.IMPRESION_NORMAL;
				impresionDocumento.Save();
			}
			
			foreach (KeyValuePair<string, string> current3 in new Dictionary<string, string> {
				{
					"PEDIDO LOGO CARTA",
					"OrdenPedido"
				},
				{
					"REMISION LOGO CARTA",
					"Remision"
				},
				{
					"FACTURA VENTA LOGO CARTA",
					"FacturaVenta"
				},
				{
					"COTIZACION COMPRA LOGO CARTA",
					"CotizacionCompra"
				},
				{
					"ORDEN COMPRA LOGO CARTA",
					"OrdenCompra"
				},
				{
					"NOTA DEBITO LOGO CARTA",
					"NotaDebito"
				},
				{
					"NOTA CREDITO LOGO CARTA",
					"NotaCredito"
				},
				{
					"DEVOLUCION VENTA LOGO CARTA - NC",
					"DevolucionVenta"
				},
				{
					"DEVOLUCION COMPRA LOGO CARTA - ND",
					"DevolucionCompra"
				},
				{
					"COMPROBANTE DE INGRESO LOGO CARTA",
					"ComprobanteIngreso"
				},
				{
					"COMPROBANTE DE EGRESO LOGO CARTA",
					"ComprobanteEgreso"
				}
			}) {
				var impresionDocumento = new ImpresionDocumento();
				impresionDocumento.Descripcion = current3.Key;
				impresionDocumento.FechaCreacion = DateTime.Now;
				impresionDocumento.Clase = "SoluPYME.Reportes.GenericaLogoCarta";
				impresionDocumento.Metodo = current3.Value;
				impresionDocumento.TipoImpresion = ImpresionDocumento.IMPRESION_NORMAL;
				impresionDocumento.Save();
			}
			
			foreach (KeyValuePair<string, string> current4 in new Dictionary<string, string> {
				{
					"INFORME DIARIO DE VENTAS",
					"InformeDiarioVenta"
				},
				{
					"INFORME DE VENTAS CONSOLIDADO ENTRE FECHAS ",
					"InformeVentaConsolidado"
				},
				{
					"CUENTAS POR COBRAR ENTRE FECHAS",
					"InformeCuentasCobrar"
				},
				{
					"CUENTAS POR COBRAR VENCIDAS",
					"InformeCuentasCobrarVencidas"
				},
				{
					"TOTAL DE INGRESOS ENTRE FECHAS",
					"InformeIngresos"
				},
				{
					"TOTAL DE EGRESOS  ENTRE FECHAS",
					"InformeEgresos"
				},
				{
					"CUENTAS POR PAGAR ENTRE FECHAS",
					"InformeCuentasPagar"
				},
				{
					"ARTICULOS VENDIDOS A UN TERCERO ENTRE FECHAS",
					"InformeArticulosTercero"
				},
				{
					"INFORME CONSOLIDADO ENTRE FECHAS DE UN DOCUMENTO",
					"InformeConsolidado"
				},
				{
					"MOVIMIENTO DE INVENTARIO",
					"MovimientoInventario"
				}
			}) {
				var impresionDocumento = new ImpresionDocumento();
				impresionDocumento.Descripcion = current4.Key;
				impresionDocumento.FechaCreacion = DateTime.Now;
				impresionDocumento.Clase = "SoluPYME.Reportes.GenericaInformes";
				impresionDocumento.Metodo = current4.Value;
				impresionDocumento.TipoImpresion = ImpresionDocumento.IMPRESION_NORMAL;
				impresionDocumento.Save();
			}
			
			var tipoMoneda = new TipoMoneda();
			tipoMoneda.Codigo = "US";
			tipoMoneda.Descripcion = TipoMoneda.DOLARES;
			tipoMoneda.FechaCreacion = DateTime.Now;
			tipoMoneda.Save();
			tipoMoneda = new TipoMoneda();
			tipoMoneda.Codigo = "E";
			tipoMoneda.Descripcion = TipoMoneda.EUROS;
			tipoMoneda.FechaCreacion = DateTime.Now;
			tipoMoneda.Save();
			tipoMoneda = new TipoMoneda();
			tipoMoneda.Codigo = "COL";
			tipoMoneda.Descripcion = TipoMoneda.PESOS;
			tipoMoneda.FechaCreacion = DateTime.Now;
			tipoMoneda.Save();
			
			var tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.COTIZACION_VENTA;
			tipoDocumentoMaestro.Descripcion = "COTIZACIÓN DE VENTA";
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.COTIZADO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.COTIZADO).ID;
			tipoDocumentoMaestro.ImpresionesDocumento.Add(ImpresionDocumento.FindByDescripcion("COTIZACION VENTA CARTA"));
			tipoDocumentoMaestro.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("COTIZACION VENTA CARTA").ID;
			tipoDocumentoMaestro.Save();
			
			var tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = "CV";
			tipoDocumento.Descripcion = "COTIZACIÓN DE VENTA";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_NULO;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.TipoDocumentoMaestroID = tipoDocumentoMaestro.ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = false;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = Tercero.REGIMEN_COMUN;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.FondoPapel = false;
			tipoDocumento.ClienteExtranjero = true;
			tipoDocumento.ClienteNacional = true;
			tipoDocumento.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("COTIZACION VENTA CARTA").ID;
			tipoDocumento.Save();
			
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.ORDEN_PEDIDO;
			tipoDocumentoMaestro.Descripcion = "ORDEN DE PEDIDO";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ORDENADO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.ORDENADO).ID;
			tipoDocumentoMaestro.ImpresionesDocumento.Add(ImpresionDocumento.FindByDescripcion("PEDIDO CARTA"));
			tipoDocumentoMaestro.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("PEDIDO CARTA").ID;
			tipoDocumentoMaestro.Save();
			tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = "OP";
			tipoDocumento.Descripcion = "ORDEN DE PEDIDO";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_NULO;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.TipoDocumentoMaestroID = tipoDocumentoMaestro.ID;
			tipoDocumento.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("PEDIDO CARTA").ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = true;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = string.Empty;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.ClienteExtranjero = true;
			tipoDocumento.ClienteNacional = true;
			tipoDocumento.FondoPapel = false;
			tipoDocumento.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.REMISION;
			tipoDocumentoMaestro.Descripcion = "REMISION";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.REMISIONADO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.REMISIONADO).ID;
			tipoDocumentoMaestro.ImpresionesDocumento.Add(ImpresionDocumento.FindByDescripcion("REMISION CARTA"));
			tipoDocumentoMaestro.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("REMISION CARTA").ID;
			tipoDocumentoMaestro.Save();
			tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = "REM";
			tipoDocumento.Descripcion = "REMISION";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_RESTA;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.TipoDocumentoMaestroID = tipoDocumentoMaestro.ID;
			tipoDocumento.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("REMISION CARTA").ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = true;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = string.Empty;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.ClienteExtranjero = true;
			tipoDocumento.ClienteNacional = true;
			tipoDocumento.FondoPapel = false;
			tipoDocumento.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.FACTURA_VENTA;
			tipoDocumentoMaestro.Descripcion = "FACTURA DE VENTA";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.FACTURADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO_PARCIALMENTE));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.FACTURADO).ID;
			tipoDocumentoMaestro.ImpresionesDocumento.Add(ImpresionDocumento.FindByDescripcion("FACTURA VENTA CARTA"));
			tipoDocumentoMaestro.ImpresionesDocumento.Add(ImpresionDocumento.FindByDescripcion("FACTURA VENTA 1/2 CARTA"));
			tipoDocumentoMaestro.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("FACTURA VENTA CARTA").ID;
			tipoDocumentoMaestro.Save();
			tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = TipoDocumentoMaestro.FACTURA_VENTA;
			tipoDocumento.Descripcion = "FACTURA DE VENTA";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_NULO;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.TipoDocumentoMaestroID = tipoDocumentoMaestro.ID;
			tipoDocumento.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("FACTURA VENTA CARTA").ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = false;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = Tercero.REGIMEN_COMUN;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ImpresionDetalleCantidad = true;
			tipoDocumento.ImpresionDetalleDescuento = true;
			tipoDocumento.ImpresionDetalleIVA = true;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.ClienteExtranjero = true;
			tipoDocumento.ClienteNacional = true;
			tipoDocumento.FondoPapel = false;
			tipoDocumento.FechaAutorizacion = new DateTime?(DateTime.Now.AddMonths(2));
			tipoDocumento.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.SALIDA_INVENTARIO;
			tipoDocumentoMaestro.Descripcion = "SALIDA INVENTARIO";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.INVENTARIADO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.INVENTARIADO).ID;
			tipoDocumentoMaestro.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.ORDEN_COMPRA;
			tipoDocumentoMaestro.Descripcion = "ORDEN DE COMPRA";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ORDENADO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.ORDENADO).ID;
			tipoDocumentoMaestro.ImpresionesDocumento.Add(ImpresionDocumento.FindByDescripcion("ORDEN COMPRA CARTA"));
			tipoDocumentoMaestro.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("ORDEN COMPRA CARTA").ID;
			tipoDocumentoMaestro.Save();
			tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = "OC";
			tipoDocumento.Descripcion = "ORDEN DE COMPRA";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_NULO;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.TipoDocumentoMaestroID = tipoDocumentoMaestro.ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = false;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = string.Empty;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.ProveedorExtranjero = true;
			tipoDocumento.ProveedorNacional = true;
			tipoDocumento.FondoPapel = false;
			tipoDocumento.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.FACTURA_COMPRA;
			tipoDocumentoMaestro.Descripcion = "FACTURA DE COMPRA";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.FACTURADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO_PARCIALMENTE));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.PAGADO).ID;
			tipoDocumentoMaestro.Save();
			tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = "FC";
			tipoDocumento.Descripcion = "FACTURA DE COMPRA";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_SUMA;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.TipoDocumentoMaestroID = tipoDocumentoMaestro.ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = false;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = string.Empty;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.ProveedorExtranjero = true;
			tipoDocumento.ProveedorNacional = true;
			tipoDocumento.FondoPapel = false;
			tipoDocumento.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.ENTRADA_INVENTARIO;
			tipoDocumentoMaestro.Descripcion = "ENTRADA INVENTARIO";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.INVENTARIADO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.INVENTARIADO).ID;
			tipoDocumentoMaestro.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.DEVOLUCION_VENTA;
			tipoDocumentoMaestro.Descripcion = "DEVOLUCION VENTA";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.DEVUELTO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.DEVUELTO).ID;
			tipoDocumentoMaestro.ImpresionesDocumento.Add(ImpresionDocumento.FindByDescripcion("DEVOLUCION VENTA CARTA - NC"));
			tipoDocumentoMaestro.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("DEVOLUCION VENTA CARTA - NC").ID;
			tipoDocumentoMaestro.Save();
			tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = "DEV";
			tipoDocumento.Descripcion = "DEVOLUCION VENTA";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_SUMA;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.TipoDocumentoMaestroID = tipoDocumentoMaestro.ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = true;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = string.Empty;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.ClienteExtranjero = true;
			tipoDocumento.ClienteNacional = true;
			tipoDocumento.Interno = true;
			tipoDocumento.FondoPapel = false;
			tipoDocumento.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.DEVOLUCION_COMPRA;
			tipoDocumentoMaestro.Descripcion = "DEVOLUCION COMPRA";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.DEVUELTO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.DEVUELTO).ID;
			tipoDocumentoMaestro.ImpresionesDocumento.Add(ImpresionDocumento.FindByDescripcion("DEVOLUCION COMPRA CARTA - ND"));
			tipoDocumentoMaestro.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("DEVOLUCION COMPRA CARTA - ND").ID;
			tipoDocumentoMaestro.Save();
			tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = "DEC";
			tipoDocumento.Descripcion = "DEVOLUCION COMPRA";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_RESTA;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.TipoDocumentoMaestroID = tipoDocumentoMaestro.ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = true;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = string.Empty;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.ProveedorExtranjero = true;
			tipoDocumento.ProveedorNacional = true;
			tipoDocumento.Interno = true;
			tipoDocumento.FondoPapel = false;
			tipoDocumento.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.INVENTARIO_INICIAL;
			tipoDocumentoMaestro.Descripcion = "INVENTARIO INICIAL";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_DOCUMENTO;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.INVENTARIADO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.INVENTARIADO).ID;
			tipoDocumentoMaestro.Save();
			tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = "II";
			tipoDocumento.Descripcion = "INVENTARIO INICIAL";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_SUMA;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.ID = tipoDocumentoMaestro.ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = true;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = string.Empty;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.FondoPapel = false;
			tipoDocumento.Interno = true;
			tipoDocumento.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.COMPROBANTE_EGRESO;
			tipoDocumentoMaestro.Descripcion = "COMPROBANTE DE EGRESO";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_COMPROBANTE;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.PROCESADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.PROCESADO).ID;
			tipoDocumentoMaestro.ImpresionesDocumento.Add(ImpresionDocumento.FindByDescripcion("COMPROBANTE DE EGRESO 1/2 CARTA"));
			tipoDocumentoMaestro.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("COMPROBANTE DE EGRESO 1/2 CARTA").ID;
			tipoDocumentoMaestro.Save();
			tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = TipoDocumentoMaestro.COMPROBANTE_EGRESO;
			tipoDocumento.Descripcion = "COMPROBANTE DE EGRESO";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_NULO;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.ID = tipoDocumentoMaestro.ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = true;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = string.Empty;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.FondoPapel = false;
			tipoDocumento.ProveedorNacional = true;
			tipoDocumento.ProveedorExtranjero = true;
			tipoDocumento.Comprobante = true;
			tipoDocumento.Save();
			tipoDocumentoMaestro = new TipoDocumentoMaestro();
			tipoDocumentoMaestro.Codigo = TipoDocumentoMaestro.COMPROBANTE_INGRESO;
			tipoDocumentoMaestro.Descripcion = "COMPROBANTE DE INGRESO";
			tipoDocumentoMaestro.Grupo = TipoDocumentoMaestro.GRUPO_COMPROBANTE;
			tipoDocumentoMaestro.FechaCreacion = DateTime.Now;
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.PROCESADO));
			tipoDocumentoMaestro.EstadosDocumento.Add(EstadoDocumento.FindByEstado(EstadoDocumento.ANULADO));
			tipoDocumentoMaestro.EstadoDocumentoID = EstadoDocumento.FindByEstado(EstadoDocumento.PROCESADO).ID;
			tipoDocumentoMaestro.ImpresionesDocumento.Add(ImpresionDocumento.FindByDescripcion("COMPROBANTE DE INGRESO 1/2 CARTA"));
			tipoDocumentoMaestro.ImpresionDocumentoID = ImpresionDocumento.FindByDescripcion("COMPROBANTE DE INGRESO 1/2 CARTA").ID;
			tipoDocumentoMaestro.Save();
			tipoDocumento = new TipoDocumento();
			tipoDocumento.Codigo = TipoDocumentoMaestro.COMPROBANTE_INGRESO;
			tipoDocumento.Descripcion = "COMPROBANTE DE INGRESO";
			tipoDocumento.ConsecutivoInicial = 1;
			tipoDocumento.ConsecutivoFinal = 1000;
			tipoDocumento.ConsecutivoActual = 1;
			tipoDocumento.Indice = TipoDocumento.INDEX;
			tipoDocumento.Factor = TipoDocumento.FACTOR_NULO;
			tipoDocumento.FechaCreacion = DateTime.Now;
			tipoDocumento.TipoDocumentoMaestroID = tipoDocumentoMaestro.ID;
			tipoDocumento.CantidadDecimal = 0;
			tipoDocumento.CerosIzquierda = 5;
			tipoDocumento.IvaIncluido = true;
			tipoDocumento.LimiteRegistro = 20;
			tipoDocumento.TipoFacturacion = string.Empty;
			tipoDocumento.TipoMonedaID = tipoMoneda.ID;
			tipoDocumento.Reservado = true;
			tipoDocumento.ImpresionEncabezado = true;
			tipoDocumento.ImpresionLogotipo = false;
			tipoDocumento.ColorConsecutivo = "RED";
			tipoDocumento.ClienteNacional = true;
			tipoDocumento.ClienteExtranjero = true;
			tipoDocumento.FondoPapel = false;
			tipoDocumento.Comprobante = true;
			tipoDocumento.Save();
			
			var unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "cm3";
			unidadComercial.Descripcion = "Centímetro Cúbico";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "c/t";
			unidadComercial.Descripcion = "Quilate";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "kg";
			unidadComercial.Descripcion = "Kilogramo";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "kwh";
			unidadComercial.Descripcion = "Kilovatios hora";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "l";
			unidadComercial.Descripcion = "Litro";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "m";
			unidadComercial.Descripcion = "Metro";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "mil";
			unidadComercial.Descripcion = "Miles de unidades o articulos";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "m2";
			unidadComercial.Descripcion = "Metro cuadrado";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "m3";
			unidadComercial.Descripcion = "Metro cubico";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "u";
			unidadComercial.Descripcion = "Unidades o artículos";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "12u";
			unidadComercial.Descripcion = "Docena";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			unidadComercial = new UnidadComercial();
			unidadComercial.Codigo = "2u";
			unidadComercial.Descripcion = "Par";
			unidadComercial.FechaCreacion = DateTime.Now;
			unidadComercial.Save();
			
			var familia = new Familia();
			familia.Codigo = "01";
			familia.Descripcion = "GENERAL";
			familia.FechaCreacion = DateTime.Now;
			familia.Save();
			
			var seccion = new Seccion();
			seccion.Codigo = "01";
			seccion.Descripcion = "GENERAL";
			seccion.FechaCreacion = DateTime.Now;
			seccion.FamiliaID = familia.ID;
			seccion.Save();
			
			var tarifaIVA = new TarifaIVA();
			tarifaIVA.Tarifa = 0f;
			tarifaIVA.Factor = 1f;
			tarifaIVA.FechaCreacion = DateTime.Now;
			tarifaIVA.Save();
			tarifaIVA = new TarifaIVA();
			tarifaIVA.Tarifa = 1.6f;
			tarifaIVA.Factor = 1.016f;
			tarifaIVA.FechaCreacion = DateTime.Now;
			tarifaIVA.Save();
			tarifaIVA = new TarifaIVA();
			tarifaIVA.Tarifa = 3f;
			tarifaIVA.Factor = 1.03f;
			tarifaIVA.FechaCreacion = DateTime.Now;
			tarifaIVA.Save();
			tarifaIVA = new TarifaIVA();
			tarifaIVA.Tarifa = 5f;
			tarifaIVA.Factor = 1.05f;
			tarifaIVA.FechaCreacion = DateTime.Now;
			tarifaIVA.Save();
			tarifaIVA = new TarifaIVA();
			tarifaIVA.Tarifa = 10f;
			tarifaIVA.Factor = 1.1f;
			tarifaIVA.FechaCreacion = DateTime.Now;
			tarifaIVA.Save();
			tarifaIVA = new TarifaIVA();
			tarifaIVA.Tarifa = 16f;
			tarifaIVA.Factor = 1.16f;
			tarifaIVA.FechaCreacion = DateTime.Now;
			tarifaIVA.Save();
			tarifaIVA = new TarifaIVA();
			tarifaIVA.Tarifa = 20f;
			tarifaIVA.Factor = 1.2f;
			tarifaIVA.FechaCreacion = DateTime.Now;
			tarifaIVA.Save();
			tarifaIVA = new TarifaIVA();
			tarifaIVA.Tarifa = 25f;
			tarifaIVA.Factor = 1.25f;
			tarifaIVA.FechaCreacion = DateTime.Now;
			tarifaIVA.Save();
			tarifaIVA = new TarifaIVA();
			tarifaIVA.Tarifa = 19f;
			tarifaIVA.Factor = 1.19f;
			tarifaIVA.FechaCreacion = DateTime.Now;
			tarifaIVA.Save();
			
			var tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 0f;
			tarifaRetencion.Factor = 1f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 0.1f;
			tarifaRetencion.Factor = 1.001f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 0.5f;
			tarifaRetencion.Factor = 1.005f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 1f;
			tarifaRetencion.Factor = 1.01f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 1.5f;
			tarifaRetencion.Factor = 1.015f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 2f;
			tarifaRetencion.Factor = 1.02f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 3.5f;
			tarifaRetencion.Factor = 1.035f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 4f;
			tarifaRetencion.Factor = 1.04f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 6f;
			tarifaRetencion.Factor = 1.06f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 7f;
			tarifaRetencion.Factor = 1.07f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 10f;
			tarifaRetencion.Factor = 1.1f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 11f;
			tarifaRetencion.Factor = 1.11f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			tarifaRetencion = new TarifaRetencion();
			tarifaRetencion.Tarifa = 20f;
			tarifaRetencion.Factor = 1.2f;
			tarifaRetencion.FechaCreacion = DateTime.Now;
			tarifaRetencion.Save();
			
			var condicionPago = new CondicionPago();
			condicionPago.FechaCreacion = DateTime.Now;
			condicionPago.Descripcion = "CONTADO";
			condicionPago.Dias = 0;
			condicionPago.ProntoPago = 0f;
			condicionPago.Recargo = 0f;
			condicionPago.Save();
			condicionPago = new CondicionPago();
			condicionPago.FechaCreacion = DateTime.Now;
			condicionPago.Descripcion = "30 dias";
			condicionPago.Dias = 30;
			condicionPago.ProntoPago = 0f;
			condicionPago.Recargo = 0f;
			condicionPago.Save();
			condicionPago = new CondicionPago();
			condicionPago.FechaCreacion = DateTime.Now;
			condicionPago.Descripcion = "45 dias";
			condicionPago.Dias = 45;
			condicionPago.ProntoPago = 0f;
			condicionPago.Recargo = 0f;
			condicionPago.Save();
			condicionPago = new CondicionPago();
			condicionPago.FechaCreacion = DateTime.Now;
			condicionPago.Descripcion = "60 dias";
			condicionPago.Dias = 60;
			condicionPago.ProntoPago = 0f;
			condicionPago.Recargo = 0f;
			condicionPago.Save();
			condicionPago = new CondicionPago();
			condicionPago.FechaCreacion = DateTime.Now;
			condicionPago.Descripcion = "90 dias";
			condicionPago.Dias = 90;
			condicionPago.ProntoPago = 0f;
			condicionPago.Recargo = 0f;
			condicionPago.Save();
			
			var banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "Banco AV Villas";
			banco.Save();
			banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "Banco Caja Social BCSC";
			banco.Save();
			banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "Banco de Bogotá";
			banco.Save();
			banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "Banco de Occidente";
			banco.Save();
			banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "Banco GNB Sudameris";
			banco.Save();
			banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "Banco Popular";
			banco.Save();
			banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "Bancolombia";
			banco.Save();
			banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "BBVA";
			banco.Save();
			banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "Citi Bank";
			banco.Save();
			banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "Colpatria";
			banco.Save();
			banco = new Banco();
			banco.FechaCreacion = DateTime.Now;
			banco.Descripcion = "Davivienda";
			banco.Save();
			
			var integracionContable = new IntegracionContable();
			integracionContable.TipoDocumentoID = TipoDocumento.FindByCodigo(TipoDocumento.FACTURA_VENTA).ID;
			integracionContable.FechaCreacion = DateTime.Now;
			integracionContable.Save();
			integracionContable = new IntegracionContable();
			integracionContable.TipoDocumentoID = TipoDocumento.FindByCodigo(TipoDocumento.FACTURA_COMPRA).ID;
			integracionContable.FechaCreacion = DateTime.Now;
			integracionContable.Save();
			
			var empleado = new Empleado();
			empleado.Codigo = "Admin";
			empleado.NombreCompleto = "Administrador";
			empleado.Save();
			
			foreach (var ciudad in Ciudad.GetAll()) 
			{
				ciudad.EstadoID = Estado.FindByCodigo(ciudad.Codigo.Substring(0,2)).ID;
				ciudad.Update();
			}
			
		}
		
	}
}
