namespace PL
{
    partial class Menu
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTurnos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMedicos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLocalidades = new System.Windows.Forms.ToolStripMenuItem();
            this.OTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTurnos,
            this.btnPacientes,
            this.btnMedicos,
            this.btnEspecialidades,
            this.btnLocalidades,
            this.OTROSToolStripMenuItem,
            this.btnSalir});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(816, 24);
            this.MenuStrip1.TabIndex = 3;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // btnTurnos
            // 
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(65, 20);
            this.btnTurnos.Text = "TURNOS";
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(78, 20);
            this.btnPacientes.Text = "PACIENTES";
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(70, 20);
            this.btnMedicos.Text = "MEDICOS";
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(108, 20);
            this.btnEspecialidades.Text = "ESPECIALIDADES";
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnLocalidades
            // 
            this.btnLocalidades.Name = "btnLocalidades";
            this.btnLocalidades.Size = new System.Drawing.Size(95, 20);
            this.btnLocalidades.Text = "LOCALIDADES";
            this.btnLocalidades.Click += new System.EventHandler(this.btnLocalidades_Click);
            // 
            // OTROSToolStripMenuItem
            // 
            this.OTROSToolStripMenuItem.Name = "OTROSToolStripMenuItem";
            this.OTROSToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.OTROSToolStripMenuItem.Text = "OTROS";
            this.OTROSToolStripMenuItem.Click += new System.EventHandler(this.OTROSToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 20);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Location = new System.Drawing.Point(0, 373);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(816, 22);
            this.StatusStrip1.TabIndex = 4;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 395);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem btnTurnos;
        internal System.Windows.Forms.ToolStripMenuItem btnMedicos;
        internal System.Windows.Forms.ToolStripMenuItem btnPacientes;
        internal System.Windows.Forms.ToolStripMenuItem btnEspecialidades;
        internal System.Windows.Forms.ToolStripMenuItem btnLocalidades;
        internal System.Windows.Forms.ToolStripMenuItem OTROSToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem btnSalir;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
    }
}

