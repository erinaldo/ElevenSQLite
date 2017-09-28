drop table if EXISTS "Empleado" ;
drop table if EXISTS "Tercero" ;
drop table if EXISTS "Articulo" ;
drop table if EXISTS "Preferencias" ;
drop table if EXISTS "TipoDocumentoMaestro" ;
drop table if EXISTS "EstadoDocxTipoDocm" ;
drop table if EXISTS "ImpresionDocxTipoDocm" ;
drop table if EXISTS "TipoDocumento" ;
drop table if EXISTS "Comprobante" ;
drop table if EXISTS "Documento" ;
drop table if EXISTS "Permiso" ;
drop table if EXISTS "PermisoTipoDocumento" ;
drop table if EXISTS "DetalleDocumento" ;
drop table if EXISTS "DetalleComprobante" ;
drop table if EXISTS "Banco";
drop TABLE if EXISTS "Bodega" ;
drop table if EXISTS "Familia" ;
drop table if EXISTS "Usuario" ;
drop table if EXISTS "UnidadComercial" ;
drop table if EXISTS "TipoMoneda" ;
drop table if EXISTS "CondicionPago" ;
drop table if EXISTS "TarifaRetencion" ;
drop table if EXISTS "TarifaIVA" ;
drop table if EXISTS "Seccion" ;
drop table if EXISTS "Pais" ;
drop table if EXISTS "Estado" ;
drop table if EXISTS "Ciudad" ;
drop table if EXISTS "EstadoDocumento" ;
drop table if EXISTS "ImpresionDocumento" ;
drop table if EXISTS "InformeDiario" ;
drop table if EXISTS "IntegracionContable" ;
drop table if EXISTS "Sistema" ;
drop table if exists Empresa;

CREATE TABLE "Banco" (
	"ID" INTEGER,
	"Descripcion" VARCHAR(100),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_93 PRIMARY KEY (ID)
) ;
CREATE UNIQUE INDEX RDB$PRIMARY28 ON BANCO (ID) ;

CREATE TABLE "Bodega" (
	"ID" INTEGER,	
	"Descripcion" VARCHAR(100),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_83 PRIMARY KEY (ID)
) ;
CREATE UNIQUE INDEX RDB$PRIMARY26 ON BODEGA (ID) ;

CREATE TABLE "Familia" (
	"ID" INTEGER,	
	"Codigo" VARCHAR(10),
	"Descripcion" VARCHAR(100),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_10 PRIMARY KEY (ID)
) ;
CREATE UNIQUE INDEX RDB$PRIMARY4 ON FAMILIA (ID) ;

CREATE TABLE "Usuario" (
	"ID" INTEGER,
	"NombreUsuario" VARCHAR(15),
	"Clave" VARCHAR(500),	
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_38 PRIMARY KEY (ID)
) ;
CREATE UNIQUE INDEX RDB$12 ON USUARIO (NombreUsuario) ;
CREATE UNIQUE INDEX RDB$PRIMARY13 ON USUARIO (ID) ;

CREATE TABLE "UnidadComercial" (
	"ID" INTEGER,	
	"Codigo" VARCHAR(10),
	"Descripcion" VARCHAR(100),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_13 PRIMARY KEY (ID)
) ;
CREATE UNIQUE INDEX RDB$PRIMARY5 ON UNIDADCOMERCIAL (ID) ;

CREATE TABLE "TipoMoneda" (
	"ID" INTEGER,	
	"Codigo" VARCHAR(10),
	"Descripcion" VARCHAR(100),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_70 PRIMARY KEY (ID)
) ;
CREATE UNIQUE INDEX RDB$22 ON TIPOMONEDA (CODIGO) ;
CREATE UNIQUE INDEX RDB$PRIMARY23 ON TIPOMONEDA (ID) ;

create table "CondicionPago" (
	"ID" INTEGER,
	"Descripcion" varchar(255) not null,
	"Dias" integer not null,
	"Recargo" float not null,
	"ProntoPago" float not null,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	constraint integ_90 primary key (id)
) ;
create unique index rdb$primary27 on condicionpago (id) ;

CREATE TABLE "TarifaRetencion" (
	"ID" INTEGER,
	"Tarifa" FLOAT,
	"Factor" FLOAT,
	"CuentaContable" VARCHAR(255),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_112 PRIMARY KEY (ID)
) ;
CREATE UNIQUE INDEX RDB$PRIMARY32 ON TARIFARETENCION (ID) ;

CREATE TABLE "TarifaIVA" (
	"ID" INTEGER,
	"Tarifa" FLOAT,
	"Factor" FLOAT,
	"CuentaContable" VARCHAR(255),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_73 PRIMARY KEY (ID)
) ;
CREATE UNIQUE INDEX RDB$PRIMARY24 ON TARIFAIVA (ID) ;

CREATE TABLE "Seccion" (
	"ID" INTEGER,
	"Codigo" VARCHAR(10),
	"Descripcion" VARCHAR(100),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	"FamiliaID" INTEGER,
	CONSTRAINT INTEG_7 PRIMARY KEY (ID),
	CONSTRAINT FK_FAMXSEC FOREIGN KEY (FAMILIAID) REFERENCES FAMILIA(ID)
) ;
CREATE INDEX FK_FAMXSEC ON SECCION (FAMILIAID) ;
CREATE UNIQUE INDEX RDB$PRIMARY3 ON SECCION (ID) ;

CREATE TABLE "Pais" (
	"ID" INTEGER,
	"Codigo" VARCHAR(10),
	"Descripcion" VARCHAR(100),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_50 PRIMARY KEY (ID)
) ;
CREATE UNIQUE INDEX RDB$18 ON PAIS (CODIGO) ;
CREATE UNIQUE INDEX RDB$PRIMARY19 ON PAIS (ID) ;

CREATE TABLE "Estado" (
	"ID" INTEGER,
	"Codigo" VARCHAR(10),
	"Descripcion" VARCHAR(100),
	"PaisID" INTEGER,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_42 PRIMARY KEY (ID),
	CONSTRAINT FK_PAISXESTADO FOREIGN KEY (PAISID) REFERENCES PAIS(ID)
) ;
CREATE INDEX FK_PAISXESTADO ON ESTADO (PAISID) ;
CREATE UNIQUE INDEX RDB$14 ON ESTADO (CODIGO) ;
CREATE UNIQUE INDEX RDB$PRIMARY15 ON ESTADO (ID) ;

CREATE TABLE "Ciudad" (
	"ID" INTEGER,
	"Codigo" VARCHAR(10),
	"Descripcion" VARCHAR(100),
	"EstadoID" INTEGER,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,	
	CONSTRAINT INTEG_46 PRIMARY KEY (ID),
	CONSTRAINT FK_ESTADOXCIUDAD FOREIGN KEY (ESTADOID) REFERENCES ESTADO(ID)
) ;
CREATE INDEX FK_ESTADOXCIUDAD ON CIUDAD (ESTADOID) ;
CREATE UNIQUE INDEX RDB$16 ON CIUDAD (CODIGO) ;
CREATE UNIQUE INDEX RDB$PRIMARY17 ON CIUDAD (ID) ;

Create Table "EstadoDocumento" (
	"ID" INTEGER,
	"Descripcion" Varchar(255),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	Constraint Integ_23 Primary Key (Id)
) ;
Create Unique Index Rdb$Primary7 On Estadodocumento (Id) ;

Create Table "ImpresionDocumento" (
	"ID" INTEGER,
	"Descripcion" Varchar(255) Not Null,
	"Clase" Varchar(255) Not Null,
	"Metodo" Varchar(255) Not Null,
	"TipoImpresion" Varchar(255),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	Constraint Integ_79 Primary Key (Id)
) ;
Create Unique Index Rdb$Primary25 On Impresiondocumento (Id) ;

Create Table "InformeDiario" (
	"ID" INTEGER,
	"Observacion" Varchar(1000),
	"FechaInforme" Date,
	"TipoDocumentoID" Char(16),
	"UsuarioID" Char(16),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,	
	Constraint Integ_34 Primary Key (Id),
	Constraint Fk_Tipodocumentoxinforme Foreign Key (TipodocumentoId) References Tipodocumento(Id),
	Constraint Fk_Usuarioxinformediario Foreign Key (UsuarioId) References Usuario(Id)
) ;
Create Index Fk_Tipodocumentoxinforme On Informediario (TipodocumentoId) ;
Create Index Fk_Usuarioxinformediario On Informediario (UsuarioId) ;
Create Unique Index Rdb$Primary11 On Informediario (Id) ;

Create Table "IntegracionContable" (
	"ID" INTEGER,
	"TipoDocumentoID" INTEGER,
	"UsuarioID" INTEGER,
	"InventarioGrabado" Varchar(255),
	"NaturalezaInventarioGrabado" Varchar(255),
	"InventarioExcento" Varchar(255),
	"NaturalezaInventarioExcento" Varchar(255),
	"InventarioExcluido" Varchar(255),
	"NaturalezaInventarioExcluido" Varchar(255),
	"CostoMercancia" Varchar(255),
	"NaturalezaCostoMercancia" Varchar(255),
	"CajaBanco" Varchar(255),
	"NaturalezaCajaBanco" Varchar(255),
	"Compra" Varchar(255),
	"NaturalezaCompra" Varchar(255),
	"Venta" Varchar(255),
	"NaturalezaVenta" Varchar(255),
	"CuentaPagar" Varchar(255),
	"NaturalezaCuentaPagar" Varchar(255),
	"CuentaCobrar" Varchar(255),
	"NaturalezaCuentaCobrar" Varchar(255),
	"Descuento" Varchar(255),
	"NaturalezaDescuento" Varchar(255),
	"Retencion" Varchar(255),
	"NaturalezaRetencion" Varchar(255),
	"Fletes" Varchar(255),
	"NaturalezaFletes" Varchar(255),
	"Anticipos" Varchar(255),
	"NaturalezaAnticipos" Varchar(255),
	"ProntoPago" Varchar(255),
	"NaturalezaProntoPago" Varchar(255),
	"RetencionIVA" Varchar(255),
	"NaturalezaRetencionIVA" Varchar(255),
	"IVA" Varchar(255),
	"NaturalezaIVA" Varchar(255),
	"RetencionICA" Varchar(255),
	"NaturalezaRetencionICA" Varchar(255),
	"DevolucionIVA" Varchar(255),
	"NaturalezaDevolucionIVA" Varchar(255),
	"DevolucionRetencion" Varchar(255),
	"NaturalezaDevolucionRetencion" Varchar(255),
	
	"Gasto" Varchar(255),
	"NaturalezaGasto" Varchar(255),
	
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,	
	Constraint Integ_109 Primary Key (Id),
	Constraint Fk_Tipodocxintegracion Foreign Key (TipodocumentoId) References Tipodocumento(Id),
	Constraint Fk_Usuarioxintegracion Foreign Key (UsuarioId) References Usuario(Id)
) ;
Create Index Fk_Tipodocxintegracion On Integracioncontable (TipodocumentoId) ;
Create Index Fk_Usuarioxintegracion On Integracioncontable (UsuarioId) ;
Create Unique Index Rdb$Primary31 On Integracioncontable (Id) ;

Create Table "Permiso" (
	"ID" INTEGER Not Null,
	"UsuarioID" INTEGER,
	"Maestros" Smallint,
	"Articulos" Smallint,
	"Terceros" Smallint,
	"Documentos" Smallint,
	"Comprobantes" Smallint,
	"Informes" Smallint,
	"Preferencias" Smallint,
	"Empresa" Smallint,
	"Sistema" Smallint,
	"TiposDocumento" Smallint,
	"Mensajes" Smallint,
	"Imagenes" Smallint,
	"Usuarios" Smallint,
	"Mantenimiento" Smallint,
	"TerminalPV" Smallint,
	"NuevoTicket" Smallint,
	"EliminarDetalleTicket" Smallint,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	Constraint Integ_121 Primary Key (Id),
	Constraint Fk_Usuarioxpermiso Foreign Key (UsuarioId) References Usuario(Id)
) ;
Create Index Fk_Usuarioxpermiso On Permiso (UsuarioId) ;
Create Unique Index Rdb$Primary35 On Permiso (Id) ;

Create Table "PermisoTipoDocumento"  (
	"ID" INTEGER Not Null,
	"UsuarioID" INTEGER,
	"TipoDocumentoID" INTEGER,
	"Nuevo" Smallint,
	"Modificar" Smallint,
	"Eliminar" Smallint,
	"Imprimir" Smallint,
	"Anular" Smallint,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	Constraint Integ_124 Primary Key (Id),
	Constraint Fk_Tipodocxpermisotipodoc Foreign Key (TipodocumentoId) References Tipodocumento(Id),
	Constraint Fk_Usuarioxpermisotipodoc Foreign Key (UsuarioId) References Usuario(Id)
) ;
Create Index Fk_Tipodocxpermisotipodoc On Permisotipodocumento (TipodocumentoId) ;
Create Index Fk_Usuarioxpermisotipodoc On Permisotipodocumento (UsuarioId) ;
Create Unique Index Rdb$Primary36 On Permisotipodocumento (Id) ;

CREATE TABLE "Sistema" (
	"ID" INTEGER,
	"VersionDB" FLOAT,
	"Serial" VARCHAR(255),
	"Empresa" VARCHAR(255),
	"GlobalTime" BIGINT,
	"VolumenSerial" VARCHAR(255),
	"Email" VARCHAR(255),
	"ClaveAcceso" SMALLINT,
	"Red" SMALLINT,
	"ActualizarSoftware" SMALLINT,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,	
	CONSTRAINT INTEG_31 PRIMARY KEY (ID)
) ;
CREATE UNIQUE INDEX RDB$PRIMARY10 ON SISTEMA (ID) ;

CREATE TABLE "Empresa" (
	"ID" INTEGER,
	"Nit" varchar(255),
	"RazonSocial" varchar(500),
	"Direccion" varchar(255),
	"TelefonoPrincipal" varchar(255),
	"OtroTelefono" varchar(255),
	"Fax" varchar(255),
	"Movil" varchar(255),
	"Email" varchar(255),
	"PaginaWeb" varchar(255),
	"CodigoCiiu" varchar(255),
	"Frase" varchar(255),
	"RutaLogo" varchar(500),
	"RutaFondoPapel" varchar(500),
	"CiudadID" INTEGER,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	CONSTRAINT INTEG_115 PRIMARY KEY (ID),
	CONSTRAINT FK_CIUDADXEMPRESA FOREIGN KEY (CIUDADID) REFERENCES CIUDAD(ID)
) ;
CREATE INDEX FK_CIUDADXEMPRESA ON EMPRESA (CIUDADID) ;
CREATE UNIQUE INDEX RDB$PRIMARY33 ON EMPRESA (ID) ;

create table "Empleado" (
	"ID" INTEGER,
	"Codigo" varchar(15),
	"NombreCompleto" varchar(150),
	"PrimerApellido" varchar(255),
	"SegundoApellido" varchar(255),
	"PrimerNombre" varchar(255),
	"OtroNombre" varchar(255),
	"DireccionPrincipal" varchar(255),
	"TelefonoPrincipal" varchar(255),
	"TelefonoMovilPrincipal" varchar(255),
	"Email" varchar(255),
	"Observacion" varchar(1000),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,	
	constraint integ_128 primary key (id)
) ;
create unique index rdb$37 on empleado (codigo) ;
create unique index rdb$primary38 on empleado (id) ;

Create Table "Tercero" (
	"ID" INTEGER,
	"Codigo" Varchar(255) Not Null,
	"Nit" Integer,
	"DigitoVerificacion" Integer,
	"NombreComercial" Varchar(255) Not Null,
	"RazonSocial" Varchar(255),
	"ContactoPrincipal" Varchar(255),
	"PrimerApellido" Varchar(255),
	"SegundoApellido" Varchar(255),
	"PrimerNombre" Varchar(255),
	"OtroNombre" Varchar(255),
	"DireccionPrincipal" Varchar(255),
	"TelefonoPrincipal" Varchar(255),
	"OtroTelefonoPrincipal" Varchar(255),
	"TelefonoMovilPrincipal" Varchar(255),
	"DireccionSecundaria" Varchar(255),
	"TelefonoSecundario" Varchar(255),
	"OtroTelefonoSecundario" Varchar(255),
	"TelefonoMovilSecundario" Varchar(255),
	"Fax" Varchar(255),
	"Email" Varchar(255),
	"PaginaWeb" Varchar(255),
	"ReferenciaComercial" Varchar(255),
	"TelefonoReferenciaComercial" Varchar(255),
	"OtraReferenciaComercial" Varchar(255),
	"TelefonoOtraReferenciaComercial" Varchar(255),
	"ExcentoIVA" Smallint,
	"TipoRegimen" Varchar(255),
	"GranContribuyente" Smallint,
	"ClienteNacional" Smallint,
	"ClienteExtranjero" Smallint,
	"ProveedorNacional" Smallint,
	"ProveedorExtranjero" Smallint,
	"Interno" Smallint,
	"OtroTipoTercero" Smallint,
	"Observacion" Varchar(1000),
	"Inhabilitar" Smallint,
	"CiudadID" INTEGER,
	"Calificacion" Integer,
	"TipoPrecioVenta" Integer,
	"UsuarioID" INTEGER,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,	
	Constraint Integ_55 Primary Key (Id),
	Constraint Fk_Ciudadxtercero Foreign Key (CiudadId) References Ciudad(Id),
	Constraint Fk_Usuarioxtercero Foreign Key (UsuarioId) References Usuario(Id)
) ;
Create Index Fk_Ciudadxtercero On Tercero (CiudadId) ;
Create Index Fk_Usuarioxtercero On Tercero (UsuarioId) ;
Create Unique Index Rdb$Primary20 On Tercero (Id) ;

Create Table "Articulo" (
	"ID" INTEGER,
	"Codigo" Varchar(15),
	"Descripcion" Varchar(1000),
	"Servicio" Smallint,
	"CodigoBarras" Varchar(20),
	"CodigoAlternativo" Varchar(20),
	"CodigoPLU" Varchar(20),
	"DescripcionCorta" Varchar(30),
	"Estado" Smallint,
	"Impuesto" Varchar(25),
	"SeccionID" INTEGER,
	"UnidadcomercialID" INTEGER,
	"Costo" Decimal(18,5),
	"ValorNeto" Decimal(18,5),
	"ValorNeto1" Decimal(18,5),
	"ValorNeto2" Decimal(18,5),
	"ValorNeto3" Decimal(18,5),
	"Iva" Float,
	"PrecioVenta" Decimal(18,5),
	"PrecioVenta1" Decimal(18,5),
	"PrecioVenta2" Decimal(18,5),
	"PrecioVenta3" Decimal(18,5),
	"Maximo" Integer,
	"Minimo" Integer,
	"Actual" Decimal(18,5),
	"Disponible" Decimal(18,5),
	"UnidadesArticulo" Integer,
	"PartidaArancelaria" Varchar(255),
	"CostoMinimo" Decimal(18,5),
	"CostoMaximo" Decimal(18,5),
	"CostoPromedio" Decimal(18,5),
	"UltimoCosto" Decimal(18,5),
	"Observacion" Varchar(1000),
	"Utilidad" Decimal(18,5),
	"Utilidad1" Decimal(18,5),
	"Utilidad2" Decimal(18,5),
	"Utilidad3" Decimal(18,5),
	"RedondeoSistema" Smallint,
	"RedondeoInferior" Smallint,
	"RedondeoSuperior" Smallint,
	"FechaUltimaCompra" Timestamp,
	"FechaUltimaVenta" Timestamp,
	"FechaUltimaTransaccion" Timestamp,
	"Catalogo" Smallint,
	"Impresion" Smallint,
	"Compuesto" Smallint,
	"MaximoDescuento" Float,
	"CodigoKIT" Varchar(255),
	"Peso" Float,
	"Volumen" Float,
	"Ancho" Float,
	"Alto" Float,
	"Profundidad" Float,
	"ImpuestoConsumo" Decimal(18,5),
	"RutaImagen" Varchar(255),
	"UsuarioID" INTEGER,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,	
	Constraint Integ_4 Primary Key (Id),
	Constraint Fk_Secxart Foreign Key (SeccionId) References Seccion(Id),
	Constraint Fk_Umxart Foreign Key (UnidadcomercialId) References Unidadcomercial(Id),
	Constraint Fk_Usuarioxarticulo Foreign Key (UsuarioId) References Usuario(Id)
) ;
Create Index Codigobarras On Articulo (Codigobarras) ;
Create Index Codigoplu On Articulo (Codigoplu) ;
Create Index Fk_Secxart On Articulo (SeccionId) ;
Create Index Fk_Umxart On Articulo (UnidadcomercialId) ;
Create Index Fk_Usuarioxarticulo On Articulo (UsuarioId) ;
Create Unique Index Rdb$1 On Articulo (Codigo) ;
Create Unique Index Rdb$Primary2 On Articulo (Id) ;

Create Table "Preferencias" (
	"ID" INTEGER,
	"ControlaInventario" Smallint,
	"ImpresionEncabezado" Smallint,
	"ImpresionLogotipo" Smallint,
	"ColorConsecutivo" Varchar(255),
	"FondoPapel" Smallint,
	"NumeroDecimal" Integer,
	"SeparadorMiles" Varchar(255),
	"ImpresoraPredeterminada" Varchar(500),
	"TipomonedaID" INTEGER,
	"MensajeTituloValor" Varchar(500),
	"MensajeCentralRiesgo" Varchar(500),
	"MensajeGeneral" Varchar(500),
	"OtroMensajeGeneral" Varchar(500),
	"ObservacionDocumento" Varchar(500),
	"OtraObservacionDocumento" Varchar(500),
	"ObservacionNotaDebito" Varchar(500),
	"ObservacionNotaCredito" Varchar(500),
	"FirmaCotizacion" Varchar(500),
	"FirmaRemision" Varchar(500),
	"FirmaFactura" Varchar(500),
	"FirmaComprobante" Varchar(500),
	"FirmaNotas" Varchar(500),
	"FirmaOrdenCompra" Varchar(500),
	"FirmaOrdenPedido" Varchar(500),
	"EnvioInformacionAnonima" Smallint,
	"EnvioInformacionErrores" Smallint,
	"EnvioInformacionShareware" Smallint,
	"ActivarPuntoVenta" Smallint,
	"TerceroPuntoVentaID" INTEGER,
	"TipoDocumentoPuntoVentaID" integer,
	"Activarcajonmonedero" Smallint,
	"PuertoSalida" Varchar(255),
	"CodigoCajonMonedero" Varchar(255),
	"BusquedaLector" Varchar(255),
	"CopiaSeguridad" Smallint,
	"ImprimirTirilla" Smallint,
	"RedondeoSuperior" Smallint,
	"RedondeoInferior" Smallint,
	"RedondeoSistema" Smallint,
	"TipoDocumentoID" INTEGER,
	"UsuarioID" integer,
	"UltimaConfiguracion" Smallint,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	Constraint Integ_118 Primary Key (Id),
	Constraint Fk_Terceropvxpreferencia Foreign Key (TerceropuntoventaId) References Tercero(Id),
	Constraint Fk_Tipodocumentopvxpreferencia Foreign Key (TipodocumentopuntoventaId) References Tipodocumento(Id),
	Constraint Fk_Tipodocumentoxpreferencia Foreign Key (TipodocumentoId) References Tipodocumento(Id),
	Constraint Fk_Tipomonedaxpreferencia Foreign Key (TipomonedaId) References Tipomoneda(Id),
	Constraint Fk_Usuarioxpreferencias Foreign Key (UsuarioId) References Usuario(Id)
) ;
Create Index Fk_Terceropvxpreferencia On Preferencias (TerceropuntoventaId) ;
Create Index Fk_Tipodocumentopvxpreferencia On Preferencias (TipodocumentopuntoventaId) ;
Create Index Fk_Tipodocumentoxpreferencia On Preferencias (TipodocumentoId) ;
Create Index Fk_Tipomonedaxpreferencia On Preferencias (TipomonedaId) ;
Create Index Fk_Usuarioxpreferencias On Preferencias (UsuarioId) ;
Create Unique Index Rdb$Primary34 On Preferencias (Id) ;

Create Table "TipoDocumentoMaestro" (
	"ID" INTEGER,
	"Codigo" Varchar(255) Not Null,
	"Descripcion" Varchar(255) Not Null,
	"Grupo" Varchar(255),
	"ImpresionDocumentoID" INTEGER,
	"EstadoDocumentoID" INTEGER,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	Constraint Integ_62 Primary Key (Id),
	Constraint Fk_Estadodocxdocmaestro Foreign Key (EstadodocumentoId) References Estadodocumento(Id),
	Constraint Fk_Impresiondocxtipodocm Foreign Key (ImpresiondocumentoId) References Impresiondocumento(Id)
) ;
Create Index Fk_Estadodocxdocmaestro On Tipodocumentomaestro (EstadodocumentoId) ;
Create Index Fk_Impresiondocxtipodocm On Tipodocumentomaestro (ImpresiondocumentoId) ;
Create Unique Index Rdb$Primary21 On Tipodocumentomaestro (Id) ;

Create Table "EstadoDocxTipoDocm" (
	"TipoDocumentoMaestroID" INTEGER Not Null,
	"EstadoDocumentoID" INTEGER Not Null,
	Constraint Fk807ac6dabd740523 Foreign Key (EstadodocumentoId) References Estadodocumento(Id),
	Constraint Fk807ac6dae7714b59 Foreign Key (TipodocumentomaestroId) References Tipodocumentomaestro(Id)
) ;
Create Index Fk807ac6dabd740523 On Estadodocxtipodocm (EstadodocumentoId) ;
Create Index Fk807ac6dae7714b59 On Estadodocxtipodocm (TipodocumentomaestroId) ;

Create Table "ImpresionDocxTipoDocm" (
	"TipoDocumentoMaestroID" INTEGER Not Null,
	"ImpresionDocumentoID" INTEGER Not Null,
	Constraint Fkde02035366108e80 Foreign Key (ImpresiondocumentoId) References Impresiondocumento(Id),
	Constraint Fkde020353e7714b59 Foreign Key (TipodocumentomaestroId) References Tipodocumentomaestro(Id)
) ;
Create Index Fkde02035366108e80 On Impresiondocxtipodocm (ImpresiondocumentoId) ;
Create Index Fkde020353e7714b59 On Impresiondocxtipodocm (TipodocumentomaestroId) ;

Create Table "TipoDocumento" (
	"ID" INTEGER,
	"Codigo" Varchar(255) Not Null,
	"Descripcion" Varchar(255) Not Null,
	"ConsecutivoInicial" Integer,
	"ConsecutivoFinal" Integer,
	"ConsecutivoActual" Integer,
	"Prefijo" Varchar(255),
	"Sufijo" Varchar(255),
	"Indice" Integer,
	"Factor" Integer,
	"Autorizacion" Varchar(255),
	"FechaAutorizacion" Date,
	"NumeracionDianDesde" Varchar(255),
	"NumeracionDianHasta" Varchar(255),
	"CantidadDecimal" Integer,
	"IvaIncluido" Smallint,
	"CantidadCopias" Integer,
	"CerosIzquierda" Integer,
	"LimiteRegistro" Integer,
	"TipoFacturacion" Varchar(255),
	"Reservado" Smallint,
	"DiasAdvertenciaDian" Integer,
	"AdvertenciaDian" Smallint,
	"AutoRetenedor" Smallint,
	"Comprobante" Smallint,
	"ImpresionEncabezado" Smallint,
	"ImpresionLogotipo" Smallint,
	"ImpresionDetalleCodigo" Smallint,
	"ImpresionDetalleIva" Smallint,
	"ImpresionDetalleDescuento" Smallint,
	"ImpresionDetalleCantidad" Smallint,
	"ImpresionLineaFinDetalles" Smallint,
	"ImpresionObservacionLinea" Smallint,
	"RedondeoAutomatico" Smallint,
	"ColorConsecutivo" Varchar(255),
	"FondoPapel" Smallint,
	"ClienteNacional" Smallint,
	"ClienteExtranjero" Smallint,
	"ProveedorNacional" Smallint,
	"ProveedorExtranjero" Smallint,
	"Interno" Smallint,
	"OtroTipoTercero" Smallint,
	"MensajeGeneral" Smallint,
	"OtroMensaje" Smallint,
	"TipoMonedaID" INTEGER,
	"ImpresionDocumentoID" INTEGER,
	"EstadoDocumentoID" INTEGER,
	"TipoDocumentoMaestroID" INTEGER,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	Constraint Integ_20 Primary Key (Id),
	Constraint Fk_Estadodocxtipodoc Foreign Key (EstadodocumentoId) References Estadodocumento(Id),
	Constraint Fk_Impresiondocxtipodoc Foreign Key (ImpresiondocumentoId) References Impresiondocumento(Id),
	Constraint Fk_Tdmxtd Foreign Key (TipodocumentomaestroId) References Tipodocumentomaestro(Id),
	Constraint Fk_Tipomonedaxtipodoc Foreign Key (TipomonedaId) References Tipomoneda(Id)
) ;
Create Index Fk_Estadodocxtipodoc On Tipodocumento (EstadodocumentoId) ;
Create Index Fk_Impresiondocxtipodoc On Tipodocumento (ImpresiondocumentoId) ;
Create Index Fk_Tdmxtd On Tipodocumento (TipodocumentomaestroId) ;
Create Index Fk_Tipomonedaxtipodoc On Tipodocumento (TipomonedaId) ;
Create Unique Index Rdb$Primary6 On Tipodocumento (Id) ;

Create Table "Comprobante" (
	"ID" INTEGER Not Null,
	"Consecutivo" Integer Not Null,
	"UsuarioID" INTEGER,
	"TipoDocumentoID" INTEGER,
	"FechaComprobante" Date Not Null,
	"FechaAnulacion" Timestamp,
	"TerceroID" INTEGER,
	"FormaPago" Varchar(255) Not Null,
	"BancoID" INTEGER,
	"NumeroCheque" Varchar(255),
	"Observacion" Varchar(1000),
	"Sucursal" Varchar(255),
	"Elaborado" Varchar(255),
	"Revisado" Varchar(255),
	"Aprobado" Varchar(255),
	"Contabilizado" Varchar(255),
	"TotalDescuento" Decimal(18,5) Not Null,
	"TotalRetencion" Decimal(18,5) Not Null,
	"Total" Decimal(18,5) Not Null,
	"ImpresionDocumentoID" INTEGER,
	"EstadoDocumentoID" INTEGER,
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	Constraint Integ_104 Primary Key (Id),
	Constraint Fk_Bancoxcom Foreign Key (BancoId) References Banco(Id),
	Constraint Fk_Estdocxcomprobante Foreign Key (EstadodocumentoId) References Estadodocumento(Id),
	Constraint Fk_Impresionxcom Foreign Key (ImpresiondocumentoId) References Impresiondocumento(Id),
	Constraint Fk_Terceroxcom Foreign Key (TerceroId) References Tercero(Id),
	Constraint Fk_Tipodocxcomp Foreign Key (TipodocumentoId) References Tipodocumento(Id),
	Constraint Fk_Usuarioxcomprobante Foreign Key (UsuarioId) References Usuario(Id)
) ;
Create Index Fk_Bancoxcom On Comprobante (BancoId) ;
Create Index Fk_Estdocxcomprobante On Comprobante (EstadodocumentoId) ;
Create Index Fk_Impresionxcom On Comprobante (ImpresiondocumentoId) ;
Create Index Fk_Terceroxcom On Comprobante (TerceroId) ;
Create Index Fk_Tipodocxcomp On Comprobante (TipodocumentoId) ;
Create Index Fk_Usuarioxcomprobante On Comprobante (UsuarioId) ;
Create Unique Index Rdb$Primary29 On Comprobante (Id) ;

drop table if exists Documento;
Create Table "Documento" (
	"ID" INTEGER Not Null,
	"Consecutivo" Integer,
	"TipoDocumentoID" INTEGER,
	"FechaDocumento" Date,
	"FechaAnulacion" Timestamp,
	"FechaImpresion" Timestamp,
	"FechaVencimiento" Date,
	"TerceroID" INTEGER,
	"EstadoDocumentoID" INTEGER,
	"EmpleadoID" INTEGER,
	"UsuarioID" INTEGER,
	"ImpresionDocumentoID" INTEGER,
	"Referencia" Varchar(255),
	"CodigoTercero" Varchar(255),
	"NitTercero" Integer,
	"DigitoVerificacionTercero" Integer,
	"NombreComercialTercero" Varchar(255),
	"DireccionPrincipalTercero" Varchar(255),
	"TelefonoPrincipalTercero" Varchar(255),
	"CiudadPrincipalTercero" Varchar(255),
	"DocumentoID" INTEGER,
	"DocumentoPadreID" INTEGER,
	"Observacion" Varchar(1000),
	"AgenteComercial" Varchar(255),
	"Condicion" Varchar(255),
	"TipoMonedaID" INTEGER,
	"CambioTipoMoneda" Decimal(18,5),
	"Recargo" Float,
	"ProntoPago" Float,
	"Total" Decimal(18,5),
	"TotalIVA" Integer,
	"CalcularIVA" Smallint,
	"CalcularDescuento" Smallint,
	"TotalDescuento" Decimal(18,5),
	"TotalImpuesto1" Decimal(18,5),
	"TotalImpuesto2" Decimal(18,5),
	"TotalRetencion" Decimal(18,5),
	"TotalRetencionIVA" Decimal(18,5),
	"TotalRetencionICA" Decimal(18,5),
	"TotalAbono" Decimal(18,5),
	"TotalRecargo" Decimal(18,5),
	"TotalExcedente" Decimal(18,5),
	"TotalFlete" Decimal(18,5),
	"Texto1" Varchar(255),
	"Texto2" Varchar(255),
	"Texto3" Varchar(255),
	"Texto4" Varchar(255),
	"Texto5" Varchar(255),
	"Numero1" Decimal(18,5),
	"Numero2" Decimal(18,5),
	"Numero3" Decimal(18,5),
	"Numero4" Decimal(18,5),
	"Numero5" Decimal(18,5),
	"Zona" Varchar(255),
	"Guia" Varchar(255),
	"Transportador" Varchar(255),
	"TotalImpuestoConsumo" Decimal(18,5),
	"Subtotal" Decimal(18,5),
	"FechaCreacion" TIMESTAMP,
	"FechaModificacion" TIMESTAMP NOT NULL,
	"Eliminado" SMALLINT,
	Constraint Integ_26 Primary Key (Id),
	Constraint Fk_Docxdoc Foreign Key (DocumentoId) References Documento(Id),
	Constraint Fk_Empleadoxdoc Foreign Key (EmpleadoId) References Empleado(Id),
	Constraint Fk_Estdocxdoc Foreign Key (EstadodocumentoId) References Estadodocumento(Id),
	Constraint Fk_Impresionxdoc Foreign Key (ImpresiondocumentoId) References Impresiondocumento(Id),
	Constraint Fk_Terceroxdoc Foreign Key (TerceroId) References Tercero(Id),
	Constraint Fk_Tipodocxdoc Foreign Key (TipodocumentoId) References Tipodocumento(Id),
	Constraint Fk_Tipomonedaxdoc Foreign Key (TipomonedaId) References Tipomoneda(Id),
	Constraint Fk_Usuarioxdoc Foreign Key (UsuarioId) References Usuario(Id)
) ;
Create Index Fk_Docxdoc On Documento (DocumentoId) ;
Create Index Fk_Empleadoxdoc On Documento (EmpleadoId) ;
Create Index Fk_Estdocxdoc On Documento (EstadodocumentoId) ;
Create Index Fk_Impresionxdoc On Documento (ImpresiondocumentoId) ;
Create Index Fk_Terceroxdoc On Documento (TerceroId) ;
Create Index Fk_Tipodocxdoc On Documento (TipodocumentoId) ;
Create Index Fk_Tipomonedaxdoc On Documento (TipomonedaId) ;
Create Index Fk_Usuarioxdoc On Documento (UsuarioId) ;
Create Unique Index Rdb$Primary8 On Documento (Id) ;

Create Table "DetalleComprobante" (
	"ID" INTEGER Not Null,
	"DocumentoID" INTEGER,
	"Concepto" Varchar(255),
	"TotalDocumento" Decimal(18,5),
	"Descuento" Decimal(18,5),
	"Retencion" Decimal(18,5),
	"Total" Decimal(18,5),
	"Observacion" Varchar(1000),
	"ComprobanteID" INTEGER,
	Constraint Integ_106 Primary Key (Id),
	Constraint Fk_Compxdetcomp Foreign Key (ComprobanteId) References Comprobante(Id),
	Constraint Fk_Docuxdetcompro Foreign Key (DocumentoId) References Documento(Id)
) ;
Create Index Fk_Compxdetcomp On Detallecomprobante (ComprobanteId) ;
Create Index Fk_Docuxdetcompro On Detallecomprobante (DocumentoId) ;
Create Unique Index Rdb$Primary30 On Detallecomprobante (Id) ;

Create Table "DetalleDocumento" (
	"ID" INTEGER Not Null,
	"ArticuloID" INTEGER,
	"BodegaID" INTEGER,
	"Descripcion" Varchar(1000),
	"Observacion" Varchar(1000),
	"Cantidad" Decimal(18,5),
	"Costo" Decimal(18,5),
	"ValorNeto" Decimal(18,5),
	"ValorUnitario" Decimal(18,5),
	"Iva" Integer,
	"Retencion" Integer,
	"TarifaIva" Float,
	"TarifaRetencion" Float,
	"SubTotal" Decimal(18,5),
	"Descuento" Decimal(18,5),
	"ImpuestoConsumo" Decimal(18,5),
	"Impuesto1" Decimal(18,5),
	"Impuesto2" Decimal(18,5),
	"Total" Decimal(18,5),
	"ObservacionInterna" Varchar(255),
	"DocumentoID" INTEGER,
	Constraint Integ_28 Primary Key (Id),
	Constraint Fk_Artxdetadoc Foreign Key (ArticuloId) References Articulo(Id),
	Constraint Fk_Bodegaocxdetdoc Foreign Key (BodegaId) References Bodega(Id),
	Constraint Fk_Docxdetdoc Foreign Key (DocumentoId) References Documento(Id)
) ;
Create Index Fk_Artxdetadoc On Detalledocumento (ArticuloId) ;
Create Index Fk_Bodegaocxdetdoc On Detalledocumento (BodegaId) ;
Create Index Fk_Docxdetdoc On Detalledocumento (DocumentoId) ;
Create Unique Index Rdb$Primary9 On Detalledocumento (Id) ;