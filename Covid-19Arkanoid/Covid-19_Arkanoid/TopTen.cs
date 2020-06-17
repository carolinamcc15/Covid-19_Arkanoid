using System;
using System.Drawing;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class TopTen : Form
    {
        public TopTen()
        {
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
    }
    
}