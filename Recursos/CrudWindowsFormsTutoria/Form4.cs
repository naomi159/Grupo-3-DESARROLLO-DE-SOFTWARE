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
    public partial class TutorControl : Form
    {
        public TutorControl()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Actualizar2();
        }

        public void Actualizar2()
        {
            dsTutoriaDBTableAdapters.TutorTableAdapter TA =
                new dsTutoriaDBTableAdapters.TutorTableAdapter();
            dsTutoriaDB.TutorDataTable DT = TA.GetTutorTable();
            dataGridView1.DataSource = DT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualizar2();
        }
    }
}
