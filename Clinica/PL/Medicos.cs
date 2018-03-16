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
    public partial class Medicos : Form
    {
        private Medico medi;
        public Medicos()
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

        public void cargarCmbHorarios()
        {
           
            horarioServicio horaServ = new horarioServicio  ();
            CBOHORARIOS.DataSource = horaServ.traerHorarios();
            CBOHORARIOS.DisplayMember = "turno";
            CBOHORARIOS.ValueMember = "idhorarios";
            
        }
        public void cargar()
        {
            medicosNegocio medNeg = new medicosNegocio();
            dgvMedicos.DataSource = medNeg.traerMedicos();
            dgvMedicos.Columns[0].Visible = false;
            dgvMedicos.Columns[1].Visible = false;
            dgvMedicos.Columns[15].Visible = false;
            dgvMedicos.Columns[2].Visible = false;
            dgvMedicos.Columns[3].Visible = false;
            dgvMedicos.Columns[8].Visible = false;
            ////dgvMedicos.Columns[1].Visible = false;
        }

        private void Medicos_Load(object sender, EventArgs e)
        {


            cboCampo.Items.Add("DNI");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Apellido");
            cboSexo.Items.Add("MASCULINO");
            cboSexo.Items.Add("FEMENINO");
            cboSexo.SelectedIndex = 0;
            cboCampo.SelectedIndex = 0;
            cargarCmbHorarios();
            cargarCmbLocal();
            cargar();
            GboxAltaMedico.Enabled = false;
            GboxBuscador.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" | txtApellido.Text == "" | txtDni.Text == "" | txtDireccion.Text == "" | txtTelParticular.Text == "" | txtTelPersonal.Text == "" | txtCorreo.Text == "")
            {
                MessageBox.Show("falta llenar campos");
                return;
            }
            else if (dtpFechaNac.Value > DateTime.Today)
            {
                MessageBox.Show("LA FECHA NO SE PUEDE SER MAYOR AL DIA DE HOY...");
                return;
            }
            

                medicosNegocio medNeg = new medicosNegocio();
            if (medi != null)
            {
                try
                {


                    Horarios b = (Horarios)CBOHORARIOS.SelectedItem;
                    medi.Idhorario = b.IdHorarios;
                    medi.Nombre = txtNombre.Text.Trim();
                    medi.Apellido = txtApellido.Text.Trim();
                    medi.Dni = Convert.ToInt64(txtDni.Text.Trim());
                    medi.Direccion = txtDireccion.Text.Trim();
                    Localidad a = (Localidad)cboLocalidad.SelectedItem;
                    medi.Idlocalidad = a.Idlocalidad;
                    medi.Celular = Convert.ToInt64(txtTelPersonal.Text.Trim());
                    medi.Telefono = Convert.ToInt64(txtTelParticular.Text.Trim());
                    medi.Email = txtCorreo.Text.Trim();
                    medi.FechaNac = Convert.ToDateTime(dtpFechaNac.Value.ToString());
                    medi.Sexo = Convert.ToString(cboSexo.SelectedItem);
                    medNeg.modificarMedico(medi);


                    MessageBox.Show("Paciente modificado...");
                    cargar();
                    limpiar();

                 }
                catch (Exception ex)
                {
                    throw ex;
                }


                }
            else
            {


                    Medico nuevo = new Medico();
                    Horarios b = (Horarios)CBOHORARIOS.SelectedItem;
                    nuevo.Idhorario = b.IdHorarios;
                    nuevo.Nombre = txtNombre.Text.Trim();
                    nuevo.Apellido = txtApellido.Text.Trim();
                    nuevo.Dni = Convert.ToInt64(txtDni.Text.Trim());
                    nuevo.Direccion = txtDireccion.Text.Trim();
                    Localidad a = (Localidad)cboLocalidad.SelectedItem;
                    nuevo.Idlocalidad = a.Idlocalidad;
                    nuevo.Celular = Convert.ToInt64(txtTelPersonal.Text.Trim());
                    nuevo.Telefono = Convert.ToInt64(txtTelParticular.Text.Trim());
                    nuevo.Email = txtCorreo.Text.Trim();
                    nuevo.FechaNac = Convert.ToDateTime(dtpFechaNac.Value.ToString());
                    nuevo.Sexo = Convert.ToString(cboSexo.SelectedItem);
                    medNeg.agregarMedico(nuevo);

                    MessageBox.Show("medico agregado exitosamente...");
                    cargar();
                    limpiar();
                                
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            medicosNegocio eliMedico = new medicosNegocio();
            Medico med = (Medico)dgvMedicos.CurrentRow.DataBoundItem;

            if (MessageBox.Show("desea eliminar", "eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                eliMedico.eliminarMedico(med);
                MessageBox.Show("eliminado!!");
                cargar();
            }
            else
            {
                return;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            GboxAltaMedico.Enabled = true;
            medi = (Medico)dgvMedicos.CurrentRow.DataBoundItem;
            this.GboxAltaMedico.Text = "MODIFICANDO....";
            CBOHORARIOS.SelectedIndex = Convert.ToInt32(medi.Idhorario) - 1;
            txtNombre.Text = medi.Nombre;
            txtApellido.Text = medi.Apellido;
            txtDni.Text = Convert.ToString(medi.Dni);
            txtDireccion.Text = medi.Direccion;
            txtTelPersonal.Text = Convert.ToString(medi.Celular);
            txtTelParticular.Text = Convert.ToString(medi.Telefono);
            txtCorreo.Text = medi.Email;
            cboLocalidad.SelectedIndex = Convert.ToInt32(medi.Idlocalidad) - 1;
            cboSexo.SelectedItem = medi.Sexo;
            dtpFechaNac.Value = medi.FechaNac;

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCampo.SelectedItem.ToString()=="DNI")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.SelectedIndex = 0;
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Contiene...");
                cboCriterio.Items.Add("Termina...");
                cboCriterio.SelectedIndex = 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                MessageBox.Show("falta escribir la clave de busqueda...");
                return;
            }
            else
            {
                medicosNegocio medNeg = new medicosNegocio();
                dgvMedicos.DataSource = null;
                dgvMedicos.DataSource = medNeg.buscarMedico(cboCampo.SelectedItem.ToString(), cboCriterio.SelectedItem.ToString(), txtClave.Text.Trim());
                dgvMedicos.Columns[0].Visible = false;
                dgvMedicos.Columns[1].Visible = false;
                dgvMedicos.Columns[15].Visible = false;
                dgvMedicos.Columns[2].Visible = false;
                dgvMedicos.Columns[3].Visible = false;
                dgvMedicos.Columns[8].Visible = false;
            }
            }

        private void btnVerEspecialidades_Click(object sender, EventArgs e)
        {


           
        }

        private void BTNverHorarios_Click(object sender, EventArgs e)
        {
            
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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            GboxAltaMedico.Enabled = true;
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

        private void BTNbuscarMedico_Click(object sender, EventArgs e)
        {
            GboxAltaMedico.Enabled = false;
            limpiar();
            GboxBuscador.Enabled = true;
            txtClave.Clear();
        }

        private void btnCancelarBuscar_Click(object sender, EventArgs e)
        {
            GboxBuscador.Enabled = false;
            txtClave.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            GboxAltaMedico.Enabled = false;

        }
    }
}
