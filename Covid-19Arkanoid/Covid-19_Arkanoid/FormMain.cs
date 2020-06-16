using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Username user = new Username();
            user.Show();
        }

        private void BtnScores_Click(object sender, EventArgs e)
        {
            TopTen scores = new TopTen();
            scores.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
            
            tlpMain.BackgroundImage = Image.FromFile("../../Resources/Group_2.png");
            tlpMain.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}