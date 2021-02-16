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
    public partial class CompensarHoras : Form
    {
        public CompensarHoras()
        {
            InitializeComponent();
        }

        private void CompensarHoras_Load(object sender, EventArgs e)
        {
            ConString.con.Open();
            try
            {
                SqlCommand cmdInsNota = new SqlCommand("SELECT * FROM Turma", ConString.con);
                SqlDataReader reader = cmdInsNota.ExecuteReader();
                while (reader.Read())
                {
                    lb_Turmas.Items.Add(reader.GetValue(0).ToString());
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

        private void lb_Turmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_Alunos.Items.Clear();

            ListViewItem lvi;

            ConString.con.Open();
            try
            {
                SqlCommand cmdInsNota = new SqlCommand("SELECT Numero, Nome FROM Aluno WHERE Turma ='" + lb_Turmas.SelectedItem.ToString() + "'", ConString.con);
                SqlDataReader reader = cmdInsNota.ExecuteReader();
                while (reader.Read())
                {
                    lvi = new ListViewItem();
                    lvi.Text = reader.GetValue(0).ToString();
                    lvi.SubItems.Add(reader.GetValue(1).ToString());

                    lv_Alunos.Items.Add(lvi);
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

        private void btn_Submeter_Click(object sender, EventArgs e)
        {

        }
    }
}
