using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace catalogo
{
    public class conexion
    {
        public SqlConnection access = new SqlConnection("server=localhost\\SQLEXPRESS; database=SisCont; integrated security=true;");
    }
}
