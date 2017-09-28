/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmAnularComprobante
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Button btnAceptar;
		private CheckBox checkEliminar;
		private Label label5;
		private Label label4;
		private Label lbTipoDocumento;
		private TextBox txtMotivo;
		private Label lbConsecutivo;
		private Label label1;
		
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
			this.checkEliminar = new CheckBox();
			this.label5 = new Label();
			this.label4 = new Label();
			this.lbTipoDocumento = new Label();
			this.txtMotivo = new TextBox();
			this.lbConsecutivo = new Label();
			this.label1 = new Label();
			base.SuspendLayout();
			this.btnAceptar.DialogResult = DialogResult.OK;
			this.btnAceptar.Location = new Point(134, 138);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new Size(141, 23);
			this.btnAceptar.TabIndex = 15;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new EventHandler(this.btnAceptar_Click);
			this.checkEliminar.AutoSize = true;
			this.checkEliminar.Location = new Point(2, 115);
			this.checkEliminar.Name = "checkEliminar";
			this.checkEliminar.Size = new Size(195, 17);
			this.checkEliminar.TabIndex = 14;
			this.checkEliminar.Text = "Eliminar documento definitivamente.";
			this.checkEliminar.UseVisualStyleBackColor = true;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label5.Location = new Point(2, 45);
			this.label5.Name = "label5";
			this.label5.Size = new Size(49, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Motivo:";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(2, 27);
			this.label4.Name = "label4";
			this.label4.Size = new Size(85, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Consecutivo: ";
			this.lbTipoDocumento.AutoSize = true;
			this.lbTipoDocumento.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbTipoDocumento.Location = new Point(97, 9);
			this.lbTipoDocumento.Name = "lbTipoDocumento";
			this.lbTipoDocumento.Size = new Size(101, 13);
			this.lbTipoDocumento.TabIndex = 11;
			this.lbTipoDocumento.Text = "COMPROBANTE";
			this.txtMotivo.Location = new Point(2, 61);
			this.txtMotivo.Multiline = true;
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.Size = new Size(391, 48);
			this.txtMotivo.TabIndex = 10;
			this.lbConsecutivo.AutoSize = true;
			this.lbConsecutivo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbConsecutivo.Location = new Point(97, 27);
			this.lbConsecutivo.Name = "lbConsecutivo";
			this.lbConsecutivo.Size = new Size(69, 20);
			this.lbConsecutivo.TabIndex = 9;
			this.lbConsecutivo.Text = "000000";
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(2, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(79, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Documento: ";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(405, 166);
			base.Controls.Add(this.btnAceptar);
			base.Controls.Add(this.checkEliminar);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.lbTipoDocumento);
			base.Controls.Add(this.txtMotivo);
			base.Controls.Add(this.lbConsecutivo);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Anular comprobante";
			base.Load += new EventHandler(this.FormAnularComprobante_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
			// 
			// FrmAnularComprobante
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "FrmAnularComprobante";
			this.Name = "FrmAnularComprobante";
		}
	}
}
