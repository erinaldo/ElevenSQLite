/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 6:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Persistent.
	/// </summary>
	public class Persistent
	{
		public Persistent()
		{
		}
		
		[Key]
    	[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public long ID { get ; set; }
		
		public bool Eliminado { get ; set; }
		public DateTime FechaCreacion { get ; set; }
		public DateTime FechaModificacion { get ; set; }
		
	}
}
