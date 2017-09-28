/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:19 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Empresa.
	/// </summary>
	public class Empresa : Persistent
	{
		public Empresa()
		{
		}
		public  string Nit { get; set; }
		public  string RazonSocial { get; set; }
		public  string Direccion { get; set; }
		public  string TelefonoPrincipal { get; set; }
		public  string OtroTelefono { get; set; }
		public  string Fax { get; set; }
		public  string Movil { get; set; }
		[NotMapped]
		public  long? PaisID { get; set; }
		[NotMapped]
		public  long? EstadoID { get; set; }
		public  long? CiudadID { get; set; }
		public  string Email { get; set; }
		public  string PaginaWeb { get; set; }
		public  string Frase { get; set; }
		public  string RutaLogo { get; set; }
		public  string RutaFondoPapel { get; set; }
		public  string CodigoCIIU { get; set; }
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{				
				db.Empresa.Add(this);
				db.SaveChanges();					
			}
 		}
		public void Update()
 		{
 			using (var db = new ElevenContext())
			{				
				db.Empresa.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex => Nit).IsModified = true;
				entry.Property(ex => RazonSocial).IsModified = true;
				entry.Property(ex => Direccion).IsModified = true;
				entry.Property(ex => TelefonoPrincipal).IsModified = true;
				entry.Property(ex => OtroTelefono).IsModified = true;
				entry.Property(ex => Fax).IsModified = true;
				entry.Property(ex => Movil).IsModified = true;		
				//entry.Property(ex => EstadoID).IsModified = true;
				entry.Property(ex => CiudadID).IsModified = true;
				entry.Property(ex => Email).IsModified = true;
				entry.Property(ex => PaginaWeb).IsModified = true;
				entry.Property(ex => Frase).IsModified = true;
				entry.Property(ex => RutaLogo).IsModified = true;
				entry.Property(ex => RutaFondoPapel).IsModified = true;
				entry.Property(ex => CodigoCIIU).IsModified = true;
				entry.Property(ex => ex.FechaModificacion).IsModified = true;
				db.SaveChanges();
			}
 		}
		public static Empresa Get () 
		{			
			using(var db = new ElevenContext())
			{  
				return db.Empresa.First();
			}
		}
		public static bool ExisteEmpresa() 
		{			
			using(var db = new ElevenContext())
			{  
				return db.Empresa.Count() > 0;
			}
		}
		public static BindingList<Empresa> GetAll ()
		{
			BindingList<Empresa> lista = new BindingList<Empresa>();
			using(var db = new ElevenContext())
			{  
				foreach( Empresa tmp in db.Empresa)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
