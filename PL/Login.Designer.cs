namespace PL
{
    partial class Frm_login
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Lblcontrasenia = new System.Windows.Forms.Label();
            this.Lblusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RDBNO = new System.Windows.Forms.RadioButton();
            this.RDBSI = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(148, 215);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(191, 153);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.ShortcutsEnabled = false;
            this.TxtContrasenia.Size = new System.Drawing.Size(100, 20);
            this.TxtContrasenia.TabIndex = 13;
            this.TxtContrasenia.UseSystemPasswordChar = true;
            // 
            // Txtusuario
            // 
            this.Txtusuario.Location = new System.Drawing.Point(191, 104);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.ShortcutsEnabled = false;
            this.Txtusuario.Size = new System.Drawing.Size(100, 20);
            this.Txtusuario.TabIndex = 12;
            // 
            // Lblcontrasenia
            // 
            this.Lblcontrasenia.AutoSize = true;
            this.Lblcontrasenia.Location = new System.Drawing.Point(88, 160);
            this.Lblcontrasenia.Name = "Lblcontrasenia";
            this.Lblcontrasenia.Size = new System.Drawing.Size(84, 13);
            this.Lblcontrasenia.TabIndex = 11;
            this.Lblcontrasenia.Text = "CONTRASEÑA:";
            // 
            // Lblusuario
            // 
            this.Lblusuario.AutoSize = true;
            this.Lblusuario.Location = new System.Drawing.Point(113, 111);
            this.Lblusuario.Name = "Lblusuario";
            this.Lblusuario.Size = new System.Drawing.Size(59, 13);
            this.Lblusuario.TabIndex = 10;
            this.Lblusuario.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ES USTED MEDICO?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RDBNO
            // 
            this.RDBNO.AutoSize = true;
            this.RDBNO.Checked = true;
            this.RDBNO.Location = new System.Drawing.Point(191, 65);
            this.RDBNO.Name = "RDBNO";
            this.RDBNO.Size = new System.Drawing.Size(41, 17);
            this.RDBNO.TabIndex = 18;
            this.RDBNO.TabStop = true;
            this.RDBNO.Text = "NO";
            this.RDBNO.UseVisualStyleBackColor = true;
            this.RDBNO.CheckedChanged += new System.EventHandler(this.RDBNO_CheckedChanged);
            // 
            // RDBSI
            // 
            this.RDBSI.AutoSize = true;
            this.RDBSI.Location = new System.Drawing.Point(256, 65);
            this.RDBSI.Name = "RDBSI";
            this.RDBSI.Size = new System.Drawing.Size(35, 17);
            this.RDBSI.TabIndex = 19;
            this.RDBSI.Text = "SI";
            this.RDBSI.UseVisualStyleBackColor = true;
            this.RDBSI.CheckedChanged += new System.EventHandler(this.RDBSI_CheckedChanged);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 291);
            this.Controls.Add(this.RDBSI);
            this.Controls.Add(this.RDBNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.Lblcontrasenia);
            this.Controls.Add(this.Lblusuario);
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnIngresar;
        internal System.Windows.Forms.TextBox TxtContrasenia;
        internal System.Windows.Forms.TextBox Txtusuario;
        internal System.Windows.Forms.Label Lblcontrasenia;
        internal System.Windows.Forms.Label Lblusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RDBNO;
        private System.Windows.Forms.RadioButton RDBSI;
    }
}