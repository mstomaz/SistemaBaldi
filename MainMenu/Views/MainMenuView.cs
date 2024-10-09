using MainMenu.Model;
using SharedResourcesLibrary;
using SharedResourcesLibrary.Factory;
using SharedResourcesLibrary.Enum;

namespace MainMenu.Views
{
    public partial class MainMenuView : Form, IMainMenuView
    {
        private System.Windows.Forms.Timer expandTimer;
        private System.Windows.Forms.Timer shrinkTimer;
        private const int initialHeight = 10;
        private const int targetHeight = 120;
        private const int timerStep = 20;


        public event EventHandler? LogoutClicked;
        public event EventHandler? ShowFinishControlModuleMainForm;
        public event EventHandler? ShowPickingModuleMainForm;

        public MainMenuView(UserModel userInfo)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            picBoxBaldi.Image = Resources.logo_baldi;
            picBoxUser.Image = Resources.user_silhouette;
            btnShowFinishControl.Click += (s, e) => { ShowFinishControlModuleMainForm?.Invoke(this, EventArgs.Empty); };
            btnShowPicking.Click += (s, e) => { ShowPickingModuleMainForm?.Invoke(this, EventArgs.Empty); };
            lblUserName.Text = userInfo.UserName;
            string departmentName = DepartmentsFactory.departmentMapping.GetValueOrDefault<UserDepartmentEnum, string>(userInfo.UserDepartment);
            lblUserDpt.Text = departmentName;


            expandTimer = new System.Windows.Forms.Timer { Interval = 10 };
            expandTimer.Tick += expandTimer_Tick;

            shrinkTimer = new System.Windows.Forms.Timer { Interval = 10 };
            shrinkTimer.Tick += shrinkTimer_Tick;

            userOptionsMenuStrip.RightToLeft = RightToLeft.Yes;
            var logoutDropDownButton = new ToolStripDropDownButton("Sair", Resources.logout_icon);
            logoutDropDownButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            int logoutTextSize = TextRenderer.MeasureText(logoutDropDownButton.Text, logoutDropDownButton.Font).Width;
            logoutDropDownButton.Width = logoutTextSize + logoutDropDownButton.Bounds.Right;
            userOptionsMenuStrip.Items.Add(logoutDropDownButton);
            logoutDropDownButton.DropDown = userOptionsMenuStrip;
            picBoxUser.ContextMenuStrip = userOptionsMenuStrip;

            logoutDropDownButton.MouseDown += (s, e) => 
            { 
                if (e.Button == MouseButtons.Left) LogoutClicked.Invoke(this, EventArgs.Empty); 
            };
        }


        private void panelMenuOptions_MouseEnter(object sender, EventArgs e)
        {
            shrinkTimer.Stop();
            expandTimer.Start();
        }

        private void panelMenuOptions_MouseLeave(object sender, EventArgs e)
        {
            if (!panelMenuOptions.ClientRectangle.Contains(panelMenuOptions.PointToClient(Cursor.Position)))
            {
                expandTimer.Stop();
                shrinkTimer.Start();
            }
        }

        private void expandTimer_Tick(object? sender, EventArgs e)
        {
            if (panelMenuOptions.Height < targetHeight)
                panelMenuOptions.Height += timerStep;
            else expandTimer.Stop();
        }

        private void shrinkTimer_Tick(object? sender, EventArgs e)
        {
            if (panelMenuOptions.Height > initialHeight)
                panelMenuOptions.Height -= timerStep;
            else shrinkTimer.Stop();
        }

        private void lblUserName_SizeChanged(object sender, EventArgs e)
        {
            if (lblUserName.Right > ClientSize.Width)
            {
                lblUserName.Left = ClientSize.Width - lblUserName.Width;
            }
        }

        private void lblUserDpt_SizeChanged(object sender, EventArgs e)
        {
            if (lblUserDpt.Right > ClientSize.Width)
            {
                lblUserDpt.Left = ClientSize.Width - lblUserDpt.Width;
            }
        }
    }
}
