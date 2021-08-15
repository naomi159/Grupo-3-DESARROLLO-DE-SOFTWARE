using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cFichaTutoria : cEntidad
    {
        //==============ATRIBUTOS================
        //---   Todos heredados de cEntidad   ---

        //===============METODOS=================
        //-----------Constructores---------------
        public cFichaTutoria() : base("FichaTutoria")
        {
        }
        //--Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] { "CodDocente", "CodEstudiante", "Semestre", "Fecha" , "Descripcion"};
        }
    }

}
