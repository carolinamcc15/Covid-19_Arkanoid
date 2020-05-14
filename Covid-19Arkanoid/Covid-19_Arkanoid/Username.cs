using System;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class Username : Form
    {
        private UserControl current;
        private Skin sk = new Skin();
        private NameUser nu = new NameUser();
        public Username()
        {
            InitializeComponent();
            current = nameUser1;
            sk.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(nameUser1, 0,0);
            current = nameUser1;
            tableLayoutPanel1.SetColumnSpan(current,2);
            
        }

        private void ButSkin_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(sk, 0,0);
            current = sk;
            tableLayoutPanel1.SetColumnSpan(current,2);
        }
    }
}