namespace ProjetoBrasileirao
{
    partial class frmTelaConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaConsultar));
            dvgConsultar = new DataGridView();
            txt_titulo = new Label();
            cbox_series = new ComboBox();
            txt_series = new Label();
            btn_paginaPrincipal = new Button();
            btn_Atualizar = new Button();
            btn_consultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgConsultar).BeginInit();
            SuspendLayout();
            // 
            // dvgConsultar
            // 
            dvgConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgConsultar.Location = new Point(205, 27);
            dvgConsultar.Name = "dvgConsultar";
            dvgConsultar.Size = new Size(300, 398);
            dvgConsultar.TabIndex = 3;
            // 
            // txt_titulo
            // 
            txt_titulo.AutoSize = true;
            txt_titulo.BackColor = Color.Transparent;
            txt_titulo.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_titulo.ForeColor = Color.White;
            txt_titulo.Location = new Point(12, 51);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(187, 29);
            txt_titulo.TabIndex = 5;
            txt_titulo.Text = "Consultar Times";
            // 
            // cbox_series
            // 
            cbox_series.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_series.FormattingEnabled = true;
            cbox_series.Items.AddRange(new object[] { "Série A", "Série B", "Série C", "Série D" });
            cbox_series.Location = new Point(12, 154);
            cbox_series.Name = "cbox_series";
            cbox_series.Size = new Size(160, 23);
            cbox_series.TabIndex = 1;
            // 
            // txt_series
            // 
            txt_series.AutoSize = true;
            txt_series.BackColor = Color.Transparent;
            txt_series.Font = new Font("Segoe UI", 11F);
            txt_series.ForeColor = Color.White;
            txt_series.Location = new Point(12, 131);
            txt_series.Name = "txt_series";
            txt_series.Size = new Size(48, 20);
            txt_series.TabIndex = 4;
            txt_series.Text = "Séries";
            // 
            // btn_paginaPrincipal
            // 
            btn_paginaPrincipal.BackColor = Color.SteelBlue;
            btn_paginaPrincipal.FlatStyle = FlatStyle.Flat;
            btn_paginaPrincipal.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_paginaPrincipal.Location = new Point(32, 264);
            btn_paginaPrincipal.Name = "btn_paginaPrincipal";
            btn_paginaPrincipal.Size = new Size(117, 56);
            btn_paginaPrincipal.TabIndex = 2;
            btn_paginaPrincipal.Text = "Página Principal";
            btn_paginaPrincipal.UseVisualStyleBackColor = false;
            btn_paginaPrincipal.Click += btn_paginaPrincipal_Click;
            // 
            // btn_Atualizar
            // 
            btn_Atualizar.BackColor = Color.Yellow;
            btn_Atualizar.FlatStyle = FlatStyle.Flat;
            btn_Atualizar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Atualizar.Location = new Point(32, 337);
            btn_Atualizar.Name = "btn_Atualizar";
            btn_Atualizar.Size = new Size(117, 56);
            btn_Atualizar.TabIndex = 6;
            btn_Atualizar.Text = "Atualizar";
            btn_Atualizar.UseVisualStyleBackColor = false;
            btn_Atualizar.Click += btn_Atualizar_Click;
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = Color.Gold;
            btn_consultar.FlatStyle = FlatStyle.Flat;
            btn_consultar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar.ForeColor = Color.Black;
            btn_consultar.Location = new Point(32, 192);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(117, 56);
            btn_consultar.TabIndex = 7;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // frmTelaConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_frmTelaConsultar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_consultar);
            Controls.Add(btn_Atualizar);
            Controls.Add(btn_paginaPrincipal);
            Controls.Add(txt_series);
            Controls.Add(cbox_series);
            Controls.Add(txt_titulo);
            Controls.Add(dvgConsultar);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTelaConsultar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTelaConsultar";
            ((System.ComponentModel.ISupportInitialize)dvgConsultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgConsultar;
        private Label txt_titulo;
        private ComboBox cbox_series;
        private Label txt_series;
        private Button btn_paginaPrincipal;
        private Button btn_Atualizar;
        private Button btn_consultar;
    }
}