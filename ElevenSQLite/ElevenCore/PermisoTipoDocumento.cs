/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:34 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of PermisoTipoDocumento.
	/// </summary>
	public class PermisoTipoDocumento : Persistent
	{
		public PermisoTipoDocumento()
		{
		}
		public long? UsuarioID { get; set; }
		public long? TipoDocumentoID { get; set; }
		public bool Nuevo { get; set; }
		public bool Modificar { get; set; }
		public bool Eliminar { get; set; }
		public bool Imprimir { get; set; }
		public bool Anular { get; set; }
		
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{
				db.PermisoTipoDocumento.Add(this);
				db.SaveChanges();
			}
 		}
		public void Delete(){}
		
		public static IList<PermisoTipoDocumento> FindByTipoDocumento(TipoDocumento td) 
		{
			List<PermisoTipoDocumento> lista = new List<PermisoTipoDocumento>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.PermisoTipoDocumento.Where(ptd => ptd.TipoDocumentoID == td.ID))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
