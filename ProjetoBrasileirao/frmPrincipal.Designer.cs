namespace ProjetoBrasileirao
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btn_consultar = new Button();
            button2 = new Button();
            txt_titulo = new Label();
            SuspendLayout();
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = Color.Gold;
            btn_consultar.FlatStyle = FlatStyle.Flat;
            btn_consultar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar.ForeColor = Color.Black;
            btn_consultar.Location = new Point(233, 301);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(130, 73);
            btn_consultar.TabIndex = 1;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(447, 301);
            button2.Name = "button2";
            button2.Size = new Size(130, 73);
            button2.TabIndex = 2;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txt_titulo
            // 
            txt_titulo.AutoSize = true;
            txt_titulo.BackColor = Color.Transparent;
            txt_titulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_titulo.ForeColor = Color.White;
            txt_titulo.Location = new Point(201, 9);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(411, 32);
            txt_titulo.TabIndex = 3;
            txt_titulo.Text = "SISTEMA DE CONTROLE DE TIMES";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_titulo);
            Controls.Add(button2);
            Controls.Add(btn_consultar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_consultar;
        private Button button2;
        private Label txt_titulo;
    }
}