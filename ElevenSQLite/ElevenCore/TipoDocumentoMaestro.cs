/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of TipoDocumentoMaestro.
	/// </summary>
	public class TipoDocumentoMaestro : Persistent
	{
		public TipoDocumentoMaestro()
		{
			EstadosDocumento = new List<EstadoDocumento>();
			ImpresionesDocumento = new List<ImpresionDocumento>();
		}
		public static string COTIZACION_VENTA = "CV";
		public static string ORDEN_PEDIDO = "OP";
		public static string REMISION = "R";
		public static string FACTURA_VENTA = "FV";
		public static string SALIDA_INVENTARIO = "SI";
		public static string ORDEN_COMPRA = "OC";
		public static string FACTURA_COMPRA = "FC";
		public static string ENTRADA_INVENTARIO = "EI";
		public static string DEVOLUCION_VENTA = "DEV";
		public static string DEVOLUCION_COMPRA = "DEC";
		public static string INVENTARIO_INICIAL = "II";
		public static string COMPROBANTE_INGRESO = "CI";
		public static string COMPROBANTE_EGRESO = "CE";
		public static string RECIBO_CAJA = "RC";
		public static string NOTA_DEBITO = "ND";
		public static string NOTA_CREDITO = "NC";
		public static string GRUPO_COMPROBANTE = "C";
		public static string GRUPO_DOCUMENTO = "D";
		public static string GRUPO_NOTA = "N";
		
		public string Codigo { get; set; }
		public string Descripcion { get; set; }
		
		public long? EstadoDocumentoID { get; set; }
		//public virtual EstadoDocumento EstadoDocumento { get; set; }
		[NotMapped]
		public List<EstadoDocumento> EstadosDocumento { get; set; }
		
		
		public long? ImpresionDocumentoID { get; set; }
		//public virtual ImpresionDocumento ImpresionDocumento { get; set; }
		[NotMapped]
		public List<ImpresionDocumento> ImpresionesDocumento { get; set; }
		public string Grupo { get; set; }
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{				
				db.TipoDocumentoMaestro.Add(this);
				db.SaveChanges();
				foreach (var ed in EstadosDocumento) {
					db.Database.ExecuteSqlCommand("insert into EstadoDocxTipoDocm values("+ ID.ToString() +","+ ed.ID.ToString() +")");
				}
				foreach (var id in ImpresionesDocumento) {
					db.Database.ExecuteSqlCommand("insert into ImpresionDocxTipoDocm values("+ ID.ToString() +","+ id.ID.ToString() +")");
				}
				
			}
 		}
		public void Load()
		{
			using(var db = new ElevenContext())
			{  
				var query = db.Database.SqlQuery<ImpresionDocumento>("SELECT * FROM ImpresionDocumento INNER JOIN ImpresionDocxTipoDocm ON ( ImpresionDocumento.ID = ImpresionDocxTipoDocm.ImpresionDocumentoID) WHERE TipoDocumentoMaestroID = " + ID);
				ImpresionesDocumento = query.ToList();
				
				var query2 = db.Database.SqlQuery<EstadoDocumento>("SELECT * FROM EstadoDocumento INNER JOIN EstadoDocxTipoDocm ON (EstadoDocumento.ID = EstadoDocxTipoDocm.EstadoDocumentoID) WHERE TipoDocumentoMaestroID = " + ID);
				EstadosDocumento = query2.ToList();
			}
		}
		public static TipoDocumentoMaestro Get(long id)
 		{
			TipoDocumentoMaestro td = null;
 			using(var db = new ElevenContext())
			{  
 				td = db.TipoDocumentoMaestro.Where(x => x.ID == id).FirstOrDefault();
 				
			}
 			return td;
 		}
		public static BindingList<TipoDocumentoMaestro> GetAllGrupo (string grupo) 
		{
			BindingList<TipoDocumentoMaestro> lista = new BindingList<TipoDocumentoMaestro>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.TipoDocumentoMaestro.Where(tdm => tdm.Grupo.Equals(grupo)))
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
		public static TipoDocumentoMaestro FindByTipoDocumentoMaestro (string grupo) 
		{
			using(var db = new ElevenContext())
			{  
				return db.TipoDocumentoMaestro.ElementAtOrDefault(0);
			}
			
		}
		public static TipoDocumentoMaestro FindByCodigo (string codigo) 
		{
			using(var db = new ElevenContext())
			{  
				return db.TipoDocumentoMaestro.Where(tdm => tdm.Codigo.Equals(codigo)).FirstOrDefault();
			}
			
		}
		public static BindingList<TipoDocumentoMaestro> GetAll () 
		{
			BindingList<TipoDocumentoMaestro> lista = new BindingList<TipoDocumentoMaestro>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.TipoDocumentoMaestro)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
