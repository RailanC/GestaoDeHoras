using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeHoras
{
    public partial class ApagarAluno : Form
    {
        public ApagarAluno()
        {
            InitializeComponent();
        }

        private void ApagarAluno_Load(object sender, EventArgs e)
        {
            ConString.con.Open();
            try
            {
                SqlCommand cmdInsNota = new SqlCommand("Select Numero, Nome from Aluno", ConString.con);
                SqlDataReader reader = cmdInsNota.ExecuteReader();
                while (reader.Read())
                {
                    cbbTurma.Items.Add(reader.GetValue(0).ToString() + "|" + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConString.con.Close();
            }
        }
    }
}
