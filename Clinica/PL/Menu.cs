using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {

            Turnos turno = new Turnos();
            turno.MdiParent = this;
            turno.Show();

          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea cerrar", "cerrando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                      this.Close();
            }
            else
            {
                return;
            }


            

        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            Medicos medico = new Medicos();
            medico.MdiParent = this;
            medico.Show();
              
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Pacientes paciente = new Pacientes();
            paciente.MdiParent = this;
            paciente.Show();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades especialidad = new Especialidades();
            especialidad.MdiParent = this;
            especialidad.Show();

        }

        private void btnLocalidades_Click(object sender, EventArgs e)
        {
            Localidades localidad = new Localidades();
            localidad.MdiParent = this;
            localidad.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Frm_login login = new Frm_login();
            login.ShowDialog();
            if (login.Nivel == "ADMIN")
            {
               
            }
            else if (login.Nivel == "RECEPCIONISTA")
            {
                btnEspecialidades.Enabled = false;
                btnMedicos.Enabled = false;
                btnLocalidades.Enabled = false;
            } 
            else
            {
                MessageBox.Show("CERRANDO...");
                this.Close();
            }
        }

        private void OTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
