using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RegistoProf
    {



        public bool RegistoP(int ID, string Nome, string Login, string senha)
        {
            ConString.con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select Numero from Aluno where Numero='" + ID + "'", ConString.con);
                SqlDataReader reader = cmd.ExecuteReader();
                SqlCommand cmdReg = new SqlCommand("sp_RegProf", ConString.con);
                cmdReg.CommandType = CommandType.StoredProcedure;
                cmdReg.Parameters.AddWithValue("@ID", ID);
                cmdReg.Parameters.AddWithValue("@Nome", Nome);
                cmdReg.Parameters.AddWithValue("@Login", Login);
                cmdReg.Parameters.AddWithValue("@Pass", senha);
                if (reader.HasRows)
                {
                    return false;
                }
                else
                {
                    reader.Close();
                    SqlCommand cmdCheck = new SqlCommand("Select ID from Professor where login='" + Login + "'", ConString.con);
                    SqlDataReader readerCheck = cmdCheck.ExecuteReader();
                    if (readerCheck.HasRows)
                        return false;
                    else
                    {
                        readerCheck.Close();
                        cmdReg.ExecuteNonQuery();
                        return true;
                    }
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
