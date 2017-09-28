/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 10/09/2017
 * Hora: 4:19 p. m.
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
	partial class FrmComboRetencion
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
			this.components = new Container();
			this.btnAceptar = new Button();
			this.cbTarifaRetencion = new ComboBox();
			this.bindingSource1 = new BindingSource(this.components);
			((ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.btnAceptar.DialogResult = DialogResult.OK;
			this.btnAceptar.Location = new Point(35, 39);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new Size(75, 23);
			this.btnAceptar.TabIndex = 10;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new EventHandler(this.btnAceptar_Click);
			this.cbTarifaRetencion.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbTarifaRetencion.FormattingEnabled = true;
			this.cbTarifaRetencion.Location = new Point(12, 12);
			this.cbTarifaRetencion.Name = "cbTarifaRetencion";
			this.cbTarifaRetencion.Size = new Size(121, 21);
			this.cbTarifaRetencion.TabIndex = 9;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(144, 67);
			base.Controls.Add(this.btnAceptar);
			base.Controls.Add(this.cbTarifaRetencion);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Retención";
			base.Load += new EventHandler(this.FormComboRetencion_Load);
			((ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
			
			// 
			// FrmComboRetencion
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			
			this.Name = "FrmComboRetencion";
		}
		
		private Button btnAceptar;
		private ComboBox cbTarifaRetencion;
		private BindingSource bindingSource1;
	}
}
