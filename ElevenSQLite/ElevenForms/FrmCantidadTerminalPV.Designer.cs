/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmCantidadTerminalPV
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private TextBox txtCantidad;
		private Label label1;
		private Label lbDescripcionCorta;
		
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbDescripcionCorta = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 86);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(368, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(262, 17);
			this.toolStripStatusLabel1.Text = "ENTER: Cambia y sale o ESC: Para salir sin grabar";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(104, 36);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(149, 26);
			this.txtCantidad.TabIndex = 4;
			this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
			this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Cantidad:";
			// 
			// lbDescripcionCorta
			// 
			this.lbDescripcionCorta.AutoSize = true;
			this.lbDescripcionCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDescripcionCorta.Location = new System.Drawing.Point(86, 9);
			this.lbDescripcionCorta.Name = "lbDescripcionCorta";
			this.lbDescripcionCorta.Size = new System.Drawing.Size(196, 20);
			this.lbDescripcionCorta.TabIndex = 6;
			this.lbDescripcionCorta.Text = "DESCRIPCION CORTA";
			// 
			// FrmCantidadTerminalPV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 108);
			this.Controls.Add(this.lbDescripcionCorta);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmCantidadTerminalPV";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cantidad Terminal PV";
			this.Load += new System.EventHandler(this.FormCantidadTerminalPV_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
