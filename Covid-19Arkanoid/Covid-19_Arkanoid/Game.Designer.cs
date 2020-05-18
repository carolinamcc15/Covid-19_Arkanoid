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
            this.tlpGame = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpGame
            // 
            this.tlpGame.BackColor = System.Drawing.Color.Black;
            this.tlpGame.BackgroundImage = global::Covid_19_Arkanoid.Properties.Resources.CroppedGame;
            this.tlpGame.ColumnCount = 2;
            this.tlpGame.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGame.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGame.Location = new System.Drawing.Point(0, 0);
            this.tlpGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpGame.Name = "tlpGame";
            this.tlpGame.RowCount = 2;
            this.tlpGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGame.Size = new System.Drawing.Size(711, 475);
            this.tlpGame.TabIndex = 0;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Covid_19_Arkanoid.Properties.Resources.CroppedGame1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tlpGame);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(711, 475);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGame;
    }
}