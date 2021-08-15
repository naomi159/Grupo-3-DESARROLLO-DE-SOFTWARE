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
using System.Security.Cryptography;

namespace LibFormularios
{
    public partial class FrmEstudiante : FrmPadre
    {
        private bool EditActivado = false;

        public FrmEstudiante()
        {
            InitializeComponent();
            IniciarEntidad(new cEstudiante());
        }

        #region Modulos Override
        //======definicion de los metodos virtuales=======

        //--EStablecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] {tbCodigo.Text, tbNombres.Text,tbAP.Text,tbAM.Text,tbCarrera.Text,cbCondicion.Text};
        }
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        {   //-- muestra la informacion contenida en el dataset de cDocente
            //tbAP.Text = aEntidad.ValorAtributo("APaterno");
            //tbAM.Text = aEntidad.ValorAtributo("AMaterno");
            //tbNombre.Text = aEntidad.ValorAtributo("Nombre");
            //tbCategoria.Text = aEntidad.ValorAtributo("Categoria");
            //tbRegimen.Text = aEntidad.ValorAtributo("Regimen");
        }
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            tbCodigo.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            tbNombres.Text = "";
            tbAP.Text = "";
            tbAM.Text = "";
            tbCarrera.Text = "";
            cbCondicion.Text = "";
        }
        //-- Listar los registros y mostrrlos en el datagrid
        public override void ListarRegistros()
        {   //-- Mostrar todos los estudiantes de la tabla en el grid
            dgvEstudiante.DataSource = aEntidad.ListaGeneral();
        }
        //-- verificar los campos obligatorios(codigo y nombre) esten llenos
        public override bool EsRegistroValido()
        {
            if (tbCodigo.Text.Trim() != "" && tbNombres.Text.Trim() != "")
                return true;
            else
                return false;
        }
        #endregion

        #region Eventos
        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }
        #endregion

        #region Módulos BD
        public override void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {   //--Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();

                    if (EditActivado) //Si se presionó el boton editar
                    {
                        DialogResult dialogoEditar = MessageBox.Show("La nueva informacion del estudiante se actualizara\n¿Desea Continuar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialogoEditar == DialogResult.OK)//Entonces actualizar
                        {
                            aEntidad.Actualizar(Atributos);
                            EditActivado = false; //Reestablecer a falso
                            tbCodigo.ReadOnly = false;
                            MessageBox.Show("SE ACTUALIZÓ AL ESTUDIANTE EXITOSAMENTE", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InicializarAtributos();//Reestablecer cmpos de edicion
                        }
                    }
                    else 
                    {
                        DialogResult dialogoGuardar = MessageBox.Show("La informacion del estudiante se agregará a la base de Datos\n¿Desea Continuar? ", "Verificacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialogoGuardar == DialogResult.OK)//Entonces insertar
                        {
                            aEntidad.Insertar(Atributos);
                            MessageBox.Show("SE GUARDÓ EXITOSAMENTE", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InicializarAtributos();//Reestablecer campos de insercion
                        }
                    }
                    //-- Inicializar el formulario
                    //MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    //InicializarAtributos();
                    ListarRegistros();
                }
                else
                    MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public override void Editar()
        {
            try
            {
                if (dgvEstudiante.SelectedRows.Count > 0)
                {
                    tbCodigo.Text = dgvEstudiante.CurrentRow.Cells[0].Value.ToString();
                    tbNombres.Text = dgvEstudiante.CurrentRow.Cells[1].Value.ToString();
                    tbAP.Text = dgvEstudiante.CurrentRow.Cells[2].Value.ToString();
                    tbAM.Text = dgvEstudiante.CurrentRow.Cells[3].Value.ToString();
                    tbCarrera.Text = dgvEstudiante.CurrentRow.Cells[4].Value.ToString();
                    cbCondicion.Text = dgvEstudiante.CurrentRow.Cells[5].Value.ToString();
                    EditActivado = true;
                    tbCodigo.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("SELECCIONE UNA FILA PARA EDITAR", "ERROR",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public override void Eliminar()
        {
            try
            {
                if (dgvEstudiante.SelectedRows.Count > 0)
                {
                    string Codigo, Nombre, AP, AM, Carrera, Condicion;
                    Codigo = dgvEstudiante.CurrentRow.Cells[0].Value.ToString();
                    Nombre = dgvEstudiante.CurrentRow.Cells[1].Value.ToString();
                    AP = dgvEstudiante.CurrentRow.Cells[2].Value.ToString();
                    AM = dgvEstudiante.CurrentRow.Cells[3].Value.ToString();
                    Carrera = dgvEstudiante.CurrentRow.Cells[4].Value.ToString();
                    Condicion = dgvEstudiante.CurrentRow.Cells[5].Value.ToString();

                    //--Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = { Codigo, Nombre, AP, AM, Carrera, Condicion };

                    DialogResult dialogoEliminar = MessageBox.Show("Esta seguro que desea eliminar al alumno\n cuyo codigo es "+Codigo+ " ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    
                    //Continuar si se acepta:
                    if (dialogoEliminar == DialogResult.OK)
                    {
                        
                        //-- Verificar si existe clave primaria
                        aEntidad.Eliminar(Atributos);
                        MessageBox.Show("ALUMNO ELIMINADO EXITOSAMENTE", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicializarAtributos();
                        ListarRegistros();
                    }
                    
                }
                else
                {
                    MessageBox.Show("SELECCIONE UNA FILA PARA ELIMINAR", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnFiltrarEst_Click(object sender, EventArgs e)
        {
            FrmFiltroEstudiante Filtro = new FrmFiltroEstudiante();
            AddOwnedForm(Filtro);
            Filtro.Show();
        }
    }
}
