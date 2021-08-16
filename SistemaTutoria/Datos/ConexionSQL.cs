using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionSQL
    {
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-H4RJ2LR;Initial Catalog=Tutoria;Integrated Security=True");
        SqlConnection conn = new SqlConnection("Data Source=proyectogrupo3-server.database.windows.net;Initial Catalog=Tutoria;User ID= Administrador; Password=Teamoyannick1");
        public DataTable Select(string consulta)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            adaptador.Fill(dt);
            return dt;
        }
        public SqlConnection GetConeccion()
        {
            return conn;
        }

    }
}
