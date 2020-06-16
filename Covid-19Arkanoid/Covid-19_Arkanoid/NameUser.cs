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

        private void BtnDoneU_Click(object sender, EventArgs e)
        {
            if (!txtUsername.Text.Equals(""))
            {
                List<Player> players = new List<Player>();
                players = PlayerDAO.GetPlayers();
                
                Player current = new Player();
                byte a = 0;
                
                foreach(var pl in players)
                {
                    if (string.Equals(pl.Name, txtUsername.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        a = 1;
                        MessageBox.Show("Welcome back!", "ARKANOID", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        current = pl;
                    }
                }

                if (a == 0)
                {
                    PlayerDAO.InsertPlayer(txtUsername.Text);
                    MessageBox.Show("User registered successfully!", "ARKANOID", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                    players = PlayerDAO.GetPlayers();
                    
                    foreach(var pl in players)
                    {
                        if (pl.Name.Equals(txtUsername.Text))
                        {
                            current = pl;
                        }
                    }
                }

                Hide();
                
                Skin s = new Skin(txtUsername.Text, current.PlayerId);
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