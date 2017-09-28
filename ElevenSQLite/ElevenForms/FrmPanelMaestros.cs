/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 12/09/2017
 * Hora: 8:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ElevenSQLite.ElevenCore;

namespace ElevenSQLite.ElevenForms
{
	/// <summary>
	/// Description of FrmPanelMaestros.
	/// </summary>
	public partial class FrmPanelMaestros : Form
	{
		void CargarSecciones()
		{
			dgvSecciones.DataSource = Seccion.GetAll();
		}
		void CargarPaises()
		{
			dgvPaises.DataSource = Pais.GetAll();
		}
		void CargarFamilias()
		{
			dgvFamilias.DataSource = Familia.GetAll();
		}
		void CargarCondicionesPago()
		{
			dgvCondicionesPago.DataSource = CondicionPago.GetAll();
		}
		void CargarBancos()
		{
			dgvBancos.DataSource = Banco.GetAll();
		}
		void CargarEstados()
		{
			dgvEstado.DataSource = Estado.GetAll();
		}
		void CargarCiudades()
		{
			dgvCiudades.DataSource = Ciudad.GetAll();
		}
		void CargarEmpleados()
		{
			dgvEmpleados.DataSource = Empleado.GetAll();
		}
		void CargarTarifasIVA()
		{
			dgvTarifasIVA.DataSource = TarifaIVA.GetAll();
		}
		void CargarUnidadMedida()
		{
			dgvUnidadComercial.DataSource = UnidadComercial.GetAll();
		}
		void CargarMonedas()
		{
			dgvMonedas.DataSource = TipoMoneda.GetAll();
		}
		public FrmPanelMaestros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmPanelMaestrosLoad(object sender, EventArgs e)
		{
			CargarSecciones();
			CargarPaises();
			CargarFamilias();
			CargarCondicionesPago();
			CargarBancos();
			CargarEstados();
			CargarTarifasIVA();
			CargarCiudades();
			CargarEmpleados();
			CargarUnidadMedida();
			CargarMonedas();
		}
		void FaTabStrip1TabStripItemSelectionChanged(FarsiLibrary.Win.TabStripItemChangedEventArgs e)
		{
			
		}
		void BtnNuevoClick(object sender, EventArgs e)
		{
			switch ( int.Parse(faTabStrip1.SelectedItem.Tag.ToString())) {
				case 0:
					var frmEmpleado = new FrmEmpleado();
					if(frmEmpleado.ShowDialog() == DialogResult.Yes){
						CargarEmpleados();
					}
					break;
				case 1:
					var frmCondicionPago = new FrmCondicionPago();
					if(frmCondicionPago.ShowDialog() == DialogResult.Yes){
						CargarCondicionesPago();
					}
					break;
				case 2:
					var frmEstado = new FrmEstado();
					if(frmEstado.ShowDialog() == DialogResult.Yes){
						CargarEstados();
					}
					break;
				case 3:
					var frmFamilia = new FrmFamilia();
					if(frmFamilia.ShowDialog() == DialogResult.Yes){
						CargarFamilias();
					}
					break;
				case 4:
					var frmUnidadComercial = new FrmUnidadComercial();
					if(frmUnidadComercial.ShowDialog() == DialogResult.Yes){
						CargarUnidadMedida();
					}
					break;
				case 5:
					var frmTarifaIVA = new FrmTarifaIVA();
					if(frmTarifaIVA.ShowDialog() == DialogResult.Yes){
						CargarTarifasIVA();
					}
					break;
				case 6:
					var frmTipoMoneda = new FrmTipoMoneda();
					if(frmTipoMoneda.ShowDialog() == DialogResult.Yes){
						CargarMonedas();
					}
					break;
				case 7:
					var frmBanco = new FrmBanco();
					if(frmBanco.ShowDialog() == DialogResult.Yes){
						CargarBancos();
					}
					break;
				case 8:
					var frmSeccion = new FrmSeccion();
					if(frmSeccion.ShowDialog() == DialogResult.Yes){
						CargarSecciones();
					}
					break;
				case 9:
					var frmCiudad = new FrmCiudad();
					if(frmCiudad.ShowDialog() == DialogResult.Yes){
						CargarCiudades();
					}
					break;
				case 10:
					var frmPais = new FrmPais();
					if(frmPais.ShowDialog() == DialogResult.Yes){
						CargarPaises();
					}
					break;
			}
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			switch ( int.Parse(faTabStrip1.SelectedItem.Tag.ToString())) {
				case 0:
					if(dgvEmpleados.SelectedRows.Count > 0){
						var emp = Empleado.FindByID(long.Parse(dgvEmpleados.CurrentRow.Cells["ID"].Value.ToString()));
						var frmEmpleado = new FrmEmpleado(emp);
						if(frmEmpleado.ShowDialog() == DialogResult.Yes){
							CargarEmpleados();
						}
					}
					break;			
				case 1:
					if(dgvCondicionesPago.SelectedRows.Count > 0){
						var cp = CondicionPago.FindByID(long.Parse(dgvCondicionesPago.CurrentRow.Cells["ID"].Value.ToString()));
						var frmCP = new FrmCondicionPago(cp);
						if(frmCP.ShowDialog() == DialogResult.Yes){
							CargarCondicionesPago();
						}
					}
					break;
				case 2:
					if(dgvEstado.SelectedRows.Count > 0){
						var est = Estado.FindByID(long.Parse(dgvEstado.CurrentRow.Cells["ID"].Value.ToString()));
						var frmEstado = new FrmEstado(est);
						if(frmEstado.ShowDialog() == DialogResult.Yes){
							CargarEstados();
						}
					}
					break;
				case 3:
					if(dgvFamilias.SelectedRows.Count > 0){
						var familia = Familia.FindByID(long.Parse(dgvFamilias.CurrentRow.Cells["ID"].Value.ToString()));
						var frmFamilia = new FrmFamilia(familia);
						if(frmFamilia.ShowDialog() == DialogResult.Yes){
							CargarFamilias();
						}
					}
					break;
				case 4:
					if(dgvUnidadComercial.SelectedRows.Count > 0){
						var unidad = UnidadComercial.FindByID(long.Parse(dgvUnidadComercial.CurrentRow.Cells["ID"].Value.ToString()));
						var frmUnidad = new FrmUnidadComercial(unidad);
						if(frmUnidad.ShowDialog() == DialogResult.Yes){
							CargarUnidadMedida();
						}
					}
					break;
				case 5:
					if(dgvTarifasIVA.SelectedRows.Count > 0){
						var iva = TarifaIVA.FindByID(long.Parse(dgvTarifasIVA.CurrentRow.Cells["ID"].Value.ToString()));
						var frmIva = new FrmTarifaIVA(iva);
						if(frmIva.ShowDialog() == DialogResult.Yes){
							CargarTarifasIVA();
						}
					}
					break;
				case 6:
					if(dgvMonedas.SelectedRows.Count > 0){
						var moneda = TipoMoneda.FindByID(long.Parse(dgvMonedas.CurrentRow.Cells["ID"].Value.ToString()));
						var frmMoneda = new FrmTipoMoneda(moneda);
						if(frmMoneda.ShowDialog() == DialogResult.Yes){
							CargarMonedas();
						}
					}
					break;
				case 7:
					if(dgvBancos.SelectedRows.Count > 0){
						var banco = Banco.FindByID(long.Parse(dgvBancos.CurrentRow.Cells["ID"].Value.ToString()));
						var frmBanco = new FrmBanco(banco);
						if(frmBanco.ShowDialog() == DialogResult.Yes){
							CargarBancos();
						}
					}
					break;
				case 8:
					if(dgvSecciones.SelectedRows.Count > 0){
						var seccion = Seccion.FindByID(long.Parse(dgvSecciones.CurrentRow.Cells["ID"].Value.ToString()));
						var frmSeccion = new FrmSeccion(seccion);
						if(frmSeccion.ShowDialog() == DialogResult.Yes){
							CargarSecciones();
						}
					}
					break;
				case 9:
					if(dgvUnidadComercial.SelectedRows.Count > 0){
						var unidad = UnidadComercial.FindByID(long.Parse(dgvUnidadComercial.CurrentRow.Cells["ID"].Value.ToString()));
						var frmUnidad = new FrmUnidadComercial(unidad);
						if(frmUnidad.ShowDialog() == DialogResult.Yes){
							CargarUnidadMedida();
						}
					}
					break;
				case 10:
					if(dgvCiudades.SelectedRows.Count > 0){
						var ciudad = Ciudad.FindByID(long.Parse(dgvCiudades.CurrentRow.Cells["ID"].Value.ToString()));
						var frmCiudad = new FrmCiudad(ciudad);
						if(frmCiudad.ShowDialog() == DialogResult.Yes){
							CargarCiudades();
						}
					}
					break;
			}
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			switch ( int.Parse(faTabStrip1.SelectedItem.Tag.ToString())) {
				case 0:
					if(dgvEmpleados.SelectedRows.Count > 0){
						var emp = Empleado.FindByID(long.Parse(dgvEmpleados.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar este empleado?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							emp.Delete();
							CargarEmpleados();
						}
					}
					break;
				case 1:
					if(dgvCondicionesPago.SelectedRows.Count > 0){
						var cp = CondicionPago.FindByID(long.Parse(dgvCondicionesPago.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar este condicion de pago?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							cp.Delete();
							CargarCondicionesPago();
						}
					}
					break;
				case 2:
					if(dgvEstado.SelectedRows.Count > 0){
						var est = Estado.FindByID(long.Parse(dgvEstado.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar este departamento?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							est.Delete();
							CargarEstados();
						}
					}
					break;
				case 3:
					if(dgvFamilias.SelectedRows.Count > 0){
						var fam = Familia.FindByID(long.Parse(dgvEstado.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar esta familia?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							fam.Delete();
							CargarFamilias();
						}
					}
					break;
				case 4:
					if(dgvUnidadComercial.SelectedRows.Count > 0){
						var unidad = UnidadComercial.FindByID(long.Parse(dgvEstado.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar esta unidad de medida?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							unidad.Delete();
							CargarUnidadMedida();
						}
					}
					break;
				case 5:
					if(dgvTarifasIVA.SelectedRows.Count > 0){
						var iva = TarifaIVA.FindByID(long.Parse(dgvTarifasIVA.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar esta tarifa IVA?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							iva.Delete();
							CargarTarifasIVA();
						}
					}
					break;
				case 6:
					if(dgvMonedas.SelectedRows.Count > 0){
						var moneda = TipoMoneda.FindByID(long.Parse(dgvMonedas.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar esta moneda?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							moneda.Delete();
							CargarMonedas();
						}
					}
					break;
				case 7:
					if(dgvBancos.SelectedRows.Count > 0){
						var banco = Banco.FindByID(long.Parse(dgvBancos.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar este banco?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							banco.Delete();
							CargarBancos();
						}
					}
					break;
				case 8:
					if(dgvSecciones.SelectedRows.Count > 0){
						var seccion = Seccion.FindByID(long.Parse(dgvSecciones.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar esta seccion?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							seccion.Delete();
							CargarSecciones();
						}
					}
					break;
				case 9:
					if(dgvCiudades.SelectedRows.Count > 0){
						var ciudad = Ciudad.FindByID(long.Parse(dgvCiudades.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar esta ciudad?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							ciudad.Delete();
							CargarCiudades();
						}
					}
					break;
				case 10:
					if(dgvPaises.SelectedRows.Count > 0){
						var pais = Pais.FindByID(long.Parse(dgvPaises.CurrentRow.Cells["ID"].Value.ToString()));
						if(MessageBox.Show("Desea eliminar este pais?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
							pais.Delete();
							CargarPaises();
						}
					}
					break;
			}
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show(this.Owner, "Desea cerrar esta ventada?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dr == DialogResult.Yes)
			{
				Close();
			}
		}
	}
}
