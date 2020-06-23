using System;
using System.Drawing;
using System.Windows.Forms;
using Covid_19_Arkanoid.Controlador;

namespace Covid_19_Arkanoid.Vista
{
    public partial class TopTen : Form
    {
        private readonly FormMain _parent;
        public TopTen(FormMain formMain)
        {
            _parent = formMain;
            InitializeComponent();
            dgvTop10.DataSource = null;
        }
        
        private void TopTen_Load(object sender, EventArgs e)
        {
            //Se asigna el fondo , se maximiza la ventana y se obtiene el top 10 de la base de datos
            BackgroundImage = Image.FromFile("../../Resources/Top101.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
            
            dgvTop10.DataSource = PlayerDao.GetTop10PlayersTable();
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        
        private void TopTen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Show();
        }

        private void TopTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                throw new ClickLeftBoardException("Close the top 10 window to return to the menu.");
            }
            catch (ClickLeftBoardException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void TlpTop10_Click(object sender, EventArgs e)
        {
            try
            {
                throw new ClickLeftBoardException("Close the top 10 window to return to the menu.");
            }
            catch (ClickLeftBoardException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}