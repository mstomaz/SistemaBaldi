namespace MainMenu.Views
{
    partial class MainMenuView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMenuOptions = new Panel();
            btnShowPicking = new Button();
            btnShowFinishControl = new Button();
            lblUserDpt = new Label();
            lblUserName = new Label();
            picBoxUser = new PictureBox();
            picBoxBaldi = new PictureBox();
            userOptionsMenuStrip = new ContextMenuStrip(components);
            panelMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBaldi).BeginInit();
            SuspendLayout();
            // 
            // panelMenuOptions
            // 
            panelMenuOptions.BackColor = Color.FromArgb(255, 128, 0);
            panelMenuOptions.Controls.Add(btnShowPicking);
            panelMenuOptions.Controls.Add(btnShowFinishControl);
            panelMenuOptions.Controls.Add(lblUserDpt);
            panelMenuOptions.Controls.Add(lblUserName);
            panelMenuOptions.Controls.Add(picBoxUser);
            panelMenuOptions.Controls.Add(picBoxBaldi);
            panelMenuOptions.Dock = DockStyle.Top;
            panelMenuOptions.Location = new Point(0, 0);
            panelMenuOptions.Margin = new Padding(0);
            panelMenuOptions.Name = "panelMenuOptions";
            panelMenuOptions.Size = new Size(997, 10);
            panelMenuOptions.TabIndex = 0;
            panelMenuOptions.MouseEnter += panelMenuOptions_MouseEnter;
            panelMenuOptions.MouseLeave += panelMenuOptions_MouseLeave;
            // 
            // btnShowPicking
            // 
            btnShowPicking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowPicking.BackColor = Color.Transparent;
            btnShowPicking.FlatAppearance.BorderColor = Color.Black;
            btnShowPicking.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnShowPicking.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnShowPicking.FlatStyle = FlatStyle.Flat;
            btnShowPicking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowPicking.Location = new Point(593, 10);
            btnShowPicking.Name = "btnShowPicking";
            btnShowPicking.Size = new Size(130, 58);
            btnShowPicking.TabIndex = 5;
            btnShowPicking.Text = "Picking";
            btnShowPicking.UseVisualStyleBackColor = false;
            // 
            // btnShowFinishControl
            // 
            btnShowFinishControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowFinishControl.BackColor = Color.Transparent;
            btnShowFinishControl.FlatAppearance.BorderColor = Color.Black;
            btnShowFinishControl.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnShowFinishControl.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnShowFinishControl.FlatStyle = FlatStyle.Flat;
            btnShowFinishControl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowFinishControl.Location = new Point(729, 10);
            btnShowFinishControl.Name = "btnShowFinishControl";
            btnShowFinishControl.Size = new Size(130, 58);
            btnShowFinishControl.TabIndex = 1;
            btnShowFinishControl.Text = "Controle de Acabamento";
            btnShowFinishControl.UseVisualStyleBackColor = false;
            // 
            // lblUserDpt
            // 
            lblUserDpt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserDpt.AutoSize = true;
            lblUserDpt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserDpt.ForeColor = SystemColors.Desktop;
            lblUserDpt.Location = new Point(928, 90);
            lblUserDpt.Name = "lblUserDpt";
            lblUserDpt.RightToLeft = RightToLeft.Yes;
            lblUserDpt.Size = new Size(50, 20);
            lblUserDpt.TabIndex = 4;
            lblUserDpt.Text = "label2";
            lblUserDpt.SizeChanged += lblUserDpt_SizeChanged;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.ControlText;
            lblUserName.Location = new Point(930, 70);
            lblUserName.Name = "lblUserName";
            lblUserName.RightToLeft = RightToLeft.Yes;
            lblUserName.Size = new Size(48, 20);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "label1";
            lblUserName.SizeChanged += lblUserName_SizeChanged;
            // 
            // picBoxUser
            // 
            picBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBoxUser.Location = new Point(904, 10);
            picBoxUser.Name = "picBoxUser";
            picBoxUser.Size = new Size(81, 50);
            picBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUser.TabIndex = 2;
            picBoxUser.TabStop = false;
            // 
            // picBoxBaldi
            // 
            picBoxBaldi.Location = new Point(7, 10);
            picBoxBaldi.Name = "picBoxBaldi";
            picBoxBaldi.Size = new Size(227, 95);
            picBoxBaldi.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxBaldi.TabIndex = 1;
            picBoxBaldi.TabStop = false;
            // 
            // userOptionsMenuStrip
            // 
            userOptionsMenuStrip.Name = "contextMenuStrip1";
            userOptionsMenuStrip.Size = new Size(61, 4);
            // 
            // MainMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 556);
            Controls.Add(panelMenuOptions);
            IsMdiContainer = true;
            Name = "MainMenuView";
            panelMenuOptions.ResumeLayout(false);
            panelMenuOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBaldi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuOptions;
        private PictureBox picBoxBaldi;
        private Label lblUserName;
        private PictureBox picBoxUser;
        private Button btnShowFinishControl;
        private Label lblUserDpt;
        private Button btnShowPicking;
        private ContextMenuStrip userOptionsMenuStrip;
    }
}
