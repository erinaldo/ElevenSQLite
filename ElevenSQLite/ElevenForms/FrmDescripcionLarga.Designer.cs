/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:35 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmDescripcionLarga
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
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(2, 2);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDescripcion.Size = new System.Drawing.Size(364, 101);
			this.txtDescripcion.TabIndex = 0;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(140, 109);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 1;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// FrmDescripcionLarga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 139);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtDescripcion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmDescripcionLarga";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Descripcion Larga";
			this.Load += new System.EventHandler(this.FormDescripcionLarga_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
		private TextBox txtDescripcion;
		private Button btnAceptar;
	}
}
