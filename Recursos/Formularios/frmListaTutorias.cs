using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmListaTutorias : Form
    {
        public frmListaTutorias()
        {
            InitializeComponent();
        }

        private void btX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btMax.Visible = false;
            btRestaurar.Visible = true;
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btRestaurar.Visible = false;
            btMax.Visible = true;
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
