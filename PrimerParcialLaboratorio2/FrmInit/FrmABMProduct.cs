using Entidades;
using System;
using System.Windows.Forms;

namespace FrmInit
{
    public partial class FrmABMProduct : Form
    {
        public FrmABMProduct()
        {
            InitializeComponent();
        }
        private void FrmABMProduct_Load(object sender, EventArgs e)
        {
            this.cmbTipo.Items.AddRange(Enum.GetNames(typeof(Tipos)));
            FIllDataGrid();
        }

        /// <summary>
        /// Rellena la informacion del DataGridView.
        /// </summary>
        private void FIllDataGrid()
        {
            int n;
            foreach (Producto item in Sistema.ListaProductos)
            {
                n = dtgvProds.Rows.Add();
                dtgvProds.Rows[n].Cells[0].Value = item.Nombre;
                dtgvProds.Rows[n].Cells[1].Value = item.Precio;
                dtgvProds.Rows[n].Cells[2].Value = item.Tipo;
                dtgvProds.Rows[n].Cells[3].Value = item.Id;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                if (Validar.IsSaldo(this.txtPrecio.Text))
                {
                    if (this.cmbTipo.SelectedItem is not null)
                    {
                        if (Validar.IsSaldo(this.txtCantidad.Text))
                        {
                            if (!string.IsNullOrWhiteSpace(this.txtDescripcion.Text))
                            {
                                Sistema.ListaProductos.Add(new Producto(this.txtNombre.Text, double.Parse(this.txtPrecio.Text), this.txtDescripcion.Text, this.cmbTipo.SelectedItem.ToString(), int.Parse(this.txtCantidad.Text)));
                                dtgvProds.Rows.Clear();
                                FIllDataGrid();
                            }
                            else
                            {
                                this.lblErrores.Text = "Ingrese una descripcion para poder continuar.";
                            }
                        }
                        else
                        {
                            this.lblErrores.Text = "Ingrese una cantidad valida para poder continuar.";
                        }
                    }
                    else
                    {
                        this.lblErrores.Text = "Ingrese un tipo para poder continuar.";
                    }
                }
                else
                {
                    this.lblErrores.Text = "Ingrese un precio valido para poder continuar.";
                }
            }
            else
            {
                this.lblErrores.Text = "Ingrese un nombre para poder continuar.";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int modificaciones = 0;
            Producto auxProd;
            if (!string.IsNullOrWhiteSpace(this.txtIdProducto.Text))
            {
                if (int.TryParse(this.txtIdProducto.Text, out int id))
                {
                    auxProd = Sistema.FindProductByID(Sistema.ListaProductos, id);
                    if (auxProd is not null)
                    {
                        if (!string.IsNullOrWhiteSpace(this.txtNombre.Text) && Validar.IsNombre(this.txtNombre.Text))
                        {
                            modificaciones += 1;
                            auxProd.Nombre = this.txtNombre.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(this.txtPrecio.Text) && Validar.IsSaldo(this.txtPrecio.Text))
                        {
                            modificaciones += 1;
                            auxProd.Precio = double.Parse(this.txtPrecio.Text);
                        }
                        if (!string.IsNullOrWhiteSpace(this.cmbTipo.Text))
                        {
                            modificaciones += 1;
                            auxProd.Tipo = this.cmbTipo.Text;

                        }
                        if (!string.IsNullOrWhiteSpace(this.txtDescripcion.Text))
                        {
                            modificaciones += 1;
                            auxProd.Descripcion = this.txtDescripcion.Text;
                        }
                        if (modificaciones > 0)
                        {
                            dtgvProds.Rows.Clear();
                            FIllDataGrid();
                        }
                        else
                        {
                            this.lblErrores.Text = "No se ingreso ningun campo.";
                        }
                    }
                    else
                    {
                        this.lblErrores.Text = "Ingrese un ID valido.";
                    }
                }
            }
            else
            {
                this.lblErrores.Text = "No se ingreso un ID";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto auxProd;
            if (!string.IsNullOrWhiteSpace(this.txtIdProducto.Text))
            {
                if (int.TryParse(this.txtIdProducto.Text, out int id))
                {
                    auxProd = Sistema.FindProductByID(Sistema.ListaProductos, id);
                    if (auxProd is not null)
                    {
                        if (MessageBox.Show("Seguro de eliminar este producto ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Sistema.ListaProductos.Remove(auxProd);
                            dtgvProds.Rows.Clear();
                            FIllDataGrid();
                        }
                    }
                    else
                    {
                        this.lblErrores.Text = "Ingrese ID valido";
                    }
                }
                else
                {
                    this.lblErrores.Text = "Ingrese ID valido";
                }
            }
            else
            {
                this.lblErrores.Text = "Ingrese ID valido";
            }
        }
        
    }
}
