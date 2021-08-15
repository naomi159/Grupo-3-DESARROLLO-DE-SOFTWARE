using System;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class FrmAsignacion : Form
    {
        //-----------------------------------------------------------
        private cEntidad aEstudiante = new cEstudiante();

        private cEntidad aTutoria = new cTutoria();

        //----------------------------------------------------


        private void FrmAsignacion_Load(object sender, EventArgs e)
        {

        }

        //private SQLConexion Conexion;

        public FrmAsignacion()
        {
            InitializeComponent();
            dgvEstudiantes.DataSource = aEstudiante.ListaGeneral();
            //Conexion = new SQLConexion();
        }

        private void BtnPasar2_Click_1(object sender, EventArgs e)
        {
            string Cod, Nombres, AP, AM, Carrera, Condicion;
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvEstudiantes.SelectedRows)
                {
                    //Obtener datos de las filas selecionadas
                    Cod = row.Cells[0].Value.ToString();
                    Nombres = row.Cells[1].Value.ToString();
                    AP = row.Cells[2].Value.ToString();
                    AM = row.Cells[3].Value.ToString();
                    Carrera = row.Cells[4].Value.ToString();
                    Condicion = row.Cells[5].Value.ToString();

                    int index = dgvTutorias.Rows.Add();
                    dgvTutorias.Rows[index].Cells[0].Value = Cod;
                    dgvTutorias.Rows[index].Cells[1].Value = Nombres;
                    dgvTutorias.Rows[index].Cells[2].Value = AP;
                    dgvTutorias.Rows[index].Cells[3].Value = AM;
                    dgvTutorias.Rows[index].Cells[4].Value = Carrera;
                    dgvTutorias.Rows[index].Cells[5].Value = Condicion;
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila de estudiantes para asignar","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                string CodEstudiante,
                   CodDocente = txt_CodDocente.Text,
                   Semestre = txt_Semestre.Text,
                   Fecha = txt_Fecha.Text;

                if(txt_CodDocente.Text!="" && txt_Semestre.Text!="" && txt_Fecha.Text!="")
                {
                    DialogResult dialogoAsignar = MessageBox.Show("Se asignaran los alumnos seleccionados al Tutor\n¿Desea Continuar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogoAsignar == DialogResult.OK)
                    {
                        for (int i = 0; i < dgvTutorias.Rows.Count; i++)
                        {
                            CodEstudiante = dgvTutorias.Rows[i].Cells[0].Value.ToString();
                            string[] atributos = { CodDocente, CodEstudiante, Semestre, Fecha };
                            aTutoria.Insertar(atributos);
                            MessageBox.Show("Los alumnos fueron asignados con éxito", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe de llenar todos los campos Superiores\n(CodDocente,Semestre y Fecha)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
            catch (Exception E) 
            {
                MessageBox.Show(E.ToString(),"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }
            
        }

        private void btnVerTutores_Click(object sender, EventArgs e)
        {
            FrmTutores ListaTutores = new FrmTutores();
           
            ListaTutores.Show();
            

        }
    }
}
