namespace PL
{
    partial class TurnosMedicos
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblTurnosMedicos = new System.Windows.Forms.Label();
            this.DGBTurnosMedicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGBTurnosMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CERRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTurnosMedicos
            // 
            this.lblTurnosMedicos.AutoSize = true;
            this.lblTurnosMedicos.Location = new System.Drawing.Point(228, 77);
            this.lblTurnosMedicos.Name = "lblTurnosMedicos";
            this.lblTurnosMedicos.Size = new System.Drawing.Size(165, 13);
            this.lblTurnosMedicos.TabIndex = 1;
            this.lblTurnosMedicos.Text = "SUS TURNOS MEDICOS SON...";
            // 
            // DGBTurnosMedicos
            // 
            this.DGBTurnosMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBTurnosMedicos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGBTurnosMedicos.Location = new System.Drawing.Point(12, 112);
            this.DGBTurnosMedicos.MultiSelect = false;
            this.DGBTurnosMedicos.Name = "DGBTurnosMedicos";
            this.DGBTurnosMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGBTurnosMedicos.Size = new System.Drawing.Size(589, 121);
            this.DGBTurnosMedicos.TabIndex = 3;
            // 
            // TurnosMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 340);
            this.Controls.Add(this.DGBTurnosMedicos);
            this.Controls.Add(this.lblTurnosMedicos);
            this.Controls.Add(this.button1);
            this.Name = "TurnosMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurnosMedicos";
            this.Load += new System.EventHandler(this.TurnosMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGBTurnosMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTurnosMedicos;
        private System.Windows.Forms.DataGridView DGBTurnosMedicos;
    }
}