/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of DetalleComprobante.
	/// </summary>
	public class DetalleComprobante
	{
		public DetalleComprobante()
		{
		}
		
		public  long Id { get; set; }
		public  string Concepto { get; set; }
		public  Documento Documento { get; set; }
		public  decimal Descuento { get; set; }
		public  decimal Retencion { get; set; }
		public  decimal Total { get; set; }
		public  decimal TotalDocumento { get; set; }
		public  string Observacion { get; set; }
	}
}
