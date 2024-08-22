namespace Common.Views
{
    public partial class MainView : Form, IMainView
    {

        public MainView()
        {
            InitializeComponent();
            picBoxBaldi.Image = SharedResources.Resources.logo_baldi;
            btnLogin.Click += (s, e) => { ShowLoginForm?.Invoke(this, EventArgs.Empty); };
            btnRegister.Click += (s, e) => { ShowRegisterForm?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowLoginForm;
        public event EventHandler ShowRegisterForm;
    }
}
