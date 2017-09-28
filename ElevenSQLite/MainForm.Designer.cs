/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 6:09 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ElevenSQLite
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Ribbon ribbon1;
		private System.Windows.Forms.RibbonTab ribbonTabPrincipal;
		private System.Windows.Forms.RibbonPanel ribbonPanelPrincipal;
		private System.Windows.Forms.RibbonButton ribbonButtonArticulos;
		private System.Windows.Forms.RibbonButton ribbonButtonTerceros;
		private System.Windows.Forms.RibbonButton ribbonButtonDocumentos;
		private System.Windows.Forms.RibbonButton ribbonButtonComprobantes;
		private System.Windows.Forms.RibbonButton ribbonButtonInformes;
		private System.Windows.Forms.RibbonButton ribbonButtonPreferencias;
		private System.Windows.Forms.RibbonButton ribbonButtonMaestros;
		private System.Windows.Forms.RibbonButton ribbonButtonSalir;
		private System.Windows.Forms.RibbonButton ribbonButton1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblInfo;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripStatusLabel lblData;
		private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ribbon1 = new System.Windows.Forms.Ribbon();
			this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
			this.ribbonTabPrincipal = new System.Windows.Forms.RibbonTab();
			this.ribbonPanelPrincipal = new System.Windows.Forms.RibbonPanel();
			this.ribbonButtonArticulos = new System.Windows.Forms.RibbonButton();
			this.ribbonButtonTerceros = new System.Windows.Forms.RibbonButton();
			this.ribbonButtonDocumentos = new System.Windows.Forms.RibbonButton();
			this.ribbonButtonComprobantes = new System.Windows.Forms.RibbonButton();
			this.ribbonButtonInformes = new System.Windows.Forms.RibbonButton();
			this.ribbonButtonPreferencias = new System.Windows.Forms.RibbonButton();
			this.ribbonButtonMaestros = new System.Windows.Forms.RibbonButton();
			this.ribbonButtonSalir = new System.Windows.Forms.RibbonButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ribbon1
			// 
			this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ribbon1.Location = new System.Drawing.Point(0, 0);
			this.ribbon1.Minimized = false;
			this.ribbon1.Name = "ribbon1";
			// 
			// 
			// 
			this.ribbon1.OrbDropDown.BorderRoundness = 8;
			this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
			this.ribbon1.OrbDropDown.Name = "";
			this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
			this.ribbon1.OrbDropDown.TabIndex = 0;
			this.ribbon1.OrbImage = ((System.Drawing.Image)(resources.GetObject("ribbon1.OrbImage")));
			// 
			// 
			// 
			this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton1);
			this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
			this.ribbon1.Size = new System.Drawing.Size(726, 116);
			this.ribbon1.TabIndex = 0;
			this.ribbon1.Tabs.Add(this.ribbonTabPrincipal);
			this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
			this.ribbon1.Text = "ribbon1";
			this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
			// 
			// ribbonButton1
			// 
			this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
			this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
			this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
			this.ribbonButton1.Text = "ribbonButton1";
			// 
			// ribbonTabPrincipal
			// 
			this.ribbonTabPrincipal.Panels.Add(this.ribbonPanelPrincipal);
			this.ribbonTabPrincipal.Text = "";
			// 
			// ribbonPanelPrincipal
			// 
			this.ribbonPanelPrincipal.Items.Add(this.ribbonButtonArticulos);
			this.ribbonPanelPrincipal.Items.Add(this.ribbonButtonTerceros);
			this.ribbonPanelPrincipal.Items.Add(this.ribbonButtonDocumentos);
			this.ribbonPanelPrincipal.Items.Add(this.ribbonButtonComprobantes);
			this.ribbonPanelPrincipal.Items.Add(this.ribbonButtonInformes);
			this.ribbonPanelPrincipal.Items.Add(this.ribbonButtonPreferencias);
			this.ribbonPanelPrincipal.Items.Add(this.ribbonButtonMaestros);
			this.ribbonPanelPrincipal.Items.Add(this.ribbonButtonSalir);
			this.ribbonPanelPrincipal.Text = "";
			// 
			// ribbonButtonArticulos
			// 
			this.ribbonButtonArticulos.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArticulos.Image")));
			this.ribbonButtonArticulos.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArticulos.SmallImage")));
			this.ribbonButtonArticulos.Text = "Articulos";
			this.ribbonButtonArticulos.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
			this.ribbonButtonArticulos.Click += new System.EventHandler(this.RibbonButtonArticulosClick);
			// 
			// ribbonButtonTerceros
			// 
			this.ribbonButtonTerceros.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTerceros.Image")));
			this.ribbonButtonTerceros.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTerceros.SmallImage")));
			this.ribbonButtonTerceros.Text = "Terceros";
			this.ribbonButtonTerceros.Click += new System.EventHandler(this.RibbonButtonTercerosClick);
			// 
			// ribbonButtonDocumentos
			// 
			this.ribbonButtonDocumentos.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDocumentos.Image")));
			this.ribbonButtonDocumentos.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDocumentos.SmallImage")));
			this.ribbonButtonDocumentos.Text = "Documentos";
			this.ribbonButtonDocumentos.Click += new System.EventHandler(this.RibbonButtonDocumentosClick);
			// 
			// ribbonButtonComprobantes
			// 
			this.ribbonButtonComprobantes.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonComprobantes.Image")));
			this.ribbonButtonComprobantes.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonComprobantes.SmallImage")));
			this.ribbonButtonComprobantes.Text = "Comprobantes";
			this.ribbonButtonComprobantes.Click += new System.EventHandler(this.RibbonButtonComprobantesClick);
			// 
			// ribbonButtonInformes
			// 
			this.ribbonButtonInformes.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInformes.Image")));
			this.ribbonButtonInformes.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInformes.SmallImage")));
			this.ribbonButtonInformes.Text = "Informes";
			// 
			// ribbonButtonPreferencias
			// 
			this.ribbonButtonPreferencias.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPreferencias.Image")));
			this.ribbonButtonPreferencias.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPreferencias.SmallImage")));
			this.ribbonButtonPreferencias.Text = "Preferencias";
			this.ribbonButtonPreferencias.Click += new System.EventHandler(this.RibbonButtonPreferenciasClick);
			// 
			// ribbonButtonMaestros
			// 
			this.ribbonButtonMaestros.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonMaestros.Image")));
			this.ribbonButtonMaestros.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonMaestros.SmallImage")));
			this.ribbonButtonMaestros.Text = "Maestros";
			this.ribbonButtonMaestros.Click += new System.EventHandler(this.RibbonButtonMaestrosClick);
			// 
			// ribbonButtonSalir
			// 
			this.ribbonButtonSalir.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSalir.Image")));
			this.ribbonButtonSalir.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSalir.SmallImage")));
			this.ribbonButtonSalir.Text = "Salir";
			this.ribbonButtonSalir.Click += new System.EventHandler(this.RibbonButtonSalirClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lblInfo,
			this.lblUsuario,
			this.lblData});
			this.statusStrip1.Location = new System.Drawing.Point(0, 239);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(726, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblInfo
			// 
			this.lblInfo.Image = ((System.Drawing.Image)(resources.GetObject("lblInfo.Image")));
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(16, 17);
			// 
			// lblData
			// 
			this.lblData.Image = ((System.Drawing.Image)(resources.GetObject("lblData.Image")));
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(16, 17);
			// 
			// lblUsuario
			// 
			this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(16, 17);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(726, 261);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.ribbon1);
			this.DoubleBuffered = true;
			this.IsMdiContainer = true;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ElevenSQLite";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
