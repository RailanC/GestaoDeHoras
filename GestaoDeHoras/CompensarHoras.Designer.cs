namespace GestaoDeHoras
{
    partial class CompensarHoras
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
            this.btn_Submeter = new System.Windows.Forms.Button();
            this.lbl_CompensarH = new System.Windows.Forms.Label();
            this.lv_Alunos = new System.Windows.Forms.ListView();
            this.ch_Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_Turmas = new System.Windows.Forms.ListBox();
            this.cb_Trimestre = new System.Windows.Forms.ComboBox();
            this.nud_HCompensar = new System.Windows.Forms.NumericUpDown();
            this.cb_Disciplina = new System.Windows.Forms.ComboBox();
            this.lbl_Disciplina = new System.Windows.Forms.Label();
            this.lbl_Trimestre = new System.Windows.Forms.Label();
            this.lbl_HCompensar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HCompensar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Submeter
            // 
            this.btn_Submeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Submeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submeter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Submeter.ForeColor = System.Drawing.Color.White;
            this.btn_Submeter.Location = new System.Drawing.Point(31, 319);
            this.btn_Submeter.Name = "btn_Submeter";
            this.btn_Submeter.Size = new System.Drawing.Size(214, 32);
            this.btn_Submeter.TabIndex = 71;
            this.btn_Submeter.Text = "SUBMETER";
            this.btn_Submeter.UseVisualStyleBackColor = false;
            this.btn_Submeter.Click += new System.EventHandler(this.btn_Submeter_Click);
            // 
            // lbl_CompensarH
            // 
            this.lbl_CompensarH.AutoSize = true;
            this.lbl_CompensarH.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompensarH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(87)))), ((int)(((byte)(174)))));
            this.lbl_CompensarH.Location = new System.Drawing.Point(24, 28);
            this.lbl_CompensarH.Name = "lbl_CompensarH";
            this.lbl_CompensarH.Size = new System.Drawing.Size(227, 27);
            this.lbl_CompensarH.TabIndex = 64;
            this.lbl_CompensarH.Text = "Compensar Horas";
            // 
            // lv_Alunos
            // 
            this.lv_Alunos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Numero,
            this.ch_Nome});
            this.lv_Alunos.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lv_Alunos.HideSelection = false;
            this.lv_Alunos.Location = new System.Drawing.Point(283, 58);
            this.lv_Alunos.Name = "lv_Alunos";
            this.lv_Alunos.Size = new System.Drawing.Size(228, 139);
            this.lv_Alunos.TabIndex = 82;
            this.lv_Alunos.UseCompatibleStateImageBehavior = false;
            this.lv_Alunos.View = System.Windows.Forms.View.Details;
            // 
            // ch_Numero
            // 
            this.ch_Numero.Text = "Número";
            // 
            // ch_Nome
            // 
            this.ch_Nome.Text = "Nome";
            this.ch_Nome.Width = 185;
            // 
            // lb_Turmas
            // 
            this.lb_Turmas.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lb_Turmas.FormattingEnabled = true;
            this.lb_Turmas.ItemHeight = 15;
            this.lb_Turmas.Location = new System.Drawing.Point(31, 58);
            this.lb_Turmas.Name = "lb_Turmas";
            this.lb_Turmas.Size = new System.Drawing.Size(222, 139);
            this.lb_Turmas.TabIndex = 81;
            this.lb_Turmas.SelectedIndexChanged += new System.EventHandler(this.lb_Turmas_SelectedIndexChanged);
            // 
            // cb_Trimestre
            // 
            this.cb_Trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Trimestre.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cb_Trimestre.FormattingEnabled = true;
            this.cb_Trimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_Trimestre.Location = new System.Drawing.Point(31, 269);
            this.cb_Trimestre.Name = "cb_Trimestre";
            this.cb_Trimestre.Size = new System.Drawing.Size(214, 23);
            this.cb_Trimestre.TabIndex = 94;
            // 
            // nud_HCompensar
            // 
            this.nud_HCompensar.DecimalPlaces = 1;
            this.nud_HCompensar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.nud_HCompensar.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_HCompensar.Location = new System.Drawing.Point(283, 269);
            this.nud_HCompensar.Name = "nud_HCompensar";
            this.nud_HCompensar.Size = new System.Drawing.Size(228, 23);
            this.nud_HCompensar.TabIndex = 93;
            // 
            // cb_Disciplina
            // 
            this.cb_Disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Disciplina.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cb_Disciplina.FormattingEnabled = true;
            this.cb_Disciplina.Items.AddRange(new object[] {
            "PT",
            "MAT",
            "ING",
            "SI",
            "FQ",
            "RC",
            "SO",
            "AI",
            "EF"});
            this.cb_Disciplina.Location = new System.Drawing.Point(31, 223);
            this.cb_Disciplina.Name = "cb_Disciplina";
            this.cb_Disciplina.Size = new System.Drawing.Size(480, 23);
            this.cb_Disciplina.TabIndex = 92;
            // 
            // lbl_Disciplina
            // 
            this.lbl_Disciplina.AutoSize = true;
            this.lbl_Disciplina.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Disciplina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_Disciplina.Location = new System.Drawing.Point(28, 203);
            this.lbl_Disciplina.Name = "lbl_Disciplina";
            this.lbl_Disciplina.Size = new System.Drawing.Size(69, 17);
            this.lbl_Disciplina.TabIndex = 95;
            this.lbl_Disciplina.Text = "Disciplina";
            // 
            // lbl_Trimestre
            // 
            this.lbl_Trimestre.AutoSize = true;
            this.lbl_Trimestre.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Trimestre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_Trimestre.Location = new System.Drawing.Point(28, 249);
            this.lbl_Trimestre.Name = "lbl_Trimestre";
            this.lbl_Trimestre.Size = new System.Drawing.Size(66, 17);
            this.lbl_Trimestre.TabIndex = 96;
            this.lbl_Trimestre.Text = "Trimestre";
            // 
            // lbl_HCompensar
            // 
            this.lbl_HCompensar.AutoSize = true;
            this.lbl_HCompensar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_HCompensar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_HCompensar.Location = new System.Drawing.Point(383, 249);
            this.lbl_HCompensar.Name = "lbl_HCompensar";
            this.lbl_HCompensar.Size = new System.Drawing.Size(128, 17);
            this.lbl_HCompensar.TabIndex = 97;
            this.lbl_HCompensar.Text = "Horas a Compensar";
            // 
            // CompensarHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 380);
            this.Controls.Add(this.lbl_HCompensar);
            this.Controls.Add(this.lbl_Trimestre);
            this.Controls.Add(this.lbl_Disciplina);
            this.Controls.Add(this.cb_Trimestre);
            this.Controls.Add(this.nud_HCompensar);
            this.Controls.Add(this.cb_Disciplina);
            this.Controls.Add(this.lv_Alunos);
            this.Controls.Add(this.lb_Turmas);
            this.Controls.Add(this.btn_Submeter);
            this.Controls.Add(this.lbl_CompensarH);
            this.Name = "CompensarHoras";
            this.Text = "CompensarHoras";
            this.Load += new System.EventHandler(this.CompensarHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_HCompensar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Submeter;
        private System.Windows.Forms.Label lbl_CompensarH;
        private System.Windows.Forms.ListView lv_Alunos;
        private System.Windows.Forms.ColumnHeader ch_Numero;
        private System.Windows.Forms.ColumnHeader ch_Nome;
        private System.Windows.Forms.ListBox lb_Turmas;
        private System.Windows.Forms.ComboBox cb_Trimestre;
        private System.Windows.Forms.NumericUpDown nud_HCompensar;
        private System.Windows.Forms.ComboBox cb_Disciplina;
        private System.Windows.Forms.Label lbl_Disciplina;
        private System.Windows.Forms.Label lbl_Trimestre;
        private System.Windows.Forms.Label lbl_HCompensar;
    }
}