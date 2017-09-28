/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:02 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Comprobante.
	/// </summary>
	public class Comprobante : Persistent
	{
		public Comprobante()
		{
			Detalles = new List<DetalleComprobante>();
		}
		public static string EFECTIVO = "Efectivo";
		public static string CHEQUE = "Cheque";
		
		public  int Consecutivo { get; set; }
		public  long TipoDocumentoID { get; set; }
		public  long UsuarioID { get; set; }
		public  DateTime? FechaComprobante { get; set; }
		public  DateTime? FechaAnulacion { get; set; }
		public  long TerceroID { get; set; }
		public  string FormaPago { get; set; }
		public  long BancoID { get; set; }
		public  string NumeroCheque { get; set; }
		public  string Observacion { get; set; }
		public  decimal TotalDescuento { get; set; }
		public  decimal TotalRetencion { get; set; }
		public  decimal Total { get; set; }
		[NotMapped]
		public  IList<DetalleComprobante> Detalles { get; set; }
		public  long ImpresionDocumentoID { get; set; }
		public  string Sucursal { get; set; }
		public  string Elaborado { get; set; }
		public  string Aprobado { get; set; }
		public  string Revisado { get; set; }
		public  string Contabilizado { get; set; }
		public  long EstadoDocumentoID { get; set; }
		
		
		public void Save(){}
		public void Update(){}
		public void Delete(){}
		public void Load(){}
		
		public static Comprobante Get (long id) 
		{
			using(var db = new ElevenContext())
			{  
				return db.Comprobante.Where(a => a.ID == id).FirstOrDefault();
			}
		}
		public static IList<Comprobante> FindByLikeTipoDocumentoTercero(TipoDocumento tdo, string terceroTexto) 
		{
			List<Comprobante> lista = new List<Comprobante>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Comprobante)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		
		public static IList<Comprobante> GetAll() 
		{
			List<Comprobante> lista = new List<Comprobante>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Comprobante.OrderBy(c => c.ID))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static IList<Comprobante> GetAll(TipoDocumento tipoDocumento) 
		{
			List<Comprobante> lista = new List<Comprobante>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Comprobante.Where(c => c.TipoDocumentoID == tipoDocumento.ID))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		
		public static IList<Comprobante> GetUltimos(TipoDocumento tipoDocumento, int cantidad = 30) 
		{
			List<Comprobante> lista = new List<Comprobante>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Comprobante.Take(cantidad))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static IList<Tercero> FindUltimosTerceroComprobante(TipoDocumento td,int cantidad = 25) 
		{
			List<Tercero> lista = new List<Tercero>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Tercero.Take(cantidad))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
