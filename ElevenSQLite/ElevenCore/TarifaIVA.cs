/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 7:49 p. m.
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
	/// Description of TarifaIVA.
	/// </summary>
	public class TarifaIVA : Persistent
	{
		public TarifaIVA()
		{
		}
		public float Tarifa { set; get;}
		public float Factor { set; get;}
		public string CuentaContable { set; get;}
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.TarifaIVA.Add(this);
				db.SaveChanges();
			}
		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.TarifaIVA.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Factor).IsModified = true;
				entry.Property(ex => ex.Tarifa).IsModified = true;
				entry.Property(ex => ex.CuentaContable).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				db.TarifaIVA.Attach(this);
				var entry = db.Entry(this);
				Eliminado = true;
				FechaModificacion = DateTime.Now;
				entry.Property(ex => ex.Eliminado).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		public static TarifaIVA FindByID(long id)
		{
			TarifaIVA tmp = null;
 			using(var db = new ElevenContext())
			{  
 				tmp = db.TarifaIVA.Where(x => x.ID == id).FirstOrDefault();
 				db.Dispose();
			}
 			return tmp;
		}
		public static BindingList<TarifaIVA> GetAll () 
		{
			BindingList<TarifaIVA> lista = new BindingList<TarifaIVA>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.TarifaIVA)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
