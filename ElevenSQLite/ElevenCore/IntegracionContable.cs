/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using  System.Collections.Generic;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of IntegracionContable.
	/// </summary>
	public class IntegracionContable  : Persistent
	{
		public IntegracionContable()
		{
		}
		
		public long? TipoDocumentoID { get; set; }
		public string InventarioGrabado { get; set; }
		public string NaturalezaInventarioGrabado { get; set; }
		public string InventarioExcento { get; set; }
		public string NaturalezaInventarioExcento { get; set; }
		public string InventarioExcluido { get; set; }
		public string NaturalezaInventarioExcluido { get; set; }
		public string CostoMercancia { get; set; }
		public string NaturalezaCostoMercancia { get; set; }
		public string CajaBanco { get; set; }
		public string NaturalezaCajaBanco { get; set; }
		public string Compra { get; set; }
		public string NaturalezaCompra { get; set; }
		public string Venta { get; set; }
		public string NaturalezaVenta { get; set; }
		public string CuentaPagar { get; set; }
		public string NaturalezaCuentaPagar { get; set; }
		public string CuentaCobrar { get; set; }
		public string NaturalezaCuentaCobrar { get; set; }
		public string Descuento { get; set; }
		public string NaturalezaDescuento { get; set; }
		public string Gasto { get; set; }
		public string NaturalezaGasto { get; set; }
		public string Retencion { get; set; }
		public string NaturalezaRetencion { get; set; }
		public string Fletes { get; set; }
		public string NaturalezaFletes { get; set; }
		public string Anticipos { get; set; }
		public string NaturalezaAnticipos { get; set; }
		public string ProntoPago { get; set; }
		public string NaturalezaProntoPago { get; set; }
		public string Iva { get; set; }
		public string NaturalezaIva { get; set; }
		public string RetencionIVA { get; set; }		
		public string NaturalezaRetencionIVA { get; set; }
		public string RetencionICA { get; set; }
		public string NaturalezaRetencionICA { get; set; }
		public string DevolucionIVA { get; set; }
		public string NaturalezaDevolucionIVA { get; set; }
		public string DevolucionRetencion { get; set; }
		public string NaturalezaDevolucionRetencion { get; set; }
		public long? UsuarioID { get; set; }
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{
				db.IntegracionContable.Add(this);
				db.SaveChanges();
			}
 		}
		public void Delete(){}
		public static IntegracionContable FindByTipoDocumento (TipoDocumento td) 
		{			
			using(var db = new ElevenContext())
			{  
				return db.IntegracionContable.Where(i => i.TipoDocumentoID == td.ID).FirstOrDefault();
			}
		}
	}
}
