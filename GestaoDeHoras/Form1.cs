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
            Login login = new Login();
            this.Hide();
            if (login.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void tsmiCriar_Click(object sender, EventArgs e)
        {
            Criar criar = new Criar();
            this.Hide();
            criar.ShowDialog();
            this.Show();
        }
    }
}
