/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 12:59 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of RandomSNKGenerator.
	/// </summary>
	public class RandomSNKGenerator
	{
		private static string convertDelimiter(SNDelimiter delInt)
		{
			string result = "";
			switch (Convert.ToInt32(delInt)) {
				case 0:
					result = "";
					break;
				case 1:
					result = "\t";
					break;
				case 2:
					result = " ";
					break;
				case 3:
					result = "-";
					break;
				case 4:
					result = ".";
					break;
				case 5:
					result = "/";
					break;
				case 6:
					result = ",";
					break;
			}
			return result;
		}

		private static string AppendSpecifiedStr(int length, int delLength, string str, char[] newKey)
		{
			string text = "";
			int i = 0;
			for (int j = 0; j < length; j++) {
				if (delLength != 0) {
					for (i = j; i < delLength + j; i++) {
						text += newKey[i];
					}
				}
				else {
					text += newKey[j];
				}
				if (i == length) {
					break;
				}
				if (delLength != 0) {
					j = i - 1;
					text += str;
				}
			}
			return text;
		}

		public static string GetSerialKeyAlphaNumeric(SNKeyLength keyLength, SNDelimiter delimiter, int delimiterLength)
		{
			string str = RandomSNKGenerator.convertDelimiter(delimiter);
			string text = Guid.NewGuid().ToString("N");
			string text2 = text.Substring(0, (int)keyLength);
			text2 = text2.ToUpper();
			char[] newKey = text2.ToCharArray();
			string result = "";
			if (keyLength <= SNKeyLength.SN20) {
				if (keyLength != SNKeyLength.SN16) {
					if (keyLength == SNKeyLength.SN20) {
						result = RandomSNKGenerator.AppendSpecifiedStr(20, delimiterLength, str, newKey);
					}
				}
				else {
					result = RandomSNKGenerator.AppendSpecifiedStr(16, delimiterLength, str, newKey);
				}
			}
			else {
				if (keyLength != SNKeyLength.SN24) {
					if (keyLength != SNKeyLength.SN28) {
						if (keyLength == SNKeyLength.SN32) {
							result = RandomSNKGenerator.AppendSpecifiedStr(32, delimiterLength, str, newKey);
						}
					}
					else {
						result = RandomSNKGenerator.AppendSpecifiedStr(28, delimiterLength, str, newKey);
					}
				}
				else {
					result = RandomSNKGenerator.AppendSpecifiedStr(24, delimiterLength, str, newKey);
				}
			}
			return result;
		}

		public static string GetSerialKeyNumeric(SNKeyNumLength keyLength)
		{
			Random random = new Random();
			return Math.Round(random.NextDouble() * Math.Pow(10.0, (double)keyLength) + 4.0).ToString().Substring(0, (int)keyLength);
		}
	}
}
