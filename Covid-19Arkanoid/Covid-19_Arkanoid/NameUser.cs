using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class NameUser : UserControl
    { 
        public NameUser()
        {
            InitializeComponent();
        }

        private void BtnDoneU_Click(object sender, EventArgs e)
        {
            Player current;

            if (!txtUsername.Text.Equals("") || txtUsername.Text.Trim().Length > 0)
            {
                current = PlayerDAO.CurrentPlayer(txtUsername.Text);
                
                Hide();
                
                Skin s = new Skin(txtUsername.Text, current.PlayerId);
                s.Dock = DockStyle.Fill;
                Parent.Controls.Add(s);
                Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("Write a name.", "ARKANOID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NameUser_Load(object sender, EventArgs e)
        {
            tlpChoose.BackgroundImage = Image.FromFile("../../Resources/User.png");;
            tlpChoose.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}