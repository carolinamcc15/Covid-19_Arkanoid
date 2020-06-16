using System;
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
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
            
            dgvTop10.DataSource = PlayerDAO.GetTop10();
            
        }
    }
    
}