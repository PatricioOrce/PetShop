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
    public partial class FrmListar : Form
    {
        string tipo;
        public FrmListar(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }
        private void FrmListar_Load(object sender, EventArgs e)
        {
            if (tipo.Equals("Cliente"))
            {
                dtgvListPersonas.Visible = true;
                foreach (Cliente item in Sistema.ListaClientes)
                {
                    int n = dtgvListPersonas.Rows.Add();
                    dtgvListPersonas.Rows[n].Cells[0].Value = item.Nombre;
                    dtgvListPersonas.Rows[n].Cells[1].Value = item.Apellido;
                    dtgvListPersonas.Rows[n].Cells[2].Value = item.DNI;
                    dtgvListPersonas.Rows[n].Cells[3].Value = "Cliente";
                }
            }
            else if (tipo.Equals("Empleado") || tipo.Equals("Admin"))
            {
                dtgvListPersonas.Visible = true;
                foreach (Empleado item in Sistema.ListaEmpleados)
                {
                    int n = dtgvListPersonas.Rows.Add();
                    dtgvListPersonas.Rows[n].Cells[0].Value = item.Nombre;
                    dtgvListPersonas.Rows[n].Cells[1].Value = item.Apellido;
                    dtgvListPersonas.Rows[n].Cells[2].Value = item.DNI;
                    if (!(item is Administrador))
                        dtgvListPersonas.Rows[n].Cells[3].Value = "Cliente";
                    else
                        dtgvListPersonas.Rows[n].Cells[3].Value = "Admin";
                }
            }
            else if (tipo.Equals("Producto"))
            {
                int n;
                dtgvListProducts.Visible = true;
                foreach (Producto item in Sistema.ListaProductos)
                {
                    n = dtgvListProducts.Rows.Add();
                    dtgvListProducts.Rows[n].Cells[0].Value = item.Nombre;
                    dtgvListProducts.Rows[n].Cells[1].Value = item.Tipo;
                    dtgvListProducts.Rows[n].Cells[2].Value = (double)item;
                    dtgvListProducts.Rows[n].Cells[3].Value = item.Id;
                }
            }
            else if (tipo.Equals("Facturacion"))
            {
                this.dtgvFacturacion.Visible = true;
                FillFacturacion();
                this.lblTotalPrice.Text = $"Total Facturado: {Total(Sistema.ListaVentas)}";
            }
        }
        /// <summary>
        /// Rellenar DataGridView con informacion de la facturacion.
        /// </summary>
        private void FillFacturacion()
        {
            int n;
            foreach (Venta venta in Sistema.ListaVentas)
            {
                foreach (Producto product in venta.Productos)
                {
                    n = dtgvFacturacion.Rows.Add();
                    dtgvFacturacion.Rows[n].Cells[0].Value = product.Nombre;
                    dtgvFacturacion.Rows[n].Cells[1].Value = product.Precio;
                    dtgvFacturacion.Rows[n].Cells[2].Value = product.Id;
                    dtgvFacturacion.Rows[n].Cells[3].Value = venta.Comprador.DNI;
                }

            }

        }
        /// <summary>
        /// Calcula el total del precio de todas las ventas.
        /// </summary>
        /// <param name="ventas"></param>
        /// <returns>Devuelve ese total en caso de ser valido, de lo contrario devuelve 0.</returns>
        private double Total(List<Venta> ventas)
        {
            double total = 0;
            if (ventas is not null)
            {
                foreach (Venta venta in ventas)
                {
                    foreach (Producto producto in venta.Productos)
                    {
                        total += producto.Precio;
                    }
                }
                return total;
            }
            return 0;
        }
    }
}
