/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 12:57 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of Entorno.
	/// </summary>
	public class Entorno
	{
		public static Usuario USUARIO = null;
		
		public static Empresa EMPRESA = null;

		public static string RUTA = Application.StartupPath;

		public static string RUTA_DOCUMENTO = Application.StartupPath + Path.DirectorySeparatorChar + "documentos";

		public static string RUTA_COPIA_SEGURIDAD = Application.StartupPath + Path.DirectorySeparatorChar + "copiaseguridad";

		public static string RUTA_UPDATE = Application.StartupPath + Path.DirectorySeparatorChar + "update";

		public static int VERSION_DB = 211;

		public static string LICENCIA = Application.StartupPath + Path.DirectorySeparatorChar + "SOLUPYME.lic";

		public static string LOG = Application.StartupPath + Path.DirectorySeparatorChar + "log4net.db3";

		public static string BASE_DATOS = Application.StartupPath + Path.DirectorySeparatorChar + "SOLUPYME.DB";

		public static string VERSION_COMPILACION = "20170701";

		public static bool IS_VALID_LICENCE = false;

		public static bool IS_FREE_LICENCE = false;

		public static CultureInfo COLOMBIA = new CultureInfo("ES-CO");

		public static string VERSION = "2.6.1";
	}
}
