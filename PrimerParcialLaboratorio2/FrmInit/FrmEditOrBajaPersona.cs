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
    public partial class FrmEditOrBajaPersona : Form
    {
        string task;
        public FrmEditOrBajaPersona(string task)
        {
            InitializeComponent();
            this.task = task;
        }

        private void FrmEditOrBajaPersona_Load(object sender, EventArgs e)
        {
            if (task.Equals("Cliente"))
            {
                FillClientDataGrid();
                this.dtgvEmpleados.Visible = false;
                this.dtgvClients.Visible = true;
                this.txtCashInput.Visible = true;
                this.lblPesosSign.Visible = false;
            }
            else if (task.Equals("Empleado"))
            {
                FillEmployeeDataGrid();
                this.dtgvEmpleados.Visible = true;
                this.dtgvClients.Visible = false;
            }

        }
        /// <summary>
        /// Edita los datos del empleado en caso de que sean validos.
        /// </summary>
        /// <param name="dni"></param>
        private void EditEmployee(string dni)
        {
            this.lblError.Text = " ";
            Empleado auxEmployee;
            int modification = 0;
            if (!(dni is null))
            {
                auxEmployee = Sistema.FindByDNI(Sistema.ListaEmpleados, dni);
                if (!(auxEmployee is null))
                {
                    if (!String.IsNullOrWhiteSpace(this.txtNameInput.Text))
                    {
                        if (Validar.IsNombre(this.txtNameInput.Text))
                        {
                            modification += 1;
                            auxEmployee.Nombre = this.txtNameInput.Text;
                        }
                        else
                        {
                            epError.SetError(this.txtNameInput, "Nombre Invalido");
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(this.txtSurnameInput.Text))
                    {
                        if (Validar.IsNombre(this.txtSurnameInput.Text))
                        {
                            modification += 1;
                            auxEmployee.Apellido = this.txtSurnameInput.Text;
                        }
                        else
                        {
                            epError.SetError(this.txtSurnameInput, "Apellido Invalido");
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(this.txtDniInput.Text))
                    {
                        if (Validar.IsDNI(this.txtDniInput.Text))
                        {
                            if (!Validar.ExistingDNI(Sistema.ListaEmpleados, this.txtDniInput.Text))
                            {
                                modification += 1;
                                auxEmployee.DNI = this.txtDniInput.Text;
                            }
                            else
                            {
                                epError.SetError(this.txtDniInput, "Este DNI ya Existe");
                            }
                        }
                        else
                        {
                            epError.SetError(this.txtDniInput, "DNI Invalido");
                        }
                    }
                }
                if (modification > 0)
                {
                    dtgvEmpleados.Rows.Clear();
                    FillEmployeeDataGrid();
                }
                else
                {
                    this.lblError.Text = "No se ingreso ningun campo para modificar.";
                }

            }
        }
        /// <summary>
        /// Edita los datos del Administrador en caso de que sean validos.
        /// </summary>
        /// <param name="dni"></param>
        private void EditAdmin(string dni)
        {
            this.lblError.Text = " ";
            Administrador auxAdmin;
            int modification = 0;
            if (!(dni is null))
            {
                auxAdmin = (Administrador)Sistema.FindByDNI(Sistema.ListaEmpleados, dni);
                if (!(auxAdmin is null))
                {
                    if (!String.IsNullOrWhiteSpace(this.txtNameInput.Text))
                    {
                        if (Validar.IsNombre(this.txtNameInput.Text))
                        {
                            modification += 1;
                            auxAdmin.Nombre = this.txtNameInput.Text;
                        }
                        else
                        {
                            epError.SetError(this.txtNameInput, "Nombre Invalido");
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(this.txtSurnameInput.Text))
                    {
                        if (Validar.IsNombre(this.txtSurnameInput.Text))
                        {
                            modification += 1;
                            auxAdmin.Apellido = this.txtSurnameInput.Text;
                        }
                        else
                        {
                            epError.SetError(this.txtSurnameInput, "Apellido Invalido");
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(this.txtDniInput.Text))
                    {
                        if (Validar.IsDNI(this.txtDniInput.Text))
                        {
                            if (!Validar.ExistingDNI(Sistema.ListaEmpleados, this.txtDniInput.Text))
                            {
                                modification += 1;
                                auxAdmin.DNI = this.txtDniInput.Text;
                            }
                            else
                            {
                                epError.SetError(this.txtDniInput, "Este DNI ya Existe");
                            }
                        }
                        else
                        {
                            epError.SetError(this.txtDniInput, "DNI Invalido");
                        }
                    }
                }
                if (modification > 0)
                {
                    dtgvEmpleados.Rows.Clear();
                    FillEmployeeDataGrid();
                }
                else
                {
                    this.lblError.Text = "No se ingreso ningun campo para modificar.";
                }

            }
        }
        /// <summary>
        /// Edita los datos del cliente en caso de que sean validos.
        /// </summary>
        /// <param name="dni"></param>
        private void EditClient(string dni)
        {
            this.lblError.Text = " ";
            Cliente auxCliente;
            int modification = 0;
            if (!(dni is null))
            {
                auxCliente = Sistema.FindByDNI(Sistema.ListaClientes, dni);
                if (!(auxCliente is null))
                {
                    if (!String.IsNullOrWhiteSpace(this.txtNameInput.Text))
                    {
                        if (Validar.IsNombre(this.txtNameInput.Text))
                        {
                            modification += 1;
                            auxCliente.Nombre = this.txtNameInput.Text;
                        }
                        else
                        {
                            epError.SetError(this.txtNameInput, "Nombre Invalido");
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(this.txtSurnameInput.Text))
                    {
                        if (Validar.IsNombre(this.txtSurnameInput.Text))
                        {
                            modification += 1;
                            auxCliente.Apellido = this.txtSurnameInput.Text;
                        }
                        else
                        {
                            epError.SetError(this.txtSurnameInput, "Apellido Invalido");
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(this.txtDniInput.Text))
                    {
                        if (Validar.IsDNI(this.txtDniInput.Text))
                        {
                            if (!Validar.ExistingDNI(Sistema.ListaEmpleados, this.txtDniInput.Text))
                            {
                                modification += 1;
                                auxCliente.DNI = this.txtDniInput.Text;
                            }
                            else
                            {
                                epError.SetError(this.txtDniInput, "Este DNI ya Existe");
                            }
                        }
                        else
                        {
                            epError.SetError(this.txtDniInput, "DNI Invalido");
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(this.txtCashInput.Text) && Validar.IsSaldo(this.txtCashInput.Text))
                    {
                        modification += 1;
                        auxCliente.Saldo = double.Parse(this.txtCashInput.Text);
                    }
                }
                if (modification > 0)
                {
                    dtgvClients.Rows.Clear();
                    FillClientDataGrid();
                }
                else
                {
                    this.lblError.Text = "No se ingreso ningun campo para modificar.";
                }

            }
        }
        /// <summary>
        /// Elimina al empleado mediante su id, en caso de existir.
        /// </summary>
        /// <param name="dni"></param>
        private void DeleteEmployee(string dni)
        {
            Empleado auxEmpleado;
            if (!(dni is null))
            {
                if (Validar.ExistingDNI(Sistema.ListaEmpleados, dni))
                {
                    auxEmpleado = Sistema.FindByDNI(Sistema.ListaEmpleados, dni);
                    if (!(auxEmpleado is null))
                    {
                        if (MessageBox.Show("El Usuario se eliminara permanentemente, estas seguro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Sistema.ListaEmpleados.Remove(auxEmpleado);
                            dtgvEmpleados.Rows.Clear();
                            FillEmployeeDataGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid DNI");
                    }
                }
            }
        }
        /// <summary>
        /// Elimina al cliente mediante su id, en caso de existir.
        /// </summary>
        /// <param name="dni"></param>
        private void DeleteClient(string dni)
        {
            Cliente auxCliente;
            if (!(dni is null))
            {
                if (Validar.ExistingDNI(Sistema.ListaClientes, dni))
                {
                    auxCliente = Sistema.FindByDNI(Sistema.ListaClientes, dni);
                    if (!(auxCliente is null))
                    {
                        if (MessageBox.Show("El Usuario se eliminara permanentemente, estas seguro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Sistema.ListaClientes.Remove(auxCliente);
                            dtgvClients.Rows.Clear();
                            FillClientDataGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid DNI");
                    }
                }
            }
        }
        /// <summary>
        /// Rellena el DataGridView con los datos de los empleados
        /// </summary>
        private void FillEmployeeDataGrid()
        {
            foreach (var user in Sistema.ListaEmpleados)
            {
                int n = dtgvEmpleados.Rows.Add();
                if (user is Administrador)
                {
                    dtgvEmpleados.Rows[n].Cells[0].Value = user.Nombre;
                    dtgvEmpleados.Rows[n].Cells[1].Value = user.Apellido;
                    dtgvEmpleados.Rows[n].Cells[2].Value = user.DNI;
                    dtgvEmpleados.Rows[n].Cells[3].Value = "Administrador";
                }
                else
                {
                    dtgvEmpleados.Rows[n].Cells[0].Value = user.Nombre;
                    dtgvEmpleados.Rows[n].Cells[1].Value = user.Apellido;
                    dtgvEmpleados.Rows[n].Cells[2].Value = user.DNI;
                    dtgvEmpleados.Rows[n].Cells[3].Value = "Empleado";
                }

            }
        }
        /// <summary>
        /// Rellena el DataGridView con los datos de los clientes.
        /// </summary>
        private void FillClientDataGrid()
        {
            foreach (var user in Sistema.ListaClientes)
            {
                int n = dtgvClients.Rows.Add();
                if (user is Cliente)
                {
                    dtgvClients.Rows[n].Cells[0].Value = user.Nombre;
                    dtgvClients.Rows[n].Cells[1].Value = user.Apellido;
                    dtgvClients.Rows[n].Cells[2].Value = user.DNI;
                    dtgvClients.Rows[n].Cells[3].Value = user.Saldo;
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.lblError.Text = " ";
            if (task.Equals("Empleado") || task.Equals("Admin"))
            {
                DeleteEmployee(this.txtDniToFind.Text);
            }
            else if (task.Equals("Cliente"))
            {
                DeleteClient(this.txtDniToFind.Text);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.lblError.Text = " ";
            if (task.Equals("Empleado"))
            {
                EditEmployee(this.txtDniToFind.Text);
            }
            else if (task.Equals("Admin"))
            {
                EditAdmin(this.txtDniToFind.Text);
            }
            else if (task.Equals("Cliente"))
            {
                EditClient(this.txtDniToFind.Text);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmEditOrBajaPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
