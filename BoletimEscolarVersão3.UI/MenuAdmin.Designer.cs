namespace BoletimEscolarVersão3.UI
{
    partial class MenuAdmin
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
            this.btn_cadaluno = new System.Windows.Forms.Button();
            this.btn_cadcurso = new System.Windows.Forms.Button();
            this.btn_cadmateria = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cadaluno
            // 
            this.btn_cadaluno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cadaluno.Location = new System.Drawing.Point(96, 110);
            this.btn_cadaluno.Name = "btn_cadaluno";
            this.btn_cadaluno.Size = new System.Drawing.Size(234, 47);
            this.btn_cadaluno.TabIndex = 0;
            this.btn_cadaluno.Text = "Aluno";
            this.btn_cadaluno.UseVisualStyleBackColor = true;
            this.btn_cadaluno.Click += new System.EventHandler(this.btn_cadaluno_Click);
            // 
            // btn_cadcurso
            // 
            this.btn_cadcurso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cadcurso.Location = new System.Drawing.Point(96, 206);
            this.btn_cadcurso.Name = "btn_cadcurso";
            this.btn_cadcurso.Size = new System.Drawing.Size(234, 47);
            this.btn_cadcurso.TabIndex = 0;
            this.btn_cadcurso.Text = "Curso";
            this.btn_cadcurso.UseVisualStyleBackColor = true;
            this.btn_cadcurso.Click += new System.EventHandler(this.btn_cadcurso_Click);
            // 
            // btn_cadmateria
            // 
            this.btn_cadmateria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cadmateria.Location = new System.Drawing.Point(96, 310);
            this.btn_cadmateria.Name = "btn_cadmateria";
            this.btn_cadmateria.Size = new System.Drawing.Size(234, 47);
            this.btn_cadmateria.TabIndex = 0;
            this.btn_cadmateria.Text = "Matéria";
            this.btn_cadmateria.UseVisualStyleBackColor = true;
            this.btn_cadmateria.Click += new System.EventHandler(this.btn_cadmateria_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_voltar.Location = new System.Drawing.Point(12, 409);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(85, 29);
            this.btn_voltar.TabIndex = 0;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escola Padawan 2.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cadmateria);
            this.Controls.Add(this.btn_cadcurso);
            this.Controls.Add(this.btn_cadaluno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadaluno;
        private System.Windows.Forms.Button btn_cadcurso;
        private System.Windows.Forms.Button btn_cadmateria;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
    }
}