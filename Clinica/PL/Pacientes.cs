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
    public partial class Pacientes : Form
    {

      
        private Paciente pacie;
        public Pacientes()
        {
            InitializeComponent();
        }

        public void cargarCmbLocal()
        {
            localidadNegocio locaNego = new localidadNegocio();
            cboLocalidad.DataSource = locaNego.traerLocalidades();
            cboLocalidad.DisplayMember = "localidades";
            cboLocalidad.ValueMember = "cp";
        }

        public void cargar()
        {
            PacienteNegocio pacNeg = new PacienteNegocio();
           
            dgvPacientes.DataSource = pacNeg.traerTodos();
            dgvPacientes.Columns[0].Visible = false;
            dgvPacientes.Columns[5].Visible = false;
            dgvPacientes.Columns[12].Visible = false;
        }
        

        private void Pacientes_Load(object sender, EventArgs e)
        {
            cboSexo.Items.Add("MASCULINO");
            cboSexo.Items.Add("FEMENINO");
            cboSexo.SelectedIndex = 0;
            cargarCmbLocal();
            gboxBuscador.Enabled = false;
            gboxAltaPaciente.Enabled = false;
            cboCampo.Items.Add("Apellido");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("DNI");
            cboCampo.SelectedIndex = 0;

            try
            {
                cargar();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            gboxAltaPaciente.Enabled = true;
            this.gboxAltaPaciente.Text = "ALTA PACIENTE";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" | txtApellido.Text == "" |txtDni.Text =="" |txtDireccion.Text=="" |txtTelParticular.Text=="" |txtTelPersonal.Text=="" |txtCorreo.Text=="")
            {
                MessageBox.Show("falta llenar campos");
                return;
            }
            else if (dtpFechaNac.Value >DateTime.Today)
            {
                MessageBox.Show("LA FECHA NO SE PUEDE SER MAYOR AL DIA DE HOY...");
            }
            else 

                try
            {

                PacienteNegocio pacNuev = new PacienteNegocio();
                    if (pacie!=null )
                    {
                    pacie.Nombre = txtNombre.Text.Trim();
                    pacie .Apellido = txtApellido.Text.Trim();
                    pacie.Dni = Convert.ToInt64(txtDni.Text.Trim());
                    pacie.Direccion = txtDireccion.Text.Trim();
                    Localidad a = (Localidad)cboLocalidad.SelectedItem;
                    pacie.Idlocalidad = a.Idlocalidad;
                    pacie.Celular = Convert.ToInt64(txtTelPersonal.Text.Trim());
                    pacie.Telefono = Convert.ToInt64(txtTelParticular.Text.Trim());
                    pacie.Email = txtCorreo.Text.Trim();
                    pacie.FechaNac = Convert.ToDateTime(dtpFechaNac.Value.ToString());
                    pacie.Sexo = Convert.ToString(cboSexo.SelectedItem);
                    pacNuev.modificarPaciente(pacie);
                    
                    MessageBox.Show("Paciente modificado...");
                    cargar();

                }
                else
                {
                    Paciente nuevo = new Paciente();
                    nuevo.Nombre = txtNombre.Text.Trim();
                    nuevo.Apellido = txtApellido.Text.Trim();
                    nuevo.Dni =Convert.ToInt64( txtDni.Text.Trim());
                    nuevo.Direccion = txtDireccion.Text.Trim();
                    Localidad a=(Localidad) cboLocalidad.SelectedItem;
                    nuevo.Idlocalidad = a.Idlocalidad;
                    nuevo.Celular =Convert.ToInt64( txtTelPersonal.Text.Trim());
                    nuevo.Telefono  = Convert.ToInt64(txtTelParticular.Text.Trim());
                    nuevo.Email = txtCorreo.Text.Trim();
                    nuevo.FechaNac =Convert.ToDateTime( dtpFechaNac.Value.ToString());
                    nuevo.Sexo =Convert.ToString( cboSexo.SelectedItem);

                    pacNuev.agregarPaciente(nuevo);
                    MessageBox.Show("Paciente agregado exitosamente...");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }
        
        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            PacienteNegocio elimpac = new PacienteNegocio() ;
            Paciente pac = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;
            if(MessageBox.Show ("desea eliminar","eliminar?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes )
            {
                elimpac.eliminarPaciente(pac);
                MessageBox.Show("eliminado!!");
                cargar();
            }
            else
            {
                return ;
            }
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            gboxAltaPaciente.Enabled = true;
            localidadNegocio locneg = new localidadNegocio();
            PacienteNegocio pacNeg = new PacienteNegocio();

            pacie = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;
            this.gboxAltaPaciente.Text = "MODIFICANDO....";
            txtNombre.Text = pacie.Nombre;
            txtApellido.Text = pacie.Apellido;
            txtDni.Text = Convert.ToString( pacie.Dni);
            txtDireccion.Text = pacie.Direccion;
            txtTelPersonal.Text =Convert.ToString( pacie.Celular );
            txtTelParticular.Text = Convert.ToString(pacie.Telefono );
            txtCorreo.Text = pacie.Email;
            cboLocalidad.SelectedIndex  = Convert.ToInt32(pacie.Idlocalidad)-1;
            cboSexo.SelectedItem = pacie.Sexo;
            dtpFechaNac.Value = pacie.FechaNac;

           

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCampo.SelectedItem.ToString() == "DNI")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.SelectedIndex = 0;
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Contiene");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.SelectedIndex = 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PacienteNegocio buscarPac = new PacienteNegocio();
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = buscarPac.Buscar(cboCampo.SelectedItem.ToString(), cboCriterio.SelectedItem.ToString(),txtClave.Text.Trim());
            dgvPacientes.Columns[0].Visible = false;
            dgvPacientes.Columns[5].Visible = false;
            dgvPacientes.Columns[12].Visible = false;


        }

        private void btnSalirPaciente_Click(object sender, EventArgs e)
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

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            gboxBuscador.Enabled = true;
            gboxAltaPaciente.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtDireccion.Clear();
            txtTelParticular.Clear();
            txtTelPersonal.Clear();
            txtCorreo.Clear();
            dtpFechaNac.Value = DateTime.Today;
        }

        private void btnCancelarBuscador_Click(object sender, EventArgs e)
        {
            gboxBuscador.Enabled = false;
            txtClave.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.gboxAltaPaciente.Text = "ALTA PACIENTE";
            limpiar();
            gboxAltaPaciente.Enabled = false;
        }

        private void btnMenuAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
