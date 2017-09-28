/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 6:28 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of ElevenContext.
	/// </summary>
	public class ElevenContext : DbContext
	{
		public ElevenContext() :  
			base(new SQLiteConnection() {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "Data.db"}.ConnectionString 
		    }, true)
        {
			//ForeignKeys = true 
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Banco> Banco { get; set; }
        public DbSet<Bodega> Bodega { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Comprobante> Comprobante { get; set; }
        public DbSet<Familia> Familia { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UnidadComercial> UnidadComercial { get; set; }
        public DbSet<TipoMoneda> TipoMoneda { get; set; }
        public DbSet<TarifaRetencion> TarifaRetencion { get; set; }
        public DbSet<TarifaIVA> TarifaIVA { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<CondicionPago> CondicionPago { get; set; }
        public DbSet<DetalleComprobante> DetalleComprobante { get; set; }
        public DbSet<DetalleDocumento> DetalleDocumento{ get; set; }
        public DbSet<Documento> Documento{ get; set; }
        public DbSet<Empleado> Empleado{ get; set; }
        public DbSet<Empresa> Empresa{ get; set; }
        public DbSet<EstadoDocumento> EstadoDocumento{ get; set; }
        public DbSet<ImpresionDocumento> ImpresionDocumento{ get; set; }
        public DbSet<InformeDiario> InformeDiario{ get; set; }
        public DbSet<IntegracionContable> IntegracionContable{ get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<PermisoTipoDocumento> PermisoTipoDocumento { get; set; }
        public DbSet<Preferencias> Preferencias{ get; set; }
        public DbSet<Seccion> Seccion { get; set; }
        public DbSet<Sistema> Sistema { get; set; }
        public DbSet<Tercero> Tercero{ get; set; }
        public DbSet<TipoDocumento> TipoDocumento{ get; set; }
        public DbSet<TipoDocumentoMaestro> TipoDocumentoMaestro{ get; set; }        
	}
}
