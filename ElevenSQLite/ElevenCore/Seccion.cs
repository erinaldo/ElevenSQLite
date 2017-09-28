/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:00 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Seccion.
	/// </summary>
	public class Seccion : Persistent
	{
		public Seccion()
		{
		}
		public  string Codigo { get; set; }
		public  long? FamiliaID { get; set; }
		public  string Descripcion { get; set; }
		
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{
				db.Seccion.Add(this);
				db.SaveChanges();
			}
 		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.Seccion.Attach(this);
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
				db.Seccion.Attach(this);
				var entry = db.Entry(this);
				Eliminado = true;
				FechaModificacion = DateTime.Now;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public static Seccion FindByID(long id) 
		{
			
			using(var db = new ElevenContext())
			{
				return db.Seccion.Where(s => s.ID == id).FirstOrDefault();
			}
			
		}
		public static Seccion Get(long id) 
		{
			
			using(var db = new ElevenContext())
			{
				return db.Seccion.Where(s => s.ID == id).FirstOrDefault();
			}
			
		}
		public static BindingList<Seccion> GetAll () 
		{
			BindingList<Seccion> lista = new BindingList<Seccion>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Seccion)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static BindingList<Seccion> FindByFamilia (Familia familia) 
		{
			BindingList<Seccion> lista = new BindingList<Seccion>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Seccion.Where(s => s.FamiliaID == familia.ID))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
