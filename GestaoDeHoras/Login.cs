using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace GestaoDeHoras
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkbxShowPass.Checked)
                {
                    tbxPass.PasswordChar = '\0';
                }
                else
                {
                    tbxPass.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void bttChange_Click(object sender, EventArgs e)
        {
            if(lbTitle.Text == "Professor")
            {
                bttChange.Text = "PROFESSOR";
                lbTitle.Text = "Aluno";
            }
            else
            {
                bttChange.Text = "ALUNO";
                lbTitle.Text = "Professor";
            }
        }

        private void bttLogin_Click_1(object sender, EventArgs e)
        {
            Logins dados = new Logins();
            try
            {
                if (dados.LoginAluno(tbxUser.Text, tbxPass.Text, lbTitle.Text))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Password Incorreta");
                }


            }
            catch (Exception ex)
            {

            }
        }

        private void lbCreate_Click(object sender, EventArgs e)
        {

        }

        private void bttQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttQuit_MouseHover(object sender, EventArgs e)
        {
            bttQuit.BackColor = Color.Red;
        }
    }
}
