/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:09 p. m.
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
	/// Description of DetalleDocumento.
	/// </summary>
	public class DetalleDocumento
	{
		public DetalleDocumento()
		{
		}
		[Key]
    	[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public long ID { get ; set; }
		
		public  float TarifaIva { get; set; }
		public  float TarifaRetencion { get; set; }
		public  long ArticuloID { get; set; }
		public  string Descripcion { get; set; }
		public  string Observacion { get; set; }
		public  decimal Cantidad { get; set; }
		public  decimal Costo { get; set; }
		public  decimal ValorNeto { get; set; }
		public  decimal ValorUnitario { get; set; }
		public  decimal Descuento { get; set; }
		public  decimal Total { get; set; }
		public  int Iva { get; set; }
		public  decimal Impuesto1 { get; set; }
		public  decimal Impuesto2 { get; set; }
		public  decimal SubTotal { get; set; }
		public  decimal ImpuestoConsumo { get; set; }
		public  string ObservacionInterna { get; set; }
		public  long BodegaID { get; set; }
		public  int Retencion { get; set; }
		public  long DocumentoID { get; set; }
		
		[NotMapped]
		public string Codigo{ get; set; }
		
		public void Save()
		{
			using (var db = new ElevenContext())
			{
				db.DetalleDocumento.Add(this);
				db.SaveChanges();
			}
		}
		
		public void Update()
		{
			using (var db = new ElevenContext())
			{
				db.DetalleDocumento.Attach(this);
				var entry = db.Entry(this);
				entry.Property(ex =>TarifaIva ).IsModified = true;
				entry.Property(ex =>TarifaRetencion ).IsModified = true;
				entry.Property(ex =>ArticuloID ).IsModified = true;
				entry.Property(ex =>Descripcion ).IsModified = true;
				entry.Property(ex =>Observacion ).IsModified = true;
				entry.Property(ex =>Cantidad ).IsModified = true;
				entry.Property(ex =>Costo ).IsModified = true;
				entry.Property(ex =>ValorNeto ).IsModified = true;
				entry.Property(ex =>ValorUnitario ).IsModified = true;
				entry.Property(ex =>Descuento ).IsModified = true;
				entry.Property(ex =>Total ).IsModified = true;
				entry.Property(ex =>Iva ).IsModified = true;
				entry.Property(ex =>Impuesto1 ).IsModified = true;
				entry.Property(ex =>Impuesto2 ).IsModified = true;
				entry.Property(ex =>SubTotal ).IsModified = true;
				entry.Property(ex =>ImpuestoConsumo ).IsModified = true;
				entry.Property(ex =>ObservacionInterna ).IsModified = true;
				entry.Property(ex =>BodegaID ).IsModified = true;
				entry.Property(ex =>Retencion ).IsModified = true;
				entry.Property(ex =>DocumentoID ).IsModified = true;
				db.SaveChanges();
			}
		}
	}
}
