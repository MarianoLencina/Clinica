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
    public partial class Especialidades : Form
    {
        private Especialidad espe;
        public Especialidades()
        {
            InitializeComponent();
        }

        public void cargarMedEpeciliastis()
        {
            medicosNegocio medNeg = new medicosNegocio();
            //dgvListadoMedico.DataSource=medNeg
        }

        public void cargarMedXesp()
        {
            med_X_espeNegocio medXesp = new med_X_espeNegocio();
            dgvListadoMedico.DataSource = medXesp.TraerTodoMedXespe();
            dgvListadoMedico.Columns[0].Visible = false;
            dgvListadoMedico.Columns[2].Visible = false;
            dgvListadoMedico.Columns[4].Visible = false;
            dgvListadoMedico.Columns[7].Visible = false;
            dgvListadoMedico.Columns[8].Visible = false;


        }

        public void cargar()
        {
            especialidadesNegocio espeNeg = new especialidadesNegocio ();
            dgvEspecialidades.DataSource = espeNeg.traerEspecialidades();
            dgvEspecialidades.Columns[0].Visible = false;
            dgvEspecialidades.Columns[2].Visible = false;
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            gboxAltaEspecialidad.Enabled = false;
            gboxAgregarEspecialidadesAlMedico.Enabled = false;
            cargar();
            cargarMedXesp();
            gboxAgregarEspecialidadesAlMedico.Enabled = false;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtEspecialidad.Text == "")
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL NOMBRE DE LA ESPECIALIDAD...");
                return;
            }
            
            especialidadesNegocio nueEspe = new especialidadesNegocio();
            Especialidad espe = new Especialidad();
            espe.Especialida = txtEspecialidad.Text.Trim();
           
            nueEspe.agregarEspecialidad(espe);
            MessageBox.Show("Especialidad agregada exitosamente...");
            txtEspecialidad.Clear();
            cargar();
            
        }

        private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        {
            especialidadesNegocio negEspe = new especialidadesNegocio();
            Especialidad espe =(Especialidad) dgvEspecialidades.CurrentRow.DataBoundItem;
            if(MessageBox.Show("desea eliminar la especialidad??","eliminando...",MessageBoxButtons.YesNo,MessageBoxIcon.Information) ==DialogResult.Yes )
            {
                negEspe.eliminarEspecialidad(espe);
                MessageBox.Show("eliminado....");
                cargar();
            }

        }

        private void btnVerEspecialidades_Click(object sender, EventArgs e)
        {
            med_X_espeNegocio medXesp = new med_X_espeNegocio();
            MedicoXespecil medX = (MedicoXespecil)dgvListadoMedico.CurrentRow.DataBoundItem;
          dgvListadoMedico.DataSource=medXesp.TraerSoloMedXespe(medX);
        }

        private void btnVerTodasEspecialidadesMedic_Click(object sender, EventArgs e)
        {
            cargarMedXesp();
        }

        private void btnAgregarEspecialidadAlMedico_Click(object sender, EventArgs e)
        {
            gboxAgregarEspecialidadesAlMedico.Enabled = true;
            NUMENTRADA.Enabled = false;
            NumericUpDown2.Enabled = false;
           
            medicosNegocio medNeg = new medicosNegocio();
         
            cboMedicos.DataSource = medNeg.traerMedicos();
            cboMedicos.DisplayMember = "apellido";
            cboMedicos.ValueMember = "idmedico";

            especialidadesNegocio espNeg = new especialidadesNegocio();
       
            CBOESPECIALIDADES.DataSource = espNeg.traerEspecialidades();
            CBOESPECIALIDADES.DisplayMember = "especialida";
            CBOESPECIALIDADES.ValueMember = "idespecialidad";

        }

        private void btnCancelarAltaEspecialidadAlMedico_Click(object sender, EventArgs e)
        {
            gboxAgregarEspecialidadesAlMedico.Enabled = false;
            NUMENTRADA.Value = 0;
            NumericUpDown2.Value = 0;


        }

        private void btnConfirmarAltaEspecialidadAlMedico_Click(object sender, EventArgs e)
        {
            med_X_espeNegocio medXespec = new med_X_espeNegocio();
            MedicoXespecil nue = new MedicoXespecil();
            Medico a =(Medico) cboMedicos.SelectedItem;
            nue.idmedico = a.Idmedico;
            Especialidad b = (Especialidad)CBOESPECIALIDADES.SelectedItem;
            nue.idespecialidad = b.Idespecialidad;
            nue.entrada =Convert.ToInt64( NUMENTRADA.Value);
            nue.salida = Convert.ToInt64(NumericUpDown2.Value);
            medXespec.agregarMedicoXespecialidad(nue);
            MessageBox.Show("Especialidad agregada al medico exitosamente...");
            cargarMedXesp();
            gboxAgregarEspecialidadesAlMedico.Enabled = false;
            NUMENTRADA.Value=0;
            NumericUpDown2.Value=0; 


        }

        private void BTNeliminarEspecialidadAlMedico_Click(object sender, EventArgs e)
        {
            med_X_espeNegocio medNeg = new med_X_espeNegocio();
            MedicoXespecil medesp = (MedicoXespecil)dgvListadoMedico.CurrentRow.DataBoundItem;
            if (MessageBox.Show("desea eliminar la especialidad del medico??", "eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                medNeg.eliminarEspecialidadXmedico(medesp);
                MessageBox.Show("eliminado....");
                cargarMedXesp();
            }
        }

        private void btnSalirEspecialidad_Click(object sender, EventArgs e)
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

        private void cboMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medico a = (Medico)cboMedicos.SelectedItem;
            Int64 b = a.Idhorario;
            Horarios  aux = new Horarios ();
            horarioServicio  horSer = new horarioServicio ();
            aux = horSer.HorariostraerHorariosPorMedico (b);
            NUMENTRADA.Value  = aux.HEntrada;
            NumericUpDown2.Value = aux.HSalida;
            lblDias.Text = aux.Turno.Trim();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            gboxAltaEspecialidad.Enabled = true;
            gboxAgregarEspecialidadesAlMedico.Enabled = false;
            txtEspecialidad.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEspecialidad.Clear();
            gboxAltaEspecialidad.Enabled = false;
        }

        private void btnMenuAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("solo se permiten letras");
            }
           
            
        }
    }
}
