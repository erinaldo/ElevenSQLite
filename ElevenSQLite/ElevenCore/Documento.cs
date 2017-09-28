/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:11 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Documento.
	/// </summary>
	public class Documento : Persistent
	{
		public Documento()
		{
			Detalles = new List<DetalleDocumento>();
		}
		public  int Consecutivo { get; set; }
		public  long TipoDocumentoID { get; set; }
		public  string CodigoTercero { get; set; }
		public  int NitTercero { get; set; }
		public  int DigitoVerificacionTercero { get; set; }
		public  string NombreComercialTercero { get; set; }
		public  string DireccionPrincipalTercero { get; set; }
		public  string TelefonoPrincipalTercero { get; set; }
		public  string CiudadPrincipalTercero { get; set; }
		public  long TerceroID { get; set; }
		public  DateTime? FechaDocumento { get; set; }
		public  DateTime? FechaAnulacion { get; set; }
		public  DateTime? FechaImpresion { get; set; }
		public  DateTime? FechaVencimiento { get; set; }		
		public  string Zona { get; set; }
		public  string Guia { get; set; }
		public  string Transportador { get; set; }
		public  bool CalcularIva { get; set; }
		[NotMapped]
		public  bool CalcularDescuento { get; set; }
		[NotMapped]
		public  IList<DetalleDocumento> Detalles { get; set; }		
		public  long EstadoDocumentoID { get; set; }
		public  string Referencia { get; set; }
		public  long DocumentoPadreID { get; set; }
		public  string Observacion { get; set; }
		public  string AgenteComercial { get; set; }
		public  decimal Total { get; set; }
		public  int TotalIva { get; set; }
		public  decimal TotalDescuento { get; set; }
		public  decimal TotalImpuesto1 { get; set; }
		public  decimal TotalImpuesto2 { get; set; }
		[NotMapped]
		public  decimal TotalOtrosValores { get; set; }
		public  long TipoMonedaID { get; set; }
		public  decimal CambioTipoMoneda { get; set; }
		public  decimal TotalImpuestoConsumo { get; set; }
		public  decimal SubTotal { get; set; }
		public  long UsuarioID { get; set; }
		public  long ImpresionDocumentoID { get; set; }
		public  float Recargo { get; set; }
		public  float ProntoPago { get; set; }
		public  string Condicion { get; set; }
		public  decimal TotalRetencion { get; set; }
		public  decimal TotalRetencionIca { get; set; }
		public  decimal TotalAbono { get; set; }
		public  decimal TotalRecargo { get; set; }
		public  decimal TotalExcedente { get; set; }
		public  decimal TotalFlete { get; set; }
		public  string Texto1 { get; set; }
		public  string Texto2 { get; set; }
		public  string Texto3 { get; set; }
		public  string Texto4 { get; set; }
		public  string Texto5 { get; set; }
		public  decimal Numero1 { get; set; }
		public  decimal Numero2 { get; set; }
		public  decimal Numero3 { get; set; }
		public  decimal Numero4 { get; set; }
		public  decimal Numero5 { get; set; }
		public  decimal TotalRetencionIva { get; set; }
		public  long EmpleadoID { get; set; }
		
		[NotMapped]
		public  decimal TotalPago
		{
			//get { return Total - (TotalRetencion + TotalRetencionIca + TotalRetencionIva); }
			set;
			get;
			
			
		}
		[NotMapped]
		public  decimal PorcentajeRetencion { get { return TotalRetencion == 0 ? 0 :  SubTotal / TotalRetencion;} }
		public void Save()
		{
			using (var db = new ElevenContext())
			{
				db.Documento.Add(this);
				db.SaveChanges();
				foreach (var detalle in Detalles) {
					detalle.DocumentoID = ID;
					detalle.ArticuloID = Articulo.FindByCodigo(detalle.Codigo).ID;
					detalle.Save();
				}
				db.SaveChanges();
			}
		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.Documento.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex =>CiudadPrincipalTercero).IsModified = true;
				entry.Property(ex =>TelefonoPrincipalTercero).IsModified = true;
				entry.Property(ex =>DireccionPrincipalTercero).IsModified = true;
				entry.Property(ex =>NombreComercialTercero).IsModified = true;
				entry.Property(ex =>DigitoVerificacionTercero).IsModified = true;
				entry.Property(ex =>NitTercero).IsModified = true;
				entry.Property(ex =>CodigoTercero).IsModified = true;
				entry.Property(ex =>Zona).IsModified = true;
				entry.Property(ex =>Guia).IsModified = true;
				entry.Property(ex =>Transportador).IsModified = true;
				entry.Property(ex =>CalcularIva).IsModified = true;
				entry.Property(ex =>Consecutivo).IsModified = true;
				entry.Property(ex =>TipoDocumentoID).IsModified = true;
				entry.Property(ex =>FechaDocumento).IsModified = true;
				entry.Property(ex =>FechaAnulacion).IsModified = true;
				entry.Property(ex =>FechaImpresion).IsModified = true;
				entry.Property(ex =>FechaVencimiento).IsModified = true;
				entry.Property(ex =>TerceroID).IsModified = true;
				entry.Property(ex =>EstadoDocumentoID).IsModified = true;
				entry.Property(ex =>Referencia).IsModified = true;
				entry.Property(ex =>DocumentoPadreID).IsModified = true;
				entry.Property(ex =>Observacion).IsModified = true;
				entry.Property(ex =>AgenteComercial).IsModified = true;
				entry.Property(ex =>Total).IsModified = true;
				entry.Property(ex =>TotalIva).IsModified = true;
				entry.Property(ex =>TotalDescuento).IsModified = true;
				entry.Property(ex =>TotalImpuesto1).IsModified = true;
				entry.Property(ex =>TotalImpuesto2).IsModified = true;
				entry.Property(ex =>TipoMonedaID).IsModified = true;
				entry.Property(ex =>CambioTipoMoneda).IsModified = true;
				entry.Property(ex =>TotalImpuestoConsumo).IsModified = true;
				entry.Property(ex =>SubTotal).IsModified = true;
				entry.Property(ex =>UsuarioID).IsModified = true;
				entry.Property(ex =>ImpresionDocumentoID).IsModified = true;
				entry.Property(ex =>Recargo).IsModified = true;
				entry.Property(ex =>ProntoPago).IsModified = true;
				entry.Property(ex =>Condicion).IsModified = true;
				entry.Property(ex =>TotalRetencion).IsModified = true;
				entry.Property(ex =>TotalRetencionIca).IsModified = true;
				entry.Property(ex =>TotalAbono).IsModified = true;
				entry.Property(ex =>TotalRecargo).IsModified = true;
				entry.Property(ex =>TotalExcedente).IsModified = true;
				entry.Property(ex =>TotalFlete).IsModified = true;
				entry.Property(ex =>Texto1).IsModified = true;
				entry.Property(ex =>Texto2).IsModified = true;
				entry.Property(ex =>Texto3).IsModified = true;
				entry.Property(ex =>Texto4).IsModified = true;
				entry.Property(ex =>Texto5).IsModified = true;
				entry.Property(ex =>Numero1).IsModified = true;
				entry.Property(ex =>Numero2).IsModified = true;
				entry.Property(ex =>Numero3).IsModified = true;
				entry.Property(ex =>Numero4).IsModified = true;
				entry.Property(ex =>Numero5).IsModified = true;
				entry.Property(ex =>TotalRetencionIva).IsModified = true;
				entry.Property(ex =>EmpleadoID).IsModified = true;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
				foreach (var detalle in Detalles) {
					detalle.DocumentoID = ID;
					detalle.ArticuloID = Articulo.FindByCodigo(detalle.Codigo).ID;
					if(detalle.ID == 0)
						detalle.Save();
					else
						detalle.Update();
				}
				db.SaveChanges();
			}
		}
		
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				db.Documento.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		
		public static Documento FindByID (long id)
		{
			Documento tmp = null;
			using(var db = new ElevenContext())
			{
				tmp = db.Documento.Where(a => a.ID == id).FirstOrDefault();
				tmp.Detalles = db.DetalleDocumento.Where(dd => dd.DocumentoID == tmp.ID).ToList();
				foreach (var detalle in tmp.Detalles) {
					detalle.Codigo = Articulo.Get(detalle.ArticuloID).Codigo;
				}
			}
			return tmp;
		}
		
		public static Documento Get (long id)
		{
			Documento tmp = null;
			using(var db = new ElevenContext())
			{
				tmp = db.Documento.Where(a => a.ID == id).FirstOrDefault();
				tmp.Detalles = db.DetalleDocumento.Where(dd => dd.DocumentoID == tmp.ID).ToList();
				foreach (var detalle in tmp.Detalles) {
					detalle.Codigo = Articulo.Get(detalle.ArticuloID).Codigo;
				}
			}
			return tmp;
		}
		
		public static Documento LoadByComprobante (Comprobante comp)
		{
			Documento tmp = null;
			using(var db = new ElevenContext())
			{
				tmp = db.Documento.FirstOrDefault();
				tmp.Detalles = db.DetalleDocumento.Where(dd => dd.DocumentoID == tmp.ID).ToList();
				foreach (var detalle in tmp.Detalles) {
					detalle.Codigo = Articulo.Get(detalle.ArticuloID).Codigo;
				}
			}
			return tmp;
		}
		
		public static BindingList<Documento> GetAll (int cantidad = 30)
		{
			BindingList<Documento> lista = new BindingList<Documento>();
			using(var db = new ElevenContext())
			{
				foreach( var tmp in db.Documento.Where( d1 => d1.Eliminado == false ).Take(cantidad).OrderByDescending(d => d.ID))
				{
					tmp.TotalPago = tmp.Total - (tmp.TotalRetencion + tmp.TotalRetencionIca + tmp.TotalRetencionIva);
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static BindingList<Documento> GetAll (TipoDocumento td)
		{
			BindingList<Documento> lista = new BindingList<Documento>();
			using(var db = new ElevenContext())
			{
				foreach( var tmp in db.Documento)
				{
					
					tmp.TotalPago = tmp.Total - (tmp.TotalRetencion + tmp.TotalRetencionIca + tmp.TotalRetencionIva);
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static BindingList<Documento> GetUltimosDocumentos (TipoDocumento td, int cantidad)
		{
			BindingList<Documento> lista = new BindingList<Documento>();
			using(var db = new ElevenContext())
			{
				foreach( var tmp in db.Documento)
				{
				
					tmp.TotalPago = tmp.Total - (tmp.TotalRetencion + tmp.TotalRetencionIca + tmp.TotalRetencionIva);
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static IList<Documento> FindUltimosTerceroDocumento(TipoDocumento td, int cantidad = 25)
		{
			List<Documento> lista = new List<Documento>();
			using(var db = new ElevenContext())
			{
				foreach( var tmp in db.Documento.Where( d1 => d1.Eliminado == false ).Take(cantidad).OrderByDescending(d => d.ID))
				{
					
					tmp.TotalPago = tmp.Total - (tmp.TotalRetencion + tmp.TotalRetencionIca + tmp.TotalRetencionIva);
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		
		public static IList<Documento> FindByLikeConsecutivo(TipoDocumento td, int consecutivo)
		{
			List<Documento> lista = new List<Documento>();
			using(var db = new ElevenContext())
			{
				foreach( var tmp in db.Documento)
				{
					
					tmp.TotalPago = tmp.Total - (tmp.TotalRetencion + tmp.TotalRetencionIca + tmp.TotalRetencionIva);
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static IList<Documento> FindByLikeTerceroTipoDocumento(TipoDocumento td, string tercero)
		{
			List<Documento> lista = new List<Documento>();
			using(var db = new ElevenContext())
			{
				foreach( var tmp in db.Documento)
				{
					
					tmp.TotalPago = tmp.Total - (tmp.TotalRetencion + tmp.TotalRetencionIca + tmp.TotalRetencionIva);
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static IList<Documento> FindByTerceroTipoDocumentoMaestroPagado(TipoDocumentoMaestro td, Tercero tercero)
		{
			List<Documento> lista = new List<Documento>();
			using(var db = new ElevenContext())
			{
				foreach( var tmp in db.Documento)
				{
					
					tmp.TotalPago = tmp.Total - (tmp.TotalRetencion + tmp.TotalRetencionIca + tmp.TotalRetencionIva);
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
