
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttQuit = new System.Windows.Forms.Button();
            this.plMenuUp = new System.Windows.Forms.Panel();
            this.lbNome = new System.Windows.Forms.Label();
            this.plMenuLeft = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plControl = new System.Windows.Forms.Panel();
            this.usHomeAluno = new GestaoDeHoras.HomeAluno();
            this.plMenuUp.SuspendLayout();
            this.plMenuLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttQuit
            // 
            this.bttQuit.BackColor = System.Drawing.Color.Transparent;
            this.bttQuit.FlatAppearance.BorderSize = 0;
            this.bttQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttQuit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttQuit.ForeColor = System.Drawing.Color.Black;
            this.bttQuit.Location = new System.Drawing.Point(820, 3);
            this.bttQuit.Name = "bttQuit";
            this.bttQuit.Size = new System.Drawing.Size(77, 26);
            this.bttQuit.TabIndex = 12;
            this.bttQuit.Text = "Quit";
            this.bttQuit.UseVisualStyleBackColor = false;
            this.bttQuit.Click += new System.EventHandler(this.bttQuit_Click);
            this.bttQuit.MouseLeave += new System.EventHandler(this.bttQuit_MouseLeave);
            this.bttQuit.MouseHover += new System.EventHandler(this.bttQuit_MouseHover);
            // 
            // plMenuUp
            // 
            this.plMenuUp.BackColor = System.Drawing.Color.White;
            this.plMenuUp.Controls.Add(this.lbNome);
            this.plMenuUp.Controls.Add(this.bttQuit);
            this.plMenuUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.plMenuUp.Location = new System.Drawing.Point(60, 0);
            this.plMenuUp.Name = "plMenuUp";
            this.plMenuUp.Size = new System.Drawing.Size(900, 33);
            this.plMenuUp.TabIndex = 13;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(3, 5);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(57, 21);
            this.lbNome.TabIndex = 14;
            this.lbNome.Text = "Nome";
            // 
            // plMenuLeft
            // 
            this.plMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(49)))));
            this.plMenuLeft.Controls.Add(this.button4);
            this.plMenuLeft.Controls.Add(this.button3);
            this.plMenuLeft.Controls.Add(this.button1);
            this.plMenuLeft.Controls.Add(this.button2);
            this.plMenuLeft.Controls.Add(this.pictureBox1);
            this.plMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.plMenuLeft.Name = "plMenuLeft";
            this.plMenuLeft.Size = new System.Drawing.Size(60, 533);
            this.plMenuLeft.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 54);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 54);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 54);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 54);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // plControl
            // 
            this.plControl.Controls.Add(this.usHomeAluno);
            this.plControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plControl.Location = new System.Drawing.Point(60, 39);
            this.plControl.Name = "plControl";
            this.plControl.Size = new System.Drawing.Size(900, 494);
            this.plControl.TabIndex = 14;
            // 
            // usHomeAluno
            // 
            this.usHomeAluno.BackColor = System.Drawing.Color.White;
            this.usHomeAluno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usHomeAluno.Location = new System.Drawing.Point(0, -115);
            this.usHomeAluno.Margin = new System.Windows.Forms.Padding(4);
            this.usHomeAluno.Name = "usHomeAluno";
            this.usHomeAluno.Size = new System.Drawing.Size(900, 609);
            this.usHomeAluno.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(960, 533);
            this.Controls.Add(this.plControl);
            this.Controls.Add(this.plMenuUp);
            this.Controls.Add(this.plMenuLeft);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plMenuUp.ResumeLayout(false);
            this.plMenuUp.PerformLayout();
            this.plMenuLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttQuit;
        private System.Windows.Forms.Panel plMenuUp;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Panel plMenuLeft;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plControl;
        private HomeAluno usHomeAluno;
    }
}

