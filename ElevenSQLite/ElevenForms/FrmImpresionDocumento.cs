/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:56 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmImpresionDocumento.
	/// </summary>
	public partial class FrmImpresionDocumento : Form
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern uint GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string lpszLongPath, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszShortPath, uint cchBuffer);
		
		public Comprobante Comprobante { get; set; }
		public Documento Documento { get; set; }
		
		public FrmImpresionDocumento()
		{
			
		}
		private void FormImpresionDocumento_Load(object sender, EventArgs e)
		{
			
		}

		public void LoadFile(string path)
		{
			
		}


		private void FormImpresionDocumento_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}

		protected string CalcularCerosIzquierda(int p)
		{
			string text = "";
			for (int i = 0; i < p; i++) {
				text += "0";
			}
			return text;
		}

		private void axAcroPDF1_Enter(object sender, EventArgs e)
		{
		}

		private void FrmImpresionDocumento_FormClosed(object sender, FormClosedEventArgs e)
		{
		}
	}
}
