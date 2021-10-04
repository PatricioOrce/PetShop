
namespace FrmInit
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.panelLateralMain = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelListar = new System.Windows.Forms.Panel();
            this.btnListPersonas = new System.Windows.Forms.Button();
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnListEmployees = new System.Windows.Forms.Button();
            this.btnListClients = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panelModify = new System.Windows.Forms.Panel();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.btnModifyClient = new System.Windows.Forms.Button();
            this.btnEditOrDelete = new System.Windows.Forms.Button();
            this.panelAltas = new System.Windows.Forms.Panel();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnNewAdmin = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnNewEntity = new System.Windows.Forms.Button();
            this.picBigLogo = new System.Windows.Forms.PictureBox();
            this.picHideScreen = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picBackToNormal = new System.Windows.Forms.PictureBox();
            this.picMaxScreen = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLateralMain.SuspendLayout();
            this.panelListar.SuspendLayout();
            this.panelModify.SuspendLayout();
            this.panelAltas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBigLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHideScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackToNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaxScreen)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateralMain
            // 
            this.panelLateralMain.AutoScroll = true;
            this.panelLateralMain.BackColor = System.Drawing.Color.SkyBlue;
            this.panelLateralMain.Controls.Add(this.btnHelp);
            this.panelLateralMain.Controls.Add(this.btnCerrarSesion);
            this.panelLateralMain.Controls.Add(this.panelListar);
            this.panelLateralMain.Controls.Add(this.btnMostrar);
            this.panelLateralMain.Controls.Add(this.panelModify);
            this.panelLateralMain.Controls.Add(this.btnEditOrDelete);
            this.panelLateralMain.Controls.Add(this.panelAltas);
            this.panelLateralMain.Controls.Add(this.btnNewEntity);
            this.panelLateralMain.Controls.Add(this.picBigLogo);
            this.panelLateralMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralMain.Location = new System.Drawing.Point(0, 0);
            this.panelLateralMain.Name = "panelLateralMain";
            this.panelLateralMain.Size = new System.Drawing.Size(201, 449);
            this.panelLateralMain.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHelp.Location = new System.Drawing.Point(0, 706);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(184, 33);
            this.btnHelp.TabIndex = 27;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 739);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(184, 40);
            this.btnCerrarSesion.TabIndex = 26;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelListar
            // 
            this.panelListar.Controls.Add(this.btnListPersonas);
            this.panelListar.Controls.Add(this.btnListProducts);
            this.panelListar.Controls.Add(this.btnListEmployees);
            this.panelListar.Controls.Add(this.btnListClients);
            this.panelListar.Controls.Add(this.btnFacturacion);
            this.panelListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListar.Location = new System.Drawing.Point(0, 553);
            this.panelListar.Name = "panelListar";
            this.panelListar.Size = new System.Drawing.Size(184, 153);
            this.panelListar.TabIndex = 25;
            this.panelListar.Visible = false;
            // 
            // btnListPersonas
            // 
            this.btnListPersonas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPersonas.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListPersonas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListPersonas.Location = new System.Drawing.Point(0, 120);
            this.btnListPersonas.Name = "btnListPersonas";
            this.btnListPersonas.Size = new System.Drawing.Size(184, 33);
            this.btnListPersonas.TabIndex = 4;
            this.btnListPersonas.Text = "Personas";
            this.btnListPersonas.UseVisualStyleBackColor = false;
            this.btnListPersonas.Click += new System.EventHandler(this.btnListPersonas_Click);
            // 
            // btnListProducts
            // 
            this.btnListProducts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListProducts.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListProducts.Location = new System.Drawing.Point(0, 90);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(184, 30);
            this.btnListProducts.TabIndex = 3;
            this.btnListProducts.Text = "Productos";
            this.btnListProducts.UseVisualStyleBackColor = false;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnListEmployees
            // 
            this.btnListEmployees.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListEmployees.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListEmployees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListEmployees.Location = new System.Drawing.Point(0, 60);
            this.btnListEmployees.Name = "btnListEmployees";
            this.btnListEmployees.Size = new System.Drawing.Size(184, 30);
            this.btnListEmployees.TabIndex = 2;
            this.btnListEmployees.Text = "Empleados";
            this.btnListEmployees.UseVisualStyleBackColor = false;
            this.btnListEmployees.Click += new System.EventHandler(this.btnListEmployees_Click);
            // 
            // btnListClients
            // 
            this.btnListClients.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListClients.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListClients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListClients.Location = new System.Drawing.Point(0, 30);
            this.btnListClients.Name = "btnListClients";
            this.btnListClients.Size = new System.Drawing.Size(184, 30);
            this.btnListClients.TabIndex = 1;
            this.btnListClients.Text = "Clientes";
            this.btnListClients.UseVisualStyleBackColor = false;
            this.btnListClients.Click += new System.EventHandler(this.btnListClients_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 0);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(184, 30);
            this.btnFacturacion.TabIndex = 0;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrar.Location = new System.Drawing.Point(0, 518);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(184, 35);
            this.btnMostrar.TabIndex = 24;
            this.btnMostrar.Text = "Listar";
            this.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // panelModify
            // 
            this.panelModify.Controls.Add(this.btnModifyProduct);
            this.panelModify.Controls.Add(this.btnModifyEmployee);
            this.panelModify.Controls.Add(this.btnModifyClient);
            this.panelModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModify.Location = new System.Drawing.Point(0, 425);
            this.panelModify.Name = "panelModify";
            this.panelModify.Size = new System.Drawing.Size(184, 93);
            this.panelModify.TabIndex = 23;
            this.panelModify.Visible = false;
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnModifyProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyProduct.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModifyProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifyProduct.Location = new System.Drawing.Point(0, 60);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(184, 33);
            this.btnModifyProduct.TabIndex = 2;
            this.btnModifyProduct.Text = "Producto";
            this.btnModifyProduct.UseVisualStyleBackColor = false;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnModifyEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModifyEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyEmployee.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModifyEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifyEmployee.Location = new System.Drawing.Point(0, 30);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(184, 30);
            this.btnModifyEmployee.TabIndex = 1;
            this.btnModifyEmployee.Text = "Empleado";
            this.btnModifyEmployee.UseVisualStyleBackColor = false;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnModifyClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModifyClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyClient.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModifyClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifyClient.Location = new System.Drawing.Point(0, 0);
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Size = new System.Drawing.Size(184, 30);
            this.btnModifyClient.TabIndex = 0;
            this.btnModifyClient.Text = "Cliente";
            this.btnModifyClient.UseVisualStyleBackColor = false;
            this.btnModifyClient.Click += new System.EventHandler(this.btnModifyClient_Click);
            // 
            // btnEditOrDelete
            // 
            this.btnEditOrDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditOrDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrDelete.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditOrDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditOrDelete.Location = new System.Drawing.Point(0, 385);
            this.btnEditOrDelete.Name = "btnEditOrDelete";
            this.btnEditOrDelete.Size = new System.Drawing.Size(184, 40);
            this.btnEditOrDelete.TabIndex = 22;
            this.btnEditOrDelete.Text = "Modificar/Eliminar";
            this.btnEditOrDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditOrDelete.UseVisualStyleBackColor = true;
            this.btnEditOrDelete.Click += new System.EventHandler(this.btnEditOrDelete_Click);
            // 
            // panelAltas
            // 
            this.panelAltas.Controls.Add(this.btnNewProduct);
            this.panelAltas.Controls.Add(this.btnNewAdmin);
            this.panelAltas.Controls.Add(this.btnNewEmployee);
            this.panelAltas.Controls.Add(this.btnNewClient);
            this.panelAltas.Controls.Add(this.btnAddSale);
            this.panelAltas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAltas.Location = new System.Drawing.Point(0, 233);
            this.panelAltas.Name = "panelAltas";
            this.panelAltas.Size = new System.Drawing.Size(184, 152);
            this.panelAltas.TabIndex = 20;
            this.panelAltas.Visible = false;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNewProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewProduct.Location = new System.Drawing.Point(0, 120);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(184, 32);
            this.btnNewProduct.TabIndex = 4;
            this.btnNewProduct.Text = "Producto";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnNewAdmin
            // 
            this.btnNewAdmin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNewAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAdmin.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewAdmin.Location = new System.Drawing.Point(0, 90);
            this.btnNewAdmin.Name = "btnNewAdmin";
            this.btnNewAdmin.Size = new System.Drawing.Size(184, 30);
            this.btnNewAdmin.TabIndex = 3;
            this.btnNewAdmin.Text = "Administrador";
            this.btnNewAdmin.UseVisualStyleBackColor = false;
            this.btnNewAdmin.Click += new System.EventHandler(this.btnNewAdmin_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNewEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEmployee.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewEmployee.Location = new System.Drawing.Point(0, 60);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(184, 30);
            this.btnNewEmployee.TabIndex = 2;
            this.btnNewEmployee.Text = "Empleado";
            this.btnNewEmployee.UseVisualStyleBackColor = false;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNewClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewClient.Location = new System.Drawing.Point(0, 30);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(184, 30);
            this.btnNewClient.TabIndex = 1;
            this.btnNewClient.Text = "Cliente";
            this.btnNewClient.UseVisualStyleBackColor = false;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSale.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddSale.Location = new System.Drawing.Point(0, 0);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(184, 30);
            this.btnAddSale.TabIndex = 0;
            this.btnAddSale.Text = "Venta";
            this.btnAddSale.UseVisualStyleBackColor = false;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnNewEntity
            // 
            this.btnNewEntity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEntity.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewEntity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewEntity.Location = new System.Drawing.Point(0, 193);
            this.btnNewEntity.Name = "btnNewEntity";
            this.btnNewEntity.Size = new System.Drawing.Size(184, 40);
            this.btnNewEntity.TabIndex = 19;
            this.btnNewEntity.Text = "Nuevo";
            this.btnNewEntity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEntity.UseVisualStyleBackColor = true;
            this.btnNewEntity.Click += new System.EventHandler(this.btnNewEntity_Click);
            // 
            // picBigLogo
            // 
            this.picBigLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBigLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBigLogo.Image")));
            this.picBigLogo.Location = new System.Drawing.Point(0, 0);
            this.picBigLogo.Name = "picBigLogo";
            this.picBigLogo.Size = new System.Drawing.Size(184, 193);
            this.picBigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBigLogo.TabIndex = 0;
            this.picBigLogo.TabStop = false;
            // 
            // picHideScreen
            // 
            this.picHideScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picHideScreen.Image = ((System.Drawing.Image)(resources.GetObject("picHideScreen.Image")));
            this.picHideScreen.Location = new System.Drawing.Point(426, 3);
            this.picHideScreen.Name = "picHideScreen";
            this.picHideScreen.Size = new System.Drawing.Size(30, 30);
            this.picHideScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHideScreen.TabIndex = 1;
            this.picHideScreen.TabStop = false;
            this.picHideScreen.Click += new System.EventHandler(this.picHideScreen_Click);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(508, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(30, 30);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 2;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picBackToNormal
            // 
            this.picBackToNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBackToNormal.Image = ((System.Drawing.Image)(resources.GetObject("picBackToNormal.Image")));
            this.picBackToNormal.Location = new System.Drawing.Point(467, 3);
            this.picBackToNormal.Name = "picBackToNormal";
            this.picBackToNormal.Size = new System.Drawing.Size(30, 30);
            this.picBackToNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackToNormal.TabIndex = 3;
            this.picBackToNormal.TabStop = false;
            this.picBackToNormal.Click += new System.EventHandler(this.picBackToNormal_Click);
            // 
            // picMaxScreen
            // 
            this.picMaxScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaxScreen.Image = ((System.Drawing.Image)(resources.GetObject("picMaxScreen.Image")));
            this.picMaxScreen.Location = new System.Drawing.Point(467, 3);
            this.picMaxScreen.Name = "picMaxScreen";
            this.picMaxScreen.Size = new System.Drawing.Size(30, 30);
            this.picMaxScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaxScreen.TabIndex = 4;
            this.picMaxScreen.TabStop = false;
            this.picMaxScreen.Visible = false;
            this.picMaxScreen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SkyBlue;
            this.panelTop.Controls.Add(this.picExit);
            this.panelTop.Controls.Add(this.picMaxScreen);
            this.panelTop.Controls.Add(this.picHideScreen);
            this.panelTop.Controls.Add(this.picBackToNormal);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(201, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(545, 42);
            this.panelTop.TabIndex = 5;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 449);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLateralMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.panelLateralMain.ResumeLayout(false);
            this.panelListar.ResumeLayout(false);
            this.panelModify.ResumeLayout(false);
            this.panelAltas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBigLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHideScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackToNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaxScreen)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateralMain;
        private System.Windows.Forms.PictureBox picHideScreen;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picBackToNormal;
        private System.Windows.Forms.PictureBox picMaxScreen;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelModify;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.Button btnModifyClient;
        private System.Windows.Forms.Button btnEditOrDelete;
        private System.Windows.Forms.Panel panelAltas;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnNewAdmin;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnNewEntity;
        private System.Windows.Forms.PictureBox picBigLogo;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Panel panelListar;
        private System.Windows.Forms.Button btnListPersonas;
        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.Button btnListEmployees;
        private System.Windows.Forms.Button btnListClients;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnHelp;
    }
}