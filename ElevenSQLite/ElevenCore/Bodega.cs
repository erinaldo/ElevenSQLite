/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 7:28 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Bodega.
	/// </summary>
	public class Bodega : Persistent
	{
		public Bodega()
		{
		}
		public string Descripcion { set; get;}
		
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.Bodega.Add(this);
				db.SaveChanges();
			}
		}
	}
}
