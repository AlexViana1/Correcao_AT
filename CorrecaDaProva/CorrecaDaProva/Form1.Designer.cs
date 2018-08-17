namespace CorrecaDaProva
{
    partial class Form1
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
            this.lbRodada = new System.Windows.Forms.Label();
            this.lbVitorias = new System.Windows.Forms.Label();
            this.lbEmpates = new System.Windows.Forms.Label();
            this.btPedra = new System.Windows.Forms.Button();
            this.btPapel = new System.Windows.Forms.Button();
            this.btTesoura = new System.Windows.Forms.Button();
            this.rbResultado = new System.Windows.Forms.RichTextBox();
            this.btJogar = new System.Windows.Forms.Button();
            this.btDescelecionar = new System.Windows.Forms.Button();
            this.btReinicar = new System.Windows.Forms.Button();
            this.lbJogadaSelecionada = new System.Windows.Forms.Label();
            this.lbDerrotas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRodada
            // 
            this.lbRodada.AutoSize = true;
            this.lbRodada.Location = new System.Drawing.Point(13, 28);
            this.lbRodada.Name = "lbRodada";
            this.lbRodada.Size = new System.Drawing.Size(51, 13);
            this.lbRodada.TabIndex = 0;
            this.lbRodada.Text = "Rodada1";
            // 
            // lbVitorias
            // 
            this.lbVitorias.AutoSize = true;
            this.lbVitorias.Location = new System.Drawing.Point(13, 61);
            this.lbVitorias.Name = "lbVitorias";
            this.lbVitorias.Size = new System.Drawing.Size(50, 13);
            this.lbVitorias.TabIndex = 1;
            this.lbVitorias.Text = "Vitórias:0";
            // 
            // lbEmpates
            // 
            this.lbEmpates.AutoSize = true;
            this.lbEmpates.Location = new System.Drawing.Point(13, 95);
            this.lbEmpates.Name = "lbEmpates";
            this.lbEmpates.Size = new System.Drawing.Size(57, 13);
            this.lbEmpates.TabIndex = 2;
            this.lbEmpates.Text = "Empates:0";
            // 
            // btPedra
            // 
            this.btPedra.Location = new System.Drawing.Point(12, 156);
            this.btPedra.Name = "btPedra";
            this.btPedra.Size = new System.Drawing.Size(75, 23);
            this.btPedra.TabIndex = 4;
            this.btPedra.Text = "Pedra";
            this.btPedra.UseVisualStyleBackColor = true;
            this.btPedra.Click += new System.EventHandler(this.btPedra_Click);
            // 
            // btPapel
            // 
            this.btPapel.Location = new System.Drawing.Point(93, 156);
            this.btPapel.Name = "btPapel";
            this.btPapel.Size = new System.Drawing.Size(124, 23);
            this.btPapel.TabIndex = 5;
            this.btPapel.Text = "Papel";
            this.btPapel.UseVisualStyleBackColor = true;
            this.btPapel.Click += new System.EventHandler(this.btPapel_Click);
            // 
            // btTesoura
            // 
            this.btTesoura.Location = new System.Drawing.Point(223, 156);
            this.btTesoura.Name = "btTesoura";
            this.btTesoura.Size = new System.Drawing.Size(75, 23);
            this.btTesoura.TabIndex = 6;
            this.btTesoura.Text = "Tesoura";
            this.btTesoura.UseVisualStyleBackColor = true;
            this.btTesoura.Click += new System.EventHandler(this.btTesoura_Click);
            // 
            // rbResultado
            // 
            this.rbResultado.Location = new System.Drawing.Point(16, 276);
            this.rbResultado.Name = "rbResultado";
            this.rbResultado.Size = new System.Drawing.Size(282, 96);
            this.rbResultado.TabIndex = 7;
            this.rbResultado.Text = "";
            // 
            // btJogar
            // 
            this.btJogar.Location = new System.Drawing.Point(16, 228);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(75, 23);
            this.btJogar.TabIndex = 8;
            this.btJogar.Text = "Jogar";
            this.btJogar.UseVisualStyleBackColor = true;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // btDescelecionar
            // 
            this.btDescelecionar.Location = new System.Drawing.Point(97, 228);
            this.btDescelecionar.Name = "btDescelecionar";
            this.btDescelecionar.Size = new System.Drawing.Size(120, 23);
            this.btDescelecionar.TabIndex = 9;
            this.btDescelecionar.Text = "Descelecionar Jogada";
            this.btDescelecionar.UseVisualStyleBackColor = true;
            this.btDescelecionar.Click += new System.EventHandler(this.btDescelecionar_Click);
            // 
            // btReinicar
            // 
            this.btReinicar.Location = new System.Drawing.Point(223, 228);
            this.btReinicar.Name = "btReinicar";
            this.btReinicar.Size = new System.Drawing.Size(75, 23);
            this.btReinicar.TabIndex = 10;
            this.btReinicar.Text = "Reiniciar";
            this.btReinicar.UseVisualStyleBackColor = true;
            this.btReinicar.Click += new System.EventHandler(this.btReinicar_Click);
            // 
            // lbJogadaSelecionada
            // 
            this.lbJogadaSelecionada.AutoSize = true;
            this.lbJogadaSelecionada.Location = new System.Drawing.Point(13, 198);
            this.lbJogadaSelecionada.Name = "lbJogadaSelecionada";
            this.lbJogadaSelecionada.Size = new System.Drawing.Size(148, 13);
            this.lbJogadaSelecionada.TabIndex = 11;
            this.lbJogadaSelecionada.Text = "Nenhuma jogada selecionada";
            // 
            // lbDerrotas
            // 
            this.lbDerrotas.AutoSize = true;
            this.lbDerrotas.Location = new System.Drawing.Point(13, 126);
            this.lbDerrotas.Name = "lbDerrotas";
            this.lbDerrotas.Size = new System.Drawing.Size(56, 13);
            this.lbDerrotas.TabIndex = 12;
            this.lbDerrotas.Text = "Derrotas:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 384);
            this.Controls.Add(this.lbDerrotas);
            this.Controls.Add(this.lbJogadaSelecionada);
            this.Controls.Add(this.btReinicar);
            this.Controls.Add(this.btDescelecionar);
            this.Controls.Add(this.btJogar);
            this.Controls.Add(this.rbResultado);
            this.Controls.Add(this.btTesoura);
            this.Controls.Add(this.btPapel);
            this.Controls.Add(this.btPedra);
            this.Controls.Add(this.lbEmpates);
            this.Controls.Add(this.lbVitorias);
            this.Controls.Add(this.lbRodada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRodada;
        private System.Windows.Forms.Label lbVitorias;
        private System.Windows.Forms.Label lbEmpates;
        private System.Windows.Forms.Button btPedra;
        private System.Windows.Forms.Button btPapel;
        private System.Windows.Forms.Button btTesoura;
        private System.Windows.Forms.RichTextBox rbResultado;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.Button btDescelecionar;
        private System.Windows.Forms.Button btReinicar;
        private System.Windows.Forms.Label lbJogadaSelecionada;
        private System.Windows.Forms.Label lbDerrotas;
    }
}

