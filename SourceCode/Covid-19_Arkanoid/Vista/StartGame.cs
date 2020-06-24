using System;
using System.Media;
using System.Windows.Forms;

namespace Covid_19_Arkanoid.Vista
{
    public partial class StartGame : Form
    {
        private readonly FormMain _parent;

        public StartGame(FormMain formMain)
        {
            _parent = formMain;
            InitializeComponent();
        }

        private void StartGame_Load(object sender, EventArgs e)
        {
            //Se maximiza la ventana y se agrega el userControl que solicita nombre de usuario
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;

            Username user = new Username();
            user.Dock = DockStyle.Fill;
            Controls.Add(user);
        }

        private void StartGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Se detiene la música cuando se cierra la ventana
            new SoundPlayer().Stop();
            _parent.Show();
        }
    }
}