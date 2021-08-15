using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cEstudiante :cEntidad
    {
        //==============ATRIBUTOS================
        //---   Todos heredados de cEntidad   ---

        //===============METODOS=================
        //-----------Constructores---------------
        public cEstudiante() : base("Estudiante")
        {
        }
        //--Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] {"CodEstudiante","Nombres","ApellidoPaterno","ApellidoMaterno","CarreraProfesional","Condicion"};
        }
    }
}
