using System;
using System.Windows.Forms;
using System.Data;
using LibClases;

namespace LibFormularios
{
    public partial class FrmDocente : FrmPadre
    {
        private bool EditActivado = false;
        public FrmDocente()
        {
            InitializeComponent();
            IniciarEntidad(new cDocente());
        }
        #region Modulos Override
        //======definicion de los metodos virtuales=======

        //--EStablecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] {tbCodigo.Text,tbNombre.Text,tbAP.Text,tbAM.Text,tbClase.Text
            ,tbCategoria.Text,tbRegimen.Text,tbCarrera.Text};
        }
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        {   //-- muestra la informacion contenida en el dataset de cDocente
            tbAP.Text = aEntidad.ValorAtributo("APaterno");
            tbAM.Text = aEntidad.ValorAtributo("AMaterno");
            tbNombre.Text = aEntidad.ValorAtributo("Nombre");
            tbCategoria.Text = aEntidad.ValorAtributo("Categoria");
            tbRegimen.Text = aEntidad.ValorAtributo("Regimen");
        }
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            tbCodigo.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            tbNombre.Text = "";
            tbAP.Text = "";
            tbAM.Text = "";
            tbClase.Text = "";
            tbCategoria.Text = "";
            tbRegimen.Text = "";
            tbCarrera.Text = "";
        }
        //-- Listar los registros y mostrrlos en el datagrid
        public override void ListarRegistros()
        {   //-- Mostrar todos los docentes de la tabla en el grid
            DgvDocente.DataSource = aEntidad.ListaGeneral();
        }
        //-- verificar los campos obligatorios(codigo y nombre) esten llenos
        public override bool EsRegistroValido()
        {
            // if (tbCodigo.Text.Trim() != "" && tbNombre.Text.Trim() != "")
            if (tbNombre.Text.Trim() != "")
                return true;
            else
                return false;
        }
        #endregion

        #region Eventos
        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        private void FrmDocente_Load(object sender, EventArgs e)
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

                    if (EditActivado) //Si se presionó el boton editar, entonces actualizar
                    {
                        DialogResult dialogoEditar = MessageBox.Show("La nueva informacion del Docente se actualizará\n¿Desea Continuar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialogoEditar == DialogResult.OK)
                        {
                            aEntidad.Actualizar(Atributos);
                            EditActivado = false; //Reestablecer a falso
                            tbCodigo.ReadOnly = false;
                            MessageBox.Show("SE ACTUALIZÓ AL DOCENTE EXITOSAMENTE", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InicializarAtributos();//Reestablecer cmpos de edicion
                        }

                    }
                    else //Entonces insertar
                    {
                        DialogResult dialogoGuardar = MessageBox.Show("La informacion del Docente se agregará a la base de Datos\n¿Desea Continuar? ", "Verificacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialogoGuardar == DialogResult.OK)//Entonces insertar
                        {
                            aEntidad.Insertar(Atributos);
                            MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InicializarAtributos();
                        }
                    }
                    //-- Inicializar el formulario
                    //MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    //InicializarAtributos();
                    ListarRegistros();
                }
                else
                    MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Editar()
        {
            try
            {
                if (DgvDocente.SelectedRows.Count > 0)
                {
                    tbCodigo.Text = DgvDocente.CurrentRow.Cells[0].Value.ToString();
                    tbNombre.Text = DgvDocente.CurrentRow.Cells[1].Value.ToString();
                    tbAP.Text = DgvDocente.CurrentRow.Cells[2].Value.ToString();
                    tbAM.Text = DgvDocente.CurrentRow.Cells[3].Value.ToString();
                    tbClase.Text = DgvDocente.CurrentRow.Cells[4].Value.ToString();
                    tbCategoria.Text = DgvDocente.CurrentRow.Cells[5].Value.ToString();
                    tbRegimen.Text = DgvDocente.CurrentRow.Cells[6].Value.ToString();
                    tbCarrera.Text = DgvDocente.CurrentRow.Cells[7].Value.ToString();
                    EditActivado = true;
                    tbCodigo.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("SELECCIONE UNA FILA PARA EDITAR", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Eliminar()
        {
            try
            {
                if (DgvDocente.SelectedRows.Count > 0)
                {
                    string Codigo, Nombre, AP, AM, Clase, Categoria, Regimen, Carrera;
                    Codigo = DgvDocente.CurrentRow.Cells[0].Value.ToString();                 
                    Nombre = DgvDocente.CurrentRow.Cells[1].Value.ToString();
                    AP = DgvDocente.CurrentRow.Cells[2].Value.ToString();
                    AM = DgvDocente.CurrentRow.Cells[3].Value.ToString();
                    Clase = DgvDocente.CurrentRow.Cells[4].Value.ToString();
                    Categoria = DgvDocente.CurrentRow.Cells[5].Value.ToString();
                    Regimen = DgvDocente.CurrentRow.Cells[6].Value.ToString();
                    Carrera = DgvDocente.CurrentRow.Cells[7].Value.ToString();

                    //--Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = { Codigo, Nombre , AP , AM , Clase , Categoria , Regimen, Carrera };

                    DialogResult dialogoEliminar = MessageBox.Show("Esta seguro que desea eliminar al docente\n cuyo codigo es " + Codigo + " ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    //Continuar si se acepta:
                    if (dialogoEliminar == DialogResult.OK)
                    {
                        //-- Verificar si existe clave primaria
                        aEntidad.Eliminar(Atributos);
                        MessageBox.Show("DOCENTE ELIMINADO EXITOSAMENTE", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicializarAtributos();
                        ListarRegistros();
                    }
                }
                else
                {
                    MessageBox.Show("SELECCIONE UNA FILA PARA ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        //public void Tutor();
        private void btnFiltrarEst_Click(object sender, EventArgs e)
        {
            FrmFiltroDocentes Filtro = new FrmFiltroDocentes();
            AddOwnedForm(Filtro);
            Filtro.Show();

        }
        
    }
}
