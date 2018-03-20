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
    public partial class Localidades : Form
    {
        private Localidad locali;
        
        public Localidades()
        {
            InitializeComponent();
        }


        public Localidades (Localidad local)
        {
            InitializeComponent();
            locali = local;
           
        }

        public void limpiar()
        {
            txtCodigoPostal.Clear();
            txtLocalidad.Clear();
        }

        private void Localidades_Load(object sender, EventArgs e)
        {
            cboCampo.Items.Add("CODIGO POSTAL");
            cboCampo.Items.Add("NOMBRE");
            cboCampo.SelectedIndex = 0;
            cargar();
            gboxAltaLocalidad.Enabled = false;
            GboxBuscador.Enabled = false;
        }
        public void cargar()
        {
            localidadNegocio loca = new localidadNegocio();
            dgvListadoLoca.DataSource = loca.traerLocalidades();
            dgvListadoLoca.Columns[0].Visible = false;
            dgvListadoLoca.Columns[3].Visible = false;
        }

        private void btnConfirmarCarga_Click(object sender, EventArgs e)
        {
         
            if (txtLocalidad.Text == "" | txtCodigoPostal.Text == "")
            {
                MessageBox.Show("falta llenar campos");
                return;
            }
            else
                try
                {

                    localidadNegocio locneg = new localidadNegocio();


                    if (locali != null)


                    {
                        locali.Localidades = txtLocalidad.Text.Trim();
                        locali.Cp = Convert.ToInt64(txtCodigoPostal.Text.Trim());

                        locneg.modificarLocalidad(locali);
                        MessageBox.Show("localidad modificada exitosamente...");
                        cargar();
                        limpiar();
                    }
                    else
                    {

                        Localidad nuevaLoc = new Localidad();
                        nuevaLoc.Localidades = txtLocalidad.Text.Trim();
                        nuevaLoc.Cp = Convert.ToInt64(txtCodigoPostal.Text.Trim());


                        locneg.agregarLocalidad(nuevaLoc);

                        MessageBox.Show("localidad agregada exitosamente...");
                        cargar();
                        limpiar();
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

        private void btnEliminarLocalidad_Click(object sender, EventArgs e)
        {
            gboxAltaLocalidad.Enabled = false;
            GboxBuscador.Enabled = false;
            localidadNegocio locneg = new localidadNegocio();
            Localidad loc = (Localidad)dgvListadoLoca.CurrentRow.DataBoundItem;

            if (MessageBox.Show("desear eliminar?", "atencion!!", MessageBoxButtons.YesNo,MessageBoxIcon.Question )==DialogResult.Yes )
            {
                locneg.eliminarLocalidad(loc);
                MessageBox.Show("Eliminado correctamente");
                cargar();
            }
            else
            {
                return;
            }

        }

        private void btnModificarLocalidad_Click(object sender, EventArgs e)
        {
            if (txtLocalidad.Text == "" | txtCodigoPostal.Text == "")
            {
                MessageBox.Show("falta llenar campos");
                return;
            }
            gboxAltaLocalidad.Enabled = true;
            GboxBuscador.Enabled = false;
            localidadNegocio locneg = new localidadNegocio();
            locali =(Localidad ) dgvListadoLoca.CurrentRow.DataBoundItem;
            
            this.gboxAltaLocalidad.Text = "modificando...";
            txtLocalidad.Text = locali.Localidades;
            txtCodigoPostal.Text  = Convert.ToString (locali.Cp);

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCampo.SelectedItem.ToString() == "CODIGO POSTAL")
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
             if (txtClave.Text  == "" )
            {
                MessageBox.Show("falta llenar la clave de busqueda...");
                return;
            }
            localidadNegocio loca = new localidadNegocio();
            dgvListadoLoca.DataSource = null;
            dgvListadoLoca.DataSource = loca.buscarLocalidad(cboCampo.SelectedItem.ToString(), cboCriterio.SelectedItem.ToString(), txtClave.Text.Trim());
            dgvListadoLoca.Columns[0].Visible = false;
            dgvListadoLoca.Columns[3].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void btnAgregarLocalidad_Click(object sender, EventArgs e)
        {
            gboxAltaLocalidad.Enabled = true;
            GboxBuscador.Enabled = false;
        }

        private void btnBuscarLocalidad_Click(object sender, EventArgs e)
        {
            gboxAltaLocalidad.Enabled = false;
            GboxBuscador.Enabled = true;
        }

      
        private void btnCancelarCargar_Click(object sender, EventArgs e)
        {
            limpiar();
            gboxAltaLocalidad.Enabled = false;
        }

        private void btnCancelarBuscar_Click(object sender, EventArgs e)
        {
            txtClave.Clear();
            GboxBuscador.Enabled = false;
        }
    }
}
