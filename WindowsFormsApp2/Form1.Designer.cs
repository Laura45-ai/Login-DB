namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textb_id = new System.Windows.Forms.TextBox();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.textb_nombre = new System.Windows.Forms.TextBox();
            this.lblalias = new System.Windows.Forms.Label();
            this.textb_alias = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.textb_email = new System.Windows.Forms.TextBox();
            this.btnregistrarse = new System.Windows.Forms.Button();
            this.btniniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textb_id
            // 
            this.textb_id.Location = new System.Drawing.Point(393, 80);
            this.textb_id.Name = "textb_id";
            this.textb_id.Size = new System.Drawing.Size(100, 20);
            this.textb_id.TabIndex = 0;
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(377, 36);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(33, 13);
            this.lbllogin.TabIndex = 2;
            this.lbllogin.Text = "Login";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(277, 87);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(16, 13);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "Id";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(277, 136);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Nombre";
            // 
            // textb_nombre
            // 
            this.textb_nombre.Location = new System.Drawing.Point(393, 129);
            this.textb_nombre.Name = "textb_nombre";
            this.textb_nombre.Size = new System.Drawing.Size(100, 20);
            this.textb_nombre.TabIndex = 5;
            // 
            // lblalias
            // 
            this.lblalias.AutoSize = true;
            this.lblalias.Location = new System.Drawing.Point(277, 185);
            this.lblalias.Name = "lblalias";
            this.lblalias.Size = new System.Drawing.Size(29, 13);
            this.lblalias.TabIndex = 6;
            this.lblalias.Text = "Alias";
            // 
            // textb_alias
            // 
            this.textb_alias.Location = new System.Drawing.Point(393, 182);
            this.textb_alias.Name = "textb_alias";
            this.textb_alias.Size = new System.Drawing.Size(100, 20);
            this.textb_alias.TabIndex = 7;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(277, 228);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "Email";
            // 
            // textb_email
            // 
            this.textb_email.Location = new System.Drawing.Point(393, 221);
            this.textb_email.Name = "textb_email";
            this.textb_email.Size = new System.Drawing.Size(100, 20);
            this.textb_email.TabIndex = 9;
            // 
            // btnregistrarse
            // 
            this.btnregistrarse.Location = new System.Drawing.Point(418, 288);
            this.btnregistrarse.Name = "btnregistrarse";
            this.btnregistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnregistrarse.TabIndex = 10;
            this.btnregistrarse.Text = "Registrarse";
            this.btnregistrarse.UseVisualStyleBackColor = true;
            this.btnregistrarse.Click += new System.EventHandler(this.btnregistrarse_Click_1);
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(280, 288);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(75, 23);
            this.btniniciar.TabIndex = 11;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.btnregistrarse);
            this.Controls.Add(this.textb_email);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.textb_alias);
            this.Controls.Add(this.lblalias);
            this.Controls.Add(this.textb_nombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.textb_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textb_id;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox textb_nombre;
        private System.Windows.Forms.Label lblalias;
        private System.Windows.Forms.TextBox textb_alias;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox textb_email;
        private System.Windows.Forms.Button btnregistrarse;
        private System.Windows.Forms.Button btniniciar;
    }
}

