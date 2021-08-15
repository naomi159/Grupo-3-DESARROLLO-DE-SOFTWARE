using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudWindowsFormsTutoria
{
    public partial class TutoríaMAIN : Form
    {
        public TutoríaMAIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnoControl frm = new AlumnoControl();
            frm.ShowDialog();
        }

        private void TutoríaMAIN_Load(object sender, EventArgs e)
        {

        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TutorControl frm = new TutorControl();
            frm.ShowDialog();
        }
    }
}
