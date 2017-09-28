/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:41 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Tercero.
	/// </summary>
	public class Tercero : Persistent
	{
		public Tercero()
		{
		}
		public static string REGIMEN_COMUN = "RC";
		public static string REGIMEN_SIMPLIFICADO = "RS";
		
		public string Codigo { get; set; }
		public int Nit { get; set; }
		public int DigitoVerificacion { get; set; }
		public string NombreComercial { get; set; }
		public string RazonSocial { get; set; }
		public string ContactoPrincipal { get; set; }
		public string PrimerApellido { get; set; }
		public string SegundoApellido { get; set; }
		public string PrimerNombre { get; set; }
		public string OtroNombre { get; set; }
		public string DireccionPrincipal { get; set; }
		public string TelefonoPrincipal { get; set; }
		public string OtroTelefonoPrincipal { get; set; }
		public string TelefonoMovilPrincipal { get; set; }
		public string DireccionSecundaria { get; set; }
		public string TelefonoSecundario { get; set; }
		public string OtroTelefonoSecundario { get; set; }
		public string TelefonoMovilSecundario { get; set; }
		public string Fax { get; set; }
		public string Email { get; set; }
		public string PaginaWeb { get; set; }
		public string ReferenciaComercial { get; set; }
		public string TelefonoReferenciaComercial { get; set; }
		public string OtraReferenciaComercial { get; set; }
		public string TelefonoOtraReferenciaComercial { get; set; }
		public bool ExcentoIva { get; set; }
		public string TipoRegimen { get; set; }
		public bool ClienteNacional { get; set; }
		public bool ClienteExtranjero { get; set; }
		public bool ProveedorNacional { get; set; }
		public bool ProveedorExtranjero { get; set; }
		public bool Interno { get; set; }
		public bool OtroTipoTercero { get; set; }
		public long CiudadID { get; set; }
		public bool Inhabilitar { get; set; }
		public int Calificacion { get; set; }
		public int TipoPrecioVenta { get; set; }
		public long UsuarioID { get; set; }
		public bool GranContribuyente { get; set; }
		public string Observacion { get; set; }
		
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{
				db.Tercero.Add(this);
				db.SaveChanges();
			}
 		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.Tercero.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => Codigo).IsModified = true;
				entry.Property(ex => Nit).IsModified = true;
				entry.Property(ex => DigitoVerificacion).IsModified = true;
				entry.Property(ex => NombreComercial).IsModified = true;
				entry.Property(ex => RazonSocial).IsModified = true;
				entry.Property(ex => ContactoPrincipal).IsModified = true;
				entry.Property(ex => PrimerApellido).IsModified = true;
				entry.Property(ex => SegundoApellido).IsModified = true;
				entry.Property(ex => PrimerNombre).IsModified = true;
				entry.Property(ex => OtroNombre).IsModified = true;
				entry.Property(ex => DireccionPrincipal).IsModified = true;
				entry.Property(ex => TelefonoPrincipal).IsModified = true;
				entry.Property(ex => OtroTelefonoPrincipal).IsModified = true;
				entry.Property(ex => TelefonoMovilPrincipal).IsModified = true;
				entry.Property(ex => DireccionSecundaria).IsModified = true;
				entry.Property(ex => TelefonoSecundario).IsModified = true;
				entry.Property(ex => OtroTelefonoSecundario).IsModified = true;
				entry.Property(ex => TelefonoMovilSecundario).IsModified = true;
				entry.Property(ex => Fax).IsModified = true;
				entry.Property(ex => Email).IsModified = true;
				entry.Property(ex => PaginaWeb).IsModified = true;
				entry.Property(ex => ReferenciaComercial).IsModified = true;
				entry.Property(ex => TelefonoReferenciaComercial).IsModified = true;
				entry.Property(ex => OtraReferenciaComercial).IsModified = true;
				entry.Property(ex => TelefonoOtraReferenciaComercial).IsModified = true;
				entry.Property(ex => ExcentoIva).IsModified = true;
				entry.Property(ex => TipoRegimen).IsModified = true;
				entry.Property(ex => ClienteNacional).IsModified = true;
				entry.Property(ex => ClienteExtranjero).IsModified = true;
				entry.Property(ex => ProveedorNacional).IsModified = true;
				entry.Property(ex => ProveedorExtranjero).IsModified = true;
				entry.Property(ex => Interno).IsModified = true;
				entry.Property(ex => OtroTipoTercero).IsModified = true;
				entry.Property(ex => CiudadID).IsModified = true;
				entry.Property(ex => Inhabilitar).IsModified = true;
				entry.Property(ex => Calificacion).IsModified = true;
				entry.Property(ex => TipoPrecioVenta).IsModified = true;
				entry.Property(ex => UsuarioID).IsModified = true;
				entry.Property(ex => GranContribuyente).IsModified = true;
				entry.Property(ex => Observacion).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
				db.SaveChanges();
			}
		}
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				db.Tercero.Attach(this);
				var entry = db.Entry(this);				
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;				                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
				db.SaveChanges();
			}
		}
		public static Tercero Get (long id) 
		{
			using(var db = new ElevenContext())
			{  
				return db.Tercero.Where(a => a.ID == id).FirstOrDefault();
			}
		}
		public static Tercero FindByID (long id) 
		{
			using(var db = new ElevenContext())
			{  
				return db.Tercero.Where(a => a.ID.Equals(id)).FirstOrDefault();
			}
		}
		public static Tercero FindByCodigo (string codigo) 
		{
			using(var db = new ElevenContext())
			{  
				return db.Tercero.Where(a => a.Codigo.Equals(codigo)).FirstOrDefault();
			}
		}		
		public static IList<Tercero> GetAll(int cantidad = 30) 
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
		public static IList<Tercero> FindByLikeCodigo(string codigo) 
		{
			List<Tercero> lista = new List<Tercero>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Tercero.Where(t => t.Codigo.StartsWith(codigo)))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		
		public static IList<Tercero> GetUltimos(int cantidad = 30) 
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
		public static IList<Tercero> GetUltimos(TipoDocumento td, int cantidad = 30) 
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
		public static IList<Tercero> FindByLikeNombreComercial(string nombreComercial) 
		{
			List<Tercero> lista = new List<Tercero>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Tercero.Where(t => t.NombreComercial.StartsWith(nombreComercial)))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static IList<Tercero> FindByLikeNit(string nit) 
		{
			List<Tercero> lista = new List<Tercero>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Tercero.Where(t => t.Nit.ToString().StartsWith(nit)))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
