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

namespace ElevenSQLite.ElevenForms
{
	partial class FrmImpresionDocumento
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FrmImpresionDocumento));
			
			base.SuspendLayout();
			
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(692, 566);
			
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Impresion Documento";
			base.FormClosing += new FormClosingEventHandler(this.FormImpresionDocumento_FormClosing);
			base.FormClosed += new FormClosedEventHandler(this.FrmImpresionDocumento_FormClosed);
			base.Load += new EventHandler(this.FormImpresionDocumento_Load);
			
			base.ResumeLayout(false);
			// 
			// FrmImpresionDocumento
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			
			this.Name = "FrmImpresionDocumento";
		}
		
		
	}
}
