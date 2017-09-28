/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 1:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of Ticket.
	/// </summary>
	public class Ticket
	{
		private ArrayList headerLines = new ArrayList();

		private ArrayList subHeaderLines = new ArrayList();

		private ArrayList items = new ArrayList();

		private ArrayList totales = new ArrayList();

		private ArrayList footerLines = new ArrayList();

		private Image headerImage;

		private int count;

		private int maxChar = 35;

		private int maxCharDescription = 20;

		private int imageHeight;

		private float leftMargin;

		private float topMargin = 3f;

		private string fontName = "Lucida Console";

		private int fontSize = 9;

		private Font printFont;

		private SolidBrush myBrush = new SolidBrush(Color.Black);

		private Graphics gfx;

		private string line;

		public Image HeaderImage {
			get {
				return headerImage;
			}
			set {
				if (headerImage != value) {
					headerImage = value;
				}
			}
		}

		public int MaxChar {
			get {
				return maxChar;
			}
			set {
				if (value != maxChar) {
					maxChar = value;
				}
			}
		}

		public int MaxCharDescription {
			get {
				return maxCharDescription;
			}
			set {
				if (value != maxCharDescription) {
					maxCharDescription = value;
				}
			}
		}

		public int FontSize {
			get {
				return fontSize;
			}
			set {
				if (value != fontSize) {
					fontSize = value;
				}
			}
		}

		public string FontName {
			get {
				return fontName;
			}
			set {
				if (value != fontName) {
					fontName = value;
				}
			}
		}

		public void AddHeaderLine(string line)
		{
			headerLines.Add(line);
		}

		public void AddSubHeaderLine(string line)
		{
			subHeaderLines.Add(line);
		}

		public void AddItem(string cantidad, string item, string price)
		{
			OrderItem orderItem = new OrderItem('?');
			items.Add(orderItem.GenerateItem(cantidad, item, price));
		}

		public void AddTotal(string name, string price)
		{
			OrderTotal orderTotal = new OrderTotal('?');
			totales.Add(orderTotal.GenerateTotal(name, price));
		}

		public void AddFooterLine(string line)
		{
			footerLines.Add(line);
		}

		private string AlignRightText(int lenght)
		{
			string text = "";
			int num = maxChar - lenght;
			for (int i = 0; i < num; i++) {
				text += " ";
			}
			return text;
		}

		private string DottedLine()
		{
			string text = "";
			for (int i = 0; i < maxChar; i++) {
				text += "=";
			}
			return text;
		}

		public bool PrinterExists(string impresora)
		{
			foreach (string b in PrinterSettings.InstalledPrinters) {
				if (impresora == b) {
					return true;
				}
			}
			return false;
		}

		public void PrintTicket(string impresora)
		{
			printFont = new Font(fontName, (float)fontSize, FontStyle.Regular);
			PrintDocument printDocument = new PrintDocument();
			printDocument.PrinterSettings.PrinterName = impresora;
			printDocument.PrintPage += new PrintPageEventHandler(pr_PrintPage);
			printDocument.Print();
		}

		private void pr_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.Graphics.PageUnit = GraphicsUnit.Millimeter;
			gfx = e.Graphics;
			DrawImage();
			DrawHeader();
			DrawSubHeader();
			DrawItems();
			DrawTotales();
			DrawFooter();
			if (headerImage != null) {
				HeaderImage.Dispose();
				headerImage.Dispose();
			}
		}

		private float YPosition()
		{
			return topMargin + ((float)count * printFont.GetHeight(gfx) + (float)imageHeight);
		}

		private void DrawImage()
		{
			if (headerImage != null) {
				try {
					gfx.DrawImage(headerImage, new Point((int)leftMargin, (int)YPosition()));
					double a = (double)headerImage.Height / 58.0 * 15.0;
					imageHeight = (int)Math.Round(a) + 3;
				}
				catch (Exception) {
				}
			}
		}

		private void DrawHeader()
		{
			foreach (string text in headerLines) {
				if (text.Length > maxChar) {
					int num = 0;
					for (int i = text.Length; i > maxChar; i -= maxChar) {
						line = text.Substring(num, maxChar);
						gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
						count++;
						num += maxChar;
					}
					line = text;
					gfx.DrawString(line.Substring(num, line.Length - num), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
				else {
					line = text;
					gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
			}
			DrawEspacio();
		}

		private void DrawSubHeader()
		{
			foreach (string text in subHeaderLines) {
				if (text.Length > maxChar) {
					int num = 0;
					for (int i = text.Length; i > maxChar; i -= maxChar) {
						line = text;
						gfx.DrawString(line.Substring(num, maxChar), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
						count++;
						num += maxChar;
					}
					line = text;
					gfx.DrawString(line.Substring(num, line.Length - num), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
				else {
					line = text;
					gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
					line = DottedLine();
					gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
			}
			DrawEspacio();
		}

		private void DrawItems()
		{
			OrderItem orderItem = new OrderItem('?');
			gfx.DrawString("CANT  DESCRIPCION           TOTAL", printFont, myBrush, leftMargin, YPosition(), new StringFormat());
			count++;
			DrawEspacio();
			foreach (string orderItem2 in items) {
				line = orderItem.GetItemCantidad(orderItem2);
				gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
				line = orderItem.GetItemPrice(orderItem2);
				line = AlignRightText(line.Length) + line;
				gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
				string itemName = orderItem.GetItemName(orderItem2);
				leftMargin = 0f;
				if (itemName.Length > maxCharDescription) {
					int num = 0;
					for (int i = itemName.Length; i > maxCharDescription; i -= maxCharDescription) {
						line = orderItem.GetItemName(orderItem2);
						gfx.DrawString("      " + line.Substring(num, maxCharDescription), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
						count++;
						num += maxCharDescription;
					}
					line = orderItem.GetItemName(orderItem2);
					gfx.DrawString("      " + line.Substring(num, line.Length - num), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
				else {
					gfx.DrawString("      " + orderItem.GetItemName(orderItem2), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
			}
			leftMargin = 0f;
			DrawEspacio();
			line = DottedLine();
			gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
			count++;
			DrawEspacio();
		}

		private void DrawTotales()
		{
			OrderTotal orderTotal = new OrderTotal('?');
			foreach (string totalItem in totales) {
				line = orderTotal.GetTotalCantidad(totalItem);
				line = AlignRightText(line.Length) + line;
				gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
				leftMargin = 0f;
				line = "      " + orderTotal.GetTotalName(totalItem);
				gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
				count++;
			}
			leftMargin = 0f;
			DrawEspacio();
			DrawEspacio();
		}

		private void DrawFooter()
		{
			foreach (string text in footerLines) {
				if (text.Length > maxChar) {
					int num = 0;
					for (int i = text.Length; i > maxChar; i -= maxChar) {
						line = text;
						gfx.DrawString(line.Substring(num, maxChar), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
						count++;
						num += maxChar;
					}
					line = text;
					gfx.DrawString(line.Substring(num, line.Length - num), printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
				else {
					line = text;
					gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
					count++;
				}
			}
			leftMargin = 0f;
			DrawEspacio();
		}

		private void DrawEspacio()
		{
			line = "";
			gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition(), new StringFormat());
			count++;
		}
	}
}
