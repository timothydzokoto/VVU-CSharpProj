using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Evaluator1
{
    public partial class MainForm : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderPanel;
        private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();

            lblSchoolName.Text = "VALLEY VIEW BASIC SCHOOLS";
            leftBorderPanel = new Panel();
            leftBorderPanel.Size = new Size(7, 45);
            panelMenu.Controls.Add(leftBorderPanel);

            // Remove the buttons on the main form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }


        private void ActiveButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 38, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderPanel.BackColor = color;
                leftBorderPanel.Location = new Point(0, currentBtn.Location.Y);
                leftBorderPanel.Visible = true;
                leftBorderPanel.BringToFront();

                // current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0, 139, 139);
            public static Color color2 = Color.FromArgb(138, 43, 226);
            public static Color color3 = Color.FromArgb(128, 0, 128);
            public static Color color4 = Color.FromArgb(188, 143, 143);
            public static Color color5 = Color.FromArgb(148, 0, 211);
            public static Color color6 = Color.FromArgb(240, 128, 128);
            public static Color color7 = Color.FromArgb(128, 128, 0);
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 31, 63);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        // Child Form

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneDesktop.Controls.Add(childForm);
            paneDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqliteDataAccess.InitialDBStartUp();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color7);
            OpenChildForm(new SettingsForm());
        }

        private void btnDaschboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new DashboardForm());
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new ManagePupilsForm());
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new ScoreForm());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new AttendanceForm());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new ReportForm());
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new Fees());
        }

        public void reset()
        {
            DisableButton();
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            reset();
        }


        // Drag form functionality
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblSchoolName_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color7);
            OpenChildForm(new SettingsForm());
        }

        private void btnScore_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new ScoreForm());
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new ReportForm());
        }

        private void btnFees_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new Fees());
        }

        private void btnSettings_Click_2(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color7);
            OpenChildForm(new SettingsForm());
        }
    }
}
