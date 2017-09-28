/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 12:33 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of Arguments.
	/// </summary>
	public class Arguments
	{
		public Arguments()
		{
		}
		private StringDictionary Parameters;

		public string this[string Param] {
			get {
				return Parameters[Param];
			}
		}

		public Arguments(string[] Args)
		{
			Parameters = new StringDictionary();
			Regex regex = new Regex("^-{1,2}|^/|=|:", RegexOptions.IgnoreCase | RegexOptions.Compiled);
			Regex regex2 = new Regex("^['\"]?(.*?)['\"]?$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
			string text = null;
			for (int i = 0; i < Args.Length; i++) {
				string input = Args[i];
				string[] array = regex.Split(input, 3);
				switch (array.Length) {
					case 1:
						if (text != null) {
							if (!Parameters.ContainsKey(text)) {
								array[0] = regex2.Replace(array[0], "$1");
								Parameters.Add(text, array[0]);
							}
							text = null;
						}
						break;
					case 2:
						if (text != null && !Parameters.ContainsKey(text)) {
							Parameters.Add(text, "true");
						}
						text = array[1];
						break;
					case 3:
						if (text != null && !Parameters.ContainsKey(text)) {
							Parameters.Add(text, "true");
						}
						text = array[1];
						if (!Parameters.ContainsKey(text)) {
							array[2] = regex2.Replace(array[2], "$1");
							Parameters.Add(text, array[2]);
						}
						text = null;
						break;
				}
			}
			if (text != null && !Parameters.ContainsKey(text)) {
				Parameters.Add(text, "true");
			}
		}
	}
}
