
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

insert into pais(codigo, descripcion, fechacreacion, fechamodificacion, eliminado) values('169', 'Colombia', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);

Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('11', 'BOGOTA D.C.', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('05', 'ANTIOQUIA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('08', 'ATLANTICO', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('09', 'BARRANQUILLA D.C.', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('13', 'BOLIVAR', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('14', 'CARTAGENA D.E.', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('15', 'BOYACA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('17', 'CALDAS', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('18', 'CAQUETA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('19', 'CAUCA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('20', 'CESAR', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('23', 'CORDOBA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('25', 'CUNDINAMARCA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('27', 'CHOCO', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('41', 'HUILA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('44', 'LA GUAJIRA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('47', 'MAGDALENA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('48', 'STA MARTA D.E.', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('50', ' META', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('52', 'NARIÑO', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('54', 'NOR.SANTANDER', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('63', 'QUINDIO', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('66', 'RISARALDA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('68', 'SANTANDER', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('70', 'SUCRE', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('73', 'TOLIMA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('76', 'VALLE', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('81', 'ARAUCA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('85', 'CASANARE', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('86', 'PUTUMAYO', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('88', 'SAN ANDRES Y PROV', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('91', 'AMAZONAS', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('94', 'GUAINIA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('95', 'GUAVIARE', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('97', 'VAUPES', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);
Insert into estado(codigo, descripcion, PaisID, fechacreacion, fechamodificacion, eliminado) values('99', 'VICHADA', 1, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 0);

insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05001', 1, 'MEDELLIN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05002', 1, 'ABEJORRAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05004', 1, 'ABRIAQUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05021', 1, 'ALEJANDRIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05030', 1, 'AMAGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05031', 1, 'AMALFI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05034', 1, 'ANDES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05036', 1, 'ANGELOPOLIS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05038', 1, 'ANGOSTURA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05040', 1, 'ANORI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05042', 1, 'ANTIOQUIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05044', 1, 'ANZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05045', 1, 'APARTADO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05051', 1, 'ARBOLETES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05055', 1, 'ARGELIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05059', 1, 'ARMENIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05079', 1, 'BARBOSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05086', 1, 'BELMIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05088', 1, 'BELLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05091', 1, 'BETANIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05093', 1, 'BETULIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05101', 1, 'BOLIVAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05107', 1, 'BRICE�O', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05113', 1, 'BURITICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05120', 1, 'CACERES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05125', 1, 'CAICEDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05129', 1, 'CALDAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05134', 1, 'CAMPAMENTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05138', 1, 'CA�ASGORDAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05142', 1, 'CARACOLI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05145', 1, 'CARAMANTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05147', 1, 'CAREPA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05148', 1, 'CARMEN DE VIBORAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05150', 1, 'CAROLINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05154', 1, 'CAUCASIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05172', 1, 'CHIGORODO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05190', 1, 'CISNEROS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05197', 1, 'COCORNA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05206', 1, 'CONCEPCION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05209', 1, 'CONCORDIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05212', 1, 'COPACABANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05234', 1, 'DABEIBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05237', 1, 'DON MATIAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05240', 1, 'EBEJICO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05250', 1, 'EL BAGRE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05264', 1, 'ENTRERRIOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05266', 1, 'ENVIGADO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05282', 1, 'FREDONIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05284', 1, 'FRONTINO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05306', 1, 'GIRALDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05308', 1, 'GIRARDOTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05310', 1, 'GOMEZ PLATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05313', 1, 'GRANADA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05315', 1, 'GUADALUPE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05318', 1, 'GUARNE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05321', 1, 'GUATAPE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05347', 1, 'HELICONIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05353', 1, 'HISPANIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05360', 1, 'ITAGUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05361', 1, 'ITUANGO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05364', 1, 'JARDIN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05368', 1, 'JERICO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05376', 1, 'LA CEJA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05380', 1, 'LA ESTRELLA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05390', 1, 'LA PINTADA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05400', 1, 'LA UNION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05411', 1, 'LIBORINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05425', 1, 'MACEO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05440', 1, 'MARINILLA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05467', 1, 'MONTEBELLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05475', 1, 'MURINDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05480', 1, 'MUTATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05483', 1, 'NARI�O', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05490', 1, 'NECOCLI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05495', 1, 'NECHI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05501', 1, 'OLAYA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05541', 1, 'PE�OL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05543', 1, 'PEQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05576', 1, 'PUEBLORRICO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05579', 1, 'PUERTO BERRIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05585', 1, 'PUERTO NARE (LA MAGD', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05591', 1, 'PUERTO TRIUNFO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05604', 1, 'REMEDIOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05607', 1, 'RETIRO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05615', 1, 'RIONEGRO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05628', 1, 'SABANALARGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05631', 1, 'SABANETA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05642', 1, 'SALGAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05647', 1, 'SAN ANDRES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05649', 1, 'SAN CARLOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05652', 1, 'SAN FRANCISCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05656', 1, 'SAN JERONIMO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05658', 1, 'SAN JOSE DE LA MONTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05659', 1, 'SAN JUAN DE URABA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05660', 1, 'SAN LUIS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05664', 1, 'SAN PEDRO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05665', 1, 'SAN PEDRO DE URABA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05667', 1, 'SAN RAFAEL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05670', 1, 'SAN ROQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05674', 1, 'SAN VICENTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05679', 1, 'SANTA BARBARA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05686', 1, 'SANTA ROSA DE OSOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05690', 1, 'SANTO DOMINGO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05697', 1, 'SANTUARIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05736', 1, 'SEGOVIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05756', 1, 'SONSON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05761', 1, 'SOPETRAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05789', 1, 'TAMESIS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05790', 1, 'TARAZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05792', 1, 'TARSO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05809', 1, 'TITIRIBI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05819', 1, 'TOLEDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05837', 1, 'TURBO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05842', 1, 'URAMITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05847', 1, 'URRAO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05854', 1, 'VALDIVIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05856', 1, 'VALPARAISO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05858', 1, 'VEGACHI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05861', 1, 'VENECIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05873', 1, 'VIGIA DEL FUERTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05885', 1, 'YALI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05887', 1, 'YARUMAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05890', 1, 'YOLOMBO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05893', 1, 'YONDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('05895', 1, 'ZARAGOZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08001', 1, 'BARRANQUILLA (DISTRI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08078', 1, 'BARANOA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08137', 1, 'CAMPO DE LA CRUZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08141', 1, 'CANDELARIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08296', 1, 'GALAPA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08372', 1, 'JUAN DE ACOSTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08421', 1, 'LURUACO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08433', 1, 'MALAMBO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08436', 1, 'MANATI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08520', 1, 'PALMAR DE VARELA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08549', 1, 'PIOJO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08558', 1, 'POLO NUEVO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08560', 1, 'PONEDERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08573', 1, 'PUERTO COLOMBIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08606', 1, 'REPELON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08634', 1, 'SABANAGRANDE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08638', 1, 'SABANALARGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08675', 1, 'SANTA LUCIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08685', 1, 'SANTO TOMAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08758', 1, 'SOLEDAD', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08770', 1, 'SUAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08832', 1, 'TUBARA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('08849', 1, 'USIACURI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11001', 1, 'BOGOTA - USAQUEN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11002', 1, 'BOGOTA - CHAPINERO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11003', 1, 'BOGOTA - SANTA FE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11004', 1, 'BOGOTA - SAN CRISTOBAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11005', 1, 'BOGOTA - USME', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11006', 1, 'BOGOTA - TUNJUELITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11007', 1, 'BOGOTA - BOSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11008', 1, 'BOGOTA - KENNEDY', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11009', 1, 'BOGOTA - FONTIBON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11010', 1, 'BOGOTA - ENGATIVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11011', 1, 'BOGOTA - SUBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11012', 1, 'BOGOTA - BARRIOS UNIDOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11013', 1, 'BOGOTA - TEUSAQUILLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11014', 1, 'BOGOTA - MARTIRES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11015', 1, 'BOGOTA - ANTONIUO NARI�O', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11016', 1, 'BOGOTA - PUENTE ARANDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11017', 1, 'BOGOTA - CANDELARIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11018', 1, 'BOGOTA - RAFAEL URIBE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11019', 1, 'BOGOTA - CIUDAD BOLIVAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('11020', 1, 'BOGOTA - SUMAPAZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13001', 1, 'CARTAGENA (DISTRITO ESPECIAL)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13006', 1, 'ACHI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13030', 1, 'ALTOS DEL ROSARIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13042', 1, 'ARENAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13052', 1, 'ARJONA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13062', 1, 'ARROYOHONDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13074', 1, 'BARRANCO DE LOBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13140', 1, 'CALAMAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13160', 1, 'CANTAGALLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13188', 1, 'CICUCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13212', 1, 'CORDOBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13222', 1, 'CLEMENCIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13244', 1, 'EL CARMEN DE BOLIVAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13248', 1, 'EL GUAMO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13268', 1, 'EL PE�ON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13300', 1, 'HATILLO DE LOBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13430', 1, 'MAGANGUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13433', 1, 'MAHATES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13440', 1, 'MARGARITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13442', 1, 'MARIA LA BAJA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13458', 1, 'MONTECRISTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13468', 1, 'MOMPOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13473', 1, 'MORALES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13549', 1, 'PINILLOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13580', 1, 'REGIDOR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13600', 1, 'RIO VIEJO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13620', 1, 'SAN CRISTOBAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13647', 1, 'SAN ESTANISLAO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13650', 1, 'SAN FERNANDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13654', 1, 'SAN JACINTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13655', 1, 'SAN JACINTO DEL CAUC', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13657', 1, 'SAN JUAN NEPOMUCENO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13667', 1, 'SAN MARTIN DE LOBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13670', 1, 'SAN PABLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13673', 1, 'SANTA CATALINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13683', 1, 'SANTA ROSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13688', 1, 'SANTA ROSA DEL SUR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13744', 1, 'SIMITI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13760', 1, 'SOPLAVIENTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13780', 1, 'TALAIGUA NUEVO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13810', 1, 'TIQUISIO (PUERTO RIC', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13836', 1, 'TURBACO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13838', 1, 'TURBANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13873', 1, 'VILLANUEVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('13894', 1, 'ZAMBRANO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15001', 1, 'TUNJA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15022', 1, 'ALMEIDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15047', 1, 'AQUITANIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15051', 1, 'ARCABUCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15087', 1, 'BELEN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15090', 1, 'BERBEO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15092', 1, 'BETEITIVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15097', 1, 'BOAVITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15104', 1, 'BOYACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15106', 1, 'BRICE�O', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15109', 1, 'BUENAVISTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15114', 1, 'BUSBANZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15131', 1, 'CALDAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15135', 1, 'CAMPOHERMOSO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15162', 1, 'CERINZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15172', 1, 'CHINAVITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15176', 1, 'CHIQUINQUIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15180', 1, 'CHISCAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15183', 1, 'CHITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15185', 1, 'CHITARAQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15187', 1, 'CHIVATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15189', 1, 'CIENEGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15204', 1, 'COMBITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15212', 1, 'COPER', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15215', 1, 'CORRALES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15218', 1, 'COVARACHIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15223', 1, 'CUBARA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15224', 1, 'CUCAITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15226', 1, 'CUITIVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15232', 1, 'CHIQUIZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15236', 1, 'CHIVOR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15238', 1, 'DUITAMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15244', 1, 'EL COCUY', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15248', 1, 'EL ESPINO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15272', 1, 'FIRAVITOBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15276', 1, 'FLORESTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15293', 1, 'GACHANTIVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15296', 1, 'GAMEZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15299', 1, 'GARAGOA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15317', 1, 'GUACAMAYAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15322', 1, 'GUATEQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15325', 1, 'GUAYATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15332', 1, 'GUICAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15362', 1, 'IZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15367', 1, 'JENESANO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15368', 1, 'JERICO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15377', 1, 'LABRANZAGRANDE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15380', 1, 'LA CAPILLA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15401', 1, 'LA VICTORIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15403', 1, 'LA UVITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15407', 1, 'VILLA DE LEIVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15425', 1, 'MACANAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15442', 1, 'MARIPI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15455', 1, 'MIRAFLORES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15464', 1, 'MONGUA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15466', 1, 'MONGUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15469', 1, 'MONIQUIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15476', 1, 'MOTAVITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15480', 1, 'MUZO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15491', 1, 'NOBSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15494', 1, 'NUEVO COLON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15500', 1, 'OICATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15507', 1, 'OTANCHE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15511', 1, 'PACHAVITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15514', 1, 'PAEZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15516', 1, 'PAIPA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15518', 1, 'PAJARITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15522', 1, 'PANQUEBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15531', 1, 'PAUNA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15533', 1, 'PAYA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15537', 1, 'PAZ DEL RIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15542', 1, 'PESCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15550', 1, 'PISBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15572', 1, 'PUERTO BOYACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15580', 1, 'QUIPAMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15599', 1, 'RAMIRIQUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15600', 1, 'RAQUIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15621', 1, 'RONDON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15632', 1, 'SABOYA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15638', 1, 'SACHICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15646', 1, 'SAMACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15660', 1, 'SAN EDUARDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15664', 1, 'SAN JOSE DE PARE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15667', 1, 'SAN LUIS DE GACENO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15673', 1, 'SAN MATEO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15676', 1, 'SAN MIGUEL DE SEMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15681', 1, 'SAN PABLO DE BORBUR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15686', 1, 'SANTANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15690', 1, 'SANTA MARIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15693', 1, 'SANTA ROSA DE VITERB', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15696', 1, 'SANTA SOFIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15720', 1, 'SATIVANORTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15723', 1, 'SATIVASUR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15740', 1, 'SIACHOQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15753', 1, 'SOATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15755', 1, 'SOCOTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15757', 1, 'SOCHA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15759', 1, 'SOGAMOSO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15761', 1, 'SOMONDOCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15762', 1, 'SORA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15763', 1, 'SOTAQUIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15764', 1, 'SORACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15774', 1, 'SUSACON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15776', 1, 'SUTAMARCHAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15778', 1, 'SUTATENZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15790', 1, 'TASCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15798', 1, 'TENZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15804', 1, 'TIBANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15806', 1, 'TIBASOSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15808', 1, 'TINJACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15810', 1, 'TIPACOQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15814', 1, 'TOCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15816', 1, 'TOGUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15820', 1, 'TOPAGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15822', 1, 'TOTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15832', 1, 'TUNUNGUA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15835', 1, 'TURMEQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15837', 1, 'TUTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15839', 1, 'TUTASA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15842', 1, 'UMBITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15861', 1, 'VENTAQUEMADA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15879', 1, 'VIRACACHA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('15897', 1, 'ZETAQUIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17001', 1, 'MANIZALES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17013', 1, 'AGUADAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17042', 1, 'ANSERMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17050', 1, 'ARANZAZU', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17088', 1, 'BELALCAZAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17174', 1, 'CHINCHINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17272', 1, 'FILADELFIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17380', 1, 'LA DORADA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17388', 1, 'LA MERCED', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17433', 1, 'MANZANARES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17442', 1, 'MARMATO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17444', 1, 'MARQUETALIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17446', 1, 'MARULANDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17486', 1, 'NEIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17495', 1, 'NORCASIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17513', 1, 'PACORA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17524', 1, 'PALESTINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17541', 1, 'PENSILVANIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17614', 1, 'RIOSUCIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17616', 1, 'RISARALDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17653', 1, 'SALAMINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17662', 1, 'SAMANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17665', 1, 'SAN JOSE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17777', 1, 'SUPIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17867', 1, 'VICTORIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17873', 1, 'VILLAMARIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('17877', 1, 'VITERBO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18001', 1, 'FLORENCIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18029', 1, 'ALBANIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18094', 1, 'BELEN DE LOS ANDAQUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18150', 1, 'CARTAGENA DEL CHAIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18205', 1, 'CURILLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18247', 1, 'EL DONCELLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18256', 1, 'EL PAUJIL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18410', 1, 'LA MONTA�ITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18460', 1, 'MILAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18479', 1, 'MORELIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18592', 1, 'PUERTO RICO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18610', 1, 'SAN JOSE DE FRAGUA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18753', 1, 'SAN  VICENTE DEL CAG', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18756', 1, 'SOLANO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18785', 1, 'SOLITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('18860', 1, 'VALPARAISO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19001', 1, 'POPAYAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19022', 1, 'ALMAGUER', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19050', 1, 'ARGELIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19075', 1, 'BALBOA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19100', 1, 'BOLIVAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19110', 1, 'BUENOS AIRES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19130', 1, 'CAJIBIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19137', 1, 'CALDONO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19142', 1, 'CALOTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19212', 1, 'CORINTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19256', 1, 'EL TAMBO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19290', 1, 'FLORENCIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19318', 1, 'GUAPI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19355', 1, 'INZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19364', 1, 'JAMBALO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19392', 1, 'LA SIERRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19397', 1, 'LA VEGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19418', 1, 'LOPEZ (MICAY)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19450', 1, 'MERCADERES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19455', 1, 'MIRANDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19473', 1, 'MORALES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19513', 1, 'PADILLA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19517', 1, 'PAEZ (BELALCAZAR)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19532', 1, 'PATIA (EL BORDO)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19533', 1, 'PIAMONTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19548', 1, 'PIENDAMO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19573', 1, 'PUERTO TEJADA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19585', 1, 'PURACE (COCONUCO)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19622', 1, 'ROSAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19693', 1, 'SAN SEBASTIAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19698', 1, 'SANTANDER DE QUILICH', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19701', 1, 'SANTA ROSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19743', 1, 'SILVIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19760', 1, 'SOTARA (PAISPAMBA)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19780', 1, 'SUAREZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19807', 1, 'TIMBIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19809', 1, 'TIMBIQUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19821', 1, 'TORIBIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19824', 1, 'TOTORO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('19845', 1, 'VILLARICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20001', 1, 'VALLEDUPAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20011', 1, 'AGUACHICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20013', 1, 'AGUSTIN CODAZZI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20032', 1, 'ASTREA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20045', 1, 'BECERRIL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20060', 1, 'BOSCONIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20175', 1, 'CHIMICHAGUA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20178', 1, 'CHIRIGUANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20228', 1, 'CURUMANI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20238', 1, 'EL COPEY', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20250', 1, 'EL PASO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20295', 1, 'GAMARRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20310', 1, 'GONZALEZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20383', 1, 'LA GLORIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20400', 1, 'LA JAGUA IBIRICO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20443', 1, 'MANAURE (BALCON DEL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20517', 1, 'PAILITAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20550', 1, 'PELAYA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20570', 1, 'PUEBLO BELLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20614', 1, 'RIO DE ORO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20621', 1, 'LA PAZ (ROBLES)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20710', 1, 'SAN ALBERTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20750', 1, 'SAN DIEGO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20770', 1, 'SAN MARTIN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('20787', 1, 'TAMALAMEQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23001', 1, 'MONTERIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23068', 1, 'AYAPEL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23079', 1, 'BUENAVISTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23090', 1, 'CANALETE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23162', 1, 'CERETE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23168', 1, 'CHIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23182', 1, 'CHINU', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23189', 1, 'CIENAGA DE ORO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23300', 1, 'COTORRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23350', 1, 'LA APARTADA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23417', 1, 'LORICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23419', 1, 'LOS CORDOBAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23464', 1, 'MOMIL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23466', 1, 'MONTELIBANO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23500', 1, 'MO�ITOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23555', 1, 'PLANETA RICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23570', 1, 'PUEBLO NUEVO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23574', 1, 'PUERTO ESCONDIDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23580', 1, 'PUERTO LIBERTADOR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23586', 1, 'PURISIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23660', 1, 'SAHAGUN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23670', 1, 'SAN ANDRES SOTAVENTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23672', 1, 'SAN ANTERO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23675', 1, 'SAN BERNARDO DEL VIE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23678', 1, 'SAN CARLOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23686', 1, 'SAN PELAYO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23807', 1, 'TIERRALTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('23855', 1, 'VALENCIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25001', 1, 'AGUA DE DIOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25019', 1, 'ALBAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25035', 1, 'ANAPOIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25040', 1, 'ANOLAIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25053', 1, 'ARBELAEZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25086', 1, 'BELTRAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25095', 1, 'BITUIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25099', 1, 'BOJACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25120', 1, 'CABRERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25123', 1, 'CACHIPAY', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25126', 1, 'CAJICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25148', 1, 'CAPARRAPI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25151', 1, 'CAQUEZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25154', 1, 'CARMEN DE CARUPA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25168', 1, 'CHAGUANI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25175', 1, 'CHIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25178', 1, 'CHIPAQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25181', 1, 'CHOACHI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25183', 1, 'CHOCONTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25200', 1, 'COGUA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25214', 1, 'COTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25224', 1, 'CUCUNUBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25245', 1, 'EL COLEGIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25258', 1, 'EL PE�ON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25260', 1, 'EL ROSAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25269', 1, 'FACATATIVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25279', 1, 'FOMEQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25281', 1, 'FOSCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25286', 1, 'FUNZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25288', 1, 'FUQUENE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25290', 1, 'FUSAGASUGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25293', 1, 'GACHALA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25295', 1, 'GACHANCIPA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25297', 1, 'GACHETA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25299', 1, 'GAMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25307', 1, 'GIRARDOT', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25312', 1, 'GRANADA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25317', 1, 'GUACHETA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25320', 1, 'GUADUAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25322', 1, 'GUASCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25324', 1, 'GUATAQUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25326', 1, 'GUATAVITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25328', 1, 'GUAYABAL DE SIQUIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25335', 1, 'GUAYABETAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25339', 1, 'GUTIERREZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25368', 1, 'JERUSALEN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25372', 1, 'JUNIN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25377', 1, 'LA CALERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25386', 1, 'LA MESA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25394', 1, 'LA PALMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25398', 1, 'LA PE�A', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25402', 1, 'LA VEGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25407', 1, 'LENGUAZAQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25426', 1, 'MACHETA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25430', 1, 'MADRID', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25436', 1, 'MANTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25438', 1, 'MEDINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25473', 1, 'MOSQUERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25483', 1, 'NARI�O', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25486', 1, 'NEMOCON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25488', 1, 'NILO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25489', 1, 'NIMAIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25491', 1, 'NOCAIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25506', 1, 'VENECIA (OSPINA PERE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25513', 1, 'PACHO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25518', 1, 'PAIME', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25524', 1, 'PANDI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25530', 1, 'PARATEBUENO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25535', 1, 'PASCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25572', 1, 'PUERTO SALGAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25580', 1, 'PULI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25592', 1, 'QUEBRADANEGRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25594', 1, 'QUETAME', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25596', 1, 'QUIPILE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25599', 1, 'APULO (RAFAEL REYES)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25612', 1, 'RICAURTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25645', 1, 'SAN  ANTONIO DEL  TE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25649', 1, 'SAN BERNARDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25653', 1, 'SAN CAYETANO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25658', 1, 'SAN FRANCISCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25662', 1, 'SAN JUAN DE RIOSECO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25718', 1, 'SASAIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25736', 1, 'SESQUILE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25740', 1, 'SIBATE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25743', 1, 'SILVANIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25745', 1, 'SIMIJACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25754', 1, 'SOACHA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25758', 1, 'SOPO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25769', 1, 'SUBACHOQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25772', 1, 'SUESCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25777', 1, 'SUPATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25779', 1, 'SUSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25781', 1, 'SUTATAUSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25785', 1, 'TABIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25793', 1, 'TAUSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25797', 1, 'TENA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25799', 1, 'TENJO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25805', 1, 'TIBACUY', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25807', 1, 'TIBIRITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25815', 1, 'TOCAIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25817', 1, 'TOCANCIPA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25823', 1, 'TOPAIPI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25839', 1, 'UBALA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25841', 1, 'UBAQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25843', 1, 'UBATE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25845', 1, 'UNE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25851', 1, 'UTICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25862', 1, 'VERGARA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25867', 1, 'VIANI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25871', 1, 'VILLAGOMEZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25873', 1, 'VILLAPINZON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25875', 1, 'VILLETA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25878', 1, 'VIOTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25885', 1, 'YACOPI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25898', 1, 'ZIPACON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('25899', 1, 'ZIPAQUIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27001', 1, 'QUIBDO (SAN FRANCISC', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27006', 1, 'ACANDI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27025', 1, 'ALTO BAUDO (PIE DE P', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27050', 1, 'ATRATO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27073', 1, 'BAGADO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27075', 1, 'BAHIA SOLANO (MUTIS)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27077', 1, 'BAJO BAUDO (PIZARRO)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27099', 1, 'BOJAYA (BELLAVISTA)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27135', 1, 'CANTON DE SAN PABLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27205', 1, 'CONDOTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27245', 1, 'EL CARMEN DE ATRATO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27250', 1, 'LITORAL DEL BAJO SAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27361', 1, 'ISTMINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27372', 1, 'JURADO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27413', 1, 'LLORO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27425', 1, 'MEDIO ATRATO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27430', 1, 'MEDIO BAUDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27491', 1, 'NOVITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27495', 1, 'NUQUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27600', 1, 'RIOQUITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27615', 1, 'RIOSUCIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27660', 1, 'SAN JOSE DEL PALMAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27745', 1, 'SIPI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27787', 1, 'TADO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27800', 1, 'UNGUIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('27810', 1, 'UNION PANAMERICANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41001', 1, 'NEIVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41006', 1, 'ACEVEDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41013', 1, 'AGRADO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41016', 1, 'AIPE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41020', 1, 'ALGECIRAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41026', 1, 'ALTAMIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41078', 1, 'BARAYA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41132', 1, 'CAMPOALEGRE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41206', 1, 'COLOMBIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41244', 1, 'ELIAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41298', 1, 'GARZON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41306', 1, 'GIGANTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41319', 1, 'GUADALUPE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41349', 1, 'HOBO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41357', 1, 'IQUIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41359', 1, 'ISNOS (SAN JOSE DE I', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41378', 1, 'LA ARGENTINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41396', 1, 'LA PLATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41483', 1, 'NATAGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41503', 1, 'OPORAPA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41518', 1, 'PAICOL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41524', 1, 'PALERMO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41530', 1, 'PALESTINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41548', 1, 'PITAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41551', 1, 'PITALITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41615', 1, 'RIVERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41660', 1, 'SALADOBLANCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41668', 1, 'SAN AGUSTIN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41676', 1, 'SANTA MARIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41770', 1, 'SUAZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41791', 1, 'TARQUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41797', 1, 'TESALIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41799', 1, 'TELLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41801', 1, 'TERUEL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41807', 1, 'TIMANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41872', 1, 'VILLAVIEJA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('41885', 1, 'YAGUARA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44001', 1, 'RIOHACHA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44078', 1, 'BARRANCAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44090', 1, 'DIBULLA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44098', 1, 'DISTRACCION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44110', 1, 'EL MOLINO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44279', 1, 'FONSECA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44378', 1, 'HATONUEVO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44420', 1, 'LA JAGUA DEL PILAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44430', 1, 'MAICAO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44560', 1, 'MANAURE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44650', 1, 'SAN JUAN DEL CESAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44847', 1, 'URIBIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44855', 1, 'URUMITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('44874', 1, 'VILLANUEVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47001', 1, 'SANTA MARTA (DISTRIT', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47030', 1, 'ALGARROBO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47053', 1, 'ARACATACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47058', 1, 'ARIGUANI (EL DIFICIL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47161', 1, 'CERRO SAN ANTONIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47170', 1, 'CHIVOLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47189', 1, 'CIENAGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47205', 1, 'CONCORDIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47245', 1, 'EL BANCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47258', 1, 'EL PI�ON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47268', 1, 'EL RETEN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47288', 1, 'FUNDACION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47318', 1, 'GUAMAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47541', 1, 'PEDRAZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47545', 1, 'PIJI�O DEL CARMEN (P', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47551', 1, 'PIVIJAY', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47555', 1, 'PLATO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47570', 1, 'PUEBLOVIEJO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47605', 1, 'REMOLINO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47660', 1, 'SABANAS DE SAN ANGEL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47675', 1, 'SALAMINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47692', 1, 'SAN SEBASTIAN DE BUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47703', 1, 'SAN ZENON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47707', 1, 'SANTA ANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47745', 1, 'SITIONUEVO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('47798', 1, 'TENERIFE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50001', 1, 'VILLAVICENCIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50006', 1, 'ACACIAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50110', 1, 'BARRANCA DE UPIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50124', 1, 'CABUYARO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50150', 1, 'CASTILLA LA NUEVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50223', 1, 'SAN LUIS DE CUBARRAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50226', 1, 'CUMARAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50245', 1, 'EL CALVARIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50251', 1, 'EL CASTILLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50270', 1, 'EL DORADO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50287', 1, 'FUENTE DE ORO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50313', 1, 'GRANADA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50318', 1, 'GUAMAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50325', 1, 'MAPIRIPAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50330', 1, 'MESETAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50350', 1, 'LA MACARENA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50370', 1, 'LA URIBE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50400', 1, 'LEJANIAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50450', 1, 'PUERTO CONCORDIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50568', 1, 'PUERTO GAITAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50573', 1, 'PUERTO LOPEZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50577', 1, 'PUERTO LLERAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50590', 1, 'PUERTO RICO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50606', 1, 'RESTREPO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50680', 1, 'SAN CARLOS DE GUAROA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50683', 1, 'SAN  JUAN DE ARAMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50686', 1, 'SAN JUANITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50689', 1, 'SAN MARTIN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('50711', 1, 'VISTAHERMOSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52001', 1, 'PASTO (SAN JUAN DE P', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52019', 1, 'ALBAN (SAN JOSE)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52022', 1, 'ALDANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52036', 1, 'ANCUYA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52051', 1, 'ARBOLEDA (BERRUECOS)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52079', 1, 'BARBACOAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52083', 1, 'BELEN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52110', 1, 'BUESACO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52203', 1, 'COLON (GENOVA)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52207', 1, 'CONSACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52210', 1, 'CONTADERO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52215', 1, 'CORDOBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52224', 1, 'CUASPUD (CARLOSAMA)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52227', 1, 'CUMBAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52233', 1, 'CUMBITARA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52240', 1, 'CHACHAGUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52250', 1, 'EL CHARCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52254', 1, 'EL PE�OL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52256', 1, 'EL ROSARIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52258', 1, 'EL TABLON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52260', 1, 'EL TAMBO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52287', 1, 'FUNES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52317', 1, 'GUACHUCAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52320', 1, 'GUAITARILLA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52323', 1, 'GUALMATAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52352', 1, 'ILES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52354', 1, 'IMUES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52356', 1, 'IPIALES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52378', 1, 'LA CRUZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52381', 1, 'LA FLORIDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52385', 1, 'LA LLANADA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52390', 1, 'LA TOLA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52399', 1, 'LA UNION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52405', 1, 'LEIVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52411', 1, 'LINARES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52418', 1, 'LOS ANDES (SOTOMAYOR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52427', 1, 'MAGUI (PAYAN)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52435', 1, 'MALLAMA (PIEDRANCHA)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52473', 1, 'MOSQUERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52490', 1, 'OLAYA HERRERA (BOCAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52506', 1, 'OSPINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52520', 1, 'FRANCISCO PIZARRO (S', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52540', 1, 'POLICARPA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52560', 1, 'POTOSI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52565', 1, 'PROVIDENCIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52573', 1, 'PUERRES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52585', 1, 'PUPIALES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52612', 1, 'RICAURTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52621', 1, 'ROBERTO PAYAN (SAN J', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52678', 1, 'SAMANIEGO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52683', 1, 'SANDONA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52685', 1, 'SAN BERNARDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52687', 1, 'SAN LORENZO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52693', 1, 'SAN PABLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52694', 1, 'SAN PEDRO DE CARTAGO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52696', 1, 'SANTA BARBARA (ISCUA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52699', 1, 'SANTA CRUZ (GUACHAVE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52720', 1, 'SAPUYES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52786', 1, 'TAMINANGO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52788', 1, 'TANGUA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52835', 1, 'TUMACO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52838', 1, 'TUQUERRES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('52885', 1, 'YACUANQUER', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54001', 1, 'CUCUTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54003', 1, 'ABREGO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54051', 1, 'ARBOLEDAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54099', 1, 'BOCHALEMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54109', 1, 'BUCARASICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54125', 1, 'CACOTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54128', 1, 'CACHIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54172', 1, 'CHINACOTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54174', 1, 'CHITAGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54206', 1, 'CONVENCION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54223', 1, 'CUCUTILLA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54239', 1, 'DURANIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54245', 1, 'EL CARMEN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54250', 1, 'EL TARRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54261', 1, 'EL ZULIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54313', 1, 'GRAMALOTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54344', 1, 'HACARI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54347', 1, 'HERRAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54377', 1, 'LABATECA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54385', 1, 'LA ESPERANZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54398', 1, 'LA PLAYA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54405', 1, 'LOS PATIOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54418', 1, 'LOURDES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54480', 1, 'MUTISCUA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54498', 1, 'OCA�A', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54518', 1, 'PAMPLONA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54520', 1, 'PAMPLONITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54553', 1, 'PUERTO SANTANDER', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54599', 1, 'RAGONVALIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54660', 1, 'SALAZAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54670', 1, 'SAN CALIXTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54673', 1, 'SAN CAYETANO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54680', 1, 'SANTIAGO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54720', 1, 'SARDINATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54743', 1, 'SILOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54800', 1, 'TEORAMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54810', 1, 'TIBU', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54820', 1, 'TOLEDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54871', 1, 'VILLACARO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('54874', 1, 'VILLA DEL ROSARIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63001', 1, 'ARMENIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63111', 1, 'BUENAVISTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63130', 1, 'CALARCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63190', 1, 'CIRCASIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63212', 1, 'CORDOBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63272', 1, 'FILANDIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63302', 1, 'GENOVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63401', 1, 'LA TEBAIDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63470', 1, 'MONTENEGRO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63548', 1, 'PIJAO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63594', 1, 'QUIMBAYA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('63690', 1, 'SALENTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66001', 1, 'PEREIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66045', 1, 'APIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66075', 1, 'BALBOA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66088', 1, 'BELEN DE UMBRIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66170', 1, 'DOS QUEBRADAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66318', 1, 'GUATICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66383', 1, 'LA CELIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66400', 1, 'LA VIRGINIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66440', 1, 'MARSELLA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66456', 1, 'MISTRATO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66572', 1, 'PUEBLO RICO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66594', 1, 'QUINCHIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66682', 1, 'SANTA ROSA DE CABAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('66687', 1, 'SANTUARIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68001', 1, 'BUCARAMANGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68013', 1, 'AGUADA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68020', 1, 'ALBANIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68051', 1, 'ARATOCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68077', 1, 'BARBOSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68079', 1, 'BARICHARA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68081', 1, 'BARRANCABERMEJA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68092', 1, 'BETULIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68101', 1, 'BOLIVAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68121', 1, 'CABRERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68132', 1, 'CALIFORNIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68147', 1, 'CAPITANEJO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68152', 1, 'CARCASI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68160', 1, 'CEPITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68162', 1, 'CERRITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68167', 1, 'CHARALA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68169', 1, 'CHARTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68176', 1, 'CHIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68179', 1, 'CHIPATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68190', 1, 'CIMITARRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68207', 1, 'CONCEPCION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68209', 1, 'CONFINES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68211', 1, 'CONTRATACION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68217', 1, 'COROMORO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68229', 1, 'CURITI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68235', 1, 'EL CARMEN DE CHUCURY', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68245', 1, 'EL GUACAMAYO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68250', 1, 'EL PE�ON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68255', 1, 'EL PLAYON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68264', 1, 'ENCINO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68266', 1, 'ENCISO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68271', 1, 'FLORIAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68276', 1, 'FLORIDABLANCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68296', 1, 'GALAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68298', 1, 'GAMBITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68307', 1, 'GIRON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68318', 1, 'GUACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68320', 1, 'GUADALUPE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68322', 1, 'GUAPOTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68324', 1, 'GUAVATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68327', 1, 'GUEPSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68344', 1, 'HATO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68368', 1, 'JESUS MARIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68370', 1, 'JORDAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68377', 1, 'LA BELLEZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68385', 1, 'LANDAZURI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68397', 1, 'LA PAZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68406', 1, 'LEBRIJA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68418', 1, 'LOS SANTOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68425', 1, 'MACARAVITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68432', 1, 'MALAGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68444', 1, 'MATANZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68464', 1, 'MOGOTES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68468', 1, 'MOLAGAVITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68498', 1, 'OCAMONTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68500', 1, 'OIBA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68502', 1, 'ONZAGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68522', 1, 'PALMAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68524', 1, 'PALMAS DEL SOCORRO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68533', 1, 'PARAMO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68547', 1, 'PIEDECUESTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68549', 1, 'PINCHOTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68572', 1, 'PUENTE NACIONAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68573', 1, 'PUERTO PARRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68575', 1, 'PUERTO WILCHES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68615', 1, 'RIONEGRO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68655', 1, 'SABANA DE TORRES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68669', 1, 'SAN ANDRES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68673', 1, 'SAN BENITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68679', 1, 'SAN GIL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68682', 1, 'SAN JOAQUIN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68684', 1, 'SAN JOSE DE MIRANDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68686', 1, 'SAN MIGUEL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68689', 1, 'SAN VICENTE DE CHUCU', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68705', 1, 'SANTA BARBARA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68720', 1, 'SANTA HELENA DEL OPO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68745', 1, 'SIMACOTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68755', 1, 'SOCORRO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68770', 1, 'SUAITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68773', 1, 'SUCRE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68780', 1, 'SURATA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68820', 1, 'TONA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68855', 1, 'VALLE SAN JOSE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68861', 1, 'VELEZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68867', 1, 'VETAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68872', 1, 'VILLANUEVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('68895', 1, 'ZAPATOCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70001', 1, 'SINCELEJO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70110', 1, 'BUENAVISTA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70124', 1, 'CAIMITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70204', 1, 'COLOSO (RICAURTE)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70215', 1, 'COROZAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70230', 1, 'CHALAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70235', 1, 'GALERAS (NUEVA GRANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70265', 1, 'GUARANDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70400', 1, 'LA UNION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70418', 1, 'LOS PALMITOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70429', 1, 'MAJAGUAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70473', 1, 'MORROA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70508', 1, 'OVEJAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70523', 1, 'PALMITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70670', 1, 'SAMPUES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70678', 1, 'SAN BENITO ABAD', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70702', 1, 'SAN JUAN DE BETULIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70708', 1, 'SAN MARCOS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70713', 1, 'SAN ONOFRE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70717', 1, 'SAN PEDRO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70742', 1, 'SINCE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70771', 1, 'SUCRE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70820', 1, 'TOLU', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('70823', 1, 'TOLUVIEJO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73001', 1, 'IBAGUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73024', 1, 'ALPUJARRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73026', 1, 'ALVARADO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73030', 1, 'AMBALEMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73043', 1, 'ANZOATEGUI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73055', 1, 'ARMERO (GUAYABAL)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73067', 1, 'ATACO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73124', 1, 'CAJAMARCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73148', 1, 'CARMEN APICALA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73152', 1, 'CASABIANCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73168', 1, 'CHAPARRAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73200', 1, 'COELLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73217', 1, 'COYAIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73226', 1, 'CUNDAY', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73236', 1, 'DOLORES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73268', 1, 'ESPINAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73270', 1, 'FALAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73275', 1, 'FLANDES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73283', 1, 'FRESNO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73319', 1, 'GUAMO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73347', 1, 'HERVEO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73349', 1, 'HONDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73352', 1, 'ICONONZO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73408', 1, 'LERIDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73411', 1, 'LIBANO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73443', 1, 'MARIQUITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73449', 1, 'MELGAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73461', 1, 'MURILLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73483', 1, 'NATAGAIMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73504', 1, 'ORTEGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73520', 1, 'PALOCABILDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73547', 1, 'PIEDRAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73555', 1, 'PLANADAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73563', 1, 'PRADO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73585', 1, 'PURIFICACION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73616', 1, 'RIOBLANCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73622', 1, 'RONCESVALLES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73624', 1, 'ROVIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73671', 1, 'SALDA�A', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73675', 1, 'SAN ANTONIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73678', 1, 'SAN LUIS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73686', 1, 'SANTA ISABEL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73770', 1, 'SUAREZ', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73854', 1, 'VALLE DE SAN JUAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73861', 1, 'VENADILLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73870', 1, 'VILLAHERMOSA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('73873', 1, 'VILLARRICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76001', 1, 'CALI (SANTIAGO DE CA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76020', 1, 'ALCALA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76036', 1, 'ANDALUCIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76041', 1, 'ANSERMANUEVO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76054', 1, 'ARGELIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76100', 1, 'BOLIVAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76109', 1, 'BUENAVENTURA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76111', 1, 'BUGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76113', 1, 'BUGALAGRANDE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76122', 1, 'CAICEDONIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76126', 1, 'CALIMA (DARIEN)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76130', 1, 'CANDELARIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76147', 1, 'CARTAGO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76233', 1, 'DAGUA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76243', 1, 'EL AGUILA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76246', 1, 'EL CAIRO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76248', 1, 'EL CERRITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76250', 1, 'EL DOVIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76275', 1, 'FLORIDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76306', 1, 'GINEBRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76318', 1, 'GUACARI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76364', 1, 'JAMUNDI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76377', 1, 'LA CUMBRE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76400', 1, 'LA UNION', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76403', 1, 'LA VICTORIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76497', 1, 'OBANDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76520', 1, 'PALMIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76563', 1, 'PRADERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76606', 1, 'RESTREPO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76616', 1, 'RIOFRIO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76622', 1, 'ROLDANILLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76670', 1, 'SAN PEDRO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76736', 1, 'SEVILLA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76823', 1, 'TORO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76828', 1, 'TRUJILLO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76834', 1, 'TULUA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76845', 1, 'ULLOA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76863', 1, 'VERSALLES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76869', 1, 'VIJES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76890', 1, 'YOTOCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76892', 1, 'YUMBO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('76895', 1, 'ZARZAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('81001', 1, 'ARAUCA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('81065', 1, 'ARAUQUITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('81220', 1, 'CRAVO NORTE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('81300', 1, 'FORTUL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('81591', 1, 'PUERTO RONDON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('81736', 1, 'SARAVENA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('81794', 1, 'TAME', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85001', 1, 'YOPAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85010', 1, 'AGUAZUL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85015', 1, 'CHAMEZA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85125', 1, 'HATO COROZAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85136', 1, 'LA SALINA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85139', 1, 'MANI', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85162', 1, 'MONTERREY', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85225', 1, 'NUNCHIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85230', 1, 'OROCUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85250', 1, 'PAZ DE ARIPORO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85263', 1, 'PORE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85279', 1, 'RECETOR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85300', 1, 'SABANALARGA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85315', 1, 'SACAMA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85325', 1, 'SAN LUIS DE PALENQUE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85400', 1, 'TAMARA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85410', 1, 'TAURAMENA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85430', 1, 'TRINIDAD', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('85440', 1, 'VILLANUEVA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86001', 1, 'MOCOA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86219', 1, 'COLON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86320', 1, 'ORITO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86568', 1, 'PUERTO ASIS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86569', 1, 'PUERTO CAICEDO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86571', 1, 'PUERTO GUZMAN', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86573', 1, 'PUERTO LEGUIZAMO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86749', 1, 'SIBUNDOY', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86755', 1, 'SAN FRANCISCO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86757', 1, 'SAN MIGUEL (LA DORAD', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86760', 1, 'SANTIAGO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86865', 1, 'LA HORMIGA (VALLE DE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('86885', 1, 'VILLAGARZON', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('88001', 1, 'SAN ANDRES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('88564', 1, 'PROVIDENCIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91001', 1, 'LETICIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91263', 1, 'EL ENCANTO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91405', 1, 'LA CHORRERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91407', 1, 'LA PEDRERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91430', 1, 'LA VICTORIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91460', 1, 'MIRITI-PARANA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91530', 1, 'PUERTO ALEGRIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91536', 1, 'PUERTO ARICA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91540', 1, 'PUERTO NARI�O', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91669', 1, 'PUERTO SANTANDER', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('91798', 1, 'TARAPACA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('94001', 1, 'PUERTO INIRIDA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('94343', 1, 'BARRANCO MINAS', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('94883', 1, 'SAN FELIPE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('94884', 1, 'PUERTO COLOMBIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('94885', 1, 'LA GUADALUPE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('94886', 1, 'CACAHUAL', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('94887', 1, 'PANA PANA (CAMPO ALE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('94888', 1, 'MORICHAL (MORICHAL N', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('95001', 1, 'SAN JOSE DEL GUAVIAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('95015', 1, 'CALAMAR', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('95025', 1, 'EL RETORNO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('95200', 1, 'MIRAFLORES', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('97001', 1, 'MITU', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('97161', 1, 'CARURU', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('97511', 1, 'PACOA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('97666', 1, 'TARAIRA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('97777', 1, 'PAPUNAUA (MORICHAL)', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('97889', 1, 'YAVARATE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('99001', 1, 'PUERTO CARRE�O', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('99524', 1, 'LA PRIMAVERA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('99572', 1, 'SANTA RITA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('99666', 1, 'SANTA ROSALIA', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('99760', 1, 'SAN JOSE DE OCUNE', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
insert into ciudad (codigo, EstadoID, descripcion, eliminado, fechacreacion, fechamodificacion) values('99773', 1, 'CUMARIBO', 0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);