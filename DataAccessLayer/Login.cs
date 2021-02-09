using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Login
    {
        private string user;
        private string pass;
        private string tipo;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public bool LoginAluno(string user, string pass, string tipo) //tipo = Aluno ou Professor
        {
            ConString.con.Open();
            try
            {
                SqlCommand cmdInsNota = new SqlCommand("Select Numero from "+ tipo +" where login='"+ user +"' and Pass='"+ pass +"'", ConString.con);
                SqlDataReader reader = cmdInsNota.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
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
