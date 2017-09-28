/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 6:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Linq;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Banco.
	/// </summary>
	public class Banco : Persistent
	{
		public Banco()
		{
		}
		
		public string Descripcion { set; get;}
		
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.Banco.Add(this);
				db.SaveChanges();
			}
		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.Banco.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Descripcion).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				db.Banco.Attach(this);
				var entry = db.Entry(this);
				Eliminado = true;
				FechaModificacion = DateTime.Now;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public static Banco FindByID(long id)
 		{ 			
 			using(var db = new ElevenContext())
			{  
 				return db.Banco.Where(x => x.ID == id).FirstOrDefault();
			} 			
 		}
		public static BindingList<Banco> GetAll () 
		{
			BindingList<Banco> lista = new BindingList<Banco>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Banco)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
