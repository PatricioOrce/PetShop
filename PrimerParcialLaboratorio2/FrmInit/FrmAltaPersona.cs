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
    public partial class FrmAltaPersona : Form
    {
        string task;
        public FrmAltaPersona(string task)
        {
            InitializeComponent();
            this.task = task;
        }
        private void FrmAltaPersona_Load(object sender, EventArgs e)
        {
            this.txtCashInput.Visible = false;
            this.lblPesosSign.Visible = false;
            switch (task)
            {
                case "Cliente":
                    AddClientView();
                    break;
                case "Empleado":
                    AddEmployeeView();
                    break;
                case "Admin":
                    AddEmployeeView();
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// Maneja la visibilidad del formulario y sus elementos en relacion a los datos del cliente.
        /// </summary>
        private void AddClientView()
        {
            this.lblAltaPersonaText.Text = $"Alta {task}";
            this.txtCashInput.Visible = true;
            this.lblPesosSign.Visible = true;
            this.txtUserInput.Visible = false;
            this.txtPassInput.Visible = false;
        }
        /// <summary>
        /// Maneja la visibilidad del formulario y sus elementos en relacion a los datos del cliente.
        /// </summary>
        private void AddEmployeeView()
        {
            this.lblAltaPersonaText.Text = $"Alta {task}";
            this.txtUserInput.Visible = true;
            this.txtPassInput.Visible = true;
        }
        /// <summary>
        /// Verifica que los datos ingresados en los textbox sean validos.
        /// </summary>
        /// <returns>Devuelve true en caso de ser validos, de lo contrario devuelve false.</returns>
        private bool VerifyPersonInfo()
        {
            int fullFields = 0;
            if (!string.IsNullOrWhiteSpace(this.txtNameInput.Text) && Validar.IsNombre(this.txtNameInput.Text))
            {
                fullFields += 1;
            }
            else
            {
                epErrores.SetError(txtNameInput, "Nombre Invalido");
                txtNameInput.Focus();
            }
            if (!string.IsNullOrWhiteSpace(this.txtSurnameInput.Text) && Validar.IsNombre(this.txtSurnameInput.Text))
            {
                fullFields += 1;
            }
            else
            {
                epErrores.SetError(txtSurnameInput, "Apellido Invalido");
                txtSurnameInput.Focus();
            }
            if (!string.IsNullOrWhiteSpace(this.txtDniInput.Text) && Validar.IsDNI(this.txtDniInput.Text) && Sistema.FindByDNI(Sistema.ListaEmpleados, this.txtDniInput.Text) is null)
            {
                fullFields += 1;
            }
            else
            {
                epErrores.SetError(txtDniInput, "DNI Invalido");
                txtDniInput.Focus();
            }
            if (fullFields == 3)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica que los datos ingresados en los textbox sean validos.
        /// </summary>
        /// <returns>Devuelve true en caso de ser validados, de lo contrario devuelve false.</returns>
        private bool VerifyAccountInfo()
        {
            int fullFields = 0;
            if (!string.IsNullOrWhiteSpace(this.txtUserInput.Text) && Validar.IsUsername(this.txtUserInput.Text))
            {
                fullFields += 1;
            }
            else
            {
                epErrores.SetError(txtUserInput, "Usuario Invalido");
                txtUserInput.Focus();
            }
            if (!string.IsNullOrWhiteSpace(this.txtPassInput.Text) && Validar.IsPassword(this.txtPassInput.Text))
            {
                fullFields += 1;

            }
            else
            {
                epErrores.SetError(txtPassInput, "Clave Invalida");
                txtPassInput.Focus();
            }
            if (fullFields == 2)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Realiza el alta de un empleado en caso de que se verifique.
        /// </summary>
        private void AddEmpleado()
        {
            epErrores.Clear();
            Empleado auxEmpleado;

            if (VerifyPersonInfo() && VerifyAccountInfo())
            {
                auxEmpleado = new Empleado(this.txtNameInput.Text, this.txtSurnameInput.Text, this.txtDniInput.Text,
                            this.txtUserInput.Text, this.txtPassInput.Text);
                Sistema.ListaEmpleados.Add(auxEmpleado);
                MessageBox.Show("Empleado Cargado");
                this.Close();
            }
        }
        /// <summary>
        /// Realiza el alta de un admin en caso de que los datos sean correctos.
        /// </summary>
        private void AddAdmin()
        {
            epErrores.Clear();
            Administrador auxAdmin;

            if (VerifyPersonInfo() && VerifyAccountInfo())
            {
                auxAdmin = new Administrador(this.txtNameInput.Text, this.txtSurnameInput.Text, this.txtDniInput.Text,
                            this.txtUserInput.Text, this.txtPassInput.Text);
                Sistema.ListaEmpleados.Add(auxAdmin);
                MessageBox.Show("Admin Cargado");
                this.Close();
            }
        }
        /// <summary>
        /// Realiza el alta de un cliente en caso de que los datos sean correctos.
        /// </summary>
        private void AddClient()
        {
            bool flagSalary = false; ;
            epErrores.Clear();
            Cliente auxCliente;
            if (double.TryParse(this.txtCashInput.Text, out double saldo))
            {
                if (!string.IsNullOrWhiteSpace(this.txtCashInput.Text) && Validar.IsSaldo(saldo))
                {
                    flagSalary = true;
                }
            }
            if (VerifyPersonInfo() && flagSalary)
            {
                auxCliente = new Cliente(this.txtNameInput.Text, this.txtSurnameInput.Text, this.txtDniInput.Text, saldo);
                Sistema.ListaClientes.Add(auxCliente);
                MessageBox.Show("Cliente Cargado");
                this.Close();
            }
        }
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            switch (task)
            {
                case "Empleado":
                    AddEmpleado();
                    break;
                case "Cliente":
                    AddClient();
                    break;
                case "Admin":
                    AddAdmin();
                    break;
                default:
                    break;
            }
        }
        private void btnCancelCrear_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
