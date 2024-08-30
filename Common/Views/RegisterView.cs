using Common.Factory;
using Common.Model.Enum;

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
            CboxDepartment.DataSource = DepartmentsFactory.GetDepartmentValues();
            chkShowPassword.Click += PasswordVisibility;
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
        public string PasswordConfirmation
        {
            get { return txtConfirmPassword.Text; }
            set { txtConfirmPassword.Text = value; }
        }
        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }
        public UserDepartmentEnum? DepartmentCode
        {
            get { return DepartmentsFactory.GetDepartmentKey(cmbDepartment.Text); }
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
        public TextBox TxtConfirmPassword
        {
            get { return txtConfirmPassword; }
            set { txtConfirmPassword = value; }
        }
        public TextBox TxtUserName
        {
            get { return txtUserName; }
            set { txtUserName = value; }
        }
        public ComboBox CboxDepartment
        {
            get { return cmbDepartment; }
            set { cmbDepartment = value; }
        }
        public ErrorProvider ErrorProvider
        {
            get { return RegisterErrorProvider; }
            set { RegisterErrorProvider = value; }
        }

        public event EventHandler? TryRegister;

        private void PasswordVisibility(object sender, EventArgs e)
        {
            if (!chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
                return;
            }
            txtPassword.PasswordChar = '\0';
            txtConfirmPassword.PasswordChar = '\0';
        }

        public void ShowMsgBoxError(string errorMessage, string titleMessage,
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK, MessageBoxIcon msgBoxIcon = MessageBoxIcon.Error)
        {
            MessageBox.Show(errorMessage, titleMessage, msgBoxButtons, msgBoxIcon);
        }
        public void ClearFields()
        {
            UserLogin = string.Empty;
            Password = string.Empty;
            PasswordConfirmation = string.Empty;
            UserName = string.Empty;
        }

        private void cmbDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

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
