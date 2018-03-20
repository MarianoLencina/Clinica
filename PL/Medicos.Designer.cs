namespace PL
{
    partial class Medicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTNbuscarMedico = new System.Windows.Forms.Button();
            this.GboxBuscador = new System.Windows.Forms.GroupBox();
            this.btnCancelarBuscar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.GboxAltaMedico = new System.Windows.Forms.GroupBox();
            this.CBOHORARIOS = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAgregarLocal = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelPart = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelParticular = new System.Windows.Forms.TextBox();
            this.txtTelPersonal = new System.Windows.Forms.TextBox();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.btnMenuant = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.GboxBuscador.SuspendLayout();
            this.GboxAltaMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNbuscarMedico
            // 
            this.BTNbuscarMedico.Location = new System.Drawing.Point(12, 132);
            this.BTNbuscarMedico.Name = "BTNbuscarMedico";
            this.BTNbuscarMedico.Size = new System.Drawing.Size(125, 34);
            this.BTNbuscarMedico.TabIndex = 33;
            this.BTNbuscarMedico.Text = "BUSCAR MEDICO";
            this.BTNbuscarMedico.UseVisualStyleBackColor = true;
            this.BTNbuscarMedico.Click += new System.EventHandler(this.BTNbuscarMedico_Click);
            // 
            // GboxBuscador
            // 
            this.GboxBuscador.Controls.Add(this.btnCancelarBuscar);
            this.GboxBuscador.Controls.Add(this.btnBuscar);
            this.GboxBuscador.Controls.Add(this.txtClave);
            this.GboxBuscador.Controls.Add(this.cboCriterio);
            this.GboxBuscador.Controls.Add(this.cboCampo);
            this.GboxBuscador.Location = new System.Drawing.Point(12, 172);
            this.GboxBuscador.Name = "GboxBuscador";
            this.GboxBuscador.Size = new System.Drawing.Size(177, 138);
            this.GboxBuscador.TabIndex = 39;
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
            // GboxAltaMedico
            // 
            this.GboxAltaMedico.Controls.Add(this.CBOHORARIOS);
            this.GboxAltaMedico.Controls.Add(this.Label3);
            this.GboxAltaMedico.Controls.Add(this.btnCancelar);
            this.GboxAltaMedico.Controls.Add(this.btnConfirmar);
            this.GboxAltaMedico.Controls.Add(this.btnAgregarLocal);
            this.GboxAltaMedico.Controls.Add(this.Label10);
            this.GboxAltaMedico.Controls.Add(this.Label9);
            this.GboxAltaMedico.Controls.Add(this.lblMail);
            this.GboxAltaMedico.Controls.Add(this.lblTelPart);
            this.GboxAltaMedico.Controls.Add(this.Label6);
            this.GboxAltaMedico.Controls.Add(this.lblLocalidad);
            this.GboxAltaMedico.Controls.Add(this.lblDireccion);
            this.GboxAltaMedico.Controls.Add(this.LblDni);
            this.GboxAltaMedico.Controls.Add(this.LblApellido);
            this.GboxAltaMedico.Controls.Add(this.lblNombre);
            this.GboxAltaMedico.Controls.Add(this.cboSexo);
            this.GboxAltaMedico.Controls.Add(this.dtpFechaNac);
            this.GboxAltaMedico.Controls.Add(this.txtCorreo);
            this.GboxAltaMedico.Controls.Add(this.txtTelParticular);
            this.GboxAltaMedico.Controls.Add(this.txtTelPersonal);
            this.GboxAltaMedico.Controls.Add(this.cboLocalidad);
            this.GboxAltaMedico.Controls.Add(this.txtDireccion);
            this.GboxAltaMedico.Controls.Add(this.txtDni);
            this.GboxAltaMedico.Controls.Add(this.txtApellido);
            this.GboxAltaMedico.Controls.Add(this.txtNombre);
            this.GboxAltaMedico.Location = new System.Drawing.Point(208, 12);
            this.GboxAltaMedico.Name = "GboxAltaMedico";
            this.GboxAltaMedico.Size = new System.Drawing.Size(564, 270);
            this.GboxAltaMedico.TabIndex = 38;
            this.GboxAltaMedico.TabStop = false;
            this.GboxAltaMedico.Text = "AGREGAR MEDICO";
            // 
            // CBOHORARIOS
            // 
            this.CBOHORARIOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOHORARIOS.FormattingEnabled = true;
            this.CBOHORARIOS.Location = new System.Drawing.Point(108, 18);
            this.CBOHORARIOS.Name = "CBOHORARIOS";
            this.CBOHORARIOS.Size = new System.Drawing.Size(143, 21);
            this.CBOHORARIOS.TabIndex = 77;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 26);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 13);
            this.Label3.TabIndex = 76;
            this.Label3.Text = "TURNO MEDICO:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(454, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 23);
            this.btnCancelar.TabIndex = 73;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(279, 239);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(104, 23);
            this.btnConfirmar.TabIndex = 72;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnAgregarLocal
            // 
            this.btnAgregarLocal.Location = new System.Drawing.Point(26, 237);
            this.btnAgregarLocal.Name = "btnAgregarLocal";
            this.btnAgregarLocal.Size = new System.Drawing.Size(223, 23);
            this.btnAgregarLocal.TabIndex = 71;
            this.btnAgregarLocal.Text = "Agregar Localidad Si No Figura En La Lista";
            this.btnAgregarLocal.UseVisualStyleBackColor = true;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(367, 208);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(34, 13);
            this.Label10.TabIndex = 69;
            this.Label10.Text = "Sexo:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(288, 170);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(113, 13);
            this.Label9.TabIndex = 68;
            this.Label9.Text = "Fecha De Nacimiento:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(304, 138);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(97, 13);
            this.lblMail.TabIndex = 67;
            this.lblMail.Text = "Correo Electronico:";
            // 
            // lblTelPart
            // 
            this.lblTelPart.AutoSize = true;
            this.lblTelPart.Location = new System.Drawing.Point(329, 97);
            this.lblTelPart.Name = "lblTelPart";
            this.lblTelPart.Size = new System.Drawing.Size(72, 13);
            this.lblTelPart.TabIndex = 66;
            this.lblTelPart.Text = "Tel Particular:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(332, 59);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(69, 13);
            this.Label6.TabIndex = 65;
            this.Label6.Text = "Tel Personal:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(40, 209);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 64;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(41, 172);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 63;
            this.lblDireccion.Text = "Direccion:";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(67, 134);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(29, 13);
            this.LblDni.TabIndex = 62;
            this.LblDni.Text = "DNI:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(49, 97);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(47, 13);
            this.LblApellido.TabIndex = 61;
            this.LblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 60;
            this.lblNombre.Text = "Nombre:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(417, 200);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(143, 21);
            this.cboSexo.TabIndex = 59;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(417, 163);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaNac.TabIndex = 58;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(417, 131);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(143, 20);
            this.txtCorreo.TabIndex = 57;
            // 
            // txtTelParticular
            // 
            this.txtTelParticular.Location = new System.Drawing.Point(417, 90);
            this.txtTelParticular.MaxLength = 15;
            this.txtTelParticular.Name = "txtTelParticular";
            this.txtTelParticular.ShortcutsEnabled = false;
            this.txtTelParticular.Size = new System.Drawing.Size(143, 20);
            this.txtTelParticular.TabIndex = 56;
            // 
            // txtTelPersonal
            // 
            this.txtTelPersonal.Location = new System.Drawing.Point(417, 52);
            this.txtTelPersonal.MaxLength = 15;
            this.txtTelPersonal.Name = "txtTelPersonal";
            this.txtTelPersonal.ShortcutsEnabled = false;
            this.txtTelPersonal.Size = new System.Drawing.Size(143, 20);
            this.txtTelPersonal.TabIndex = 55;
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(108, 201);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(143, 21);
            this.cboLocalidad.TabIndex = 54;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(108, 165);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ShortcutsEnabled = false;
            this.txtDireccion.Size = new System.Drawing.Size(143, 20);
            this.txtDireccion.TabIndex = 53;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(108, 127);
            this.txtDni.MaxLength = 11;
            this.txtDni.Name = "txtDni";
            this.txtDni.ShortcutsEnabled = false;
            this.txtDni.Size = new System.Drawing.Size(143, 20);
            this.txtDni.TabIndex = 52;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(108, 89);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(143, 20);
            this.txtApellido.TabIndex = 51;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 52);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 50;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(204, 297);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(314, 20);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "D A T O S      D E      L O S     M E D I C O S";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(543, 461);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(80, 23);
            this.btnsalir.TabIndex = 35;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dgvMedicos
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicos.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvMedicos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMedicos.Location = new System.Drawing.Point(12, 320);
            this.dgvMedicos.MultiSelect = false;
            this.dgvMedicos.Name = "dgvMedicos";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(760, 97);
            this.dgvMedicos.TabIndex = 36;
            // 
            // btnMenuant
            // 
            this.btnMenuant.Location = new System.Drawing.Point(128, 461);
            this.btnMenuant.Name = "btnMenuant";
            this.btnMenuant.Size = new System.Drawing.Size(125, 23);
            this.btnMenuant.TabIndex = 34;
            this.btnMenuant.Text = "MENU ANTERIOR";
            this.btnMenuant.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(12, 92);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(125, 34);
            this.btneliminar.TabIndex = 32;
            this.btneliminar.Text = "ELIMINAR MEDICO";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(12, 52);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(125, 34);
            this.btnmodificar.TabIndex = 31;
            this.btnmodificar.Text = "MODIFICAR MEDICO";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 12);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(125, 34);
            this.btnagregar.TabIndex = 30;
            this.btnagregar.Text = "AGREGAR MEDICO";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BTNbuscarMedico);
            this.Controls.Add(this.GboxBuscador);
            this.Controls.Add(this.GboxAltaMedico);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.btnMenuant);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Name = "Medicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicos";
            this.Load += new System.EventHandler(this.Medicos_Load);
            this.GboxBuscador.ResumeLayout(false);
            this.GboxBuscador.PerformLayout();
            this.GboxAltaMedico.ResumeLayout(false);
            this.GboxAltaMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button BTNbuscarMedico;
        internal System.Windows.Forms.GroupBox GboxBuscador;
        internal System.Windows.Forms.Button btnCancelarBuscar;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.ComboBox cboCriterio;
        internal System.Windows.Forms.ComboBox cboCampo;
        internal System.Windows.Forms.GroupBox GboxAltaMedico;
        internal System.Windows.Forms.ComboBox CBOHORARIOS;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnConfirmar;
        internal System.Windows.Forms.Button btnAgregarLocal;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label lblMail;
        internal System.Windows.Forms.Label lblTelPart;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblLocalidad;
        internal System.Windows.Forms.Label lblDireccion;
        internal System.Windows.Forms.Label LblDni;
        internal System.Windows.Forms.Label LblApellido;
        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.ComboBox cboSexo;
        internal System.Windows.Forms.DateTimePicker dtpFechaNac;
        internal System.Windows.Forms.TextBox txtCorreo;
        internal System.Windows.Forms.TextBox txtTelParticular;
        internal System.Windows.Forms.TextBox txtTelPersonal;
        internal System.Windows.Forms.ComboBox cboLocalidad;
        internal System.Windows.Forms.TextBox txtDireccion;
        internal System.Windows.Forms.TextBox txtDni;
        internal System.Windows.Forms.TextBox txtApellido;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnsalir;
        internal System.Windows.Forms.DataGridView dgvMedicos;
        internal System.Windows.Forms.Button btnMenuant;
        internal System.Windows.Forms.Button btneliminar;
        internal System.Windows.Forms.Button btnmodificar;
        internal System.Windows.Forms.Button btnagregar;
    }
}