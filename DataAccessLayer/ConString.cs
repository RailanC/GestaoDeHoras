using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ConString
    {
        public static SqlConnection con;

        static ConString()
        {
            con = new SqlConnection(@"server=.\SQLexpress;database=CompHoras;Trusted_Connection=True;");
        }
    }
}
