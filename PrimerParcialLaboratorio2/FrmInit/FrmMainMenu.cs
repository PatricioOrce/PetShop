using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmInit
{
    public partial class FrmMainMenu : Form
    {
        #region WeirdStuff
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        FrmABMProduct formularioProds;
        FrmLogIn logOut;
        FrmAltaPersona nuevaPersona;
        FrmListar formularioListar;
        FrmVentas formularioVentas;
        FrmEditOrBajaPersona formularioEditOrBaja;
        FrmListaGeneral listaGeneral;
        Empleado comodin;
        
        bool rango;
        private FrmMainMenu()
        {
            InitializeComponent();
        }
        public FrmMainMenu(Empleado empleado) : this()
        {
            this.comodin = empleado;
            this.rango = false;
        }
        public FrmMainMenu(Administrador empleado) : this()
        {
            this.comodin = empleado;
            this.rango = true;
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            if (!rango)
            { 
                EmployeeView();
                this.BackColor = Color.AliceBlue;
            }
        }

        private void LogOut()
        {
            logOut = new FrmLogIn();
            logOut.Show();
            this.Close();
        }

        private void EmployeeView()
        {
            this.btnEditOrDelete.Enabled = false;
            this.btnFacturacion.Enabled = false;
            this.btnListEmployees.Enabled = false;
            this.btnListProducts.Enabled = false;
            this.btnListPersonas.Enabled = false;
            this.btnNewAdmin.Enabled = false;
            this.btnNewEmployee.Enabled = false;
            this.btnNewProduct.Enabled = false;
        }

        private void hidePanels()
        {
            if (this.panelAltas.Visible)
                this.panelAltas.Visible = false;
            if (this.panelModify.Visible)
                this.panelModify.Visible = false;
            if (this.panelListar.Visible)
                this.panelListar.Visible = false;

        }

        private void showPanels(Panel panel)
        {
            if (panel.Visible == false)
            {
                hidePanels();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void picHideScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBackToNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.picMaxScreen.Visible = true;
            this.picBackToNormal.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.picMaxScreen.Visible = false;
            this.picBackToNormal.Visible = true;
        }

        private void btnNewEntity_Click(object sender, EventArgs e)
        {
            showPanels(this.panelAltas);
        }

        private void btnEditOrDelete_Click(object sender, EventArgs e)
        {
            showPanels(this.panelModify);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            showPanels(this.panelListar);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de querer cerrar sesion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogOut();
            }
            
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            formularioVentas = new FrmVentas();
            formularioVentas.ShowDialog();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            nuevaPersona = new FrmAltaPersona("Cliente");
            nuevaPersona.ShowDialog();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            nuevaPersona = new FrmAltaPersona("Empleado");
            nuevaPersona.ShowDialog();
        }

        private void btnNewAdmin_Click(object sender, EventArgs e)
        {
            nuevaPersona = new FrmAltaPersona("Admin");
            nuevaPersona.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            formularioListar = new FrmListar("Facturacion");
            formularioListar.Show();
        }

        private void btnListClients_Click(object sender, EventArgs e)
        {
            formularioListar = new FrmListar("Cliente");
            formularioListar.Show();
        }

        private void btnListEmployees_Click(object sender, EventArgs e)
        {
            formularioListar = new FrmListar("Empleado");
            formularioListar.Show();
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            formularioListar = new FrmListar("Producto");
            formularioListar.Show();
        }

        private void btnListPersonas_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyClient_Click(object sender, EventArgs e)
        {
            formularioEditOrBaja = new FrmEditOrBajaPersona("Cliente");
            formularioEditOrBaja.ShowDialog();
        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            formularioEditOrBaja = new FrmEditOrBajaPersona("Empleado");
            formularioEditOrBaja.ShowDialog();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {

        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            formularioProds = new FrmABMProduct();
            formularioProds.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            listaGeneral = new FrmListaGeneral("Help");
            listaGeneral.Show();
        }
    }
}
