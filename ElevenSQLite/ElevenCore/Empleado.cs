/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:17 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado : Persistent
	{
		public Empleado()
		{
		}
		public  string Codigo { get; set; }
		public  string NombreCompleto { get; set; }
		public  string PrimerApellido { get; set; }
		public  string SegundoApellido { get; set; }
		public  string PrimerNombre { get; set; }
		public  string OtroNombre { get; set; }
		public  string DireccionPrincipal { get; set; }
		public  string TelefonoPrincipal { get; set; }
		public  string TelefonoMovilPrincipal { get; set; }
		public  string Email { get; set; }
		public  string Observacion { get; set; }
		
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{
				db.Empleado.Add(this);
				db.SaveChanges();					
			}
 		}
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.Empleado.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Codigo).IsModified = true;
				entry.Property(ex => ex.NombreCompleto).IsModified = true;
				entry.Property(ex => ex.PrimerApellido).IsModified = true;
				entry.Property(ex => ex.SegundoApellido).IsModified = true;
				entry.Property(ex => ex.PrimerNombre).IsModified = true;
				entry.Property(ex => ex.OtroNombre).IsModified = true;
				entry.Property(ex => ex.DireccionPrincipal).IsModified = true;
				entry.Property(ex => ex.TelefonoMovilPrincipal).IsModified = true;
				entry.Property(ex => ex.Email).IsModified = true;
				entry.Property(ex => ex.Observacion).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
		}
		
		public void Delete()
		{
			using (var db = new ElevenContext())
			{
				Eliminado = true;
				db.Empleado.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => ex.Eliminado).IsModified = true;
				db.SaveChanges();
			}
		}
		public static Empleado FindByID (long id) 
		{
			using(var db = new ElevenContext())
			{  
				return db.Empleado.Where(a => a.ID == id).FirstOrDefault();
			}
		}
		public static BindingList<Empleado> GetAll () 
		{
			BindingList<Empleado> lista = new BindingList<Empleado>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Empleado.Where(e => !e.Eliminado))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
