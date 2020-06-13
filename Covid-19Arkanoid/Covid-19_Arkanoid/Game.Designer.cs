using System;
using System.ComponentModel;

namespace Covid_19_Arkanoid
{
    partial class Game
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerArkanoid = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerArkanoid
            // 
            this.timerArkanoid.Interval = 10;
            this.timerArkanoid.Tick += new System.EventHandler(this.timerArkanoid_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Covid_19_Arkanoid.Properties.Resources.GameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(1153, 749);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Click += new System.EventHandler(this.Game_Click);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerArkanoid;
    }
}