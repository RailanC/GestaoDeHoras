﻿using System;
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
    public partial class Criar : Form
    {
        public Criar()
        {
            InitializeComponent();
        }

        private void cbxSwPass_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxSwPass.Checked)
                {
                    tbxPass.PasswordChar = '\0';
                    tbxConfPass.PasswordChar = '\0';
                }
                else
                {
                    tbxPass.PasswordChar = '*';
                    tbxConfPass.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNome.Text != "" || tbxNumero.Text != "" || tbxPass.Text != "" || tbxConfPass.Text != "" || tbxUser.Text != "" || cbbTurma.SelectedIndex != -1)
                {
                    string VerLogin = tbxUser.Text;
                    VerLogin = VerLogin.Substring(1);

                    if (tbxUser.Text.StartsWith("I") || tbxUser.Text.StartsWith("i"))
                    {
                        if (tbxNumero.Text == VerLogin)
                        {
                            Registo rst = new Registo();
                            if (tbxPass.Text == tbxConfPass.Text)
                            {
                                if (rst.RegistoA(Convert.ToInt32(tbxNumero.Text), tbxNome.Text, tbxUser.Text, tbxPass.Text, cbbTurma.SelectedItem.ToString()))
                                {

                                    MessageBox.Show("Criado");
                                }
                                else
                                {
                                    MessageBox.Show("Erro");
                                }
                            }
                            else
                            {
                                MessageBox.Show("As duas passwords não coincidem!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("O Username não está de acordo com o Número do Aluno!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O Username não começa com o caracter i !", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Os campos não estão todos preenchidos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private void Criar_Load(object sender, EventArgs e)
        {
            ConString.con.Open();
            try
            {
                SqlCommand cmdInsNota = new SqlCommand("Select * from Turma", ConString.con);
                SqlDataReader reader = cmdInsNota.ExecuteReader();
                while (reader.Read())
                {
                    cbbTurma.Items.Add(reader.GetValue(0).ToString());
                }
            }
            catch(Exception ex)
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
