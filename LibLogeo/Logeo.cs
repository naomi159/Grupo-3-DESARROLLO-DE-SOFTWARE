using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFormularios;
using LibClases;
using System.Runtime.InteropServices; //Para usar librerias nativas del sistema operativo (dlls)
using System.Threading;
namespace LibLogeo
{
    public partial class Logeo : Form
    {
        Thread th; //Hilo para iniciar nuevo formulario

        private cEntidad Usuario = new cUsuario();
        public Logeo()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "USUARIO")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.Black;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "")
            {
                TxtUser.Text = "USUARIO";
                TxtUser.ForeColor = Color.Black;
            }
        }

        private void TxtPasword_Enter(object sender, EventArgs e)
        {
            if (TxtPasword.Text == "CONTRASEÑA")
            {
                TxtPasword.Text = "";
                TxtPasword.ForeColor = Color.Black;
                TxtPasword.UseSystemPasswordChar = true;
            }
        }

        private void TxtPasword_Leave(object sender, EventArgs e)
        {
            if (TxtPasword.Text == "")
            {
                TxtPasword.Text = "CONTRASEÑA";
                TxtPasword.ForeColor = Color.Black;
                TxtPasword.UseSystemPasswordChar = false;
            }
        }

        //Boton acceder
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string CodUser = TxtUser.Text;
            string Contraseña = TxtPasword.Text;
            string Hash;

            //Verificar si el usuario existe en la base de datos
            if(Usuario.ExisteClavePrimaria(new string[] { CodUser })) //Si existe
            {
                //Recuperar hash (contraseña) de la base de datos
                Hash = Usuario.RecuperarRegistro(new string[] { CodUser })[1].ToString();
                //Cifrar contraseña introducida
                Contraseña = cCriptografia.CifradoMD5(Contraseña);
                //Comparar si la contraseña insertada es correcta
                if(Contraseña == Hash)
                {
                    MessageBox.Show("Sesion iniciada correctamente. Tenga buen día.");
                    //Cerrar login
                    this.Close();
                    //Abrir nuevo formulario
                    th = new Thread(AbrirNuevoFormulario);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                //Si Contraseña != Hash
                else MessageBox.Show("Contraseña incorrecta. Intente de nuevo.");
            }
            //Si el codigo no se encontro en la BD
            else MessageBox.Show("Usuario incorrecto. Intente de nuevo.");
        }
        private void AbrirNuevoFormulario()
        {
            Application.Run(new FrmMenu());
        }

        //Procedimiento para poder deslizar el login
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
