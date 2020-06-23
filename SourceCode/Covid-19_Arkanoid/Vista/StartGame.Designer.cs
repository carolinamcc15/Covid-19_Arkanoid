using System.ComponentModel;

namespace Covid_19_Arkanoid.Vista
{
      partial class StartGame
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(StartGame));
            this.nameUser1 = new Covid_19_Arkanoid.Vista.Username();
            this.SuspendLayout();
            // 
            // nameUser1
            // 
            this.nameUser1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nameUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameUser1.Location = new System.Drawing.Point(0, 0);
            this.nameUser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameUser1.Name = "nameUser1";
            this.nameUser1.Size = new System.Drawing.Size(1132, 693);
            this.nameUser1.TabIndex = 0;
            // 
            // Username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 693);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "StartGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARKANOID";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartGame_FormClosing);
            this.Load += new System.EventHandler(this.StartGame_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private Covid_19_Arkanoid.Vista.Username nameUser1;
    }
}