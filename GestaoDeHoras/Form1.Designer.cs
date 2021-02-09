
namespace GestaoDeHoras
{
    partial class Form1
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
            this.bttEntrar = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttEntrar
            // 
            this.bttEntrar.Location = new System.Drawing.Point(163, 192);
            this.bttEntrar.Name = "bttEntrar";
            this.bttEntrar.Size = new System.Drawing.Size(131, 31);
            this.bttEntrar.TabIndex = 4;
            this.bttEntrar.Text = "Entrar";
            this.bttEntrar.UseVisualStyleBackColor = true;
            this.bttEntrar.Click += new System.EventHandler(this.bttEntrar_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(163, 138);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(131, 20);
            this.txtPass.TabIndex = 3;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(202, 122);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(53, 13);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(163, 80);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(131, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(212, 64);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 596);
            this.Controls.Add(this.bttEntrar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.txtLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttEntrar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbLogin;
    }
}

