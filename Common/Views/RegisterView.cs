namespace Common.Views
{
    public partial class RegisterView : Form, IRegisterView
    {
        private string? _message;
        private bool _isSuccessful;

        public RegisterView()
        {
            InitializeComponent();
            btnRegister.Click += (s, e) => { TryRegister?.Invoke(this, EventArgs.Empty); };
        }

        public string UserLogin
        {
            get { return txtUserLogin.Text; }
            set { txtUserLogin.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }
        public int DepartmentIndex
        {
            get { return cmbDepartment.SelectedIndex; }
            set { cmbDepartment.SelectedIndex = value; }
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
        public TextBox TxtUserLogin
        {
            get { return txtUserLogin; }
            set { txtUserLogin = value; }
        }
        public TextBox TxtPassword
        {
            get { return txtPassword; }
            set { txtPassword = value; }
        }
        public TextBox TxtUserName
        {
            get { return txtUserName; }
            set { txtUserName = value; }
        }

        public event EventHandler? TryRegister;


        private static RegisterView? instance;

        public static RegisterView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RegisterView
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
