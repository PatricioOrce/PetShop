
namespace FrmInit
{
    partial class FrmAltaPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaPersona));
            this.lblAltaPersonaText = new System.Windows.Forms.Label();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.txtSurnameInput = new System.Windows.Forms.TextBox();
            this.txtDniInput = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelCrear = new System.Windows.Forms.Button();
            this.txtCashInput = new System.Windows.Forms.TextBox();
            this.lblPesosSign = new System.Windows.Forms.Label();
            this.epErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.txtPassInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.epErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAltaPersonaText
            // 
            this.lblAltaPersonaText.AutoSize = true;
            this.lblAltaPersonaText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltaPersonaText.Location = new System.Drawing.Point(195, 9);
            this.lblAltaPersonaText.Name = "lblAltaPersonaText";
            this.lblAltaPersonaText.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblAltaPersonaText.Size = new System.Drawing.Size(105, 43);
            this.lblAltaPersonaText.TabIndex = 1;
            this.lblAltaPersonaText.Text = "Custom Text";
            this.lblAltaPersonaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(27, 71);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.PlaceholderText = "Ingrese Nombre";
            this.txtNameInput.Size = new System.Drawing.Size(100, 23);
            this.txtNameInput.TabIndex = 1;
            // 
            // txtSurnameInput
            // 
            this.txtSurnameInput.Location = new System.Drawing.Point(195, 71);
            this.txtSurnameInput.Name = "txtSurnameInput";
            this.txtSurnameInput.PlaceholderText = "Ingrese Apellido";
            this.txtSurnameInput.Size = new System.Drawing.Size(100, 23);
            this.txtSurnameInput.TabIndex = 2;
            // 
            // txtDniInput
            // 
            this.txtDniInput.Location = new System.Drawing.Point(360, 71);
            this.txtDniInput.Name = "txtDniInput";
            this.txtDniInput.PlaceholderText = "Ingrese DNI";
            this.txtDniInput.Size = new System.Drawing.Size(100, 23);
            this.txtDniInput.TabIndex = 3;
            // 
            // btnCrear
            // 
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Location = new System.Drawing.Point(302, 192);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(184, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // btnCancelCrear
            // 
            this.btnCancelCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCrear.Location = new System.Drawing.Point(12, 192);
            this.btnCancelCrear.Name = "btnCancelCrear";
            this.btnCancelCrear.Size = new System.Drawing.Size(181, 23);
            this.btnCancelCrear.TabIndex = 67;
            this.btnCancelCrear.Text = "Cancelar";
            this.btnCancelCrear.UseVisualStyleBackColor = true;
            this.btnCancelCrear.Click += new System.EventHandler(this.btnCancelCrear_Click_1);
            // 
            // txtCashInput
            // 
            this.txtCashInput.Location = new System.Drawing.Point(195, 120);
            this.txtCashInput.Name = "txtCashInput";
            this.txtCashInput.PlaceholderText = "Ingrese Saldo";
            this.txtCashInput.Size = new System.Drawing.Size(78, 23);
            this.txtCashInput.TabIndex = 5;
            // 
            // lblPesosSign
            // 
            this.lblPesosSign.AutoSize = true;
            this.lblPesosSign.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPesosSign.Location = new System.Drawing.Point(273, 122);
            this.lblPesosSign.Name = "lblPesosSign";
            this.lblPesosSign.Size = new System.Drawing.Size(18, 19);
            this.lblPesosSign.TabIndex = 8;
            this.lblPesosSign.Text = "$";
            // 
            // epErrores
            // 
            this.epErrores.ContainerControl = this;
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(27, 120);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.PlaceholderText = "Ingrese Usuario";
            this.txtUserInput.Size = new System.Drawing.Size(100, 23);
            this.txtUserInput.TabIndex = 4;
            this.txtUserInput.Visible = false;
            // 
            // txtPassInput
            // 
            this.txtPassInput.Location = new System.Drawing.Point(360, 119);
            this.txtPassInput.Name = "txtPassInput";
            this.txtPassInput.PlaceholderText = "Ingrese Clave";
            this.txtPassInput.Size = new System.Drawing.Size(100, 23);
            this.txtPassInput.TabIndex = 6;
            this.txtPassInput.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(498, 227);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassInput);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.lblPesosSign);
            this.Controls.Add(this.txtCashInput);
            this.Controls.Add(this.btnCancelCrear);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDniInput);
            this.Controls.Add(this.txtSurnameInput);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.lblAltaPersonaText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaPersona";
            this.Load += new System.EventHandler(this.FrmAltaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAltaPersonaText;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.TextBox txtSurnameInput;
        private System.Windows.Forms.TextBox txtDniInput;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelCrear;
        private System.Windows.Forms.TextBox txtCashInput;
        private System.Windows.Forms.Label lblPesosSign;
        private System.Windows.Forms.ErrorProvider epErrores;
        private System.Windows.Forms.TextBox txtPassInput;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}