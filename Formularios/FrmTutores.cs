using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class FrmTutores : Form
    {
        public FrmTutores()
        {
            InitializeComponent();
        }

        private void FrmTutores_Load(object sender, EventArgs e)
        {
            //cEntidad Docente = new cDocente();
            cDocente Docente = new cDocente();

            //dgvTutores.DataSource = Docente.ListaGeneral();
            dgvTutores.DataSource = Docente.ListaTutor();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
