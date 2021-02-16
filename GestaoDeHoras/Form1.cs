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
using DataAccessLayer;

namespace GestaoDeHoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            if (login.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                if (Login.Tipo == "Aluno")
                {
                    CarregarLvAluno(Login.Aluno);
                    menuStrip1.Visible = false;
                }
                else
                {
                    menuStrip1.Visible = true;
                    CarregarLv();
                }

            }

            

        }

        public void CarregarLv()
        {
            ConString.con.Open();

            ListViewItem lvi;

            try
            {
                listView1.Items.Clear();

                SqlCommand cmd = new SqlCommand("Select * from Horas", ConString.con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lvi = new ListViewItem();
                    lvi.Text = reader.GetValue(1).ToString();
                    lvi.SubItems.Add(reader.GetValue(2).ToString());
                    lvi.SubItems.Add(reader.GetValue(3).ToString());
                    lvi.SubItems.Add(reader.GetValue(4).ToString());
                    lvi.SubItems.Add(reader.GetValue(5).ToString());
                    lvi.SubItems.Add(reader.GetValue(6).ToString());
                    lvi.SubItems.Add(reader.GetValue(7).ToString());

                    listView1.Items.Add(lvi);
                }
            }
            catch { }
            finally { ConString.con.Close(); }
        }

        public void CarregarLvAluno(string aluno)
        {

            ConString.con.Open();
            int numero = 0;
            ListViewItem lvi;

            try
            {
                listView1.Items.Clear();
                numero = Convert.ToInt32(aluno.Replace("I", ""));
                SqlCommand cmd = new SqlCommand("Select * from Horas where Aluno='" + numero + "'", ConString.con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lvi = new ListViewItem();
                    lvi.Text = reader.GetValue(1).ToString();
                    lvi.SubItems.Add(reader.GetValue(2).ToString());
                    lvi.SubItems.Add(reader.GetValue(3).ToString());
                    lvi.SubItems.Add(reader.GetValue(4).ToString());
                    lvi.SubItems.Add(reader.GetValue(5).ToString());
                    lvi.SubItems.Add(reader.GetValue(6).ToString());
                    lvi.SubItems.Add(reader.GetValue(7).ToString());

                    listView1.Items.Add(lvi);
                }
            }
            catch
            {

            }
            finally { ConString.con.Close(); }
        }


        private void tsmiCriar_Click(object sender, EventArgs e)
        {
            Criar criar = new Criar();
            this.Hide();
            criar.ShowDialog();
            this.Show();
        }



        private void omACompensar_Click(object sender, EventArgs e)
        {
            CompensarHoras compensarH = new CompensarHoras();
            this.Hide();
            compensarH.ShowDialog();
            this.Show();
        }

        private void tsmiCompensacao_Click(object sender, EventArgs e)
        {
            CompensacaoHoras compensacaoH = new CompensacaoHoras();
            this.Hide();
            compensacaoH.ShowDialog();
            this.Show();
        }

        private void tsmiApagar_Click(object sender, EventArgs e)
        {
            ApagarAluno apagarA = new ApagarAluno();
            this.Hide();
            apagarA.ShowDialog();
            this.Show();
        }
    }
}
