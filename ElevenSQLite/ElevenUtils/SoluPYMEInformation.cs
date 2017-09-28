/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 1:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of SoluPYMEInformation.
	/// </summary>
	public class SoluPYMEInformation
	{
		private struct SYSTEM_INFO
		{
			public short wProcessorArchitecture;

			public short wReserved;

			public int dwPageSize;

			public IntPtr lpMinimumApplicationAddress;

			public IntPtr lpMaximumApplicationAddress;

			public IntPtr dwActiveProcessorMask;

			public int dwNumberOfProcessors;

			public int dwProcessorType;

			public int dwAllocationGranularity;

			public short wProcessorLevel;

			public short wProcessorRevision;
		}

		private const int PROCESSOR_ARCHITECTURE_AMD64 = 9;

		private const int PROCESSOR_ARCHITECTURE_IA64 = 6;

		private const int PROCESSOR_ARCHITECTURE_INTEL = 0;

		public static string PlatformName {
			get {
				return Environment.OSVersion.ToString();
			}
		}

		public static string PathExecutable {
			get {
				return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			}
			set {
				SoluPYMEInformation.PathExecutable = value;
			}
		}

		public static bool DebugMode {
			get {
				string value = (ConfigurationManager.AppSettings["DebugMode"] == null) ? "FALSE" : ConfigurationManager.AppSettings["DebugMode"];
				return Convert.ToBoolean(value);
			}
			set {
				SoluPYMEInformation.DebugMode = value;
			}
		}

		public static string ProcessorArchitecture {
			get {
				SoluPYMEInformation.SYSTEM_INFO sYSTEM_INFO = default(SoluPYMEInformation.SYSTEM_INFO);
				SoluPYMEInformation.GetNativeSystemInfo(ref sYSTEM_INFO);
				short wProcessorArchitecture = sYSTEM_INFO.wProcessorArchitecture;
				if (wProcessorArchitecture == 0) {
					return "X86";
				}
				if (wProcessorArchitecture == 6) {
					return "X64";
				}
				if (wProcessorArchitecture == 9) {
					return "X64";
				}
				return "None";
			}
		}

		[DllImport("kernel32.dll")]
		private static extern void GetNativeSystemInfo(ref SoluPYMEInformation.SYSTEM_INFO lpSystemInfo);
	}
}
