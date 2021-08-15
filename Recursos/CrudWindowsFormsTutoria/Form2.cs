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
    public partial class AlumnoControl : Form
    {
        public AlumnoControl()
        {
            InitializeComponent();            
        }

        private void AlumnoControl_Load(object sender, EventArgs e)
        {
            Actualizar1();
        }
        private void Actualizar1()
        {
            dsTutoriaDBTableAdapters.AlumnoTableAdapter TA =
                new dsTutoriaDBTableAdapters.AlumnoTableAdapter();
            dsTutoriaDB.AlumnoDataTable DT = TA.GetAlumnoTable();
            dataGridView1.DataSource = DT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualizar1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AñadirAlumno frm = new AñadirAlumno();
            frm.ShowDialog();
            Actualizar1();
        }

        private string GetID()
        {
            try
            {
                return (
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );
            }
            catch
            {
                return null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID = GetID();
            if (ID != null)
            {
                AñadirAlumno frm = new AñadirAlumno(ID);
                frm.ShowDialog();
                Actualizar1();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ID = GetID();
            if (ID != null)
            {
                dsTutoriaDBTableAdapters.AlumnoTableAdapter TA =
                    new dsTutoriaDBTableAdapters.AlumnoTableAdapter();
                TA.EliminarAlumno(ID);
                Actualizar1();
            }
        }
    }
}
