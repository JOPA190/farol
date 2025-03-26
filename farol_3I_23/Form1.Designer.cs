namespace farol_3I_23
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
            this.lbl_Vermelho = new System.Windows.Forms.Label();
            this.lbl_Verde = new System.Windows.Forms.Label();
            this.lbl_Amarelo = new System.Windows.Forms.Label();
            this.btn_Vermelho = new System.Windows.Forms.Button();
            this.btn_Verde = new System.Windows.Forms.Button();
            this.btn_Amarelo = new System.Windows.Forms.Button();
            this.btn_Automacao = new System.Windows.Forms.Button();
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.btn_Sequencial = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.nud_Tempo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tempo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Vermelho
            // 
            this.lbl_Vermelho.AutoSize = true;
            this.lbl_Vermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vermelho.Location = new System.Drawing.Point(471, 113);
            this.lbl_Vermelho.Name = "lbl_Vermelho";
            this.lbl_Vermelho.Size = new System.Drawing.Size(51, 55);
            this.lbl_Vermelho.TabIndex = 0;
            this.lbl_Vermelho.Text = "0";
            // 
            // lbl_Verde
            // 
            this.lbl_Verde.AutoSize = true;
            this.lbl_Verde.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Verde.Location = new System.Drawing.Point(471, 309);
            this.lbl_Verde.Name = "lbl_Verde";
            this.lbl_Verde.Size = new System.Drawing.Size(51, 55);
            this.lbl_Verde.TabIndex = 1;
            this.lbl_Verde.Text = "0";
            // 
            // lbl_Amarelo
            // 
            this.lbl_Amarelo.AutoSize = true;
            this.lbl_Amarelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amarelo.Location = new System.Drawing.Point(471, 210);
            this.lbl_Amarelo.Name = "lbl_Amarelo";
            this.lbl_Amarelo.Size = new System.Drawing.Size(51, 55);
            this.lbl_Amarelo.TabIndex = 2;
            this.lbl_Amarelo.Text = "0";
            this.lbl_Amarelo.Click += new System.EventHandler(this.lbl_Amarelo_Click);
            // 
            // btn_Vermelho
            // 
            this.btn_Vermelho.BackColor = System.Drawing.Color.Red;
            this.btn_Vermelho.Location = new System.Drawing.Point(63, 52);
            this.btn_Vermelho.Name = "btn_Vermelho";
            this.btn_Vermelho.Size = new System.Drawing.Size(122, 84);
            this.btn_Vermelho.TabIndex = 3;
            this.btn_Vermelho.Text = "Vermelho";
            this.btn_Vermelho.UseVisualStyleBackColor = false;
            this.btn_Vermelho.Click += new System.EventHandler(this.btn_Vermelho_Click);
            // 
            // btn_Verde
            // 
            this.btn_Verde.BackColor = System.Drawing.Color.Lime;
            this.btn_Verde.Location = new System.Drawing.Point(63, 280);
            this.btn_Verde.Name = "btn_Verde";
            this.btn_Verde.Size = new System.Drawing.Size(122, 84);
            this.btn_Verde.TabIndex = 4;
            this.btn_Verde.Text = "Verde";
            this.btn_Verde.UseVisualStyleBackColor = false;
            this.btn_Verde.Click += new System.EventHandler(this.btn_Verde_Click);
            // 
            // btn_Amarelo
            // 
            this.btn_Amarelo.BackColor = System.Drawing.Color.Yellow;
            this.btn_Amarelo.Location = new System.Drawing.Point(63, 164);
            this.btn_Amarelo.Name = "btn_Amarelo";
            this.btn_Amarelo.Size = new System.Drawing.Size(122, 84);
            this.btn_Amarelo.TabIndex = 5;
            this.btn_Amarelo.Text = "Amarelo";
            this.btn_Amarelo.UseVisualStyleBackColor = false;
            this.btn_Amarelo.Click += new System.EventHandler(this.btn_Amarelo_Click);
            // 
            // btn_Automacao
            // 
            this.btn_Automacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Automacao.Location = new System.Drawing.Point(63, 383);
            this.btn_Automacao.Name = "btn_Automacao";
            this.btn_Automacao.Size = new System.Drawing.Size(144, 22);
            this.btn_Automacao.TabIndex = 6;
            this.btn_Automacao.Text = "Automação";
            this.btn_Automacao.UseVisualStyleBackColor = false;
            this.btn_Automacao.Click += new System.EventHandler(this.btn_Automacao_Click);
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tempo.Location = new System.Drawing.Point(247, 368);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(31, 33);
            this.lbl_Tempo.TabIndex = 7;
            this.lbl_Tempo.Text = "0";
            // 
            // btn_Sequencial
            // 
            this.btn_Sequencial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Sequencial.Location = new System.Drawing.Point(63, 411);
            this.btn_Sequencial.Name = "btn_Sequencial";
            this.btn_Sequencial.Size = new System.Drawing.Size(144, 22);
            this.btn_Sequencial.TabIndex = 8;
            this.btn_Sequencial.Text = "Sequencial";
            this.btn_Sequencial.UseVisualStyleBackColor = false;
            this.btn_Sequencial.Click += new System.EventHandler(this.btn_Sequencial_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Red;
            this.btn_Stop.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Stop.Location = new System.Drawing.Point(509, 411);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(47, 21);
            this.btn_Stop.TabIndex = 9;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // nud_Tempo
            // 
            this.nud_Tempo.Location = new System.Drawing.Point(443, 395);
            this.nud_Tempo.Name = "nud_Tempo";
            this.nud_Tempo.Size = new System.Drawing.Size(60, 20);
            this.nud_Tempo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 455);
            this.Controls.Add(this.nud_Tempo);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Sequencial);
            this.Controls.Add(this.lbl_Tempo);
            this.Controls.Add(this.btn_Automacao);
            this.Controls.Add(this.btn_Amarelo);
            this.Controls.Add(this.btn_Verde);
            this.Controls.Add(this.btn_Vermelho);
            this.Controls.Add(this.lbl_Amarelo);
            this.Controls.Add(this.lbl_Verde);
            this.Controls.Add(this.lbl_Vermelho);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Vermelho;
        private System.Windows.Forms.Label lbl_Verde;
        private System.Windows.Forms.Label lbl_Amarelo;
        private System.Windows.Forms.Button btn_Vermelho;
        private System.Windows.Forms.Button btn_Verde;
        private System.Windows.Forms.Button btn_Amarelo;
        private System.Windows.Forms.Button btn_Automacao;
        private System.Windows.Forms.Label lbl_Tempo;
        private System.Windows.Forms.Button btn_Sequencial;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.NumericUpDown nud_Tempo;
    }
}

