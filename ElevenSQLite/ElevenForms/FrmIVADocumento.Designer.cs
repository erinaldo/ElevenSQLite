/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:05 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmIVADocumento
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtIVA = new System.Windows.Forms.TextBox();
			this.checkRecalculo = new System.Windows.Forms.CheckBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valor:";
			// 
			// txtIVA
			// 
			this.txtIVA.Location = new System.Drawing.Point(59, 12);
			this.txtIVA.Name = "txtIVA";
			this.txtIVA.Size = new System.Drawing.Size(189, 20);
			this.txtIVA.TabIndex = 1;
			// 
			// checkRecalculo
			// 
			this.checkRecalculo.AutoSize = true;
			this.checkRecalculo.Checked = true;
			this.checkRecalculo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkRecalculo.Location = new System.Drawing.Point(16, 38);
			this.checkRecalculo.Name = "checkRecalculo";
			this.checkRecalculo.Size = new System.Drawing.Size(173, 17);
			this.checkRecalculo.TabIndex = 2;
			this.checkRecalculo.Text = "NO hacer recalculo automatico";
			this.checkRecalculo.UseVisualStyleBackColor = true;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(96, 61);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 3;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// FrmIVADocumento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(261, 96);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.checkRecalculo);
			this.Controls.Add(this.txtIVA);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmIVADocumento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IVA Documento";
			this.Load += new System.EventHandler(this.FormIVADocumento_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private Label label1;
		private TextBox txtIVA;
		private CheckBox checkRecalculo;
		private Button btnAceptar;
	}
}
