/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:00 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.ComponentModel;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Ciudad.
	/// </summary>
	public class Ciudad : Persistent
	{
		public Ciudad()
		{
		}
		
		public string Codigo { get; set; }
		public string Descripcion { get; set; }
		public long? EstadoID { get; set; }
		
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.Ciudad.Add(this);
				db.SaveChanges();
			}
		}
		
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.Ciudad.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Codigo).IsModified = true;
				entry.Property(ex => ex.Descripcion).IsModified = true;
				entry.Property(ex => ex.EstadoID).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				db.Ciudad.Attach(this);
				var entry = db.Entry(this);
				Eliminado = true;
				FechaModificacion = DateTime.Now;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		
		public static Ciudad FindByID(long id)
 		{ 			
 			using(var db = new ElevenContext())
			{  
 				return db.Ciudad.Where(x => x.ID == id).FirstOrDefault();
			} 			
 		}
		
		public static Ciudad Get(long id)
 		{
 			Ciudad tmp = null;
 			using(var db = new ElevenContext())
			{  
 				tmp = db.Ciudad.Where(x => x.ID == id).FirstOrDefault();
 				db.Dispose();
			}
 			return tmp;
 		}
		
		public static BindingList<Ciudad> GetAllByEstado (Estado estado) 
		{
			BindingList<Ciudad> lista = new BindingList<Ciudad>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Ciudad.Where(c => c.EstadoID == estado.ID))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		
		public static BindingList<Ciudad> FindByLikeNombreCiudad (string nombreCiudad) 
		{
			BindingList<Ciudad> lista = new BindingList<Ciudad>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Ciudad.Where(c => c.Descripcion.Contains(nombreCiudad)))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		
		public static BindingList<Ciudad> GetAll () 
		{
			BindingList<Ciudad> lista = new BindingList<Ciudad>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Ciudad)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
