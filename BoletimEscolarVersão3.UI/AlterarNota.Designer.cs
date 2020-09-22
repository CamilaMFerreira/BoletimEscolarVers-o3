namespace BoletimEscolarVersão3.UI
{
    partial class AlterarNota
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
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_aluno = new System.Windows.Forms.ComboBox();
            this.cb_materia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_curso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(119, 262);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(220, 20);
            this.txt_nota.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F);
            this.label6.Location = new System.Drawing.Point(17, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nota :";
            // 
            // cb_aluno
            // 
            this.cb_aluno.FormattingEnabled = true;
            this.cb_aluno.Location = new System.Drawing.Point(119, 211);
            this.cb_aluno.Name = "cb_aluno";
            this.cb_aluno.Size = new System.Drawing.Size(220, 21);
            this.cb_aluno.TabIndex = 13;
            // 
            // cb_materia
            // 
            this.cb_materia.FormattingEnabled = true;
            this.cb_materia.Location = new System.Drawing.Point(119, 160);
            this.cb_materia.Name = "cb_materia";
            this.cb_materia.Size = new System.Drawing.Size(220, 21);
            this.cb_materia.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F);
            this.label5.Location = new System.Drawing.Point(17, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Aluno :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F);
            this.label4.Location = new System.Drawing.Point(17, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Materia :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alterar Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Escola Padawan 2.0";
            // 
            // cb_curso
            // 
            this.cb_curso.FormattingEnabled = true;
            this.cb_curso.Location = new System.Drawing.Point(119, 113);
            this.cb_curso.Name = "cb_curso";
            this.cb_curso.Size = new System.Drawing.Size(220, 21);
            this.cb_curso.TabIndex = 15;
            this.cb_curso.SelectedIndexChanged += new System.EventHandler(this.cb_curso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(17, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Curso :";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_alterar.Location = new System.Drawing.Point(148, 317);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(128, 36);
            this.btn_alterar.TabIndex = 17;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_voltar.Location = new System.Drawing.Point(20, 357);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(65, 32);
            this.btn_voltar.TabIndex = 18;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // AlterarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 402);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_aluno);
            this.Controls.Add(this.cb_materia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_curso);
            this.Controls.Add(this.label1);
            this.Name = "AlterarNota";
            this.Text = "AlterarNota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_aluno;
        private System.Windows.Forms.ComboBox cb_materia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_voltar;
    }
}