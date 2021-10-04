
namespace FrmInit
{
    partial class FrmEditOrBajaPersona
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditOrBajaPersona));
            this.lblPesosSign = new System.Windows.Forms.Label();
            this.txtCashInput = new System.Windows.Forms.TextBox();
            this.txtDniInput = new System.Windows.Forms.TextBox();
            this.txtSurnameInput = new System.Windows.Forms.TextBox();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.txtDniToFind = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rango = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserToInspect = new System.Windows.Forms.Label();
            this.dtgvClients = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNICliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesosSign
            // 
            this.lblPesosSign.AutoSize = true;
            this.lblPesosSign.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPesosSign.Location = new System.Drawing.Point(90, 282);
            this.lblPesosSign.Name = "lblPesosSign";
            this.lblPesosSign.Size = new System.Drawing.Size(18, 19);
            this.lblPesosSign.TabIndex = 15;
            this.lblPesosSign.Text = "$";
            this.lblPesosSign.Visible = false;
            // 
            // txtCashInput
            // 
            this.txtCashInput.Location = new System.Drawing.Point(12, 278);
            this.txtCashInput.Name = "txtCashInput";
            this.txtCashInput.PlaceholderText = "Ingrese Saldo";
            this.txtCashInput.Size = new System.Drawing.Size(78, 23);
            this.txtCashInput.TabIndex = 14;
            this.txtCashInput.Visible = false;
            // 
            // txtDniInput
            // 
            this.txtDniInput.Location = new System.Drawing.Point(12, 190);
            this.txtDniInput.Name = "txtDniInput";
            this.txtDniInput.PlaceholderText = "Ingrese DNI";
            this.txtDniInput.Size = new System.Drawing.Size(100, 23);
            this.txtDniInput.TabIndex = 13;
            // 
            // txtSurnameInput
            // 
            this.txtSurnameInput.Location = new System.Drawing.Point(12, 114);
            this.txtSurnameInput.Name = "txtSurnameInput";
            this.txtSurnameInput.PlaceholderText = "Ingrese Apellido";
            this.txtSurnameInput.Size = new System.Drawing.Size(100, 23);
            this.txtSurnameInput.TabIndex = 12;
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(12, 35);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.PlaceholderText = "Ingrese Nombre";
            this.txtNameInput.Size = new System.Drawing.Size(100, 23);
            this.txtNameInput.TabIndex = 11;
            // 
            // txtDniToFind
            // 
            this.txtDniToFind.Location = new System.Drawing.Point(151, 366);
            this.txtDniToFind.Name = "txtDniToFind";
            this.txtDniToFind.PlaceholderText = "DNI a buscar";
            this.txtDniToFind.Size = new System.Drawing.Size(100, 23);
            this.txtDniToFind.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(451, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 30);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(298, 405);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 30);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Modificar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(144, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Cancelar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // dtgvEmpleados
            // 
            this.dtgvEmpleados.BackgroundColor = System.Drawing.Color.Azure;
            this.dtgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Rango});
            this.dtgvEmpleados.Location = new System.Drawing.Point(151, 12);
            this.dtgvEmpleados.Name = "dtgvEmpleados";
            this.dtgvEmpleados.RowTemplate.Height = 25;
            this.dtgvEmpleados.Size = new System.Drawing.Size(416, 304);
            this.dtgvEmpleados.TabIndex = 22;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Empleado";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido Empleado";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI Empleado";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Rango
            // 
            this.Rango.HeaderText = "Rango";
            this.Rango.Name = "Rango";
            this.Rango.ReadOnly = true;
            // 
            // lblUserToInspect
            // 
            this.lblUserToInspect.AutoSize = true;
            this.lblUserToInspect.Location = new System.Drawing.Point(151, 337);
            this.lblUserToInspect.Name = "lblUserToInspect";
            this.lblUserToInspect.Size = new System.Drawing.Size(239, 15);
            this.lblUserToInspect.TabIndex = 23;
            this.lblUserToInspect.Text = "Ingrese aqui el DNI del usuario a interactuar.";
            // 
            // dtgvClients
            // 
            this.dtgvClients.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.ApellidoCliente,
            this.DNICliente,
            this.SaldoCliente});
            this.dtgvClients.Location = new System.Drawing.Point(151, 12);
            this.dtgvClients.Name = "dtgvClients";
            this.dtgvClients.RowTemplate.Height = 25;
            this.dtgvClients.Size = new System.Drawing.Size(416, 304);
            this.dtgvClients.TabIndex = 24;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Frozen = true;
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.HeaderText = "Apellido Cliente";
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.ReadOnly = true;
            // 
            // DNICliente
            // 
            this.DNICliente.HeaderText = "DNI del Cliente";
            this.DNICliente.Name = "DNICliente";
            this.DNICliente.ReadOnly = true;
            // 
            // SaldoCliente
            // 
            this.SaldoCliente.HeaderText = "Saldo del Cliente";
            this.SaldoCliente.Name = "SaldoCliente";
            this.SaldoCliente.ReadOnly = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(277, 374);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 25;
            // 
            // FrmEditOrBajaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(575, 442);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dtgvClients);
            this.Controls.Add(this.lblUserToInspect);
            this.Controls.Add(this.dtgvEmpleados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDniToFind);
            this.Controls.Add(this.lblPesosSign);
            this.Controls.Add(this.txtCashInput);
            this.Controls.Add(this.txtDniInput);
            this.Controls.Add(this.txtSurnameInput);
            this.Controls.Add(this.txtNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditOrBajaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditOrBaja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditOrBajaPersona_FormClosing);
            this.Load += new System.EventHandler(this.FrmEditOrBajaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesosSign;
        private System.Windows.Forms.TextBox txtCashInput;
        private System.Windows.Forms.TextBox txtDniInput;
        private System.Windows.Forms.TextBox txtSurnameInput;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.TextBox txtDniToFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rango;
        private System.Windows.Forms.Label lblUserToInspect;
        private System.Windows.Forms.DataGridView dtgvClients;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNICliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoCliente;
    }
}