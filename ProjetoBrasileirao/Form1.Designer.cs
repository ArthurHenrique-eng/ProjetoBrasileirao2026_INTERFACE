namespace ProjetoBrasileirao
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            btn_entrar = new Button();
            btn_sair = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_entrar
            // 
            resources.ApplyResources(btn_entrar, "btn_entrar");
            btn_entrar.BackColor = Color.Green;
            btn_entrar.FlatAppearance.BorderColor = Color.Black;
            btn_entrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_entrar.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_entrar.Name = "btn_entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // btn_sair
            // 
            resources.ApplyResources(btn_sair, "btn_sair");
            btn_sair.BackColor = Color.Red;
            btn_sair.FlatAppearance.MouseDownBackColor = Color.Red;
            btn_sair.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_sair.Name = "btn_sair";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.Yellow;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            // 
            // frm_login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_logo_sistemadecontroledetimes;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_sair);
            Controls.Add(btn_entrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_login";
            Tag = "frm_login";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_entrar;
        private Button btn_sair;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
