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
        private float minutos;
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
        public float Minutos
        {
            get { return minutos; }
            set { minutos = value; }
        }



        public bool AddHoras(int numero, string sigla, int trim, float minutos, DateTime dataInicial, DateTime hInic, DateTime hFinal)
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
                cmd.Parameters.AddWithValue("@Hinic", hInic);
                cmd.Parameters.AddWithValue("@Hfinal", hFinal);
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

        public bool AddHoras(int numero, string sigla, int trim, float minutos)
        {
            ConString.con.Open();
            try
            {
                if(minutos == 0)
                {
                    return false;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_NewHora", ConString.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Aluno", numero);
                    cmd.Parameters.AddWithValue("@trim", trim);
                    cmd.Parameters.AddWithValue("@Sigla", sigla);
                    cmd.Parameters.AddWithValue("@qtd", minutos);
                    cmd.Parameters.AddWithValue("@data", "");
                    cmd.Parameters.AddWithValue("@Hinic", "");
                    cmd.Parameters.AddWithValue("@Hfinal", "");
                    cmd.ExecuteNonQuery();
                    return true;
                }
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
