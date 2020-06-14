using System;
using System.Collections.Generic;
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
                List<Player> players = new List<Player>();
                players = PlayerDAO.GetPlayers();
                
                Player current = new Player();
                
                foreach(var pl in players)
                {
                    if (pl.Name.Equals(txtUsername.Text))
                    {
                        MessageBox.Show("Already registered.", "ARKANOID", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        current = pl;
                    }
                    else
                    {
                        MessageBox.Show("No implementado aún.");
                    }
                }
                //PlayerDAO.InsertPlayer(txtUsername.Text);
                Hide();
                Skin s = new Skin(txtUsername.Text, current.playerID);
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