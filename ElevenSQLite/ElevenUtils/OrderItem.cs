/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 12:57 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of OrderItem.
	/// </summary>
	public class OrderItem
	{
		private char[] delimitador = new char[] {
			'?'
		};

		public OrderItem(char delimit)
		{
			delimitador = new char[] {
				delimit
			};
		}

		public string GetItemCantidad(string orderItem)
		{
			string[] array = orderItem.Split(delimitador);
			return array[0];
		}

		public string GetItemName(string orderItem)
		{
			string[] array = orderItem.Split(delimitador);
			return array[1];
		}

		public string GetItemPrice(string orderItem)
		{
			string[] array = orderItem.Split(delimitador);
			return array[2];
		}

		public string GenerateItem(string cantidad, string itemName, string price)
		{
			return string.Concat(new object[] {
				cantidad,
				delimitador[0],
				itemName,
				delimitador[0],
				price
			});
		}
	}
}
