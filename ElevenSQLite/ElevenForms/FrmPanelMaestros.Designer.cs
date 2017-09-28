/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 12/09/2017
 * Hora: 8:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ElevenSQLite.ElevenForms
{
	partial class FrmPanelMaestros
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private FarsiLibrary.Win.FATabStrip faTabStrip1;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemCiudad;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemEstado;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemBancos;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemCondicionPago;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemEmpleados;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemFamilias;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemPais;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemSecciones;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemIVA;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemTiposMoneda;
		private FarsiLibrary.Win.FATabStripItem faTabStripItemUnidades;		
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btnNuevo;
		private System.Windows.Forms.ToolStripButton btnModificar;
		private System.Windows.Forms.ToolStripButton btnEliminar;
		private System.Windows.Forms.ToolStripButton btnCerrar;
		private System.Windows.Forms.DataGridView dgvSecciones;
		private System.Windows.Forms.DataGridView dgvPaises;
		private System.Windows.Forms.DataGridView dgvFamilias;
		private System.Windows.Forms.DataGridView dgvCondicionesPago;
		private System.Windows.Forms.DataGridView dgvBancos;
		private System.Windows.Forms.DataGridView dgvEstado;
		private System.Windows.Forms.DataGridView dgvCiudades;
		private System.Windows.Forms.DataGridView dgvEmpleados;
		private System.Windows.Forms.DataGridView dgvTarifasIVA;		
		private System.Windows.Forms.DataGridView dgvUnidadComercial;
		private System.Windows.Forms.DataGridView dgvMonedas;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPanelMaestros));
			this.faTabStrip1 = new FarsiLibrary.Win.FATabStrip();
			this.faTabStripItemTiposMoneda = new FarsiLibrary.Win.FATabStripItem();
			this.dgvMonedas = new System.Windows.Forms.DataGridView();
			this.faTabStripItemEmpleados = new FarsiLibrary.Win.FATabStripItem();
			this.dgvEmpleados = new System.Windows.Forms.DataGridView();
			this.faTabStripItemCondicionPago = new FarsiLibrary.Win.FATabStripItem();
			this.dgvCondicionesPago = new System.Windows.Forms.DataGridView();
			this.faTabStripItemEstado = new FarsiLibrary.Win.FATabStripItem();
			this.dgvEstado = new System.Windows.Forms.DataGridView();
			this.faTabStripItemFamilias = new FarsiLibrary.Win.FATabStripItem();
			this.dgvFamilias = new System.Windows.Forms.DataGridView();
			this.faTabStripItemUnidades = new FarsiLibrary.Win.FATabStripItem();
			this.dgvUnidadComercial = new System.Windows.Forms.DataGridView();
			this.faTabStripItemIVA = new FarsiLibrary.Win.FATabStripItem();
			this.dgvTarifasIVA = new System.Windows.Forms.DataGridView();
			this.faTabStripItemBancos = new FarsiLibrary.Win.FATabStripItem();
			this.dgvBancos = new System.Windows.Forms.DataGridView();
			this.faTabStripItemSecciones = new FarsiLibrary.Win.FATabStripItem();
			this.dgvSecciones = new System.Windows.Forms.DataGridView();
			this.faTabStripItemCiudad = new FarsiLibrary.Win.FATabStripItem();
			this.dgvCiudades = new System.Windows.Forms.DataGridView();
			this.faTabStripItemPais = new FarsiLibrary.Win.FATabStripItem();
			this.dgvPaises = new System.Windows.Forms.DataGridView();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnNuevo = new System.Windows.Forms.ToolStripButton();
			this.btnModificar = new System.Windows.Forms.ToolStripButton();
			this.btnEliminar = new System.Windows.Forms.ToolStripButton();
			this.btnCerrar = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.faTabStrip1)).BeginInit();
			this.faTabStrip1.SuspendLayout();
			this.faTabStripItemTiposMoneda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMonedas)).BeginInit();
			this.faTabStripItemEmpleados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
			this.faTabStripItemCondicionPago.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCondicionesPago)).BeginInit();
			this.faTabStripItemEstado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).BeginInit();
			this.faTabStripItemFamilias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).BeginInit();
			this.faTabStripItemUnidades.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUnidadComercial)).BeginInit();
			this.faTabStripItemIVA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTarifasIVA)).BeginInit();
			this.faTabStripItemBancos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).BeginInit();
			this.faTabStripItemSecciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSecciones)).BeginInit();
			this.faTabStripItemCiudad.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
			this.faTabStripItemPais.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).BeginInit();
			this.toolStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// faTabStrip1
			// 
			this.faTabStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.faTabStrip1.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
			this.faTabStripItemTiposMoneda,
			this.faTabStripItemEmpleados,
			this.faTabStripItemCondicionPago,
			this.faTabStripItemEstado,
			this.faTabStripItemFamilias,
			this.faTabStripItemUnidades,
			this.faTabStripItemIVA,
			this.faTabStripItemBancos,
			this.faTabStripItemSecciones,
			this.faTabStripItemCiudad,
			this.faTabStripItemPais});
			this.faTabStrip1.Location = new System.Drawing.Point(12, 28);
			this.faTabStrip1.Name = "faTabStrip1";
			this.faTabStrip1.SelectedItem = this.faTabStripItemTiposMoneda;
			this.faTabStrip1.Size = new System.Drawing.Size(642, 498);
			this.faTabStrip1.TabIndex = 0;
			this.faTabStrip1.TabStripItemSelectionChanged += new FarsiLibrary.Win.TabStripItemChangedHandler(this.FaTabStrip1TabStripItemSelectionChanged);
			// 
			// faTabStripItemTiposMoneda
			// 
			this.faTabStripItemTiposMoneda.Controls.Add(this.dgvMonedas);
			this.faTabStripItemTiposMoneda.IsDrawn = true;
			this.faTabStripItemTiposMoneda.Name = "faTabStripItemTiposMoneda";
			this.faTabStripItemTiposMoneda.Selected = true;
			this.faTabStripItemTiposMoneda.TabIndex = 11;
			this.faTabStripItemTiposMoneda.Tag = "6";
			this.faTabStripItemTiposMoneda.Title = "Monedas";
			// 
			// dgvMonedas
			// 
			this.dgvMonedas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMonedas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvMonedas.Location = new System.Drawing.Point(0, 0);
			this.dgvMonedas.MultiSelect = false;
			this.dgvMonedas.Name = "dgvMonedas";
			this.dgvMonedas.ReadOnly = true;
			this.dgvMonedas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMonedas.Size = new System.Drawing.Size(640, 477);
			this.dgvMonedas.TabIndex = 6;
			// 
			// faTabStripItemEmpleados
			// 
			this.faTabStripItemEmpleados.Controls.Add(this.dgvEmpleados);
			this.faTabStripItemEmpleados.IsDrawn = true;
			this.faTabStripItemEmpleados.Name = "faTabStripItemEmpleados";
			this.faTabStripItemEmpleados.TabIndex = 5;
			this.faTabStripItemEmpleados.Tag = "0";
			this.faTabStripItemEmpleados.Title = "Empleados";
			// 
			// dgvEmpleados
			// 
			this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEmpleados.Location = new System.Drawing.Point(0, 0);
			this.dgvEmpleados.MultiSelect = false;
			this.dgvEmpleados.Name = "dgvEmpleados";
			this.dgvEmpleados.ReadOnly = true;
			this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmpleados.Size = new System.Drawing.Size(200, 100);
			this.dgvEmpleados.TabIndex = 7;
			// 
			// faTabStripItemCondicionPago
			// 
			this.faTabStripItemCondicionPago.Controls.Add(this.dgvCondicionesPago);
			this.faTabStripItemCondicionPago.IsDrawn = true;
			this.faTabStripItemCondicionPago.Name = "faTabStripItemCondicionPago";
			this.faTabStripItemCondicionPago.TabIndex = 1;
			this.faTabStripItemCondicionPago.Tag = "1";
			this.faTabStripItemCondicionPago.Title = "Condiciones de  Pago";
			// 
			// dgvCondicionesPago
			// 
			this.dgvCondicionesPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvCondicionesPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCondicionesPago.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCondicionesPago.Location = new System.Drawing.Point(0, 0);
			this.dgvCondicionesPago.MultiSelect = false;
			this.dgvCondicionesPago.Name = "dgvCondicionesPago";
			this.dgvCondicionesPago.ReadOnly = true;
			this.dgvCondicionesPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCondicionesPago.Size = new System.Drawing.Size(200, 100);
			this.dgvCondicionesPago.TabIndex = 3;
			// 
			// faTabStripItemEstado
			// 
			this.faTabStripItemEstado.Controls.Add(this.dgvEstado);
			this.faTabStripItemEstado.IsDrawn = true;
			this.faTabStripItemEstado.Name = "faTabStripItemEstado";
			this.faTabStripItemEstado.TabIndex = 4;
			this.faTabStripItemEstado.Tag = "2";
			this.faTabStripItemEstado.Title = "Departamentos";
			// 
			// dgvEstado
			// 
			this.dgvEstado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEstado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEstado.Location = new System.Drawing.Point(0, 0);
			this.dgvEstado.MultiSelect = false;
			this.dgvEstado.Name = "dgvEstado";
			this.dgvEstado.ReadOnly = true;
			this.dgvEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEstado.Size = new System.Drawing.Size(200, 100);
			this.dgvEstado.TabIndex = 5;
			// 
			// faTabStripItemFamilias
			// 
			this.faTabStripItemFamilias.Controls.Add(this.dgvFamilias);
			this.faTabStripItemFamilias.IsDrawn = true;
			this.faTabStripItemFamilias.Name = "faTabStripItemFamilias";
			this.faTabStripItemFamilias.TabIndex = 6;
			this.faTabStripItemFamilias.Tag = "3";
			this.faTabStripItemFamilias.Title = "Familias";
			// 
			// dgvFamilias
			// 
			this.dgvFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFamilias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvFamilias.Location = new System.Drawing.Point(0, 0);
			this.dgvFamilias.MultiSelect = false;
			this.dgvFamilias.Name = "dgvFamilias";
			this.dgvFamilias.ReadOnly = true;
			this.dgvFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFamilias.Size = new System.Drawing.Size(200, 100);
			this.dgvFamilias.TabIndex = 2;
			// 
			// faTabStripItemUnidades
			// 
			this.faTabStripItemUnidades.CanClose = false;
			this.faTabStripItemUnidades.Controls.Add(this.dgvUnidadComercial);
			this.faTabStripItemUnidades.IsDrawn = true;
			this.faTabStripItemUnidades.Name = "faTabStripItemUnidades";
			this.faTabStripItemUnidades.TabIndex = 12;
			this.faTabStripItemUnidades.Tag = "4";
			this.faTabStripItemUnidades.Title = "Unidades de Medida";
			// 
			// dgvUnidadComercial
			// 
			this.dgvUnidadComercial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvUnidadComercial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUnidadComercial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUnidadComercial.Location = new System.Drawing.Point(0, 0);
			this.dgvUnidadComercial.MultiSelect = false;
			this.dgvUnidadComercial.Name = "dgvUnidadComercial";
			this.dgvUnidadComercial.ReadOnly = true;
			this.dgvUnidadComercial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUnidadComercial.Size = new System.Drawing.Size(200, 100);
			this.dgvUnidadComercial.TabIndex = 3;
			// 
			// faTabStripItemIVA
			// 
			this.faTabStripItemIVA.Controls.Add(this.dgvTarifasIVA);
			this.faTabStripItemIVA.Name = "faTabStripItemIVA";
			this.faTabStripItemIVA.TabIndex = 10;
			this.faTabStripItemIVA.Tag = "5";
			this.faTabStripItemIVA.Title = "Tarifas IVA";
			// 
			// dgvTarifasIVA
			// 
			this.dgvTarifasIVA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvTarifasIVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTarifasIVA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTarifasIVA.Location = new System.Drawing.Point(0, 0);
			this.dgvTarifasIVA.MultiSelect = false;
			this.dgvTarifasIVA.Name = "dgvTarifasIVA";
			this.dgvTarifasIVA.ReadOnly = true;
			this.dgvTarifasIVA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTarifasIVA.Size = new System.Drawing.Size(200, 100);
			this.dgvTarifasIVA.TabIndex = 2;
			// 
			// faTabStripItemBancos
			// 
			this.faTabStripItemBancos.Controls.Add(this.dgvBancos);
			this.faTabStripItemBancos.Name = "faTabStripItemBancos";
			this.faTabStripItemBancos.TabIndex = 0;
			this.faTabStripItemBancos.Tag = "7";
			this.faTabStripItemBancos.Title = "Bancos";
			// 
			// dgvBancos
			// 
			this.dgvBancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBancos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBancos.Location = new System.Drawing.Point(0, 0);
			this.dgvBancos.MultiSelect = false;
			this.dgvBancos.Name = "dgvBancos";
			this.dgvBancos.ReadOnly = true;
			this.dgvBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBancos.Size = new System.Drawing.Size(200, 100);
			this.dgvBancos.TabIndex = 4;
			// 
			// faTabStripItemSecciones
			// 
			this.faTabStripItemSecciones.Controls.Add(this.dgvSecciones);
			this.faTabStripItemSecciones.Name = "faTabStripItemSecciones";
			this.faTabStripItemSecciones.TabIndex = 8;
			this.faTabStripItemSecciones.Tag = "8";
			this.faTabStripItemSecciones.Title = "Secciones";
			// 
			// dgvSecciones
			// 
			this.dgvSecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvSecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSecciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSecciones.Location = new System.Drawing.Point(0, 0);
			this.dgvSecciones.MultiSelect = false;
			this.dgvSecciones.Name = "dgvSecciones";
			this.dgvSecciones.ReadOnly = true;
			this.dgvSecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSecciones.Size = new System.Drawing.Size(200, 100);
			this.dgvSecciones.TabIndex = 0;
			// 
			// faTabStripItemCiudad
			// 
			this.faTabStripItemCiudad.Controls.Add(this.dgvCiudades);
			this.faTabStripItemCiudad.Name = "faTabStripItemCiudad";
			this.faTabStripItemCiudad.TabIndex = 2;
			this.faTabStripItemCiudad.Tag = "9";
			this.faTabStripItemCiudad.Title = "Ciudades";
			// 
			// dgvCiudades
			// 
			this.dgvCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCiudades.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCiudades.Location = new System.Drawing.Point(0, 0);
			this.dgvCiudades.MultiSelect = false;
			this.dgvCiudades.Name = "dgvCiudades";
			this.dgvCiudades.ReadOnly = true;
			this.dgvCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCiudades.Size = new System.Drawing.Size(200, 100);
			this.dgvCiudades.TabIndex = 6;
			// 
			// faTabStripItemPais
			// 
			this.faTabStripItemPais.Controls.Add(this.dgvPaises);
			this.faTabStripItemPais.Name = "faTabStripItemPais";
			this.faTabStripItemPais.TabIndex = 7;
			this.faTabStripItemPais.Tag = "10";
			this.faTabStripItemPais.Title = "Paises";
			// 
			// dgvPaises
			// 
			this.dgvPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPaises.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvPaises.Location = new System.Drawing.Point(0, 0);
			this.dgvPaises.MultiSelect = false;
			this.dgvPaises.Name = "dgvPaises";
			this.dgvPaises.ReadOnly = true;
			this.dgvPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPaises.Size = new System.Drawing.Size(200, 100);
			this.dgvPaises.TabIndex = 1;
			// 
			// toolStrip2
			// 
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.btnNuevo,
			this.btnModificar,
			this.btnEliminar,
			this.btnCerrar});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(669, 25);
			this.toolStrip2.TabIndex = 2;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(62, 22);
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(78, 22);
			this.btnModificar.Text = "Modificar";
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(70, 22);
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(59, 22);
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// FrmPanelMaestros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 538);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.faTabStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmPanelMaestros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Maestros";
			this.Load += new System.EventHandler(this.FrmPanelMaestrosLoad);
			((System.ComponentModel.ISupportInitialize)(this.faTabStrip1)).EndInit();
			this.faTabStrip1.ResumeLayout(false);
			this.faTabStripItemTiposMoneda.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvMonedas)).EndInit();
			this.faTabStripItemEmpleados.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
			this.faTabStripItemCondicionPago.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCondicionesPago)).EndInit();
			this.faTabStripItemEstado.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).EndInit();
			this.faTabStripItemFamilias.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).EndInit();
			this.faTabStripItemUnidades.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUnidadComercial)).EndInit();
			this.faTabStripItemIVA.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTarifasIVA)).EndInit();
			this.faTabStripItemBancos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).EndInit();
			this.faTabStripItemSecciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSecciones)).EndInit();
			this.faTabStripItemCiudad.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
			this.faTabStripItemPais.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).EndInit();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
