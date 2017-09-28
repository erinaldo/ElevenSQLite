/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:30 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.ComponentModel;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Pais.
	/// </summary>
	public class Pais : Persistent
	{
		public Pais()
		{
		}
		public string Codigo { get; set; }
		public string Descripcion { get; set; }
		
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.Pais.Add(this);
				db.SaveChanges();
			}
		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.Pais.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Codigo).IsModified = true;
				entry.Property(ex => ex.Descripcion).IsModified = true;				
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				db.Pais.Attach(this);
				var entry = db.Entry(this);
				Eliminado = true;
				FechaModificacion = DateTime.Now;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public static Pais FindByID(long id)
 		{ 			
 			using(var db = new ElevenContext())
			{  
 				return db.Pais.Where(x => x.ID == id).FirstOrDefault();
			} 			
 		}
		public static Pais Get(long id)
 		{
 			Pais tmp = null;
 			using(var db = new ElevenContext())
			{  
 				tmp = db.Pais.Where(x => x.ID == id).FirstOrDefault();
 				db.Dispose();
			}
 			return tmp;
 		}
		public static BindingList<Pais> GetAll () 
		{
			BindingList<Pais> lista = new BindingList<Pais>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Pais)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
