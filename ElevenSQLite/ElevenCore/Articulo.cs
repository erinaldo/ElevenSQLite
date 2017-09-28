/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 7:53 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Articulo.
	/// </summary>
	public class Articulo : Persistent
	{
		public Articulo()
		{
		}
		public static string IVA = "IVA";
		public static string EXCENTO = "EXCENTO";
		public static string EXCLUIDO = "EXCLUIDO";
		
		public  string Codigo { get; set; }
		public  string Descripcion { get; set; }
		public  bool Servicio  { get; set; }
		public  string CodigoBarras { get; set; }
		public  string CodigoAlternativo { get; set; }
		public  string CodigoPLU { get; set; }
		public  string DescripcionCorta { get; set; }
		public  bool Estado { get; set; }
		public  string Impuesto { get; set; }
		public  long? SeccionID { get; set; }
		public  long? UnidadComercialID { get; set; }
		public  decimal Costo { get; set; }
		public  decimal ValorNeto { get; set; }
		public  decimal ValorNeto1 { get; set; }
		public  decimal ValorNeto2 { get; set; }
		public  decimal ValorNeto3 { get; set; }
		public  float Iva { get; set; }
		public  decimal PrecioVenta { get; set; }
		public  decimal PrecioVenta1 { get; set; }
		public  decimal PrecioVenta2 { get; set; }
		public  decimal PrecioVenta3 { get; set; }
		public  decimal Utilidad { get; set; }
		public  decimal Utilidad1 { get; set; }		
		public  decimal Utilidad2 { get; set; }		
		public  decimal Utilidad3 { get; set; }
		public  int StockMinimo { get; set; }		
		public  int StockMaximo { get; set; }		
		public  decimal StockActual { get; set; }
		public  decimal StockDisponible { get; set; }
		public  int UnidadesArticulo { get; set; }
		public  string PartidaArancelaria { get; set; }		
		public  decimal CostoMinimo { get; set; }
		public  decimal CostoMaximo { get; set; }		
		public  decimal CostoPromedio { get; set; }
		public  decimal UltimoCosto { get; set; }	
		public  bool RedondeoSistema { get; set; }
		public  bool RedondeoInferior { get; set; }
		public  bool RedondeoSuperior { get; set; }		
		public  DateTime? FechaUltimaCompra { get; set; }
		public  DateTime? FechaUltimaVenta { get; set; }
		public  DateTime? FechaUltimaTransaccion  { get; set; }		
		public  string RutaImagen  { get; set; }
		public  bool Catalogo { get; set; }
		public  bool Impresion { get; set; }
		public  bool Compuesto { get; set; }
		public  float MaximoDescuento { get; set; }
		public  string CodigoKit { get; set; }
		public  float Peso { get; set; }
		public  float Volumen { get; set; }
		public  float Ancho { get; set; }
		public  float Alto { get; set; }
		public  float Profundidad { get; set; }
		public  long? UsuarioID { get; set; }		
		public  decimal ImpuestoConsumo { get; set; }		
		public  string Observacion { get; set; }
		
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{
				db.Articulo.Add(this);
				db.SaveChanges();
			}
 		}
		
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.Articulo.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Codigo).IsModified = true;
				entry.Property(ex => ex.Descripcion).IsModified = true;
				entry.Property(ex => ex.Servicio ).IsModified = true;
				entry.Property(ex => ex.CodigoBarras).IsModified = true;
				entry.Property(ex => ex.CodigoAlternativo).IsModified = true;
				entry.Property(ex => ex.CodigoPLU).IsModified = true;
				entry.Property(ex => ex.DescripcionCorta).IsModified = true;
				entry.Property(ex => ex.Estado).IsModified = true;
				entry.Property(ex => ex.Impuesto).IsModified = true;
				entry.Property(ex => ex.SeccionID).IsModified = true;
				entry.Property(ex => ex.UnidadComercialID).IsModified = true;
				entry.Property(ex => ex.Costo).IsModified = true;
				entry.Property(ex => ex.ValorNeto).IsModified = true;
				entry.Property(ex => ex.ValorNeto1).IsModified = true;
				entry.Property(ex => ex.ValorNeto2).IsModified = true;
				entry.Property(ex => ex.ValorNeto3).IsModified = true;
				entry.Property(ex => ex.Iva).IsModified = true;
				entry.Property(ex => ex.PrecioVenta).IsModified = true;
				entry.Property(ex => ex.PrecioVenta1).IsModified = true;
				entry.Property(ex => ex.PrecioVenta2).IsModified = true;
				entry.Property(ex => ex.PrecioVenta3).IsModified = true;
				entry.Property(ex => ex.Utilidad).IsModified = true;
				entry.Property(ex => ex.Utilidad1).IsModified = true;		
				entry.Property(ex => ex.Utilidad2).IsModified = true;		
				entry.Property(ex => ex.Utilidad3).IsModified = true;
				entry.Property(ex => ex.StockMinimo).IsModified = true;		
				entry.Property(ex => ex.StockMaximo).IsModified = true;		
				entry.Property(ex => ex.StockActual).IsModified = true;
				entry.Property(ex => ex.StockDisponible).IsModified = true;
				entry.Property(ex => ex.UnidadesArticulo).IsModified = true;
				entry.Property(ex => ex.PartidaArancelaria).IsModified = true;		
				entry.Property(ex => ex.CostoMinimo).IsModified = true;
				entry.Property(ex => ex.CostoMaximo).IsModified = true;		
				entry.Property(ex => ex.CostoPromedio).IsModified = true;
				entry.Property(ex => ex.UltimoCosto).IsModified = true;	
				entry.Property(ex => ex.RedondeoSistema).IsModified = true;
				entry.Property(ex => ex.RedondeoInferior).IsModified = true;
				entry.Property(ex => ex.RedondeoSuperior).IsModified = true;		
				entry.Property(ex => ex.FechaUltimaCompra).IsModified = true;
				entry.Property(ex => ex.FechaUltimaVenta).IsModified = true;
				entry.Property(ex => ex.FechaUltimaTransaccion ).IsModified = true;		
				entry.Property(ex => ex.RutaImagen ).IsModified = true;
				entry.Property(ex => ex.Catalogo).IsModified = true;
				entry.Property(ex => ex.Impresion).IsModified = true;
				entry.Property(ex => ex.Compuesto).IsModified = true;
				entry.Property(ex => ex.MaximoDescuento).IsModified = true;
				entry.Property(ex => ex.CodigoKit).IsModified = true;
				entry.Property(ex => ex.Peso).IsModified = true;
				entry.Property(ex => ex.Volumen).IsModified = true;
				entry.Property(ex => ex.Ancho).IsModified = true;
				entry.Property(ex => ex.Alto).IsModified = true;
				entry.Property(ex => ex.Profundidad).IsModified = true;
				entry.Property(ex => ex.UsuarioID).IsModified = true;		
				entry.Property(ex => ex.ImpuestoConsumo).IsModified = true;		
				entry.Property(ex => ex.Observacion).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
				db.SaveChanges();
			}
		}
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				db.Articulo.Attach(this);
				var entry = db.Entry(this);				
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;				                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
				db.SaveChanges();
			}
		}
		
		public static IList<Articulo> GetAll (int cantidad = 30) 
		{
			List<Articulo> lista = new List<Articulo>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Articulo.Take(cantidad))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		
		public static Articulo Get (long id) 
		{
			using(var db = new ElevenContext())
			{  
				return db.Articulo.Where(a => a.ID.Equals(id)).FirstOrDefault();
			}
		}
		
		public static Articulo FindByID (long id) 
		{
			using(var db = new ElevenContext())
			{  
				return db.Articulo.Where(a => a.ID.Equals(id)).FirstOrDefault();
			}
		}
		
		public static Articulo FindByCodigo (string codigo) 
		{
			List<Articulo> lista = new List<Articulo>();
			using(var db = new ElevenContext())
			{  
				return db.Articulo.Where(a => a.Codigo.Equals(codigo)).FirstOrDefault();
			}
		}
		
		public static List<Articulo> FindByLikeCodigo (string codigo) 
		{
			List<Articulo> lista = new List<Articulo>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Articulo.Where(a => a.Codigo.StartsWith(codigo)))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static List<Articulo> FindByLikeCodigoPLU (string codigoPLU) 
		{
			List<Articulo> lista = new List<Articulo>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Articulo.Where(a => a.CodigoPLU.StartsWith(codigoPLU)))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		
		public static List<Articulo> FindByLikeDescripcion (string descripcion) 
		{
			List<Articulo> lista = new List<Articulo>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Articulo.Where(a => a.Descripcion.StartsWith(descripcion)))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
