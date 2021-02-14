using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NovaHoras
    {
        private int numero;
        private string sigla;
        private int trim;
        private long minutos;
        private string dataInicial;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Trim
        {
            get { return trim; }
            set { trim = value; }
        }
        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }
        public string DataInicial
        {
            get { return dataInicial; }
            set { dataInicial = value; }
        }
        public long Minutos
        {
            get { return minutos; }
            set { minutos = value; }
        }



        public bool AddHoras(int numero, string sigla, int trim, long minutos, string dataInicial)
        {
            ConString.con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_NewHora", ConString.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Aluno", numero);
                cmd.Parameters.AddWithValue("@trim", trim);
                cmd.Parameters.AddWithValue("@Sigla", sigla);
                cmd.Parameters.AddWithValue("@qtd", minutos);
                cmd.Parameters.AddWithValue("@data", dataInicial);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                ConString.con.Close();
            }
        }
    }
}
