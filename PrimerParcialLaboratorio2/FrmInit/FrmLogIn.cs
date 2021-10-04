using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmInit
{
    public partial class FrmLogIn : Form
    {
        FrmMainMenu menuPrincipal;
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool existe = false;
            Empleado empleado = null;
            Administrador admin = null;
            if (!string.IsNullOrWhiteSpace(this.txtUsuario.Text))
            {
                if (!string.IsNullOrWhiteSpace(this.txtUsuario.Text))
                {
                    foreach (var user in Sistema.ListaEmpleados)
                    {
                        if (user.Usuario.Trim().ToLower().Equals(this.txtUsuario.Text.ToLower().Trim()) && user.Contrasenia.Trim().ToLower().Equals(this.txtClave.Text.ToLower().Trim()))
                        {
                            existe = true;
                            if (user is Administrador)
                            {
                                admin = (Administrador)user;
                            }
                            else
                            {
                                empleado = user;
                            }
                            break;
                        }
                    }
                    if (!existe)
                        MessageBox.Show("Usuario y/o Contrasena incorrecto/s");
                }
                else
                {
                    MessageBox.Show("Ingrese Contrasena");
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese Usuario");
                txtUsuario.Focus();
            }

            if (existe && !(admin is null))
            {
                menuPrincipal = new FrmMainMenu(admin);
                menuPrincipal.ShowDialog();
                this.Hide();
            }
            else if (existe && !(empleado is null))
            {
                menuPrincipal = new FrmMainMenu(empleado);
                menuPrincipal.ShowDialog();
                this.Hide();
            }
        }

        private void btnLogInAsEmp_Click(object sender, EventArgs e)
        {
            foreach (Empleado item in Sistema.ListaEmpleados)
            {
                if (!(item is Administrador))
                {
                    this.txtUsuario.Text = item.Usuario;
                    this.txtClave.Text = item.Contrasenia;
                }
            }
        }

        private void btnLogInAsAdm_Click(object sender, EventArgs e)
        {
            foreach (Empleado item in Sistema.ListaEmpleados)
            {
                if (item is Administrador)
                {
                    this.txtUsuario.Text = item.Usuario;
                    this.txtClave.Text = item.Contrasenia;
                }
            }
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
