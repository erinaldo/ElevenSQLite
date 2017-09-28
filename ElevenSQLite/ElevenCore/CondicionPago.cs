/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:01 p. m.
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
	/// Description of CondicionPago.
	/// </summary>
	public class CondicionPago : Persistent
	{
		public CondicionPago()
		{
		}
		public  string Descripcion { get; set; }
		public  int Dias { get; set; }
		public  float Recargo { get; set; }
		public  float ProntoPago { get; set; }
		
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{
				db.CondicionPago.Add(this);
				db.SaveChanges();					
			}
 		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.CondicionPago.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Descripcion).IsModified = true;
				entry.Property(ex => ex.Dias).IsModified = true;
				entry.Property(ex => ex.Recargo).IsModified = true;
				entry.Property(ex => ex.ProntoPago).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				db.CondicionPago.Attach(this);
				var entry = db.Entry(this);
				Eliminado = true;
				FechaModificacion = DateTime.Now;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public static CondicionPago FindByID (long id) 
		{
			using(var db = new ElevenContext())
			{  
				return db.CondicionPago.Where(a => a.ID == id).FirstOrDefault();
			}
		}
		
		public static CondicionPago Get(long id)
 		{ 			
 			using(var db = new ElevenContext())
			{  
 				return db.CondicionPago.Where(x => x.ID == id).FirstOrDefault();
			} 			
 		}
		public static BindingList<CondicionPago> GetAll () 
		{
			BindingList<CondicionPago> lista = new BindingList<CondicionPago>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.CondicionPago.Where(cp => !cp.Eliminado))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
