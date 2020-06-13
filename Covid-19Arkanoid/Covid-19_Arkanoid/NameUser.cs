using System;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class NameUser : UserControl
    { 
        public NameUser()
        {
            InitializeComponent();
        }

        private void btnDoneU_Click(object sender, EventArgs e)
        {
            if (!txtUsername.Text.Equals(""))
            {
                Hide();
                Skin s = new Skin(txtUsername.Text);
                s.Dock = DockStyle.Fill;
                Parent.Controls.Add(s);
                Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("Write a name.","ARKANOID",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            
        }
    }
}