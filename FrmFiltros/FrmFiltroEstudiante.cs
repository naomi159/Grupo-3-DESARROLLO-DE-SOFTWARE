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
    public partial class FrmFiltroEstudiante : Form
    {
        public FrmFiltroEstudiante()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmEstudiante Estudiante = Owner as FrmEstudiante;
            if (Estudiante.dgvEstudiante.RowCount > 0) //si no está vacio
            {
                Estudiante.dgvEstudiante.DataSource = null;
                Estudiante.dgvEstudiante.Rows.Clear();
            }
            string[] ValoresAtr = { tbCodigo.Text, tbNombres.Text, tbAP.Text, tbAM.Text, tbCarrera.Text, cbCondicion.Text };
            Estudiante.dgvEstudiante.DataSource = Estudiante.aEntidad.Filtrar(ValoresAtr);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            FrmEstudiante Estudiante = Owner as FrmEstudiante;
            Estudiante.ListarRegistros();
            tbCodigo.Text = "";
            tbNombres.Text = "";
            tbAP.Text = "";
            tbAM.Text = "";
            tbCarrera.Text = "";
            cbCondicion.Text = "";
        }
    }
}
