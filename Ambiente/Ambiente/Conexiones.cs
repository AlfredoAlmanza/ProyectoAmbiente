using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ambiente
{
    class Conexiones
    {
        public SqlConnection Conectar()
        {
            SqlConnection conectar = new SqlConnection(@"Data Source=FREDY-PC\SQLEXPRESS;Initial Catalog=Ambiente;Integrated Security=True");
            return conectar;
        }
    }
}
