/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:24 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of InformeDiario.
	/// </summary>
	public class InformeDiario : Persistent
	{
		public InformeDiario()
		{
		}
		public TipoDocumento TipoDocumento { get; set; }
		public string Observacion { get; set; }
		public DateTime? FechaInforme { get; set; }
		public Usuario Usuario { get; set; }
	}
}
