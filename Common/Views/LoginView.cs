﻿namespace Common.Views
{
    public partial class LoginView : Form, ILoginView
    {

        private string? _message;
        private bool _isSuccessful;

        public LoginView()
        {
            InitializeComponent();
            picBoxSilhouette.Image = SharedResources.Resources.user_silhouette;
            ViewEvents();
        }

        private void ViewEvents()
        {
            btnLogin.Click += (s, e) => { TryLogin?.Invoke(this, EventArgs.Empty); };
            chkShowPassword.Click += ShowPassword;
        }

        public string UserLogin 
        { 
            get { return frmTxtUsername.Text; }
            set { frmTxtUsername.Text = value;}
        }
        public string Password 
        { 
            get { return frmTxtPassword.Text; }
            set { frmTxtPassword.Text = value; }
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public bool IsSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }
        public TextBox TxtUsername
        {   
            get { return frmTxtUsername; }
            set { frmTxtUsername = value; }
        }
        public TextBox TxtPassword 
        { 
            get { return frmTxtPassword; }
            set { frmTxtPassword = value; }
        }
        public ErrorProvider ErrorProvider
        {
            get { return UserErrorProvider; }
            set { UserErrorProvider = value; }
        }

        public event EventHandler? TryLogin;

        public void SetError(Control control, string? errorMessage)
        {
            ErrorProvider.SetError(control, errorMessage);
        }

        private void ShowPassword(object sender, EventArgs args)
        {
            if (chkShowPassword.Checked)
                frmTxtPassword.PasswordChar = '\0';
            else
                frmTxtPassword.PasswordChar = '*';
        }

        private static LoginView? instance;

        public static LoginView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LoginView
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                instance.Show();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
