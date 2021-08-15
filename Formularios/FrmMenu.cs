using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private Form activoFrm;

        //Metodo para mostrar los formularios
        private void abrirFormularioHijo(Form hijo)
        {
            if (activoFrm != null)
            {
                activoFrm.Close();
            }
            activoFrm = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelFormHijo.Controls.Add(hijo);
            panelFormHijo.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmDocente());
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmEstudiante());
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmAsignacion());
        }

        private void btnTutorias_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmListaTutorias());
        }
    }
}
