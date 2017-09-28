/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 15:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmAnularDocumento
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Label label1;
		private Label lbConsecutivo;
		private TextBox txtMotivo;
		private Label lbTipoDocumento;
		private Label label4;
		private Label label5;
		private CheckBox checkEliminar;
		private Button btnAceptar;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnularDocumento));
			this.label1 = new System.Windows.Forms.Label();
			this.lbConsecutivo = new System.Windows.Forms.Label();
			this.txtMotivo = new System.Windows.Forms.TextBox();
			this.lbTipoDocumento = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.checkEliminar = new System.Windows.Forms.CheckBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Documento: ";
			// 
			// lbConsecutivo
			// 
			this.lbConsecutivo.AutoSize = true;
			this.lbConsecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbConsecutivo.Location = new System.Drawing.Point(99, 27);
			this.lbConsecutivo.Name = "lbConsecutivo";
			this.lbConsecutivo.Size = new System.Drawing.Size(69, 20);
			this.lbConsecutivo.TabIndex = 1;
			this.lbConsecutivo.Text = "000000";
			// 
			// txtMotivo
			// 
			this.txtMotivo.Location = new System.Drawing.Point(4, 61);
			this.txtMotivo.Multiline = true;
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.Size = new System.Drawing.Size(316, 48);
			this.txtMotivo.TabIndex = 2;
			// 
			// lbTipoDocumento
			// 
			this.lbTipoDocumento.AutoSize = true;
			this.lbTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTipoDocumento.Location = new System.Drawing.Point(99, 9);
			this.lbTipoDocumento.Name = "lbTipoDocumento";
			this.lbTipoDocumento.Size = new System.Drawing.Size(86, 13);
			this.lbTipoDocumento.TabIndex = 3;
			this.lbTipoDocumento.Text = "DOCUMENTO";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(4, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Consecutivo: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(4, 45);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Motivo:";
			// 
			// checkEliminar
			// 
			this.checkEliminar.AutoSize = true;
			this.checkEliminar.Location = new System.Drawing.Point(4, 115);
			this.checkEliminar.Name = "checkEliminar";
			this.checkEliminar.Size = new System.Drawing.Size(195, 17);
			this.checkEliminar.TabIndex = 6;
			this.checkEliminar.Text = "Eliminar documento definitivamente.";
			this.checkEliminar.UseVisualStyleBackColor = true;
			// 
			// btnAceptar
			// 
			this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(113, 138);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(97, 30);
			this.btnAceptar.TabIndex = 7;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// FrmAnularDocumento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 172);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.checkEliminar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbTipoDocumento);
			this.Controls.Add(this.txtMotivo);
			this.Controls.Add(this.lbConsecutivo);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmAnularDocumento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Anular Documento";
			this.Load += new System.EventHandler(this.FormAnularDocumento_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
