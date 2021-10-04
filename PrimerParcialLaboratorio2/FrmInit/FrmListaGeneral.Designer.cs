
namespace FrmInit
{
    partial class FrmListaGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaGeneral));
            this.listHelp = new System.Windows.Forms.ListBox();
            this.listPersonas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listHelp
            // 
            this.listHelp.FormattingEnabled = true;
            this.listHelp.ItemHeight = 15;
            this.listHelp.Location = new System.Drawing.Point(0, -2);
            this.listHelp.Name = "listHelp";
            this.listHelp.Size = new System.Drawing.Size(479, 454);
            this.listHelp.TabIndex = 0;
            this.listHelp.Visible = false;
            // 
            // listPersonas
            // 
            this.listPersonas.FormattingEnabled = true;
            this.listPersonas.ItemHeight = 15;
            this.listPersonas.Location = new System.Drawing.Point(-1, -2);
            this.listPersonas.Name = "listPersonas";
            this.listPersonas.Size = new System.Drawing.Size(479, 454);
            this.listPersonas.TabIndex = 1;
            this.listPersonas.Visible = false;
            // 
            // FrmListaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.listPersonas);
            this.Controls.Add(this.listHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaGeneral";
            this.Load += new System.EventHandler(this.ListaGeneral_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listHelp;
        private System.Windows.Forms.ListBox listPersonas;
    }
}