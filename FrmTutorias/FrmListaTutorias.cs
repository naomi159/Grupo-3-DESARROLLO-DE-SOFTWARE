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
    public partial class frmListaTutorias : Form
    {
        private cEntidad aFichaTutoria = new cFichaTutoria();
        public frmListaTutorias()
        {
            InitializeComponent();
        }

        private void btX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void btMax_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //    btMax.Visible = false;
        //    btRestaurar.Visible = true;
        //}

        //private void btRestaurar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Normal;
        //    btRestaurar.Visible = false;
        //    btMax.Visible = true;
        //}

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string IDTutoria, CodDocente, CodEstudiante, Semestre, Fecha, Descripcion;
            if (dgvListaTutoria.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaTutoria.SelectedRows)
                {
                    //Obtener datos de las filas selecionadas
                    IDTutoria = row.Cells[0].Value.ToString();
                    CodDocente = row.Cells[1].Value.ToString();
                    CodEstudiante = row.Cells[2].Value.ToString();
                    Semestre = row.Cells[3].Value.ToString();
                    Fecha = row.Cells[4].Value.ToString();
                    Descripcion = row.Cells[5].Value.ToString();

                    string[] ValuesAtr = { IDTutoria, CodDocente, CodEstudiante, Semestre, Fecha, Descripcion };
                    //Abrir Formulario ficha tutoria en modo vista
                    FrmTutorias.FrmFichaTutoria Ficha = new FrmTutorias.FrmFichaTutoria(ValuesAtr, true);
                    Ficha.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
                return;
            }


            
        }

        private void lblTituloFormTurorias_Click(object sender, EventArgs e)
        {

        }

        private void frmListaTutorias_Load(object sender, EventArgs e)
        {
            dgvListaTutoria.DataSource = aFichaTutoria.ListaGeneral();
        }
    }
}
