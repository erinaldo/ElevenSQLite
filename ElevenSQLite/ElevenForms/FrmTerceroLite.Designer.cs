/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:41 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmTerceroLite
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtNombreComercial = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 161);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(520, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(250, 17);
			this.toolStripStatusLabel1.Text = "ENTER o TAB: Para desplazar  * Son requeridos";
			// 
			// txtNombreComercial
			// 
			this.txtNombreComercial.Location = new System.Drawing.Point(123, 38);
			this.txtNombreComercial.Name = "txtNombreComercial";
			this.txtNombreComercial.Size = new System.Drawing.Size(372, 20);
			this.txtNombreComercial.TabIndex = 1;
			this.txtNombreComercial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreComercial_KeyDown);
			this.txtNombreComercial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreComercial_KeyPress);
			this.txtNombreComercial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombreComercial_KeyUp);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(4, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Nombre comercial *:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Código *:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(123, 12);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(119, 20);
			this.txtCodigo.TabIndex = 0;
			this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
			this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
			this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(315, 119);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(103, 29);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(102, 119);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(103, 29);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "ACEPTAR";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(123, 93);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(128, 20);
			this.txtTelefono.TabIndex = 3;
			this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyDown);
			this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
			this.txtTelefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyUp);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(4, 100);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(61, 13);
			this.label13.TabIndex = 30;
			this.label13.Text = "Teléfono:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(123, 64);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(372, 20);
			this.txtDireccion.TabIndex = 2;
			this.txtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDireccion_KeyDown);
			this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
			this.txtDireccion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDireccion_KeyUp);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(4, 71);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(65, 13);
			this.label11.TabIndex = 29;
			this.label11.Text = "Dirección:";
			// 
			// FrmTerceroLite
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 183);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtNombreComercial);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmTerceroLite";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tercero Lite";
			this.Load += new System.EventHandler(this.FormTerceroLite_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
		private StatusStrip statusStrip1;
		private TextBox txtNombreComercial;
		private Label label4;
		private Label label1;
		private Button btnSalir;
		private Button btnAceptar;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private TextBox txtTelefono;
		private Label label13;
		private TextBox txtDireccion;
		private Label label11;
		public TextBox txtCodigo;
	}
}
