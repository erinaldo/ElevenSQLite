/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 16:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmClaveAcceso
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Button btnCambioClave;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtNuevaClave;
		private TextBox txtRepitaClave;
		
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
			this.btnCambioClave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNuevaClave = new System.Windows.Forms.TextBox();
			this.txtRepitaClave = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCambioClave
			// 
			this.btnCambioClave.Location = new System.Drawing.Point(95, 105);
			this.btnCambioClave.Name = "btnCambioClave";
			this.btnCambioClave.Size = new System.Drawing.Size(119, 23);
			this.btnCambioClave.TabIndex = 0;
			this.btnCambioClave.Text = "Cambiar clave";
			this.btnCambioClave.UseVisualStyleBackColor = true;
			this.btnCambioClave.Click += new System.EventHandler(this.btnCambioClave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "CAMBIO DE CLAVE DE ACCESO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nueva clave:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Repita la clave:";
			// 
			// txtNuevaClave
			// 
			this.txtNuevaClave.Location = new System.Drawing.Point(119, 46);
			this.txtNuevaClave.Name = "txtNuevaClave";
			this.txtNuevaClave.PasswordChar = '*';
			this.txtNuevaClave.Size = new System.Drawing.Size(164, 20);
			this.txtNuevaClave.TabIndex = 4;
			// 
			// txtRepitaClave
			// 
			this.txtRepitaClave.Location = new System.Drawing.Point(119, 72);
			this.txtRepitaClave.Name = "txtRepitaClave";
			this.txtRepitaClave.PasswordChar = '*';
			this.txtRepitaClave.Size = new System.Drawing.Size(164, 20);
			this.txtRepitaClave.TabIndex = 5;
			// 
			// FrmClaveAcceso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 145);
			this.Controls.Add(this.txtRepitaClave);
			this.Controls.Add(this.txtNuevaClave);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCambioClave);
			this.Name = "FrmClaveAcceso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambiar Clave Acceso";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
