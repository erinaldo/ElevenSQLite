/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:11 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmDescuentoDocumento
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
			this.btnAceptar = new System.Windows.Forms.Button();
			this.checkRecalculo = new System.Windows.Forms.CheckBox();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAceptar
			// 
			this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAceptar.Location = new System.Drawing.Point(96, 107);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 1;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// checkRecalculo
			// 
			this.checkRecalculo.AutoSize = true;
			this.checkRecalculo.Checked = true;
			this.checkRecalculo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkRecalculo.Location = new System.Drawing.Point(10, 84);
			this.checkRecalculo.Name = "checkRecalculo";
			this.checkRecalculo.Size = new System.Drawing.Size(173, 17);
			this.checkRecalculo.TabIndex = 6;
			this.checkRecalculo.Text = "NO hacer recalculo automatico";
			this.checkRecalculo.UseVisualStyleBackColor = true;
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(53, 12);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(189, 20);
			this.txtDescuento.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Valor:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(10, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(271, 40);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Observación:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(258, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Si cambia el descuento debe también calcular el IVA.";
			// 
			// FrmDescuentoDocumento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 137);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.checkRecalculo);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmDescuentoDocumento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Descuento Documento";
			this.Load += new System.EventHandler(this.FormDescuentoDocumento_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private Button btnAceptar;
		private CheckBox checkRecalculo;
		private TextBox txtDescuento;
		private Label label1;
		private GroupBox groupBox1;
		private Label label2;
	}
}
