/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:22 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of EstadoDocumento.
	/// </summary>
	public class EstadoDocumento : Persistent
	{
		public EstadoDocumento()
		{
		}
		public static string ACTIVADO = "ACTIVADO";
		public static string DESACTIVADO = "DESACTIVADO";
		public static string PAGADO = "PAGADO";
		public static string PAGADO_PARCIALMENTE = "PAGADO PARCIALMENTE";
		public static string NO_PAGADO = "NO PAGADO";
		public static string INVENTARIADO = "INVENTARIADO";
		public static string PROCESADO = "PROCESADO";
		public static string FACTURADO = "FACTURADO";
		public static string PEDIDO = "PEDIDO";
		public static string DEVUELTO = "DEVUELTO";
		public static string REMISIONADO = "REMISIONADO";
		public static string COTIZADO = "COTIZADO";
		public static string ANULADO = "ANULADO";
		public static string ORDENADO = "ORDENADO";
		public  string Descripcion { get; set; }
		        
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{				
				db.EstadoDocumento.Add(this);
				db.SaveChanges();					
			}
 		}
		
		public static EstadoDocumento FindByEstado(string descripcionEstado)
 		{
 			using(var db = new ElevenContext())
			{  
 				return db.EstadoDocumento.Where(x => x.Descripcion.Equals(descripcionEstado)).FirstOrDefault();
			}
 		}
		
		public static EstadoDocumento Get(long id)
 		{
 			using(var db = new ElevenContext())
			{  
 				return db.EstadoDocumento.Where(x => x.ID == id).FirstOrDefault();
			}
 		}
	}
}
