﻿using System;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class Username : Form
    {
        public UserControl current;
        public Skin sk = new Skin();
      
        public Username()
        {
            InitializeComponent();
            current = nameUser1;
            sk.Dock = DockStyle.Fill;
        }

        private void Username_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
        }
        
    }
}