namespace WindowsFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitelKdbLogin = new System.Windows.Forms.Label();
            this.LabelBenutzername = new System.Windows.Forms.Label();
            this.LabelPasswort = new System.Windows.Forms.Label();
            this.TxtBoxBenutzername = new System.Windows.Forms.TextBox();
            this.TxtBoxPasswort = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitelKdbLogin
            // 
            this.TitelKdbLogin.AutoSize = true;
            this.TitelKdbLogin.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitelKdbLogin.ForeColor = System.Drawing.Color.Black;
            this.TitelKdbLogin.Location = new System.Drawing.Point(61, 46);
            this.TitelKdbLogin.Name = "TitelKdbLogin";
            this.TitelKdbLogin.Size = new System.Drawing.Size(587, 33);
            this.TitelKdbLogin.TabIndex = 0;
            this.TitelKdbLogin.Text = "Kundendatenbank Login";
            // 
            // LabelBenutzername
            // 
            this.LabelBenutzername.AutoSize = true;
            this.LabelBenutzername.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBenutzername.ForeColor = System.Drawing.Color.Black;
            this.LabelBenutzername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelBenutzername.Location = new System.Drawing.Point(62, 181);
            this.LabelBenutzername.Name = "LabelBenutzername";
            this.LabelBenutzername.Size = new System.Drawing.Size(141, 29);
            this.LabelBenutzername.TabIndex = 1;
            this.LabelBenutzername.Text = "Benutzername";
            this.LabelBenutzername.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelPasswort
            // 
            this.LabelPasswort.AutoSize = true;
            this.LabelPasswort.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswort.ForeColor = System.Drawing.Color.Black;
            this.LabelPasswort.Location = new System.Drawing.Point(62, 267);
            this.LabelPasswort.Name = "LabelPasswort";
            this.LabelPasswort.Size = new System.Drawing.Size(95, 29);
            this.LabelPasswort.TabIndex = 2;
            this.LabelPasswort.Text = "Passwort";
            this.LabelPasswort.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBoxBenutzername
            // 
            this.TxtBoxBenutzername.Location = new System.Drawing.Point(229, 190);
            this.TxtBoxBenutzername.Name = "TxtBoxBenutzername";
            this.TxtBoxBenutzername.Size = new System.Drawing.Size(230, 20);
            this.TxtBoxBenutzername.TabIndex = 3;
            this.TxtBoxBenutzername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtBoxPasswort
            // 
            this.TxtBoxPasswort.Location = new System.Drawing.Point(229, 275);
            this.TxtBoxPasswort.Name = "TxtBoxPasswort";
            this.TxtBoxPasswort.Size = new System.Drawing.Size(230, 20);
            this.TxtBoxPasswort.TabIndex = 4;
            this.TxtBoxPasswort.TextChanged += new System.EventHandler(this.MsgBoxPasswort_TextChanged);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.Black;
            this.ButtonLogin.Location = new System.Drawing.Point(258, 364);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(156, 50);
            this.ButtonLogin.TabIndex = 5;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 451);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TxtBoxPasswort);
            this.Controls.Add(this.TxtBoxBenutzername);
            this.Controls.Add(this.LabelPasswort);
            this.Controls.Add(this.LabelBenutzername);
            this.Controls.Add(this.TitelKdbLogin);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitelKdbLogin;
        private System.Windows.Forms.Label LabelBenutzername;
        private System.Windows.Forms.Label LabelPasswort;
        private System.Windows.Forms.TextBox TxtBoxBenutzername;
        private System.Windows.Forms.TextBox TxtBoxPasswort;
        private System.Windows.Forms.Button ButtonLogin;
    }
}

