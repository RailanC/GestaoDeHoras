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
    public partial class CompensacaoHoras : Form
    {
        public CompensacaoHoras()
        {
            InitializeComponent();
        }

        private void CompensacaoHoras_Load(object sender, EventArgs e)
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
                dtp_Data.CustomFormat = "yyyy/MM/dd";
                dtpHInicial.CustomFormat = "yyyy/MM/dd HH:mm";
                dtpHFinal.CustomFormat = "yyyy/MM/dd HH:mm";
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

        private void lv_Alunos_SelectedIndexChanged(object sender, EventArgs e)
        {

            cb_Disciplina.Items.Clear();

            ConString.con.Open();
            try
            {
                SqlCommand cmdInsNota = new SqlCommand("SELECT Sigla FROM Horas WHERE Aluno = '" + lv_Alunos.SelectedItems[0].Text + "'", ConString.con);
                SqlDataReader reader = cmdInsNota.ExecuteReader();
                while (reader.Read())
                {
                    cb_Disciplina.Items.Add(reader.GetValue(0).ToString());
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

        private void cb_Disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Trimestre.Items.Clear();

            ConString.con.Open();
            try
            {
                SqlCommand cmdInsNota = new SqlCommand("SELECT Trimestre FROM Horas WHERE Aluno = '" + lv_Alunos.SelectedItems[0].Text + "' AND Sigla='" + cb_Disciplina.SelectedItem.ToString() + "'", ConString.con);
                SqlDataReader reader = cmdInsNota.ExecuteReader();
                while (reader.Read())
                {
                    cb_Trimestre.Items.Add(reader.GetValue(0).ToString());
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

        private void btnSubmeter_Click(object sender, EventArgs e)
        {

            float var = 0;
            float qtdHComp = 0;
            float total;
            string test;
            ConString.con.Open();
            try
            {
                test = dtp_Data.Value.ToString();
                total = (float.Parse(dtpHFinal.Value.ToString().Split(' ')[1].Split(':')[0]) + (float.Parse(dtpHFinal.Value.ToString().Split(' ')[1].Split(':')[1]) / 60))
                            - (float.Parse(dtpHInicial.Value.ToString().Split(' ')[1].Split(':')[0]) + (float.Parse(dtpHInicial.Value.ToString().Split(' ')[1].Split(':')[1]) / 60));

                if (total <= 0)
                {
                    MessageBox.Show("Valores de Horas Inválidos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NovaHoras novaHoras = new NovaHoras();
                    SqlCommand cmdInsNota = new SqlCommand("Select QuantH from Horas WHERE Aluno = '" + lv_Alunos.SelectedItems[0].Text + "' AND Sigla='" + cb_Disciplina.SelectedItem.ToString() + "' AND Trimestre = '" + cb_Trimestre.SelectedItem.ToString() + "' AND HoraInicC is NULL", ConString.con);
                    SqlDataReader reader = cmdInsNota.ExecuteReader();

                    while (reader.Read())
                    {
                        var = float.Parse(reader.GetValue(0).ToString());
                    }


                    if (var != 0)
                    {
                        reader.Close();
                        SqlCommand cmd = new SqlCommand("Select * from Horas WHERE Aluno = '" + lv_Alunos.SelectedItems[0].Text + "' AND Sigla='" + cb_Disciplina.SelectedItem.ToString() + "' AND Trimestre = '" + cb_Trimestre.SelectedItem.ToString() + "' AND HoraInicC is NOT NULL", ConString.con);
                        SqlDataReader reader1 = cmd.ExecuteReader();

                        while (reader1.Read())
                        {
                            qtdHComp += TimeToFloat(reader1.GetValue(5).ToString(), reader1.GetValue(6).ToString());
                        }

                        if (var - qtdHComp <= 0)
                        {
                            MessageBox.Show("Este aluno já não tem Horas a compensar!");
                        }
                        else
                        {
                            ConString.con.Close();
                            NovaHoras novaH = new NovaHoras();
                            if (novaH.AddHoras(Convert.ToInt32(lv_Alunos.SelectedItems[0].Text), cb_Disciplina.SelectedItem.ToString(), Convert.ToInt32(cb_Trimestre.SelectedItem.ToString()), var, dtp_Data.Value, dtpHInicial.Value, dtpHFinal.Value))
                            {
                                MessageBox.Show("C");
                            }
                            else
                            {
                                MessageBox.Show("E");
                            }
                        }
                    }

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

        public float TimeToFloat(string texto2, string texto)
        {
            float numero;
            numero = (float.Parse(texto.Split(' ')[1].Split(':')[0]) + (float.Parse(texto.Split(' ')[1].Split(':')[1]) / 60))
                            - (float.Parse(texto2.Split(' ')[1].Split(':')[0]) + (float.Parse(texto2.Split(' ')[1].Split(':')[1]) / 60));
            numero = numero * 60;
            return numero;
        }
    }
}
