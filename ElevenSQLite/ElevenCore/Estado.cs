/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.ComponentModel;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Estado.
	/// </summary>
	public class Estado : Persistent
	{
		public Estado()
		{
		}
		public string Codigo { get; set; }		
		public string Descripcion { get; set; }		
		public long PaisID { get; set; }
				
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.Estado.Add(this);
				db.SaveChanges();
			}
		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.Estado.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Descripcion).IsModified = true;
				entry.Property(ex => ex.Codigo).IsModified = true;
				entry.Property(ex => ex.PaisID).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				db.Estado.Attach(this);
				var entry = db.Entry(this);
				Eliminado = true;
				FechaModificacion = DateTime.Now;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		
		public static Estado FindByID(long id)
 		{
 			Estado tmp = null;
 			using(var db = new ElevenContext())
			{  
 				tmp = db.Estado.Where(x => x.ID == id).FirstOrDefault();
 				db.Dispose();
			}
 			return tmp;
 		}
		public static Estado FindByCodigo(string codigo)
 		{
 			using(var db = new ElevenContext())
			{  
 				return db.Estado.Where(x => x.Codigo == codigo).FirstOrDefault();
			}
 		}
		
		public static Estado Get(long id)
 		{
 			Estado tmp = null;
 			using(var db = new ElevenContext())
			{  
 				tmp = db.Estado.Where(x => x.ID == id).FirstOrDefault();
 				db.Dispose();
			}
 			return tmp;
 		}
		public static BindingList<Estado> GetAll() 
		{
			BindingList<Estado> lista = new BindingList<Estado>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Estado)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static BindingList<Estado> GetAllByPais (Pais pais) 
		{
			BindingList<Estado> lista = new BindingList<Estado>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Estado.Where(e => e.PaisID == pais.ID))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
