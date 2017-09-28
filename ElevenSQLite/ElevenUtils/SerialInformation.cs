/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 1:01 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of SerialInformation.
	/// </summary>
	public class SerialInformation
	{
		[DllImport("kernel32.dll")]
		private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, uint VolumeNameSize, ref uint VolumeSerialNumber, ref uint MaximumComponentLength, ref uint FileSystemFlags, StringBuilder FileSystemNameBuffer, uint FileSystemNameSize);

		public static string GetVolumeSerial(string strDriveLetter)
		{
			uint value = 0u;
			uint num = 0u;
			StringBuilder stringBuilder = new StringBuilder(256);
			uint num2 = 0u;
			StringBuilder stringBuilder2 = new StringBuilder(256);
			strDriveLetter += ":\\";
			SerialInformation.GetVolumeInformation(strDriveLetter, stringBuilder, (uint)stringBuilder.Capacity, ref value, ref num, ref num2, stringBuilder2, (uint)stringBuilder2.Capacity);
			return Convert.ToString(value);
		}

		[DllImport("mscoree.dll")]
		public static extern int GetCORSystemDirectory([MarshalAs(UnmanagedType.LPWStr)] StringBuilder pbuffer, int cchBuffer, ref int dwlength);

		private static string GetClrInstallationDirectory()
		{
			int num = 260;
			StringBuilder stringBuilder = new StringBuilder(num);
			SerialInformation.GetCORSystemDirectory(stringBuilder, num, ref num);
			return stringBuilder.ToString();
		}

		[DllImport("mscoree.dll")]
		private static extern int GetCORVersion([MarshalAs(UnmanagedType.LPWStr)] StringBuilder pbuffer, int cchBuffer, ref int dwlength);

		public static string GetCORVersion()
		{
			int num = 260;
			StringBuilder stringBuilder = new StringBuilder(num);
			SerialInformation.GetCORVersion(stringBuilder, num, ref num);
			return stringBuilder.ToString();
		}

		public static string GetCPUId()
		{
			string text = "";
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
			if (managementObjectSearcher == null) {
				return "WINXP";
			}
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			if (managementObjectCollection == null) {
				return "WINXP";
			}
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator()) {
				while (enumerator.MoveNext()) {
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					if (managementObject["ProcessorId"] == null) {
						string result = "VM";
						return result;
					}
					text = managementObject["ProcessorId"].ToString();
				}
			}
			if (text == null) {
				return "WINXP";
			}
			return text;
		}
	}
}
