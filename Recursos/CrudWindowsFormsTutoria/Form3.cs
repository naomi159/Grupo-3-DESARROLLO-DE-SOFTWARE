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
    public partial class AñadirAlumno : Form
    {
        private string Cod_Alumno;
        public AñadirAlumno(string ID = null)
        {
            InitializeComponent();
            this.Cod_Alumno = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsTutoriaDBTableAdapters.AlumnoTableAdapter TA =
                new dsTutoriaDBTableAdapters.AlumnoTableAdapter();
            if (Cod_Alumno == null)
            {
                TA.AñadirAlumno(txtCODIGO.Text.Trim(), txtNombre.Text.Trim(), txtAP.Text.Trim(), txtAM.Text.Trim());
            }
            else
            {
                TA.EditarAlumno(txtNombre.Text.Trim(), txtAP.Text.Trim(), txtAM.Text.Trim(), Cod_Alumno);
            }
            this.Close();
        }

        private void AñadirAlumno_Load(object sender, EventArgs e)
        {
            if (Cod_Alumno != null)
            {
                dsTutoriaDBTableAdapters.AlumnoTableAdapter TA =
                    new dsTutoriaDBTableAdapters.AlumnoTableAdapter();
                dsTutoriaDB.AlumnoDataTable DT = TA.GetCodigoAlumnoID(Cod_Alumno);
                dsTutoriaDB.AlumnoRow row = (dsTutoriaDB.AlumnoRow)DT.Rows[0];
                txtNombre.Text = row.Nombres;
                txtAP.Text = row.Paterno;
                txtAM.Text = row.Materno;
            }
        }
    }
}
