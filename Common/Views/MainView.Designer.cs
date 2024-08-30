namespace Common.Views
{
    partial class MainView
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
            picBoxBaldi = new PictureBox();
            titleLogoPanel = new Panel();
            btnRegister = new Button();
            btnLogin = new Button();
            lblBaldi = new Label();
            menusPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)picBoxBaldi).BeginInit();
            titleLogoPanel.SuspendLayout();
            menusPanel.SuspendLayout();
            SuspendLayout();
            // 
            // picBoxBaldi
            // 
            picBoxBaldi.BackColor = Color.Transparent;
            picBoxBaldi.Location = new Point(0, 0);
            picBoxBaldi.Margin = new Padding(0, 0, 3, 0);
            picBoxBaldi.Name = "picBoxBaldi";
            picBoxBaldi.Size = new Size(227, 95);
            picBoxBaldi.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxBaldi.TabIndex = 0;
            picBoxBaldi.TabStop = false;
            // 
            // titleLogoPanel
            // 
            titleLogoPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            titleLogoPanel.BackColor = Color.DarkGray;
            titleLogoPanel.Controls.Add(picBoxBaldi);
            titleLogoPanel.Dock = DockStyle.Top;
            titleLogoPanel.Location = new Point(0, 0);
            titleLogoPanel.Margin = new Padding(0, 0, 0, 3);
            titleLogoPanel.Name = "titleLogoPanel";
            titleLogoPanel.Size = new Size(1032, 100);
            titleLogoPanel.TabIndex = 1;
            titleLogoPanel.TabStop = true;
            // 
            // btnRegister
            // 
            btnRegister.AutoSize = true;
            btnRegister.BackColor = Color.Transparent;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(12, 44);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 33);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(12, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 33);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblBaldi
            // 
            lblBaldi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblBaldi.AutoSize = true;
            lblBaldi.BackColor = Color.Transparent;
            lblBaldi.Location = new Point(25, 539);
            lblBaldi.Name = "lblBaldi";
            lblBaldi.Size = new Size(73, 15);
            lblBaldi.TabIndex = 2;
            lblBaldi.Text = "Estojos Baldi";
            // 
            // menusPanel
            // 
            menusPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            menusPanel.AutoSize = true;
            menusPanel.BackColor = Color.FromArgb(255, 128, 0);
            menusPanel.BorderStyle = BorderStyle.FixedSingle;
            menusPanel.Controls.Add(btnLogin);
            menusPanel.Controls.Add(lblBaldi);
            menusPanel.Controls.Add(btnRegister);
            menusPanel.Location = new Point(913, 100);
            menusPanel.Margin = new Padding(0);
            menusPanel.Name = "menusPanel";
            menusPanel.Size = new Size(978, 564);
            menusPanel.TabIndex = 4;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 664);
            Controls.Add(menusPanel);
            Controls.Add(titleLogoPanel);
            IsMdiContainer = true;
            Name = "MainView";
            ((System.ComponentModel.ISupportInitialize)picBoxBaldi).EndInit();
            titleLogoPanel.ResumeLayout(false);
            menusPanel.ResumeLayout(false);
            menusPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxBaldi;
        private Panel titleLogoPanel;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblBaldi;
        private Panel menusPanel;
    }
}