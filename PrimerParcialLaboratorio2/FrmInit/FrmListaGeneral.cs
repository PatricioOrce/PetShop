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
    public partial class FrmListaGeneral : Form
    {
        string task;
        Cliente cliente;
        Empleado empleado;
        Administrador admin;
        

        public FrmListaGeneral(string task)
        {
            InitializeComponent();
            this.task = task;
            cliente = new Cliente("Nameless","Surnameless","00000000",1);
            empleado = new Empleado("Nameless", "Surnameless", "00000000","UserLess","PasswordLess");
            admin = new Administrador("Nameless", "Surnameless", "00000000", "UserLesss", "PasswordLesss");
        }

        private void ListaGeneral_Load(object sender, EventArgs e)
        {
            if(task.Equals("Help"))
            {
                listHelp.Visible = true;
                FillListHelp();
            }
            else
            {
                listPersonas.Visible = true;
            }
        }

        private void FillListHelp()
        {
            this.listHelp.Dock = DockStyle.Fill;
            this.listHelp.Items.Add(cliente.Help()); ;
            this.listHelp.Items.Add(empleado.Help()); ;
            this.listHelp.Items.Add(admin.Help()); ;
        }
        

    }
}
