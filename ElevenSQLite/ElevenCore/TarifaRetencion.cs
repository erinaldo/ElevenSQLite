/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 7:43 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of TarifaRetencion.
	/// </summary>
	public class TarifaRetencion : Persistent
	{
		public TarifaRetencion()
		{
		}
		public float Tarifa { set; get;}
		public float Factor { set; get;}
		public string CuentaContable { set; get;}
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.TarifaRetencion.Add(this);
				db.SaveChanges();
			}
		}
		public static IList<TarifaRetencion> GetAll() 
		{
			List<TarifaRetencion> lista = new List<TarifaRetencion>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.TarifaRetencion)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
