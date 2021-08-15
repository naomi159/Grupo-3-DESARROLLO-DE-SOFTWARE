using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace LibClases
{
    public class cDocente : cEntidad
    {   //==============ATRIBUTOS================
        //---   Todos heredados de cEntidad   ---

        //===============METODOS=================
        //-----------Constructores---------------
        public cDocente() : base("Docente")
        {
        }
        //--Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] {"CodDocente","Nombres", "ApellidoPaterno","ApellidoMaterno","Clase",
                "Categoria","Regimen","CarreraProfesional"};
        }
        public DataTable ListaTutor()
        {

            string Codigo = @"select * from Docente where
                (Clase = 'Nombrado') or (Clase = 'Contratado' and (Regimen = 'A1' or Regimen = 'B1'))";
            aConexion.EjecutarSelect(Codigo);
            return aConexion.Datos.Tables[0];
        }

    }
}
