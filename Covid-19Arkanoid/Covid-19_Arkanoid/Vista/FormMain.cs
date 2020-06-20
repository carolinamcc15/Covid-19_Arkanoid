using System;
using System.Drawing;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            
            Username user = new Username(this);
            user.Show();
            Hide();
        }

        private void BtnScores_Click(object sender, EventArgs e)
        {
            TopTen scores = new TopTen(this);
            scores.Show();
            Hide();
        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
            BackgroundImage = Image.FromFile("../../Resources/Group_2.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            tlpMain.BackColor = Color.Transparent;
        }
    }
}