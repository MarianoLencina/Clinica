namespace PL
{
    partial class Pacientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.gboxAltaPaciente = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelPart = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelParticular = new System.Windows.Forms.TextBox();
            this.txtTelPersonal = new System.Windows.Forms.TextBox();
            this.btnAgregarLocal = new System.Windows.Forms.Button();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.gboxBuscador = new System.Windows.Forms.GroupBox();
            this.btnCancelarBuscador = new System.Windows.Forms.Button();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.btnSalirPaciente = new System.Windows.Forms.Button();
            this.btnMenuAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.gboxAltaPaciente.SuspendLayout();
            this.gboxBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(247, 315);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(227, 13);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "D A T O S     D E     LOS      P A C I E N T E S";
            // 
            // dgvPacientes
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPacientes.Location = new System.Drawing.Point(7, 341);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(770, 150);
            this.dgvPacientes.TabIndex = 28;
            // 
            // gboxAltaPaciente
            // 
            this.gboxAltaPaciente.Controls.Add(this.btnCancelar);
            this.gboxAltaPaciente.Controls.Add(this.btnConfirmar);
            this.gboxAltaPaciente.Controls.Add(this.Label10);
            this.gboxAltaPaciente.Controls.Add(this.Label9);
            this.gboxAltaPaciente.Controls.Add(this.lblMail);
            this.gboxAltaPaciente.Controls.Add(this.lblTelPart);
            this.gboxAltaPaciente.Controls.Add(this.Label6);
            this.gboxAltaPaciente.Controls.Add(this.cboSexo);
            this.gboxAltaPaciente.Controls.Add(this.dtpFechaNac);
            this.gboxAltaPaciente.Controls.Add(this.txtCorreo);
            this.gboxAltaPaciente.Controls.Add(this.txtTelParticular);
            this.gboxAltaPaciente.Controls.Add(this.txtTelPersonal);
            this.gboxAltaPaciente.Controls.Add(this.btnAgregarLocal);
            this.gboxAltaPaciente.Controls.Add(this.lblLocalidad);
            this.gboxAltaPaciente.Controls.Add(this.lblDireccion);
            this.gboxAltaPaciente.Controls.Add(this.LblDni);
            this.gboxAltaPaciente.Controls.Add(this.LblApellido);
            this.gboxAltaPaciente.Controls.Add(this.Label1);
            this.gboxAltaPaciente.Controls.Add(this.cboLocalidad);
            this.gboxAltaPaciente.Controls.Add(this.txtDireccion);
            this.gboxAltaPaciente.Controls.Add(this.txtDni);
            this.gboxAltaPaciente.Controls.Add(this.txtApellido);
            this.gboxAltaPaciente.Controls.Add(this.txtNombre);
            this.gboxAltaPaciente.Location = new System.Drawing.Point(231, 12);
            this.gboxAltaPaciente.Name = "gboxAltaPaciente";
            this.gboxAltaPaciente.Size = new System.Drawing.Size(546, 254);
            this.gboxAltaPaciente.TabIndex = 35;
            this.gboxAltaPaciente.TabStop = false;
            this.gboxAltaPaciente.Text = "ALTA PACIENTE";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(415, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 23);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(268, 204);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(104, 23);
            this.btnConfirmar.TabIndex = 45;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(338, 175);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(34, 13);
            this.Label10.TabIndex = 44;
            this.Label10.Text = "Sexo:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(259, 137);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(113, 13);
            this.Label9.TabIndex = 43;
            this.Label9.Text = "Fecha De Nacimiento:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(275, 105);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(97, 13);
            this.lblMail.TabIndex = 42;
            this.lblMail.Text = "Correo Electronico:";
            // 
            // lblTelPart
            // 
            this.lblTelPart.AutoSize = true;
            this.lblTelPart.Location = new System.Drawing.Point(300, 64);
            this.lblTelPart.Name = "lblTelPart";
            this.lblTelPart.Size = new System.Drawing.Size(72, 13);
            this.lblTelPart.TabIndex = 41;
            this.lblTelPart.Text = "Tel Particular:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(303, 26);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(69, 13);
            this.Label6.TabIndex = 40;
            this.Label6.Text = "Tel Personal:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(378, 167);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(143, 21);
            this.cboSexo.TabIndex = 39;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(378, 130);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaNac.TabIndex = 38;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(378, 98);
            this.txtCorreo.MaxLength = 30;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(143, 20);
            this.txtCorreo.TabIndex = 37;
            // 
            // txtTelParticular
            // 
            this.txtTelParticular.Location = new System.Drawing.Point(378, 57);
            this.txtTelParticular.MaxLength = 14;
            this.txtTelParticular.Name = "txtTelParticular";
            this.txtTelParticular.ShortcutsEnabled = false;
            this.txtTelParticular.Size = new System.Drawing.Size(143, 20);
            this.txtTelParticular.TabIndex = 36;
            // 
            // txtTelPersonal
            // 
            this.txtTelPersonal.Location = new System.Drawing.Point(378, 19);
            this.txtTelPersonal.MaxLength = 14;
            this.txtTelPersonal.Name = "txtTelPersonal";
            this.txtTelPersonal.ShortcutsEnabled = false;
            this.txtTelPersonal.Size = new System.Drawing.Size(143, 20);
            this.txtTelPersonal.TabIndex = 35;
            // 
            // btnAgregarLocal
            // 
            this.btnAgregarLocal.Location = new System.Drawing.Point(7, 204);
            this.btnAgregarLocal.Name = "btnAgregarLocal";
            this.btnAgregarLocal.Size = new System.Drawing.Size(223, 23);
            this.btnAgregarLocal.TabIndex = 34;
            this.btnAgregarLocal.Text = "Agregar Localidad Si No Figura En La Lista";
            this.btnAgregarLocal.UseVisualStyleBackColor = true;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(16, 176);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 33;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 139);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 32;
            this.lblDireccion.Text = "Direccion:";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(43, 100);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(29, 13);
            this.LblDni.TabIndex = 31;
            this.LblDni.Text = "DNI:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(25, 63);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(47, 13);
            this.LblApellido.TabIndex = 30;
            this.LblApellido.Text = "Apellido:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(25, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Nombre:";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(89, 168);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(143, 21);
            this.cboLocalidad.TabIndex = 28;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(89, 132);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ShortcutsEnabled = false;
            this.txtDireccion.Size = new System.Drawing.Size(143, 20);
            this.txtDireccion.TabIndex = 27;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(89, 93);
            this.txtDni.MaxLength = 12;
            this.txtDni.Name = "txtDni";
            this.txtDni.ShortcutsEnabled = false;
            this.txtDni.Size = new System.Drawing.Size(143, 20);
            this.txtDni.TabIndex = 26;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(89, 56);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(143, 20);
            this.txtApellido.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 19);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(7, 99);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(154, 23);
            this.btnBuscarPaciente.TabIndex = 33;
            this.btnBuscarPaciente.Text = "BUSCAR PACIENTE";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // gboxBuscador
            // 
            this.gboxBuscador.Controls.Add(this.btnCancelarBuscador);
            this.gboxBuscador.Controls.Add(this.cboCampo);
            this.gboxBuscador.Controls.Add(this.cboCriterio);
            this.gboxBuscador.Controls.Add(this.btnBuscar);
            this.gboxBuscador.Controls.Add(this.txtClave);
            this.gboxBuscador.Location = new System.Drawing.Point(7, 144);
            this.gboxBuscador.Name = "gboxBuscador";
            this.gboxBuscador.Size = new System.Drawing.Size(197, 134);
            this.gboxBuscador.TabIndex = 34;
            this.gboxBuscador.TabStop = false;
            this.gboxBuscador.Text = "BUSCADOR";
            // 
            // btnCancelarBuscador
            // 
            this.btnCancelarBuscador.Location = new System.Drawing.Point(116, 99);
            this.btnCancelarBuscador.Name = "btnCancelarBuscador";
            this.btnCancelarBuscador.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBuscador.TabIndex = 11;
            this.btnCancelarBuscador.Text = "Cancelar";
            this.btnCancelarBuscador.UseVisualStyleBackColor = true;
            this.btnCancelarBuscador.Click += new System.EventHandler(this.btnCancelarBuscador_Click);
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(36, 19);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(131, 21);
            this.cboCampo.TabIndex = 7;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(36, 46);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(131, 21);
            this.cboCriterio.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(36, 72);
            this.txtClave.MaxLength = 30;
            this.txtClave.Name = "txtClave";
            this.txtClave.ShortcutsEnabled = false;
            this.txtClave.Size = new System.Drawing.Size(131, 20);
            this.txtClave.TabIndex = 9;
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Location = new System.Drawing.Point(7, 70);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(154, 23);
            this.btnEliminarPaciente.TabIndex = 32;
            this.btnEliminarPaciente.Text = "ELIMINAR PACIENTE";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.Location = new System.Drawing.Point(7, 41);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(154, 23);
            this.btnModificarPaciente.TabIndex = 31;
            this.btnModificarPaciente.Text = "MODIFICAR PACIENTE";
            this.btnModificarPaciente.UseVisualStyleBackColor = true;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.Location = new System.Drawing.Point(7, 12);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(154, 23);
            this.btnAgregarPaciente.TabIndex = 30;
            this.btnAgregarPaciente.Text = "AGREGAR PACIENTE";
            this.btnAgregarPaciente.UseVisualStyleBackColor = true;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // btnSalirPaciente
            // 
            this.btnSalirPaciente.Location = new System.Drawing.Point(562, 511);
            this.btnSalirPaciente.Name = "btnSalirPaciente";
            this.btnSalirPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnSalirPaciente.TabIndex = 37;
            this.btnSalirPaciente.Text = "SALIR";
            this.btnSalirPaciente.UseVisualStyleBackColor = true;
            this.btnSalirPaciente.Click += new System.EventHandler(this.btnSalirPaciente_Click);
            // 
            // btnMenuAnterior
            // 
            this.btnMenuAnterior.Location = new System.Drawing.Point(134, 511);
            this.btnMenuAnterior.Name = "btnMenuAnterior";
            this.btnMenuAnterior.Size = new System.Drawing.Size(139, 23);
            this.btnMenuAnterior.TabIndex = 36;
            this.btnMenuAnterior.Text = "MENU ANTERIOR";
            this.btnMenuAnterior.UseVisualStyleBackColor = true;
            this.btnMenuAnterior.Click += new System.EventHandler(this.btnMenuAnterior_Click);
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSalirPaciente);
            this.Controls.Add(this.btnMenuAnterior);
            this.Controls.Add(this.gboxAltaPaciente);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.gboxBuscador);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Controls.Add(this.btnModificarPaciente);
            this.Controls.Add(this.btnAgregarPaciente);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvPacientes);
            this.Name = "Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.gboxAltaPaciente.ResumeLayout(false);
            this.gboxAltaPaciente.PerformLayout();
            this.gboxBuscador.ResumeLayout(false);
            this.gboxBuscador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.DataGridView dgvPacientes;
        internal System.Windows.Forms.GroupBox gboxAltaPaciente;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnConfirmar;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label lblMail;
        internal System.Windows.Forms.Label lblTelPart;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cboSexo;
        internal System.Windows.Forms.DateTimePicker dtpFechaNac;
        internal System.Windows.Forms.TextBox txtCorreo;
        internal System.Windows.Forms.TextBox txtTelParticular;
        internal System.Windows.Forms.TextBox txtTelPersonal;
        internal System.Windows.Forms.Button btnAgregarLocal;
        internal System.Windows.Forms.Label lblLocalidad;
        internal System.Windows.Forms.Label lblDireccion;
        internal System.Windows.Forms.Label LblDni;
        internal System.Windows.Forms.Label LblApellido;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboLocalidad;
        internal System.Windows.Forms.TextBox txtDireccion;
        internal System.Windows.Forms.TextBox txtDni;
        internal System.Windows.Forms.TextBox txtApellido;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Button btnBuscarPaciente;
        internal System.Windows.Forms.GroupBox gboxBuscador;
        internal System.Windows.Forms.Button btnCancelarBuscador;
        internal System.Windows.Forms.ComboBox cboCampo;
        internal System.Windows.Forms.ComboBox cboCriterio;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.Button btnEliminarPaciente;
        internal System.Windows.Forms.Button btnModificarPaciente;
        internal System.Windows.Forms.Button btnAgregarPaciente;
        internal System.Windows.Forms.Button btnSalirPaciente;
        internal System.Windows.Forms.Button btnMenuAnterior;
    }
}