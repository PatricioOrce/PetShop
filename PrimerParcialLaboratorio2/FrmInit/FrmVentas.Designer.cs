
namespace FrmInit
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.txtClientDNI = new System.Windows.Forms.TextBox();
            this.dtgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvCart = new System.Windows.Forms.DataGridView();
            this.CartProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListClients = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDProduct = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClientInfo = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnVaciarCarrito = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientDNI
            // 
            this.txtClientDNI.Location = new System.Drawing.Point(12, 30);
            this.txtClientDNI.Name = "txtClientDNI";
            this.txtClientDNI.PlaceholderText = "DNI del Cliente";
            this.txtClientDNI.Size = new System.Drawing.Size(132, 23);
            this.txtClientDNI.TabIndex = 0;
            // 
            // dtgvProducts
            // 
            this.dtgvProducts.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Price,
            this.ID});
            this.dtgvProducts.Location = new System.Drawing.Point(174, 30);
            this.dtgvProducts.Name = "dtgvProducts";
            this.dtgvProducts.RowTemplate.Height = 25;
            this.dtgvProducts.Size = new System.Drawing.Size(339, 182);
            this.dtgvProducts.TabIndex = 1;
            // 
            // ProductName
            // 
            this.ProductName.Frozen = true;
            this.ProductName.HeaderText = "Producto";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Precio $";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // dtgvCart
            // 
            this.dtgvCart.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CartProduct,
            this.CartPrice,
            this.CartID,
            this.Cantidad});
            this.dtgvCart.Location = new System.Drawing.Point(174, 264);
            this.dtgvCart.Name = "dtgvCart";
            this.dtgvCart.RowTemplate.Height = 25;
            this.dtgvCart.Size = new System.Drawing.Size(342, 131);
            this.dtgvCart.TabIndex = 2;
            // 
            // CartProduct
            // 
            this.CartProduct.Frozen = true;
            this.CartProduct.HeaderText = "Producto";
            this.CartProduct.Name = "CartProduct";
            // 
            // CartPrice
            // 
            this.CartPrice.Frozen = true;
            this.CartPrice.HeaderText = "Precio $";
            this.CartPrice.Name = "CartPrice";
            this.CartPrice.ReadOnly = true;
            // 
            // CartID
            // 
            this.CartID.Frozen = true;
            this.CartID.HeaderText = "ID";
            this.CartID.Name = "CartID";
            this.CartID.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Stock";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // btnListClients
            // 
            this.btnListClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListClients.Location = new System.Drawing.Point(12, 88);
            this.btnListClients.Name = "btnListClients";
            this.btnListClients.Size = new System.Drawing.Size(132, 23);
            this.btnListClients.TabIndex = 3;
            this.btnListClients.Text = "Listar Clientes";
            this.btnListClients.UseVisualStyleBackColor = true;
            this.btnListClients.Click += new System.EventHandler(this.btnListClients_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(174, 426);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carrito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Productos";
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.Location = new System.Drawing.Point(6, 372);
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.PlaceholderText = "ID Producto";
            this.txtIDProduct.Size = new System.Drawing.Size(75, 23);
            this.txtIDProduct.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(384, 422);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(129, 23);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirmar Compra";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Location = new System.Drawing.Point(87, 372);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 12;
            this.btnAddToCart.Text = "Agregar";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(6, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblClientInfo
            // 
            this.lblClientInfo.AutoSize = true;
            this.lblClientInfo.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClientInfo.Location = new System.Drawing.Point(12, 138);
            this.lblClientInfo.Name = "lblClientInfo";
            this.lblClientInfo.Size = new System.Drawing.Size(0, 19);
            this.lblClientInfo.TabIndex = 14;
            // 
            // btnVerify
            // 
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Location = new System.Drawing.Point(12, 59);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(132, 23);
            this.btnVerify.TabIndex = 15;
            this.btnVerify.Text = "Verificar Cliente";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarCarrito.Location = new System.Drawing.Point(87, 426);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(75, 23);
            this.btnVaciarCarrito.TabIndex = 16;
            this.btnVaciarCarrito.Text = "Vaciar";
            this.btnVaciarCarrito.UseVisualStyleBackColor = true;
            this.btnVaciarCarrito.Click += new System.EventHandler(this.btnVaciarCarrito_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(6, 333);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 17;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(528, 457);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnVaciarCarrito);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lblClientInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtIDProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnListClients);
            this.Controls.Add(this.dtgvCart);
            this.Controls.Add(this.dtgvProducts);
            this.Controls.Add(this.txtClientDNI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientDNI;
        private System.Windows.Forms.DataGridView dtgvCart;
        private System.Windows.Forms.Button btnListClients;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private new System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartID;
        private System.Windows.Forms.TextBox txtIDProduct;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dtgvProducts;
        private System.Windows.Forms.Label lblClientInfo;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnVaciarCarrito;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}