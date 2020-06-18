using System;
using System.Drawing;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class TopTen : Form
    {
        private readonly FormMain _parent;
        public TopTen(FormMain formMain)
        {
            _parent = formMain;
            InitializeComponent();
            dgvTop10.DataSource = null;
        }


        private void TopTen_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("../../Resources/Top101.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
            dgvTop10.DataSource = PlayerDAO.GetTop10();
            
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

        private void TopTen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Show();
        }
    }
    
}