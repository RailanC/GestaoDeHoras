namespace GestaoDeHoras
{
    partial class CompensacaoHoras
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
            this.lbl_CompensacaoH = new System.Windows.Forms.Label();
            this.nud_MI = new System.Windows.Forms.NumericUpDown();
            this.lbl_MI = new System.Windows.Forms.Label();
            this.nud_MF = new System.Windows.Forms.NumericUpDown();
            this.lbl_MF = new System.Windows.Forms.Label();
            this.nud_HI = new System.Windows.Forms.NumericUpDown();
            this.lbl_HI = new System.Windows.Forms.Label();
            this.nud_HF = new System.Windows.Forms.NumericUpDown();
            this.lbl_HF = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_Trimestre = new System.Windows.Forms.Label();
            this.lbl_Disciplina = new System.Windows.Forms.Label();
            this.cb_Trimestre = new System.Windows.Forms.ComboBox();
            this.cb_Disciplina = new System.Windows.Forms.ComboBox();
            this.lv_Alunos = new System.Windows.Forms.ListView();
            this.ch_Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_Turmas = new System.Windows.Forms.ListBox();
            this.btn_Submeter = new System.Windows.Forms.Button();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HF)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CompensacaoH
            // 
            this.lbl_CompensacaoH.AutoSize = true;
            this.lbl_CompensacaoH.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompensacaoH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(87)))), ((int)(((byte)(174)))));
            this.lbl_CompensacaoH.Location = new System.Drawing.Point(24, 28);
            this.lbl_CompensacaoH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CompensacaoH.Name = "lbl_CompensacaoH";
            this.lbl_CompensacaoH.Size = new System.Drawing.Size(261, 27);
            this.lbl_CompensacaoH.TabIndex = 98;
            this.lbl_CompensacaoH.Text = "Compensação Horas";
            // 
            // nud_MI
            // 
            this.nud_MI.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.nud_MI.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_MI.Location = new System.Drawing.Point(30, 367);
            this.nud_MI.Margin = new System.Windows.Forms.Padding(4);
            this.nud_MI.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_MI.Name = "nud_MI";
            this.nud_MI.Size = new System.Drawing.Size(84, 23);
            this.nud_MI.TabIndex = 115;
            // 
            // lbl_MI
            // 
            this.lbl_MI.AutoSize = true;
            this.lbl_MI.Enabled = false;
            this.lbl_MI.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_MI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_MI.Location = new System.Drawing.Point(26, 346);
            this.lbl_MI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MI.Name = "lbl_MI";
            this.lbl_MI.Size = new System.Drawing.Size(97, 17);
            this.lbl_MI.TabIndex = 114;
            this.lbl_MI.Text = "Minutos Inicio";
            // 
            // nud_MF
            // 
            this.nud_MF.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.nud_MF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_MF.Location = new System.Drawing.Point(425, 367);
            this.nud_MF.Margin = new System.Windows.Forms.Padding(4);
            this.nud_MF.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_MF.Name = "nud_MF";
            this.nud_MF.Size = new System.Drawing.Size(84, 23);
            this.nud_MF.TabIndex = 113;
            // 
            // lbl_MF
            // 
            this.lbl_MF.AutoSize = true;
            this.lbl_MF.Enabled = false;
            this.lbl_MF.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_MF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_MF.Location = new System.Drawing.Point(423, 346);
            this.lbl_MF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MF.Name = "lbl_MF";
            this.lbl_MF.Size = new System.Drawing.Size(86, 17);
            this.lbl_MF.TabIndex = 112;
            this.lbl_MF.Text = "Minutos Fim";
            // 
            // nud_HI
            // 
            this.nud_HI.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.nud_HI.Location = new System.Drawing.Point(30, 316);
            this.nud_HI.Margin = new System.Windows.Forms.Padding(4);
            this.nud_HI.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nud_HI.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_HI.Name = "nud_HI";
            this.nud_HI.Size = new System.Drawing.Size(84, 23);
            this.nud_HI.TabIndex = 111;
            this.nud_HI.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbl_HI
            // 
            this.lbl_HI.AutoSize = true;
            this.lbl_HI.Enabled = false;
            this.lbl_HI.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_HI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_HI.Location = new System.Drawing.Point(26, 295);
            this.lbl_HI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HI.Name = "lbl_HI";
            this.lbl_HI.Size = new System.Drawing.Size(79, 17);
            this.lbl_HI.TabIndex = 110;
            this.lbl_HI.Text = "Hora Inicial";
            // 
            // nud_HF
            // 
            this.nud_HF.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.nud_HF.Location = new System.Drawing.Point(425, 316);
            this.nud_HF.Margin = new System.Windows.Forms.Padding(4);
            this.nud_HF.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nud_HF.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_HF.Name = "nud_HF";
            this.nud_HF.Size = new System.Drawing.Size(84, 23);
            this.nud_HF.TabIndex = 109;
            this.nud_HF.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbl_HF
            // 
            this.lbl_HF.AutoSize = true;
            this.lbl_HF.Enabled = false;
            this.lbl_HF.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_HF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_HF.Location = new System.Drawing.Point(437, 295);
            this.lbl_HF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HF.Name = "lbl_HF";
            this.lbl_HF.Size = new System.Drawing.Size(72, 17);
            this.lbl_HF.TabIndex = 108;
            this.lbl_HF.Text = "Hora Final";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_Data.Location = new System.Drawing.Point(472, 249);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(37, 17);
            this.lbl_Data.TabIndex = 123;
            this.lbl_Data.Text = "Data";
            // 
            // lbl_Trimestre
            // 
            this.lbl_Trimestre.AutoSize = true;
            this.lbl_Trimestre.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Trimestre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_Trimestre.Location = new System.Drawing.Point(26, 249);
            this.lbl_Trimestre.Name = "lbl_Trimestre";
            this.lbl_Trimestre.Size = new System.Drawing.Size(66, 17);
            this.lbl_Trimestre.TabIndex = 122;
            this.lbl_Trimestre.Text = "Trimestre";
            // 
            // lbl_Disciplina
            // 
            this.lbl_Disciplina.AutoSize = true;
            this.lbl_Disciplina.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Disciplina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_Disciplina.Location = new System.Drawing.Point(26, 203);
            this.lbl_Disciplina.Name = "lbl_Disciplina";
            this.lbl_Disciplina.Size = new System.Drawing.Size(69, 17);
            this.lbl_Disciplina.TabIndex = 121;
            this.lbl_Disciplina.Text = "Disciplina";
            // 
            // cb_Trimestre
            // 
            this.cb_Trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Trimestre.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cb_Trimestre.FormattingEnabled = true;
            this.cb_Trimestre.Location = new System.Drawing.Point(29, 269);
            this.cb_Trimestre.Name = "cb_Trimestre";
            this.cb_Trimestre.Size = new System.Drawing.Size(222, 23);
            this.cb_Trimestre.TabIndex = 120;
            // 
            // cb_Disciplina
            // 
            this.cb_Disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Disciplina.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cb_Disciplina.FormattingEnabled = true;
            this.cb_Disciplina.Location = new System.Drawing.Point(29, 223);
            this.cb_Disciplina.Name = "cb_Disciplina";
            this.cb_Disciplina.Size = new System.Drawing.Size(480, 23);
            this.cb_Disciplina.TabIndex = 118;
            this.cb_Disciplina.SelectedIndexChanged += new System.EventHandler(this.cb_Disciplina_SelectedIndexChanged);
            // 
            // lv_Alunos
            // 
            this.lv_Alunos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Numero,
            this.ch_Nome});
            this.lv_Alunos.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lv_Alunos.HideSelection = false;
            this.lv_Alunos.Location = new System.Drawing.Point(281, 58);
            this.lv_Alunos.Name = "lv_Alunos";
            this.lv_Alunos.Size = new System.Drawing.Size(228, 139);
            this.lv_Alunos.TabIndex = 117;
            this.lv_Alunos.UseCompatibleStateImageBehavior = false;
            this.lv_Alunos.View = System.Windows.Forms.View.Details;
            this.lv_Alunos.SelectedIndexChanged += new System.EventHandler(this.lv_Alunos_SelectedIndexChanged);
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
            this.lb_Turmas.Location = new System.Drawing.Point(29, 58);
            this.lb_Turmas.Name = "lb_Turmas";
            this.lb_Turmas.Size = new System.Drawing.Size(222, 139);
            this.lb_Turmas.TabIndex = 116;
            this.lb_Turmas.SelectedIndexChanged += new System.EventHandler(this.lb_Turmas_SelectedIndexChanged);
            // 
            // btn_Submeter
            // 
            this.btn_Submeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Submeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submeter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Submeter.ForeColor = System.Drawing.Color.White;
            this.btn_Submeter.Location = new System.Drawing.Point(30, 416);
            this.btn_Submeter.Name = "btn_Submeter";
            this.btn_Submeter.Size = new System.Drawing.Size(214, 32);
            this.btn_Submeter.TabIndex = 124;
            this.btn_Submeter.Text = "SUBMETER";
            this.btn_Submeter.UseVisualStyleBackColor = false;
            this.btn_Submeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // dtp_Data
            // 
            this.dtp_Data.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Data.Location = new System.Drawing.Point(281, 269);
            this.dtp_Data.MaxDate = new System.DateTime(2020, 10, 21, 0, 0, 0, 0);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(228, 23);
            this.dtp_Data.TabIndex = 125;
            this.dtp_Data.Value = new System.DateTime(2020, 10, 21, 0, 0, 0, 0);
            // 
            // CompensacaoHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 478);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.btn_Submeter);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.lbl_Trimestre);
            this.Controls.Add(this.lbl_Disciplina);
            this.Controls.Add(this.cb_Trimestre);
            this.Controls.Add(this.cb_Disciplina);
            this.Controls.Add(this.lv_Alunos);
            this.Controls.Add(this.lb_Turmas);
            this.Controls.Add(this.nud_MI);
            this.Controls.Add(this.lbl_MI);
            this.Controls.Add(this.nud_MF);
            this.Controls.Add(this.lbl_MF);
            this.Controls.Add(this.nud_HI);
            this.Controls.Add(this.lbl_HI);
            this.Controls.Add(this.nud_HF);
            this.Controls.Add(this.lbl_HF);
            this.Controls.Add(this.lbl_CompensacaoH);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompensacaoHoras";
            this.Text = "CompensacaoHoras";
            this.Load += new System.EventHandler(this.CompensacaoHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_MI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_CompensacaoH;
        private System.Windows.Forms.NumericUpDown nud_MI;
        private System.Windows.Forms.Label lbl_MI;
        private System.Windows.Forms.NumericUpDown nud_MF;
        private System.Windows.Forms.Label lbl_MF;
        private System.Windows.Forms.NumericUpDown nud_HI;
        private System.Windows.Forms.Label lbl_HI;
        private System.Windows.Forms.NumericUpDown nud_HF;
        private System.Windows.Forms.Label lbl_HF;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_Trimestre;
        private System.Windows.Forms.Label lbl_Disciplina;
        private System.Windows.Forms.ComboBox cb_Trimestre;
        private System.Windows.Forms.ComboBox cb_Disciplina;
        private System.Windows.Forms.ListView lv_Alunos;
        private System.Windows.Forms.ColumnHeader ch_Numero;
        private System.Windows.Forms.ColumnHeader ch_Nome;
        private System.Windows.Forms.ListBox lb_Turmas;
        private System.Windows.Forms.Button btn_Submeter;
        private System.Windows.Forms.DateTimePicker dtp_Data;
    }
}