using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace PL
{
    public partial class Turnos : Form
    {
        private IList<Especialidad > listaespecialidad;
        private  Horarios Horatrabajo;

        public Turnos()
        {
            InitializeComponent();
        }

        public Turnos( Horarios horas)
        {
            InitializeComponent();
            Horatrabajo  = horas ;
        }


        public Turnos (IList<Especialidad > lista)
        {
            InitializeComponent();
           listaespecialidad   = lista ;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }


        public void cargarDgv()
        {
            turnosServicio turSer = new turnosServicio();
            dgvTurnos.DataSource = turSer.traerTodos();
            dgvTurnos.Columns[0].Visible = false;
            dgvTurnos.Columns[1].Visible = false;
            dgvTurnos.Columns[3].Visible = false;
            dgvTurnos.Columns[10].Visible = false;
            dgvTurnos.Columns[5].Visible = false;
        }
        
        private void Turnos_Load(object sender, EventArgs e)
        {

            gboxTurno.Enabled = false;
            cargarDgv();
            cargarCboPacientes();
            cargarCboEspecialidades();
        }

        public void cargarCboEspecialidades()
        {
            especialidadesNegocio espneg = new especialidadesNegocio();
            cboEspecialidad.DataSource = espneg.traerEspecialidades();
            cboEspecialidad.DisplayMember = "especialida";
            cboEspecialidad.ValueMember = "IDESPECIALIDAD";
        }

        public void cargarCboPacientes()
        {
            PacienteNegocio pacneg = new PacienteNegocio();
            cboPacientes.DataSource = pacneg.traerTodos();
            cboPacientes.DisplayMember = "Apellido";
            cboPacientes.ValueMember = "idpaciente";
        }

        private void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Especialidad a = (Especialidad)cboEspecialidad.SelectedItem;
            long b = a.Idespecialidad;

            med_X_espeNegocio espXmed = new med_X_espeNegocio();
            cboMedicos.DataSource = espXmed.traerEspeciXmedico(b);

            //medicosNegocio medNeg = new medicosNegocio();
            //cboMedicos.DataSource = medNeg.traerMedicosPorEspeciliadad(b);
            cboMedicos.DisplayMember = "apellido";
            cboMedicos.ValueMember = "Idmedico";


        }

        private void cboMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

            MedicoXespecil a = (MedicoXespecil)cboMedicos.SelectedItem;
            Int64 b = a.idmedico;
        

            medicosNegocio medNeg = new medicosNegocio();
            Medico c = medNeg.traerMedicosPorEspeciliadad(b);
            Int64 d = c.Hora.HEntrada;
            Int64 f = c.Hora.HSalida;
            turnosServicio turSer = new turnosServicio();
            cboHoraTurno.DataSource = turSer.traerlista(d, f);

            //    //cboHorarios.DataSource = medNeg.traerMedicosPorEspeciliadad(a.Idhorario);
            horarioServicio horSer = new horarioServicio();
            cboHorarios.DataSource = horSer.traerListaHorariosPorMedico(c.Idhorario);
            cboHorarios.DisplayMember = "turno";
           // cboHorarios.ValueMember = "IDHORARIO";


        }

        private void cboHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Medico a = (Medico)cboHorarios.SelectedItem;
            //Int64 b = a.Hora.HEntrada;
            //Int64 c = a.Hora.HSalida;
            //turnosServicio turSer = new turnosServicio();
            //cboHoraTurno.DataSource = turSer.traerlista(b, c);

        }


        private void cboHoraTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            turnosServicio turSer = new turnosServicio();
            Turno nuevo = new Turno();
            Especialidad a =(Especialidad) cboEspecialidad.SelectedItem;
            nuevo.idEspecialidades = a.Idespecialidad;
            Paciente b = (Paciente)cboPacientes.SelectedItem;
            nuevo.idpaciente = b.Idpaciente;
            MedicoXespecil  c = (MedicoXespecil )cboMedicos.SelectedItem;
            nuevo.idmedico = c.idmedico;
            nuevo.fechaTurno = Convert.ToDateTime(dtpFecha.Value.ToString());
            nuevo.horaTurno =Convert.ToInt64( cboHoraTurno.SelectedItem);
            nuevo.observaciones = txtObservaciones.Text.Trim();
            turSer.agregarTurno(nuevo);

            MessageBox.Show("turno agregado exitosamente...");
            cargarDgv();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea salir...", "cerrando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnsolicitarturno_Click(object sender, EventArgs e)
        {
            gboxTurno.Enabled = true;
            txtObservaciones.Clear();
        }

        private void BTNgbtCancelar_Click(object sender, EventArgs e)
        {
            txtObservaciones.Clear();
            gboxTurno.Enabled = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            gboxTurno.Enabled = false;
            txtObservaciones.Clear();
        }
    }
}
