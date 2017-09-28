/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 1:02 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Security.Cryptography;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of SharedInformation.
	/// </summary>
	public static class SharedInformation
	{
		public static int KeySize {
			get {
				return 1024;
			}
		}

		public static string HashAlgorithm {
			get {
				return "SHA1";
			}
		}

		public static RSACryptoServiceProvider CryptoProvider {
			get {
				return new RSACryptoServiceProvider(SharedInformation.KeySize, new CspParameters());
			}
		}
	}
}
