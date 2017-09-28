/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 3:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmCambiarConsecutivo
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
			this.btnAceptar = new Button();
			this.label1 = new Label();
			this.txtConsecutivo = new TextBox();
			base.SuspendLayout();
			this.btnAceptar.DialogResult = DialogResult.OK;
			this.btnAceptar.Location = new Point(73, 34);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new Size(75, 23);
			this.btnAceptar.TabIndex = 0;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new EventHandler(this.btnAceptar_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(1, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(81, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Consecutivo:";
			this.txtConsecutivo.Location = new Point(85, 6);
			this.txtConsecutivo.Name = "txtConsecutivo";
			this.txtConsecutivo.Size = new Size(121, 20);
			this.txtConsecutivo.TabIndex = 2;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(220, 69);
			base.Controls.Add(this.txtConsecutivo);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnAceptar);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Cambiar consecutivo";
			base.Load += new EventHandler(this.FormCambiarConsecutivo_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
			
			// 
			// FrmCambiarConsecutivo
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "FrmCambiarConsecutivo";
		}
		private Button btnAceptar;
		private Label label1;
		private TextBox txtConsecutivo;
	}
}
