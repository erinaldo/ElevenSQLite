/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:31 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Permiso.
	/// </summary>
	public class Permiso : Persistent
	{
		public Permiso()
		{
		}
		public long? UsuarioID { get; set; }
		public bool Maestros { get; set; }
		public bool Articulos { get; set; }
		public bool Terceros { get; set; }
		public bool Documentos { get; set; }
		public bool Comprobantes { get; set; }
		public bool Informes { get; set; }
		public bool Preferencias { get; set; }
		public bool Empresa { get; set; }
		public bool Sistema { get; set; }
		public bool TiposDocumento { get; set; }
		public bool Mensajes { get; set; }
		public bool Imagenes { get; set; }
		public bool Mantenimiento { get; set; }
		public bool Usuarios { get; set; }
		public bool TerminalPV { get; set; }
		public bool NuevoTicket { get; set; }
		public bool EliminarDetalleTicket { get; set; }
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{
				db.Permiso.Add(this);
				db.SaveChanges();
			}
 		}
		public static IList<Permiso> GetAll() 
		{
			List<Permiso> lista = new List<Permiso>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Permiso)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
