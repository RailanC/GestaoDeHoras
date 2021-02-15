
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCriar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApagar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoras = new System.Windows.Forms.ToolStripMenuItem();
            this.omACompensar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompensacao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTotalHCompensar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTotalHCompensacao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAluno,
            this.tsmiHoras,
            this.tsmiFerramentas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAluno
            // 
            this.tsmiAluno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCriar,
            this.tsmiApagar});
            this.tsmiAluno.Name = "tsmiAluno";
            this.tsmiAluno.Size = new System.Drawing.Size(51, 20);
            this.tsmiAluno.Text = "Aluno";
            // 
            // tsmiCriar
            // 
            this.tsmiCriar.Name = "tsmiCriar";
            this.tsmiCriar.Size = new System.Drawing.Size(180, 22);
            this.tsmiCriar.Text = "Criar";
            this.tsmiCriar.Click += new System.EventHandler(this.tsmiCriar_Click);
            // 
            // tsmiApagar
            // 
            this.tsmiApagar.Name = "tsmiApagar";
            this.tsmiApagar.Size = new System.Drawing.Size(180, 22);
            this.tsmiApagar.Text = "Apagar";
            // 
            // tsmiHoras
            // 
            this.tsmiHoras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omACompensar,
            this.tsmiCompensacao});
            this.tsmiHoras.Name = "tsmiHoras";
            this.tsmiHoras.Size = new System.Drawing.Size(50, 20);
            this.tsmiHoras.Text = "Horas";
            // 
            // omACompensar
            // 
            this.omACompensar.Name = "omACompensar";
            this.omACompensar.Size = new System.Drawing.Size(150, 22);
            this.omACompensar.Text = " A compensar";
            // 
            // tsmiCompensacao
            // 
            this.tsmiCompensacao.Name = "tsmiCompensacao";
            this.tsmiCompensacao.Size = new System.Drawing.Size(150, 22);
            this.tsmiCompensacao.Text = "Compensação";
            // 
            // tsmiFerramentas
            // 
            this.tsmiFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTotalHCompensar,
            this.tsmiTotalHCompensacao});
            this.tsmiFerramentas.Name = "tsmiFerramentas";
            this.tsmiFerramentas.Size = new System.Drawing.Size(84, 20);
            this.tsmiFerramentas.Text = "Ferramentas";
            // 
            // tsmiTotalHCompensar
            // 
            this.tsmiTotalHCompensar.Name = "tsmiTotalHCompensar";
            this.tsmiTotalHCompensar.Size = new System.Drawing.Size(223, 22);
            this.tsmiTotalHCompensar.Text = "Total de horas a compensar";
            // 
            // tsmiTotalHCompensacao
            // 
            this.tsmiTotalHCompensacao.Name = "tsmiTotalHCompensacao";
            this.tsmiTotalHCompensacao.Size = new System.Drawing.Size(223, 22);
            this.tsmiTotalHCompensacao.Text = "Total de horas compensadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(960, 533);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAluno;
        private System.Windows.Forms.ToolStripMenuItem tsmiCriar;
        private System.Windows.Forms.ToolStripMenuItem tsmiApagar;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoras;
        private System.Windows.Forms.ToolStripMenuItem omACompensar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompensacao;
        private System.Windows.Forms.ToolStripMenuItem tsmiFerramentas;
        private System.Windows.Forms.ToolStripMenuItem tsmiTotalHCompensar;
        private System.Windows.Forms.ToolStripMenuItem tsmiTotalHCompensacao;
    }
}

