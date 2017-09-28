/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 7:40 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of TipoMoneda.
	/// </summary>
	public class TipoMoneda : Persistent
	{
		public TipoMoneda()
		{
		}
		public static string PESO = "PESO";
		public static string DOLAR = "DOLAR";
		public static string EURO = "EURO";
		public static string PESOS = "PESOS";
		public static string DOLARES = "DOLARES";
		public static string EUROS = "EUROS";
		
		public string Codigo { set; get;}
		public string Descripcion { set; get;}
		
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.TipoMoneda.Add(this);
				db.SaveChanges();
			}
		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.TipoMoneda.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Descripcion).IsModified = true;
				entry.Property(ex => ex.Codigo).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				db.TipoMoneda.Attach(this);
				var entry = db.Entry(this);
				Eliminado = true;
				FechaModificacion = DateTime.Now;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		
		public static TipoMoneda FindByID(long id)
 		{ 			
 			using(var db = new ElevenContext())
			{  
 				return db.TipoMoneda.Where(x => x.ID == id).FirstOrDefault();
			} 			
 		}
		
		public static TipoMoneda Get(long id)
 		{ 			
 			using(var db = new ElevenContext())
			{  
 				return db.TipoMoneda.Where(x => x.ID == id).FirstOrDefault();
			} 			
 		}
		public static BindingList<TipoMoneda> GetAll () 
		{
			BindingList<TipoMoneda> lista = new BindingList<TipoMoneda>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.TipoMoneda)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
