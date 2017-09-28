/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 8:35 p. m.
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
	/// Description of Preferencias.
	/// </summary>
	public class Preferencias : Persistent
	{
		public Preferencias()
		{
		}
		
		public long? UsuarioID { get; set; }
		public bool UltimaConfiguracion { get; set; }
		[NotMapped]
		public long? UltimoTipoDocumentoID { get; set; }
		public bool ControlaInventario { get; set; }
		public bool ImpresionEncabezado { get; set; }
		public bool ImpresionLogotipo { get; set; }
		public string ColorConsecutivo { get; set; }
		public bool FondoPapel { get; set; }
		public int NumeroDecimal { get; set; }
		public string SeparadorMiles { get; set; }
		public string ImpresoraPredeterminada { get; set; }
		public long? TipoMonedaID{ get; set; }
		public string MensajeTituloValor { get; set; }
		public string MensajeCentralRiesgo { get; set; }
		public string MensajeGeneral { get; set; }
		public string OtroMensajeGeneral{ get; set; }
		public string ObservacionDocumento { get; set; }
		public string OtraObservacionDocumento { get; set; }
		public string ObservacionNotaDebito { get; set; }
		public string ObservacionNotaCredito { get; set; }
		public string FirmaCotizacion { get; set; }
		public string FirmaRemision { get; set; }
		public string FirmaFactura { get; set; }
		public string FirmaComprobante { get; set; }
		public string FirmaNotas { get; set; }
		public string FirmaOrdenCompra { get; set; }
		public string FirmaOrdenPedido { get; set; }
		public bool ActivarPuntoVenta { get; set; }
		public long? TerceroPuntoVentaID{ get; set; }
		public long? TipoDocumentoPuntoVentaID{ get; set; }
		public string BusquedaLector{ get; set; }
		public bool ActivarCajonMonedero { get; set; }
		public string PuertoSalida { get; set; }
		public string CodigoCajonMonedero { get; set; }
		public bool CopiaSeguridad { get; set; }
		public bool RedondeoSistema { get; set; }
		public bool RedondeoInferior { get; set; }
		public bool RedondeoSuperior{ get; set; }
		public bool ImprimirTirilla { get; set; }
		public bool EnvioInformacionAnonima { get; set; }
		public bool EnvioInformacionErrores{ get; set; }
		public bool EnvioInformacionShareware{ get; set; }
		public void Save()
 		{
 			using (var db = new ElevenContext())
			{				
				db.Preferencias.Add(this);
				db.SaveChanges();					
			}
 		}
		public void Update()
 		{
 			using (var db = new ElevenContext())
			{
				
					db.Preferencias.Attach(this);
					var entry = db.Entry(this);
					entry.Property(ex => ex.UsuarioID).IsModified = true;
					entry.Property(ex => ex.UltimaConfiguracion).IsModified = true;
					//entry.Property(ex => ex.UltimoTipoDocumentoID).IsModified = true;
					entry.Property(ex => ex.ControlaInventario).IsModified = true;
					entry.Property(ex => ex.ImpresionEncabezado).IsModified = true;
					entry.Property(ex => ex.ImpresionLogotipo).IsModified = true;
					entry.Property(ex => ex.ColorConsecutivo).IsModified = true;
					entry.Property(ex => ex.FondoPapel).IsModified = true;
					entry.Property(ex => ex.NumeroDecimal).IsModified = true;
					entry.Property(ex => ex.SeparadorMiles).IsModified = true;
					entry.Property(ex => ex.ImpresoraPredeterminada).IsModified = true;
					entry.Property(ex => ex.TipoMonedaID).IsModified = true;
					entry.Property(ex => ex.MensajeTituloValor).IsModified = true;
					entry.Property(ex => ex.MensajeCentralRiesgo).IsModified = true;
					entry.Property(ex => ex.MensajeGeneral).IsModified = true;
					entry.Property(ex => ex.OtroMensajeGeneral).IsModified = true;
					entry.Property(ex => ex.ObservacionDocumento).IsModified = true;
					entry.Property(ex => ex.OtraObservacionDocumento).IsModified = true;
					entry.Property(ex => ex.ObservacionNotaDebito).IsModified = true;
					entry.Property(ex => ex.ObservacionNotaCredito).IsModified = true;
					entry.Property(ex => ex.FirmaCotizacion).IsModified = true;
					entry.Property(ex => ex.FirmaRemision).IsModified = true;
					entry.Property(ex => ex.FirmaFactura).IsModified = true;
					entry.Property(ex => ex.FirmaComprobante).IsModified = true;
					entry.Property(ex => ex.FirmaNotas).IsModified = true;
					entry.Property(ex => ex.FirmaOrdenCompra).IsModified = true;
					entry.Property(ex => ex.FirmaOrdenPedido).IsModified = true;
					entry.Property(ex => ex.ActivarPuntoVenta).IsModified = true;
					entry.Property(ex => ex.TerceroPuntoVentaID).IsModified = true;
					entry.Property(ex => ex.TipoDocumentoPuntoVentaID).IsModified = true;
					entry.Property(ex => ex.BusquedaLector).IsModified = true;
					entry.Property(ex => ex.ActivarCajonMonedero).IsModified = true;
					entry.Property(ex => ex.PuertoSalida).IsModified = true;
					entry.Property(ex => ex.CodigoCajonMonedero).IsModified = true;
					entry.Property(ex => ex.CopiaSeguridad).IsModified = true;
					entry.Property(ex => ex.RedondeoSistema).IsModified = true;
					entry.Property(ex => ex.RedondeoInferior).IsModified = true;
					entry.Property(ex => ex.RedondeoSuperior).IsModified = true;
					entry.Property(ex => ex.ImprimirTirilla).IsModified = true;
					entry.Property(ex => ex.EnvioInformacionAnonima).IsModified = true;
					entry.Property(ex => ex.EnvioInformacionErrores).IsModified = true;
					entry.Property(ex => ex.EnvioInformacionShareware).IsModified = true;
					entry.Property(ex => ex.FechaModificacion).IsModified = true;
					entry.Property(ex => ex.UsuarioID).IsModified = true;
					db.SaveChanges();
					
			}
 		}
		public static Preferencias Get (Usuario usuario) 
		{
			using(var db = new ElevenContext())
			{  
				return db.Preferencias.Where(p => p.UsuarioID == usuario.ID).FirstOrDefault();
			}
		}
		
	}
}
