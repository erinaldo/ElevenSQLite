/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:23 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.ComponentModel;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of ImpresionDocumento.
	/// </summary>
	public class ImpresionDocumento : Persistent
	{
		public ImpresionDocumento()
		{
		}
		public static string IMPRESION_POS = "POS";
		public static string IMPRESION_NORMAL = "NORMAL";
		public string Descripcion { get; set; }
		public string Clase { get; set; }
		public string Metodo { get; set; }
		public string TipoImpresion { get; set; }
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{				
				db.ImpresionDocumento.Add(this);
				db.SaveChanges();					
			}
 		}
		public static ImpresionDocumento FindByDescripcion(string descripcionImpresionDocumento)
 		{
 			using(var db = new ElevenContext())
			{  
 				return db.ImpresionDocumento.Where(x => x.Descripcion.Equals(descripcionImpresionDocumento)).FirstOrDefault();
			}
 		}
		public static BindingList<ImpresionDocumento> GetAll() 
		{
			BindingList<ImpresionDocumento> lista = new BindingList<ImpresionDocumento>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.ImpresionDocumento)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
