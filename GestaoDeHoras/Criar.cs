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
                Registo rst = new Registo();
                if(rst.RegistoA(Convert.ToInt32(tbxNumero.Text), tbxNome.Text, tbxUser.Text, tbxPass.Text, "TGPSI18/02"))
                {
                    MessageBox.Show("Criado");
                }
                else
                {
                    MessageBox.Show("Erro");
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
    }
}
