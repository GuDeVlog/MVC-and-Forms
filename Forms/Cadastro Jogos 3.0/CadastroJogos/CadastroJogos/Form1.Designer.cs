namespace CadastroJogos
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
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDataAquisicao = new System.Windows.Forms.TextBox();
            this.txtCPUID = new System.Windows.Forms.TextBox();
            this.txtValorLocacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(140, 230);
            this.txtResumo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(650, 124);
            this.txtResumo.TabIndex = 64;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(490, 172);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 34);
            this.button3.TabIndex = 62;
            this.button3.Text = "Exclui";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 172);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 34);
            this.button2.TabIndex = 61;
            this.button2.Text = "Altera";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDataAquisicao
            // 
            this.txtDataAquisicao.Location = new System.Drawing.Point(794, 86);
            this.txtDataAquisicao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataAquisicao.Name = "txtDataAquisicao";
            this.txtDataAquisicao.Size = new System.Drawing.Size(91, 20);
            this.txtDataAquisicao.TabIndex = 60;
            // 
            // txtCPUID
            // 
            this.txtCPUID.Location = new System.Drawing.Point(614, 86);
            this.txtCPUID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPUID.Name = "txtCPUID";
            this.txtCPUID.Size = new System.Drawing.Size(124, 20);
            this.txtCPUID.TabIndex = 59;
            // 
            // txtValorLocacao
            // 
            this.txtValorLocacao.Location = new System.Drawing.Point(512, 86);
            this.txtValorLocacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorLocacao.Name = "txtValorLocacao";
            this.txtValorLocacao.Size = new System.Drawing.Size(91, 20);
            this.txtValorLocacao.TabIndex = 58;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(215, 86);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 20);
            this.txtNome.TabIndex = 57;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 172);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 34);
            this.button4.TabIndex = 56;
            this.button4.Text = "Inserir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(84, 86);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 20);
            this.txtCodigo.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Valor da Locação";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(611, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "CPUID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(791, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "DataAquisição";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(666, 172);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 34);
            this.button5.TabIndex = 71;
            this.button5.Text = "Consultar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(969, 441);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDataAquisicao);
            this.Controls.Add(this.txtCPUID);
            this.Controls.Add(this.txtValorLocacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDataAquisicao;
        private System.Windows.Forms.TextBox txtCPUID;
        private System.Windows.Forms.TextBox txtValorLocacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
    }
}

