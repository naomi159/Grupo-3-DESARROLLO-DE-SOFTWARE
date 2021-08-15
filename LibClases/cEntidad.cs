using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace LibClases
{
    public abstract class cEntidad
    {   //===================Atributos====================
        protected cConexion aConexion;
        private string aNombreTabla;
        string[] aNombres = null; //-- nombres de los campos de la tabla
        string[] aValores = null; //-- valores de los campos de la tabla
        private bool aNuevo;
        //====================Metodos=====================
       
        //-----------------Constructores------------------
        public cEntidad(string pNombreTabla)
        {   // inicializar los atributos
            aNuevo = true;
            aNombreTabla = pNombreTabla;
            aConexion = new cConexion();
            aNombres = NombresAtributos();
            aValores = null;
        }
        //-----------------Propiedades--------------------
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = value; }
        }

        #region Metodos de soporte de la BD
        //--------------------------------------------------------------------------
        //-- Metodos abstractos encargados de aestablecer los nombres de los campos
        //-- (atributos) de la tabla. Se deben implementar necesariamente
        //-- en los herederos como arreglos de cadenas.
        //-- Estos atributos deben concidir con los existentes en la Base de Datos
        //--------------------------------------------------------------------------
        public abstract string[] NombresAtributos();
        #endregion


        #region Metodos para el mantenimiento de la tabla
        //--------------- Insercion de nuevos registros---------------------------
        public virtual void Insertar(params string[] Atributos)
        {   //-- Permite insertar informacion de un registro en la tabla 

            //-- Recuperar los valores de los atributos
            aValores = Atributos;
            //-- Formar la cadena de insercion
            string CadenaInsertar = "insert into " + aNombreTabla + " values ('";
            for (int k = 0; k < aValores.Length; k++)
            {   //-- incluir los atributos en la consulta
                CadenaInsertar += aValores[k];
                if (k == aValores.Length - 1)
                    //-- se concatenó el ultimo atributo. Terminar la consulta.
                    CadenaInsertar += "')";
                else   //-- dejar la consulta lista para el siguiente atributo
                    CadenaInsertar += "', '";
            }
            // Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(CadenaInsertar);
            aNuevo = false;
        }
        // ------------Actualizacion de registros---------------------------------
        public void Actualizar(params string[] Atributos)
        {   //-- Permite actualizar la informacion de un registro de la tabla

            //-- Recuperar los nombres y valores de los atributos de la tabla.
            aNombres = NombresAtributos();
            aValores = Atributos;

            //-- Formar la cadena de actualizacion
            //-- Se asume que la clave principal es el primer atributo (Posicion CERO)
            string CadenaActualizar = "update " + aNombreTabla + " set ";
            for (int k = 1; k < aValores.Length; k++)
            {   //-- incluir los atributos en la consulta
                CadenaActualizar += aNombres[k] + "= '" + aValores[k];
                if (k == aValores.Length - 1)
                    //-- se concatenó el ultimo atributo. Terminar asignacion de valores
                    CadenaActualizar += "'";
                else    //-- dejar la consulta lista para el siguiente atributo
                    CadenaActualizar += "', ";
            }
            //-- Agregar a la consulta la clausula WHERE
            CadenaActualizar += " where " + aNombres[0] + "= '" + aValores[0] + "'";

            //-- Ejecutar la consulta para actualizar el registro
            aConexion.EjecutarComando(CadenaActualizar);
        }
        //--------------------Eliminacion de un registro -------------------------
        public void Eliminar(params string[] Atributos)
        {   //--Permite eliminar un registro
            //-- Recuperar los nombres y valores de los atributos de la Tabla.
            aNombres = NombresAtributos();
            aValores = Atributos;

            //-- Formar la cadena de eliminacion
            string CadenaEliminar = "delete from " + aNombreTabla + " where " + aNombres[0] + "= '" + aValores[0] + "'";

            //-- Ejecutar la consulta para eliminar el registro
            aConexion.EjecutarComando(CadenaEliminar);
        }
        //------------------------------------------------------------------------
        public bool ExisteClavePrimaria(params string[] Atributos)
        {   // verifica si un registro especifico existe

            //-- Recuperar los nombres y valores de los atributos de la tabla.
            aNombres = NombresAtributos();
            aValores = Atributos;

            //-- Formar la consulta
            string CadenaConsulta = "select * from " + aNombreTabla + " where " + aNombres[0] + "= '" + aValores[0] + "'";

            //--Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);

            //-- Si existen registros en la tabla 0 del dataset, la clave primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        //------------------------------------------------------------------------
        public DataRow RecuperarRegistro(params string[] Atributos)
        {   //-- Recupera la informacion de un registro
            //-- Recuperar los nombres y valores de los atributos de la tabla.
            aNombres = NombresAtributos();
            aValores = Atributos;

            //-- Formar la consulta a travez de la clave primaria
            string CadenaConsulta = "select * from " + aNombreTabla + " where " + aNombres[0] + "= '" + aValores[0] + "'";

            //-- Ejecutar la consulta y devolver el resultado
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0].Rows[0];
        }
        //------------------------------------------------------------------------
        public string ValorAtributo(string pNombreCampo)
        {   //-- Recupera el valor de un atributo del dataset 
            if (aConexion.Datos.Tables[0].Rows.Count > 0)
                return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
            else
                return "";
        }
        //------------------------------------------------------------------------
        public DataTable ListaGeneral()
        {   //retorna una tabla con la lista completa de los registros 
            string Consulta = "select * from " + aNombreTabla;
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        #endregion
        public DataTable Filtrar(params string[] Atributos)
        {
            DataTable Tabla = new DataTable();
            aNombres = NombresAtributos();
            aValores = Atributos;

            //Generar consulta
            string CodSQL = $"select * from {aNombreTabla} where\n";
            string Operador;
            int NroAtr = aNombres.Length;
            for (int i = 0; i < NroAtr; i++)
            {
                Operador = aValores[i] == "" ? "<>" : "=";
                CodSQL += $"\t{aNombres[i]} {Operador} '{aValores[i]}' ";
                if (i < NroAtr - 1) CodSQL += "and\n";
            }
            aConexion.EjecutarSelect(CodSQL);
            return aConexion.Datos.Tables[0];
        }

    }
}
