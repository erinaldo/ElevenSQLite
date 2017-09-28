/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 7:39 p. m.
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
	/// Description of UnidadComercial.
	/// </summary>
	public class UnidadComercial : Persistent
	{
		public UnidadComercial()
		{
		}
		public string Codigo { set; get;}
		public string Descripcion { set; get;}
		
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.UnidadComercial.Add(this);
				db.SaveChanges();
			}
		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.UnidadComercial.Attach(this);
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
				db.UnidadComercial.Attach(this);
				var entry = db.Entry(this);
				Eliminado = true;
				FechaModificacion = DateTime.Now;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		
		public static UnidadComercial FindByID(long id)
		{
			UnidadComercial tmp = null;
 			using(var db = new ElevenContext())
			{  
 				tmp = db.UnidadComercial.Where(x => x.ID == id).FirstOrDefault();
 				db.Dispose();
			}
 			return tmp;
		}
		
		public static BindingList<UnidadComercial> GetAll () 
		{
			BindingList<UnidadComercial> lista = new BindingList<UnidadComercial>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.UnidadComercial)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
