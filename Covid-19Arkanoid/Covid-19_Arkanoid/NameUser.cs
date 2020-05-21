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
            Hide();
            Skin s = new Skin();
            s.Dock = DockStyle.Fill;
            Parent.Controls.Add(s);
        }
    }
}