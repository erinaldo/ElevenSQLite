/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 1:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using log4net;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Permissions;
using System.Text;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of Util.
	/// </summary>
	public class Util
	{
		private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public static bool IsNetfx35Installed()
		{
			return Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\NET Framework Setup\\NDP\\v3.5", false) != null;
		}

		public static bool IsNetfx40Installed()
		{
			string versionFromRegistry = Util.GetVersionFromRegistry();
			Util.log.Debug(versionFromRegistry);
			return versionFromRegistry.Contains("v4.0");
		}

		public static bool IsNetfx45Installed()
		{
			string versionFromRegistry = Util.GetVersionFromRegistry();
			Util.log.Debug(versionFromRegistry);
			return versionFromRegistry.Contains("v4");
		}

		public static bool IsNetfx45or451Installed()
		{
			bool result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\")) {
				int releaseKey = Convert.ToInt32(registryKey.GetValue("Release"));
				result = Util.CheckFor45DotVersion(releaseKey);
			}
			return result;
		}

		private static bool CheckFor45DotVersion(int releaseKey)
		{
			return releaseKey >= 379893 || releaseKey >= 378675 || releaseKey >= 378389;
		}

		public static string GetVersionFromRegistry()
		{
			StringBuilder stringBuilder = new StringBuilder();
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\NET Framework Setup\\NDP", false);
			string[] subKeyNames = registryKey.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++) {
				string text = subKeyNames[i];
				if (text.StartsWith("v")) {
					RegistryKey registryKey2 = registryKey.OpenSubKey(text);
					string text2 = (string)registryKey2.GetValue("Version", "");
					string text3 = registryKey2.GetValue("SP", "").ToString();
					string a = registryKey2.GetValue("Install", "").ToString();
					if (a == "") {
						stringBuilder.AppendLine(text + "  " + text2);
					}
					else {
						if (text3 != "" && a == "1") {
							stringBuilder.AppendLine(string.Concat(new string[] {
								text,
								"  ",
								text2,
								"  SP",
								text3
							}));
						}
					}
					if (!(text2 != "")) {
						string[] subKeyNames2 = registryKey2.GetSubKeyNames();
						for (int j = 0; j < subKeyNames2.Length; j++) {
							string text4 = subKeyNames2[j];
							RegistryKey registryKey3 = registryKey2.OpenSubKey(text4);
							text2 = (string)registryKey3.GetValue("Version", "");
							if (text2 != "") {
								text3 = registryKey3.GetValue("SP", "").ToString();
							}
							a = registryKey3.GetValue("Install", "").ToString();
							if (a == "") {
								stringBuilder.AppendLine(text + "  " + text2);
							}
							else {
								if (text3 != "" && a == "1") {
									stringBuilder.AppendLine(string.Concat(new string[] {
										"  ",
										text4,
										"  ",
										text2,
										"  SP",
										text3
									}));
								}
								else {
									if (a == "1") {
										stringBuilder.AppendLine("  " + text4 + "  " + text2);
									}
								}
							}
						}
					}
				}
			}
			return stringBuilder.ToString();
		}

		public static bool IsLicencia(string unNit, string serial)
		{
			int num = Util.sumarTodosDigitos(unNit);
			int num2 = Util.calculoDigitoVerificacion(unNit);
			int value = (num + num2) * 3;
			int value2 = Convert.ToInt32(unNit[1]) * num2;
			int value3 = Convert.ToInt32(Util.voltear(Convert.ToString(num) + Convert.ToString(num2)));
			int value4 = (num2 != 0) ? (num % num2) : 82;
			string text = string.Concat(new string[] {
				Convert.ToString(value3),
				Convert.ToString(num2),
				Convert.ToString(value),
				Convert.ToString(value4),
				Convert.ToString(num),
				Convert.ToString(value2)
			});
			return text.Equals(serial);
		}

		public static string[] Split(string cadena, int tamanoCadena)
		{
			if (cadena.Length <= tamanoCadena) {
				return new string[] {
					cadena
				};
			}
			List<string> list = new List<string>();
			string[] array = cadena.Split(new char[] {
				' '
			});
			int num = 0;
			string text = "";
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++) {
				string text2 = array2[i];
				num += text2.Length;
				if (num > tamanoCadena) {
					list.Add(text);
					text = "";
					num = text2.Length;
				}
				text = text + text2 + " ";
			}
			list.Add(text);
			return list.ToArray();
		}

		public static string voltear(string concat)
		{
			string text = "";
			for (int i = concat.Length; i > 0; i--) {
				text += concat[i - 1];
			}
			return text;
		}

		public static int sumarTodosDigitos(string unNit)
		{
			int num = 0;
			for (int i = 0; i < unNit.Length; i++) {
				num += Convert.ToInt32(unNit[i]);
			}
			return num;
		}

		public static string RetornarNIT(string sNit)
		{
			string text = string.Empty;
			string text2 = sNit;
			if (sNit.IndexOf('-') != -1) {
				text2 = sNit.Split(new char[] {
					'-'
				})[0];
			}
			for (int i = 0; i < text2.Length; i++) {
				if (char.IsNumber(text2[i])) {
					text += text2[i];
				}
			}
			return text;
		}

		public static int calculoDigitoVerificacion(string unNit)
		{
			int[] array = new int[] {
				3,
				7,
				13,
				17,
				19,
				23,
				29,
				37,
				41,
				43,
				47,
				53,
				59,
				67,
				71
			};
			int num = 0;
			for (int i = 0; i < unNit.Length; i++) {
				string value = unNit[unNit.Length - 1 - i].ToString();
				num += Convert.ToInt32(value) * array[i];
			}
			int num2 = num % 11;
			if (num2 > 1) {
				return Convert.ToInt32(11 - num2);
			}
			return num2;
		}

		[EnvironmentPermission(SecurityAction.LinkDemand, Unrestricted = true)]
		public static void EnviarEstadistica()
		{
			try {
				string[] value = new string[] {
					"MachineName=" + Uri.EscapeUriString(Environment.MachineName),
					"SO=" + Uri.EscapeUriString(SoluPYMEInformation.PlatformName),
					"Runtime=" + Uri.EscapeUriString(Util.GetVersionFromRegistry()),
					"Compile=" + Uri.EscapeUriString(Entorno.VERSION_COMPILACION),
					"Version=" + Uri.EscapeUriString(Util.Version()),
					"BuildDate=" + Uri.EscapeUriString(Util.BuildDate().ToString())
				};
				WebRequest webRequest = WebRequest.Create(new Uri("http://www.solupyme.com/stats.php"));
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.Method = "POST";
				byte[] bytes = Encoding.Default.GetBytes(string.Join("&", value));
				webRequest.ContentLength = (long)bytes.Length;
				using (Stream requestStream = webRequest.GetRequestStream()) {
					requestStream.Write(bytes, 0, bytes.Length);
					requestStream.Close();
				}
			}
			catch {
			}
		}

		[EnvironmentPermission(SecurityAction.LinkDemand, Unrestricted = true)]
		public static string Version()
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(SoluPYMEInformation.PathExecutable + "SoluPYME.exe");
			return versionInfo.ProductVersion.ToString();
		}

		public static DateTime BuildDate()
		{
			FileInfo fileInfo = new FileInfo(Assembly.GetExecutingAssembly().Location);
			return fileInfo.LastWriteTime;
		}

		public static bool CheckForInternetConnection(string serial)
		{
			bool result;
			try {
				if (NetworkInterface.GetIsNetworkAvailable()) {
					using (WebClient webClient = new WebClient()) {
						webClient.CachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);
						webClient.Proxy = null;
						using (webClient.OpenRead("http://www.solupyme.com/s=" + serial)) {
							result = true;
							return result;
						}
					}
				}
				result = false;
			}
			catch {
				result = false;
			}
			return result;
		}

		public static string CalcularCerosIzquierda(int p)
		{
			string text = "";
			for (int i = 0; i < p; i++) {
				text += "0";
			}
			return text;
		}
	}
}
