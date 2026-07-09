namespace ProjetoBrasileirao
{
    partial class frmTelaAtualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaAtualizar));
            label1 = new Label();
            panel1 = new Panel();
            lbl_Posicao = new Label();
            lbl_NomeTime = new Label();
            txtFiltro_Posicao = new TextBox();
            txtFiltro_NomeTime = new TextBox();
            btn_consultar = new Button();
            cBox_Atualizar = new ComboBox();
            txt_series = new Label();
            dgvAtualizar = new DataGridView();
            btn_inserir = new Button();
            btn_atualizar = new Button();
            btn_apagar = new Button();
            label5 = new Label();
            txt_derrotas = new TextBox();
            label10 = new Label();
            txt_vitorias = new TextBox();
            label11 = new Label();
            txt_jogosTime = new TextBox();
            label2 = new Label();
            txt_nomeTime = new TextBox();
            label3 = new Label();
            txt_pontos = new TextBox();
            label4 = new Label();
            txt_posicao = new TextBox();
            label6 = new Label();
            txt_golsTime = new TextBox();
            label7 = new Label();
            txt_golsSofridos = new TextBox();
            label8 = new Label();
            txt_empates = new TextBox();
            label9 = new Label();
            txt_saldoTime = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtualizar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(221, 33);
            label1.TabIndex = 0;
            label1.Text = "Atualizar Times";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(lbl_Posicao);
            panel1.Controls.Add(lbl_NomeTime);
            panel1.Controls.Add(txtFiltro_Posicao);
            panel1.Controls.Add(txtFiltro_NomeTime);
            panel1.Controls.Add(btn_consultar);
            panel1.Controls.Add(cBox_Atualizar);
            panel1.Controls.Add(txt_series);
            panel1.Controls.Add(dgvAtualizar);
            panel1.Controls.Add(label1);
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(-7, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 549);
            panel1.TabIndex = 8;
            // 
            // lbl_Posicao
            // 
            lbl_Posicao.AutoSize = true;
            lbl_Posicao.Font = new Font("Segoe UI", 9.75F);
            lbl_Posicao.Location = new Point(147, 427);
            lbl_Posicao.Name = "lbl_Posicao";
            lbl_Posicao.Size = new Size(85, 17);
            lbl_Posicao.TabIndex = 47;
            lbl_Posicao.Text = "Posição Time";
            // 
            // lbl_NomeTime
            // 
            lbl_NomeTime.AutoSize = true;
            lbl_NomeTime.Font = new Font("Segoe UI", 9.75F);
            lbl_NomeTime.Location = new Point(19, 427);
            lbl_NomeTime.Name = "lbl_NomeTime";
            lbl_NomeTime.Size = new Size(73, 17);
            lbl_NomeTime.TabIndex = 46;
            lbl_NomeTime.Text = "Nome time";
            // 
            // txtFiltro_Posicao
            // 
            txtFiltro_Posicao.Location = new Point(147, 445);
            txtFiltro_Posicao.Name = "txtFiltro_Posicao";
            txtFiltro_Posicao.Size = new Size(100, 23);
            txtFiltro_Posicao.TabIndex = 45;
            txtFiltro_Posicao.TextChanged += AplicarFiltros;
            // 
            // txtFiltro_NomeTime
            // 
            txtFiltro_NomeTime.Location = new Point(19, 445);
            txtFiltro_NomeTime.Name = "txtFiltro_NomeTime";
            txtFiltro_NomeTime.Size = new Size(100, 23);
            txtFiltro_NomeTime.TabIndex = 44;
            txtFiltro_NomeTime.TextChanged += AplicarFiltros;
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = Color.PaleTurquoise;
            btn_consultar.FlatStyle = FlatStyle.Flat;
            btn_consultar.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btn_consultar.Location = new Point(57, 499);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(135, 32);
            btn_consultar.TabIndex = 43;
            btn_consultar.Text = "Consultar tabela";
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // cBox_Atualizar
            // 
            cBox_Atualizar.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_Atualizar.FormattingEnabled = true;
            cBox_Atualizar.Items.AddRange(new object[] { "Série A", "Série B", "Série C", "Série D" });
            cBox_Atualizar.Location = new Point(17, 92);
            cBox_Atualizar.Name = "cBox_Atualizar";
            cBox_Atualizar.Size = new Size(221, 23);
            cBox_Atualizar.TabIndex = 1;
            cBox_Atualizar.SelectedIndexChanged += cBox_Atualizar_SelectedIndexChanged;
            // 
            // txt_series
            // 
            txt_series.AutoSize = true;
            txt_series.BackColor = Color.Transparent;
            txt_series.Font = new Font("Segoe UI", 10F);
            txt_series.ForeColor = Color.Black;
            txt_series.Location = new Point(17, 70);
            txt_series.Name = "txt_series";
            txt_series.Size = new Size(44, 19);
            txt_series.TabIndex = 4;
            txt_series.Text = "Séries";
            // 
            // dgvAtualizar
            // 
            dgvAtualizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtualizar.Location = new Point(17, 156);
            dgvAtualizar.Name = "dgvAtualizar";
            dgvAtualizar.Size = new Size(230, 256);
            dgvAtualizar.TabIndex = 9;
            dgvAtualizar.CellContentClick += dgvAtualizar_CellClick;
            // 
            // btn_inserir
            // 
            btn_inserir.BackColor = Color.GreenYellow;
            btn_inserir.FlatStyle = FlatStyle.Flat;
            btn_inserir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_inserir.Location = new Point(277, 430);
            btn_inserir.Name = "btn_inserir";
            btn_inserir.Size = new Size(96, 38);
            btn_inserir.TabIndex = 2;
            btn_inserir.Text = "Inserir";
            btn_inserir.UseVisualStyleBackColor = false;
            btn_inserir.Click += btn_inserir_Click;
            // 
            // btn_atualizar
            // 
            btn_atualizar.BackColor = Color.Yellow;
            btn_atualizar.FlatStyle = FlatStyle.Flat;
            btn_atualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_atualizar.Location = new Point(416, 430);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(96, 38);
            btn_atualizar.TabIndex = 3;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = false;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // btn_apagar
            // 
            btn_apagar.BackColor = Color.Crimson;
            btn_apagar.FlatStyle = FlatStyle.Flat;
            btn_apagar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            btn_apagar.Location = new Point(553, 430);
            btn_apagar.Name = "btn_apagar";
            btn_apagar.Size = new Size(96, 38);
            btn_apagar.TabIndex = 4;
            btn_apagar.Text = "Apagar";
            btn_apagar.UseVisualStyleBackColor = false;
            btn_apagar.Click += btn_apagar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(277, 274);
            label5.Name = "label5";
            label5.Size = new Size(113, 19);
            label5.TabIndex = 16;
            label5.Text = "Derrotas do time";
            // 
            // txt_derrotas
            // 
            txt_derrotas.Location = new Point(277, 296);
            txt_derrotas.Multiline = true;
            txt_derrotas.Name = "txt_derrotas";
            txt_derrotas.Size = new Size(166, 29);
            txt_derrotas.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(277, 204);
            label10.Name = "label10";
            label10.Size = new Size(106, 19);
            label10.TabIndex = 26;
            label10.Text = "Vitórias do time";
            // 
            // txt_vitorias
            // 
            txt_vitorias.Location = new Point(277, 226);
            txt_vitorias.Multiline = true;
            txt_vitorias.Name = "txt_vitorias";
            txt_vitorias.Size = new Size(166, 29);
            txt_vitorias.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(277, 135);
            label11.Name = "label11";
            label11.Size = new Size(95, 19);
            label11.TabIndex = 28;
            label11.Text = "Jogos do time";
            // 
            // txt_jogosTime
            // 
            txt_jogosTime.Location = new Point(277, 157);
            txt_jogosTime.Multiline = true;
            txt_jogosTime.Name = "txt_jogosTime";
            txt_jogosTime.Size = new Size(166, 29);
            txt_jogosTime.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(277, 65);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 30;
            label2.Text = "Nome do time";
            // 
            // txt_nomeTime
            // 
            txt_nomeTime.Location = new Point(277, 87);
            txt_nomeTime.Multiline = true;
            txt_nomeTime.Name = "txt_nomeTime";
            txt_nomeTime.Size = new Size(166, 29);
            txt_nomeTime.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(483, 65);
            label3.Name = "label3";
            label3.Size = new Size(102, 19);
            label3.TabIndex = 32;
            label3.Text = "Pontos do time";
            // 
            // txt_pontos
            // 
            txt_pontos.Location = new Point(483, 87);
            txt_pontos.Multiline = true;
            txt_pontos.Name = "txt_pontos";
            txt_pontos.Size = new Size(166, 29);
            txt_pontos.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(483, 343);
            label4.Name = "label4";
            label4.Size = new Size(141, 19);
            label4.TabIndex = 34;
            label4.Text = "Saldo de gols do time";
            // 
            // txt_posicao
            // 
            txt_posicao.Location = new Point(483, 160);
            txt_posicao.Multiline = true;
            txt_posicao.Name = "txt_posicao";
            txt_posicao.Size = new Size(166, 29);
            txt_posicao.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(483, 204);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 36;
            label6.Text = "Gols pró do time";
            // 
            // txt_golsTime
            // 
            txt_golsTime.Location = new Point(483, 226);
            txt_golsTime.Multiline = true;
            txt_golsTime.Name = "txt_golsTime";
            txt_golsTime.Size = new Size(166, 29);
            txt_golsTime.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(483, 274);
            label7.Name = "label7";
            label7.Size = new Size(139, 19);
            label7.TabIndex = 38;
            label7.Text = "Gols sofridos do time";
            // 
            // txt_golsSofridos
            // 
            txt_golsSofridos.Location = new Point(483, 296);
            txt_golsSofridos.Multiline = true;
            txt_golsSofridos.Name = "txt_golsSofridos";
            txt_golsSofridos.Size = new Size(166, 29);
            txt_golsSofridos.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(277, 343);
            label8.Name = "label8";
            label8.Size = new Size(112, 19);
            label8.TabIndex = 40;
            label8.Text = "Empates do time";
            // 
            // txt_empates
            // 
            txt_empates.Location = new Point(277, 365);
            txt_empates.Multiline = true;
            txt_empates.Name = "txt_empates";
            txt_empates.Size = new Size(166, 29);
            txt_empates.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(483, 135);
            label9.Name = "label9";
            label9.Size = new Size(105, 19);
            label9.TabIndex = 42;
            label9.Text = "Posição do time";
            // 
            // txt_saldoTime
            // 
            txt_saldoTime.Location = new Point(483, 365);
            txt_saldoTime.Multiline = true;
            txt_saldoTime.Name = "txt_saldoTime";
            txt_saldoTime.Size = new Size(166, 29);
            txt_saldoTime.TabIndex = 41;
            // 
            // frmTelaAtualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_frmTelaConsultar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1053, 538);
            Controls.Add(label9);
            Controls.Add(txt_saldoTime);
            Controls.Add(label8);
            Controls.Add(txt_empates);
            Controls.Add(label7);
            Controls.Add(txt_golsSofridos);
            Controls.Add(btn_apagar);
            Controls.Add(label6);
            Controls.Add(btn_atualizar);
            Controls.Add(txt_golsTime);
            Controls.Add(btn_inserir);
            Controls.Add(label4);
            Controls.Add(txt_posicao);
            Controls.Add(label3);
            Controls.Add(txt_pontos);
            Controls.Add(label2);
            Controls.Add(txt_nomeTime);
            Controls.Add(label11);
            Controls.Add(txt_jogosTime);
            Controls.Add(label10);
            Controls.Add(txt_vitorias);
            Controls.Add(label5);
            Controls.Add(txt_derrotas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTelaAtualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTelaAtualizar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtualizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dgvAtualizar;
        private ComboBox cBox_Atualizar;
        private Button btn_apagar;
        private Button btn_atualizar;
        private Button btn_inserir;
        private Label txt_series;
        private Label label5;
        private TextBox txt_derrotas;
        private Label label10;
        private TextBox txt_vitorias;
        private Label label11;
        private TextBox txt_jogosTime;
        private Label label2;
        private TextBox txt_nomeTime;
        private Label label3;
        private TextBox txt_pontos;
        private Label label4;
        private TextBox txt_posicao;
        private Label label6;
        private TextBox txt_golsTime;
        private Label label7;
        private TextBox txt_golsSofridos;
        private Label label8;
        private TextBox txt_empates;
        private Label label9;
        private TextBox txt_saldoTime;
        private Button btn_consultar;
        private Label lbl_Posicao;
        private Label lbl_NomeTime;
        private TextBox txtFiltro_Posicao;
        private TextBox txtFiltro_NomeTime;
    }
}