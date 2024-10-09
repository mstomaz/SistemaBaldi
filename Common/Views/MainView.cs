using Common.Model;
using SharedResourcesLibrary;

namespace Common.Views
{
    public partial class MainView : Form, IMainView
    {

        public MainView()
        {
            InitializeComponent();
            picBoxBaldi.Image = Resources.logo_baldi;
            StartPosition = FormStartPosition.CenterScreen;
            btnLogin.Click += (s, e) => { ShowLoginForm?.Invoke(this, EventArgs.Empty); };
            btnRegister.Click += (s, e) => { ShowRegisterForm?.Invoke(this, EventArgs.Empty); };
        }

        public UserModel UserInfo { get; set; }
        public event EventHandler ShowLoginForm;
        public event EventHandler ShowRegisterForm;
    }
}
