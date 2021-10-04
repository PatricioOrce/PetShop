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
    public partial class FrmVentas : Form
    {
        double total;
        Stack<Producto> carrito;
        FrmListar listadoDeClientes;
        public FrmVentas()
        {
            InitializeComponent();
            InitProductDataGrid();
            carrito = new Stack<Producto>();
        }
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            this.total = 0;
        }
        private void InitProductDataGrid()
        {
            foreach (Producto product in Sistema.ListaProductos)
            {
                int n = dtgvProducts.Rows.Add();
                if (product is Producto)
                {
                    dtgvProducts.Rows[n].Cells[0].Value = product.Nombre;
                    dtgvProducts.Rows[n].Cells[1].Value = product.Precio;
                    dtgvProducts.Rows[n].Cells[2].Value = product.Id;
                }
            }
        }
        private static double Total(Stack<Producto> product)
        {
            double auxTotal = 0;
            foreach (Producto item in product)
            {
                auxTotal = auxTotal + item.Precio;
            }
            return auxTotal;
        }
        private Producto VerifyStock()
        {
            foreach (Producto productos in Sistema.ListaProductos)
            {
                foreach (Producto carritoProds in this.carrito)
                {
                    if (carritoProds == productos)
                    {
                        if (productos.Cantidad > 0)
                        {
                            productos.Cantidad -= 1;
                        }
                        else
                        {
                            return carritoProds;
                        }
                    }
                }
            }
            return null;
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            this.lblError.Text = string.Empty;
            Cliente auxCliente = Sistema.FindByDNI(Sistema.ListaClientes, this.txtClientDNI.Text);
            if (!(auxCliente is null))
            {
                if (int.TryParse(this.txtIDProduct.Text, out int productId))
                {
                    Producto auxProducto = Sistema.FindProductByID(Sistema.ListaProductos, productId);
                    if (!(auxProducto is null))
                    {
                        carrito.Push(auxProducto);
                        this.total = Total(carrito);
                        if (auxCliente.Saldo < this.total)
                        {
                            MessageBox.Show("No ha sido posible realizar la transaccion: \nDinero Insuficiente.", "Error");
                        }
                        else
                        {
                            this.lblTotal.Text = $"Total: {this.total} $";
                            int n = dtgvCart.Rows.Add();
                            dtgvCart.Rows[n].Cells[0].Value = auxProducto.Nombre;
                            dtgvCart.Rows[n].Cells[1].Value = auxProducto.Precio;
                            dtgvCart.Rows[n].Cells[2].Value = auxProducto.Id;
                            dtgvCart.Rows[n].Cells[3].Value = auxProducto.Cantidad;
                        }
                    }
                }
                else
                {
                    this.lblError.Text = "Ingrese un ID valido \npara poder continuar.";
                    this.txtIDProduct.Focus();
                }
            }
            else
            {
                this.lblError.Text = "Ingrese un Cliente valido \npara poder continuar.";
                this.txtClientDNI.Focus();
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Cliente auxCliente;
            Producto auxProducto;
            Venta auxVenta;
            this.lblError.Text = string.Empty;
            if (!string.IsNullOrWhiteSpace(this.txtClientDNI.Text))
            {
                if (Validar.ExistingDNI(Sistema.ListaClientes, this.txtClientDNI.Text))
                {
                    auxCliente = Sistema.FindByDNI(Sistema.ListaClientes, this.txtClientDNI.Text);
                    if (this.carrito.Count > 0)
                    {
                        auxProducto = VerifyStock();
                        if (!(auxProducto is null))
                        {
                            MessageBox.Show($"No ha sido posible realizar la transaccion: \n{auxProducto.Nombre} sin stock.", "Error");
                            this.Close();
                        }
                        else
                        {
                            if (MessageBox.Show("Se confirmara la compra, esta seguro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                auxVenta = new Venta(auxCliente, this.carrito);
                                auxCliente.Saldo = auxCliente.Saldo - Total(this.carrito);
                                Sistema.ListaVentas.Add(auxVenta);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        this.lblError.Text = "Ingrese al menos un producto \npara poder continuar.";
                        this.txtClientDNI.Focus();
                    }
                }
                else
                {
                    this.lblError.Text = "Ingrese un DNI valido \npara poder continuar.";
                    this.txtClientDNI.Focus();
                }
            }
            else
            {
                this.lblError.Text = "Ingrese un DNI valido \npara poder continuar.";
                this.txtClientDNI.Focus();
            }
        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            this.lblError.Text = string.Empty;
            Cliente auxCliente = Sistema.FindByDNI(Sistema.ListaClientes, this.txtClientDNI.Text);
            if (!(auxCliente is null))
            {
                StringBuilder nameInfo = new StringBuilder();
                nameInfo.AppendLine($"Nombre: {auxCliente.Nombre}");
                nameInfo.AppendLine($"Apellido: {auxCliente.Apellido}");
                nameInfo.AppendLine($"DNI: {auxCliente.DNI}");
                nameInfo.AppendLine($"Saldo: {auxCliente.Saldo} $");
                this.lblClientInfo.Text = nameInfo.ToString();
            }
            else
            {
                this.lblError.Text = "Ingrese un DNI valido \npara poder continuar.";
                this.txtClientDNI.Focus();
            }
        }
        private void btnListClients_Click(object sender, EventArgs e)
        {
            listadoDeClientes = new FrmListar("Cliente");
            listadoDeClientes.Show();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de querer salir? Se perdera todo el avance de la compra.", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            this.lblError.Text = string.Empty;
            carrito.Clear();
            dtgvCart.Rows.Clear();
            this.lblTotal.Text = $"Total:";
        }

        private void FrmVentas_Load_1(object sender, EventArgs e)
        {

        }
    }
}
