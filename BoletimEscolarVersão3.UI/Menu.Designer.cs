namespace BoletimEscolarVersão3.UI
{
    partial class Menu
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aluno = new System.Windows.Forms.Button();
            this.btn_professor = new System.Windows.Forms.Button();
            this.btn_administrador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(77, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escola Padawan 2.0";
            // 
            // btn_aluno
            // 
            this.btn_aluno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_aluno.Location = new System.Drawing.Point(24, 162);
            this.btn_aluno.Name = "btn_aluno";
            this.btn_aluno.Size = new System.Drawing.Size(177, 36);
            this.btn_aluno.TabIndex = 5;
            this.btn_aluno.Text = "Aluno";
            this.btn_aluno.UseVisualStyleBackColor = true;
            this.btn_aluno.Click += new System.EventHandler(this.btn_aluno_Click);
            // 
            // btn_professor
            // 
            this.btn_professor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_professor.Location = new System.Drawing.Point(472, 162);
            this.btn_professor.Name = "btn_professor";
            this.btn_professor.Size = new System.Drawing.Size(177, 36);
            this.btn_professor.TabIndex = 5;
            this.btn_professor.Text = "Professor";
            this.btn_professor.UseVisualStyleBackColor = true;
            this.btn_professor.Click += new System.EventHandler(this.btn_professor_Click);
            // 
            // btn_administrador
            // 
            this.btn_administrador.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_administrador.Location = new System.Drawing.Point(246, 162);
            this.btn_administrador.Name = "btn_administrador";
            this.btn_administrador.Size = new System.Drawing.Size(177, 36);
            this.btn_administrador.TabIndex = 5;
            this.btn_administrador.Text = "Administrador";
            this.btn_administrador.UseVisualStyleBackColor = true;
            this.btn_administrador.Click += new System.EventHandler(this.btn_administrador_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 272);
            this.Controls.Add(this.btn_administrador);
            this.Controls.Add(this.btn_professor);
            this.Controls.Add(this.btn_aluno);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aluno;
        private System.Windows.Forms.Button btn_professor;
        private System.Windows.Forms.Button btn_administrador;
    }
}

