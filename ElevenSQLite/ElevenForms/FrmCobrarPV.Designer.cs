/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 11/09/2017
 * Hora: 14:31
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
	partial class FrmCobrarPV
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Label label1;
		private TextBox txtTotal;
		private TextBox txtEntregado;
		private Label label2;
		private TextBox txtCambio;
		private Label label3;
		private Label label4;
		private ComboBox cbFormaPago;
		private Button btnImprimir;
		private Button btnSalir;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		
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
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtEntregado = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbFormaPago = new System.Windows.Forms.ComboBox();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "TOTAL:";
			// 
			// txtTotal
			// 
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(143, 12);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(167, 26);
			this.txtTotal.TabIndex = 5;
			this.txtTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal_KeyDown);
			this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
			this.txtTotal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotal_KeyUp);
			// 
			// txtEntregado
			// 
			this.txtEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEntregado.Location = new System.Drawing.Point(143, 44);
			this.txtEntregado.Name = "txtEntregado";
			this.txtEntregado.Size = new System.Drawing.Size(167, 26);
			this.txtEntregado.TabIndex = 7;
			this.txtEntregado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntregado_KeyDown);
			this.txtEntregado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntregado_KeyPress);
			this.txtEntregado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEntregado_KeyUp);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "ENTREGADO:";
			// 
			// txtCambio
			// 
			this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCambio.Location = new System.Drawing.Point(143, 76);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.ReadOnly = true;
			this.txtCambio.Size = new System.Drawing.Size(167, 26);
			this.txtCambio.TabIndex = 9;
			this.txtCambio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCambio_KeyDown);
			this.txtCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCambio_KeyPress);
			this.txtCambio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCambio_KeyUp);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "CAMBIO:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "M. PAGO:";
			// 
			// cbFormaPago
			// 
			this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFormaPago.FormattingEnabled = true;
			this.cbFormaPago.Items.AddRange(new object[] {
			"CONTADO",
			"TARJETA"});
			this.cbFormaPago.Location = new System.Drawing.Point(143, 109);
			this.cbFormaPago.Name = "cbFormaPago";
			this.cbFormaPago.Size = new System.Drawing.Size(167, 28);
			this.cbFormaPago.TabIndex = 11;
			this.cbFormaPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFormaPago_KeyDown);
			this.cbFormaPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFormaPago_KeyPress);
			this.cbFormaPago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbFormaPago_KeyUp);
			this.cbFormaPago.Layout += new System.Windows.Forms.LayoutEventHandler(this.cbFormaPago_Layout);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Location = new System.Drawing.Point(16, 157);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(103, 29);
			this.btnImprimir.TabIndex = 12;
			this.btnImprimir.Text = "IMPRIMIR";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(229, 157);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(103, 29);
			this.btnSalir.TabIndex = 13;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 192);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(364, 22);
			this.statusStrip1.TabIndex = 14;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 17);
			this.toolStripStatusLabel1.Text = "ENTER: para pasar.";
			// 
			// FrmCobrarPV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 214);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.cbFormaPago);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEntregado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmCobrarPV";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cobrar PV";
			this.Load += new System.EventHandler(this.FormCobrarPV_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
