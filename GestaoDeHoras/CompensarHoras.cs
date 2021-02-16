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
            float var = 0;
            float qtdHComp = 0;
            ConString.con.Open();
            try
            {
                NovaHoras novaHoras = new NovaHoras();
                SqlCommand cmdInsNota = new SqlCommand("Select QuantH from Horas WHERE Aluno = '" + lv_Alunos.SelectedItems[0].Text + "' AND Sigla='" + cb_Disciplina.SelectedItem.ToString() + "' AND Trimestre = '" + cb_Trimestre.SelectedItem.ToString() + "' AND HoraInicC is NULL", ConString.con);
                SqlDataReader reader = cmdInsNota.ExecuteReader();

                if (!reader.HasRows)
                {
                        ConString.con.Close();
                        NovaHoras novaH = new NovaHoras();
                        if (novaH.AddHoras(Convert.ToInt32(lv_Alunos.SelectedItems[0].Text), cb_Disciplina.SelectedItem.ToString(), Convert.ToInt32(cb_Trimestre.SelectedItem.ToString()), float.Parse(nud_HCompensar.Value.ToString()) * 60))
                        {
                            MessageBox.Show("Criado com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Erro");
                        }
                }else
                {
                    MessageBox.Show("Já existe uma hora criada");
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
