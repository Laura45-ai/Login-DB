namespace WindowsFormsApp2
{
    partial class Registrarse
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
            this.lblregistrarse = new System.Windows.Forms.Label();
            this.lblidregis = new System.Windows.Forms.Label();
            this.lblnomregis = new System.Windows.Forms.Label();
            this.lblaliasregis = new System.Windows.Forms.Label();
            this.lblemailregis = new System.Windows.Forms.Label();
            this.textidr = new System.Windows.Forms.TextBox();
            this.textnomr = new System.Windows.Forms.TextBox();
            this.textbaliasr = new System.Windows.Forms.TextBox();
            this.textbemailr = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblregistrarse
            // 
            this.lblregistrarse.AutoSize = true;
            this.lblregistrarse.Location = new System.Drawing.Point(366, 42);
            this.lblregistrarse.Name = "lblregistrarse";
            this.lblregistrarse.Size = new System.Drawing.Size(60, 13);
            this.lblregistrarse.TabIndex = 3;
            this.lblregistrarse.Text = "Registrarse";
            // 
            // lblidregis
            // 
            this.lblidregis.AutoSize = true;
            this.lblidregis.Location = new System.Drawing.Point(301, 86);
            this.lblidregis.Name = "lblidregis";
            this.lblidregis.Size = new System.Drawing.Size(16, 13);
            this.lblidregis.TabIndex = 4;
            this.lblidregis.Text = "Id";
            // 
            // lblnomregis
            // 
            this.lblnomregis.AutoSize = true;
            this.lblnomregis.Location = new System.Drawing.Point(301, 138);
            this.lblnomregis.Name = "lblnomregis";
            this.lblnomregis.Size = new System.Drawing.Size(44, 13);
            this.lblnomregis.TabIndex = 5;
            this.lblnomregis.Text = "Nombre";
            // 
            // lblaliasregis
            // 
            this.lblaliasregis.AutoSize = true;
            this.lblaliasregis.Location = new System.Drawing.Point(301, 172);
            this.lblaliasregis.Name = "lblaliasregis";
            this.lblaliasregis.Size = new System.Drawing.Size(29, 13);
            this.lblaliasregis.TabIndex = 7;
            this.lblaliasregis.Text = "Alias";
            // 
            // lblemailregis
            // 
            this.lblemailregis.AutoSize = true;
            this.lblemailregis.Location = new System.Drawing.Point(301, 212);
            this.lblemailregis.Name = "lblemailregis";
            this.lblemailregis.Size = new System.Drawing.Size(32, 13);
            this.lblemailregis.TabIndex = 9;
            this.lblemailregis.Text = "Email";
            // 
            // textidr
            // 
            this.textidr.Location = new System.Drawing.Point(395, 83);
            this.textidr.Name = "textidr";
            this.textidr.Size = new System.Drawing.Size(100, 20);
            this.textidr.TabIndex = 11;
            // 
            // textnomr
            // 
            this.textnomr.Location = new System.Drawing.Point(395, 131);
            this.textnomr.Name = "textnomr";
            this.textnomr.Size = new System.Drawing.Size(100, 20);
            this.textnomr.TabIndex = 12;
            // 
            // textbaliasr
            // 
            this.textbaliasr.Location = new System.Drawing.Point(395, 169);
            this.textbaliasr.Name = "textbaliasr";
            this.textbaliasr.Size = new System.Drawing.Size(100, 20);
            this.textbaliasr.TabIndex = 13;
            // 
            // textbemailr
            // 
            this.textbemailr.Location = new System.Drawing.Point(395, 212);
            this.textbemailr.Name = "textbemailr";
            this.textbemailr.Size = new System.Drawing.Size(100, 20);
            this.textbemailr.TabIndex = 14;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(420, 269);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 15;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(304, 269);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 16;
            this.btncrear.Text = "Crear usuario";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.textbemailr);
            this.Controls.Add(this.textbaliasr);
            this.Controls.Add(this.textnomr);
            this.Controls.Add(this.textidr);
            this.Controls.Add(this.lblemailregis);
            this.Controls.Add(this.lblaliasregis);
            this.Controls.Add(this.lblnomregis);
            this.Controls.Add(this.lblidregis);
            this.Controls.Add(this.lblregistrarse);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblregistrarse;
        private System.Windows.Forms.Label lblidregis;
        private System.Windows.Forms.Label lblnomregis;
        private System.Windows.Forms.Label lblaliasregis;
        private System.Windows.Forms.Label lblemailregis;
        private System.Windows.Forms.TextBox textidr;
        private System.Windows.Forms.TextBox textnomr;
        private System.Windows.Forms.TextBox textbaliasr;
        private System.Windows.Forms.TextBox textbemailr;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btncrear;
    }
}