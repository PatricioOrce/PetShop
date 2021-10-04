
namespace FrmInit
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnLogInAsEmp = new System.Windows.Forms.Button();
            this.btnLogInAsAdm = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Location = new System.Drawing.Point(6, 323);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(264, 29);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnLogInAsEmp
            // 
            this.btnLogInAsEmp.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogInAsEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInAsEmp.Location = new System.Drawing.Point(147, 361);
            this.btnLogInAsEmp.Name = "btnLogInAsEmp";
            this.btnLogInAsEmp.Size = new System.Drawing.Size(123, 28);
            this.btnLogInAsEmp.TabIndex = 1;
            this.btnLogInAsEmp.Text = "Empleado";
            this.btnLogInAsEmp.UseVisualStyleBackColor = false;
            this.btnLogInAsEmp.Click += new System.EventHandler(this.btnLogInAsEmp_Click);
            // 
            // btnLogInAsAdm
            // 
            this.btnLogInAsAdm.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogInAsAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInAsAdm.Location = new System.Drawing.Point(6, 361);
            this.btnLogInAsAdm.Name = "btnLogInAsAdm";
            this.btnLogInAsAdm.Size = new System.Drawing.Size(131, 28);
            this.btnLogInAsAdm.TabIndex = 2;
            this.btnLogInAsAdm.Text = "Admin";
            this.btnLogInAsAdm.UseVisualStyleBackColor = false;
            this.btnLogInAsAdm.Click += new System.EventHandler(this.btnLogInAsAdm_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(50, 257);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.PlaceholderText = "Ingrese Clave";
            this.txtClave.Size = new System.Drawing.Size(184, 23);
            this.txtClave.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(50, 176);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ingrese Usuario.";
            this.txtUsuario.Size = new System.Drawing.Size(184, 23);
            this.txtUsuario.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(45, 158);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(54, 16);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Usuario.";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clave.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseLogin.Image")));
            this.btnCloseLogin.Location = new System.Drawing.Point(239, 1);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(37, 35);
            this.btnCloseLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseLogin.TabIndex = 9;
            this.btnCloseLogin.TabStop = false;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(277, 396);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnLogInAsAdm);
            this.Controls.Add(this.btnLogInAsEmp);
            this.Controls.Add(this.btnLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogIn";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogIn";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnLogInAsEmp;
        private System.Windows.Forms.Button btnLogInAsAdm;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCloseLogin;
    }
}