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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttEntrar_Click(object sender, EventArgs e)
        {
            Login dados = new Login();

            bool status = dados.InserirNota(txtLogin.Text, txtPass.Text);
            if (status == true)
            {
                MessageBox.Show("Certo!!");
            }
            else { MessageBox.Show("Falha! Senha Errada"); }
        }
    }
}
