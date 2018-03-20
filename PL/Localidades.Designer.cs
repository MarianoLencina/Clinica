namespace PL
{
    partial class Localidades
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
            this.gboxAltaLocalidad = new System.Windows.Forms.GroupBox();
            this.btnCancelarCargar = new System.Windows.Forms.Button();
            this.btnConfirmarCarga = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMenuAnterior = new System.Windows.Forms.Button();
            this.btnBuscarLocalidad = new System.Windows.Forms.Button();
            this.btnEliminarLocalidad = new System.Windows.Forms.Button();
            this.btnModificarLocalidad = new System.Windows.Forms.Button();
            this.btnAgregarLocalidad = new System.Windows.Forms.Button();
            this.dgvListadoLoca = new System.Windows.Forms.DataGridView();
            this.GboxBuscador = new System.Windows.Forms.GroupBox();
            this.btnCancelarBuscar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.gboxAltaLocalidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLoca)).BeginInit();
            this.GboxBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxAltaLocalidad
            // 
            this.gboxAltaLocalidad.Controls.Add(this.btnCancelarCargar);
            this.gboxAltaLocalidad.Controls.Add(this.btnConfirmarCarga);
            this.gboxAltaLocalidad.Controls.Add(this.Label2);
            this.gboxAltaLocalidad.Controls.Add(this.lblLocalidad);
            this.gboxAltaLocalidad.Controls.Add(this.txtCodigoPostal);
            this.gboxAltaLocalidad.Controls.Add(this.txtLocalidad);
            this.gboxAltaLocalidad.Location = new System.Drawing.Point(276, 34);
            this.gboxAltaLocalidad.Name = "gboxAltaLocalidad";
            this.gboxAltaLocalidad.Size = new System.Drawing.Size(236, 134);
            this.gboxAltaLocalidad.TabIndex = 35;
            this.gboxAltaLocalidad.TabStop = false;
            this.gboxAltaLocalidad.Text = "Alta Localidad";
            // 
            // btnCancelarCargar
            // 
            this.btnCancelarCargar.Location = new System.Drawing.Point(131, 91);
            this.btnCancelarCargar.Name = "btnCancelarCargar";
            this.btnCancelarCargar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelarCargar.TabIndex = 5;
            this.btnCancelarCargar.Text = "CANCELAR";
            this.btnCancelarCargar.UseVisualStyleBackColor = true;
            this.btnCancelarCargar.Click += new System.EventHandler(this.btnCancelarCargar_Click);
            // 
            // btnConfirmarCarga
            // 
            this.btnConfirmarCarga.Location = new System.Drawing.Point(9, 91);
            this.btnConfirmarCarga.Name = "btnConfirmarCarga";
            this.btnConfirmarCarga.Size = new System.Drawing.Size(87, 23);
            this.btnConfirmarCarga.TabIndex = 4;
            this.btnConfirmarCarga.Text = "CONFIRMAR";
            this.btnConfirmarCarga.UseVisualStyleBackColor = true;
            this.btnConfirmarCarga.Click += new System.EventHandler(this.btnConfirmarCarga_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(21, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Codigo Postal:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(40, 29);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 2;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(116, 58);
            this.txtCodigoPostal.MaxLength = 10;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.ShortcutsEnabled = false;
            this.txtCodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPostal.TabIndex = 1;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(116, 22);
            this.txtLocalidad.MaxLength = 30;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ShortcutsEnabled = false;
            this.txtLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidad.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(385, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMenuAnterior
            // 
            this.btnMenuAnterior.Location = new System.Drawing.Point(135, 392);
            this.btnMenuAnterior.Name = "btnMenuAnterior";
            this.btnMenuAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnMenuAnterior.TabIndex = 33;
            this.btnMenuAnterior.Text = "MENU ANTERIOR";
            this.btnMenuAnterior.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLocalidad
            // 
            this.btnBuscarLocalidad.Location = new System.Drawing.Point(36, 152);
            this.btnBuscarLocalidad.Name = "btnBuscarLocalidad";
            this.btnBuscarLocalidad.Size = new System.Drawing.Size(143, 26);
            this.btnBuscarLocalidad.TabIndex = 32;
            this.btnBuscarLocalidad.Text = "BUSCAR LOCALIDAD";
            this.btnBuscarLocalidad.UseVisualStyleBackColor = true;
            this.btnBuscarLocalidad.Click += new System.EventHandler(this.btnBuscarLocalidad_Click);
            // 
            // btnEliminarLocalidad
            // 
            this.btnEliminarLocalidad.Location = new System.Drawing.Point(36, 110);
            this.btnEliminarLocalidad.Name = "btnEliminarLocalidad";
            this.btnEliminarLocalidad.Size = new System.Drawing.Size(143, 23);
            this.btnEliminarLocalidad.TabIndex = 31;
            this.btnEliminarLocalidad.Text = "ELIMINAR LOCALIDAD";
            this.btnEliminarLocalidad.UseVisualStyleBackColor = true;
            this.btnEliminarLocalidad.Click += new System.EventHandler(this.btnEliminarLocalidad_Click);
            // 
            // btnModificarLocalidad
            // 
            this.btnModificarLocalidad.Location = new System.Drawing.Point(36, 74);
            this.btnModificarLocalidad.Name = "btnModificarLocalidad";
            this.btnModificarLocalidad.Size = new System.Drawing.Size(143, 21);
            this.btnModificarLocalidad.TabIndex = 30;
            this.btnModificarLocalidad.Text = "MODIFICAR LOCALIDAD";
            this.btnModificarLocalidad.UseVisualStyleBackColor = true;
            this.btnModificarLocalidad.Click += new System.EventHandler(this.btnModificarLocalidad_Click);
            // 
            // btnAgregarLocalidad
            // 
            this.btnAgregarLocalidad.Location = new System.Drawing.Point(36, 34);
            this.btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            this.btnAgregarLocalidad.Size = new System.Drawing.Size(143, 23);
            this.btnAgregarLocalidad.TabIndex = 29;
            this.btnAgregarLocalidad.Text = "AGREGAR LOCALIDAD";
            this.btnAgregarLocalidad.UseVisualStyleBackColor = true;
            this.btnAgregarLocalidad.Click += new System.EventHandler(this.btnAgregarLocalidad_Click);
            // 
            // dgvListadoLoca
            // 
            this.dgvListadoLoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoLoca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoLoca.Location = new System.Drawing.Point(276, 217);
            this.dgvListadoLoca.MultiSelect = false;
            this.dgvListadoLoca.Name = "dgvListadoLoca";
            this.dgvListadoLoca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoLoca.Size = new System.Drawing.Size(236, 138);
            this.dgvListadoLoca.TabIndex = 28;
            // 
            // GboxBuscador
            // 
            this.GboxBuscador.Controls.Add(this.btnCancelarBuscar);
            this.GboxBuscador.Controls.Add(this.btnBuscar);
            this.GboxBuscador.Controls.Add(this.txtClave);
            this.GboxBuscador.Controls.Add(this.cboCriterio);
            this.GboxBuscador.Controls.Add(this.cboCampo);
            this.GboxBuscador.Location = new System.Drawing.Point(36, 217);
            this.GboxBuscador.Name = "GboxBuscador";
            this.GboxBuscador.Size = new System.Drawing.Size(191, 138);
            this.GboxBuscador.TabIndex = 36;
            this.GboxBuscador.TabStop = false;
            this.GboxBuscador.Text = "BUSCADOR";
            // 
            // btnCancelarBuscar
            // 
            this.btnCancelarBuscar.Location = new System.Drawing.Point(99, 105);
            this.btnCancelarBuscar.Name = "btnCancelarBuscar";
            this.btnCancelarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBuscar.TabIndex = 19;
            this.btnCancelarBuscar.Text = "Cancelar";
            this.btnCancelarBuscar.UseVisualStyleBackColor = true;
            this.btnCancelarBuscar.Click += new System.EventHandler(this.btnCancelarBuscar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(6, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(6, 79);
            this.txtClave.Name = "txtClave";
            this.txtClave.ShortcutsEnabled = false;
            this.txtClave.Size = new System.Drawing.Size(119, 20);
            this.txtClave.TabIndex = 17;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(6, 47);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(119, 21);
            this.cboCriterio.TabIndex = 16;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(6, 20);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(119, 21);
            this.cboCampo.TabIndex = 15;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // Localidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 428);
            this.Controls.Add(this.GboxBuscador);
            this.Controls.Add(this.gboxAltaLocalidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenuAnterior);
            this.Controls.Add(this.btnBuscarLocalidad);
            this.Controls.Add(this.btnEliminarLocalidad);
            this.Controls.Add(this.btnModificarLocalidad);
            this.Controls.Add(this.btnAgregarLocalidad);
            this.Controls.Add(this.dgvListadoLoca);
            this.Name = "Localidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.Localidades_Load);
            this.gboxAltaLocalidad.ResumeLayout(false);
            this.gboxAltaLocalidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLoca)).EndInit();
            this.GboxBuscador.ResumeLayout(false);
            this.GboxBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gboxAltaLocalidad;
        internal System.Windows.Forms.Button btnCancelarCargar;
        internal System.Windows.Forms.Button btnConfirmarCarga;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblLocalidad;
        internal System.Windows.Forms.TextBox txtCodigoPostal;
        internal System.Windows.Forms.TextBox txtLocalidad;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnMenuAnterior;
        internal System.Windows.Forms.Button btnBuscarLocalidad;
        internal System.Windows.Forms.Button btnEliminarLocalidad;
        internal System.Windows.Forms.Button btnModificarLocalidad;
        internal System.Windows.Forms.Button btnAgregarLocalidad;
        internal System.Windows.Forms.DataGridView dgvListadoLoca;
        internal System.Windows.Forms.GroupBox GboxBuscador;
        internal System.Windows.Forms.Button btnCancelarBuscar;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.ComboBox cboCriterio;
        internal System.Windows.Forms.ComboBox cboCampo;
    }
}