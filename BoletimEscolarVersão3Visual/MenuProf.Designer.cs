namespace BoletimEscolarVersão3Visual
{
    partial class MenuProf
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
            this.btn_cadnota = new System.Windows.Forms.Button();
            this.btn_alterarnota = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escola Padawan 2.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Área do professor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_cadnota
            // 
            this.btn_cadnota.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cadnota.Location = new System.Drawing.Point(100, 131);
            this.btn_cadnota.Name = "btn_cadnota";
            this.btn_cadnota.Size = new System.Drawing.Size(186, 56);
            this.btn_cadnota.TabIndex = 1;
            this.btn_cadnota.Text = "Cadastrar Nota";
            this.btn_cadnota.UseVisualStyleBackColor = true;
            // 
            // btn_alterarnota
            // 
            this.btn_alterarnota.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_alterarnota.Location = new System.Drawing.Point(100, 242);
            this.btn_alterarnota.Name = "btn_alterarnota";
            this.btn_alterarnota.Size = new System.Drawing.Size(186, 56);
            this.btn_alterarnota.TabIndex = 1;
            this.btn_alterarnota.Text = "Alterar Nota";
            this.btn_alterarnota.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_voltar.Location = new System.Drawing.Point(12, 349);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(78, 31);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // MenuProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 405);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_alterarnota);
            this.Controls.Add(this.btn_cadnota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuProf";
            this.Text = "MenuProf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cadnota;
        private System.Windows.Forms.Button btn_alterarnota;
        private System.Windows.Forms.Button btn_voltar;
    }
}