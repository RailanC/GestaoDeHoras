using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Registo
    {
        private int numero;
        private string nome;
        private string login;
        private string pass;
        private string turma;
        private string id;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Turma
        {
            get { return turma; }
            set { turma = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool RegistoA(int id, string nome, string login, string senha, string turma)
        {
            ConString.con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select Numero from Aluno where Numero='" + id + "'", ConString.con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return false;
                }
                else
                {
                    reader.Close();
                    SqlCommand cmdCheck = new SqlCommand("Select Numero from Aluno where username='" + login + "'", ConString.con);
                    SqlDataReader readerCheck = cmdCheck.ExecuteReader();
                    SqlCommand cmdReg = new SqlCommand("sp_RegAluno", ConString.con);
                    cmdReg.CommandType = CommandType.StoredProcedure;
                    cmdReg.Parameters.AddWithValue("@Numero", id);
                    cmdReg.Parameters.AddWithValue("@Nome", nome);
                    cmdReg.Parameters.AddWithValue("@Login", login);
                    cmdReg.Parameters.AddWithValue("@Pass", senha);
                    cmdReg.Parameters.AddWithValue("@Turma", turma);
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


        public bool RegistoP(int id, string nome, string login, string senha)
        {
            ConString.con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select ID from Professor where ID='" + id + "'", ConString.con);
                SqlDataReader reader = cmd.ExecuteReader();
                SqlCommand cmdReg = new SqlCommand("sp_RegProf", ConString.con);
                cmdReg.CommandType = CommandType.StoredProcedure;
                cmdReg.Parameters.AddWithValue("@ID", id);
                cmdReg.Parameters.AddWithValue("@Nome", nome);
                cmdReg.Parameters.AddWithValue("@Login", login);
                cmdReg.Parameters.AddWithValue("@Pass", senha);
                if (reader.HasRows)
                {
                    return false;
                }
                else
                {
                    reader.Close();
                    SqlCommand cmdCheck = new SqlCommand("Select ID from Professor where username='" + login + "'", ConString.con);
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
