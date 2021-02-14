
namespace GestaoDeHoras
{
    partial class HomeAluno
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbFaltasC = new System.Windows.Forms.Label();
            this.lbFaltasF = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(80)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(232, 542);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbFaltasC
            // 
            this.lbFaltasC.AutoSize = true;
            this.lbFaltasC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbFaltasC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbFaltasC.Location = new System.Drawing.Point(20, 32);
            this.lbFaltasC.Name = "lbFaltasC";
            this.lbFaltasC.Size = new System.Drawing.Size(69, 17);
            this.lbFaltasC.TabIndex = 34;
            this.lbFaltasC.Text = "Username";
            // 
            // lbFaltasF
            // 
            this.lbFaltasF.AutoSize = true;
            this.lbFaltasF.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbFaltasF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbFaltasF.Location = new System.Drawing.Point(281, 32);
            this.lbFaltasF.Name = "lbFaltasF";
            this.lbFaltasF.Size = new System.Drawing.Size(69, 17);
            this.lbFaltasF.TabIndex = 36;
            this.lbFaltasF.Text = "Username";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(80)))));
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(284, 52);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(232, 542);
            this.listView2.TabIndex = 35;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // HomeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.lbFaltasF);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.lbFaltasC);
            this.Controls.Add(this.listView1);
            this.Name = "HomeAluno";
            this.Size = new System.Drawing.Size(991, 609);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbFaltasC;
        private System.Windows.Forms.Label lbFaltasF;
        private System.Windows.Forms.ListView listView2;
    }
}
