﻿namespace BoletimEscolarVersão3Visual
{
    partial class CadastroCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_situação = new System.Windows.Forms.ComboBox();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(12, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Escola Padawan 2.0";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(139, 108);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(259, 23);
            this.txt_nome.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Situação:";
            // 
            // cb_situação
            // 
            this.cb_situação.FormattingEnabled = true;
            this.cb_situação.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cb_situação.Location = new System.Drawing.Point(139, 166);
            this.cb_situação.Name = "cb_situação";
            this.cb_situação.Size = new System.Drawing.Size(259, 23);
            this.cb_situação.TabIndex = 3;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastro.Location = new System.Drawing.Point(152, 228);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(149, 50);
            this.btn_cadastro.TabIndex = 4;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_voltar.Location = new System.Drawing.Point(12, 309);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(69, 28);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir.Location = new System.Drawing.Point(360, 309);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(69, 28);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(12, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Curso";
            // 
            // CadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 349);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.cb_situação);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCurso";
            this.Text = "CadastroCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_situação;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label label5;
    }
}