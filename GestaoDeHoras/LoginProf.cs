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
    public partial class frmLoginProf : Form
    {
        public frmLoginProf()
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

        private void bttLogin_Click(object sender, EventArgs e)
        {
            Logins dados = new Logins();
            try
            {
                if (dados.LoginAluno(tbxUser.Text, tbxPass.Text, "Professor"))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else { MessageBox.Show("Password Incorreta"); }

               
            }
            catch(Exception ex)
            {

            }
        }

        private void bttChange_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
