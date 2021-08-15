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
    public partial class TutoInfo : Form
    {
        public TutoInfo()
        {
            InitializeComponent();
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            if (tbVer.PasswordChar == '*')
            {
                btOcultar.BringToFront();
                tbVer.PasswordChar = '\0';
            }
        }

        private void btOcultar_Click(object sender, EventArgs e)
        {
            if (tbVer.PasswordChar == '\0')
            {
                btVer.BringToFront();
                tbVer.PasswordChar = '*';
            }
        }
    }
}
