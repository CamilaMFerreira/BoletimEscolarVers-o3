namespace BoletimEscolarVersão3Visual
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(125, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escola Padawan 2.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_aluno
            // 
            this.btn_aluno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aluno.Location = new System.Drawing.Point(28, 187);
            this.btn_aluno.Name = "btn_aluno";
            this.btn_aluno.Size = new System.Drawing.Size(206, 42);
            this.btn_aluno.TabIndex = 5;
            this.btn_aluno.Text = "Aluno";
            this.btn_aluno.UseVisualStyleBackColor = true;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastro.Location = new System.Drawing.Point(551, 187);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(206, 42);
            this.btn_cadastro.TabIndex = 5;
            this.btn_cadastro.Text = "Professor";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(287, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Administrador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cadastro);
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
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button button1;
    }
}

