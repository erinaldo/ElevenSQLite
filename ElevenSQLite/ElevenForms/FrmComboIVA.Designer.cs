/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:28 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ElevenSQLite.ElevenForms
{
	partial class FrmComboIVA
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
			this.components = new System.ComponentModel.Container();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.cbTarifaIVA = new System.Windows.Forms.ComboBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAceptar
			// 
			this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAceptar.Location = new System.Drawing.Point(35, 30);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 8;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// cbTarifaIVA
			// 
			this.cbTarifaIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTarifaIVA.FormattingEnabled = true;
			this.cbTarifaIVA.Location = new System.Drawing.Point(12, 3);
			this.cbTarifaIVA.Name = "cbTarifaIVA";
			this.cbTarifaIVA.Size = new System.Drawing.Size(121, 21);
			this.cbTarifaIVA.TabIndex = 7;
			// 
			// FrmComboIVA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(143, 60);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.cbTarifaIVA);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmComboIVA";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IVA";
			this.Load += new System.EventHandler(this.FormComboIVA_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}
		
		private Button btnAceptar;
		private ComboBox cbTarifaIVA;
		private BindingSource bindingSource1;
	}
}
