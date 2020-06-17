using System;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class Username : Form
    {
        public Username()
        {
            InitializeComponent();
        }

        private void Username_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;

            nameUser1.Dock = DockStyle.Fill;
            Controls.Add(nameUser1);
        }
        
    }
}