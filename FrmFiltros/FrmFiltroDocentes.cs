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
    public partial class FrmFiltroDocentes : Form
    {
        public FrmFiltroDocentes()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmDocente Docente = Owner as FrmDocente;
            if (Docente.DgvDocente.RowCount > 0) //si no está vacio
            {
                Docente.DgvDocente.DataSource = null;
                Docente.DgvDocente.Rows.Clear();
            }
            string[] ValoresAtr = { tbCodigo.Text, tbNombre.Text, tbAP.Text, tbAM.Text, tbClase.Text, tbCategoria.Text, tbRegimen.Text, tbCarrera.Text };
            Docente.DgvDocente.DataSource = Docente.aEntidad.Filtrar(ValoresAtr);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            FrmDocente Docente = Owner as FrmDocente;
            Docente.ListarRegistros();
            tbCodigo.Text = ""; 
            tbNombre.Text = ""; 
            tbAP.Text = ""; 
            tbAM.Text = ""; 
            tbClase.Text = ""; 
            tbCategoria.Text = ""; 
            tbRegimen.Text = ""; 
            tbCarrera.Text = "";
        }
    }
}
