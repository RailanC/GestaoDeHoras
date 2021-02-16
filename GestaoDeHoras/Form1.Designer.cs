
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch_Aluno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Sigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Trimestre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_QuantH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_HoraInicC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_HoraFinC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_DataC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tsmiApagar.Click += new System.EventHandler(this.tsmiApagar_Click);
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
            this.omACompensar.Click += new System.EventHandler(this.omACompensar_Click);
            // 
            // tsmiCompensacao
            // 
            this.tsmiCompensacao.Name = "tsmiCompensacao";
            this.tsmiCompensacao.Size = new System.Drawing.Size(150, 22);
            this.tsmiCompensacao.Text = "Compensação";
            this.tsmiCompensacao.Click += new System.EventHandler(this.tsmiCompensacao_Click);
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
            this.tsmiTotalHCompensar.Size = new System.Drawing.Size(224, 22);
            this.tsmiTotalHCompensar.Text = "Total de horas a compensar";
            // 
            // tsmiTotalHCompensacao
            // 
            this.tsmiTotalHCompensacao.Name = "tsmiTotalHCompensacao";
            this.tsmiTotalHCompensacao.Size = new System.Drawing.Size(224, 22);
            this.tsmiTotalHCompensacao.Text = "Total de horas compensadas";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Aluno,
            this.ch_Sigla,
            this.ch_Trimestre,
            this.ch_QuantH,
            this.ch_HoraInicC,
            this.ch_HoraFinC,
            this.ch_DataC});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(936, 484);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ch_Aluno
            // 
            this.ch_Aluno.Text = "Aluno";
            // 
            // ch_Sigla
            // 
            this.ch_Sigla.Text = "Sigla";
            // 
            // ch_Trimestre
            // 
            this.ch_Trimestre.Text = "Trimestre";
            this.ch_Trimestre.Width = 75;
            // 
            // ch_QuantH
            // 
            this.ch_QuantH.Text = "QuantH";
            this.ch_QuantH.Width = 66;
            // 
            // ch_HoraInicC
            // 
            this.ch_HoraInicC.Text = "HoraInicC";
            this.ch_HoraInicC.Width = 78;
            // 
            // ch_HoraFinC
            // 
            this.ch_HoraFinC.Text = "HoraFinC";
            this.ch_HoraFinC.Width = 78;
            // 
            // ch_DataC
            // 
            this.ch_DataC.Text = "DataC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(960, 533);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ch_Aluno;
        private System.Windows.Forms.ColumnHeader ch_Sigla;
        private System.Windows.Forms.ColumnHeader ch_Trimestre;
        private System.Windows.Forms.ColumnHeader ch_QuantH;
        private System.Windows.Forms.ColumnHeader ch_HoraInicC;
        private System.Windows.Forms.ColumnHeader ch_HoraFinC;
        private System.Windows.Forms.ColumnHeader ch_DataC;
    }
}

