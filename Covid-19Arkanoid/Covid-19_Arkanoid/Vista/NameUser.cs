using System;
using System.Drawing;
using System.Windows.Forms;
using Covid_19_Arkanoid.Controlador;
using Covid_19_Arkanoid.Modelo;

namespace Covid_19_Arkanoid.Vista
{
    public partial class NameUser : UserControl
    { 
        public NameUser()
        {
            InitializeComponent();
        }
        
        private void NameUser_Load(object sender, EventArgs e)
        {
            //Se asigna la imagen de fondo
            tlpChoose.BackgroundImage = Image.FromFile("../../Resources/User.png");;
            tlpChoose.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    throw new EnterKeyPressException("Presione el boton DONE");
                }
            }
            catch (EnterKeyPressException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            try
            {
                //Si el nombre ingresado no está vacío
                if (!txtUsername.Text.Trim().Equals(""))
                {
                    Player currentPlayer = PlayerDAO.CurrentPlayer(txtUsername.Text.ToUpper().Trim());
                    if (currentPlayer.PlayerId == 0)
                    {
                        MessageBox.Show("User registered successfully!", "ARKANOID", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        currentPlayer.PlayerId = PlayerDAO.GetID(currentPlayer.Name);
                    }
                    else 
                        MessageBox.Show("Welcome back!", "ARKANOID", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    Hide();
                
                    Skin skin = new Skin(currentPlayer);
                    skin.Dock = DockStyle.Fill;
                    Parent.Controls.Add(skin);
                    
                    Parent.Controls.Remove(this);
                }
                else
                {
                    txtUsername.Clear(); // Limpia el textBox para quitar los espacios.
                    throw new EmptyNameException("Escriba un nombre.");
                }
            }
            catch (EmptyNameException exception)
            {
                MessageBox.Show(exception.Message, "ARKANOID", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }
    }
}