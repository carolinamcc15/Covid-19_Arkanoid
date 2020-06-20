using System;
using System.Windows.Forms;

namespace Covid_19_Arkanoid.Vista
{
    public partial class Username : Form
    {
        private readonly FormMain _parent;
        public Username(FormMain formMain)
        {
            _parent = formMain;
            InitializeComponent();
        }

        private void Username_Load(object sender, EventArgs e)
        {
            //Se maximiza la ventana y se agrega el userControl que solicita nombre de usuario
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;

            nameUser1.Dock = DockStyle.Fill;
            Controls.Add(nameUser1);
        }

        private void Username_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Show();
        }
    }
}