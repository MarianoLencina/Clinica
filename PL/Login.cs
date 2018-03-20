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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }
        public string Nivel;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuariosService usuSer = new usuariosService();

            if (RDBSI.Checked == true)
            {
                turnosServicio turSer = new turnosServicio();
                Usuario usua = new Usuario();
                usua.User = Txtusuario.Text;
                usua.Contrasenia = TxtContrasenia.Text;
                                
                IList<Turno> listaTurno = turSer.traerTurnosPorMedicos(Txtusuario.Text);
                TurnosMedicos FormTurn = new TurnosMedicos(listaTurno );
                FormTurn.Show();
                
               
                              
            }
            else
            {



                try
                {

                    Usuario usua = new Usuario();
                    usua.User = Txtusuario.Text;
                    usua.Contrasenia = TxtContrasenia.Text;
                    if (usuSer.Login(usua) == "ADMIN")
                    {
                        this.DialogResult = DialogResult.Yes;
                        MessageBox.Show("BIENVENIDO ADMIN");
                        Nivel = usua.User;
                    }
                    else if (usuSer.Login(usua) == "RECEPCIONISTA")
                    {
                        this.DialogResult = DialogResult.No;
                        MessageBox.Show("BIENVENIDA RECEPCIONISTA");
                        Nivel = usua.User;
                        return;
                    }
                    else
                    {
                        Txtusuario.Clear();
                        TxtContrasenia.Clear();
                        MessageBox.Show("ACCESO DENEGADO");
                        return;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RDBNO_CheckedChanged(object sender, EventArgs e)
        {
            Lblusuario.Text = "USUARIO:";
        }

        private void RDBSI_CheckedChanged(object sender, EventArgs e)
        {
            Lblusuario.Text = "APELLIDO:";
        }
    }
}
