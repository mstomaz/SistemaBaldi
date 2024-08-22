namespace Common.Views
{
    partial class LoginView
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            picBoxSilhouette = new PictureBox();
            frmTxtUsername = new TextBox();
            frmTxtPassword = new TextBox();
            lblLogin = new Label();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            UserErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)picBoxSilhouette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 51);
            panel1.TabIndex = 0;
            // 
            // picBoxSilhouette
            // 
            picBoxSilhouette.Anchor = AnchorStyles.Top;
            picBoxSilhouette.Location = new Point(192, 55);
            picBoxSilhouette.Margin = new Padding(3, 3, 3, 0);
            picBoxSilhouette.Name = "picBoxSilhouette";
            picBoxSilhouette.Size = new Size(127, 89);
            picBoxSilhouette.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxSilhouette.TabIndex = 1;
            picBoxSilhouette.TabStop = false;
            // 
            // frmTxtUsername
            // 
            frmTxtUsername.Anchor = AnchorStyles.Top;
            frmTxtUsername.Location = new Point(149, 185);
            frmTxtUsername.Name = "frmTxtUsername";
            frmTxtUsername.PlaceholderText = "Usuário";
            frmTxtUsername.Size = new Size(213, 23);
            frmTxtUsername.TabIndex = 2;
            // 
            // frmTxtPassword
            // 
            frmTxtPassword.Anchor = AnchorStyles.Top;
            frmTxtPassword.Location = new Point(149, 214);
            frmTxtPassword.Name = "frmTxtPassword";
            frmTxtPassword.PasswordChar = '*';
            frmTxtPassword.PlaceholderText = "Senha";
            frmTxtPassword.Size = new Size(213, 23);
            frmTxtPassword.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(223, 149);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(63, 25);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            // 
            // chkShowPassword
            // 
            chkShowPassword.Anchor = AnchorStyles.Top;
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(149, 243);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(101, 19);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Mostrar senha";
            chkShowPassword.TextAlign = ContentAlignment.TopLeft;
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(203, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 38);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // UserErrorProvider
            // 
            UserErrorProvider.ContainerControl = this;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 335);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(lblLogin);
            Controls.Add(frmTxtPassword);
            Controls.Add(frmTxtUsername);
            Controls.Add(picBoxSilhouette);
            Controls.Add(panel1);
            Name = "LoginView";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picBoxSilhouette).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picBoxSilhouette;
        private TextBox frmTxtUsername;
        private TextBox frmTxtPassword;
        private Label lblLogin;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private ErrorProvider UserErrorProvider;
    }
}