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
    public partial class TurnosMedicos : Form
    {

        private IList<Turno> listaTurnosMedicos;
        public TurnosMedicos()
        {
            InitializeComponent();
        }

        public TurnosMedicos (IList<Turno> tur)
        {
            InitializeComponent();
            listaTurnosMedicos= tur ;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void TurnosMedicos_Load(object sender, EventArgs e)
        {
            DGBTurnosMedicos.DataSource = listaTurnosMedicos;
            DGBTurnosMedicos.Columns[0].Visible = false;
            DGBTurnosMedicos.Columns[1].Visible = false;
            DGBTurnosMedicos.Columns[3].Visible = false;
            DGBTurnosMedicos.Columns[10].Visible = false;
            DGBTurnosMedicos.Columns[5].Visible = false;
        }
    }
}
