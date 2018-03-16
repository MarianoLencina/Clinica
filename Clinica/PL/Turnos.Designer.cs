namespace PL
{
    partial class Turnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GboxOpciones = new System.Windows.Forms.GroupBox();
            this.btnTodosTurnos = new System.Windows.Forms.Button();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.CBOLISTA = new System.Windows.Forms.ComboBox();
            this.CBOBUSCAR = new System.Windows.Forms.ComboBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsolicitarturno = new System.Windows.Forms.Button();
            this.gboxTurno = new System.Windows.Forms.GroupBox();
            this.cboHoraTurno = new System.Windows.Forms.ComboBox();
            this.BTNgbtCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.cboHorarios = new System.Windows.Forms.ComboBox();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.cboMedicos = new System.Windows.Forms.ComboBox();
            this.cboPacientes = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblFechaTurno = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmenuant = new System.Windows.Forms.Button();
            this.GboxOpciones.SuspendLayout();
            this.gboxTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // GboxOpciones
            // 
            this.GboxOpciones.Controls.Add(this.btnTodosTurnos);
            this.GboxOpciones.Controls.Add(this.BTNBUSCAR);
            this.GboxOpciones.Controls.Add(this.Label2);
            this.GboxOpciones.Controls.Add(this.CBOLISTA);
            this.GboxOpciones.Controls.Add(this.CBOBUSCAR);
            this.GboxOpciones.Controls.Add(this.btncancelar);
            this.GboxOpciones.Controls.Add(this.btnsolicitarturno);
            this.GboxOpciones.Location = new System.Drawing.Point(12, 43);
            this.GboxOpciones.Name = "GboxOpciones";
            this.GboxOpciones.Size = new System.Drawing.Size(423, 150);
            this.GboxOpciones.TabIndex = 47;
            this.GboxOpciones.TabStop = false;
            this.GboxOpciones.Text = "OPCIONES";
            // 
            // btnTodosTurnos
            // 
            this.btnTodosTurnos.Location = new System.Drawing.Point(307, 88);
            this.btnTodosTurnos.Name = "btnTodosTurnos";
            this.btnTodosTurnos.Size = new System.Drawing.Size(110, 23);
            this.btnTodosTurnos.TabIndex = 6;
            this.btnTodosTurnos.Text = "Todos ";
            this.btnTodosTurnos.UseVisualStyleBackColor = true;
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.Location = new System.Drawing.Point(307, 43);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(110, 23);
            this.BTNBUSCAR.TabIndex = 3;
            this.BTNBUSCAR.Text = "BUSCAR";
            this.BTNBUSCAR.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(63, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(337, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "B  U  S  Q  U  E  D  A       D  E        T  U  R  N  O  S       P  O  R     . . ." +
    "";
            // 
            // CBOLISTA
            // 
            this.CBOLISTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOLISTA.FormattingEnabled = true;
            this.CBOLISTA.Location = new System.Drawing.Point(164, 43);
            this.CBOLISTA.Name = "CBOLISTA";
            this.CBOLISTA.Size = new System.Drawing.Size(121, 21);
            this.CBOLISTA.TabIndex = 2;
            // 
            // CBOBUSCAR
            // 
            this.CBOBUSCAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOBUSCAR.FormattingEnabled = true;
            this.CBOBUSCAR.Location = new System.Drawing.Point(21, 43);
            this.CBOBUSCAR.Name = "CBOBUSCAR";
            this.CBOBUSCAR.Size = new System.Drawing.Size(121, 21);
            this.CBOBUSCAR.TabIndex = 1;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(164, 90);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(121, 23);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar Turno";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsolicitarturno
            // 
            this.btnsolicitarturno.Location = new System.Drawing.Point(21, 90);
            this.btnsolicitarturno.Name = "btnsolicitarturno";
            this.btnsolicitarturno.Size = new System.Drawing.Size(121, 23);
            this.btnsolicitarturno.TabIndex = 4;
            this.btnsolicitarturno.Text = "Solicitar Turno";
            this.btnsolicitarturno.UseVisualStyleBackColor = true;
            this.btnsolicitarturno.Click += new System.EventHandler(this.btnsolicitarturno_Click);
            // 
            // gboxTurno
            // 
            this.gboxTurno.Controls.Add(this.cboHoraTurno);
            this.gboxTurno.Controls.Add(this.BTNgbtCancelar);
            this.gboxTurno.Controls.Add(this.btnConfirmar);
            this.gboxTurno.Controls.Add(this.btnAgregarPaciente);
            this.gboxTurno.Controls.Add(this.cboHorarios);
            this.gboxTurno.Controls.Add(this.cboEspecialidad);
            this.gboxTurno.Controls.Add(this.cboMedicos);
            this.gboxTurno.Controls.Add(this.cboPacientes);
            this.gboxTurno.Controls.Add(this.txtObservaciones);
            this.gboxTurno.Controls.Add(this.lblFechaTurno);
            this.gboxTurno.Controls.Add(this.Label3);
            this.gboxTurno.Controls.Add(this.dtpFecha);
            this.gboxTurno.Controls.Add(this.lblObservaciones);
            this.gboxTurno.Controls.Add(this.lblMedico);
            this.gboxTurno.Controls.Add(this.Label4);
            this.gboxTurno.Controls.Add(this.lblHora);
            this.gboxTurno.Controls.Add(this.lblPaciente);
            this.gboxTurno.Location = new System.Drawing.Point(441, 12);
            this.gboxTurno.Name = "gboxTurno";
            this.gboxTurno.Size = new System.Drawing.Size(340, 466);
            this.gboxTurno.TabIndex = 46;
            this.gboxTurno.TabStop = false;
            this.gboxTurno.Text = "TURNO";
            // 
            // cboHoraTurno
            // 
            this.cboHoraTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoraTurno.FormattingEnabled = true;
            this.cboHoraTurno.Location = new System.Drawing.Point(117, 260);
            this.cboHoraTurno.Name = "cboHoraTurno";
            this.cboHoraTurno.Size = new System.Drawing.Size(47, 21);
            this.cboHoraTurno.TabIndex = 52;
            this.cboHoraTurno.SelectedIndexChanged += new System.EventHandler(this.cboHoraTurno_SelectedIndexChanged);
            // 
            // BTNgbtCancelar
            // 
            this.BTNgbtCancelar.Location = new System.Drawing.Point(166, 360);
            this.BTNgbtCancelar.Name = "BTNgbtCancelar";
            this.BTNgbtCancelar.Size = new System.Drawing.Size(92, 32);
            this.BTNgbtCancelar.TabIndex = 17;
            this.BTNgbtCancelar.Text = "Cancelar";
            this.BTNgbtCancelar.UseVisualStyleBackColor = true;
            this.BTNgbtCancelar.Click += new System.EventHandler(this.BTNgbtCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(28, 360);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(84, 32);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.Location = new System.Drawing.Point(118, 19);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(180, 23);
            this.btnAgregarPaciente.TabIndex = 51;
            this.btnAgregarPaciente.Text = "Agregar Paciente";
            this.btnAgregarPaciente.UseVisualStyleBackColor = true;
            // 
            // cboHorarios
            // 
            this.cboHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHorarios.FormattingEnabled = true;
            this.cboHorarios.Location = new System.Drawing.Point(119, 185);
            this.cboHorarios.Name = "cboHorarios";
            this.cboHorarios.Size = new System.Drawing.Size(140, 21);
            this.cboHorarios.TabIndex = 11;
            this.cboHorarios.SelectedIndexChanged += new System.EventHandler(this.cboHorarios_SelectedIndexChanged);
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(119, 105);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(140, 21);
            this.cboEspecialidad.TabIndex = 10;
            this.cboEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cboEspecialidad_SelectedIndexChanged);
            // 
            // cboMedicos
            // 
            this.cboMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicos.FormattingEnabled = true;
            this.cboMedicos.Location = new System.Drawing.Point(119, 148);
            this.cboMedicos.Name = "cboMedicos";
            this.cboMedicos.Size = new System.Drawing.Size(180, 21);
            this.cboMedicos.TabIndex = 12;
            this.cboMedicos.SelectedIndexChanged += new System.EventHandler(this.cboMedicos_SelectedIndexChanged);
            // 
            // cboPacientes
            // 
            this.cboPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacientes.FormattingEnabled = true;
            this.cboPacientes.Location = new System.Drawing.Point(118, 63);
            this.cboPacientes.Name = "cboPacientes";
            this.cboPacientes.Size = new System.Drawing.Size(180, 21);
            this.cboPacientes.TabIndex = 9;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(117, 295);
            this.txtObservaciones.MaxLength = 100;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ShortcutsEnabled = false;
            this.txtObservaciones.Size = new System.Drawing.Size(214, 20);
            this.txtObservaciones.TabIndex = 15;
            // 
            // lblFechaTurno
            // 
            this.lblFechaTurno.AutoSize = true;
            this.lblFechaTurno.Location = new System.Drawing.Point(22, 232);
            this.lblFechaTurno.Name = "lblFechaTurno";
            this.lblFechaTurno.Size = new System.Drawing.Size(90, 13);
            this.lblFechaTurno.TabIndex = 37;
            this.lblFechaTurno.Text = "Fecha Del Turno:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(179, 268);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(22, 13);
            this.Label3.TabIndex = 44;
            this.Label3.Text = "HS";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(118, 225);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(213, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(31, 302);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 41;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(68, 156);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(45, 13);
            this.lblMedico.TabIndex = 40;
            this.lblMedico.Text = "Medico:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(32, 113);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(70, 13);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "Especialidad:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(48, 268);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(64, 13);
            this.lblHora.TabIndex = 38;
            this.lblHora.Text = "Hora Turno:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(25, 71);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(77, 13);
            this.lblPaciente.TabIndex = 36;
            this.lblPaciente.Text = "Lista Paciente:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(145, 215);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(135, 13);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "LISTADO   DE   TURNOS ";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dgvTurnos
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurnos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTurnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTurnos.Location = new System.Drawing.Point(12, 232);
            this.dgvTurnos.MultiSelect = false;
            this.dgvTurnos.Name = "dgvTurnos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnos.Size = new System.Drawing.Size(423, 150);
            this.dgvTurnos.TabIndex = 42;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(327, 455);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(108, 23);
            this.btnsalir.TabIndex = 45;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnmenuant
            // 
            this.btnmenuant.Location = new System.Drawing.Point(33, 455);
            this.btnmenuant.Name = "btnmenuant";
            this.btnmenuant.Size = new System.Drawing.Size(108, 23);
            this.btnmenuant.TabIndex = 44;
            this.btnmenuant.Text = "Menu Anterior";
            this.btnmenuant.UseVisualStyleBackColor = true;
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GboxOpciones);
            this.Controls.Add(this.gboxTurno);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmenuant);
            this.Name = "Turnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.Turnos_Load);
            this.GboxOpciones.ResumeLayout(false);
            this.GboxOpciones.PerformLayout();
            this.gboxTurno.ResumeLayout(false);
            this.gboxTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GboxOpciones;
        internal System.Windows.Forms.Button btnTodosTurnos;
        internal System.Windows.Forms.Button BTNBUSCAR;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox CBOLISTA;
        internal System.Windows.Forms.ComboBox CBOBUSCAR;
        internal System.Windows.Forms.Button btncancelar;
        internal System.Windows.Forms.Button btnsolicitarturno;
        internal System.Windows.Forms.GroupBox gboxTurno;
        internal System.Windows.Forms.Button BTNgbtCancelar;
        internal System.Windows.Forms.Button btnConfirmar;
        internal System.Windows.Forms.Button btnAgregarPaciente;
        internal System.Windows.Forms.ComboBox cboHorarios;
        internal System.Windows.Forms.ComboBox cboEspecialidad;
        internal System.Windows.Forms.ComboBox cboMedicos;
        internal System.Windows.Forms.ComboBox cboPacientes;
        internal System.Windows.Forms.TextBox txtObservaciones;
        internal System.Windows.Forms.Label lblFechaTurno;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        internal System.Windows.Forms.Label lblObservaciones;
        internal System.Windows.Forms.Label lblMedico;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblHora;
        internal System.Windows.Forms.Label lblPaciente;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgvTurnos;
        internal System.Windows.Forms.Button btnsalir;
        internal System.Windows.Forms.Button btnmenuant;
        private System.Windows.Forms.ComboBox cboHoraTurno;
    }
}