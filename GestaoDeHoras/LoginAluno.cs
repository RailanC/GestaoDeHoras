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
    public partial class frmLoginAluno : Form
    {
        public frmLoginAluno()
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
            catch(Exception ex)
            {

            }
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            Logins dados = new Logins();
            string tipo = "Aluno";
            try
            {
                if (dados.LoginAluno(tbxUser.Text, tbxPass.Text, "Aluno"))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Incorreta");
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void bttChange_Click(object sender, EventArgs e)
        {
            frmLoginProf login = new frmLoginProf();
            try
            {
                this.Hide();
                if (login.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            finally
            {
                this.Close();
            }
           
           
        }
    }
}
