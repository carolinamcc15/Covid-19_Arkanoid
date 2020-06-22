using System;
using System.Drawing;
using System.Windows.Forms;
using Covid_19_Arkanoid.Controlador;
using Covid_19_Arkanoid.Modelo;

namespace Covid_19_Arkanoid.Vista
{
    public partial class Username : UserControl
    { 
        public Username()
        {
            InitializeComponent();
        }
        
        private void NameUser_Load(object sender, EventArgs e)
        {
            //Se asigna la imagen de fondo
            tlpChoose.BackgroundImage = Image.FromFile("../../Resources/User.png");;
            tlpChoose.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    throw new EnterKeyPressException("Press DONE button.");
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
                if (!txtUsername.Text.Trim().Equals("") && !(txtUsername.Text.Length > 20))
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
                    if (txtUsername.Text.Trim().Length != 0)
                        throw new UsernameLengthException("Nickname too long.\nMax length: 20 digits.");
                    throw new EmptyNameException("Write a nickname.");
                }
            }
            catch (EmptyNameException ex)
            {
                MessageBox.Show(ex.Message, "ARKANOID", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (UsernameLengthException ex)
            {
                MessageBox.Show(ex.Message, "ARKANOID", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                // Limpia el textBox para quitar los espacios.
                txtUsername.Clear();
            }
        }
    }
}