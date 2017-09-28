/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 12:56 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data;
using System.IO;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of CSVWriter.
	/// </summary>
	public class CSVWriter
	{
		public static string WriteToString(DataTable table, bool header, bool quoteall)
		{
			StringWriter stringWriter = new StringWriter();
			CSVWriter.WriteToStream(stringWriter, table, header, quoteall);
			return stringWriter.ToString();
		}

		public static void WriteToStream(TextWriter stream, DataTable table, bool header, bool quoteall)
		{
			if (header) {
				for (int i = 0; i < table.Columns.Count; i++) {
					CSVWriter.WriteItem(stream, table.Columns[i].Caption, quoteall);
					if (i < table.Columns.Count - 1) {
						stream.Write(',');
					}
					else {
						stream.Write('\n');
					}
				}
			}
			foreach (DataRow dataRow in table.Rows) {
				for (int j = 0; j < table.Columns.Count; j++) {
					CSVWriter.WriteItem(stream, dataRow[j], quoteall);
					if (j < table.Columns.Count - 1) {
						stream.Write(',');
					}
					else {
						stream.Write('\n');
					}
				}
			}
		}

		private static void WriteItem(TextWriter stream, object item, bool quoteall)
		{
			if (item == null) {
				return;
			}
			string text = item.ToString();
			if (quoteall || text.IndexOfAny("\",\n\r".ToCharArray()) > -1) {
				stream.Write("\"" + text.Replace("\"", "\"\"") + "\"");
				return;
			}
			stream.Write(text);
		}
	}
}
