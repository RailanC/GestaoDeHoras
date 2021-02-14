
namespace GestaoDeHoras
{
    partial class frmLoginAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUser = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.checkbxShowPass = new System.Windows.Forms.CheckBox();
            this.bttLogin = new System.Windows.Forms.Button();
            this.bttChange = new System.Windows.Forms.Button();
            this.lbAlready = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(30, 86);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(69, 17);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "Username";
            // 
            // tbxUser
            // 
            this.tbxUser.BackColor = System.Drawing.Color.White;
            this.tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUser.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(33, 108);
            this.tbxUser.Multiline = true;
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(216, 28);
            this.tbxUser.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(30, 156);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(66, 17);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // tbxPass
            // 
            this.tbxPass.BackColor = System.Drawing.Color.White;
            this.tbxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPass.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.Location = new System.Drawing.Point(33, 178);
            this.tbxPass.Multiline = true;
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(216, 28);
            this.tbxPass.TabIndex = 2;
            // 
            // checkbxShowPass
            // 
            this.checkbxShowPass.AutoSize = true;
            this.checkbxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbxShowPass.Location = new System.Drawing.Point(130, 212);
            this.checkbxShowPass.Name = "checkbxShowPass";
            this.checkbxShowPass.Size = new System.Drawing.Size(119, 21);
            this.checkbxShowPass.TabIndex = 3;
            this.checkbxShowPass.Text = "Show Password";
            this.checkbxShowPass.UseVisualStyleBackColor = true;
            this.checkbxShowPass.CheckedChanged += new System.EventHandler(this.checkbxShowPass_CheckedChanged);
            // 
            // bttLogin
            // 
            this.bttLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.bttLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttLogin.ForeColor = System.Drawing.Color.White;
            this.bttLogin.Location = new System.Drawing.Point(33, 263);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(216, 35);
            this.bttLogin.TabIndex = 4;
            this.bttLogin.Text = "LOGIN";
            this.bttLogin.UseVisualStyleBackColor = false;
            this.bttLogin.Click += new System.EventHandler(this.bttLogin_Click);
            // 
            // bttChange
            // 
            this.bttChange.BackColor = System.Drawing.Color.White;
            this.bttChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.bttChange.Location = new System.Drawing.Point(33, 304);
            this.bttChange.Name = "bttChange";
            this.bttChange.Size = new System.Drawing.Size(216, 35);
            this.bttChange.TabIndex = 4;
            this.bttChange.Text = "PROFESSOR";
            this.bttChange.UseVisualStyleBackColor = false;
            this.bttChange.Click += new System.EventHandler(this.bttChange_Click);
            // 
            // lbAlready
            // 
            this.lbAlready.AutoSize = true;
            this.lbAlready.Location = new System.Drawing.Point(75, 359);
            this.lbAlready.Name = "lbAlready";
            this.lbAlready.Size = new System.Drawing.Size(132, 17);
            this.lbAlready.TabIndex = 5;
            this.lbAlready.Text = "Não tem uma Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(91, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create Account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(33, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(33, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 1);
            this.panel2.TabIndex = 6;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(87)))), ((int)(((byte)(174)))));
            this.lbTitle.Location = new System.Drawing.Point(28, 43);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(82, 27);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Aluno";
            // 
            // frmLoginAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAlready);
            this.Controls.Add(this.bttChange);
            this.Controls.Add(this.bttLogin);
            this.Controls.Add(this.checkbxShowPass);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoginAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAluno";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.CheckBox checkbxShowPass;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.Button bttChange;
        private System.Windows.Forms.Label lbAlready;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
    }
}