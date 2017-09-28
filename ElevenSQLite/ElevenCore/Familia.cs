/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 7:35 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.ComponentModel;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Familia.
	/// </summary>
	public class Familia : Persistent
	{
		public Familia()
		{
		}
		public string Codigo { set; get;}
		public string Descripcion { set; get;}
		
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.Familia.Add(this);
				db.SaveChanges();
			}
		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.Familia.Attach(this);
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
				db.Familia.Attach(this);
				var entry = db.Entry(this);
				Eliminado = true;
				FechaModificacion = DateTime.Now;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		
		public static Familia FindByID(long id)
		{
			Familia tmp = null;
 			using(var db = new ElevenContext())
			{  
 				tmp = db.Familia.Where(x => x.ID == id).FirstOrDefault();
 				db.Dispose();
			}
 			return tmp;
		}
		
		public static BindingList<Familia> GetAll () 
		{
			BindingList<Familia> lista = new BindingList<Familia>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Familia)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
