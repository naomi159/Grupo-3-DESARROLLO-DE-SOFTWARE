using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios.FrmTutorias
{
    public partial class FrmFichaTutoria : Form
    {
        private string[] ValuesAtr;
        private string Key = "";
        private cEntidad Estudiante = new cEstudiante();
        private cEntidad Docente = new cDocente();
        public FrmFichaTutoria(string[] Values, bool ModoVista)
        {//ModoVista: (true)Si el formulario es solo vista o (false)para guardar valores
            if (ModoVista)
            {
                InitializeComponent();
                ValuesAtr = Values;
                btnGuardar.Visible = false;
            }
            else
            {
                InitializeComponent();
                ValuesAtr = Values;
                btnGuardar.Visible = true;
                tbCodigo.ReadOnly = false;
                tbFecha.ReadOnly = false;
                tbDescripcion.ReadOnly = false;
            }
            
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmFichaTutoria_Load(object sender, EventArgs e)
        {

            //Posiciones: [IDTutoria, CodDocente, CodEstudiante, Semestre, Fecha, Descripcion];
            tbCodigo.Text = ValuesAtr[2];
            tbSemestre.Text = ValuesAtr[3];
            tbFecha.Text = ValuesAtr[4].Substring(0,10);
            tbDescripcion.Text = ValuesAtr[5];

            //Obtener Registro con los datos del estudiante
            DataRow RegistroEst = Estudiante.RecuperarRegistro(new  string[] { tbCodigo.Text });

            //Mostrar datos del estudiantes
            tbNombre.Text = RegistroEst[1].ToString();
            tbAP.Text = RegistroEst[2].ToString();
            tbAM.Text = RegistroEst[3].ToString();
            tbCarrera.Text = RegistroEst[4].ToString();
            tbCondicion.Text = RegistroEst[5].ToString();

            //Obtener Registro con los datos del docente
            DataRow RegistroTutor = Docente.RecuperarRegistro(new string[] {ValuesAtr[1] });

            //Mostrar datos del docente
            tbCodigoTutor.Text = ValuesAtr[1];
            tbNombreTutor.Text = RegistroTutor[1].ToString();
            tbAPTutor.Text = RegistroTutor[2].ToString();
            tbAMTutor.Text = RegistroTutor[3].ToString();
        }


        private void btnVerClave_Click(object sender, EventArgs e)
        {
            tbClave.PasswordChar = '\0';
            btOcultar.BringToFront();
        }

        private void btOcultar_Click(object sender, EventArgs e)
        {
            tbClave.PasswordChar = '*';
            btnVerClave.BringToFront();
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            if(btVer.Text == "Ver")
            {
                Key = tbClave.Text;
                //Desencriptar descripcion a través de la clave
                string Descripcion = cCriptografia.DesencriptarRSA(tbDescripcion.Text, Key );
                if (Descripcion != null)
                {
                    MessageBox.Show("Clave correcta.");
                    btVer.Text = "Ocultar";
                    tbDescripcion.Text = Descripcion; //
                    tbClave.Text = ""; //Limpiar textbox
                }
                else
                {
                    MessageBox.Show("Clave incorrecta.");            
                }
            }
            else //btVer.Text == "Ocultar"
            {
                btVer.Text = "Ver"; //Cambiar texto del boton
                //Encriptar descripcion
                tbDescripcion.Text = cCriptografia.EncriptarRSA(tbDescripcion.Text, Key);
                Key = ""; //Limpiar clave
            }
        }
    }   
}
