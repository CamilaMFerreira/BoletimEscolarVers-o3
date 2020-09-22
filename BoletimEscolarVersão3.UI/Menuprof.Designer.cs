namespace BoletimEscolarVersão3.UI
{
    partial class Menuprof
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
            this.label5 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_excluiraluno = new System.Windows.Forms.Button();
            this.btn_cadaluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Área do professor";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_voltar.Location = new System.Drawing.Point(132, 362);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(73, 25);
            this.btn_voltar.TabIndex = 8;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_excluiraluno
            // 
            this.btn_excluiraluno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_excluiraluno.Location = new System.Drawing.Point(69, 270);
            this.btn_excluiraluno.Name = "btn_excluiraluno";
            this.btn_excluiraluno.Size = new System.Drawing.Size(201, 41);
            this.btn_excluiraluno.TabIndex = 9;
            this.btn_excluiraluno.Text = "Excluir";
            this.btn_excluiraluno.UseVisualStyleBackColor = true;
            this.btn_excluiraluno.Click += new System.EventHandler(this.btn_excluiraluno_Click);
            // 
            // btn_cadaluno
            // 
            this.btn_cadaluno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cadaluno.Location = new System.Drawing.Point(69, 122);
            this.btn_cadaluno.Name = "btn_cadaluno";
            this.btn_cadaluno.Size = new System.Drawing.Size(201, 41);
            this.btn_cadaluno.TabIndex = 10;
            this.btn_cadaluno.Text = "Cadastrar";
            this.btn_cadaluno.UseVisualStyleBackColor = true;
            this.btn_cadaluno.Click += new System.EventHandler(this.btn_cadaluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escola Padawan 2.0";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_alterar.Location = new System.Drawing.Point(69, 194);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(201, 41);
            this.btn_alterar.TabIndex = 12;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // Menuprof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 431);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluiraluno);
            this.Controls.Add(this.btn_cadaluno);
            this.Controls.Add(this.label1);
            this.Name = "Menuprof";
            this.Text = "Menuprof";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_excluiraluno;
        private System.Windows.Forms.Button btn_cadaluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_alterar;
    }
}