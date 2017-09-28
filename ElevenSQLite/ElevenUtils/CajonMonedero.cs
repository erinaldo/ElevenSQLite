/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 12:34 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of CajonMonedero.
	/// </summary>
	public class CajonMonedero
	{
		private const int INT_TIMEOUT_ENVIODATOS = 500;
		private const char STR_SEPARADOR = ',';
		private const uint GENERIC_READ = 2147483648u;
		private const uint GENERIC_WRITE = 1073741824u;
		private const uint OPEN_EXISTING = 3u;
		private string puerto = "LPT1";
		private string drawerCode = "27,112,0,25,250";

		[DllImport("kernel32", SetLastError = true)]
		private static extern SafeFileHandle CreateFile(string FileName, uint DesiredAccess, uint ShareMode, uint SecurityAttributes, uint CreationDisposition, uint FlagsAndAttributes, int hTemplateFile);

		public CajonMonedero(string puerto, string codigo)
		{
			this.puerto = puerto;
			this.drawerCode = codigo;
		}

		public int AbrirCajonMonedero()
		{
			int result = -1;
			Thread thread = new Thread(new ThreadStart(EnviarDatosCajon));
			thread.IsBackground = true;
			thread.Start();
			Thread.Sleep(500);
			if (thread.IsAlive) {
				thread.Abort();
			}
			return result;
		}

		private void EnviarDatosCajon()
		{
			FileStream fileStream = null;
			StreamWriter streamWriter = null;
			try {
				char[] separator = new char[] {
					','
				};
				string[] array = drawerCode.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				List<char> list = new List<char>();
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++) {
					string s = array2[i];
					list.Add((char)int.Parse(s));
				}
				SafeFileHandle safeFileHandle = CajonMonedero.CreateFile(puerto, 3221225472u, 0u, 0u, 3u, 0u, 0);
				if (!safeFileHandle.IsInvalid) {
					fileStream = new FileStream(safeFileHandle, FileAccess.Write);
					streamWriter = new StreamWriter(fileStream);
					streamWriter.Write(list.ToArray());
					streamWriter.Flush();
				}
			}
			catch (Exception ex) {
				throw ex;
			}
			finally {
				try {
					if (streamWriter != null) {
						streamWriter.Close();
					}
					if (fileStream != null) {
						fileStream.Close();
					}
				}
				catch {
				}
			}
		}
	}
}
