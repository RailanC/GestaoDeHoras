namespace GestaoDeHoras
{
    partial class ApagarAluno
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
            this.cbbTurma = new System.Windows.Forms.ComboBox();
            this.bttApagar = new System.Windows.Forms.Button();
            this.lbAluno = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbTurma
            // 
            this.cbbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTurma.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbbTurma.FormattingEnabled = true;
            this.cbbTurma.Location = new System.Drawing.Point(29, 99);
            this.cbbTurma.Name = "cbbTurma";
            this.cbbTurma.Size = new System.Drawing.Size(330, 23);
            this.cbbTurma.TabIndex = 79;
            // 
            // bttApagar
            // 
            this.bttApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.bttApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttApagar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttApagar.ForeColor = System.Drawing.Color.White;
            this.bttApagar.Location = new System.Drawing.Point(29, 158);
            this.bttApagar.Name = "bttApagar";
            this.bttApagar.Size = new System.Drawing.Size(214, 32);
            this.bttApagar.TabIndex = 71;
            this.bttApagar.Text = "APAGAR";
            this.bttApagar.UseVisualStyleBackColor = false;
            // 
            // lbAluno
            // 
            this.lbAluno.AutoSize = true;
            this.lbAluno.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbAluno.Location = new System.Drawing.Point(26, 79);
            this.lbAluno.Name = "lbAluno";
            this.lbAluno.Size = new System.Drawing.Size(45, 17);
            this.lbAluno.TabIndex = 66;
            this.lbAluno.Text = "Aluno";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(87)))), ((int)(((byte)(174)))));
            this.lbTitle.Location = new System.Drawing.Point(24, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(174, 27);
            this.lbTitle.TabIndex = 64;
            this.lbTitle.Text = "Apagar Aluno";
            // 
            // ApagarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 224);
            this.Controls.Add(this.cbbTurma);
            this.Controls.Add(this.bttApagar);
            this.Controls.Add(this.lbAluno);
            this.Controls.Add(this.lbTitle);
            this.Name = "ApagarAluno";
            this.Text = "ApagarAluno";
            this.Load += new System.EventHandler(this.ApagarAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbTurma;
        private System.Windows.Forms.Button bttApagar;
        private System.Windows.Forms.Label lbAluno;
        private System.Windows.Forms.Label lbTitle;
    }
}