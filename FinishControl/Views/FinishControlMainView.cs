using FinishControl.Model;

namespace FinishControl.Views
{
    public partial class FinishControlMainView : Form, IFinishControlMainView
    {
        public FinishControlMainView()
        {
            InitializeComponent();
        }

        public DataGridView prodControlGrid
        {
            get { return finishControlGrid; }
            set { finishControlGrid = value; }
        }

        private static FinishControlMainView? instance;

        public static FinishControlMainView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FinishControlMainView
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
