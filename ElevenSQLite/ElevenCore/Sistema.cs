/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:39 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Sistema.
	/// </summary>
	public class Sistema : Persistent
	{
		public Sistema()
		{
		}
		public float VersionDB { get; set; }
		public string Serial { get; set; }
		public string Empresa { get; set; }
		public long GlobalTime { get; set; }
		public bool ClaveAcceso { get; set; }
		public string VolumenSerial { get; set; }
		public bool Red { get; set; }
		public string Email { get; set; }
		public bool ActualizarSoftware { get; set; }
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{				
				db.Sistema.Add(this);
				db.SaveChanges();
			}
 		}
		public static Sistema Get () 
		{			
			using(var db = new ElevenContext())
			{  
				return db.Sistema.First();
			}
		}
	}
}
