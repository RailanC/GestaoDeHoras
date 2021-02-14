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
            usHomeAluno.Hide();
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

        private void bttQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttQuit_MouseHover(object sender, EventArgs e)
        {
            bttQuit.ForeColor = Color.Red;
        }

        private void bttQuit_MouseLeave(object sender, EventArgs e)
        {
            bttQuit.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usHomeAluno.Show();
        }
    }
}
