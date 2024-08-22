namespace Common.Views
{
    partial class RegisterView
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
            label1 = new Label();
            lblSenha = new Label();
            lblConfirmPassword = new Label();
            lblDepartment = new Label();
            txtUserLogin = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            cmbDepartment = new ComboBox();
            lblCadastro = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            btnRegister = new Button();
            RegisterErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)RegisterErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(219, 138);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome de usuário:";
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Top;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 11F);
            lblSenha.Location = new Point(293, 188);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.Top;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 11F);
            lblConfirmPassword.Location = new Point(219, 238);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(122, 20);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Confirmar Senha:";
            // 
            // lblDepartment
            // 
            lblDepartment.Anchor = AnchorStyles.Top;
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 11F);
            lblDepartment.Location = new Point(298, 338);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(47, 20);
            lblDepartment.TabIndex = 3;
            lblDepartment.Text = "Setor:";
            // 
            // txtUserLogin
            // 
            txtUserLogin.Anchor = AnchorStyles.Top;
            txtUserLogin.BackColor = SystemColors.Window;
            txtUserLogin.Location = new Point(368, 135);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(210, 23);
            txtUserLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.Location = new Point(368, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top;
            txtConfirmPassword.Location = new Point(368, 239);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(210, 23);
            txtConfirmPassword.TabIndex = 2;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Anchor = AnchorStyles.Top;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(368, 335);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(210, 23);
            cmbDepartment.TabIndex = 7;
            // 
            // lblCadastro
            // 
            lblCadastro.Anchor = AnchorStyles.Top;
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastro.Location = new Point(342, 65);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(115, 32);
            lblCadastro.TabIndex = 0;
            lblCadastro.Text = "Cadastro";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top;
            txtUserName.Location = new Point(368, 285);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(210, 23);
            txtUserName.TabIndex = 9;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 11F);
            lblUserName.Location = new Point(219, 288);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(126, 20);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "Nome de usuário:";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top;
            btnRegister.AutoSize = true;
            btnRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(342, 395);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(115, 39);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // RegisterErrorProvider
            // 
            RegisterErrorProvider.ContainerControl = this;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(801, 485);
            Controls.Add(btnRegister);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblCadastro);
            Controls.Add(cmbDepartment);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserLogin);
            Controls.Add(lblDepartment);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblSenha);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "RegisterView";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)RegisterErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblSenha;
        private Label lblConfirmPassword;
        private Label lblDepartment;
        private TextBox txtUserLogin;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ComboBox cmbDepartment;
        private Label lblCadastro;
        private TextBox txtUserName;
        private Label lblUserName;
        private Button btnRegister;
        private ErrorProvider RegisterErrorProvider;
    }
}