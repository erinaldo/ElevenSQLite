/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.ComponentModel;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of TipoDocumento.
	/// </summary>
	public class TipoDocumento : Persistent
	{
		public TipoDocumento()
		{
		}
		public static int FACTOR_NULO = 0;
		public static int FACTOR_SUMA = 1;
		public static int FACTOR_RESTA = -1;
		public static int INDEX = 1;
		public static int NO_INDEX = -1;
		public static string FACTURA_VENTA = "FV";
		public static string FACTURA_COMPRA = "FC";
		public static string COMPROBANTE_INGRESO = "CI";
		public static string COMPROBANTE_EGRESO = "CE";
		public bool RedondeoAutomatico { get; set; }
		public bool ImpresionDetalleCodigo { get; set; }
		public bool ImpresionLineaFinDetalles { get; set; }
		public bool ImpresionObservacionLinea { get; set; }
		public bool ImpresionDetalleIVA { get; set; }
		public bool ImpresionDetalleDescuento { get; set; }
		public bool ImpresionDetalleCantidad { get; set; }
		public bool Autoretenedor { get; set; }
		public bool MensajeGeneral { get; set; }
		public bool OtroMensaje { get; set; }
		public bool AdvertenciaDIAN { get; set; }
		public bool Comprobante { get; set; }
		public bool Reservado { get; set; }
		public string Autorizacion { get; set; }
		public DateTime? FechaAutorizacion { get; set; }
		public string NumeracionDianDesde { get; set; }
		public string NumeracionDianHasta { get; set; }
		public int CantidadDecimal { get; set; }
		public bool IvaIncluido { get; set; }
		public int CerosIzquierda { get; set; }
		public int LimiteRegistro { get; set; }
		public string TipoFacturacion { get; set; }
		public long? TipoMonedaID { get; set; }
		public string Sufijo { get; set; }
		public string Prefijo { get; set; }
		public string Codigo { get; set; }
		public int ConsecutivoInicial { get; set; }
		public int ConsecutivoFinal { get; set; }
		public int ConsecutivoActual { get; set; }
		public string Descripcion { get; set; }
		public int Factor { get; set; }
		public long? TipoDocumentoMaestroID { get; set; }
		public long? ImpresionDocumentoID { get; set; }
		public int Indice { get; set; }
		public bool ImpresionEncabezado { get; set; }
		public bool ImpresionLogotipo { get; set; }
		public string ColorConsecutivo { get; set; }
		public bool FondoPapel { get; set; }
		public bool ClienteNacional { get; set; }
		public bool ClienteExtranjero { get; set; }
		public bool ProveedorNacional { get; set; }
		public bool ProveedorExtranjero { get; set; }
		public bool Interno { get; set; }
		public bool OtroTipoTercero { get; set; }
		public long? EstadoDocumentoID { get; set; }
		public int CantidadCopias { get; set; }
		public int DiasAdvertenciaDIAN { get; set; }
		
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{
				db.TipoDocumento.Add(this);
				db.SaveChanges();
			}
 		}
		public void Update()
 		{
 			using (var db = new ElevenContext())
			{
 				db.TipoDocumento.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => RedondeoAutomatico).IsModified = true;
				entry.Property(ex => ImpresionDetalleCodigo).IsModified = true;
				entry.Property(ex => ImpresionLineaFinDetalles).IsModified = true;
				entry.Property(ex => ImpresionObservacionLinea).IsModified = true;
				entry.Property(ex => ImpresionDetalleIVA).IsModified = true;
				entry.Property(ex => ImpresionDetalleDescuento).IsModified = true;
				entry.Property(ex => ImpresionDetalleCantidad).IsModified = true;
				entry.Property(ex => Autoretenedor).IsModified = true;
				entry.Property(ex => MensajeGeneral).IsModified = true;
				entry.Property(ex => OtroMensaje).IsModified = true;
				entry.Property(ex => AdvertenciaDIAN).IsModified = true;
				entry.Property(ex => Comprobante).IsModified = true;
				entry.Property(ex => Reservado).IsModified = true;
				entry.Property(ex => Autorizacion).IsModified = true;
				entry.Property(ex => FechaAutorizacion).IsModified = true;
				entry.Property(ex => NumeracionDianDesde).IsModified = true;
				entry.Property(ex => NumeracionDianHasta).IsModified = true;
				entry.Property(ex => CantidadDecimal).IsModified = true;
				entry.Property(ex => IvaIncluido).IsModified = true;
				entry.Property(ex => CerosIzquierda).IsModified = true;
				entry.Property(ex => LimiteRegistro).IsModified = true;
				entry.Property(ex => TipoFacturacion).IsModified = true;
				entry.Property(ex => TipoMonedaID).IsModified = true;
				entry.Property(ex => Sufijo).IsModified = true;
				entry.Property(ex => Prefijo).IsModified = true;
				entry.Property(ex => Codigo).IsModified = true;
				entry.Property(ex => ConsecutivoInicial).IsModified = true;
				entry.Property(ex => ConsecutivoFinal).IsModified = true;
				entry.Property(ex => ConsecutivoActual).IsModified = true;
				entry.Property(ex => Descripcion).IsModified = true;
				entry.Property(ex => Factor).IsModified = true;
				entry.Property(ex => TipoDocumentoMaestroID).IsModified = true;
				entry.Property(ex => ImpresionDocumentoID).IsModified = true;
				entry.Property(ex => Indice).IsModified = true;
				entry.Property(ex => ImpresionEncabezado).IsModified = true;
				entry.Property(ex => ImpresionLogotipo).IsModified = true;
				entry.Property(ex => ColorConsecutivo).IsModified = true;
				entry.Property(ex => FondoPapel).IsModified = true;
				entry.Property(ex => ClienteNacional).IsModified = true;
				entry.Property(ex => ClienteExtranjero).IsModified = true;
				entry.Property(ex => ProveedorNacional).IsModified = true;
				entry.Property(ex => ProveedorExtranjero).IsModified = true;
				entry.Property(ex => Interno).IsModified = true;
				entry.Property(ex => OtroTipoTercero).IsModified = true;
				entry.Property(ex => EstadoDocumentoID).IsModified = true;
				entry.Property(ex => CantidadCopias).IsModified = true;
				entry.Property(ex => DiasAdvertenciaDIAN).IsModified = true;
				db.SaveChanges();
			}
 		}
		public void Delete(){}
		public static TipoDocumento Get(long id)
 		{
 			using(var db = new ElevenContext())
			{  
 				return db.TipoDocumento.Where(x => x.ID == id).FirstOrDefault();
			}
 		}
		
		public static TipoDocumento FindByCodigo(string codigoTipoDocumento)
 		{
 			using(var db = new ElevenContext())
			{  
 				return db.TipoDocumento.Where(x => x.Codigo.Equals(codigoTipoDocumento)).FirstOrDefault();
			}
 		}
		
		public static BindingList<TipoDocumento> GetAll () 
		{
			BindingList<TipoDocumento> lista = new BindingList<TipoDocumento>();
			using(var db = new ElevenContext())
			{  
				foreach( TipoDocumento tmp in db.TipoDocumento.OrderBy(td => td.Codigo))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		
		public static BindingList<TipoDocumento> FindTiposDocumento (TipoDocumentoMaestro tdm) 
		{
			BindingList<TipoDocumento> lista = new BindingList<TipoDocumento>();
			using(var db = new ElevenContext())
			{  
				foreach( TipoDocumento tmp in db.TipoDocumento)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
