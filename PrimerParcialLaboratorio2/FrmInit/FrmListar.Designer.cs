
namespace FrmInit
{
    partial class FrmListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListar));
            this.dtgvListPersonas = new System.Windows.Forms.DataGridView();
            this.NameList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangoList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvListProducts = new System.Windows.Forms.DataGridView();
            this.ProductNameBis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvFacturacion = new System.Windows.Forms.DataGridView();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListPersonas
            // 
            this.dtgvListPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvListPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameList,
            this.ApellidoList,
            this.DNIList,
            this.RangoList});
            this.dtgvListPersonas.Location = new System.Drawing.Point(0, 0);
            this.dtgvListPersonas.Name = "dtgvListPersonas";
            this.dtgvListPersonas.RowTemplate.Height = 25;
            this.dtgvListPersonas.Size = new System.Drawing.Size(440, 437);
            this.dtgvListPersonas.TabIndex = 0;
            this.dtgvListPersonas.Visible = false;
            // 
            // NameList
            // 
            this.NameList.Frozen = true;
            this.NameList.HeaderText = "Nombre";
            this.NameList.Name = "NameList";
            this.NameList.ReadOnly = true;
            // 
            // ApellidoList
            // 
            this.ApellidoList.Frozen = true;
            this.ApellidoList.HeaderText = "Apellido";
            this.ApellidoList.Name = "ApellidoList";
            this.ApellidoList.ReadOnly = true;
            // 
            // DNIList
            // 
            this.DNIList.Frozen = true;
            this.DNIList.HeaderText = "DNI";
            this.DNIList.Name = "DNIList";
            this.DNIList.ReadOnly = true;
            // 
            // RangoList
            // 
            this.RangoList.Frozen = true;
            this.RangoList.HeaderText = "Rango";
            this.RangoList.Name = "RangoList";
            this.RangoList.ReadOnly = true;
            // 
            // dtgvListProducts
            // 
            this.dtgvListProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameBis,
            this.TipoProduct,
            this.ProductPrice,
            this.ProductID});
            this.dtgvListProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvListProducts.Location = new System.Drawing.Point(0, 0);
            this.dtgvListProducts.Name = "dtgvListProducts";
            this.dtgvListProducts.RowTemplate.Height = 25;
            this.dtgvListProducts.Size = new System.Drawing.Size(441, 437);
            this.dtgvListProducts.TabIndex = 1;
            this.dtgvListProducts.Visible = false;
            // 
            // ProductNameBis
            // 
            this.ProductNameBis.Frozen = true;
            this.ProductNameBis.HeaderText = "Nombre";
            this.ProductNameBis.Name = "ProductNameBis";
            this.ProductNameBis.ReadOnly = true;
            // 
            // TipoProduct
            // 
            this.TipoProduct.Frozen = true;
            this.TipoProduct.HeaderText = "Tipo";
            this.TipoProduct.Name = "TipoProduct";
            this.TipoProduct.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Frozen = true;
            this.ProductPrice.HeaderText = "Precio $";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.Frozen = true;
            this.ProductID.HeaderText = "ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // dtgvFacturacion
            // 
            this.dtgvFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdName,
            this.ProdPrice,
            this.ProdID,
            this.ProdDNI});
            this.dtgvFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvFacturacion.Location = new System.Drawing.Point(0, 437);
            this.dtgvFacturacion.Name = "dtgvFacturacion";
            this.dtgvFacturacion.RowTemplate.Height = 25;
            this.dtgvFacturacion.Size = new System.Drawing.Size(441, 407);
            this.dtgvFacturacion.TabIndex = 2;
            this.dtgvFacturacion.Visible = false;
            // 
            // ProdName
            // 
            this.ProdName.Frozen = true;
            this.ProdName.HeaderText = "Producto";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // ProdPrice
            // 
            this.ProdPrice.Frozen = true;
            this.ProdPrice.HeaderText = "Precio";
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.ReadOnly = true;
            // 
            // ProdID
            // 
            this.ProdID.Frozen = true;
            this.ProdID.HeaderText = "ID";
            this.ProdID.Name = "ProdID";
            this.ProdID.ReadOnly = true;
            // 
            // ProdDNI
            // 
            this.ProdDNI.Frozen = true;
            this.ProdDNI.HeaderText = "DNI del Comprador";
            this.ProdDNI.Name = "ProdDNI";
            this.ProdDNI.ReadOnly = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(13, 414);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 15);
            this.lblTotalPrice.TabIndex = 3;
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 437);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.dtgvFacturacion);
            this.Controls.Add(this.dtgvListProducts);
            this.Controls.Add(this.dtgvListPersonas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListar";
            this.Text = "FrmListar";
            this.Load += new System.EventHandler(this.FrmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangoList;
        private System.Windows.Forms.DataGridView dtgvListProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameBis;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridView dtgvFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDNI;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}