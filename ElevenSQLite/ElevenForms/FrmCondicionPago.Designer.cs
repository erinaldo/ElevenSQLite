/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 10:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmCondicionPago
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private StatusStrip statusStrip1;
		private Label label1;
		private Label label2;
		private NumericUpDown numDias;
		private TextBox txtDescripcion;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.ToolStripStatusLabel lblInfo;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCondicionPago));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numDias = new System.Windows.Forms.NumericUpDown();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lblInfo});
			this.statusStrip1.Location = new System.Drawing.Point(0, 67);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(387, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblInfo
			// 
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(0, 17);
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(101, 8);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(270, 20);
			this.txtDescripcion.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Descripción*:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Dias*:";
			// 
			// numDias
			// 
			this.numDias.Location = new System.Drawing.Point(101, 35);
			this.numDias.Name = "numDias";
			this.numDias.Size = new System.Drawing.Size(72, 20);
			this.numDias.TabIndex = 7;
			// 
			// btnCerrar
			// 
			this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(283, 33);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(92, 28);
			this.btnCerrar.TabIndex = 23;
			this.btnCerrar.Text = "&Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(190, 33);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(92, 28);
			this.btnGuardar.TabIndex = 22;
			this.btnGuardar.Text = "&Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// FrmCondicionPago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 89);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.numDias);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmCondicionPago";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Condicion Pago";
			this.Load += new System.EventHandler(this.FrmCondicionPagoLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
