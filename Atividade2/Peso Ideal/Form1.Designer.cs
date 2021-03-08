
namespace Peso_Ideal
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_calcular = new System.Windows.Forms.Button();
            this.text_altura = new System.Windows.Forms.TextBox();
            this.text_peso_atual = new System.Windows.Forms.TextBox();
            this.radio_homem = new System.Windows.Forms.RadioButton();
            this.radio_mulher = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_calcular
            // 
            this.cmd_calcular.Location = new System.Drawing.Point(177, 284);
            this.cmd_calcular.Name = "cmd_calcular";
            this.cmd_calcular.Size = new System.Drawing.Size(154, 54);
            this.cmd_calcular.TabIndex = 0;
            this.cmd_calcular.Text = "CALCULAR";
            this.cmd_calcular.UseVisualStyleBackColor = true;
            this.cmd_calcular.Click += new System.EventHandler(this.cmd_calcular_Click);
            // 
            // text_altura
            // 
            this.text_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_altura.Location = new System.Drawing.Point(91, 204);
            this.text_altura.Name = "text_altura";
            this.text_altura.Size = new System.Drawing.Size(114, 29);
            this.text_altura.TabIndex = 1;
            this.text_altura.TextChanged += new System.EventHandler(this.text_altura_TextChanged);
            // 
            // text_peso_atual
            // 
            this.text_peso_atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_peso_atual.Location = new System.Drawing.Point(306, 204);
            this.text_peso_atual.Name = "text_peso_atual";
            this.text_peso_atual.Size = new System.Drawing.Size(121, 29);
            this.text_peso_atual.TabIndex = 2;
            // 
            // radio_homem
            // 
            this.radio_homem.AutoSize = true;
            this.radio_homem.Checked = true;
            this.radio_homem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_homem.Location = new System.Drawing.Point(100, 135);
            this.radio_homem.Name = "radio_homem";
            this.radio_homem.Size = new System.Drawing.Size(88, 24);
            this.radio_homem.TabIndex = 3;
            this.radio_homem.TabStop = true;
            this.radio_homem.Text = "HOMEM";
            this.radio_homem.UseVisualStyleBackColor = true;
            // 
            // radio_mulher
            // 
            this.radio_mulher.AutoSize = true;
            this.radio_mulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_mulher.Location = new System.Drawing.Point(315, 135);
            this.radio_mulher.Name = "radio_mulher";
            this.radio_mulher.Size = new System.Drawing.Size(96, 24);
            this.radio_mulher.TabIndex = 4;
            this.radio_mulher.Text = "MULHER";
            this.radio_mulher.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "CÁLCULO DO PESO IDEAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Altura (metros):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Peso atual (Kg.):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_mulher);
            this.Controls.Add(this.radio_homem);
            this.Controls.Add(this.text_peso_atual);
            this.Controls.Add(this.text_altura);
            this.Controls.Add(this.cmd_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_calcular;
        private System.Windows.Forms.TextBox text_altura;
        private System.Windows.Forms.TextBox text_peso_atual;
        private System.Windows.Forms.RadioButton radio_homem;
        private System.Windows.Forms.RadioButton radio_mulher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

