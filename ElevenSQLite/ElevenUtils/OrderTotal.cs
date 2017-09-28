/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 12:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of OrderTotal.
	/// </summary>
	public class OrderTotal
	{
		private char[] delimitador = new char[] {
			'?'
		};

		public OrderTotal(char delimit)
		{
			delimitador = new char[] {
				delimit
			};
		}

		public string GetTotalName(string totalItem)
		{
			string[] array = totalItem.Split(delimitador);
			return array[0];
		}

		public string GetTotalCantidad(string totalItem)
		{
			string[] array = totalItem.Split(delimitador);
			return array[1];
		}

		public string GenerateTotal(string totalName, string price)
		{
			return totalName + delimitador[0] + price;
		}
	}
}
